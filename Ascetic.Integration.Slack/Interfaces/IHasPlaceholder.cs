using Ascetic.Integration.Slack.Models;

namespace Ascetic.Integration.Slack.Interfaces
{
    public interface IHasPlaceholder
    {
        SlackPlainText Placeholder { get; set; }
    }
}
