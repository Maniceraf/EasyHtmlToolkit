using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <abbr> (abbreviation) element.
    /// </summary>
    public class AbbrTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbbrTag"/> class.
        /// </summary>
        public AbbrTag() : base(ETag.abbr) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbbrTag"/> class with the specified inner text and optional title attribute.
        /// </summary>
        /// <param name="innerText">The inner text of the <abbr> element.</param>
        /// <param name="title">The optional title attribute of the <abbr> element.</param>
        public AbbrTag(string innerText, string? title = null) : base(ETag.abbr)
        {
            InnerText = innerText;

            if (!string.IsNullOrEmpty(title))
            {
                AddAttribute("title", title);
            }
        }

        /// <summary>
        /// Sets the title attribute value of the <abbr> element.
        /// </summary>
        /// <param name="title">The title attribute value.</param>
        public void SetTitle(string title)
        {
            AddAttribute("title", title);
        }
    }

}
