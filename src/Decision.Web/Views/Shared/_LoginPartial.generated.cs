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
    
    #line 2 "..\..\Views\Shared\_LoginPartial.cshtml"
    using Auth=Decision.ServiceLayer.Security.AssignableToRolePermissions;
    
    #line default
    #line hidden
    using Decision.Common.MVC;
    
    #line 1 "..\..\Views\Shared\_LoginPartial.cshtml"
    using Decision.ServiceLayer.Security;
    
    #line default
    #line hidden
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_LoginPartial.cshtml")]
    public partial class _Views_Shared__LoginPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__LoginPartial_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"navbar-collapse collapse\"");

WriteLiteral(" id=\"navbar-main\"");

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"nav navbar-nav\"");

WriteLiteral(">\r\n");

            
            #line 5 "..\..\Views\Shared\_LoginPartial.cshtml"
        
            
            #line default
            #line hidden
            
            #line 5 "..\..\Views\Shared\_LoginPartial.cshtml"
         if (User.IsInRole(Auth.CanViewTeacherList))
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"main\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 8 "..\..\Views\Shared\_LoginPartial.cshtml"
           Write(Html.SecureActionLink("مدیریت اساتید", MVC.Teacher.List()));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n");

            
            #line 10 "..\..\Views\Shared\_LoginPartial.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("       \r\n");

            
            #line 12 "..\..\Views\Shared\_LoginPartial.cshtml"
        
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Shared\_LoginPartial.cshtml"
         if (User.IsInRole(Auth.CanAccessReports))
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"main\"");

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 525), Tuple.Create("\"", 564)
            
            #line 15 "..\..\Views\Shared\_LoginPartial.cshtml"
, Tuple.Create(Tuple.Create("", 532), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Report.Design())
            
            #line default
            #line hidden
, 532), false)
);

WriteLiteral(">گزارشات</a>\r\n            </li>\r\n");

            
            #line 17 "..\..\Views\Shared\_LoginPartial.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 18 "..\..\Views\Shared\_LoginPartial.cshtml"
         if (User.IsInRole(Auth.CanManageUser))
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"main\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Views\Shared\_LoginPartial.cshtml"
           Write(Html.SecureActionLink("مدیریت کاربران", MVC.User.List()));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n");

            
            #line 23 "..\..\Views\Shared\_LoginPartial.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 24 "..\..\Views\Shared\_LoginPartial.cshtml"
         if (User.IsInRole(Auth.CanAccessToSystemMaintenance))
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"main\"");

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 929), Tuple.Create("\"", 966)
            
            #line 27 "..\..\Views\Shared\_LoginPartial.cshtml"
, Tuple.Create(Tuple.Create("", 936), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Elmah.Index())
            
            #line default
            #line hidden
, 936), false)
);

WriteLiteral(">نگهداری سیستم</a>\r\n            </li>\r\n");

            
            #line 29 "..\..\Views\Shared\_LoginPartial.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("      ");

            
            #line 30 "..\..\Views\Shared\_LoginPartial.cshtml"
       if (Auth.GetBaseSettingPermissions().Any(User.IsInRole))
      {

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"main\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 33 "..\..\Views\Shared\_LoginPartial.cshtml"
       Write(Html.SecureActionLink("تنظیمات پایه", MVC.BaseSetting.Index()));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </li>\r\n");

            
            #line 35 "..\..\Views\Shared\_LoginPartial.cshtml"
      }

            
            #line default
            #line hidden
WriteLiteral("\r\n    </ul>\r\n    <ul");

WriteLiteral(" class=\"nav navbar-nav navbar-left\"");

WriteLiteral(">\r\n");

            
            #line 39 "..\..\Views\Shared\_LoginPartial.cshtml"
        
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Shared\_LoginPartial.cshtml"
         if (User.IsInRole(Auth.CanUsePrivateMessage))
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"dropdown noti-dropdown main\"");

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1416), Tuple.Create("\"", 1462)
            
            #line 42 "..\..\Views\Shared\_LoginPartial.cshtml"
, Tuple.Create(Tuple.Create("", 1423), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.PrivateMessage.InBox())
            
            #line default
            #line hidden
, 1423), false)
);

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"badge bage-noti digit\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Shared\_LoginPartial.cshtml"
                                                          Html.RenderAction(MVC.Home.GetNewMessagesCount());
            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    <span");

WriteLiteral(" class=\"fa fa-bell  animated infinite swing\"");

WriteLiteral("></span>\r\n                    پیغام جدید\r\n                </a>\r\n            </li>" +
"\r\n");

            
            #line 48 "..\..\Views\Shared\_LoginPartial.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("      \r\n        <li>\r\n            <div");

WriteLiteral(" id=\"dl-menu\"");

WriteLiteral(" class=\"dl-menuwrapper\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" class=\"dl-trigger\"");

WriteLiteral("></button>\r\n                <ul");

WriteLiteral(" class=\"dl-menu\"");

WriteLiteral(">\r\n                    <li>\r\n                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                            تنظیمات کاربری\r\n                        </a>\r\n    " +
"                </li>\r\n");

            
            #line 59 "..\..\Views\Shared\_LoginPartial.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Shared\_LoginPartial.cshtml"
                     if (User.IsInRole(Auth.CanUsePrivateMessage))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li>\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                                پیغام\r\n                                <span");

WriteLiteral(" class=\"fa fa-caret-left pull-left\"");

WriteLiteral("></span>\r\n                            </a>\r\n\r\n\r\n                            <ul");

WriteLiteral(" class=\"dl-submenu\"");

WriteLiteral(">\r\n                                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2494), Tuple.Create("\"", 2545)
            
            #line 69 "..\..\Views\Shared\_LoginPartial.cshtml"
, Tuple.Create(Tuple.Create("", 2501), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.PrivateMessage.NewMessage())
            
            #line default
            #line hidden
, 2501), false)
);

WriteLiteral(">پیغام جدید</a></li>\r\n                                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2606), Tuple.Create("\"", 2652)
            
            #line 70 "..\..\Views\Shared\_LoginPartial.cshtml"
, Tuple.Create(Tuple.Create("", 2613), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.PrivateMessage.InBox())
            
            #line default
            #line hidden
, 2613), false)
);

WriteLiteral(">صندوق دریافت</a></li>\r\n                                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2715), Tuple.Create("\"", 2762)
            
            #line 71 "..\..\Views\Shared\_LoginPartial.cshtml"
, Tuple.Create(Tuple.Create("", 2722), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.PrivateMessage.OutBox())
            
            #line default
            #line hidden
, 2722), false)
);

WriteLiteral(">صندوق ارسال</a></li>\r\n                            </ul>\r\n\r\n\r\n                   " +
"     </li>\r\n");

            
            #line 76 "..\..\Views\Shared\_LoginPartial.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 77 "..\..\Views\Shared\_LoginPartial.cshtml"
                     if (User.IsInRole(StandardRoles.Operators))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li>\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3028), Tuple.Create("\"", 3071)
            
            #line 80 "..\..\Views\Shared\_LoginPartial.cshtml"
, Tuple.Create(Tuple.Create("", 3035), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Teacher.ReferList())
            
            #line default
            #line hidden
, 3035), false)
);

WriteLiteral(">\r\n                                لیست ارجاعات\r\n                            </a>" +
"\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3185), Tuple.Create("\"", 3233)
            
            #line 83 "..\..\Views\Shared\_LoginPartial.cshtml"
, Tuple.Create(Tuple.Create("", 3192), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Teacher.NewTeacherList())
            
            #line default
            #line hidden
, 3192), false)
);

WriteLiteral(">\r\n                                اساتید در حال تکمیل\r\n                         " +
"   </a>\r\n                        </li>\r\n");

WriteLiteral("                        <li>\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3415), Tuple.Create("\"", 3455)
            
            #line 88 "..\..\Views\Shared\_LoginPartial.cshtml"
, Tuple.Create(Tuple.Create("", 3422), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Teacher.Create())
            
            #line default
            #line hidden
, 3422), false)
);

WriteLiteral(">\r\n                                درج استاد\r\n                            </a>\r\n " +
"                       </li>\r\n");

            
            #line 92 "..\..\Views\Shared\_LoginPartial.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <li>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3644), Tuple.Create("\"", 3684)
            
            #line 95 "..\..\Views\Shared\_LoginPartial.cshtml"
, Tuple.Create(Tuple.Create("", 3651), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Account.LogOff())
            
            #line default
            #line hidden
, 3651), false)
);

WriteLiteral(">\r\n                            خروج\r\n                        </a>\r\n              " +
"      </li>\r\n                </ul>\r\n            </div>\r\n            <!-- /dl-men" +
"uwrapper -->\r\n        </li>\r\n    </ul>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591