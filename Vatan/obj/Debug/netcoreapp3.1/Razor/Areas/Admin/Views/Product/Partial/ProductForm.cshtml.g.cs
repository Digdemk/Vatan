#pragma checksum "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a987ed0534502d4f49ded9f2a40dd6cc9bc3c01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Partial_ProductForm), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Partial/ProductForm.cshtml")]
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
#line 3 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\_ViewImports.cshtml"
using Vatan.Areas.Admin.Models.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\_ViewImports.cshtml"
using Vatan.Areas.Admin.Models.ORM.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a987ed0534502d4f49ded9f2a40dd6cc9bc3c01", @"/Areas/Admin/Views/Product/Partial/ProductForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719e21ca811eabf282219850cb8b4b0f62ecb3d8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Partial_ProductForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 9 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
       Write(Html.LabelFor(q => q.ProductName, new { @class = "col-sm-3 text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 10 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
       Write(Html.TextBoxFor(q => q.ProductName, new { @placeholder = "Enter Product name", @class = "form-control", @id = "fname" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 11 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
       Write(Html.ValidationMessageFor(q => q.ProductName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 16 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
       Write(Html.LabelFor(q => q.Description, new { @class = "col-sm-3 text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("            ");
#nullable restore
#line 19 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
       Write(Html.TextBoxFor(q => q.Description, new { @placeholder = "Enter description", @class = "form-control", @id = "duration" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 20 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
       Write(Html.ValidationMessageFor(q => q.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
       Write(Html.LabelFor(q => q.Quantity, new { @class = "col-sm-3 text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            ");
#nullable restore
#line 27 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
       Write(Html.TextBoxFor(q => q.Quantity, new { @placeholder = "Enter quantity", @class = "form-control", @id = "posterurl" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 28 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
       Write(Html.ValidationMessageFor(q => q.Quantity, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 35 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
       Write(Html.LabelFor(q => q.Price, new { @class = "col-sm-3 text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            ");
#nullable restore
#line 37 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
       Write(Html.TextBoxFor(q => q.Price, new { @type = "text", @placeholder = "Enter price", @class = "form-control mydatepicker" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 38 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
       Write(Html.ValidationMessageFor(q => q.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            <label class=\"bmd-label-floating\">Categories:</label>\r\n            <br>\r\n");
#nullable restore
#line 48 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
             foreach (var item in Model.categoryCheck)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"checkbox\" name=\"categoryArray\"");
            BeginWriteAttribute("value", " value=\"", 2191, "\"", 2215, 1);
#nullable restore
#line 51 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
WriteAttributeValue("", 2199, item.categoryid, 2199, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 2216, "\"", 2241, 1);
#nullable restore
#line 51 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
WriteAttributeValue("", 2226, item.IsChecked, 2226, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <label>");
#nullable restore
#line 52 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"
                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n");
#nullable restore
#line 53 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Product\Partial\ProductForm.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>

    <div class=""form-group"">
        <label class=""bmd-label-floating"">Choose an image</label>
        <input type=""file"" name=""productimages"" multiple accept=""image/x-png,image/gif,image/jpeg"" class=""btn btn-danger"" style=""position:initial; opacity:initial"" />
    </div>

</div>
<script>
    $(function () {
        $(""#datepicker"").datepicker({

        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
