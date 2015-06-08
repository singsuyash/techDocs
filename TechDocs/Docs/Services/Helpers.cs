using Manoli.Utils.CSharpFormat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Docs.Services
{
    public static class Helpers
    {
        public static IHtmlString DisplayCode(this HtmlHelper helper, String code, String language)
        {
            HtmlString htmlString;
            switch (language.ToLower())
            {
                case "c#":
                    CSharpFormat csFormat = new CSharpFormat();
                    htmlString = new HtmlString(csFormat.FormatCode(code));
                    break;
                case "js":
                    JavaScriptFormat jsFormat = new JavaScriptFormat();
                    htmlString = new HtmlString(jsFormat.FormatCode(code));
                    break;
                default:
                    htmlString = new HtmlString(String.Empty);
                    break;
            }
            return htmlString;
        }
    }
}