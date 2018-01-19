# TGDH starter kit for Umbraco
> Requires Umbraco 7.7.5+

This is a starter kit for [Umbraco](https://umbraco.com/) which aims to provide common functionality that most sites require.

## Login details
- admin
- tgdhstarterkit

## Features

### Blog
The `Blog` includes a listing of `Post`s which can be filtered by date, author and category.

### News
The `News` system includes a listing of 3 article categories and can be filtered by category and date.
- General news
- Press release
- In the media

Both `General news` and `Press release` articles show up in the listing and have a dedicated content page. `In the media`, on the other hand, will be shown in the listing but instead of linking to a content page, it will link to an external website.

### Gateway page
The `Gateway page` acts as a folder for other content pages. The primary function is to ensure sub-pages can be navigated across different device types (e.g. touch) without having to include a sub nav on the content pages.

Out of the box, the gateway has the ability highlight some of the sub-pages. This makes it possible to make richer looking gateways.

### Text page
The `Text page` doctype makes use of `Nested Content` to create something that we refer to as `Page components`. This allows you to add as many components resulting in richer looking content pages.

Examples of page components include images, text, gallery, quotes, tabs etc.

### Contact form
A basic `Contact` form is included by default. This form can be configured by navigating to:
```
Settings/Sitewide content > Contact form
```

You can customise the submit message and have the option to send a notification email to the sender.

### Sitemap
The sitemap provides an ordered listing of pages on the site. To access an XML listing, you can use the alt template:

```
/sitemap/?altTemplate=xmlsitemap
```
## Developing
### Prerequisites

- [Visual Studio IDE](https://www.visualstudio.com/) – Windows

### Building

There are two parts to the starter kit — the package and the core files.

#### Package
The package contains a number of Umbraco specific functionality & needs to be created and exported from the packages interface.

**Download the latest package**
The latest version of the package can be found here:

```
tgdh-starterkit > TGDH.Web > Media > created-packages > tgdh-starterkit_x.x.x.zip
```

**Update the package**
- Navigate to `Developer > Packages > Created packages > tgdh-starterkit`
- Make any updates
- Use [SemVer](https://semver.org/)
- Click `Save`
- Click `Publish`
- When the package is done saving, you can download it from the `Package file (.zip)` link

#### Core files
Please note that there's a number of Visual Studio projects that needs to be manually built:
- TGDH.Core
- TGDH.Forms

## Style guide

This project follows a component based architecture. This allows you to split the UI into independent, reusable pieces and think about each piece in isolation.

There are 2 parts to a component:
- Model
- View

### Model
The model is where you define the properties available to the component.

Models should be created here:
```
TGDH.Core > Models
```

Let's create a heading component as an example:

```cs
namespace TGDH.Core.Models
{
    public class HeadingViewModel
    {
        public string Headline { get; set; }

        public string Description { get; set; }

        public string ModifierClass { get; set; }
    }
}
```

It's a good idea to include a modifier class property when creating components. This makes it easy to change the styling of an instance while maintaining the default styles.

### View
The view will contain the markup and make use of the properties.

Views should be created in the components directory, for example:
```
TGDH.Web > Views > Partials > Components > Heading.cshtml
```

A basic example of the heading component can be seen below:
```cs
@using TGDH.Core.Models;
@inherits UmbracoViewPage<HeadingViewModel>
@{
    if (!String.IsNullOrWhiteSpace(Model.Headline)) {
        return;
    }
}

<header class="c-heading @Model.ModifierClass">
    <h2 class="c-heading__headline">@Mode.Headline</h2>
    @if (!String.IsNullOrWhiteSpace(Model.Description))
        <div class="c-heading__description">
            @Html.Raw(Model.Description)
        </div>
    }
</header>
```

As you can see above, the component only knows about the properties that have been set in the model.

### Rendering a component

A component is rendered like any other partial view, except we're creating a new instance of the components model and explicitly setting the data for the available properties:
```cs
@Html.Partial("~/Views/Partials/Components/Heading.cshtml", new HeadingViewModel {
    Headline = "Example headline",
    Description = Model.GetPropertyValue<string>("pageDescription")
})
```
**IMPORTANT: Make sure to handle any null checks in the component view**

## Database

This project uses the SQL Compact edition for the following reasons:
- Quickstart
- Stored on the file system
- Ability to Version Control

> SQL CE is a good option if you want to get started quickly. You don't need to create a database in a server ahead of time and it's free. That said, it doesn't scale very well for sites with a large amount of content. Once you reach the point where SQL CE doesn't seem to cut it for your site, you can migrate it to a SQL Server database.
— [Umbraco docs](https://our.umbraco.org/documentation/Getting-Started/Setup/Install/install-umbraco-manually)
