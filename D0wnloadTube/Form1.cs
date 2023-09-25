using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Streams;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Runtime.InteropServices;
using Windows.UI.Notifications;
using System.Diagnostics.Metrics;
using System.IO;
using System;
using Microsoft.VisualBasic.Devices;
using System.Text.RegularExpressions;

namespace D0wnloadTube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void ShowNotification(string notifTitle, string notifContent)
        {
            new ToastContentBuilder()
    .AddText(notifTitle)
    .AddText(notifContent)
    .Show();
        }

        private async Task DownloadPlaylist(string url, string filePath)
        {
            if (VideoCb.Checked && AudioCb.Checked)
            {
                var youtube = new YoutubeClient();
                var playlist = await youtube.Playlists.GetAsync(url);
                var youtubeClient = new YoutubeClient();
                var playlists = await youtube.Playlists.GetVideosAsync(url);
                var videos = await youtube.Playlists.GetVideosAsync(url);
                await foreach (var video in youtube.Playlists.GetVideosAsync(url))
                {
                    var title = video.Title;
                    string cleanedTitle = Regex.Replace(title, @"[\\/:*?""<>|]", "");
                    label5.Text = ("Downloading: " + cleanedTitle);
                    filePath = cleanedTitle;
                    var progress = new Progress<double>(p => pbDownload.Value = (int)(p * 100));
                    var playlistManifest = await youtubeClient.Videos.Streams.GetManifestAsync(video.Id);
                    var playlistInfo = await youtubeClient.Videos.GetAsync(video.Id);
                    var playlistStreamInfo = playlistManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                    // Create file name
                    await youtube.Videos.Streams.DownloadAsync(playlistStreamInfo, filePath);
                    await youtubeClient.Videos.Streams.DownloadAsync(playlistStreamInfo, filePath, progress);
                    filePath = Path.Combine(txtOutputDirectory.Text, cleanedTitle + ".mp4");
                    await youtubeClient.Videos.Streams.DownloadAsync(playlistStreamInfo, filePath, progress);
                }
            }
            else if (VideoCb.Checked && !AudioCb.Checked)
            {
                var youtube = new YoutubeClient();
                var playlist = await youtube.Playlists.GetAsync(url);
                var youtubeClient = new YoutubeClient();
                var playlists = await youtube.Playlists.GetVideosAsync(url);
                var videos = await youtube.Playlists.GetVideosAsync(url);
                await foreach (var video in youtube.Playlists.GetVideosAsync(url))
                {
                    var title = video.Title;
                    label5.Text = ("Downloading: " + title);
                    filePath = title;
                    var progress = new Progress<double>(p => pbDownload.Value = (int)(p * 100));
                    var playlistManifest = await youtubeClient.Videos.Streams.GetManifestAsync(video.Id);
                    var playlistInfo = await youtubeClient.Videos.GetAsync(video.Id);
                    var playlistStreamInfo = playlistManifest.GetVideoOnlyStreams().GetWithHighestVideoQuality();
                    // Create file name
                    await youtube.Videos.Streams.DownloadAsync(playlistStreamInfo, filePath);
                    await youtubeClient.Videos.Streams.DownloadAsync(playlistStreamInfo, filePath, progress);
                    filePath = Path.Combine(txtOutputDirectory.Text, title + ".mp4");
                    await youtubeClient.Videos.Streams.DownloadAsync(playlistStreamInfo, filePath, progress);
                }
            }
            else if (!VideoCb.Checked && AudioCb.Checked)
            {
                var youtube = new YoutubeClient();
                var playlist = await youtube.Playlists.GetAsync(url);
                var youtubeClient = new YoutubeClient();
                var playlists = await youtube.Playlists.GetVideosAsync(url);
                var videos = await youtube.Playlists.GetVideosAsync(url);
                await foreach (var video in youtube.Playlists.GetVideosAsync(url))
                {
                    var title = video.Title;
                    label5.Text = ("Downloading: " + title);
                    filePath = title;
                    var progress = new Progress<double>(p => pbDownload.Value = (int)(p * 100));
                    var playlistManifest = await youtubeClient.Videos.Streams.GetManifestAsync(video.Id);
                    var playlistInfo = await youtubeClient.Videos.GetAsync(video.Id);
                    var playlistStreamInfo = playlistManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                    // Create file name
                    await youtube.Videos.Streams.DownloadAsync(playlistStreamInfo, filePath);
                    await youtubeClient.Videos.Streams.DownloadAsync(playlistStreamInfo, filePath, progress);
                    filePath = Path.Combine(txtOutputDirectory.Text, title + ".mp3");
                    await youtubeClient.Videos.Streams.DownloadAsync(playlistStreamInfo, filePath, progress);
                }
            }
        }

        private async Task DownloadVideo(string url, string filePath)
        {
            if (VideoCb.Checked && AudioCb.Checked)
            {
                var youtube = new YoutubeClient();
                var videoId = YoutubeExplode.Videos.VideoId.Parse(url);
                var video = await youtube.Videos.GetAsync(videoId);
                var title = video.Title;
                string cleanedTitle = Regex.Replace(title, @"[\\/:*?""<>|]", "");
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
                var VideoStreamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                var progress = new Progress<double>(p => pbDownload.Value = (int)(p * 100));
                await youtube.Videos.Streams.DownloadAsync(VideoStreamInfo, filePath, progress);
                var notifTitle = "Success";
                var notifContent = "Video Downloaded Successfully!";
                ShowNotification(notifTitle, notifContent);
            }
            else if (VideoCb.Checked && !AudioCb.Checked)
            {
                var youtube = new YoutubeClient();
                var videoId = YoutubeExplode.Videos.VideoId.Parse(url);
                var video = await youtube.Videos.GetAsync(videoId);
                var title = video.Title;
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
                var VideoStreamInfo = streamManifest.GetVideoOnlyStreams().GetWithHighestVideoQuality();
                var progress = new Progress<double>(p => pbDownload.Value = (int)(p * 100));
                await youtube.Videos.Streams.DownloadAsync(VideoStreamInfo, filePath, progress);
                var notifTitle = "Success";
                var notifContent = "Video Downloaded Successfully!";
                ShowNotification(notifTitle, notifContent);
            }
            else if (!VideoCb.Checked && AudioCb.Checked)
            {
                var youtube = new YoutubeClient();
                var videoId = YoutubeExplode.Videos.VideoId.Parse(url);
                var video = await youtube.Videos.GetAsync(videoId);
                var title = video.Title;
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
                var VideoStreamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                var progress = new Progress<double>(p => pbDownload.Value = (int)(p * 100));
                await youtube.Videos.Streams.DownloadAsync(VideoStreamInfo, filePath, progress);
                var notifTitle = "Success";
                var notifContent = "Video Downloaded Successfully!";
                ShowNotification(notifTitle, notifContent);
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (!VideoCb.Checked && !AudioCb.Checked)
            {
                var title = "Error";
                var content = "Chooose atleast One of the checkboxes.";
                ShowNotification(title, content);
            }
            else if (!string.IsNullOrEmpty(txtUrl.Text) && !string.IsNullOrEmpty(txtOutputDirectory.Text))
            {

                if (txtUrl.Text.Contains("playlist"))
                {
                    var title = "Error";
                    var content = "Wrong Link Please Click on Video and copy from the link EXAMPLE:`https://www.youtube.com/watch?v=XXXXXXXXXXX&list=XXXXXXXXXXXXXXXXXXXXXXXXXX&index=0`";
                    ShowNotification(title, content);
                }
                //else if (txtUrl.Text.Contains("&list"))
                //{
                //    if (!VideoCb.Checked && AudioCb.Checked)
                //    {
                //        var notifTitle = "Downloading";
                //        var notifContent = "";
                //        ShowNotification(notifTitle, notifContent);
                //        var url = txtUrl.Text;
                //        var youtube = new YoutubeClient();
                //        var videoId = YoutubeExplode.Videos.VideoId.Parse(url);
                //        var video = await youtube.Videos.GetAsync(videoId);
                //        var title = video.Title;
                //        label5.Text = ("Downloading: " + title);
                //        var filePath = Path.Combine(txtOutputDirectory.Text, title + ".mp3");
                //        await DownloadPlaylist(url, filePath);
                //    }
                //    else
                //    {
                //        var notifTitle = "Downloading";
                //        var notifContent = "";
                //        ShowNotification(notifTitle, notifContent);
                //        var url = txtUrl.Text;
                //        var youtube = new YoutubeClient();
                //        var videoId = YoutubeExplode.Videos.VideoId.Parse(url);
                //        var video = await youtube.Videos.GetAsync(videoId);
                //        var title = video.Title;
                //        label5.Text = ("Downloading: " + title);
                //        var filePath = Path.Combine(txtOutputDirectory.Text, title + ".mp4");
                //        await DownloadPlaylist(url, filePath);
                //    }
                //}
                else if (!txtUrl.Text.Contains("&list"))
                {
                    if (!VideoCb.Checked && AudioCb.Checked)
                    {
                        var notifTitle = "Downloading";
                        var notifContent = "";
                        ShowNotification(notifTitle, notifContent);
                        var url = txtUrl.Text;
                        var youtube = new YoutubeClient();
                        var videoId = YoutubeExplode.Videos.VideoId.Parse(url);
                        var video = await youtube.Videos.GetAsync(videoId);
                        var title = video.Title;
                        string cleanedTitle = Regex.Replace(title, @"[\\/:*?""<>|]", "");
                        label5.Text = ("Downloading: " + title);
                        var filePath = Path.Combine(txtOutputDirectory.Text, cleanedTitle + ".mp3");
                        await DownloadVideo(url, filePath);
                    }
                    else
                    {
                        var notifTitle = "Downloading";
                        var notifContent = "";
                        ShowNotification(notifTitle, notifContent);
                        var url = txtUrl.Text;
                        var youtube = new YoutubeClient();
                        var videoId = YoutubeExplode.Videos.VideoId.Parse(url);
                        var video = await youtube.Videos.GetAsync(videoId);
                        var title = video.Title;
                        string cleanedTitle = Regex.Replace(title, @"[\\/:*?""<>|]", "");
                        label5.Text = ("Downloading: " + title);
                        var filePath = Path.Combine(txtOutputDirectory.Text, cleanedTitle + ".mp4");
                        await DownloadVideo(url, filePath);
                    }
                }
            }
            else
            {
                var title = "Error";
                var content = "Please enter a valid URL and save path!";
                ShowNotification(title, content);
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    txtOutputDirectory.Text = dialog.SelectedPath;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Progresslbl.Text = "Progress " + pbDownload.Value + "%";
        }
    }
}



