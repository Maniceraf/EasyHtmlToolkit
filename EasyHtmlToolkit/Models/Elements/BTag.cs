using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <b> (bold) element.
    /// </summary>
    public class BTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BTag"/> class.
        /// </summary>
        public BTag() : base(ETag.b) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="BTag"/> class with the specified inner text.
        /// </summary>
        /// <param name="innerText">The inner text of the <b> element.</param>
        public BTag(string innerText) : base(ETag.b)
        {
            InnerText = innerText;
        }
    }
}
