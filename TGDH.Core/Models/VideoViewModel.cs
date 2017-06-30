using System.Web;

namespace TGDH.Core.Models
{
    public class VideoViewModel
    {
        public IHtmlString Video { get; set; }

        public string ModifierClass { get; set; }

        public VideoViewModel()
        {
        }
    }
}