using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// This is h1 tag.
    /// </summary>
    public class H1Tag : HtmlElement
    {
        /// <summary>
        /// 
        /// </summary>
        public H1Tag() : base(ETag.h1) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public H1Tag(string value) : base(ETag.h1)
        {
            InnerText = value;
        }
    }
}
