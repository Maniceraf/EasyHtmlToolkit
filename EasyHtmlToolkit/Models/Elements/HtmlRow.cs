using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    public class HtmlRow : HtmlElement
    {
        public HtmlRow() : base(ETag.h1) { }

        public void AddCell(HtmlCell cell)
        {
            AddChildren(cell);
        }
    }
}
