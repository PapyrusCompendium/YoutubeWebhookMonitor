using System;
using System.Text.RegularExpressions;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace YoutubeWebhook
{
    public static class YoutubeWebhooks
    {
       

        [FunctionName("PollYoutubeChannel")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo timerInfo, ILogger log)
        {
            log.LogInformation($"Polling Youtube Channels: {DateTime.Now}");
        }
    }
}