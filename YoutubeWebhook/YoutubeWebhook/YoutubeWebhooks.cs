using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Specialized;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace YoutubeWebhook
{
    public static class YoutubeWebhooks
    {      
        [FunctionName("PollYoutubeChannel")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo timerInfo, ILogger log)
        {
            log.LogInformation($"Polling Youtube Channels: {DateTime.Now}");

            var channelVideos = API.Youtube.GetChannelVideosAsync();
            log.LogInformation($"Found {} videos");
        }

        private static async Task SaveBlobItem(string blobName, BlobOrderItem blobOrderItem)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(Environment.GetEnvironmentVariable("ConnectionStrings__AzureWebJobsStorage"));
            var blobContainer = blobServiceClient.GetBlobContainerClient("webhooks");
            var blobClient = blobContainer.GetBlockBlobClient(blobName);

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(blobOrderItem))))
            {
                await blobClient.UploadAsync(stream);
            }
        }
    }
}