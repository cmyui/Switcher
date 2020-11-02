namespace Switcher {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dcBox = new System.Windows.Forms.PictureBox();
            this.ytBox = new System.Windows.Forms.PictureBox();
            this.helpLabel = new System.Windows.Forms.Label();
            this.ipBoxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dcBoxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ytBoxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.newsBox = new System.Windows.Forms.RichTextBox();
            this.sysTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.localhostButton = new Switcher.NotAnnoyingCheckBox();
            this.ipBox = new Switcher.NotAnnoyingTextBox();
            this.switchButton = new Switcher.NotAnnoyingCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dcBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dcBox
            // 
            this.dcBox.BackColor = System.Drawing.Color.Transparent;
            this.dcBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dcBox.Image = global::Switcher.Properties.Resources.dc;
            this.dcBox.Location = new System.Drawing.Point(34, 59);
            this.dcBox.Name = "dcBox";
            this.dcBox.Size = new System.Drawing.Size(24, 22);
            this.dcBox.TabIndex = 2;
            this.dcBox.TabStop = false;
            this.dcBox.Click += new System.EventHandler(this.dcBox_Click);
            // 
            // ytBox
            // 
            this.ytBox.BackColor = System.Drawing.Color.Transparent;
            this.ytBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ytBox.Image = global::Switcher.Properties.Resources.yt;
            this.ytBox.Location = new System.Drawing.Point(5, 62);
            this.ytBox.Name = "ytBox";
            this.ytBox.Size = new System.Drawing.Size(24, 18);
            this.ytBox.TabIndex = 3;
            this.ytBox.TabStop = false;
            this.ytBox.Click += new System.EventHandler(this.ytBox_Click);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.BackColor = System.Drawing.Color.Transparent;
            this.helpLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.ForeColor = System.Drawing.Color.Red;
            this.helpLabel.Location = new System.Drawing.Point(60, 59);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(53, 21);
            this.helpLabel.TabIndex = 4;
            this.helpLabel.Text = "<- help";
            // 
            // ipBoxToolTip
            // 
            this.ipBoxToolTip.AutoPopDelay = 5000;
            this.ipBoxToolTip.InitialDelay = 250;
            this.ipBoxToolTip.ReshowDelay = 100;
            // 
            // dcBoxToolTip
            // 
            this.dcBoxToolTip.AutoPopDelay = 5000;
            this.dcBoxToolTip.InitialDelay = 250;
            this.dcBoxToolTip.ReshowDelay = 100;
            // 
            // ytBoxToolTip
            // 
            this.ytBoxToolTip.AutoPopDelay = 5000;
            this.ytBoxToolTip.InitialDelay = 250;
            this.ytBoxToolTip.ReshowDelay = 100;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // newsBox
            // 
            this.newsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.newsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newsBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.newsBox.ForeColor = System.Drawing.SystemColors.Window;
            this.newsBox.Location = new System.Drawing.Point(8, 98);
            this.newsBox.Margin = new System.Windows.Forms.Padding(0);
            this.newsBox.Name = "newsBox";
            this.newsBox.ReadOnly = true;
            this.newsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.newsBox.Size = new System.Drawing.Size(298, 77);
            this.newsBox.TabIndex = 5;
            this.newsBox.Text = "";
            // 
            // sysTray
            // 
            this.sysTray.BalloonTipText = "To re-open, double-click the icon";
            this.sysTray.BalloonTipTitle = "Switcher minimized to system tray";
            this.sysTray.Icon = ((System.Drawing.Icon)(resources.GetObject("sysTray.Icon")));
            this.sysTray.Text = "o!A Switcher\r\nCurrently: Unspec";
            this.sysTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sysTray_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.switchButton);
            this.panel1.Controls.Add(this.helpLabel);
            this.panel1.Controls.Add(this.dcBox);
            this.panel1.Controls.Add(this.ytBox);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 87);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lemon/Milk", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "User settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lemon/Milk", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Developer settings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.localhostButton);
            this.panel2.Controls.Add(this.ipBox);
            this.panel2.Location = new System.Drawing.Point(163, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 87);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(118, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "↺";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // localhostButton
            // 
            this.localhostButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.localhostButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.localhostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.localhostButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.localhostButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localhostButton.Location = new System.Drawing.Point(3, 25);
            this.localhostButton.Name = "localhostButton";
            this.localhostButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.localhostButton.shouldRaise = true;
            this.localhostButton.Size = new System.Drawing.Size(135, 31);
            this.localhostButton.TabIndex = 0;
            this.localhostButton.Text = "Use Localhost";
            this.localhostButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.localhostButton.UseVisualStyleBackColor = false;
            this.localhostButton.CheckedChanged += new System.EventHandler(this.localhostButton_CheckedChanged);
            // 
            // ipBox
            // 
            this.ipBox.BackColor = System.Drawing.Color.DarkGray;
            this.ipBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ipBox.Location = new System.Drawing.Point(3, 62);
            this.ipBox.MaxLength = 15;
            this.ipBox.Name = "ipBox";
            this.ipBox.shouldRaise = true;
            this.ipBox.Size = new System.Drawing.Size(135, 17);
            this.ipBox.TabIndex = 1;
            this.ipBox.Text = "123.456.789.420";
            this.ipBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipBox.TextChanged += new System.EventHandler(this.ipBox_TextChanged);
            // 
            // switchButton
            // 
            this.switchButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.switchButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.switchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.switchButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchButton.Location = new System.Drawing.Point(5, 25);
            this.switchButton.Name = "switchButton";
            this.switchButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.switchButton.shouldRaise = true;
            this.switchButton.Size = new System.Drawing.Size(136, 31);
            this.switchButton.TabIndex = 0;
            this.switchButton.Text = "Currently: Unspec";
            this.switchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchButton.UseVisualStyleBackColor = false;
            this.switchButton.CheckedChanged += new System.EventHandler(this.switchButton_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(314, 182);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newsBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "osu!Akatsuki Switcher v1.2.3.4";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dcBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NotAnnoyingCheckBox switchButton;
        private NotAnnoyingTextBox ipBox;
        private System.Windows.Forms.PictureBox dcBox;
        private System.Windows.Forms.PictureBox ytBox;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.ToolTip ipBoxToolTip;
        private System.Windows.Forms.ToolTip dcBoxToolTip;
        private System.Windows.Forms.ToolTip ytBoxToolTip;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox newsBox;
        private System.Windows.Forms.NotifyIcon sysTray;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private NotAnnoyingCheckBox localhostButton;
        private System.Windows.Forms.Button button1;
    }
}
