using EasyHtmlToolkit.Enums;
using System;
using System.Text;

namespace EasyHtmlToolkit.Models
{
    public class HtmlElement(ETag tagName)
    {
        /// <summary>
        /// Gets tag name of element.
        /// </summary>
        public ETag TagName { get; } = tagName;

        /// <summary>
        /// Gets or Sets inner text to element.
        /// </summary>
        public string? InnerText { get; set; }
        private Dictionary<string, string> Attributes { get; set; } = [];
        private Dictionary<string, string> Styles { get; set; } = [];
        private List<HtmlElement> Childrens { get; set; } = [];

        public void AddChildren(HtmlElement children)
        {
            Childrens.Add(children);
        }

        public void AddAttribute(string key, string value)
        {
            Attributes[key] = value;
        }

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
        /// Set a style for element with name and value.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void SetStyle(string name, string value)
        {
            if (Styles.ContainsKey(name))
            {
                Styles[name] = value;
            }
            else
            {
                Styles.TryAdd(name, value);
            }
        }

        public void AddEvent(string eventName, string jsFunction)
        {
            AddAttribute($"on{eventName}", jsFunction);
        }

        public override string ToString()
        {
            var tag = TagName.ToString();

            var sb = new StringBuilder();
            sb.Append($"<{tag}");

            var style = string.Join(";", Styles.Select(x => $"{x.Key}: {x.Value}"));
            if (!string.IsNullOrEmpty(style))
            {
                sb.Append($" style=\"{style}\"");
            }

            foreach (var attribute in Attributes)
            {
                sb.Append($" {attribute.Key}=\"{attribute.Value}\"");
            }

            sb.Append('>');

            if (!string.IsNullOrEmpty(InnerText))
            {
                sb.Append(InnerText);
            }

            foreach (var child in Childrens)
            {
                sb.Append(child.ToString());
            }

            sb.Append($"</{tag}>");

            return sb.ToString();
        }
    }
}
