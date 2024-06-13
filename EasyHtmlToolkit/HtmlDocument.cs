using EasyHtmlToolkit.Models;
using System.Text;

namespace EasyHtmlToolkit
{
    public class HtmlDocument
    {
        public HtmlElement Head { get; set; }
        public HtmlElement Body { get; set; }

        public HtmlDocument()
        {
            Head = new HtmlElement("head");
            Body = new HtmlElement("body");
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("<!DOCTYPE html>");
            sb.Append("<html>");
            sb.Append(Head.ToString());
            sb.Append(Body.ToString());
            sb.Append("</html>");
            return sb.ToString();
        }

        public void SaveToFile(string directoryPath, string? fileName = null)
        {
            string filePath = Path.Combine(directoryPath, fileName ?? "index.html");

            if (!Directory.Exists(directoryPath))
            {
                var info = Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(filePath, ToString());
        }

        public bool TrySaveToFile(string directoryPath, string? fileName = null)
        {
            try
            {
                string filePath = Path.Combine(directoryPath, fileName ?? "index.html");

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.WriteAllText(filePath, ToString());

                return true;
            }
            catch { return false; }
        }

        public void SaveToDownloadsFolder(string? fileName = null)
        {
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string filePath = Path.Combine(downloadsPath, fileName ?? "index.html");
            File.WriteAllText(filePath, ToString());
        }
    }
}
