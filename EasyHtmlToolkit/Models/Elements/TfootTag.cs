using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <tfoot> element.
    /// </summary>
    public class TfootTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TfootTag"/> class without any inner text.
        /// </summary>
        public TfootTag() : base(ETag.tfoot) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TfootTag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the tfoot.</param>
        public TfootTag(string value) : base(ETag.tfoot)
        {
            InnerText = value;
        }
    }

}
