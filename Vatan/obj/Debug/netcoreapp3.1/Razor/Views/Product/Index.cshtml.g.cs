#pragma checksum "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e887146d37cd8dde6d1f66de64575a2cd09a0006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e887146d37cd8dde6d1f66de64575a2cd09a0006", @"/Views/Product/Index.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vatan.Models.VM.ProductVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n\r\n    <!-- Page Heading -->\r\n");
            WriteLiteral(@"
    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Product List</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Name</th>
                            <th>Description</th>
                            <th>Quantity</th>
                            <th>Price</th>
                            <th>Category</th>
");
            WriteLiteral("                            <th>Edit</th>\r\n                            <th>Delete</th>\r\n\r\n\r\n\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("id", " id=\"", 1652, "\"", 1665, 1);
#nullable restore
#line 47 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
WriteAttributeValue("", 1657, item.ID, 1657, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
                               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 50 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 51 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 52 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td>\r\n");
#nullable restore
#line 55 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
                                     foreach (var item2 in item.categories)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>");
#nullable restore
#line 57 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
                                         Write(item2.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("/</span>\r\n");
#nullable restore
#line 58 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
            WriteLiteral("                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2647, "\"", 2676, 2);
            WriteAttributeValue("", 2654, "/Product/Edit/", 2654, 14, true);
#nullable restore
#line 67 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
WriteAttributeValue("", 2668, item.ID, 2668, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-outline-success\">Edit</button></a>\r\n                                </td>\r\n                                <td>\r\n\r\n                                    <button class=\"btn btn-outline-danger delete\"");
            BeginWriteAttribute("id", " id=\"", 2897, "\"", 2910, 1);
#nullable restore
#line 71 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
WriteAttributeValue("", 2902, item.ID, 2902, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 75 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\Product\Index.cshtml"
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
<div class=""modal fade"" id=""detailmodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Author Detail</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
           
            <div class=""modal-body"">
                <div>
                    <span>Name:</span>
                    <span id=""Name""></span>
                </div>
                <div>
                    <span>Surname:</span>
                    <span id=""Description""></span>
                </div>
                <div>
                    <spa");
            WriteLiteral(@"n>EMail:</span>
                    <span id=""Quantity""></span>
                </div>
                <div>
                    <span>Phone:</span>
                    <span id=""Price""></span>
                </div>
             
                <div>
                    <span>Categories:</span>
                    <ul id=""categories"">
                    </ul>
                </div>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>


<!-- Page level plugins -->
<script src=""/vendor/datatables/jquery.dataTables.min.js""></script>
<script src=""/vendor/datatables/dataTables.bootstrap4.min.js""></script>

<!-- Page level custom scripts -->
<script src=""/js/demo/datatables-demo.js""></script>


<script>
    $(document).on(""click"", "".delete"", function () {
        var confirmation = confirm(""are you sure you want to remove th");
            WriteLiteral(@"e item?"");
        if (confirmation) {
            let id = $(this).attr(""id"")
            $.ajax({
                url: ""/Product/Delete"",
                type: ""POST"",
                data: { id: id },
                success: function (msg) {
                   
                    $(""#"" + id).fadeOut();
                },
                error: function (err) {
                    alert(""Product Deleting Failed!"");
                }
            })
        }
        
    })

    





    $(document).on(""click"", "".detay"", function () {
        let id = $(this).attr(""id"");
        fetch(""/Product/Detail/"" + id)
            .then((res) => res.json())
            .then((result) => {
                console.log(result);
                $(""#Name"").html(result.productName);
                $(""#Description"").html(result.description);
                $(""#Quantity"").html(result.quantity);
                $(""#Price"").html(result.price);
          


                $(""#categorie");
            WriteLiteral(@"s li"").remove();

                for (var i = 0; i < result.categories.length; i++) {


                    $(""#categories"").append(`
                          <li>`+ result.categories[i].categoryName + `</li>

                         `);
                }

                $(""#detailmodal"").modal();
            })
    })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Vatan.Models.VM.ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
