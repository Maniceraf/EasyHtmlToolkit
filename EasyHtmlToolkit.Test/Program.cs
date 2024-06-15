using EasyHtmlToolkit.Enums;
using EasyHtmlToolkit.Models;
using EasyHtmlToolkit.Models.Elements;
using EasyHtmlToolkit.Test.Models;

namespace EasyHtmlToolkit.Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product("Product 1", 19.99m, "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/325800/redmi-13-blue-thumb-600x600.jpg", "Description of Product 1", "Category A", "Manufacturer 1", 50, new DateTime(2023, 1, 1)),
                new Product("Product 2", 29.99m, "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/320461/xiaomi-redmi-note-13-green-thumb-600x600.jpg", "Description of Product 2", "Category B", "Manufacturer 2", 30, new DateTime(2023, 2, 1)),
                new Product("Product 3", 39.99m, "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/320734/xiaomi-redmi-a3-xanh-l%C3%A1-thumb-600x600.jpg", "Description of Product 3", "Category A", "Manufacturer 3", 20, new DateTime(2023, 3, 1)),
                new Product("Product 4", 49.99m, "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/316771/xiaomi-redmi-13c-xanh-la-1-2-3-600x600.jpg", "Description of Product 4", "Category C", "Manufacturer 1", 100, new DateTime(2023, 4, 1)),
                new Product("Product 5", 59.99m, "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/322069/xiaomi-redmi-note-13-purple-thumb-600x600.jpg", "Description of Product 5", "Category B", "Manufacturer 2", 60, new DateTime(2023, 5, 1)),
                new Product("Product 6", 69.99m, "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/313889/xiaomi-14-ultra-white-thumbnew-600x600.jpg", "Description of Product 6", "Category C", "Manufacturer 3", 10, new DateTime(2023, 6, 1)),
                new Product("Product 7", 79.99m, "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/522/325988/redmi-pad-pro-grey-thumb-1-600x600.jpg", "Description of Product 7", "Category A", "Manufacturer 1", 40, new DateTime(2023, 7, 1)),
                new Product("Product 8", 89.99m, "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/325799/redmi-13-yellow-thumb-600x600.jpg", "Description of Product 8", "Category B", "Manufacturer 2", 70, new DateTime(2023, 8, 1)),
                new Product("Product 9", 99.99m, "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/307556/xiaomi-redmi-12-den-thumb-text-600x600.jpg", "Description of Product 9", "Category C", "Manufacturer 3", 90, new DateTime(2023, 9, 1)),
                new Product("Product 10", 109.99m, "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/319670/xiaomi-redmi-note-13-pro-5g-violet-thumb-600x600.jpg", "Description of Product 10", "Category A", "Manufacturer 1", 25, new DateTime(2023, 10, 1))
            };

            var table = new TableTag();
            table.AddAttribute("style", "width:100%");

            var head = new TheadTag();
            head.AddAttribute("style", "background-color:#00FF00");

            var tr = new TrTag();
            tr.AddAttribute("style", "padding: 5px");

            var th = new ThTag("Product");
            tr.AddChildren(th);

            th = new ThTag("Price");
            tr.AddChildren(th);

            th = new ThTag("Description");
            tr.AddChildren(th);

            th = new ThTag("Category");
            tr.AddChildren(th);

            th = new ThTag("Manufacturer");
            tr.AddChildren(th);

            th = new ThTag("StockQuantity");
            tr.AddChildren(th);

            th = new ThTag("Image");
            tr.AddChildren(th);

            head.AddChildren(tr);

            table.AddChildren(head);

            var body = new TbodyTag();
            body.AddAttribute("style", "background-color: aliceblue;");

            foreach (var product in products)
            {
                tr = new TrTag();

                var td = new TdTag(product.Name.ToString());
                tr.AddChildren(td);

                td = new TdTag(product.Price.ToString());
                tr.AddChildren(td);

                td = new TdTag(product.Description.ToString());
                tr.AddChildren(td);

                td = new TdTag(product.Category.ToString());
                tr.AddChildren(td);

                td = new TdTag(product.Manufacturer.ToString());
                tr.AddChildren(td);

                td = new TdTag(product.StockQuantity.ToString());
                tr.AddChildren(td);

                td = new TdTag("");
                var img = new ImgTag(product.ImageUrl.ToString());
                img.SetWidth(200);
                img.SetHeight(200);
                td.AddChildren(img);
                tr.AddChildren(td);

                body.AddChildren(tr);
            }

            table.AddChildren(body);

            var doc = new HtmlDocument();

            doc.AddStyle(@"table, th, td {
              border: 1px solid black;
              border-collapse: collapse;
              text-align: center;
                padding-top: 10px;
                padding-bottom: 10px;
            }");
            doc.Body.AddChildren(table);
            

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
