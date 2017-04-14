using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
using System.Text.RegularExpressions;
using System.IO;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void videoButton_Click(object send, EventArgs e)
        {
            VideoInfo video = (VideoInfo)listBox1.SelectedItem; //TODO: make a merger for video only video items
            
            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);

            var videoDownloader = new VideoDownloader(video,
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
                RemoveIllegalPathCharacters(video.Title) + video.VideoExtension));

            videoDownloader.DownloadProgressChanged += (sender, args) => downloadProgressBar.Value = (int)args.ProgressPercentage;


            videoDownloader.Execute(); //TODO: make it run on another thread so it doesn't hang the program
        }

        private static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "");
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string link = videoURL.Text;

            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link, false);

            listBox1.DataSource = videoInfos; //TODO: Only show filetype, bitrate and resolution
        }
    }
}
