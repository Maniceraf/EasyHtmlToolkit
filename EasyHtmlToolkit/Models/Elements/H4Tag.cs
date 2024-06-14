using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    public class H4Tag : HtmlElement
    {
        public H4Tag() : base(ETag.h4) { }

        public H4Tag(string value) : base(ETag.h4)
        {
            InnerText = value;
        }
    }
}
