#pragma checksum "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_AdminSidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f47e8ea4489372bd1d34d24a5cb560996c5da5c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminSidebar), @"mvc.1.0.view", @"/Views/Shared/_AdminSidebar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AdminSidebar.cshtml", typeof(AspNetCore.Views_Shared__AdminSidebar))]
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
#line 1 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\_ViewImports.cshtml"
using BookShop;

#line default
#line hidden
#line 2 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\_ViewImports.cshtml"
using BookShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f47e8ea4489372bd1d34d24a5cb560996c5da5c5", @"/Views/Shared/_AdminSidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee4735df80bb67d1ce7d40fc94d37240032cc50", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminSidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index:Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::BookShop.Areas.Admin.TagHelpers.SecurityTrimmingTagHelper __BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 396, true);
            WriteLiteral(@"
<div class=""sidebar"">
    <nav class=""sidebar-nav"">
        <ul class=""nav"">
            <li class=""nav-title"">پنل مدیریت</li>
            <li class=""nav-item"">
                <a href=""index.html"" class=""nav-link"">
                    <i class=""icon icon-speedometer""></i> داشبورد
                </a>
            </li>
            <li class=""nav-item nav-dropdown"">
                ");
            EndContext();
            BeginContext(421, 329, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("security-trimming", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb2aac2518e64e8aabe066def47740ad", async() => {
                BeginContext(506, 224, true);
                WriteLiteral("\r\n                    <a href=\"#\" class=\"nav-link nav-dropdown-toggle\">\r\n                        <i class=\"icon icon-book-open\"></i> مدیریت کتاب ها <i class=\"fa fa-caret-left\"></i>\r\n                    </a>\r\n                ");
                EndContext();
            }
            );
            __BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper = CreateTagHelper<global::BookShop.Areas.Admin.TagHelpers.SecurityTrimmingTagHelper>();
            __tagHelperExecutionContext.Add(__BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper);
            __BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(750, 88, true);
            WriteLiteral("\r\n               \r\n                <ul class=\"nav-dropdown-items\">\r\n                    ");
            EndContext();
            BeginContext(838, 389, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("security-trimming", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0602b54e4694caeb3817046a2b8ea68", async() => {
                BeginContext(916, 291, true);
                WriteLiteral(@"
                        <li class=""nav-item"">
                            <a href=""/Admin/Books/Index"" class=""nav-link"">
                                <i class=""icon icon-target""></i> مشاهده کتاب ها
                            </a>
                        </li>
                    ");
                EndContext();
            }
            );
            __BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper = CreateTagHelper<global::BookShop.Areas.Admin.TagHelpers.SecurityTrimmingTagHelper>();
            __tagHelperExecutionContext.Add(__BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper);
            __BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1227, 44, true);
            WriteLiteral("\r\n                    \r\n                    ");
            EndContext();
            BeginContext(1271, 393, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("security-trimming", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b6c39968afe4583b6c9c983734ff6c2", async() => {
                BeginContext(1350, 294, true);
                WriteLiteral(@"
                        <li class=""nav-item"">
                            <a href=""/Admin/Books/Create"" class=""nav-link"">
                                <i class=""icon icon-target""></i> افزودن کتاب جدید
                            </a>
                        </li>
                    ");
                EndContext();
            }
            );
            __BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper = CreateTagHelper<global::BookShop.Areas.Admin.TagHelpers.SecurityTrimmingTagHelper>();
            __tagHelperExecutionContext.Add(__BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper);
            __BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __BookShop_Areas_Admin_TagHelpers_SecurityTrimmingTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1664, 5765, true);
            WriteLiteral(@"
                    
                </ul>
            </li>
            <li class=""nav-item nav-dropdown"">
                <a href=""#"" class=""nav-link nav-dropdown-toggle"">
                    <i class=""icon icon-user""></i> مدیریت نویسندگان <i class=""fa fa-caret-left""></i>
                </a>
                <ul class=""nav-dropdown-items"">
                    <li class=""nav-item"">
                        <a href=""/Admin/Authors/Index"" class=""nav-link"">
                            <i class=""icon icon-target""></i> مشاهده نویسندگان
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/Admin/Authors/Create"" class=""nav-link"">
                            <i class=""icon icon-target""></i> افزودن نویسنده جدید
                        </a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item nav-dropdown"">
                <a href=""#"" class=""nav-link nav-dropdown-toggle"">
   ");
            WriteLiteral(@"                 <i class=""icon icon-user""></i> مدیریت مترجمان <i class=""fa fa-caret-left""></i>
                </a>
                <ul class=""nav-dropdown-items"">
                    <li class=""nav-item"">
                        <a href=""/Admin/Translators/Index"" class=""nav-link"">
                            <i class=""icon icon-target""></i> مشاهده مترجمان
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/Admin/Translators/Create"" class=""nav-link"">
                            <i class=""icon icon-target""></i> افزودن مترجم جدید
                        </a>
                    </li>
                </ul>
            </li>

            <li class=""nav-item nav-dropdown"">
                <a href=""#"" class=""nav-link nav-dropdown-toggle"">
                    <i class=""icon icon-user""></i> مدیریت ناشرین <i class=""fa fa-caret-left""></i>
                </a>
                <ul class=""nav-dropdown-items"">
             ");
            WriteLiteral(@"       <li class=""nav-item"">
                        <a href=""/Admin/Publishers/Index"" class=""nav-link"">
                            <i class=""icon icon-target""></i> مشاهده ناشرین
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/Admin/Publishers/Create"" class=""nav-link"">
                            <i class=""icon icon-target""></i> افزودن ناشر جدید
                        </a>
                    </li>
                </ul>
            </li>

            <li class=""nav-item nav-dropdown"">
                <a href=""#"" class=""nav-link nav-dropdown-toggle"">
                    <i class=""icon icon-list""></i> جداول پایه <i class=""fa fa-caret-left""></i>
                </a>
                <ul class=""nav-dropdown-items"">
                    <li class=""nav-item"">
                        <a href=""/Admin/Languages/Index"" class=""nav-link"">
                            <i class=""icon icon-target""></i> زبان های کتاب
      ");
            WriteLiteral(@"                  </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/Admin/Provinces/Index"" class=""nav-link"">
                            <i class=""icon icon-target""></i> استان ها و شهرها
                        </a>
                    </li>
                </ul>
            </li>

            <li class=""nav-item nav-dropdown"">
                <a href=""#"" class=""nav-link nav-dropdown-toggle"">
                    <i class=""icon icon-list""></i> مدیریت کاربران <i class=""fa fa-caret-left""></i>
                </a>
                <ul class=""nav-dropdown-items"">
                    <li class=""nav-item"">
                        <a href=""/Admin/UsersManager/Index"" class=""nav-link"">
                            <i class=""fa fa-users""></i> مشاهده کاربران
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/Identity/Account/Register"" class=""nav-link"">
              ");
            WriteLiteral(@"              <i class=""icon icon-target""></i> عضویت کاربر جدید
                        </a>
                    </li>
                </ul>
            </li>

            <li class=""nav-item nav-dropdown"">
                <a href=""#"" class=""nav-link nav-dropdown-toggle"">
                    <i class=""icon icon-list""></i> مدیریت نقش ها <i class=""fa fa-caret-left""></i>
                </a>
                <ul class=""nav-dropdown-items"">
                    <li class=""nav-item"">
                        <a href=""/Admin/RolesManager/Index"" class=""nav-link"">
                            <i class=""icon icon-target""></i> مشاهده نقش ها
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/Admin/RolesManager/AddRole"" class=""nav-link"">
                            <i class=""icon icon-target""></i> افزودن نقش جدید
                        </a>
                    </li>
                </ul>
            </li>

            <li");
            WriteLiteral(@" class=""nav-item nav-dropdown"">
                <a href=""#"" class=""nav-link nav-dropdown-toggle"">
                    <i class=""fa fa-address-book""></i> تنظیمات حساب کاربری <i class=""fa fa-caret-left""></i>
                </a>
                <ul class=""nav-dropdown-items"">
                    <li class=""nav-item"">
                        <a href=""/Admin/User/TwoFactorAuthentication"" class=""nav-link"">
                            <i class=""fa fa-mobile-alt""></i> تنظیمات احراز هویت دو مرحله با اپلیکشن
                        </a>
                    </li>
                </ul>
            </li>
        </ul>
    </nav>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
