using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomHelper.CustomClasses
{
    
    public class Customhelper
    {
      //  int add();
      //  float sub();
        //static
        public static  IHtmlString LabelwithMark(string content)
        {
            string htmlstring = String.Format("<label><b><i>{0}<i/></b></label>",content);
            return new HtmlString(htmlstring);
        }
    }
}