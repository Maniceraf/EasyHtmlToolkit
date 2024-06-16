# EasyHtmlToolkit

EasyHtmlToolkit is a lightweight and versatile C# library designed to simplify the generation and manipulation of HTML content programmatically. Whether you're creating dynamic web pages, generating HTML emails, or automating report generation, EasyHtmlToolkit provides an intuitive API to streamline the process.

## Project Overview:

EasyHtmlToolkit facilitates the creation and customization of HTML documents directly from C# code. It provides a set of classes and methods to generate HTML elements, manage attributes, handle events, and save generated HTML to files. This toolkit aims to simplify tasks that involve dynamic HTML generation, offering flexibility and ease of integration into C# applications.

## Getting Started:

### Installation:

You can install EasyHtmlToolkit via NuGet Package Manager:

```bash
Install-Package Maniceraf.EasyHtmlToolkit -Version 1.0.0
```

### Usage:

Here's a quick example of how to use EasyHtmlToolkit to generate a simple HTML document:

```csharp
using EasyHtmlToolkit;

class Program
{
    static void Main(string[] args)
    {
        // Create a new HTML document
        var document = new HtmlDocument();
        
        // Create a div element with some text content
        var div = new HtmlElement("div");
        div.InnerText = "Hello, EasyHtmlToolkit!";
        
        // Add the div element to the document body
        document.Body.AddChild(div);
        
        // Save the HTML document to a file
        document.SaveToFile("output.html");
        
        Console.WriteLine("HTML document generated successfully.");
    }
}
```

## Use Case:

I have encountered a number of tasks because the customer wanted that and assigned me the task to do in their system generate a report sent to them every day to their email the content in which needless to say is always There must be an attached excel file containing revenue report data information and some other tasks so they can track their business. But in this report, they want an html file that also has the same content as the excel file, but they still want it for convenience. As you know, the customer is king. But I realized that in the system, more and more reports like that were gradually being created with the need for an html file. and each report generates a different format, but in general the code is a lot and very complicated and difficult to fix bugs, so I decided to write this library to solve this common problem. If you need it, please refer to it.

## Contributing:

Contributions are welcome! If you have suggestions, improvements, or bug fixes, please submit a pull request or open an issue on GitHub.

## License:

This project is licensed under the MIT License - see the LICENSE file for details.
