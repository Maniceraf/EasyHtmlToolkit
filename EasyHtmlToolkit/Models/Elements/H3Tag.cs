using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    public class H3Tag : HtmlElement
    {
        public H3Tag() : base(ETag.h3) { }

        public H3Tag(string value) : base(ETag.h3)
        {
            InnerText = value;
        }
    }
}
