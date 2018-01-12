using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Xml.Linq;

namespace MyMVCApp
{
    public static class CustomHtmlHelpers
    {
        //Staic method

        public static IHtmlString EncodeAndFormatXmlForDisplayStatic(string xml, object htmlAttributes)
        {
            var builder = new TagBuilder("pre");
            builder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            var xDoc = new XDocument();
            try
            {
                xDoc = XDocument.Parse(xml);
                builder.SetInnerText(xDoc.ToString());
            }
            catch (Exception ex)
            {
                builder.SetInnerText("Xml was not well formed\n" + ex.Message);
            }

            return MvcHtmlString.Create(builder.ToString());
        }


        // Extension method
        public static IHtmlString EncodeAndFormatXmlForDisplayExtension(this HtmlHelper helper, string xml, object htmlAttributes)
        {
            var builder = new TagBuilder("pre");
            builder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            var xDoc = new XDocument();
            try
            {
                xDoc = XDocument.Parse(xml);
                builder.SetInnerText(xDoc.ToString());
            }
            catch (Exception ex)
            {
                builder.SetInnerText("Xml was not well formed\n" + ex.Message);
            }

            return MvcHtmlString.Create(builder.ToString());
        }

    }
}
