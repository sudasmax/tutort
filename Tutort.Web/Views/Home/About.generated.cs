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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/About.cshtml")]
    public partial class _Views_Home_About_cshtml : System.Web.Mvc.WebViewPage<Tutort.Web.ViewModels.Home.AboutPageViewModel>
    {
        public _Views_Home_About_cshtml()
        {
        }
        public override void Execute()
        {
DefineSection("PageHeader", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 4 "..\..\Views\Home\About.cshtml"
Write(Html.Partial("~/Views/Page/HeadLine.cshtml", Model.HeadLine));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n<div");

WriteLiteral(" id=\"timeline-post\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"heading-section\"");

WriteLiteral(">\r\n                    <h2>Who We Are</h2>\r\n                    <img");

WriteLiteral(" src=\"images/under-heading.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(@">
                <h3>Our Company</h3>
                <p>Nulla sodales ut tellus blandit accumsan. Aliquam erat volutpat. Morbi quis vestibulum erat. Nam malesuada lobortis tempus. Fusce fermentum libero fringilla odio pharetra malesuada. Suspendisse potenti. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nullam ultrices lectus quis consequat fringilla. Mauris non ex et purus sollicitudin tempus vitae quis nisi.</p>
            </div>
            <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(@">
                <h3>Team Management</h3>
                <p>Suspendisse quis consectetur nisi, vitae consequat sem. In et quam id libero venenatis venenatis. Morbi vitae justo vulputate, auctor augue eu, pulvinar augue. Vestibulum placerat sem eu posuere laoreet. Ut ac ex nec urna maximus tristique interdum eget ipsum. Duis at pharetra neque, ut condimentum ex. Nunc tincidunt magna nec aliquam rhoncus. Morbi a posuere nunc.</p>
            </div>
        </div>

        <div");

WriteLiteral(" class=\"space50\"");

WriteLiteral("></div>\r\n\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-2 col-sm-4\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"timeline-thumb\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/timeline1.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"overlay\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"timeline-caption\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><h4>Breakfast</h4></a>\r\n                            <p>7:30 AM</p>\r\n            " +
"            </div>\r\n                    </div>\r\n                </div>\r\n        " +
"    </div>\r\n            <div");

WriteLiteral(" class=\"col-md-2 col-sm-4\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"timeline-thumb\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/timeline2.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"overlay\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"timeline-caption\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><h4>Lunch</h4></a>\r\n                            <p>11:20 AM</p>\r\n               " +
"         </div>\r\n                    </div>\r\n                </div>\r\n           " +
" </div>\r\n            <div");

WriteLiteral(" class=\"col-md-2 col-sm-4\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"timeline-thumb\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/timeline3.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"overlay\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"timeline-caption\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><h4>Lunch</h4></a>\r\n                            <p>1:00 PM</p>\r\n                " +
"        </div>\r\n                    </div>\r\n                </div>\r\n            " +
"</div>\r\n            <div");

WriteLiteral(" class=\"col-md-2 col-sm-4\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"timeline-thumb\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/timeline4.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"overlay\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"timeline-caption\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><h4>Dinner</h4></a>\r\n                            <p>6:30 PM</p>\r\n               " +
"         </div>\r\n                    </div>\r\n                </div>\r\n           " +
" </div>\r\n            <div");

WriteLiteral(" class=\"col-md-2 col-sm-4\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"timeline-thumb\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/timeline5.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"overlay\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"timeline-caption\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><h4>Dinner</h4></a>\r\n                            <p>8:20 PM</p>\r\n               " +
"         </div>\r\n                    </div>\r\n                </div>\r\n           " +
" </div>\r\n            <div");

WriteLiteral(" class=\"col-md-2 col-sm-4\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"timeline-thumb\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"thumb\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"images/timeline6.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"overlay\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"timeline-caption\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><h4>Dinner</h4></a>\r\n                            <p>9:10 PM</p>\r\n               " +
"         </div>\r\n                    </div>\r\n                </div>\r\n           " +
" </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div");

WriteLiteral(" id=\"our-team\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"heading-section\"");

WriteLiteral(">\r\n                    <h2>Our Team</h2>\r\n                    <img");

WriteLiteral(" src=\"images/under-heading.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"authors\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-3 col-sm-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"team-thumb\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"author\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" src=\"images/author1.jpg\"");

WriteLiteral(" alt=\"Tracy - templatemo\"");

WriteLiteral(">\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"overlay\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"author-caption\"");

WriteLiteral(">\r\n                                <ul>\r\n                                    <li>" +
"<a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-facebook\"");

WriteLiteral("></i></a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-twitter\"");

WriteLiteral("></i></a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-linkedin\"");

WriteLiteral("></i></a></li>\r\n                                </ul>\r\n                          " +
"  </div>\r\n                        </div>\r\n                    </div>\r\n          " +
"          <div");

WriteLiteral(" class=\"author-details\"");

WriteLiteral(">\r\n                        <h2>Tracy</h2>\r\n                        <span>Designer" +
"</span>\r\n                    </div>\r\n                </div>\r\n                <di" +
"v");

WriteLiteral(" class=\"col-md-3 col-sm-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"team-thumb\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"author\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" src=\"images/author2.jpg\"");

WriteLiteral(" alt=\"Mary - templatemo\"");

WriteLiteral(">\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"overlay\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"author-caption\"");

WriteLiteral(">\r\n                                <ul>\r\n                                    <li>" +
"<a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-facebook\"");

WriteLiteral("></i></a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-twitter\"");

WriteLiteral("></i></a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-linkedin\"");

WriteLiteral("></i></a></li>\r\n                                </ul>\r\n                          " +
"  </div>\r\n                        </div>\r\n                    </div>\r\n          " +
"          <div");

WriteLiteral(" class=\"author-details\"");

WriteLiteral(">\r\n                        <h2>Mary</h2>\r\n                        <span>Developer" +
"</span>\r\n                    </div>\r\n                </div>\r\n                <di" +
"v");

WriteLiteral(" class=\"col-md-3 col-sm-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"team-thumb\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"author\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" src=\"images/author3.jpg\"");

WriteLiteral(" alt=\"Julia - templatemo\"");

WriteLiteral(">\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"overlay\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"author-caption\"");

WriteLiteral(">\r\n                                <ul>\r\n                                    <li>" +
"<a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-facebook\"");

WriteLiteral("></i></a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-twitter\"");

WriteLiteral("></i></a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-linkedin\"");

WriteLiteral("></i></a></li>\r\n                                </ul>\r\n                          " +
"  </div>\r\n                        </div>\r\n                    </div>\r\n          " +
"          <div");

WriteLiteral(" class=\"author-details\"");

WriteLiteral(">\r\n                        <h2>Julia</h2>\r\n                        <span>Director" +
"</span>\r\n                    </div>\r\n                </div>\r\n                <di" +
"v");

WriteLiteral(" class=\"col-md-3 col-sm-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"team-thumb\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"author\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" src=\"images/author4.jpg\"");

WriteLiteral(" alt=\"Linda - templatemo\"");

WriteLiteral(">\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"overlay\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"author-caption\"");

WriteLiteral(">\r\n                                <ul>\r\n                                    <li>" +
"<a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-facebook\"");

WriteLiteral("></i></a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-twitter\"");

WriteLiteral("></i></a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-linkedin\"");

WriteLiteral("></i></a></li>\r\n                                </ul>\r\n                          " +
"  </div>\r\n                        </div>\r\n                    </div>\r\n          " +
"          <div");

WriteLiteral(" class=\"author-details\"");

WriteLiteral(">\r\n                        <h2>Linda</h2>\r\n                        <span>Manager<" +
"/span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n" +
"        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n<div");

WriteLiteral(" id=\"testimonails\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"heading-section\"");

WriteLiteral(">\r\n                    <h2>Testimonials and Awards</h2>\r\n                    <img" +
"");

WriteLiteral(" src=\"images/under-heading.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-8 col-md-offset-2\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"testimonails-slider\"");

WriteLiteral(">\r\n                    <ul");

WriteLiteral(" class=\"slides\"");

WriteLiteral(">\r\n                        <li>\r\n                            <div");

WriteLiteral(" class=\"testimonails-content\"");

WriteLiteral(@">
                                <p>Nam nec risus feugiat dui ultrices dignissim. Morbi ex purus, commodo a tristique eu, mollis a nisi. Pellentesque in enim sit amet tellus ornare fringilla eget eu arcu. Nam ultricies dolor et mi tempor, non pulvinar felis sollicitudin.</p>
                                <h6>Jennifer - <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Chief Designer</a></h6>\r\n                            </div>\r\n                   " +
"     </li>\r\n                        <li>\r\n                            <div");

WriteLiteral(" class=\"testimonails-content\"");

WriteLiteral(@">
                                <p>Fusce fermentum libero fringilla odio pharetra malesuada. Suspendisse potenti. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nullam ultrices lectus quis consequat fringilla. Mauris non ex et purus sollicitudin.</p>
                                <h6>Laureen - <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Marketing Executive</a></h6>\r\n                            </div>\r\n              " +
"          </li>\r\n                        <li>\r\n                            <div");

WriteLiteral(" class=\"testimonails-content\"");

WriteLiteral(@">
                                <p>Sed egestas tincidunt mollis. Suspendisse rhoncus vitae enim et faucibus. Ut dignissim nec arcu nec hendrerit sed arcu odio, sagittis vel diam in, malesuada malesuada risus. Aenean a sem leo. Nam ultricies dolor et mi tempor, non pulvinar felis sollicitudin.</p>
                                <h6>Tanya - <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Creative Director</a></h6>\r\n                            </div>\r\n                " +
"        </li>\r\n                    </ul>\r\n                </div>\r\n            </" +
"div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
