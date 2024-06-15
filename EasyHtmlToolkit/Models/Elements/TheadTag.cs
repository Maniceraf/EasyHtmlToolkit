using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <thead> element.
    /// </summary>
    public class TheadTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TheadTag"/> class without any inner text.
        /// </summary>
        public TheadTag() : base(ETag.thead) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TheadTag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the thead.</param>
        public TheadTag(string value) : base(ETag.thead)
        {
            InnerText = value;
        }
    }

}
