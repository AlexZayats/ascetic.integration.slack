using Ascetic.Integration.Slack.Models;
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
            await client.PostMessageAsync(new SlackMessage
            {
                Text = "TEST",
                Channel = "#bot",
                Attachments = new[]
                {
                    new SlackAttachment
                    {
                        Pretext = "Test pretext...",
                        AuthorName = "Mr. Test",
                        Title = "Test title",
                        Text = "Test text",
                        Footer = "Test footer",
                        Color = "#32CD32"
                    }
                }
            });
        }
    }
}
