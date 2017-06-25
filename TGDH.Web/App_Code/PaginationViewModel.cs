using System.Collections.Generic;
using Umbraco.Core.Models;
using TGDH.Core.Utility;

public class PaginationViewModel
{
    public Paging Paging { get; set; }

    public IPublishedContent CurrentModel { get; set; }

    public string HashLink { get; set; }

    public string ModifierClass { get; set; }
}