using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <h2> element.
    /// </summary>
    public class H2Tag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="H2Tag"/> class with no inner text.
        /// </summary>
        public H2Tag() : base(ETag.h2) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="H2Tag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the <h2> element.</param>
        public H2Tag(string value) : base(ETag.h2)
        {
            InnerText = value;
        }
    }
}
