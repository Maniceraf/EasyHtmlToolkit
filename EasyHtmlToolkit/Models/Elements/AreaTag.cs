using EasyHtmlToolkit.Enums;

namespace EasyHtmlToolkit.Models.Elements
{
    /// <summary>
    /// Represents an HTML <area> element.
    /// </summary>
    public class AreaTag : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AreaTag"/> class.
        /// </summary>
        public AreaTag() : base(ETag.area) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AreaTag"/> class with the specified attributes.
        /// </summary>
        /// <param name="href">The href attribute of the <area> element.</param>
        /// <param name="shape">The shape attribute of the <area> element (e.g., "rect", "circle", "poly").</param>
        /// <param name="alt">The alt attribute of the <area> element (optional alternative text).</param>
        public AreaTag(string href, string shape, string? alt = null) : base(ETag.area)
        {
            if (string.IsNullOrEmpty(href))
            {
                throw new ArgumentException("Href attribute must be provided for <area> element.");
            }

            if (string.IsNullOrEmpty(shape))
            {
                throw new ArgumentException("Shape attribute must be provided for <area> element.");
            }

            AddAttribute("href", href);
            AddAttribute("shape", shape);

            if (!string.IsNullOrEmpty(alt))
            {
                AddAttribute("alt", alt);
            }
        }

        /// <summary>
        /// Sets the coords attribute value of the <area> element.
        /// </summary>
        /// <param name="coords">The coords attribute value (coordinates of the shape).</param>
        public void SetCoords(string coords)
        {
            AddAttribute("coords", coords);
        }

        /// <summary>
        /// Sets the download attribute value of the <area> element.
        /// </summary>
        /// <param name="filename">The filename to download.</param>
        public void SetDownload(string filename)
        {
            AddAttribute("download", filename);
        }

        /// <summary>
        /// Sets the hreflang attribute value of the <area> element.
        /// </summary>
        /// <param name="languageCode">The language code of the target URL.</param>
        public void SetHrefLang(string languageCode)
        {
            AddAttribute("hreflang", languageCode);
        }

        /// <summary>
        /// Sets the media attribute value of the <area> element.
        /// </summary>
        /// <param name="mediaQuery">The media query specifying what media/device the target URL is optimized for.</param>
        public void SetMedia(string mediaQuery)
        {
            AddAttribute("media", mediaQuery);
        }

        /// <summary>
        /// Sets the referrerpolicy attribute value of the <area> element.
        /// </summary>
        /// <param name="policy">The referrer policy to send with the link.</param>
        public void SetReferrerPolicy(string policy)
        {
            AddAttribute("referrerpolicy", policy);
        }

        /// <summary>
        /// Sets the rel attribute value of the <area> element.
        /// </summary>
        /// <param name="relationship">The relationship between the current document and the target URL.</param>
        public void SetRel(string relationship)
        {
            AddAttribute("rel", relationship);
        }

        /// <summary>
        /// Sets the target attribute value of the <area> element.
        /// </summary>
        /// <param name="target">The target window or frame where the linked document will open.</param>
        public void SetTarget(string target)
        {
            AddAttribute("target", target);
        }

        /// <summary>
        /// Sets the type attribute value of the <area> element.
        /// </summary>
        /// <param name="mediaType">The media type of the target URL.</param>
        public void SetType(string mediaType)
        {
            AddAttribute("type", mediaType);
        }
    }
}
