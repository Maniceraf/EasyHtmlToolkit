using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    public class HtmlAnchor : HtmlElement
    {
        public HtmlAnchor() : base(ETag.h1) { }

        public void SetHref(string href)
        {
            AddAttribute("href", href);
        }
    }
}
