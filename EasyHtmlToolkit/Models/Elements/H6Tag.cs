using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <h6> element.
    /// </summary>
    public class H6Tag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="H6Tag"/> class with no inner text.
        /// </summary>
        public H6Tag() : base(ETag.h6) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="H6Tag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the <h6> element.</param>
        public H6Tag(string value) : base(ETag.h6)
        {
            InnerText = value;
        }
    }
}
