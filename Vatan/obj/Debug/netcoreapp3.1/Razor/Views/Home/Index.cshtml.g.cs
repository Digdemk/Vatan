#pragma checksum "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49a0a54372ce6123d70efec2bf00e173fa63cb29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49a0a54372ce6123d70efec2bf00e173fa63cb29", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vatan.Models.VM.HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\" style=\"margin-bottom:20px\">\r\n    <div class=\"col-md-3\">\r\n        <div class=\"card card-stats\">\r\n            <div class=\"card-header card-header-warning card-header-icon\">\r\n\r\n                <h3 class=\"card-title\">\r\n                    ");
#nullable restore
#line 14 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
               Write(ViewBag.TotalUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <small>Users</small>
                </h3>
            </div>
        </div>
    </div>
    <div class=""col-md-3"">
        <div class=""card card-stats"">
            <div class=""card-header card-header-info card-header-icon"">

                <h3 class=""card-title"">
                    ");
#nullable restore
#line 25 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
               Write(ViewBag.TotalCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <small>Categories </small>
                </h3>
            </div>
        </div>
    </div>
    <div class=""col-md-3"">
        <div class=""card card-stats"">
            <div class=""card-header card-header-primary card-header-icon"">

                <h3 class=""card-title"">
                    ");
#nullable restore
#line 36 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
               Write(ViewBag.TotalProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <small>Products</small>
                </h3>
            </div>
        </div>
    </div>
</div>

<div class=""row"" style=""margin-bottom:20px"">
    <div class=""col-lg-6 col-md-12"">
        <div class=""card"">
            <div class=""card-header card-header-warning"">
                <h4 class=""card-title"">Categories</h4>
");
            WriteLiteral(@"            </div>
            <div class=""card-body table-responsive"">
                <table class=""table table-hover"">
                    <thead class=""text-warning"">
                        <tr>
                            <th>ID</th>
                            <th>Name</th>
                            <th>Top Category</th>



                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 64 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                         foreach (var item in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("id", " id=\"", 2077, "\"", 2090, 1);
#nullable restore
#line 66 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
WriteAttributeValue("", 2082, item.ID, 2082, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 67 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 68 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 69 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.TopCategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 73 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class=""col-lg-6 col-md-12"">
        <div class=""card"">
            <div class=""card-header card-header-info"">
                <h4 class=""card-title"">Products</h4>
                <p class=""card-category"">All products</p>
            </div>
            <div class=""card-body table-responsive"">
                <table class=""table table-hover"">
                    <thead class=""text-info"">
                        <tr class=""text-center"">
                            <th>ID</th>
                            <th>Name</th>
                            <th>Description</th>
                            <th>Quantity</th>
                            <th>Price</th>
                            <th>Category</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 100 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                         foreach (var item in Model.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"text-center\">\r\n                                <td>");
#nullable restore
#line 103 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 104 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 105 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 106 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 107 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 110 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>
            </div>
        </div>
    </div>

</div>
<div class=""row"">
    <div class=""col-lg-6 col-md-12"">
        <div class=""card"">
            <div class=""card-header card-header-primary"">
                <h4 class=""card-title"">Users</h4>
                <p class=""card-category"">All users of this page</p>
            </div>
            <div class=""card-body table-responsive"">
                <table class=""table table-hover"">
                    <thead class=""text-primary"">
                        <tr class=""text-center"">
                            <th>ID</th>
                            <th>Name</th>
                            <th>Surname</th>
                            <th>Mail</th>
                            <th>Phone</th>
                            <th>Address</th>
                            <th>Password</th>
");
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 142 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                         foreach (var item in Model.Users)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"text-center\">\r\n                                <td>");
#nullable restore
#line 145 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 146 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 147 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 148 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 149 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 150 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 151 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                               Write(item.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 155 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vatan.Models.VM.HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
