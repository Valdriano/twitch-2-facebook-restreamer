using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Twitch_to_Facebook
{
    public partial class MainForm : Form
    {
        Twtfb client;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            DialogResult dialog = MessageBox.Show( "Warning: this software is delivered AS IS and without any warranty. You are fully responsible for any outcomes related to the usage of this application.", "Disclaimer", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning );

            if( dialog == DialogResult.Cancel )
            {
                this.Close();
            }
            samplingrate.SelectedIndex = 0;

            client = new Twtfb();
            client.Load();

            facebook.Text = client.Get( "facebook" );
            twitch.Text = client.Get( "twitch" );
            streamlink_test.Text = client.Get( "streamlink" ) == "" ? "ERROR" : "OK";
            ffmpeg_test.Text = client.Get( "ffmpeg" ) == "" ? "ERROR" : "OK";
        }

        private void DownloadStreamLinkbutton_Click( object sender, EventArgs e )
        {
            Process.Start( "https://github.com/streamlink/streamlink/releases" );
        }

        private void DownloadFFMPEGbutton_Click( object sender, EventArgs e )
        {
            Process.Start( "https://github.com/BtbN/FFmpeg-Builds/releases" );
        }

        private void UnSetStreamLinkbutton_Click( object sender, EventArgs e )
        {
            client.ClearStreamlink();
        }

        private void UnSetFFMPEGbutton_Click( object sender, EventArgs e )
        {
            client.ClearFfmpeg();
        }

        private void SetStreamLinkbutton_Click( object sender, EventArgs e )
        {
            fileOpen.Filter = "Executables|*.exe";
            if( fileOpen.ShowDialog() == DialogResult.OK )
            {
                if( client.SetStreamlink( fileOpen.FileName ) == false )
                {
                    MessageBox.Show( "Invalid Streamlink output.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    streamlink_test.Text = "ERROR";
                }
                else
                {
                    streamlink_test.Text = "OK";
                }
            }
        }

        private void SetFFMPEGbutton_Click( object sender, EventArgs e )
        {
            fileOpen.Filter = "Executables|*.exe";
            if( fileOpen.ShowDialog() == DialogResult.OK )
            {
                if( client.SetFfmpeg( fileOpen.FileName ) == false )
                {
                    MessageBox.Show( "Invalid ffmpeg output.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    ffmpeg_test.Text = "ERROR";
                }
                else
                {
                    ffmpeg_test.Text = "OK";
                }
            }
        }

        private void Startbutton_Click( object sender, EventArgs e )
        {
            client.SetSamplingrate( samplingrate.SelectedItem.ToString() );
            client.SetFacebook( facebook.Text );
            client.SetTwitch( twitch.Text );

            int result = client.Start();
            switch( result )
            {
                case 0:
                    MessageBox.Show( "ffmpeg path not set.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    ffmpeg_test.Text = "ERROR";
                    break;

                case 1:
                    MessageBox.Show( "Invalid ffmpeg output.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    ffmpeg_test.Text = "ERROR";
                    break;

                case 2:
                    MessageBox.Show( "streamlink path not set.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    streamlink_test.Text = "ERROR";
                    break;

                case 3:
                    MessageBox.Show( "Invalid streamlink output.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    streamlink_test.Text = "ERROR";
                    break;
                case 4:
                    MessageBox.Show( "Facebook key not set.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    break;
                case 5:
                    MessageBox.Show( "Enter Twitch account to re-stream.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    break;
                default:
                    MessageBox.Show( "Finished Stream!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    break;
            }
        }

        private void Helpbutton_Click( object sender, EventArgs e )
        {
            Process.Start( "https://idct.pl/article/twitch-to-facebook" );
        }

        private void HideKeycheckBox_CheckedChanged( object sender, EventArgs e )
        {
            if( HideKeycheckBox.Checked )
                facebook.PasswordChar = '*';
            else
                facebook.PasswordChar = ' ';
        }
    }
}
