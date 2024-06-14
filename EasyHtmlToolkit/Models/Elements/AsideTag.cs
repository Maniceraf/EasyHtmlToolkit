using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <aside> element.
    /// </summary>
    public class AsideTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsideTag"/> class.
        /// </summary>
        public AsideTag() : base(ETag.aside)
        {
            // Optionally, you can set default attributes or perform initialization here.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsideTag"/> class with inner text content.
        /// </summary>
        /// <param name="content">The inner text content of the <aside> element.</param>
        public AsideTag(string content) : base(ETag.aside)
        {
            InnerText = content;
        }

        /// <summary>
        /// Sets the id attribute of the <aside> element.
        /// </summary>
        /// <param name="id">The value of the id attribute.</param>
        public void SetId(string id)
        {
            AddAttribute("id", id);
        }

        /// <summary>
        /// Sets the class attribute of the <aside> element.
        /// </summary>
        /// <param name="className">The value of the class attribute.</param>
        public void SetClass(string className)
        {
            AddAttribute("class", className);
        }

        /// <summary>
        /// Sets the style attribute of the <aside> element.
        /// </summary>
        /// <param name="style">The value of the style attribute.</param>
        public void SetStyle(string style)
        {
            AddAttribute("style", style);
        }

        /// <summary>
        /// Sets the title attribute of the <aside> element.
        /// </summary>
        /// <param name="title">The value of the title attribute.</param>
        public void SetTitle(string title)
        {
            AddAttribute("title", title);
        }
    }
}
