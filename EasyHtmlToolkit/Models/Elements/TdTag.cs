using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <td> element.
    /// </summary>
    public class TdTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TdTag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the td element.</param>
        public TdTag(string value) : base(ETag.td)
        {
            InnerText = value;
        }
    }
}
