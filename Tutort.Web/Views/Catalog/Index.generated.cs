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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Catalog/Index.cshtml")]
    public partial class _Views_Catalog_Index_cshtml : System.Web.Mvc.WebViewPage<Tutort.Web.Models.ViewModels.Catalog.CatalogViewModel>
    {
        public _Views_Catalog_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n");

            
            #line 7 "..\..\Views\Catalog\Index.cshtml"
Write(Html.Action("PageHeader", "Page", new { title = "test" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" id=\"products-post\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" id=\"product-heading\"");

WriteLiteral(">\r\n                    <h2>");

            
            #line 14 "..\..\Views\Catalog\Index.cshtml"
                   Write(Tutort.Web.Localization.Catalog.Catalog_Subtitle);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                    <img");

WriteLiteral(" src=\"images/under-heading.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"filters col-md-12 col-xs-12\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" id=\"filters\"");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n                    <li><span");

WriteLiteral(" class=\"filter\"");

WriteLiteral(" data-filter=\"all\"");

WriteLiteral(">");

            
            #line 22 "..\..\Views\Catalog\Index.cshtml"
                                                          Write(Tutort.Web.Localization.Catalog.Catalog_All);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                    <li><span");

WriteLiteral(" class=\"filter\"");

WriteLiteral(" data-filter=\".cakes\"");

WriteLiteral(">");

            
            #line 23 "..\..\Views\Catalog\Index.cshtml"
                                                             Write(Tutort.Web.Localization.Catalog.Catalog_Cakes);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                    <li><span");

WriteLiteral(" class=\"filter\"");

WriteLiteral(" data-filter=\".cheesecakes\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\Catalog\Index.cshtml"
                                                                   Write(Tutort.Web.Localization.Catalog.Catalog_Cheesecakes);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                    <li><span");

WriteLiteral(" class=\"filter\"");

WriteLiteral(" data-filter=\".cupcakes\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\Catalog\Index.cshtml"
                                                                Write(Tutort.Web.Localization.Catalog.Catalog_Cupcakes);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                    <li><span");

WriteLiteral(" class=\"filter\"");

WriteLiteral(" data-filter=\".zefir\"");

WriteLiteral(">");

            
            #line 26 "..\..\Views\Catalog\Index.cshtml"
                                                             Write(Tutort.Web.Localization.Catalog.Catalog_Zefir);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        " +
"<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"Container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-3 col-sm-6 mix portfolio-item Pizza\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"portfolio-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"portfolio-thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/product1.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"hover\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"hover-iner\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"fancybox\"");

WriteLiteral(" href=\"images/product1_big.jpg\"");

WriteLiteral("><img");

WriteLiteral(" src=\"images/open-icon.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                                <span>Pizza</span>\r\n                    " +
"        </div>\r\n                        </div>\r\n                    </div>\r\n    " +
"                <div");

WriteLiteral(" class=\"label-text\"");

WriteLiteral(">\r\n                        <h3><a");

WriteLiteral(" href=\"single-post.html\"");

WriteLiteral(">Vege Pizza</a></h3>\r\n                        <span");

WriteLiteral(" class=\"text-category\"");

WriteLiteral(">$16.00</span>\r\n                    </div>\r\n                </div>\r\n            <" +
"/div>\r\n            <div");

WriteLiteral(" class=\"col-md-3 col-sm-6 mix portfolio-item ginger\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"portfolio-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"portfolio-thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/product2.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"hover\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"hover-iner\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"fancybox\"");

WriteLiteral(" href=\"images/product2_big.jpg\"");

WriteLiteral("><img");

WriteLiteral(" src=\"images/open-icon.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                                <span>Ginger</span>\r\n                   " +
"         </div>\r\n                        </div>\r\n                    </div>\r\n   " +
"                 <div");

WriteLiteral(" class=\"label-text\"");

WriteLiteral(">\r\n                        <h3><a");

WriteLiteral(" href=\"single-post.html\"");

WriteLiteral(">Ginger Tea</a></h3>\r\n                        <span");

WriteLiteral(" class=\"text-category\"");

WriteLiteral(">$24.00</span>\r\n                    </div>\r\n                </div>\r\n            <" +
"/div>\r\n            <div");

WriteLiteral(" class=\"col-md-3 col-sm-6 mix portfolio-item pizza\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"portfolio-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"portfolio-thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/product3.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"hover\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"hover-iner\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"fancybox\"");

WriteLiteral(" href=\"images/product3_big.jpg\"");

WriteLiteral("><img");

WriteLiteral(" src=\"images/open-icon.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                                <span>Pizza</span>\r\n                    " +
"        </div>\r\n                        </div>\r\n                    </div>\r\n    " +
"                <div");

WriteLiteral(" class=\"label-text\"");

WriteLiteral(">\r\n                        <h3><a");

WriteLiteral(" href=\"single-post.html\"");

WriteLiteral(">Fresh Salad</a></h3>\r\n                        <span");

WriteLiteral(" class=\"text-category\"");

WriteLiteral(">$12.00</span>\r\n                    </div>\r\n                </div>\r\n            <" +
"/div>\r\n            <div");

WriteLiteral(" class=\"col-md-3 col-sm-6 mix portfolio-item pasta\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"portfolio-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"portfolio-thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/product4.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"hover\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"hover-iner\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"fancybox\"");

WriteLiteral(" href=\"images/product4_big.jpg\"");

WriteLiteral("><img");

WriteLiteral(" src=\"images/open-icon.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                                <span>Pasta</span>\r\n                    " +
"        </div>\r\n                        </div>\r\n                    </div>\r\n    " +
"                <div");

WriteLiteral(" class=\"label-text\"");

WriteLiteral(">\r\n                        <h3><a");

WriteLiteral(" href=\"single-post.html\"");

WriteLiteral(">Healthy Herbal Tea</a></h3>\r\n                        <span");

WriteLiteral(" class=\"text-category\"");

WriteLiteral(">$8.00</span>\r\n                    </div>\r\n                </div>\r\n            </" +
"div>\r\n            <div");

WriteLiteral(" class=\"col-md-3 col-sm-6 mix portfolio-item drink\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"portfolio-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"portfolio-thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/product5.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"hover\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"hover-iner\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"fancybox\"");

WriteLiteral(" href=\"images/product5_big.jpg\"");

WriteLiteral("><img");

WriteLiteral(" src=\"images/open-icon.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                                <span>Drink</span>\r\n                    " +
"        </div>\r\n                        </div>\r\n                    </div>\r\n    " +
"                <div");

WriteLiteral(" class=\"label-text\"");

WriteLiteral(">\r\n                        <h3><a");

WriteLiteral(" href=\"single-post.html\"");

WriteLiteral(">Fruit Salad</a></h3>\r\n                        <span");

WriteLiteral(" class=\"text-category\"");

WriteLiteral(">$12.50</span>\r\n                    </div>\r\n                </div>\r\n            <" +
"/div>\r\n            <div");

WriteLiteral(" class=\"col-md-3 col-sm-6 mix portfolio-item hamburger\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"portfolio-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"portfolio-thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/product6.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"hover\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"hover-iner\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"fancybox\"");

WriteLiteral(" href=\"images/product6_big.jpg\"");

WriteLiteral("><img");

WriteLiteral(" src=\"images/open-icon.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                                <span>Hamburger</span>\r\n                " +
"            </div>\r\n                        </div>\r\n                    </div>\r\n" +
"                    <div");

WriteLiteral(" class=\"label-text\"");

WriteLiteral(">\r\n                        <h3><a");

WriteLiteral(" href=\"single-post.html\"");

WriteLiteral(">Spicy Hamburger</a></h3>\r\n                        <span");

WriteLiteral(" class=\"text-category\"");

WriteLiteral(">$7.50</span>\r\n                    </div>\r\n                </div>\r\n            </" +
"div>\r\n            <div");

WriteLiteral(" class=\"col-md-3 col-sm-6 mix portfolio-item pizza\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"portfolio-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"portfolio-thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/product7.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"hover\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"hover-iner\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"fancybox\"");

WriteLiteral(" href=\"images/product7_big.jpg\"");

WriteLiteral("><img");

WriteLiteral(" src=\"images/open-icon.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                                <span>Pizza</span>\r\n                    " +
"        </div>\r\n                        </div>\r\n                    </div>\r\n    " +
"                <div");

WriteLiteral(" class=\"label-text\"");

WriteLiteral(">\r\n                        <h3><a");

WriteLiteral(" href=\"single-post.html\"");

WriteLiteral(">Chocolate Cake</a></h3>\r\n                        <span");

WriteLiteral(" class=\"text-category\"");

WriteLiteral(">$16.00</span>\r\n                    </div>\r\n                </div>\r\n            <" +
"/div>\r\n            <div");

WriteLiteral(" class=\"col-md-3 col-sm-6 mix portfolio-item pasta\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"portfolio-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"portfolio-thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/product8.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"hover\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"hover-iner\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"fancybox\"");

WriteLiteral(" href=\"images/product8_big.jpg\"");

WriteLiteral("><img");

WriteLiteral(" src=\"images/open-icon.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                                <span>Pasta</span>\r\n                    " +
"        </div>\r\n                        </div>\r\n                    </div>\r\n    " +
"                <div");

WriteLiteral(" class=\"label-text\"");

WriteLiteral(">\r\n                        <h3><a");

WriteLiteral(" href=\"single-post.html\"");

WriteLiteral(">Berry Taste</a></h3>\r\n                        <span");

WriteLiteral(" class=\"text-category\"");

WriteLiteral(">$15.00</span>\r\n                    </div>\r\n                </div>\r\n            <" +
"/div>\r\n            <div");

WriteLiteral(" class=\"col-md-3 col-sm-6 mix portfolio-item hamburger\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"portfolio-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"portfolio-thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/product3.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"hover\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"hover-iner\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"fancybox\"");

WriteLiteral(" href=\"images/product3_big.jpg\"");

WriteLiteral("><img");

WriteLiteral(" src=\"images/open-icon.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                                <span>Hamburger</span>\r\n                " +
"            </div>\r\n                        </div>\r\n                    </div>\r\n" +
"                    <div");

WriteLiteral(" class=\"label-text\"");

WriteLiteral(">\r\n                        <h3><a");

WriteLiteral(" href=\"single-post.html\"");

WriteLiteral(">Onion Grilled</a></h3>\r\n                        <span");

WriteLiteral(" class=\"text-category\"");

WriteLiteral(">$16.00</span>\r\n                    </div>\r\n                </div>\r\n            <" +
"/div>\r\n            <div");

WriteLiteral(" class=\"col-md-3 col-sm-6 mix portfolio-item drink\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"portfolio-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"portfolio-thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/product2.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"hover\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"hover-iner\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"fancybox\"");

WriteLiteral(" href=\"images/product2_big.jpg\"");

WriteLiteral("><img");

WriteLiteral(" src=\"images/open-icon.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                                <span>Drink</span>\r\n                    " +
"        </div>\r\n                        </div>\r\n                    </div>\r\n    " +
"                <div");

WriteLiteral(" class=\"label-text\"");

WriteLiteral(">\r\n                        <h3><a");

WriteLiteral(" href=\"single-post.html\"");

WriteLiteral(">Another Ginger</a></h3>\r\n                        <span");

WriteLiteral(" class=\"text-category\"");

WriteLiteral(">$18.00</span>\r\n                    </div>\r\n                </div>\r\n            <" +
"/div>\r\n            <div");

WriteLiteral(" class=\"col-md-3 col-sm-6 mix portfolio-item ginger\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"portfolio-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"portfolio-thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/product1.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"hover\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"hover-iner\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"fancybox\"");

WriteLiteral(" href=\"images/product1_big.jpg\"");

WriteLiteral("><img");

WriteLiteral(" src=\"images/open-icon.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                                <span>Ginger</span>\r\n                   " +
"         </div>\r\n                        </div>\r\n                    </div>\r\n   " +
"                 <div");

WriteLiteral(" class=\"label-text\"");

WriteLiteral(">\r\n                        <h3><a");

WriteLiteral(" href=\"single-post.html\"");

WriteLiteral(">Mocha Coffee</a></h3>\r\n                        <span");

WriteLiteral(" class=\"text-category\"");

WriteLiteral(">$16.00</span>\r\n                    </div>\r\n                </div>\r\n            <" +
"/div>\r\n            <div");

WriteLiteral(" class=\"col-md-3 col-sm-6 mix portfolio-item pasta\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"portfolio-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"portfolio-thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/product6.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"hover\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"hover-iner\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"fancybox\"");

WriteLiteral(" href=\"images/product6_big.jpg\"");

WriteLiteral("><img");

WriteLiteral(" src=\"images/open-icon.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                                <span>Pasta</span>\r\n                    " +
"        </div>\r\n                        </div>\r\n                    </div>\r\n    " +
"                <div");

WriteLiteral(" class=\"label-text\"");

WriteLiteral(">\r\n                        <h3><a");

WriteLiteral(" href=\"single-post.html\"");

WriteLiteral(">Dessert Time</a></h3>\r\n                        <span");

WriteLiteral(" class=\"text-category\"");

WriteLiteral(">$16.00</span>\r\n                    </div>\r\n                </div>\r\n            <" +
"/div>\r\n        </div>\r\n        ");

WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
