using System.Collections.Generic;
using Umbraco.Core.Models;

namespace TGDH.Core.Models
{
    public class DownloadsViewModel
    {
        public string Headline { get; set; }

        public IEnumerable<IPublishedContent> Media { get; set; }

        public string ModifierClass { get; set; }

        public DownloadsViewModel()
        {

        }
    }
}