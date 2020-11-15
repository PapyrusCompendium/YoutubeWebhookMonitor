using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using YoutubeWebhook.Models;

namespace YoutubeWebhook.API
{
	public static class Youtube
	{
		public static readonly Regex VideoJsonRegex = new Regex(@"({""gridVideoRenderer"":{.+}})],""continuations"":");

		public static async Task<GridVideoRenderer[]> GetChannelVideosAsync(string channelName)
		{
			var httpClient = new HttpClient();
			var response = await httpClient.GetAsync($"https://www.youtube.com/c/{channelName}/videos");

			if (!response.IsSuccessStatusCode)
			{
				return new GridVideoRenderer[0];
			}

			return FindVideos(await response.Content.ReadAsStringAsync());
		}

		private static async Task<GridVideoRenderer> GetLatestVideoAsync(string channelName)
		{
			var channelVideos = await GetChannelVideosAsync(channelName);
			if(channelVideos.Length < 1)
			{
				throw new Exception("No videos on channel!");
			}
			return channelVideos.First();
		}

		private static GridVideoRenderer[] FindVideos(string rawHtml)
		{		
			if (VideoJsonRegex.Match(rawHtml).Success)
			{

				var jsonBody = VideoJsonRegex.Match(rawHtml).Groups[1].Value;
				var gridVideoTabs = new JsonSerializer().Deserialize<YoutubeVideoBlock[]>(new JsonTextReader(new StringReader($"[{jsonBody}]")));
				return gridVideoTabs.Select(i => i.GridVideoRenderer).ToArray();
			}
			return new GridVideoRenderer[0];
		}
	}
}