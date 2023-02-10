using global::Umbraco.Cms.Core.Models.PublishedContent;
using global::Umbraco.Cms.Core.Web;
using MessagePack;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.Blocks;
using static Umbraco.Cms.Core.Constants.HttpContext;
using ContentModels = Umbraco.Cms.Web.Common.PublishedModels;

namespace Internal.Umbraco.Views.Partials.blockgrid.Components.CTA
{
    public class CTAViewComponent : ViewComponent
    {
        private readonly IUmbracoContextAccessor _umbracoContextAccessor;


        public CTAViewComponent(IUmbracoContextAccessor umbracoContextAccessor)
        {
            _umbracoContextAccessor = umbracoContextAccessor;
        }
        //public async Task<IViewComponentResult> Invoke(BlockGridItem item = null)
        //{
        //    var context = _umbracoContextAccessor;
        //        var content = item.Content;
        //        await Task.Delay(4000);
        //        return View("~/Views/Partials/blockgrid/Components/CTA/Cta.cshtml", content as ContentModels.CTA);
        //}

        public async Task<IViewComponentResult> InvokeAsync(BlockGridItem item = null)
        {
            var context = _umbracoContextAccessor;
            var content = item.Content;
            await Task.Delay(10000);
            return View("~/Views/Partials/blockgrid/Components/CTA/Cta.cshtml", content as ContentModels.CTA);
        }


    }
}

