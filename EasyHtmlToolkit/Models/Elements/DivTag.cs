using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <div> element.
    /// </summary>
    public class DivTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DivTag"/> class without any inner text.
        /// </summary>
        public DivTag() : base(ETag.div) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="DivTag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the div.</param>
        public DivTag(string value) : base(ETag.div)
        {
            InnerText = value;
        }
    }

}
