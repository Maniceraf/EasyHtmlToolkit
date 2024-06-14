﻿using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    public class HtmlTd : HtmlElement
    {
        public HtmlTd(string value) : base(ETag.h1)
        {
            InnerText = value;
        }
    }
}
