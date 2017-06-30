using System.Collections.Generic;
using Umbraco.Core.Models;

namespace TGDH.Core.Models
{
    public class PageListingViewModel
    {
        public IEnumerable<IPublishedContent> Listing { get; set; }

        public IPublishedContent CurrentModel { get; set; }

        public string ModifierClass { get; set; }
    }
}