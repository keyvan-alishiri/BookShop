#pragma checksum "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_UserSidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae566abaabb58fed12844353bf3648d61035fb05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UserSidebar), @"mvc.1.0.view", @"/Views/Shared/_UserSidebar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_UserSidebar.cshtml", typeof(AspNetCore.Views_Shared__UserSidebar))]
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
#line 3 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_UserSidebar.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae566abaabb58fed12844353bf3648d61035fb05", @"/Views/Shared/_UserSidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee4735df80bb67d1ce7d40fc94d37240032cc50", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__UserSidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookShop.Models.ViewModels.UserSidebarViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/UserPic.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(201, 66, true);
            WriteLiteral("<div class=\"profile-sidebar\">\r\n    <div class=\"profile-userpic\">\r\n");
            EndContext();
#line 7 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_UserSidebar.cshtml"
         if (Model.Image == null)
        {

#line default
#line hidden
            BeginContext(313, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(325, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ac0221de34844ca0954fbf18401c4d97", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(387, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_UserSidebar.cshtml"
        }

#line default
#line hidden
            BeginContext(400, 111, true);
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"profile-usertitle\">\r\n        <div class=\"profile-usertitle-name\">\r\n            ");
            EndContext();
            BeginContext(512, 14, false);
#line 16 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_UserSidebar.cshtml"
       Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(526, 125, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"profile-usertitle-job\">\r\n            <p class=\"mb-1\">\r\n                آخرین بازدید :\r\n");
            EndContext();
#line 21 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_UserSidebar.cshtml"
                 if (Model.LastVisit.HasValue)
                {
                    

#line default
#line hidden
            BeginContext(739, 89, false);
#line 23 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_UserSidebar.cshtml"
               Write(convertDate.ConvertMiladiToShamsi((DateTime)Model.LastVisit, "d MMMM yyyy ساعت HH:mm:ss"));

#line default
#line hidden
            EndContext();
#line 23 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_UserSidebar.cshtml"
                                                                                                              
                }

#line default
#line hidden
            BeginContext(849, 66, true);
            WriteLiteral("            </p>\r\n            <p>\r\n                تاریخ عضویت :\r\n");
            EndContext();
#line 28 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_UserSidebar.cshtml"
                 if (Model.RegisterDate.HasValue)
                {
                    

#line default
#line hidden
            BeginContext(1006, 92, false);
#line 30 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_UserSidebar.cshtml"
               Write(convertDate.ConvertMiladiToShamsi((DateTime)Model.RegisterDate, "d MMMM yyyy ساعت HH:mm:ss"));

#line default
#line hidden
            EndContext();
#line 30 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_UserSidebar.cshtml"
                                                                                                                 
                }

#line default
#line hidden
            BeginContext(1119, 93, true);
            WriteLiteral("            </p>\r\n        </div>\r\n    </div>\r\n    <div class=\"profile-userbuttons\">\r\n        ");
            EndContext();
            BeginContext(1212, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84bee8dc578d4d75a4a351eed229f4f9", async() => {
                BeginContext(1299, 15, true);
                WriteLiteral("تغییر کلمه عبور");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1318, 236, true);
            WriteLiteral("\r\n        <button type=\"button\" class=\"btn btn-danger btn-sm\">مشاهده سایت</button>\r\n    </div>\r\n    <div class=\"profile-usermenu sidebar-sticky\">\r\n        <ul class=\"nav flex-column\">\r\n            <li class=\"nav-item\">\r\n                ");
            EndContext();
            BeginContext(1554, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8467398095642a0a9d2e38a13867eab", async() => {
                BeginContext(1627, 103, true);
                WriteLiteral("\r\n                    <i class=\"fa fa-user\"></i>\r\n                    تغییر کلمه عبور\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1734, 438, true);
            WriteLiteral(@"
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"" target=""_blank"">
                    <i class=""fa fa-check""></i>
                    پروفایل
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">
                    <i class=""fa fa-flag""></i>
                    سفارشات
                </a>
            </li>
");
            EndContext();
#line 59 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_UserSidebar.cshtml"
             if ((await AuthorizationService.AuthorizeAsync(User, "HappyBirthDay")).Succeeded)
            {

#line default
#line hidden
            BeginContext(2283, 270, true);
            WriteLiteral(@"                <li class=""nav-item"">
                    <a class=""nav-link text-danger"" href=""/Account/HappyBirthDay"">
                        <i class=""fa fa-gift""></i>
                        تبریک !!! کلیک کنید.
                    </a>
                </li>
");
            EndContext();
#line 67 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Views\Shared\_UserSidebar.cshtml"
            }

#line default
#line hidden
            BeginContext(2568, 58, true);
            WriteLiteral("\r\n        </ul>\r\n    </div>\r\n    <!-- END MENU -->\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BookShop.Classes.ConvertDate convertDate { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookShop.Models.ViewModels.UserSidebarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
