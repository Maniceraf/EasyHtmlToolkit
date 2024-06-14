using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <span> element.
    /// </summary>
    public class SpanTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpanTag"/> class without any inner text.
        /// </summary>
        public SpanTag() : base(ETag.span) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanTag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the span.</param>
        public SpanTag(string value) : base(ETag.span)
        {
            InnerText = value;
        }
    }
}
