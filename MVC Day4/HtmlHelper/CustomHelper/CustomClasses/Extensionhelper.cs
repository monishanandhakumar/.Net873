using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHelper.CustomClasses
{
    public static class Extensionhelper
    {
        public static IHtmlString LabelwithItalic(this HtmlHelper helper,string content)
        {
            string htmlstring = String.Format("<label><i><font color=red>{0}</font><i></label>", content);
            return new HtmlString(htmlstring);

        }


        public static IHtmlString Labelwithcolor(this HtmlHelper helper, string content)
        {
            string htmlstring = String.Format("<label><i><font color=green>{0}</font><i></label>", content);
            return new HtmlString(htmlstring);

        }
    }
}