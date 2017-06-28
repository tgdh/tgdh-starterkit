using System.Web;

public class AuthorViewModel
{
    public string Name { get; set; }

    public IPublishedContent Image { get; set; }

    public IHtmlString Bio { get; set; }

    public string ModifierClass { get; set; }
}