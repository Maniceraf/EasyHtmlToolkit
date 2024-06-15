using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <tbody> element.
    /// </summary>
    public class TbodyTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TbodyTag"/> class without any inner text.
        /// </summary>
        public TbodyTag() : base(ETag.tbody) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TbodyTag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the tbody.</param>
        public TbodyTag(string value) : base(ETag.tbody)
        {
            InnerText = value;
        }
    }

}
