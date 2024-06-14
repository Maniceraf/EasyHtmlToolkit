using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <img> (image) element.
    /// </summary>
    public class ImgTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImgTag"/> class with no attributes set initially.
        /// </summary>
        public ImgTag() : base(ETag.img) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImgTag"/> class with the specified src attribute and optional alt attribute.
        /// </summary>
        /// <param name="src">The src attribute value of the <img> element (required).</param>
        /// <param name="alt">The alt attribute value of the <img> element (optional).</param>
        public ImgTag(string src, string? alt = null) : base(ETag.img)
        {
            if (string.IsNullOrEmpty(src))
            {
                throw new ArgumentException("Src attribute must be provided for <img> element.");
            }

            AddAttribute("src", src);

            if (!string.IsNullOrEmpty(alt))
            {
                AddAttribute("alt", alt);
            }
        }

        /// <summary>
        /// Sets the src attribute value of the <img> element.
        /// </summary>
        /// <param name="src">The src attribute value.</param>
        public void SetSrc(string src)
        {
            if (string.IsNullOrEmpty(src))
            {
                throw new ArgumentException("Src attribute must not be null or empty.");
            }

            AddAttribute("src", src);
        }

        /// <summary>
        /// Sets the alt attribute value of the <img> element.
        /// </summary>
        /// <param name="alt">The alt attribute value.</param>
        public void SetAlt(string alt)
        {
            AddAttribute("alt", alt);
        }

        /// <summary>
        /// Sets the width attribute value of the <img> element.
        /// </summary>
        /// <param name="width">The width attribute value.</param>
        public void SetWidth(int width)
        {
            AddAttribute("width", width.ToString());
        }

        /// <summary>
        /// Sets the height attribute value of the <img> element.
        /// </summary>
        /// <param name="height">The height attribute value.</param>
        public void SetHeight(int height)
        {
            AddAttribute("height", height.ToString());
        }

        /// <summary>
        /// Sets the crossorigin attribute value of the <img> element.
        /// </summary>
        /// <param name="crossorigin">The crossorigin attribute value.</param>
        public void SetCrossOrigin(string crossorigin)
        {
            AddAttribute("crossorigin", crossorigin);
        }

        /// <summary>
        /// Sets the ismap attribute of the <img> element.
        /// </summary>
        public void SetIsMap()
        {
            AddAttribute("ismap", "ismap");
        }

        /// <summary>
        /// Sets the loading attribute value of the <img> element.
        /// </summary>
        /// <param name="loading">The loading attribute value.</param>
        public void SetLoading(string loading)
        {
            AddAttribute("loading", loading);
        }

        /// <summary>
        /// Sets the longdesc attribute value of the <img> element.
        /// </summary>
        /// <param name="longdesc">The longdesc attribute value.</param>
        public void SetLongDesc(string longdesc)
        {
            AddAttribute("longdesc", longdesc);
        }

        /// <summary>
        /// Sets the referrerpolicy attribute value of the <img> element.
        /// </summary>
        /// <param name="referrerpolicy">The referrerpolicy attribute value.</param>
        public void SetReferrerPolicy(string referrerpolicy)
        {
            AddAttribute("referrerpolicy", referrerpolicy);
        }

        /// <summary>
        /// Sets the sizes attribute value of the <img> element.
        /// </summary>
        /// <param name="sizes">The sizes attribute value.</param>
        public void SetSizes(string sizes)
        {
            AddAttribute("sizes", sizes);
        }

        /// <summary>
        /// Sets the srcset attribute value of the <img> element.
        /// </summary>
        /// <param name="srcset">The srcset attribute value.</param>
        public void SetSrcSet(string srcset)
        {
            AddAttribute("srcset", srcset);
        }

        /// <summary>
        /// Sets the usemap attribute value of the <img> element.
        /// </summary>
        /// <param name="usemap">The usemap attribute value.</param>
        public void SetUseMap(string usemap)
        {
            AddAttribute("usemap", usemap);
        }
    }
}
