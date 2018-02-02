using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCApp.Models
{
    public class HtmlHelpers
    {
        public HtmlHelpers()
        {
            WellFormedXml = @"<contact><name>Mark Baird</name><phone type='mobile'>651-442-9504</phone></contact>";
            MalformedXml = "<contact><name>Mark Baird</name><phone type='mobile'>651-442-9504</contact>";
        }

        public string WellFormedXml { get; set; }
        public string MalformedXml { get; set; }

    }
}