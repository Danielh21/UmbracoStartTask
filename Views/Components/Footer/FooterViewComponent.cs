using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Internal.Umbraco.Views.Components.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly IUmbracoContextAccessor _umbracoContextAccessor;


        public FooterViewComponent(IUmbracoContextAccessor umbracoContextAccessor)
        {
            _umbracoContextAccessor = umbracoContextAccessor;
        }


        public IViewComponentResult Invoke()
        {
            var context = _umbracoContextAccessor;
            if (context.TryGetUmbracoContext(out IUmbracoContext ctx))
            {
                var root = ctx.Content.GetAtRoot().FirstOrDefault() as HomePage;
                if (root != null)
                {

                    var footerModel = new FooterModel()
                    {
                        FooterText = root.FooterTitle
                    };
                    return View("./Footer", footerModel);
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
