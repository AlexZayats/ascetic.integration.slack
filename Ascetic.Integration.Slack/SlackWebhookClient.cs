using Ascetic.Core.Http.Extensions;
using Ascetic.Integration.Slack.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ascetic.Integration.Slack
{
    public class SlackWebhookClient
    {
        private readonly HttpClient _client;

        public SlackWebhookClient(HttpClient client)
        {
            _client = client;
        }

        public async Task PostMessageAsync(SlackMessage message)
        {
            await _client.PostJsonAsync("", message).ConfigureAwait(false);
        }
    }
}
