#pragma checksum "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\_InsertOrUpdateBookImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8cbfedb8028ef452f6a66c5447f69f8c2694306"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books__InsertOrUpdateBookImage), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/_InsertOrUpdateBookImage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Books/_InsertOrUpdateBookImage.cshtml", typeof(AspNetCore.Areas_Admin_Views_Books__InsertOrUpdateBookImage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8cbfedb8028ef452f6a66c5447f69f8c2694306", @"/Areas/Admin/Views/Books/_InsertOrUpdateBookImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee4735df80bb67d1ce7d40fc94d37240032cc50", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Books__InsertOrUpdateBookImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookShop.Models.ViewModels.ImageBookViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept", new global::Microsoft.AspNetCore.Html.HtmlString(".jpg, .png, .jpeg, .gif, .tif, .tiff, .JPG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InsertOrUpdateBookImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 385, true);
            WriteLiteral(@"
<div class=""modal fade"" id=""myModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">ویرایش تصویر جلد کتاب</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(439, 1624, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59ba481efcec48a0a046622eef2adf4e", async() => {
                BeginContext(512, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(534, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1154069bca76415eabda40b2294bf298", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 13 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\_InsertOrUpdateBookImage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BookID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(574, 57, true);
                WriteLiteral("\r\n                    <input name=\"IsValid\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 631, "\"", 678, 1);
#line 14 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\_InsertOrUpdateBookImage.cshtml"
WriteAttributeValue("", 639, ViewData.ModelState.IsValid.ToString(), 639, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(679, 176, true);
                WriteLiteral(" />\r\n                    <div class=\"fileinput fileinput-new\" data-provides=\"fileinput\">\r\n                        <div class=\"fileinput-new thumbnail\" style=\"height: 200px;\">\r\n");
                EndContext();
#line 17 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\_InsertOrUpdateBookImage.cshtml"
                             if (Model.ImageByte != null)
                            {

#line default
#line hidden
                BeginContext(945, 36, true);
                WriteLiteral("                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 981, "\"", 1046, 4);
                WriteAttributeValue("", 987, "/Admin/Books/ViewImage/", 987, 23, true);
#line 19 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\_InsertOrUpdateBookImage.cshtml"
WriteAttributeValue("", 1010, Model.BookID, 1010, 13, false);

#line default
#line hidden
                WriteAttributeValue("", 1023, "?DateTime=", 1023, 10, true);
#line 19 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\_InsertOrUpdateBookImage.cshtml"
WriteAttributeValue("", 1033, DateTime.Now, 1033, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1047, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 20 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\_InsertOrUpdateBookImage.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(1148, 78, true);
                WriteLiteral("                                <img src=\"/images/No_Image_Available.jpg\" />\r\n");
                EndContext();
#line 24 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\_InsertOrUpdateBookImage.cshtml"
                            }

#line default
#line hidden
                BeginContext(1257, 468, true);
                WriteLiteral(@"
                        </div>
                        <div class=""fileinput-preview fileinput-exists thumbnail"" style=""height:200px""> </div>
                        <div>
                            <span class=""btn default btn-file"">
                                <span class=""fileinput-new btn btn-success""> انتخاب کنید </span>
                                <span class=""fileinput-exists btn btn-info""> تغییر عکس </span>
                                ");
                EndContext();
                BeginContext(1725, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d22aa8b634584d4d885af82d790243eb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 32 "C:\Users\keyvan\source\repos\keyvan-alishiri\BookShop\BookShop\Areas\Admin\Views\Books\_InsertOrUpdateBookImage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Image);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1814, 242, true);
                WriteLiteral("\r\n                            </span>\r\n                            <a href=\"javascript:;\" class=\"btn btn-danger fileinput-exists\" data-dismiss=\"fileinput\"> حذف </a>\r\n                        </div>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2063, 317, true);
            WriteLiteral(@"
            </div>

            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary ml-1"" data-save=""modal"">افزودن</button>
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">بستن</button>
            </div>
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookShop.Models.ViewModels.ImageBookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
