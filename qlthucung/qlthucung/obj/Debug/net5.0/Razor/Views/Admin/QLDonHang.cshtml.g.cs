#pragma checksum "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13754beadf49f41d9bb3ad4cb26b46c5b4f471ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_QLDonHang), @"mvc.1.0.view", @"/Views/Admin/QLDonHang.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13754beadf49f41d9bb3ad4cb26b46c5b4f471ad", @"/Views/Admin/QLDonHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef73639f6b3737e7259fad928485fe42d0b458a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_QLDonHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedList<DonHang>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "QLChiTietDonHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
  
    ViewData["Title"] = "QLDonHang";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-lg-12 padding-8\">\r\n");
            WriteLiteral(@"
    <div class=""body fix-width scroll-inner"" style=""margin: 50px 0;"">
        <table class=""table table-striped"">
            <tr>
                <th>
                    Mã kh
                </th>
                <th>
                    Thanh toán
                </th>
                <th>
                    Trạng thái
                </th>
                <th>
                    Ngày đặt
                </th>
                <th>
                    Ngày giao
                </th>

                <th></th>
            </tr>

");
#nullable restore
#line 42 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Makh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Thanhtoan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 52 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                         if (item.Giaohang == "chờ xử lý")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\"color: #007bff;\">");
#nullable restore
#line 54 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                                                    Write(item.Giaohang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 55 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                        }
                        else if (item.Giaohang == "đang xử lý")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\"color: orange;\">");
#nullable restore
#line 58 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                                                   Write(item.Giaohang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 59 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                        }
                        else if (item.Giaohang == "đang giao")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\"color: forestgreen;\">");
#nullable restore
#line 62 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                                                        Write(item.Giaohang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 63 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                        }
                        else if (item.Giaohang == "giao thành công")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\"color: green;\">");
#nullable restore
#line 66 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                                                  Write(item.Giaohang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 67 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                        }
                        else if (item.Giaohang == "hủy")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\"color: red;\">");
#nullable restore
#line 70 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                                                Write(item.Giaohang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 71 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ngaydat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 77 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ngaygiao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13754beadf49f41d9bb3ad4cb26b46c5b4f471ad9767", async() => {
                WriteLiteral("Chi tiết đơn hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                                                           WriteLiteral(item.Madon);

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
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 85 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n\r\n    <!--Pagination-->\r\n    <ul class=\"pagination justify-content-center\" style=\"margin: 10px auto;\">\r\n");
#nullable restore
#line 92 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
         if (Model.HasPreviousPage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3282, "\"", 3355, 1);
#nullable restore
#line 94 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
WriteAttributeValue("", 3289, Url.Action("QLDonHang", new { pageNumber = Model.PageIndex - 1 }), 3289, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Previous</a></li>\r\n");
#nullable restore
#line 95 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 97 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
         for (int i = 1; i <= Model.TotalPages; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\"><a");
            BeginWriteAttribute("href", " href=\"", 3555, "\"", 3562, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\"> ");
#nullable restore
#line 101 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 102 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3702, "\"", 3757, 1);
#nullable restore
#line 105 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
WriteAttributeValue("", 3709, Url.Action("QLDonHang", new { pageNumber = i }), 3709, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 105 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
                                                                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 106 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 109 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
         if (Model.HasNextPage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3898, "\"", 3971, 1);
#nullable restore
#line 111 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
WriteAttributeValue("", 3905, Url.Action("QLDonHang", new { pageNumber = Model.PageIndex + 1 }), 3905, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a></li>\r\n");
#nullable restore
#line 112 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\Admin\QLDonHang.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedList<DonHang>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
