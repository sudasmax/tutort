﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Tutort.Web;
    
    #line 2 "..\..\Views\Page\HeadLine.cshtml"
    using Tutort.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/HeadLine.cshtml")]
    public partial class _Views_Page_HeadLine_cshtml : System.Web.Mvc.WebViewPage<Tutort.Web.ViewModels.Page.HeadLineViewModel>
    {
        public _Views_Page_HeadLine_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"heading\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"heading-content\"");

WriteLiteral(">\r\n                    <h2>");

            
            #line 9 "..\..\Views\Page\HeadLine.cshtml"
                   Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                    <span>");

            
            #line 10 "..\..\Views\Page\HeadLine.cshtml"
                     Write(Model.ToNavigationMenu(" / "));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n" +
"</div>\r\n");

        }
    }
}
#pragma warning restore 1591
