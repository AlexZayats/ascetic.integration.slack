using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ascetic.Integration.Slack.Tests
{
    [TestClass]
    public class SlackWebhookClientTests
    {
        public SlackWebhookClient CreateClient()
        {
            var configuration = new ConfigurationBuilder().AddUserSecrets<SlackWebhookClientTests>().Build();
            return new SlackWebhookClient(new HttpClient { BaseAddress = new Uri(configuration["SlackWebhookURL"]) });
        }

        [TestMethod]
        public async Task SlackWebhookClient_PostMessageAsync()
        {
            var client = CreateClient();
            var message = MessageBuilder
                .CreateMessage()
                .AddAttachment(x => x
                    .SetAuthor("Success Test")
                    .SetTitle("Test Title")
                    .SetText("Test Text")
                    .SetFooter("Test Footer")
                    .SetSuccessStatus())
                .AddAttachment(x => x
                    .SetAuthor("Warning Test")
                    .SetTitle("Test Title")
                    .SetText("Test Text")
                    .SetFooter("Test Footer")
                    .SetWarningStatus())
                .AddAttachment(x => x
                    .SetAuthor("Danger Test")
                    .SetTitle("Test Title")
                    .SetText("Test Text")
                    .SetFooter("Test Footer")
                    .SetDangerStatus());
            await client.PostMessageAsync(message);
        }
    }
}
