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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Giveaway/GiveawayList.cshtml")]
    public partial class _Views_Giveaway_GiveawayList_cshtml : System.Web.Mvc.WebViewPage<Tutort.Web.ViewModels.Giveaway.GiveawayListViewModel>
    {
        public _Views_Giveaway_GiveawayList_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Giveaway\GiveawayList.cshtml"
  
    ViewBag.Title = Tutort.Web.Localization.Giveaway.GiveawayList_Title;
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("HeadLine", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Views\Giveaway\GiveawayList.cshtml"
Write(Html.Partial("~/Views/Page/HeadLine.cshtml", Model.HeadLine));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n\r\n<div");

WriteLiteral(" id=\"products-post\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"Container\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..\Views\Giveaway\GiveawayList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Giveaway\GiveawayList.cshtml"
             foreach (var item in Model.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-md-3 col-sm-6 mix portfolio-item hamburger\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"portfolio-wrapper\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"portfolio-thumb\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 664), Tuple.Create("\"", 681)
            
            #line 21 "..\..\Views\Giveaway\GiveawayList.cshtml"
, Tuple.Create(Tuple.Create("", 671), Tuple.Create<System.Object, System.Int32>(item.Link
            
            #line default
            #line hidden
, 671), false)
);

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 687), Tuple.Create("\"", 704)
            
            #line 21 "..\..\Views\Giveaway\GiveawayList.cshtml"
, Tuple.Create(Tuple.Create("", 693), Tuple.Create<System.Object, System.Int32>(item.Image
            
            #line default
            #line hidden
, 693), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"label-text\"");

WriteLiteral(">\r\n                            <h3><a");

WriteAttribute("href", Tuple.Create(" href=\"", 837), Tuple.Create("\"", 854)
            
            #line 24 "..\..\Views\Giveaway\GiveawayList.cshtml"
, Tuple.Create(Tuple.Create("", 844), Tuple.Create<System.Object, System.Int32>(item.Link
            
            #line default
            #line hidden
, 844), false)
);

WriteLiteral(">");

            
            #line 24 "..\..\Views\Giveaway\GiveawayList.cshtml"
                                                Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</a></h3>\r\n                            <span");

WriteLiteral(" class=\"text-category\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\Giveaway\GiveawayList.cshtml"
                                                   Write(item.Date);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n            " +
"    </div>");

            
            #line 28 "..\..\Views\Giveaway\GiveawayList.cshtml"
                      }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
