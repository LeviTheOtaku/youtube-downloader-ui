namespace YoutubeMP3Downloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.urlBox = new System.Windows.Forms.TextBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.selectPathButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.showOutputCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(33, 23);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(429, 20);
            this.urlBox.TabIndex = 0;
            this.urlBox.Text = "URL";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(33, 73);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(293, 20);
            this.pathBox.TabIndex = 1;
            // 
            // selectPathButton
            // 
            this.selectPathButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selectPathButton.Location = new System.Drawing.Point(332, 71);
            this.selectPathButton.Name = "selectPathButton";
            this.selectPathButton.Size = new System.Drawing.Size(130, 23);
            this.selectPathButton.TabIndex = 2;
            this.selectPathButton.Text = "Change Location";
            this.selectPathButton.UseVisualStyleBackColor = true;
            this.selectPathButton.Click += new System.EventHandler(this.selectPathButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(33, 110);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(429, 36);
            this.DownloadButton.TabIndex = 3;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // showOutputCheckbox
            // 
            this.showOutputCheckbox.AutoSize = true;
            this.showOutputCheckbox.ForeColor = System.Drawing.Color.White;
            this.showOutputCheckbox.Location = new System.Drawing.Point(33, 153);
            this.showOutputCheckbox.Name = "showOutputCheckbox";
            this.showOutputCheckbox.Size = new System.Drawing.Size(92, 17);
            this.showOutputCheckbox.TabIndex = 4;
            this.showOutputCheckbox.Text = "Show output?";
            this.showOutputCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(494, 173);
            this.Controls.Add(this.showOutputCheckbox);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.selectPathButton);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.urlBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "YTDL";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button selectPathButton;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.CheckBox showOutputCheckbox;
    }
}

