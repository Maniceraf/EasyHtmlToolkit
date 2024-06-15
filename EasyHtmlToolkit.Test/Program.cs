using EasyHtmlToolkit.Enums;
using EasyHtmlToolkit.Models;
using EasyHtmlToolkit.Models.Elements;

namespace EasyHtmlToolkit.Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            var b = new BTag("and this is bold text");
            var p = new PTag($"This is normal text - {b}.");

            var doc = new HtmlDocument();

            doc.Body.AddChildren(p);

            doc.SaveToDownloadsFolder();
        }

        public static void Example1()
        {
            var doc = new HtmlDocument();

            var table = new TableTag();

            var tableHeader = new TheadTag();

            var tr = new TrTag();

            var th = new ThTag("Month");

            tr.AddChildren(th);

            th = new ThTag("Savings");

            tr.AddChildren(th);

            tableHeader.AddChildren(tr);

            var tableBody = new TbodyTag();

            tr = new TrTag();

            tr.AddAttribute("style", "text-align:right");

            var td = new TdTag("January");

            tr.AddChildren(td);

            td = new TdTag("$100");

            tr.AddChildren(td);

            tableBody.AddChildren(tr);

            table.AddChildren(tableHeader);
            table.AddChildren(tableBody);

            table.AddAttribute("style", "width:100%; border: 1px solid black");

            doc.Body.AddChildren(table);

            doc.AddStyle(@"table, th, td {
              border: 1px solid black;
            }");

            doc.SaveToFile1("D:\\", "test1.html");
        }

        public static void Example2()
        {
            // Create a new HTML document
            var document = new HtmlDocument();

            // Create a button element
            var button = new HtmlElement(ETag.button);
            button.InnerText = "Click Me";

            // Set the accesskey attribute for the button (e.g., Alt + B)
            button.AddAttribute("accesskey", "b");

            // Add the button to the document body
            document.Body.AddChildren(button);

            // Save the HTML document to a file
            document.SaveToDownloadsFolder();
        }

        public static void Example3()
        {
            var h1 = new H1Tag("Happy niu year");

            h1.SetStyle("color", "blue");
            h1.SetStyle("color", "red");

            var doc = new HtmlDocument();

            doc.Body.AddChildren(h1);

            h1.SetStyle("color", "yellow");

            doc.SaveToDownloadsFolder();
        }
    }
}
