namespace EasyHtmlToolkit.Models.Elements
{
    public class HtmlRow : HtmlElement
    {
        public HtmlRow() : base("tr") { }

        public void AddCell(HtmlCell cell)
        {
            AddChild(cell);
        }
    }
}
