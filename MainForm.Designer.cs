namespace Twitch_to_Facebook
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.streamlink_test = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetStreamLinkbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UnSetFFMPEGbutton = new System.Windows.Forms.Button();
            this.SetFFMPEGbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ffmpeg_test = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.facebook = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.twitch = new System.Windows.Forms.TextBox();
            this.fileOpen = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.samplingrate = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.VersiontoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.DownloadFFMPEGbutton = new System.Windows.Forms.Button();
            this.UnSetStreamLinkbutton = new System.Windows.Forms.Button();
            this.DownloadStreamLinkbutton = new System.Windows.Forms.Button();
            this.Startbutton = new System.Windows.Forms.Button();
            this.HideKeycheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // streamlink_test
            // 
            this.streamlink_test.AutoSize = true;
            this.streamlink_test.Location = new System.Drawing.Point(52, 86);
            this.streamlink_test.Name = "streamlink_test";
            this.streamlink_test.Size = new System.Drawing.Size(31, 13);
            this.streamlink_test.TabIndex = 2;
            this.streamlink_test.Text = "- na -";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnSetStreamLinkbutton);
            this.groupBox1.Controls.Add(this.SetStreamLinkbutton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DownloadStreamLinkbutton);
            this.groupBox1.Controls.Add(this.streamlink_test);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Streamlink";
            // 
            // SetStreamLinkbutton
            // 
            this.SetStreamLinkbutton.Image = global::Twitch_to_Facebook.Properties.Resources.add;
            this.SetStreamLinkbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetStreamLinkbutton.Location = new System.Drawing.Point(101, 54);
            this.SetStreamLinkbutton.Name = "SetStreamLinkbutton";
            this.SetStreamLinkbutton.Size = new System.Drawing.Size(82, 29);
            this.SetStreamLinkbutton.TabIndex = 2;
            this.SetStreamLinkbutton.Text = "set";
            this.SetStreamLinkbutton.UseVisualStyleBackColor = true;
            this.SetStreamLinkbutton.Click += new System.EventHandler(this.SetStreamLinkbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UnSetFFMPEGbutton);
            this.groupBox2.Controls.Add(this.SetFFMPEGbutton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DownloadFFMPEGbutton);
            this.groupBox2.Controls.Add(this.ffmpeg_test);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 112);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FFMPEG";
            // 
            // UnSetFFMPEGbutton
            // 
            this.UnSetFFMPEGbutton.Image = global::Twitch_to_Facebook.Properties.Resources.delete;
            this.UnSetFFMPEGbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UnSetFFMPEGbutton.Location = new System.Drawing.Point(6, 54);
            this.UnSetFFMPEGbutton.Name = "UnSetFFMPEGbutton";
            this.UnSetFFMPEGbutton.Size = new System.Drawing.Size(82, 29);
            this.UnSetFFMPEGbutton.TabIndex = 3;
            this.UnSetFFMPEGbutton.Text = "unset";
            this.UnSetFFMPEGbutton.UseVisualStyleBackColor = true;
            this.UnSetFFMPEGbutton.Click += new System.EventHandler(this.UnSetFFMPEGbutton_Click);
            // 
            // SetFFMPEGbutton
            // 
            this.SetFFMPEGbutton.Image = global::Twitch_to_Facebook.Properties.Resources.add;
            this.SetFFMPEGbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetFFMPEGbutton.Location = new System.Drawing.Point(101, 54);
            this.SetFFMPEGbutton.Name = "SetFFMPEGbutton";
            this.SetFFMPEGbutton.Size = new System.Drawing.Size(82, 29);
            this.SetFFMPEGbutton.TabIndex = 2;
            this.SetFFMPEGbutton.Text = "set";
            this.SetFFMPEGbutton.UseVisualStyleBackColor = true;
            this.SetFFMPEGbutton.Click += new System.EventHandler(this.SetFFMPEGbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            // 
            // ffmpeg_test
            // 
            this.ffmpeg_test.AutoSize = true;
            this.ffmpeg_test.Location = new System.Drawing.Point(71, 86);
            this.ffmpeg_test.Name = "ffmpeg_test";
            this.ffmpeg_test.Size = new System.Drawing.Size(31, 13);
            this.ffmpeg_test.TabIndex = 2;
            this.ffmpeg_test.Text = "- na -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Facebook key:";
            // 
            // facebook
            // 
            this.facebook.Location = new System.Drawing.Point(15, 282);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(596, 20);
            this.facebook.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Twitch:";
            // 
            // twitch
            // 
            this.twitch.Location = new System.Drawing.Point(15, 327);
            this.twitch.Name = "twitch";
            this.twitch.Size = new System.Drawing.Size(117, 20);
            this.twitch.TabIndex = 11;
            // 
            // fileOpen
            // 
            this.fileOpen.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sampling rate:";
            // 
            // samplingrate
            // 
            this.samplingrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.samplingrate.FormattingEnabled = true;
            this.samplingrate.Items.AddRange(new object[] {
            "44100",
            "48000",
            "22050"});
            this.samplingrate.Location = new System.Drawing.Point(12, 373);
            this.samplingrate.Name = "samplingrate";
            this.samplingrate.Size = new System.Drawing.Size(88, 21);
            this.samplingrate.TabIndex = 14;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VersiontoolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 468);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(645, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 15;
            this.statusStrip.Text = "statusStrip1";
            // 
            // VersiontoolStripStatusLabel
            // 
            this.VersiontoolStripStatusLabel.Name = "VersiontoolStripStatusLabel";
            this.VersiontoolStripStatusLabel.Size = new System.Drawing.Size(630, 17);
            this.VersiontoolStripStatusLabel.Spring = true;
            this.VersiontoolStripStatusLabel.Text = "Version: 1.0.0.0";
            // 
            // Helpbutton
            // 
            this.Helpbutton.Image = global::Twitch_to_Facebook.Properties.Resources.help;
            this.Helpbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Helpbutton.Location = new System.Drawing.Point(12, 412);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(102, 48);
            this.Helpbutton.TabIndex = 12;
            this.Helpbutton.Text = "Get help";
            this.Helpbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Helpbutton.UseVisualStyleBackColor = true;
            this.Helpbutton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // DownloadFFMPEGbutton
            // 
            this.DownloadFFMPEGbutton.Image = global::Twitch_to_Facebook.Properties.Resources.download_cloud;
            this.DownloadFFMPEGbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DownloadFFMPEGbutton.Location = new System.Drawing.Point(6, 19);
            this.DownloadFFMPEGbutton.Name = "DownloadFFMPEGbutton";
            this.DownloadFFMPEGbutton.Size = new System.Drawing.Size(114, 29);
            this.DownloadFFMPEGbutton.TabIndex = 1;
            this.DownloadFFMPEGbutton.Text = "download";
            this.DownloadFFMPEGbutton.UseVisualStyleBackColor = true;
            this.DownloadFFMPEGbutton.Click += new System.EventHandler(this.DownloadFFMPEGbutton_Click);
            // 
            // UnSetStreamLinkbutton
            // 
            this.UnSetStreamLinkbutton.Image = global::Twitch_to_Facebook.Properties.Resources.delete;
            this.UnSetStreamLinkbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UnSetStreamLinkbutton.Location = new System.Drawing.Point(6, 54);
            this.UnSetStreamLinkbutton.Name = "UnSetStreamLinkbutton";
            this.UnSetStreamLinkbutton.Size = new System.Drawing.Size(82, 29);
            this.UnSetStreamLinkbutton.TabIndex = 3;
            this.UnSetStreamLinkbutton.Text = "unset";
            this.UnSetStreamLinkbutton.UseVisualStyleBackColor = true;
            this.UnSetStreamLinkbutton.Click += new System.EventHandler(this.UnSetStreamLinkbutton_Click);
            // 
            // DownloadStreamLinkbutton
            // 
            this.DownloadStreamLinkbutton.Image = global::Twitch_to_Facebook.Properties.Resources.download_cloud;
            this.DownloadStreamLinkbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DownloadStreamLinkbutton.Location = new System.Drawing.Point(6, 19);
            this.DownloadStreamLinkbutton.Name = "DownloadStreamLinkbutton";
            this.DownloadStreamLinkbutton.Size = new System.Drawing.Size(114, 29);
            this.DownloadStreamLinkbutton.TabIndex = 1;
            this.DownloadStreamLinkbutton.Text = "download";
            this.DownloadStreamLinkbutton.UseVisualStyleBackColor = true;
            this.DownloadStreamLinkbutton.Click += new System.EventHandler(this.DownloadStreamLinkbutton_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.Image = global::Twitch_to_Facebook.Properties.Resources.lightning;
            this.Startbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Startbutton.Location = new System.Drawing.Point(501, 412);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(132, 48);
            this.Startbutton.TabIndex = 4;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // HideKeycheckBox
            // 
            this.HideKeycheckBox.AutoSize = true;
            this.HideKeycheckBox.Location = new System.Drawing.Point(617, 285);
            this.HideKeycheckBox.Name = "HideKeycheckBox";
            this.HideKeycheckBox.Size = new System.Drawing.Size(15, 14);
            this.HideKeycheckBox.TabIndex = 16;
            this.HideKeycheckBox.UseVisualStyleBackColor = true;
            this.HideKeycheckBox.CheckedChanged += new System.EventHandler(this.HideKeycheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(645, 490);
            this.Controls.Add(this.HideKeycheckBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.samplingrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Helpbutton);
            this.Controls.Add(this.twitch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Startbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitch to Facebook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DownloadStreamLinkbutton;
        private System.Windows.Forms.Label streamlink_test;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UnSetStreamLinkbutton;
        private System.Windows.Forms.Button SetStreamLinkbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UnSetFFMPEGbutton;
        private System.Windows.Forms.Button SetFFMPEGbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DownloadFFMPEGbutton;
        private System.Windows.Forms.Label ffmpeg_test;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox facebook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox twitch;
        private System.Windows.Forms.OpenFileDialog fileOpen;
        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox samplingrate;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel VersiontoolStripStatusLabel;
        private System.Windows.Forms.CheckBox HideKeycheckBox;
    }
}

