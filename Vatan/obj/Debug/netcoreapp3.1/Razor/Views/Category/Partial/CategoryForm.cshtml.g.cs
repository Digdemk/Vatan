#pragma checksum "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Category\Partial\CategoryForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "172831cc1592c479f9f9d8340c77ebb4e08ccd21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Partial_CategoryForm), @"mvc.1.0.view", @"/Views/Category/Partial/CategoryForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"172831cc1592c479f9f9d8340c77ebb4e08ccd21", @"/Views/Category/Partial/CategoryForm.cshtml")]
    public class Views_Category_Partial_CategoryForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vatan.Models.VM.CategoryVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <style>\r\n        .field-validation-error{\r\n            color:red\r\n        }\r\n    </style>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 10 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Category\Partial\CategoryForm.cshtml"
   Write(Html.LabelFor(q => q.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Category\Partial\CategoryForm.cshtml"
   Write(Html.TextBoxFor(q => q.CategoryName, new { @placeholder = "Enter Category Name"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 15 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Category\Partial\CategoryForm.cshtml"
   Write(Html.LabelFor(q => q.TopCategoryID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Category\Partial\CategoryForm.cshtml"
   Write(Html.TextBoxFor(q => q.TopCategoryID, new { @placeholder = "Enter Top Category ID"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vatan.Models.VM.CategoryVM> Html { get; private set; }
    }
}
#pragma warning restore 1591