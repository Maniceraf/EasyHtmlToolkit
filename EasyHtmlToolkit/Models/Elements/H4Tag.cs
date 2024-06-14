using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <h4> element.
    /// </summary>
    public class H4Tag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="H4Tag"/> class with no inner text.
        /// </summary>
        public H4Tag() : base(ETag.h4) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="H4Tag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the <h4> element.</param>
        public H4Tag(string value) : base(ETag.h4)
        {
            InnerText = value;
        }
    }
}
