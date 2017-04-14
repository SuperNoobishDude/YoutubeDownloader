namespace YoutubeDownloader
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
            this.videoURL = new System.Windows.Forms.TextBox();
            this.videoButton = new System.Windows.Forms.Button();
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.loadButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // videoURL
            // 
            this.videoURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoURL.Location = new System.Drawing.Point(12, 12);
            this.videoURL.Name = "videoURL";
            this.videoURL.Size = new System.Drawing.Size(179, 20);
            this.videoURL.TabIndex = 0;
            this.videoURL.Text = "Download Video";
            // 
            // videoButton
            // 
            this.videoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoButton.Location = new System.Drawing.Point(12, 198);
            this.videoButton.Name = "videoButton";
            this.videoButton.Size = new System.Drawing.Size(260, 23);
            this.videoButton.TabIndex = 1;
            this.videoButton.Text = "Download";
            this.videoButton.UseVisualStyleBackColor = true;
            this.videoButton.Click += new System.EventHandler(this.videoButton_Click);
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadProgressBar.Location = new System.Drawing.Point(12, 227);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(260, 23);
            this.downloadProgressBar.TabIndex = 2;
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Location = new System.Drawing.Point(197, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 147);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.downloadProgressBar);
            this.Controls.Add(this.videoButton);
            this.Controls.Add(this.videoURL);
            this.Name = "Form1";
            this.Text = "Youtube Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox videoURL;
        private System.Windows.Forms.Button videoButton;
        private System.Windows.Forms.ProgressBar downloadProgressBar;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

