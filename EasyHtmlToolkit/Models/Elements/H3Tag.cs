using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <h3> element.
    /// </summary>
    public class H3Tag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="H3Tag"/> class with no inner text.
        /// </summary>
        public H3Tag() : base(ETag.h3) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="H3Tag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the <h3> element.</param>
        public H3Tag(string value) : base(ETag.h3)
        {
            InnerText = value;
        }
    }

}
