using System.Text.RegularExpressions;

namespace EasyHtmlToolkit.Extensions
{
    public class FileMinimizer
    {
        public string GetMinimizedFileContent(string filePath)
        {
            try
            {
                // Read the file content
                string fileContent = File.ReadAllText(filePath);

                // Minimize the file content (remove comments, unnecessary whitespace, etc.)
                string minimizedContent = MinimizeContent(fileContent);

                return minimizedContent;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading or minimizing file: {ex.Message}");
                return null;
            }
        }

        private string MinimizeContent(string content)
        {
            // Remove comments (HTML, CSS, JS) and unnecessary whitespace
            content = RemoveComments(content);
            content = RemoveWhitespace(content);

            return content;
        }

        private string RemoveComments(string content)
        {
            // Remove HTML comments: <!-- ... -->
            content = Regex.Replace(content, @"<!--(.*?)-->", "", RegexOptions.Singleline);

            // Remove CSS comments: /* ... */
            content = Regex.Replace(content, @"/\*(.*?)\*/", "", RegexOptions.Singleline);

            // Remove JavaScript comments: // ... or /* ... */
            content = Regex.Replace(content, @"\/\/(.+?)\n|\/\*(.*?)\*\/", "", RegexOptions.Singleline);

            return content;
        }

        private string RemoveWhitespace(string content)
        {
            // Remove unnecessary whitespace using regex
            content = Regex.Replace(content, @"\s+", " ");

            return content;
        }
    }
}
