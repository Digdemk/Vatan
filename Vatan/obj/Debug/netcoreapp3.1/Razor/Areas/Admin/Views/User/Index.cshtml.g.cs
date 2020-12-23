#pragma checksum "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6252793c9b3a6f3c42feacae48caa0219509519f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6252793c9b3a6f3c42feacae48caa0219509519f", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719e21ca811eabf282219850cb8b4b0f62ecb3d8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    <!-- Page Heading -->\r\n");
            WriteLiteral(@"
    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">User List</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Name</th>
                            <th>Surname</th>
                            <th>Mail</th>
                            <th>Phone</th>
                            <th>Address</th>
                            <th>Password</th>
                            <th>Edit</th>
                            <th>Delete2</th>
                            <th>Delete</th>


                        </tr>
                    </thead>

                    <tbody>
");
#nullable restore
#line 45 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("id", " id=\"", 1696, "\"", 1709, 1);
#nullable restore
#line 47 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1701, item.ID, 1701, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
                               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 50 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
                               Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 51 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
                               Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 52 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
                               Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
                               Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 54 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
                               Write(item.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2171, "\"", 2203, 2);
            WriteAttributeValue("", 2178, "/Admin/User/Edit/", 2178, 17, true);
#nullable restore
#line 57 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 2195, item.ID, 2195, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-outline-success\">Edit</button></a>\r\n                                </td>\r\n                                <td>\r\n\r\n\r\n                                    <button class=\"btn btn-outline-primary detay\"");
            BeginWriteAttribute("id", " id=\"", 2426, "\"", 2439, 1);
#nullable restore
#line 62 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 2431, item.ID, 2431, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""material-icons"">description</i>
                                    </button>


                                </td>
                                <td>

                                    <button class=""btn btn-outline-danger delete""");
            BeginWriteAttribute("id", " id=\"", 2737, "\"", 2750, 1);
#nullable restore
#line 70 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 2742, item.ID, 2742, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\User\Index.cshtml"
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



<div class=""modal fade"" id=""deletemodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Author Detail</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-body"">


                <h3>Silmek istediğinizden eminmisiniz?</h3>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-secondary delete2"" data-dismiss=""modal"">Sil</");
            WriteLiteral("button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <!-- Page level plugins -->
    <script src=""/vendor/datatables/jquery.dataTables.min.js""></script>
    <script src=""/vendor/datatables/dataTables.bootstrap4.min.js""></script>

    <!-- Page level custom scripts -->
    <script src=""/js/demo/datatables-demo.js""></script> ");
            }
            );
            WriteLiteral(@"

<script>
    //$(document).on(""click"", "".delete2"", function () {

    //    let id = $(this).attr(""id"");

    //    $.ajax({
    //        url: ""/User/Delete"",
    //        type: ""POST"",
    //        data: { id: id },
    //        success: function (msg) {
    //            alert(msg);
    //            $(""#"" + id).fadeOut();
    //        },
    //        error: function (err) {
    //            alert(""User Deleting Failed!"");
    //        }

    //    })
    //})


    $(document).on(""click"", "".delete"", function () {
        var confirmation = confirm(""are you sure you want to remove the item?"");
        if (confirmation) {
            let id = $(this).attr(""id"")
            $.ajax({
                url: ""/Admin/User/Delete"",

                type: ""POST"",
                data: { id: id },
                success: function (msg) {
                    $(""#"" + id).fadeOut();
                },
                error: function (err) {
                    alert(""Product");
            WriteLiteral(" Deleting Failed!\");\r\n                }\r\n            })\r\n        }\r\n    })\r\n\r\n\r\n\r\n    $(document).on(\"click\", \".detay\", function () {\r\n        let id = $(this).attr(\"id\");\r\n\r\n\r\n\r\n        $(\"#deletemodal\").modal();\r\n\r\n    })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
