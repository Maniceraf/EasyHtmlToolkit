namespace EasyHtmlToolkit.Models.Elements
{
    public class HtmlTh : HtmlElement
    {
        public HtmlTh(string value) : base("th")
        {
            InnerText = value;
        }
    }
}
