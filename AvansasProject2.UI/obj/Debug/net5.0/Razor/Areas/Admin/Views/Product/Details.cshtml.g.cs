#pragma checksum "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc4e497afa32c01b731913a4f14408ea8f7190bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Details.cshtml")]
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
#line 1 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\_ViewImports.cshtml"
using AvansasProject2.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\_ViewImports.cshtml"
using AvansasProject2.MODEL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4e497afa32c01b731913a4f14408ea8f7190bd", @"/Areas/Admin/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eed5973c20bf8485cf4cedb7de86d8233e596023", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AvansasProject2.MODEL.Models.Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Ürün Detayı";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-align:center\"> Ürün Detay Sayfası </h1>\r\n\r\n<<div class=\"container mt-4 product-detail\">\r\n    <div class=\"product-image\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 293, "\"", 311, 1);
#nullable restore
#line 12 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml"
WriteAttributeValue("", 299, Model.Image, 299, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 312, "\"", 330, 1);
#nullable restore
#line 12 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml"
WriteAttributeValue("", 318, Model.Title, 318, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"product-info\">\r\n        <h1 class=\"product-title\">");
#nullable restore
#line 15 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml"
                             Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p class=\"product-category\">Kategori: ");
#nullable restore
#line 16 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml"
                                         Write(Model.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <div>\r\n            <span");
            BeginWriteAttribute("class", " class=\"", 534, "\"", 598, 2);
            WriteAttributeValue("", 542, "badge", 542, 5, true);
#nullable restore
#line 19 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml"
WriteAttributeValue(" ", 547, Model.IsHome ? "badge-success" : "badge-danger", 548, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 20 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml"
                 if (Model.IsHome)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Anasayfa</span>\r\n");
#nullable restore
#line 23 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Anasayfa Değil</span>\r\n");
#nullable restore
#line 27 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </span>\r\n\r\n            <span");
            BeginWriteAttribute("class", " class=\"", 868, "\"", 933, 2);
            WriteAttributeValue("", 876, "badge", 876, 5, true);
#nullable restore
#line 30 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml"
WriteAttributeValue(" ", 881, Model.IsStock ? "badge-success" : "badge-danger", 882, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 31 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml"
                 if (Model.IsStock)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Stokta</span>\r\n");
#nullable restore
#line 34 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Stokta Değil</span>\r\n");
#nullable restore
#line 38 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\AvansasProject2\AvansasProject2.UI\Areas\Admin\Views\Product\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </span>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AvansasProject2.MODEL.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
