using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Diagnostics;
using Switcher.Properties;

// maybe a bit sloppy, first c# project xd

namespace Switcher {

    public partial class MainForm : Form {
        string hostsFile = $@"{Environment.SystemDirectory}\drivers\etc\hosts";
        string settingsFile = $@"{Application.UserAppDataPath}\settings.db";
        string fetchIPUrl = "https://akatsuki.pw/static/ip/new_ip.txt";

        // note: only (osu|a|i|c([4-6]|e)?) are used in 2020 (and we'll only write those),
        // we'll keep the others to keep other switchers from mucking up our hosts file.
        Regex EntryRegex = new Regex(@"^(?:\d{1,3}\.){3}\d{1,3}[\t ]+(?:osu|a|s|i|c(?:[1-6]|e)?)\.ppy\.sh$");
        Regex IPRegex = new Regex(@"^(?:\d{1,3}\.){3}\d{1,3}$");

        bool switched = false;

        // ip the server is set to
        string currentIP = null;

        // data from the server
        string akatsukiIP = "144.217.254.156";
        string akatsukiCertName = "TheHangout";
        string akatsukiNews = null;

        public MainForm() {
            if (!AdminPrivs()) {
                // make sure we're running the program as admin, since
                // it's required for some of the things we have to do.
                MessageBox.Show(
                    "The switcher edits a system file (hosts), and installs a certificate " +
                    "under trusted root; and therefore must be run as administrator.\n\n" +
                    "You can configure the switcher to automatically open with administrative " +
                    "privileges in the right-click menu under Properties -> Compatability."
                );
                Dispose();
            }

            // set our cwd for easy access to the hosts file
            if (File.Exists(hostsFile)) {
                // our hosts file exists, check whether
                // the user is actually switched already
                CheckSwitched(out switched);
            } else {
                // our hosts file doesn't exist, create it
                // this also means we're not currently switched!
                using (File.Create(hostsFile)) { };
                switched = false;
            }

            // check for & install cert if missing
            InstallCertificate(Resources.ca);

            // fetch the latest ip from the server
            FetchLatestInformation(out akatsukiIP, out akatsukiCertName, out akatsukiNews);

            // check if we have settings
            if (File.Exists(settingsFile))
                // use ip from settings file
                ReadSettings(out currentIP);
            else
                // use ip from akatsuki server
                currentIP = akatsukiIP;

            // init gui
            InitializeComponent();

            Text = $"o!A Switcher v{Application.ProductVersion}";
            ipBox.SetNoRaise(currentIP);

            // tooltips
            ipBoxToolTip.ToolTipTitle = "Customizable server IP";
            ipBoxToolTip.SetToolTip(ipBox, "When changed, this IP will change the IP the switcher points to.\r\n" +
                                           "Removing the text in the box will revert to the official Akatsuki IP.");

            dcBoxToolTip.ToolTipTitle = "Official osu!Akatsuki Discord";
            dcBoxToolTip.SetToolTip(dcBox, "A link to our Discord, where our community is active.\r\n" +
                                           "For connection help, check the #faq channel (~90% chance it'll have your issue),\r\n" +
                                           "but if not, someone will help you out in the #help channel.");

            ytBoxToolTip.ToolTipTitle = "Official osu!Akatsuki YouTube";
            ytBoxToolTip.SetToolTip(ytBox, "A link to our YouTube channel, where the best of the community is uploaded.");

            newsBox.Text = akatsukiNews;

            string currentTxt;

            if (switched) {
                if (currentIP == akatsukiIP) {
                    currentTxt = "Akatsuki";
                } else if (currentIP == "127.0.0.1") {
                    currentTxt = "Localhost";
                    localhostButton.SetNoRaise(true);
                } else {
                    currentTxt = "Custom IP";
                }
            } else {
                currentTxt = "osu!";
            }

            // these events must be added after text set so we don't switch
            // todo: perhaps think of a better solution for this? lol..
            switchButton.Text = $"Currently: {currentTxt}";

            switchButton.SetNoRaise(switched);

            sysTray.Text = $"o!A Switcher\r\nCurrently: {currentTxt}";
        }

        /* utility functions */

        public bool AdminPrivs() {
            using (var identity = WindowsIdentity.GetCurrent()) {
                var principal = new WindowsPrincipal(identity);

                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        public void SaveSettings() {
            if (!File.Exists(settingsFile)) {
                // settings file doesn't exist, create it.
                using (File.Create(settingsFile)) { };
            }

            using (var sw = new StreamWriter(settingsFile)) {
                // more will probably be added to the settings
                // file over time, but for now, just the ip.
                sw.Write($"{currentIP}");
            }
        }

        public void ReadSettings(out string ip) {
            using (var sr = new StreamReader(settingsFile)) {
                // more will probably be added to the settings
                // file over time, but for now, just the ip.
                ip = sr.ReadToEnd();
            }
        }

        public void InstallCertificate(byte[] cert) {
            using (var store = new X509Store(StoreName.Root, StoreLocation.LocalMachine)) {
                // open with read & write perms
                store.Open(OpenFlags.ReadWrite);

                // search for akatsuki's cert
                var certs = store.Certificates.Find(X509FindType.FindBySubjectName, akatsukiCertName, false);

                // if no certs are found, install it
                if (certs.Count == 0)
                    store.Add(new X509Certificate2(cert));
            }
        }

        public void CheckSwitched(out bool found) {
            // open the hosts file up and check for
            // *.ppy.sh rewrites matching our regex

            using (StreamReader sr = File.OpenText(hostsFile)) {
                string s;

                while ((s = sr.ReadLine()) != null) {
                    if (EntryRegex.IsMatch(s)) {
                        found = true;
                        return;
                    }
                }

                // no lines matched the regex
                found = false;
            }
        }

        public void FetchLatestInformation(out string ip, out string cert, out string news) {
            // perform a web request to get the latest ip
            HttpWebRequest req = WebRequest.CreateHttp(fetchIPUrl);

            req.Timeout = 500;
            string data = null;

            try {
                using (var resp = (HttpWebResponse)req.GetResponse()) {
                    if (resp.StatusCode != (HttpStatusCode)200)
                        throw new WebException($"HTTP {resp.StatusCode}");

                    using (var sr = new StreamReader(resp.GetResponseStream()))
                        data = sr.ReadToEnd().TrimEnd('\r', '\n');
                }
            } catch (WebException) {
                ip = akatsukiIP;
                cert = akatsukiCertName;
                news = "Could not fetch updates from server.";
                return;
            }

            var s = data.Split(new char[] { '\n' }, 3, StringSplitOptions.None);

            if (s.Length == 3 && IPRegex.IsMatch(s[0])) {
                // request parsed successfully, read vals
                ip = s[0];
                cert = s[1];
                news = s[2];
            } else {
                // request data is invalid, use default
                ip = akatsukiIP;
                cert = akatsukiCertName;
                news = "Could not fetch updates from server.";
            }
        }

        public void EmptyHosts() {
            var lines = new List<string>();

            // iterate through file and keep
            // all non-ppy.sh related lines
            using (var sr = File.OpenText(hostsFile)) {
                string s;

                while ((s = sr.ReadLine()) != null) {
                    if (!EntryRegex.IsMatch(s)) {
                        lines.Add(s);
                    }
                }
            }

            // now overwrite the file with the lines we read
            using (var sw = new StreamWriter(hostsFile)) {
                foreach (string s in lines) {
                    sw.WriteLine(s);
                }
            }
        }

        public void WriteHosts() {
            using (var sw = File.AppendText(hostsFile)) {
                sw.WriteLine($"{currentIP}\tosu.ppy.sh"); // web/* handlers
                sw.WriteLine($"{currentIP}\ta.ppy.sh"); // avatars
                sw.WriteLine($"{currentIP}\ti.ppy.sh"); // images (main menu icon for example)

                // bancho connections
                sw.WriteLine($"{currentIP}\tc.ppy.sh");
                sw.WriteLine($"{currentIP}\tce.ppy.sh");
                for (int n = 4; n < 7; n++) //c[4-6]
                    sw.WriteLine($"{currentIP}\tc{n}.ppy.sh");
            }
        }

        /* event handlers */

        private void switchButton_CheckedChanged(object sender, EventArgs e) {
            string currentTxt;

            if (!switched) {
                if (currentIP == akatsukiIP) {
                    currentTxt = "Akatsuki";
                } else if (currentIP == "127.0.0.1") {
                    currentTxt = "Localhost";
                } else {
                    currentTxt = "Custom IP";
                }
            } else {
                currentTxt = "osu!";
            }

            switchButton.Text = $"Currently: {currentTxt}";
            sysTray.Text = $"o!A Switcher\r\nCurrently: {currentTxt}";

            if (switched)
                // switch back to osu!
                EmptyHosts();
            else {
                // switch to private server
                SaveSettings();
                WriteHosts();
            }

            switched = !switched;
        }

        private void ipBox_TextChanged(object sender, EventArgs e) {
            // todo: maaaybe update settings & hosts immediately on change?

            if (ipBox.Text == "") {
                ipBox.SetNoRaise(akatsukiIP);
                currentIP = akatsukiIP;

                ipBox.BackColor = Color.White;

                // update to our settings file
                SaveSettings();
            } else {
                currentIP = ipBox.Text;

                if (IPRegex.IsMatch(currentIP)) {
                    // match
                    ipBox.BackColor = Color.White;
                    if (!switchButton.Enabled)
                        switchButton.Enabled = true;
                } else {
                    // not match, disable switch button
                    ipBox.BackColor = Color.FromArgb(0xFF, 0xFF, 0xB0, 0xB0);
                    if (switchButton.Enabled)
                        switchButton.Enabled = false;
                }
                // colour the background redish if ip is invalid
                ipBox.BackColor = IPRegex.IsMatch(currentIP)
                    ? Color.White
                    : Color.FromArgb(0xFF, 0xFF, 0xB0, 0xB0);
            }

            localhostButton.SetNoRaise(false);
        }

        /* socials */

        private void ytBox_Click(object sender, EventArgs e) =>
            Process.Start("https://www.youtube.com/channel/UCjf8Fx_BlUr-htEy6hficcQ");

        private void dcBox_Click(object sender, EventArgs e) =>
            Process.Start("https://akatsuki.pw/discord");

        /* minimize to systray */

        private void MainForm_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                Hide();

                sysTray.Visible = true;
                sysTray.ShowBalloonTip(1000); // notify the user we've minimized to systray
            }
        }

        private void sysTray_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
            sysTray.Visible = false;
        }

        private void localhostButton_CheckedChanged(object sender, EventArgs e) {
            string currentTxt;

            if (currentIP == "127.0.0.1") {
                // localhost -> akatsuki
                currentIP = akatsukiIP;
                currentTxt = "Akatsuki";
            } else {
                // (custom|akatsuki) -> localhost
                currentIP = "127.0.0.1";
                currentTxt = "Localhost";
            }

            switchButton.Text = $"Currently: {currentTxt}";
            sysTray.Text = $"o!A Switcher\r\nCurrently: {currentTxt}";

            ipBox.SetNoRaise(currentIP);

            ipBox.BackColor = Color.White;
            switchButton.Enabled = true;

            if (switched) {
                EmptyHosts();
                WriteHosts();
            }
        }
    }

    public class NotAnnoyingTextBox : TextBox {
        public bool shouldRaise { get; set; } = true;

        public void SetNoRaise(string value) {
            bool origin = shouldRaise;
            if (shouldRaise)
                shouldRaise = false;

            Text = value;
            shouldRaise = origin;
        }

        protected override void OnTextChanged(EventArgs e) {
            if (shouldRaise)
                base.OnTextChanged(e);
        }
    }
    public class NotAnnoyingCheckBox : CheckBox {
        public bool shouldRaise { get; set; } = true;

        public void SetNoRaise(bool value) {
            if (Checked == value)
                return;

            bool origin = shouldRaise;
            if (shouldRaise)
                shouldRaise = false;

            Checked = value;
            shouldRaise = origin;
        }

        protected override void OnCheckedChanged(EventArgs e) {
            if (shouldRaise)
                base.OnCheckedChanged(e);
        }
    };
}
