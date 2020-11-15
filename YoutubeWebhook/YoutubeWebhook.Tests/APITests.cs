using System;
using System.IO;
using System.Linq;
using Xunit;
using YoutubeWebhook.API;

namespace YoutubeWebhook.Tests
{
	public class APITests
	{
		[Fact]
		public async void TestYoutube()
		{
			var videos = await Youtube.GetChannelVideosAsync("Timcast");

			var savedVideos = File.ReadAllLines("Videos");
			File.WriteAllLines("Videos", videos.Select(i => i.Title.Runs[0].Text));
		}
	}
}