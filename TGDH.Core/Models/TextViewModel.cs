using System.Web;

namespace TGDH.Core.Models
{
    public class TextViewModel
    {
        public IHtmlString Text { get; set; }

        public string ModifierClass { get; set; }

        public TextViewModel()
        {
        }
    }
}