#pragma checksum "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec48762de16bb479c2f0d6732cdea66df6bd74f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DynamicAccess_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DynamicAccess/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/DynamicAccess/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_DynamicAccess_Index))]
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
#line 2 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
using BookShop.Areas.Admin.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec48762de16bb479c2f0d6732cdea66df6bd74f8", @"/Areas/Admin/Views/DynamicAccess/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee4735df80bb67d1ce7d40fc94d37240032cc50", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DynamicAccess_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookShop.Models.ViewModels.DynamicAccessIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DynamicAccess", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(184, 117, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header bg-light\">\r\n        <h5 class=\"mb-1\"> تنظیم سطوح دسترسی پویای نقش «");
            EndContext();
            BeginContext(302, 32, false);
#line 10 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
                                                  Write(Model.RoleIncludeRoleClaims.Name);

#line default
#line hidden
            EndContext();
            BeginContext(334, 24, true);
            WriteLiteral("»</h5>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(358, 3511, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0c310d54e1a4be9a20281eaa99ea305", async() => {
                BeginContext(450, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(460, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1560734522de4a08a67bc75e12282366", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 15 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(506, 67, true);
                WriteLiteral("\r\n        <div class=\"card-body\">\r\n            <input name=\"RoleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 573, "\"", 612, 1);
#line 17 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
WriteAttributeValue("", 581, Model.RoleIncludeRoleClaims.Id, 581, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(613, 50, true);
                WriteLiteral(" type=\"hidden\" />\r\n            <div class=\"row\">\r\n");
                EndContext();
#line 19 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
                 foreach (var controller in Model.SecuredControllerActions.OrderBy(x => x.ControllerDisplayName))
                {

#line default
#line hidden
                BeginContext(797, 207, true);
                WriteLiteral("                    <div class=\"col-md-4\">\r\n                        <div class=\"card\">\r\n                            <button class=\"btn btn-primary\" type=\"button\" data-toggle=\"collapse\" data-target=\"#demo\">\r\n");
                EndContext();
#line 24 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
                                  
                                    var displayName = controller.ControllerDisplayName;
                                    if (string.IsNullOrWhiteSpace(displayName))
                                    {
                                        displayName = controller.ControllerName;
                                    }
                                

#line default
#line hidden
                BeginContext(1405, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1438, 11, false);
#line 31 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
                           Write(displayName);

#line default
#line hidden
                EndContext();
                BeginContext(1449, 184, true);
                WriteLiteral("\r\n                            </button>\r\n\r\n                            <div id=\"demo\" class=\"collapse\">\r\n                                <ul class=\"list-group list-group-flush pr-0\">\r\n");
                EndContext();
#line 36 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
                                      int i = 0;

#line default
#line hidden
                BeginContext(1684, 36, true);
                WriteLiteral("                                    ");
                EndContext();
#line 37 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
                                     foreach (var action in controller.MvcActions.OrderBy(x => x.ActionDisplayName))
                                    {
                                        var isSelected = Model.RoleIncludeRoleClaims.Claims
                                            .Any(roleClaim => roleClaim.ClaimType == ConstantPolicies.DynamicPermissionClaimType &&
                                                              roleClaim.ClaimValue == action.ActionId);
                                        var selected = isSelected ? "checked" : "";
                                        var actionDisplayName = action.ActionDisplayName;
                                        if (string.IsNullOrWhiteSpace(actionDisplayName))
                                        {
                                            actionDisplayName = $"{action}::{action.ActionId}";
                                        }

#line default
#line hidden
                BeginContext(2622, 249, true);
                WriteLiteral("                                        <li class=\"list-group-item\" role=\"presentation\">\r\n                                            <div class=\"toggle-switch d-block\" data-ts-color=\"success\">\r\n                                                <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 2871, "\"", 2886, 1);
#line 50 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
WriteAttributeValue("", 2877, "ts"+i, 2877, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2887, 18, true);
                WriteLiteral(" class=\"ts-label\">");
                EndContext();
                BeginContext(2906, 17, false);
#line 50 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
                                                                                   Write(actionDisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(2923, 64, true);
                WriteLiteral("</label>\r\n                                                <input");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2987, "\"", 3001, 1);
#line 51 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
WriteAttributeValue("", 2992, "ts"+i, 2992, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3002, 49, true);
                WriteLiteral(" type=\"checkbox\" name=\"actionIds\" hidden=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3051, "\"", 3075, 1);
#line 51 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
WriteAttributeValue("", 3059, action.ActionId, 3059, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3076, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(3078, 8, false);
#line 51 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
                                                                                                                                           Write(selected);

#line default
#line hidden
                EndContext();
                BeginContext(3086, 57, true);
                WriteLiteral(">\r\n                                                <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 3143, "\"", 3158, 1);
#line 52 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
WriteAttributeValue("", 3149, "ts"+i, 3149, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3159, 141, true);
                WriteLiteral(" class=\"ts-helper float-left\"></label>\r\n                                            </div>\r\n\r\n                                        </li>\r\n");
                EndContext();
#line 56 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"
                                        i++;
                                    }

#line default
#line hidden
                BeginContext(3385, 137, true);
                WriteLiteral("                                </ul>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 63 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\DynamicAccess\Index.cshtml"

                }

#line default
#line hidden
                BeginContext(3543, 319, true);
                WriteLiteral(@"            </div>


        </div>
        <div class=""card-footer bg-light clearfix"">
            <button type=""submit"" class=""btn btn-primary float-left top15"">
                اعمال تغییرات
                <span aria-hidden=""true"" class=""fas fa-thumbs-up""></span>
            </button>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(3869, 18, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookShop.Models.ViewModels.DynamicAccessIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591