#pragma checksum "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cca6cbd20acb87c3de1fbac865801fe9dec1ecb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminUser_Partial_AdminUserForm), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminUser/Partial/AdminUserForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cca6cbd20acb87c3de1fbac865801fe9dec1ecb", @"/Areas/Admin/Views/AdminUser/Partial/AdminUserForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719e21ca811eabf282219850cb8b4b0f62ecb3d8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminUser_Partial_AdminUserForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminUserVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n   \r\n        <div class=\"form-group row\">\r\n            <div class=\"col-sm-6 mb-3 mb-sm-0\">\r\n");
            WriteLiteral("                ");
#nullable restore
#line 9 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
           Write(Html.LabelFor(q => q.Name, new { @class = "text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 10 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
           Write(Html.TextBoxFor(q => q.Name, new { @placeholder = "Enter Your First Name *", @class = "form-control", @id = "name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 11 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
           Write(Html.ValidationMessageFor(q => q.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n");
            WriteLiteral("                ");
#nullable restore
#line 16 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
           Write(Html.LabelFor(q => q.Surname, new { @class = "text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 17 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
           Write(Html.TextBoxFor(q => q.Surname, new { @placeholder = "Enter Your Last Name *", @class = "form-control", @id = "surname" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 18 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
           Write(Html.ValidationMessageFor(q => q.Surname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
            WriteLiteral("            ");
#nullable restore
#line 24 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
       Write(Html.LabelFor(q => q.EMail, new { @class = " text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
       Write(Html.TextBoxFor(q => q.EMail, new { @placeholder = "Enter Your Email *", @class = "form-control", @id = "fname", @type = "email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 26 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
       Write(Html.ValidationMessageFor(q => q.EMail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <div class=\"col-sm-6 mb-3 mb-sm-0\">\r\n");
            WriteLiteral("                ");
#nullable restore
#line 32 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
           Write(Html.LabelFor(q => q.Password, new { @class = "text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 33 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
           Write(Html.PasswordFor(q => q.Password, new { @placeholder = "Create Your Password *", @class = "form-control", @id = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 34 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
           Write(Html.ValidationMessageFor(q => q.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n");
            WriteLiteral("                ");
#nullable restore
#line 39 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
           Write(Html.LabelFor(q => q.Confirmpassword, new { @class = "text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 40 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
           Write(Html.PasswordFor(q => q.Confirmpassword, new { @placeholder = "Confirm Your Password *", @class = "form-control", @id = "cfpassword" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 41 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\AdminUser\Partial\AdminUserForm.cshtml"
           Write(Html.ValidationMessageFor(q => q.Confirmpassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n   \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminUserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
