using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace YTDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pathBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            string data = "-U";
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.StartInfo.FileName = "youtube-dl.exe";
            proc.StartInfo.Arguments = data;
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.Start();
            proc.WaitForExit();
        }


        private void DownloadButton_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {


                string data = "";
                if (!MP4checkBox.Checked)
                {
                    data = "--o \"" + pathBox.Text + "\\%(title)s.%(ext)s\" --embed-thumbnail --add-metadata -x --audio-format mp3 " + urlBox.Text;
                }
                else
                {
                    data = "--o \"" + pathBox.Text + "\\%(title)s.%(ext)s\" --add-metadata " + urlBox.Text;
                }


                Process proc = new Process();
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.FileName = "youtube-dl.exe";
                proc.StartInfo.Arguments = data;
                proc.StartInfo.RedirectStandardError = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.Start();
                proc.BeginOutputReadLine();
                proc.OutputDataReceived += Proc_OutputDataReceived;
                proc.WaitForExit();


                Invoke(new Action(() =>
                {
                    this.Text = "YTDL - Done!";
                    Process.Start("explorer.exe", @pathBox.Text);
                    Thread.Sleep(500);
                    this.Text = "YTDL";
                }));
            }).Start();
        }

        private void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                Invoke(new Action(() =>
                {
                    this.Text = "YTDL - " + e.Data.ToString();
                }));
            }
        }

        private void selectPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathBox.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }
    }
}
