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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/Header.cshtml")]
    public partial class _Views_Page_Header_cshtml : System.Web.Mvc.WebViewPage<Tutort.Web.ViewModels.Page.HeaderViewModel>
    {
        public _Views_Page_Header_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<header>\r\n    <div");

WriteLiteral(" id=\"top-header\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"home-account\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 9 "..\..\Views\Page\Header.cshtml"
                   Write(Html.ActionLink(Tutort.Web.Localization.Header.TopMenu_Home, "Index", "Home"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        ");

WriteLiteral("\r\n                        ");

WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n\r\n                    <div");

WriteLiteral(" class=\"cart-info\"");

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 847), Tuple.Create("\"", 909)
, Tuple.Create(Tuple.Create("", 854), Tuple.Create("tel:", 854), true)
            
            #line 20 "..\..\Views\Page\Header.cshtml"
, Tuple.Create(Tuple.Create("", 858), Tuple.Create<System.Object, System.Int32>(Tutort.Web.Localization.General.ContactPhoneStrict
            
            #line default
            #line hidden
, 858), false)
);

WriteLiteral(">");

            
            #line 20 "..\..\Views\Page\Header.cshtml"
                                                                                     Write(Tutort.Web.Localization.Header.ContactPhone);

            
            #line default
            #line hidden
WriteLiteral("</a>  &#8211;  ");

            
            #line 20 "..\..\Views\Page\Header.cshtml"
                                                                                                                                                Write(Tutort.Web.Localization.Header.ContactPhoneMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        ");

WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n       " +
" </div>\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"main-header\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"logo\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"/\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 1493), Tuple.Create("\"", 1541)
            
            #line 33 "..\..\Views\Page\Header.cshtml"
, Tuple.Create(Tuple.Create("", 1499), Tuple.Create<System.Object, System.Int32>(Url.Content("~/images/logo/logo_top.png")
            
            #line default
            #line hidden
, 1499), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 1542), Tuple.Create("\"", 1629)
            
            #line 33 "..\..\Views\Page\Header.cshtml"
                 , Tuple.Create(Tuple.Create("", 1550), Tuple.Create<System.Object, System.Int32>(Tutort.Web.Localization.General.Name
            
            #line default
            #line hidden
, 1550), false)
, Tuple.Create(Tuple.Create(" ", 1587), Tuple.Create("-", 1588), true)
            
            #line 33 "..\..\Views\Page\Header.cshtml"
                                                        , Tuple.Create(Tuple.Create(" ", 1589), Tuple.Create<System.Object, System.Int32>(Tutort.Web.Localization.General.Slogan
            
            #line default
            #line hidden
, 1590), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 1630), Tuple.Create("\"", 1715)
            
            #line 33 "..\..\Views\Page\Header.cshtml"
                                                                                                       , Tuple.Create(Tuple.Create("", 1636), Tuple.Create<System.Object, System.Int32>(Tutort.Web.Localization.General.Name
            
            #line default
            #line hidden
, 1636), false)
, Tuple.Create(Tuple.Create(" ", 1673), Tuple.Create("-", 1674), true)
            
            #line 33 "..\..\Views\Page\Header.cshtml"
                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 1675), Tuple.Create<System.Object, System.Int32>(Tutort.Web.Localization.General.Slogan
            
            #line default
            #line hidden
, 1676), false)
);

WriteLiteral("></a>\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"main-menu\"");

WriteLiteral(">\r\n                        <ul>\r\n                            ");

WriteLiteral("\r\n                            <li> ");

            
            #line 43 "..\..\Views\Page\Header.cshtml"
                            Write(Html.ActionLink(Tutort.Web.Localization.Header.MainMenu_Home, "Index", "Home"));

            
            #line default
            #line hidden
WriteLiteral(" </li>\r\n                            <li> ");

            
            #line 44 "..\..\Views\Page\Header.cshtml"
                            Write(Html.ActionLink(Tutort.Web.Localization.Header.MainMenu_Giveaways, "ShowList", "Giveaway"));

            
            #line default
            #line hidden
WriteLiteral(" </li>\r\n                        </ul>\r\n                    </div>\r\n              " +
"  </div>\r\n                <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"social-top\"");

WriteLiteral(">\r\n                        <ul>\r\n                            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2628), Tuple.Create("\"", 2683)
            
            #line 51 "..\..\Views\Page\Header.cshtml"
, Tuple.Create(Tuple.Create("", 2635), Tuple.Create<System.Object, System.Int32>(Tutort.Web.Localization.General.Media_Instagram
            
            #line default
            #line hidden
, 2635), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"fa fa-instagram\"");

WriteLiteral("></a></li>\r\n                            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2770), Tuple.Create("\"", 2818)
            
            #line 52 "..\..\Views\Page\Header.cshtml"
, Tuple.Create(Tuple.Create("", 2777), Tuple.Create<System.Object, System.Int32>(Tutort.Web.Localization.General.Media_VK
            
            #line default
            #line hidden
, 2777), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"fa fa-vk\"");

WriteLiteral("></a></li>\r\n                            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2898), Tuple.Create("\"", 2952)
            
            #line 53 "..\..\Views\Page\Header.cshtml"
, Tuple.Create(Tuple.Create("", 2905), Tuple.Create<System.Object, System.Int32>(Tutort.Web.Localization.General.Media_Facebook
            
            #line default
            #line hidden
, 2905), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"fa fa-facebook\"");

WriteLiteral("></a></li>\r\n                            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3038), Tuple.Create("\"", 3091)
            
            #line 54 "..\..\Views\Page\Header.cshtml"
, Tuple.Create(Tuple.Create("", 3045), Tuple.Create<System.Object, System.Int32>(Tutort.Web.Localization.General.Media_Twitter
            
            #line default
            #line hidden
, 3045), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"fa fa-twitter\"");

WriteLiteral("></a></li>\r\n                            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3176), Tuple.Create("\"", 3228)
            
            #line 55 "..\..\Views\Page\Header.cshtml"
, Tuple.Create(Tuple.Create("", 3183), Tuple.Create<System.Object, System.Int32>(Tutort.Web.Localization.General.Media_Tumblr
            
            #line default
            #line hidden
, 3183), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"fa fa-tumblr\"");

WriteLiteral("></a></li>\r\n                        </ul>\r\n                    </div>\r\n          " +
"          ");

WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</heade" +
"r>\r\n\r\n\r\n\r\n\r\n<div");

WriteLiteral(" class=\"modal fade bannerformmodal\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-labelledby=\"bannerformmodal\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" id=\"bannerformmodal\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog modal-sm\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</button>\r\n                    <h4");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(" id=\"myModalLabel\"");

WriteLiteral(">Contact Form</h4>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                    ");

WriteLiteral("\r\n\r\n                    ");

WriteLiteral("\r\n\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-blue\"");

WriteLiteral(">Submit</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n   " +
" </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591