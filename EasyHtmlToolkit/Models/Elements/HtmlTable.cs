using System;
using System.Collections.Generic;
using System.Linq;
namespace EasyHtmlToolkit.Models.Elements
{
    public class HtmlTable : HtmlElement
    {
        public HtmlTable() : base("table")
        {
        }

        public void AddRow(HtmlRow row)
        {
            AddChild(row);
        }

        public void AddRowFromData(params string[] cellData)
        {
            var row = new HtmlRow();
            foreach (var data in cellData)
            {
                row.AddCell(new HtmlCell { InnerText = data });
            }
            AddRow(row);
        }
    }
}
