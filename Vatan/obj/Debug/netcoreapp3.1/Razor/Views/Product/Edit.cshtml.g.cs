#pragma checksum "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d38daccd6836226dab599cc23eda50149256b17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Edit), @"mvc.1.0.view", @"/Views/Product/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d38daccd6836226dab599cc23eda50149256b17", @"/Views/Product/Edit.cshtml")]
    public class Views_Product_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vatan.Models.VM.ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header card-header-primary"">
                <h4 class=""card-title"">Edit PRoduct</h4>
                <p class=""card-category"">Edit a product</p>
            </div>
            <div class=""card-body"">
                <form action=""/Product/Edit"" method=""post"">
                    ");
#nullable restore
#line 19 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Edit.cshtml"
               Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 21 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Edit.cshtml"
               Write(await Html.PartialAsync("Partial/ProductForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 23 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Edit.cshtml"
               Write(Html.HiddenFor(q => q.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <button type=\"submit\" class=\"btn btn-primary pull-right\">Edit Product</button>\r\n                    <div class=\"clearfix\"></div>\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vatan.Models.VM.ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
