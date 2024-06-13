using System.Text;

namespace EasyHtmlToolkit.Models
{
    public class HtmlElement
    {
        public string TagName { get; set; }
        public string InnerText { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
        public List<HtmlElement> Children { get; set; }

        public HtmlElement(string tagName)
        {
            TagName = tagName;
            Attributes = [];
            Children = [];
        }

        public void AddAttribute(string key, string value)
        {
            Attributes[key] = value;
        }

        public void AddChild(HtmlElement child)
        {
            Children.Add(child);
        }

        public void AddClass(string className)
        {
            if (Attributes.ContainsKey("class"))
            {
                Attributes["class"] += " " + className;
            }
            else
            {
                Attributes["class"] = className;
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
