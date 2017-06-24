using System.Collections.Generic;
using System.Web;
using Umbraco.Core.Models;

public class SocialChannelsViewModel
{
    public IEnumerable<IPublishedContent> SocialChannels { get; set; }

    public int SocialChannelIconSize { get; set; }

    public SocialChannelsViewModel()
    {
        SocialChannelIconSize = 32;
    }
}