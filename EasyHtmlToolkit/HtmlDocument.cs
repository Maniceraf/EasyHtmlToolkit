using EasyHtmlToolkit.Enums;
using EasyHtmlToolkit.Models;
using System.Text;

namespace EasyHtmlToolkit
{
    public class HtmlDocument
    {
        #region Fields

        public HtmlElement Head { get; set; }
        public HtmlElement Body { get; set; }

        #endregion

        #region Constructor

        public HtmlDocument()
        {
            Head = new HtmlElement(ETag.head);
            Body = new HtmlElement(ETag.body);
        }

        #endregion

        #region Public Methods

        public void AddStyle(string css)
        {
            var styleElement = new HtmlElement(ETag.style);
            styleElement.InnerText = css;
            Head.AddChildren(styleElement);
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

        public void SaveToFile1(string directoryPath, string? fileName = null)
        {
            byte[] htmlBytes = Encoding.UTF8.GetBytes(ToString());

            // Combine the folder path and file name
            string filePath = Path.Combine(directoryPath, fileName ?? "index.html");

            // Write the byte array to a file
            File.WriteAllBytes(filePath, htmlBytes);
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
            string name = fileName ?? "index";
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string filePath = Path.Combine(downloadsPath, $"{name}.html");

            if (File.Exists(filePath))
            {
                fileName = GetUniqueFileName(downloadsPath, name, ".html");
                filePath = Path.Combine(downloadsPath, fileName);
            }

            File.WriteAllText(filePath, ToString());
        }

        public byte[] GetFile()
        {
            byte[] htmlBytes = Encoding.UTF8.GetBytes(ToString());

            return htmlBytes;
        }

        #endregion

        #region Private Methods

        private static string GetUniqueFileName(string directoryPath, string fileNameWithoutExtension, string fileExtension)
        {
            int count = 1;
            string fileName = $"{fileNameWithoutExtension}{fileExtension}";
            string newFileName = fileName;

            while (File.Exists(Path.Combine(directoryPath, newFileName)))
            {
                newFileName = $"{fileNameWithoutExtension}_{count}{fileExtension}";
                count++;
            }

            return newFileName;
        }


        #endregion
    }
}