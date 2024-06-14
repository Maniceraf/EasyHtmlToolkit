using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    public class PTag : HtmlElement
    {
        public PTag(string value) : base(ETag.p)
        {
            InnerText = value;
        }
    }
}
