#pragma checksum "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf9b27a5d73e455a066bcbcf3a10bbde26296975"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Books/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Books_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf9b27a5d73e455a066bcbcf3a10bbde26296975", @"/Areas/Admin/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee4735df80bb67d1ce7d40fc94d37240032cc50", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookShop.Models.ViewModels.ReadAllBooks>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Book.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(185, 320, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header bg-light"">
                اطلاعات کتاب ها 
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-3"">
                        ");
            EndContext();
            BeginContext(505, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "797372c937a44efaaa453a01973960f1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(551, 239, true);
            WriteLiteral("\r\n                    </div>\r\n                    \r\n                    <div class=\"col-md-9\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                <p>عنوان کتاب : ");
            EndContext();
            BeginContext(791, 11, false);
#line 23 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(802, 47, true);
            WriteLiteral("</p>\r\n                                <p>شابک: ");
            EndContext();
            BeginContext(850, 10, false);
#line 24 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                    Write(Model.ISBN);

#line default
#line hidden
            EndContext();
            BeginContext(860, 53, true);
            WriteLiteral("</p>\r\n                                <p>سال انتشار: ");
            EndContext();
            BeginContext(914, 17, false);
#line 25 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                          Write(Model.PublishYear);

#line default
#line hidden
            EndContext();
            BeginContext(931, 47, true);
            WriteLiteral("</p>\r\n                                <p>قیمت: ");
            EndContext();
            BeginContext(979, 11, false);
#line 26 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                    Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(990, 49, true);
            WriteLiteral("</p>\r\n                                <p>موجودی: ");
            EndContext();
            BeginContext(1040, 11, false);
#line 27 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                      Write(Model.Stock);

#line default
#line hidden
            EndContext();
            BeginContext(1051, 54, true);
            WriteLiteral("</p>\r\n                                <p>تعداد صفحات: ");
            EndContext();
            BeginContext(1106, 16, false);
#line 28 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                           Write(Model.NumOfPages);

#line default
#line hidden
            EndContext();
            BeginContext(1122, 52, true);
            WriteLiteral("</p>\r\n                                <p>زبان کتاب: ");
            EndContext();
            BeginContext(1175, 18, false);
#line 29 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                         Write(Model.LanguageName);

#line default
#line hidden
            EndContext();
            BeginContext(1193, 139, true);
            WriteLiteral("</p>\r\n                            </div>\r\n\r\n                            <div class=\"col-md-6\">\r\n\r\n                                <p>ناشر: ");
            EndContext();
            BeginContext(1333, 19, false);
#line 34 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                    Write(Model.PublisherName);

#line default
#line hidden
            EndContext();
            BeginContext(1352, 90, true);
            WriteLiteral("</p>\r\n                                <p>\r\n                                    نویسندگان: ");
            EndContext();
            BeginContext(1443, 13, false);
#line 36 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                          Write(Model.Authors);

#line default
#line hidden
            EndContext();
            BeginContext(1456, 199, true);
            WriteLiteral("\r\n                                   \r\n\r\n                                    \r\n                                </p>\r\n                                <p>\r\n                                    مترجمان: ");
            EndContext();
            BeginContext(1656, 17, false);
#line 42 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                        Write(Model.Translators);

#line default
#line hidden
            EndContext();
            BeginContext(1673, 167, true);
            WriteLiteral("\r\n                                   \r\n\r\n\r\n\r\n                                </p>\r\n                                <p>\r\n                                    دسته بندی: ");
            EndContext();
            BeginContext(1841, 16, false);
#line 49 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                          Write(Model.Categories);

#line default
#line hidden
            EndContext();
            BeginContext(1857, 183, true);
            WriteLiteral("\r\n                                   \r\n\r\n\r\n\r\n\r\n                                </p>\r\n\r\n\r\n\r\n\r\n\r\n                                <p>\r\n                                    تاریخ انتشار:\r\n");
            EndContext();
#line 63 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                     if (Model.PublishDate != null)
                                    {
                                        

#line default
#line hidden
            BeginContext(2189, 76, false);
#line 65 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                   Write(convertDate.ConvertMiladiToShamsi((DateTime)Model.PublishDate, "yyyy/MM/dd"));

#line default
#line hidden
            EndContext();
#line 65 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                                                                                                     
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2387, 56, true);
            WriteLiteral("                                        <span>-</span>\r\n");
            EndContext();
#line 70 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2482, 128, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                                </p>\r\n                                <p>\r\n                                    وضعیت\r\n");
            EndContext();
#line 79 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                     if (Model.IsPublish == true)
                                    {

#line default
#line hidden
            BeginContext(2716, 151, true);
            WriteLiteral("                                        <apan>\r\n                                            منشر شده\r\n                                        </apan>\r\n");
            EndContext();
#line 84 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2987, 151, true);
            WriteLiteral("                                        <span>\r\n                                            پیش نویس\r\n                                        </span>\r\n");
            EndContext();
#line 90 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3177, 119, true);
            WriteLiteral("\r\n\r\n                                </p>\r\n                                <p>\r\n                                    وزن:");
            EndContext();
            BeginContext(3297, 12, false);
#line 95 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                   Write(Model.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(3309, 313, true);
            WriteLiteral(@"
                                </p>
                                
                            </div>


                        </div>
                    </div>

                   
                    <div class=""col-md-12"">
                        <hr />
                        <p>خلاصه کتاب: ");
            EndContext();
            BeginContext(3623, 13, false);
#line 107 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                  Write(Model.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(3636, 118, true);
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookShop.Models.ViewModels.ReadAllBooks> Html { get; private set; }
    }
}
#pragma warning restore 1591
