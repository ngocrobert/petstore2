#pragma checksum "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47f4b1573cc24a4537f9622e0bfc2978b53db704"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_Search), @"mvc.1.0.view", @"/Views/SanPham/Search.cshtml")]
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
#nullable restore
#line 1 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\_ViewImports.cshtml"
using qlthucung;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\_ViewImports.cshtml"
using qlthucung.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f4b1573cc24a4537f9622e0bfc2978b53db704", @"/Views/SanPham/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef73639f6b3737e7259fad928485fe42d0b458a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SanPham_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<qlthucung.Models.SanPham>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SanPham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"
  
    ViewData["Title"] = "Search";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"body\" style=\"margin-top: 50px;\">\r\n\r\n    <div class=\"body__mainTitle d-flex justify-content-between align-items-center\">\r\n        <h2>Tìm kiếm sản phẩm có tên: ");
#nullable restore
#line 10 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"
                                 Write(TempData["nameProduct"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 18 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-2_5 col-md-4 col-6 post2\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f4b1573cc24a4537f9622e0bfc2978b53db7044940", async() => {
                WriteLiteral("\r\n                        <div class=\"product\">\r\n                            <div class=\"product__img\">\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 906, "\"", 922, 1);
#nullable restore
#line 24 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"
WriteAttributeValue("", 912, item.Hinh, 912, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 923, "\"", 929, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </div>\r\n");
#nullable restore
#line 26 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"
                             if (item.Giamgia == 0 || item.Giamgia == null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"product__sale\">\r\n                                    <h4>Mới</h4>\r\n                                </div>\r\n");
#nullable restore
#line 31 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"product__sale\">\r\n                                    <h4>");
#nullable restore
#line 36 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"
                                   Write(item.Giamgia);

#line default
#line hidden
#nullable disable
                WriteLiteral(" %</h4>\r\n                                </div>\r\n");
#nullable restore
#line 38 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"product__content\">\r\n                                <div class=\"product__title\">\r\n                                    ");
#nullable restore
#line 41 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"
                               Write(item.Tensp);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n\r\n");
#nullable restore
#line 44 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"
                                 if (!(item.Giamgia == 0 || item.Giamgia == null))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"product__pride-oldPride\">\r\n                                        <span class=\"Price\">\r\n                                            <bdi>\r\n                                                ");
#nullable restore
#line 49 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"
                                           Write(string.Format("{0:N0}", item.Giaban));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                <span class=\"currencySymbol\">₫</span>\r\n                                            </bdi>\r\n                                        </span>\r\n                                    </div>\r\n");
#nullable restore
#line 54 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>

                        <div>
                            <div class=""product__pride-newPride"">
                                <span class=""Price"">
                                    <bdi>
                                        ");
#nullable restore
#line 63 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"
                                   Write(string.Format("{0:N0}", item.Giakhuyenmai));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <span class=\"currencySymbol\">₫</span>\r\n                                    </bdi>\r\n                                </span>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"
                                                                       WriteLiteral(item.Masp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 71 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\Search.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<qlthucung.Models.SanPham>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
