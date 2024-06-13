using EasyHtmlToolkit.Models;
using EasyHtmlToolkit.Models.Elements;

namespace EasyHtmlToolkit.Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Example1();
        }

        public static void Example1()
        {
            var doc = new HtmlDocument();

            var table = new HtmlTable();

            var tableHeader = new HtmlTableHeader();

            var tr = new HtmlTr();

            var th = new HtmlTh("Month");

            tr.AddChild(th);

            th = new HtmlTh("Savings");

            tr.AddChild(th);

            tableHeader.AddChild(tr);

            var tableBody = new HtmlTableBody();

            tr = new HtmlTr();

            tr.AddAttribute("style", "text-align:right");

            var td = new HtmlTd("January");

            tr.AddChild(td);

            td = new HtmlTd("$100");

            tr.AddChild(td);

            tableBody.AddChild(tr);

            table.AddChild(tableHeader);
            table.AddChild(tableBody);

            table.AddAttribute("style", "width:100%; border: 1px solid black");

            doc.Body.AddChild(table);

            doc.AddStyleToHead(@"table, th, td {
  border: 1px solid black;
}");

            doc.SaveToFile1("D:\\", "test1.html");
        }

        public static void Example2()
        {
            // Create a new HTML document
            var document = new HtmlDocument();

            // Create a button element
            var button = new HtmlElement("button");
            button.InnerText = "Click Me";

            // Set the accesskey attribute for the button (e.g., Alt + B)
            button.AddAttribute("accesskey", "b");

            // Add the button to the document body
            document.Body.AddChild(button);

            // Save the HTML document to a file
            document.SaveToDownloadsFolder();
        }
    }
}
