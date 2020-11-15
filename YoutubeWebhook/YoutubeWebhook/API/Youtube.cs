using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YoutubeWebhook.Models;

namespace YoutubeWebhook.API
{
	public static class Youtube
	{
		public static readonly Regex VideoTitle = new Regex(@"<a id=""video - title"" class="".+? title = ""(.+?)"" href = ""(.+?)""");
		public static readonly Regex VideoThumbnail = new Regex(@"<img id=""img"" class="".+? "" alt="""" width=""210"" src=""(https://i.ytimg.com/vi/.+?)"">");

		public static async Task<YoutubeVideo[]> GetChannelVideosAsync(string channelName)
		{
			var httpClient = new HttpClient();
			var response = await httpClient.GetAsync($"https://www.youtube.com/c/{channelName}/videos");
			if (!response.IsSuccessStatusCode)
			{
				return new YoutubeVideo[0];
			}
			return FindVideos(await response.Content.ReadAsStringAsync());			
		}

		private static async Task<YoutubeVideo> GetLatestVideoAsync(string channelName)
		{
			var channelVideos = await GetChannelVideosAsync(channelName);
			if(channelVideos.Length < 1)
			{
				throw new Exception("No videos on channel!");
			}
			return channelVideos[0];
		}

		private static YoutubeVideo[] FindVideos(string rawHtml)
		{
			var videoTitles = VideoTitle.Matches(rawHtml);
			var videoThumbnails = VideoThumbnail.Matches(rawHtml);

			if(videoTitles.Count != videoThumbnails.Count)
			{
				throw new Exception("Parsing error!");
			}

			var videos = new YoutubeVideo[videoTitles.Count - 1];
			for (int x = 0; x < videoTitles.Count; x++)
			{
				var videoTitleCapGroups = videoTitles[x].Groups;
				var videoThumbnailCapGroups = videoThumbnails[x].Groups;

				videos[x] = new YoutubeVideo()
				{
					Title = videoTitleCapGroups[1].Value,
					Source = $"httpss://youtube.com/{videoTitleCapGroups[2]}",
					Thumbnail = videoThumbnailCapGroups[1].Value
				};
			}

			return videos;
		}
	}
}