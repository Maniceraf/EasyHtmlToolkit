using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <p> element.
    /// </summary>
    public class PTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PTag"/> class with no inner text.
        /// </summary>
        public PTag() : base(ETag.p) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PTag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the <p> element.</param>
        public PTag(string value) : base(ETag.p)
        {
            InnerText = value;
        }
    }
}
