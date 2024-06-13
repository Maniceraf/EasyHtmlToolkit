namespace EasyHtmlToolkit.Models.Elements
{
    public class HtmlAnchor : HtmlElement
    {
        public HtmlAnchor() : base("a") { }

        public void SetHref(string href)
        {
            AddAttribute("href", href);
        }
    }
}
