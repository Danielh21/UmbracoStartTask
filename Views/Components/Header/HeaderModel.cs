using Umbraco.Cms.Core.Models.PublishedContent;

namespace Internal.Umbraco.Views.Components.Header
{
    public class HeaderModel
    {
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string TitleOpenGraph { get; set; }
        public string SiteNameOpenGraph { get; set; }
        public string TypeOpenGraph { get; set; }
        public string URLOpenGraph { get; set; }
        public string ImageOpenGraph { get; set; }

        public string HeaderText { get; set; }

        public IEnumerable<IPublishedContent> ChildPages { get; set;}

        public IPublishedContent Root { get; set;}

    }
}
