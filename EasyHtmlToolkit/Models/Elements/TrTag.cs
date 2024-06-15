using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <tr> element.
    /// </summary>
    public class TrTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrTag"/> class without any inner text.
        /// </summary>
        public TrTag() : base(ETag.tr) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrTag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the tr.</param>
        public TrTag(string value) : base(ETag.tr)
        {
            InnerText = value;
        }
    }
}
