#pragma checksum "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\RolesManager\DeleteRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a95e8adea010eb64b69953d48533479dab4ce9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_RolesManager_DeleteRole), @"mvc.1.0.view", @"/Areas/Admin/Views/RolesManager/DeleteRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/RolesManager/DeleteRole.cshtml", typeof(AspNetCore.Areas_Admin_Views_RolesManager_DeleteRole))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a95e8adea010eb64b69953d48533479dab4ce9b", @"/Areas/Admin/Views/RolesManager/DeleteRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee4735df80bb67d1ce7d40fc94d37240032cc50", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_RolesManager_DeleteRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookShop.Models.ViewModels.RolesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\RolesManager\DeleteRole.cshtml"
  
    ViewData["Title"] = "DeleteRole";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(142, 192, true);
            WriteLiteral("\r\n<div class=\"row w-75 m-auto\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header bg-light\">حذف اطلاعات</div>\r\n            <div class=\"card-body\">\r\n");
            EndContext();
#line 12 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\RolesManager\DeleteRole.cshtml"
                 if (ViewBag.Error != null)
                {

#line default
#line hidden
            BeginContext(398, 96, true);
            WriteLiteral("                    <div class=\"alert alert-danger alert-dismissable\">\r\n                        ");
            EndContext();
            BeginContext(495, 13, false);
#line 15 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\RolesManager\DeleteRole.cshtml"
                   Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(508, 236, true);
            WriteLiteral("\r\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                            <span aria-hidden=\"true\">&times;</span>\r\n                        </button>\r\n                    </div>\r\n");
            EndContext();
#line 20 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\RolesManager\DeleteRole.cshtml"
                }

#line default
#line hidden
            BeginContext(763, 44, true);
            WriteLiteral("                <p>آیا شما می خواهید <span> ");
            EndContext();
            BeginContext(808, 14, false);
#line 21 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\RolesManager\DeleteRole.cshtml"
                                       Write(Model.RoleName);

#line default
#line hidden
            EndContext();
            BeginContext(822, 149, true);
            WriteLiteral("  را از لیست نقش ها حذف کنید ؟ </span> </p>\r\n            </div>\r\n            <div class=\"card-footer bg-light text-right clearfix\">\r\n                ");
            EndContext();
            BeginContext(971, 311, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4000218850ec49cc8708c4f53e39e0de", async() => {
                BeginContext(1001, 42, true);
                WriteLiteral("\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1043, "\"", 1064, 1);
#line 25 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\RolesManager\DeleteRole.cshtml"
WriteAttributeValue("", 1051, Model.RoleID, 1051, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1065, 131, true);
                WriteLiteral(" name=\"id\" />\r\n                    <input type=\"submit\" value=\"بله\" class=\"btn btn-danger mr-2 float-left\" />\r\n                    ");
                EndContext();
                BeginContext(1196, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f50e9ee848004a709e38e478292aa0fc", async() => {
                    BeginContext(1250, 3, true);
                    WriteLiteral("خیر");
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
                BeginContext(1257, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1282, 56, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookShop.Models.ViewModels.RolesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
