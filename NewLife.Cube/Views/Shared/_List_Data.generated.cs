﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 2 "..\..\Views\Shared\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Shared\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data.cshtml")]
    public partial class _Views_Shared__List_Data_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Shared\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var fk = fact.Unique;
    var set = ViewBag.PageSetting as PageSetting;

    var hasUser = fields.Any(f => f.Name.EqualIgnoreCase("CreateUserID", "UpdateUserID"));
    if (hasUser && ViewData["Provider"] == null) { ViewData["Provider"] = ManageProvider.Provider; }

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed table-data" +
"-list\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 18 "..\..\Views\Shared\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Shared\_List_Data.cshtml"
             if (set.EnableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\r\n");

            
            #line 21 "..\..\Views\Shared\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 22 "..\..\Views\Shared\_List_Data.cshtml"
             foreach (var item in fields)
            {
                var sortUrl = item.OriField != null ? page.GetSortUrl(item.OriField.Name) : page.GetSortUrl(item.Name);
                var width = item.Name.EndsWithIgnoreCase("Date") ? 80 : 134;
                if (item.Type == typeof(DateTime))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th");

WriteLiteral(" class=\"text-center\"");

WriteAttribute("style", Tuple.Create(" style=\"", 1182), Tuple.Create("\"", 1211)
, Tuple.Create(Tuple.Create("", 1190), Tuple.Create("min-width:", 1190), true)
            
            #line 28 "..\..\Views\Shared\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1200), Tuple.Create<System.Object, System.Int32>(width
            
            #line default
            #line hidden
, 1200), false)
, Tuple.Create(Tuple.Create("", 1208), Tuple.Create("px;", 1208), true)
);

WriteAttribute("title", Tuple.Create(" title=\"", 1212), Tuple.Create("\"", 1237)
            
            #line 28 "..\..\Views\Shared\_List_Data.cshtml"
 , Tuple.Create(Tuple.Create("", 1220), Tuple.Create<System.Object, System.Int32>(item.Description
            
            #line default
            #line hidden
, 1220), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1241), Tuple.Create("\"", 1266)
            
            #line 28 "..\..\Views\Shared\_List_Data.cshtml"
                             , Tuple.Create(Tuple.Create("", 1248), Tuple.Create<System.Object, System.Int32>(Html.Raw(sortUrl)
            
            #line default
            #line hidden
, 1248), false)
);

WriteLiteral(">");

            
            #line 28 "..\..\Views\Shared\_List_Data.cshtml"
                                                                                                                            Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a></th>\r\n");

            
            #line 29 "..\..\Views\Shared\_List_Data.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th");

WriteLiteral(" class=\"text-center\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1399), Tuple.Create("\"", 1424)
            
            #line 32 "..\..\Views\Shared\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1407), Tuple.Create<System.Object, System.Int32>(item.Description
            
            #line default
            #line hidden
, 1407), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1428), Tuple.Create("\"", 1453)
            
            #line 32 "..\..\Views\Shared\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1435), Tuple.Create<System.Object, System.Int32>(Html.Raw(sortUrl)
            
            #line default
            #line hidden
, 1435), false)
);

WriteLiteral(">");

            
            #line 32 "..\..\Views\Shared\_List_Data.cshtml"
                                                                                              Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a></th>\r\n");

            
            #line 33 "..\..\Views\Shared\_List_Data.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 35 "..\..\Views\Shared\_List_Data.cshtml"
             if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:100px;\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 38 "..\..\Views\Shared\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 42 "..\..\Views\Shared\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\Shared\_List_Data.cshtml"
         foreach (var entity in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 45 "..\..\Views\Shared\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Shared\_List_Data.cshtml"
                 if (set.EnableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1969), Tuple.Create("\"", 1993)
            
            #line 47 "..\..\Views\Shared\_List_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 1977), Tuple.Create<System.Object, System.Int32>(entity[fk.Name]
            
            #line default
            #line hidden
, 1977), false)
);

WriteLiteral(" /></td>\r\n");

            
            #line 48 "..\..\Views\Shared\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 49 "..\..\Views\Shared\_List_Data.cshtml"
                 foreach (var item in fields)
                {
                    
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Shared\_List_Data.cshtml"
               Write(Html.Partial("_List_Data_Item", new Pair(entity, item)));

            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Shared\_List_Data.cshtml"
                                                                            
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 53 "..\..\Views\Shared\_List_Data.cshtml"
                 if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 56 "..\..\Views\Shared\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 58 "..\..\Views\Shared\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 60 "..\..\Views\Shared\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 61 "..\..\Views\Shared\_List_Data.cshtml"
         if (page.State != null)
        {
            
            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\Shared\_List_Data.cshtml"
       Write(Html.Partial("_List_Data_Stat", page.State));

            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\Shared\_List_Data.cshtml"
                                                        
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
