#pragma checksum "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\NotFoundProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14d718599c26df666d00682a685eb5d80bad96ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_NotFoundProduct), @"mvc.1.0.view", @"/Views/SanPham/NotFoundProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14d718599c26df666d00682a685eb5d80bad96ae", @"/Views/SanPham/NotFoundProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef73639f6b3737e7259fad928485fe42d0b458a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SanPham_NotFoundProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"body\" style=\"margin-top: 50px;\">\r\n    <h1>Không tìm thấy sản phẩm ");
#nullable restore
#line 2 "E:\Code_GitHub\asp.net\asp.net\qlthucung\qlthucung\qlthucung\Views\SanPham\NotFoundProduct.cshtml"
                           Write(TempData["nameProduct"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
