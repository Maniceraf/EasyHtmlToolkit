using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    public class H2Tag : HtmlElement
    {
        public H2Tag() : base(ETag.h2) { }

        public H2Tag(string value) : base(ETag.h2)
        {
            InnerText = value;
        }
    }
}
