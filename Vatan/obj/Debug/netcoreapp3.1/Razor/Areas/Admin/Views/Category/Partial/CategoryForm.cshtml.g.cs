#pragma checksum "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Category\Partial\CategoryForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f20c9f08e36c7cb1aab345d43cb678916d5841c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Partial_CategoryForm), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Partial/CategoryForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20c9f08e36c7cb1aab345d43cb678916d5841c5", @"/Areas/Admin/Views/Category/Partial/CategoryForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719e21ca811eabf282219850cb8b4b0f62ecb3d8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Partial_CategoryForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 7 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Category\Partial\CategoryForm.cshtml"
           Write(Html.LabelFor(q => q.CategoryName, new { @class = "col-sm-3 text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 8 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Category\Partial\CategoryForm.cshtml"
           Write(Html.TextBoxFor(q => q.CategoryName, new { @placeholder = "Enter Category Name", @class = "form-control", @id = "fname" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 9 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Category\Partial\CategoryForm.cshtml"
           Write(Html.ValidationMessageFor(q => q.CategoryName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n            <div class=\"form-group\">\r\n");
            WriteLiteral(@"             
                
                        <label for=""Categories"">Categories</label>
                        <select class=""form-control selectpicker"" data-style=""btn btn-link"" name=""categoryid"" id=""Categories"">
                            <option value=""0"">Kategori Seçin</option>
");
#nullable restore
#line 22 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Category\Partial\CategoryForm.cshtml"
                             foreach (var item in Model.categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 1325, "\"", 1341, 1);
#nullable restore
#line 24 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Category\Partial\CategoryForm.cshtml"
WriteAttributeValue("", 1333, item.ID, 1333, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Category\Partial\CategoryForm.cshtml"
                                                    Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 25 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Category\Partial\CategoryForm.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </select>\r\n                    \r\n            </div>\r\n        </div>\r\n      \r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
