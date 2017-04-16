using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using YoutubeExtractor;
using System.Text.RegularExpressions;
using System.IO;


namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        private List<VideoInfo> videoInfos;

        public Form1()
        {
            InitializeComponent();
        }

        private void videoButton_Click(object send, EventArgs e)
        {
            VideoInfo video = videoInfos[listBox1.SelectedIndex]; //TODO: Perhaps try not to depend on the selectedindex.


            //TODO: Check IF the selected video already has audio ELSE download audio and video and contatenate

            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);

            if (video.AudioType == AudioType.Unknown)
            {
                var videoDownloader = new VideoDownloader(video, 
                    Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) 
                    + @"\video" + video.VideoExtension));

                VideoInfo audio = videoInfos[16];

                var audioDownloader = new AudioDownloader(video, 
                    Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) 
                    + @"\audio" + video.AudioExtension));

                downloadProgressBar.Maximum = 200;
                videoDownloader.DownloadProgressChanged += videoDownloader_DownloadProgressChanged;
                audioDownloader.DownloadProgressChanged += videoDownloader_DownloadProgressChanged;

                Thread videoThread = new Thread(() => startDownload(videoDownloader));
                Thread audioThread = new Thread(() => startDownload(audioDownloader));
                videoThread.Start();
                audioThread.Start();

            }
            else
            {
                var videoDownloader = new VideoDownloader(video,
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
                    RemoveIllegalPathCharacters(video.Title) + video.VideoExtension));

                downloadProgressBar.Maximum = 100;
                videoDownloader.DownloadProgressChanged += videoDownloader_DownloadProgressChanged;

                Thread thread = new Thread(() => startDownload(videoDownloader));
                thread.Start();
            }
        }

        private void videoDownloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            downloadProgressBar.Invoke((MethodInvoker)delegate
            {
                downloadProgressBar.Value = (int)e.ProgressPercentage;
            });
        }

        private void startDownload(Downloader obj)
        {
            obj.Execute();
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

            videoInfos = DownloadUrlResolver.GetDownloadUrls(link, false).ToList();
            List<string> dataSource = new List<string>();

            foreach (var info in videoInfos)
            {
                if (info.Resolution != 0)
                    dataSource.Add(string.Format("TITLE :{0}, VIDEO: {1}, RESOLUTION: {2}, AUDIO {3}", info.Title, info.VideoExtension, info.Resolution, info.AudioType));
            }

            listBox1.DataSource = dataSource;
        }
    }
}
