using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Ascetic.Integration.Slack.Tests
{
    public class LoggingHandler : DelegatingHandler
    {
        private readonly ILogger<HttpClient> _logger;

        public LoggingHandler(ILogger<HttpClient> logger)
            : base(new HttpClientHandler())
        {
            _logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            _logger.LogInformation(request.ToString());
            if (request.Content != null)
            {
                _logger.LogInformation(await request.Content.ReadAsStringAsync());
            }
            var response = await base.SendAsync(request, cancellationToken);
            _logger.LogInformation(response.ToString());
            if (response.Content != null)
            {
                _logger.LogInformation(await response.Content.ReadAsStringAsync());
            }
            return response;
        }
    }

    public static class SlackClientHelper
    {
        public static SlackWebhookClient CreateClient()
        {
            var loggerConfiguration = new LoggerConfiguration().WriteTo.Trace();
            var loggerFactory = LoggerFactory.Create(builder => builder.AddSerilog(loggerConfiguration.CreateLogger()));
            var logger = loggerFactory.CreateLogger<HttpClient>();
            var configuration = new ConfigurationBuilder().AddUserSecrets<SlackWebhookClientAttachmentTests>().Build();
            return new SlackWebhookClient(new HttpClient(new LoggingHandler(logger)) { BaseAddress = new Uri(configuration["SlackWebhookURL"]) });
        }
    }
}
