using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <h5> element.
    /// </summary>
    public class H5Tag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="H5Tag"/> class with no inner text.
        /// </summary>
        public H5Tag() : base(ETag.h5) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="H5Tag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the <h5> element.</param>
        public H5Tag(string value) : base(ETag.h5)
        {
            InnerText = value;
        }
    }
}
