#pragma checksum "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Cities\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "780bf985c13b11c9bd3723e709b066e96cfcfc16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Cities_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Cities/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Cities/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Cities_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\_ViewImports.cshtml"
using BookShop;

#line default
#line hidden
#line 2 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\_ViewImports.cshtml"
using BookShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"780bf985c13b11c9bd3723e709b066e96cfcfc16", @"/Areas/Admin/Views/Cities/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee4735df80bb67d1ce7d40fc94d37240032cc50", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Cities_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Provice>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Cities\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(103, 141, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n\r\n        <div class=\"card\">\r\n            <div class=\"bg-light card-header\"> شهر های استان ");
            EndContext();
            BeginContext(245, 18, false);
#line 11 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Cities\Index.cshtml"
                                                        Write(Model.ProvinceName);

#line default
#line hidden
            EndContext();
            BeginContext(263, 204, true);
            WriteLiteral("</div>\r\n            <div class=\"card-body\">\r\n                <table class=\"table table-bordered table-striped\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>");
            EndContext();
            BeginContext(468, 48, false);
#line 16 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Cities\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ProvinceName));

#line default
#line hidden
            EndContext();
            BeginContext(516, 342, true);
            WriteLiteral(@"</th>
                            <th>
                                <span>نام شهر</span>
                            </th>
                            <th>
                                <span>عملیات</span>
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 26 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Cities\Index.cshtml"
                         foreach (var item in Model.City)
                        {

#line default
#line hidden
            BeginContext(944, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1015, 13, false);
#line 29 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Cities\Index.cshtml"
                               Write(item.CityName);

#line default
#line hidden
            EndContext();
            BeginContext(1028, 85, true);
            WriteLiteral("</td>\r\n\r\n                                <td>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1113, "\"", 1153, 2);
            WriteAttributeValue("", 1120, "/Admin/Books/Details/", 1120, 21, true);
#line 32 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Cities\Index.cshtml"
WriteAttributeValue("", 1141, item.CityID, 1141, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1154, 111, true);
            WriteLiteral(" class=\"btn btn-info btn-icon\"><i class=\"fa fa-eye text-white\"></i></a>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1265, "\"", 1302, 2);
            WriteAttributeValue("", 1272, "/Admin/Books/Edit/", 1272, 18, true);
#line 33 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Cities\Index.cshtml"
WriteAttributeValue("", 1290, item.CityID, 1290, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1303, 115, true);
            WriteLiteral(" class=\"btn btn-success btn-icon\"><i class=\"fa fa-edit text-white\"></i></a>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1418, "\"", 1457, 2);
            WriteAttributeValue("", 1425, "/Admin/Books/Delete/", 1425, 20, true);
#line 34 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Cities\Index.cshtml"
WriteAttributeValue("", 1445, item.CityID, 1445, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1458, 151, true);
            WriteLiteral(" class=\"btn btn-danger btn-icon\"><i class=\"fa fa-trash text-white\"></i></a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 37 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Cities\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1636, 119, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n             </div>\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Provice> Html { get; private set; }
    }
}
#pragma warning restore 1591