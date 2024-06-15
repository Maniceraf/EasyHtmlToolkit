using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <table> element.
    /// </summary>
    public class TableTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableTag"/> class without any inner text.
        /// </summary>
        public TableTag() : base(ETag.table) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableTag"/> class with the specified inner text.
        /// </summary>
        /// <param name="value">The inner text of the table.</param>
        public TableTag(string value) : base(ETag.table)
        {
            InnerText = value;
        }
    }
}
