using EasyHtmlToolkit.Models.Elements;

namespace EasyHtmlToolkit.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var table = new HtmlTable();
            table.AddRowFromData("Header1", "Header2");
            table.AddRowFromData("Cell1", "Cell2");
            table.AddAttribute("border", "1");

            var div = new HtmlDiv();
            div.AddClass("container");
            div.AddChild(table);

            var anchor = new HtmlAnchor();
            anchor.SetHref("https://example.com");
            anchor.InnerText = "Click here";
            anchor.AddEvent("click", "alert('Hello World!')");
            div.AddChild(anchor);

            var doc = new HtmlDocument();
            doc.Body.AddChild(div);

            doc.SaveToDownloadsFolder();
        }
    }
}
