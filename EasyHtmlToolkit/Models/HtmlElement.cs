using System.Text;

namespace EasyHtmlToolkit.Models
{
    public class HtmlElement(string tagName)
    {
        public string TagName { get; set; } = tagName;
        public string? InnerText { get; set; }
        public Dictionary<string, string> Attributes { get; set; } = [];
        public List<HtmlElement> Children { get; set; } = [];

        public void AddChild(HtmlElement child)
        {
            Children.Add(child);
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

            foreach (var attribute in Attributes)
            {
                sb.Append($" {attribute.Key}=\"{attribute.Value}\"");
            }

            sb.Append(">");

            if (!string.IsNullOrEmpty(InnerText))
            {
                sb.Append(InnerText);
            }

            foreach (var child in Children)
            {
                sb.Append(child.ToString());
            }

            sb.Append($"</{TagName}>");

            return sb.ToString();
        }
    }
}
