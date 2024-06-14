using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <a> (anchor) element.
    /// </summary>
    public class ATag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ATag"/> class with no inner text.
        /// </summary>
        public ATag() : base(ETag.a) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ATag"/> class with the specified inner text and optional href attribute.
        /// </summary>
        /// <param name="value">The inner text of the <a> element.</param>
        /// <param name="href">The href attribute value (optional).</param>
        public ATag(string value, string? href = null) : base(ETag.a)
        {
            InnerText = value;

            if (!string.IsNullOrEmpty(href))
            {
                AddAttribute("href", href);
            }
        }

        /// <summary>
        /// Sets the href attribute value of the <a> element.
        /// </summary>
        /// <param name="href">The href attribute value.</param>
        public void SetHref(string href)
        {
            AddAttribute("href", href);
        }
    }
}
