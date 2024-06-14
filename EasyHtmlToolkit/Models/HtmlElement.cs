using EasyHtmlToolkit.Enums;
using System;
using System.Text;

namespace EasyHtmlToolkit.Models
{
    /// <summary>
    /// Represents an HTML element with methods to generate HTML tags with attributes and content.
    /// </summary>
    public class HtmlElement
    {
        /// <summary>
        /// Gets the tag name of the HTML element.
        /// </summary>
        public ETag TagName { get; }

        /// <summary>
        /// Gets or sets the inner text content of the HTML element.
        /// </summary>
        public string? InnerText { get; set; }

        private Dictionary<string, string> Attributes { get; } = []; // Holds HTML attributes
        private Dictionary<string, string> Styles { get; } = []; // Holds CSS styles
        private List<HtmlElement> Childrens { get; } = []; // Holds child elements

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlElement"/> class with the specified tag name.
        /// </summary>
        /// <param name="tagName">The HTML tag name of the element.</param>
        public HtmlElement(ETag tagName)
        {
            TagName = tagName;
        }

        /// <summary>
        /// Adds a child HtmlElement to the current element.
        /// </summary>
        /// <param name="child">The HtmlElement to add as a child.</param>
        public void AddChildren(HtmlElement child)
        {
            Childrens.Add(child);
        }

        /// <summary>
        /// Adds or updates an HTML attribute with the specified key and value.
        /// </summary>
        /// <param name="key">The attribute name.</param>
        /// <param name="value">The attribute value.</param>
        public void AddAttribute(string key, string value)
        {
            Attributes[key] = value;
        }

        /// <summary>
        /// Adds an ID attribute to the HTML element.
        /// If an ID attribute already exists, appends the new ID to the existing one.
        /// </summary>
        /// <param name="value">The value of the ID attribute to add.</param>
        public void AddId(string value)
        {
            if (Attributes.ContainsKey("id"))
            {
                Attributes["id"] += " " + value;
            }
            else
            {
                Attributes["id"] = value;
            }
        }

        /// <summary>
        /// Adds a class attribute to the HTML element.
        /// If a class attribute already exists, appends the new class to the existing one.
        /// </summary>
        /// <param name="value">The value of the class attribute to add.</param>
        public void AddClass(string value)
        {
            if (Attributes.ContainsKey("class"))
            {
                Attributes["class"] += " " + value;
            }
            else
            {
                Attributes["class"] = value;
            }
        }

        /// <summary>
        /// Sets a CSS style for the HTML element with the specified name and value.
        /// </summary>
        /// <param name="name">The name of the CSS style property.</param>
        /// <param name="value">The value of the CSS style property.</param>
        public void SetStyle(string name, string value)
        {
            Styles[name] = value;
        }

        /// <summary>
        /// Adds an event attribute to the HTML element, such as onclick or onmouseover.
        /// </summary>
        /// <param name="eventName">The name of the event (e.g., click, mouseover).</param>
        /// <param name="jsFunction">The JavaScript function to be executed.</param>
        public void AddEvent(string eventName, string jsFunction)
        {
            AddAttribute($"on{eventName}", jsFunction);
        }

        /// <summary>
        /// Sets the accesskey attribute for keyboard shortcuts.
        /// </summary>
        /// <param name="value">The value of the accesskey attribute.</param>
        public void SetAccessKey(char value)
        {
            AddAttribute("accesskey", value.ToString());
        }

        /// <summary>
        /// Sets whether the element's content is editable.
        /// </summary>
        /// <param name="editable">True to make the content editable; false otherwise.</param>
        public void SetContentEditable(bool editable)
        {
            AddAttribute("contenteditable", editable ? "true" : "false");
        }

        /// <summary>
        /// Sets custom data attributes prefixed with "data-".
        /// </summary>
        /// <param name="name">The name of the custom data attribute.</param>
        /// <param name="value">The value of the custom data attribute.</param>
        public void SetDataAttribute(string name, string value)
        {
            AddAttribute($"data-{name}", value);
        }

        /// <summary>
        /// Sets the text direction of the element's content.
        /// </summary>
        /// <param name="direction">The direction of the text (e.g., "ltr", "rtl").</param>
        public void SetDirection(string direction)
        {
            AddAttribute("dir", direction);
        }

        /// <summary>
        /// Sets whether the element is draggable.
        /// </summary>
        /// <param name="draggable">True to make the element draggable; false otherwise.</param>
        public void SetDraggable(bool draggable)
        {
            AddAttribute("draggable", draggable ? "true" : "false");
        }

        /// <summary>
        /// Sets the enterkeyhint attribute for the virtual keyboard behavior.
        /// </summary>
        /// <param name="hint">The enter key hint (e.g., "enter", "done").</param>
        public void SetEnterKeyHint(string hint)
        {
            AddAttribute("enterkeyhint", hint);
        }

        /// <summary>
        /// Sets whether the element is hidden from view.
        /// </summary>
        /// <param name="hidden">True to hide the element; false to show it.</param>
        public void SetHidden(bool hidden)
        {
            if (hidden)
            {
                AddAttribute("hidden", "hidden");
            }
            else
            {
                Attributes.Remove("hidden");
            }
        }

        /// <summary>
        /// Sets whether the element should be ignored by the browser.
        /// </summary>
        /// <param name="inert">True to make the element inert; false otherwise.</param>
        public void SetInert(bool inert)
        {
            if (inert)
            {
                AddAttribute("inert", "inert");
            }
            else
            {
                Attributes.Remove("inert");
            }
        }

        /// <summary>
        /// Sets the inputmode attribute for the virtual keyboard behavior.
        /// </summary>
        /// <param name="mode">The input mode (e.g., "text", "numeric").</param>
        public void SetInputMode(string mode)
        {
            AddAttribute("inputmode", mode);
        }

        /// <summary>
        /// Sets the language of the element's content.
        /// </summary>
        /// <param name="language">The language code (e.g., "en", "fr").</param>
        public void SetLanguage(string language)
        {
            AddAttribute("lang", language);
        }

        /// <summary>
        /// Sets the popover attribute for custom popover content.
        /// </summary>
        /// <param name="popoverContent">The popover content.</param>
        public void SetPopover(string popoverContent)
        {
            AddAttribute("popover", popoverContent);
        }

        /// <summary>
        /// Sets whether the element's spelling and grammar should be checked.
        /// </summary>
        /// <param name="spellcheck">True to enable spell checking; false to disable it.</param>
        public void SetSpellCheck(bool spellcheck)
        {
            AddAttribute("spellcheck", spellcheck ? "true" : "false");
        }

        /// <summary>
        /// Sets the tabindex attribute for keyboard navigation order.
        /// </summary>
        /// <param name="index">The tab index value.</param>
        public void SetTabIndex(int index)
        {
            AddAttribute("tabindex", index.ToString());
        }

        /// <summary>
        /// Sets whether the element's content should be translated.
        /// </summary>
        /// <param name="translate">True to enable translation; false to disable it.</param>
        public void SetTranslate(bool translate)
        {
            AddAttribute("translate", translate ? "yes" : "no");
        }

        /// <summary>
        /// Generates the HTML string representation of the HTML element and its children.
        /// </summary>
        /// <returns>The HTML string representing the HTML element and its children.</returns>
        public override string ToString()
        {
            var tag = TagName.ToString();

            var sb = new StringBuilder();
            sb.Append($"<{tag}");

            // Append styles if any
            var style = string.Join(";", Styles.Select(x => $"{x.Key}: {x.Value}"));
            if (!string.IsNullOrEmpty(style))
            {
                sb.Append($" style=\"{style}\"");
            }

            // Append attributes
            foreach (var attribute in Attributes)
            {
                sb.Append($" {attribute.Key}=\"{attribute.Value}\"");
            }

            sb.Append('>');

            // Append inner text
            if (!string.IsNullOrEmpty(InnerText))
            {
                sb.Append(InnerText);
            }

            // Append child elements
            foreach (var child in Childrens)
            {
                sb.Append(child.ToString());
            }

            sb.Append($"</{tag}>");

            return sb.ToString();
        }
    }
}
