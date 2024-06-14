using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <address> element.
    /// </summary>
    public class AddressTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTag"/> class.
        /// </summary>
        public AddressTag() : base(ETag.address) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTag"/> class with the specified inner text.
        /// </summary>
        /// <param name="innerText">The inner text of the <address> element.</param>
        public AddressTag(string innerText) : base(ETag.address)
        {
            InnerText = innerText;
        }
    }
}
