using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <th> element.
    /// </summary>
    public class ThTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThTag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the th element.</param>
        public ThTag(string value) : base(ETag.th)
        {
            InnerText = value;
        }
    }
}
