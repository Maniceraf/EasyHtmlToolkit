using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    public class HtmlTh : HtmlElement
    {
        public HtmlTh(string value) : base(ETag.h1)
        {
            InnerText = value;
        }
    }
}
