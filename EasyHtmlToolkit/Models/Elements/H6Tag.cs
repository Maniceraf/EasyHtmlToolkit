using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    public class H6Tag : HtmlElement
    {
        public H6Tag() : base(ETag.h6) { }

        public H6Tag(string value) : base(ETag.h6)
        {
            InnerText = value;
        }
    }
}
