using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <h1> element.
    /// </summary>
    public class H1Tag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="H1Tag"/> class with no inner text.
        /// </summary>
        public H1Tag() : base(ETag.h1) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="H1Tag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the <h1> element.</param>
        public H1Tag(string value) : base(ETag.h1)
        {
            InnerText = value;
        }
    }
}
