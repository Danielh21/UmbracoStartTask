using Internal.Umbraco.Views.Components.Header;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Internal.Umbraco.Views.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly IUmbracoContextAccessor _umbracoContextAccessor;


        public HeaderViewComponent(IUmbracoContextAccessor umbracoContextAccessor)
        {
            _umbracoContextAccessor = umbracoContextAccessor;
        }


        public IViewComponentResult Invoke(IPublishedContent model = null)
        {
            var context = _umbracoContextAccessor;
            if (context.TryGetUmbracoContext(out IUmbracoContext ctx))
            {
                var root = ctx.Content.GetAtRoot().FirstOrDefault() as HomePage;
                if (root != null)
                {
                    var Childs = root.Children;

                    var headerModel = new HeaderModel()
                    {
                        Title = model.Value<string>("Title"),
                        MetaDescription = model.Value<string>("Description"),
                        ImageOpenGraph = model.Value<Image>("Image")?.Url(),
                        MetaTitle = model.Value<string>("Title"),
                        SiteNameOpenGraph = model.Value<string>("Sitename"),
                        TitleOpenGraph = model.Value<string>("TitleOpenGraph"),
                        TypeOpenGraph = root.Value<string>("Type"),
                        URLOpenGraph = model.Value<Link>("URL")?.Url,
                        HeaderText = root.HeaderTitle,
                        ChildPages = Childs,
                        Root = root
                    };
                    return View("./Header", headerModel);
                }
                else
                {
                    return View(null);
                }

            }
            else
            {
                return View(null);
            }
        }
    }
}
