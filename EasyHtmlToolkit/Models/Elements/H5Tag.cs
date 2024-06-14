using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    public class H5Tag : HtmlElement
    {
        public H5Tag() : base(ETag.h5) { }

        public H5Tag(string value) : base(ETag.h5)
        {
            InnerText = value;
        }
    }
}
