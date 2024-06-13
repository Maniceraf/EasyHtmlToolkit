namespace EasyHtmlToolkit.Models.Elements
{
    public class HtmlTd : HtmlElement
    {
        public HtmlTd(string value) : base("th")
        {
            InnerText = value;
        }
    }
}
