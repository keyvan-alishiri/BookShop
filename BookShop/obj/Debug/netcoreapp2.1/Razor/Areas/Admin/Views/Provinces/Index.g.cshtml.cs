#pragma checksum "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Provinces\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8010f9c8ccba9729b2d083a81b24f3daa64c3971"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Provinces_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Provinces/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Provinces/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Provinces_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8010f9c8ccba9729b2d083a81b24f3daa64c3971", @"/Areas/Admin/Views/Provinces/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee4735df80bb67d1ce7d40fc94d37240032cc50", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Provinces_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Provice>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Provinces\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(116, 250, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card\">\r\n            <div class=\"bg-light card-header\">\r\n                استان ها\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(366, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75aebef7926849959ff35ff942d3d9f6", async() => {
                BeginContext(413, 17, true);
                WriteLiteral("افزودن استان جدید");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(434, 184, true);
            WriteLiteral("\r\n                </p>\r\n                <table class=\"table table-bordered table-striped\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th> ");
            EndContext();
            BeginContext(619, 48, false);
#line 20 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Provinces\Index.cshtml"
                            Write(Html.DisplayNameFor(model => model.ProvinceName));

#line default
#line hidden
            EndContext();
            BeginContext(667, 361, true);
            WriteLiteral(@"</th>
                            <th class=""text-center"">
                                شهرهای استان
                            </th>
                            <th class=""text-center"">
                                عملیات
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 30 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Provinces\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1109, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1180, 17, false);
#line 33 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Provinces\Index.cshtml"
                               Write(item.ProvinceName);

#line default
#line hidden
            EndContext();
            BeginContext(1197, 103, true);
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1300, "\"", 1343, 2);
            WriteAttributeValue("", 1307, "/Admin/Cities/Index/", 1307, 20, true);
#line 35 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Provinces\Index.cshtml"
WriteAttributeValue("", 1327, item.ProvinceID, 1327, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1344, 182, true);
            WriteLiteral(" class=\"btn btn-sm btn-info\">مشاهده شهرها</a>\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1526, "\"", 1571, 2);
            WriteAttributeValue("", 1533, "/Admin/Provinces/Edit/", 1533, 22, true);
#line 38 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Provinces\Index.cshtml"
WriteAttributeValue("", 1555, item.ProvinceID, 1555, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1572, 115, true);
            WriteLiteral(" class=\"btn btn-success btn-icon\"><i class=\"fa fa-edit text-white\"></i></a>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1687, "\"", 1734, 2);
            WriteAttributeValue("", 1694, "/Admin/Provinces/Delete/", 1694, 24, true);
#line 39 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Provinces\Index.cshtml"
WriteAttributeValue("", 1718, item.ProvinceID, 1718, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1735, 151, true);
            WriteLiteral(" class=\"btn btn-danger btn-icon\"><i class=\"fa fa-trash text-white\"></i></a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 42 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Provinces\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1913, 99, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <nav>\r\n                    ");
            EndContext();
            BeginContext(2013, 74, false);
#line 46 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Provinces\Index.cshtml"
               Write(await this.Component.InvokeAsync("Pager", new { PagingList = this.Model }));

#line default
#line hidden
            EndContext();
            BeginContext(2087, 84, true);
            WriteLiteral("\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Provice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
