using Ascetic.Integration.Slack.Models;
using System.Collections.Generic;

namespace Ascetic.Integration.Slack.Interfaces
{
    public interface IHasOptions
    {
        IList<SlackOption> Options { get; set; }
    }
}
