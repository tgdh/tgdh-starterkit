using System.Web;

namespace TGDH.Core.Models
{
    public class QuoteViewModel
    {
        public IHtmlString Quote { get; set; }

        public string Source { get; set; }

        public string Alignment { get; set; }

        public string ModifierClass { get; set; }

        public QuoteViewModel()
        {

        }
    }
}