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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/Footer.cshtml")]
    public partial class _Views_Page_Footer_cshtml : System.Web.Mvc.WebViewPage<Tutort.Web.ViewModels.Page.FooterViewModel>
    {
        public _Views_Page_Footer_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<footer>\r\n\t<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n\t\t");

WriteLiteral("\r\n\t\t");

WriteLiteral("\r\n\t\t<div");

WriteLiteral(" class=\"bottom-footer\"");

WriteLiteral(">\r\n\t\t\t<p>\r\n\t\t\t\t<span>\r\n\t\t\t\t\tCopyright © ");

            
            #line 103 "..\..\Views\Page\Footer.cshtml"
                           Write(DateTime.Now.Year);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 103 "..\..\Views\Page\Footer.cshtml"
                                              Write(Html.ActionLink(Tutort.Web.Localization.General.DomainNameShort, "Index", "Home"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t| ");

            
            #line 104 "..\..\Views\Page\Footer.cshtml"
                 Write(Tutort.Web.Localization.Footer.CopyrightMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t</span>\r\n\t\t\t</p>\r\n\t\t</div>\r\n\r\n\t</div>\r\n</footer>\r\n");

        }
    }
}
#pragma warning restore 1591
