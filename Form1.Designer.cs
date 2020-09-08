namespace Switcher {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.switchButton = new System.Windows.Forms.CheckBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.dcBox = new System.Windows.Forms.PictureBox();
            this.ytBox = new System.Windows.Forms.PictureBox();
            this.helpLabel = new System.Windows.Forms.Label();
            this.ipBoxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dcBoxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ytBoxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.newsBox = new System.Windows.Forms.RichTextBox();
            this.sysTray = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dcBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytBox)).BeginInit();
            this.SuspendLayout();
            //
            // switchButton
            //
            this.switchButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.switchButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.switchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.switchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.switchButton.Location = new System.Drawing.Point(244, 10);
            this.switchButton.Name = "switchButton";
            this.switchButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.switchButton.Size = new System.Drawing.Size(128, 31);
            this.switchButton.TabIndex = 0;
            this.switchButton.Text = "Currently: Unspec";
            this.switchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchButton.UseVisualStyleBackColor = false;
            //
            // ipBox
            //
            this.ipBox.BackColor = System.Drawing.Color.DarkGray;
            this.ipBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ipBox.Location = new System.Drawing.Point(244, 47);
            this.ipBox.MaxLength = 15;
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(128, 20);
            this.ipBox.TabIndex = 1;
            this.ipBox.Text = "123.456.789.420";
            this.ipBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipBox.TextChanged += new System.EventHandler(this.ipBox_TextChanged);
            //
            // dcBox
            //
            this.dcBox.BackColor = System.Drawing.Color.Transparent;
            this.dcBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dcBox.Image = global::Switcher.Properties.Resources.dc;
            this.dcBox.Location = new System.Drawing.Point(273, 70);
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
            this.ytBox.Location = new System.Drawing.Point(244, 73);
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
            this.helpLabel.Location = new System.Drawing.Point(299, 70);
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
            this.newsBox.Location = new System.Drawing.Point(12, 12);
            this.newsBox.Margin = new System.Windows.Forms.Padding(0);
            this.newsBox.Name = "newsBox";
            this.newsBox.ReadOnly = true;
            this.newsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.newsBox.Size = new System.Drawing.Size(221, 79);
            this.newsBox.TabIndex = 5;
            this.newsBox.Text = resources.GetString("newsBox.Text");
            //
            // sysTray
            //
            this.sysTray.BalloonTipText = "To re-open, double-click the icon";
            this.sysTray.BalloonTipTitle = "Switcher minimized to system tray";
            this.sysTray.Icon = ((System.Drawing.Icon)(resources.GetObject("sysTray.Icon")));
            this.sysTray.Text = "o!A Switcher\r\nCurrently: Unspec";
            this.sysTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sysTray_MouseDoubleClick);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(381, 98);
            this.Controls.Add(this.newsBox);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.ytBox);
            this.Controls.Add(this.dcBox);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.switchButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "osu!Akatsuki Switcher v1.2.3.4";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dcBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox switchButton;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.PictureBox dcBox;
        private System.Windows.Forms.PictureBox ytBox;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.ToolTip ipBoxToolTip;
        private System.Windows.Forms.ToolTip dcBoxToolTip;
        private System.Windows.Forms.ToolTip ytBoxToolTip;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox newsBox;
        private System.Windows.Forms.NotifyIcon sysTray;
    }
}
