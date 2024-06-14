using System;
using System.Text;

namespace EasyHtmlToolkit.Models
{
    public class HtmlElement(string tagName)
    {
        public string TagName { get; set; } = tagName;
        public string? InnerText { get; set; }
        public Dictionary<string, string> Attributes { get; set; } = [];
        public Dictionary<string, string> Styles { get; set; } = [];
        public List<HtmlElement> Childrens { get; set; } = [];

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

        public void AddEvent(string eventName, string jsFunction)
        {
            AddAttribute($"on{eventName}", jsFunction);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"<{TagName}");

            var style = string.Join(";", Styles.Select(x => $"{x.Key}: {x.Value}"));
            if (!string.IsNullOrEmpty(style))
            {
                sb.Append($" style=\"{style}\"");
            }

            foreach (var attribute in Attributes)
            {
                sb.Append($" {attribute.Key}=\"{attribute.Value}\"");
            }

            sb.Append(">");

            if (!string.IsNullOrEmpty(InnerText))
            {
                sb.Append(InnerText);
            }

            foreach (var child in Childrens)
            {
                sb.Append(child.ToString());
            }

            sb.Append($"</{TagName}>");

            return sb.ToString();
        }
    }
}
