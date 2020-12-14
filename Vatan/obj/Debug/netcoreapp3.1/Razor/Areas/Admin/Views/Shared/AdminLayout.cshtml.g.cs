#pragma checksum "C:\Users\User\Desktop\MVC\Yeni klasör\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea4705fd5378a5b655c45c16de506120dc2c3be8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_AdminLayout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/AdminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea4705fd5378a5b655c45c16de506120dc2c3be8", @"/Areas/Admin/Views/Shared/AdminLayout.cshtml")]
    public class Areas_Admin_Views_Shared_AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea4705fd5378a5b655c45c16de506120dc2c3be83162", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 254, "\"", 264, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 291, "\"", 301, 0);
                EndWriteAttribute();
                WriteLiteral(@">

    <title>SB Admin 2 - Blank</title>

    <!-- Custom fonts for this template-->
    <link href=""../../vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i""
          rel=""stylesheet"">

    <!-- Custom styles for this template-->
    <link href=""../../css/sb-admin-2.min.css"" rel=""stylesheet"">

    <!-- Bootstrap core JavaScript-->
    <script src=""../../vendor/jquery/jquery.min.js""></script>
    <script src=""../../vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
 
    <!-- Core plugin JavaScript-->
    <script src=""../../vendor/jquery-easing/jquery.easing.min.js""></script>

    <!-- Custom scripts for all pages-->
    <script src=""../../js/sb-admin-2.min.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea4705fd5378a5b655c45c16de506120dc2c3be85584", async() => {
                WriteLiteral(@"

    <!-- Page Wrapper -->
    <div id=""wrapper"">

        <!-- Sidebar -->
        <ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

            <!-- Sidebar - Brand -->
            <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""index.html"">
                <div class=""sidebar-brand-icon rotate-n-15"">
                    <i class=""fas fa-laugh-wink""></i>
                </div>
                <div class=""sidebar-brand-text mx-3"">SB Admin <sup>2</sup></div>
            </a>

            <!-- Divider -->
            <hr class=""sidebar-divider my-0"">

            <!-- Nav Item - Dashboard -->
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Admin"">
                    <i class=""fas fa-fw fa-tachometer-alt""></i>
                    <span>Dashboard</span>
                </a>
            </li>

            <!-- Divider -->
            <hr class=""sidebar-divider"">

           ");
                WriteLiteral(@" <!-- Heading -->
            <div class=""sidebar-heading"">
                Interface
            </div>

            <!-- Nav Item - Pages Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""/Admin/category"" data-toggle=""collapse"" data-target=""#category""
                   aria-expanded=""true"" aria-controls=""category"">
                    <i class=""fa fa-list-alt"" aria-hidden=""true""></i>
                    <span>Categories</span>
                </a>
                <div id=""category"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Custom Components:</h6>
                        <a class=""collapse-item"" href=""/Admin/category"">    <i class=""fas fa-list""></i>   List Category</a>
                        <a class=""collapse-item"" href=""/Admin/category/add"">  <i class=""fas fa-plus""></i> Add Cate");
                WriteLiteral(@"gory</a>


                    </div>
                </div>
            </li>

            <li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""/admin/product"" data-toggle=""collapse"" data-target=""#product""
                   aria-expanded=""true"" aria-controls=""product"">
                    <i class=""fab fa-product-hunt""></i>
                    <span>Products</span>
                </a>
                <div id=""product"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Custom Components:</h6>
                        <a class=""collapse-item"" href=""/Admin/Product""><i class=""fas fa-list""></i>   List Product</a>
                        <a class=""collapse-item"" href=""/Admin/Product/add"">  <i class=""fas fa-plus""></i>  Add Product</a>


                    </div>
                </div>
            </li>

            <!-- ");
                WriteLiteral(@"Nav Item - Utilities Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""/Admin/User"" data-toggle=""collapse"" data-target=""#user""
                   aria-expanded=""true"" aria-controls=""user"">
                    <i class=""fas fa-user""></i>
                    <span>User</span>
                </a>
                <div id=""user"" class=""collapse"" aria-labelledby=""headingUtilities""
                     data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Custom Utilities:</h6>
                        <a class=""collapse-item"" href=""/Admin/User""><i class=""fas fa-list""></i>   List User</a>
                        <a class=""collapse-item"" href=""/Admin/User/add"">  <i class=""fas fa-plus""></i>  Add User</a>

                    </div>
                </div>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link collaps");
                WriteLiteral(@"ed"" href=""/Admin/comment"" data-toggle=""collapse"" data-target=""#comment""
                   aria-expanded=""true"" aria-controls=""comment"">
                    <i class=""fas fa-comment""></i>
                    <span>Comments</span>
                </a>
                <div id=""comment"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Custom Components:</h6>
                        <a class=""collapse-item"" href=""/Admin/comment"">    <i class=""fas fa-list""></i>   List comment</a>
                        <a class=""collapse-item"" href=""/Admin/comment/add"">  <i class=""fas fa-plus""></i> Add comment</a>


                    </div>
                </div>
            </li>


            <!-- Divider -->
            <hr class=""sidebar-divider"">

            <!-- Heading -->
            <!-- Nav Item - Pages Collapse Menu -->
            <!-- Divider");
                WriteLiteral(@" -->
            <hr class=""sidebar-divider d-none d-md-block"">

            <!-- Sidebar Toggler (Sidebar) -->
            <div class=""text-center d-none d-md-inline"">
                <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
            </div>

        </ul>
        <!-- End of Sidebar -->
        <!-- Content Wrapper -->
        <div id=""content-wrapper"" class=""d-flex flex-column"">

            <!-- Main Content -->
            <div id=""content"">

                <!-- Topbar -->
                <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

                    <!-- Sidebar Toggle (Topbar) -->
                    <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
                        <i class=""fa fa-bars""></i>
                    </button>

                    <!-- Topbar Search -->
                    <form class=""d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw");
                WriteLiteral(@"-100 navbar-search"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for...""
                                   aria-label=""Search"" aria-describedby=""basic-addon2"">
                            <div class=""input-group-append"">
                                <button class=""btn btn-primary"" type=""button"">
                                    <i class=""fas fa-search fa-sm""></i>
                                </button>
                            </div>
                        </div>
                    </form>

                    <!-- Topbar Navbar -->
                    <ul class=""navbar-nav ml-auto"">

                        <!-- Nav Item - Search Dropdown (Visible Only XS) -->
                        <li class=""nav-item dropdown no-arrow d-sm-none"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button""
                       ");
                WriteLiteral(@"        data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-search fa-fw""></i>
                            </a>
                            <!-- Dropdown - Messages -->
                            <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in""
                                 aria-labelledby=""searchDropdown"">
                                <form class=""form-inline mr-auto w-100 navbar-search"">
                                    <div class=""input-group"">
                                        <input type=""text"" class=""form-control bg-light border-0 small""
                                               placeholder=""Search for..."" aria-label=""Search""
                                               aria-describedby=""basic-addon2"">
                                        <div class=""input-group-append"">
                                            <button class=""btn btn-primary"" type=""button"">
               ");
                WriteLiteral(@"                                 <i class=""fas fa-search fa-sm""></i>
                                            </button>
                                        </div>
                                    </div>
                                </form>
                            </div>
                        </li>

                        <!-- Nav Item - Alerts -->
                        <li class=""nav-item dropdown no-arrow mx-1"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-bell fa-fw""></i>
                                <!-- Counter - Alerts -->
                                <span class=""badge badge-danger badge-counter"">3+</span>
                            </a>
                            <!-- Dropdown - Alerts -->
                            <div class=""dropdown-list dropdown");
                WriteLiteral(@"-menu dropdown-menu-right shadow animated--grow-in""
                                 aria-labelledby=""alertsDropdown"">
                                <h6 class=""dropdown-header"">
                                    Alerts Center
                                </h6>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""mr-3"">
                                        <div class=""icon-circle bg-primary"">
                                            <i class=""fas fa-file-alt text-white""></i>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""small text-gray-500"">December 12, 2019</div>
                                        <span class=""font-weight-bold"">A new monthly report is ready to download!</span>
                                    </div>
                                </a>");
                WriteLiteral(@"
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""mr-3"">
                                        <div class=""icon-circle bg-success"">
                                            <i class=""fas fa-donate text-white""></i>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""small text-gray-500"">December 7, 2019</div>
                                        $290.29 has been deposited into your account!
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""mr-3"">
                                        <div class=""icon-circle bg-warning"">
                                            <i class=""fas fa-exclamation-triang");
                WriteLiteral(@"le text-white""></i>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""small text-gray-500"">December 2, 2019</div>
                                        Spending Alert: We've noticed unusually high spending for your account.
                                    </div>
                                </a>
                                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Show All Alerts</a>
                            </div>
                        </li>

                        <!-- Nav Item - Messages -->
                        <li class=""nav-item dropdown no-arrow mx-1"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""messagesDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-envelo");
                WriteLiteral(@"pe fa-fw""></i>
                                <!-- Counter - Messages -->
                                <span class=""badge badge-danger badge-counter"">7</span>
                            </a>
                            <!-- Dropdown - Messages -->
                            <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in""
                                 aria-labelledby=""messagesDropdown"">
                                <h6 class=""dropdown-header"">
                                    Message Center
                                </h6>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""../../img/undraw_profile_1.svg""");
                BeginWriteAttribute("alt", "\r\n                                             alt=\"", 14349, "\"", 14401, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <div class=""status-indicator bg-success""></div>
                                    </div>
                                    <div class=""font-weight-bold"">
                                        <div class=""text-truncate"">
                                            Hi there! I am wondering if you can help me with a
                                            problem I've been having.
                                        </div>
                                        <div class=""small text-gray-500"">Emily Fowler · 58m</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""../../img/undraw_profile_2.svg""");
                BeginWriteAttribute("alt", "\r\n                                             alt=\"", 15345, "\"", 15397, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <div class=""status-indicator""></div>
                                    </div>
                                    <div>
                                        <div class=""text-truncate"">
                                            I have the photos that you ordered last month, how
                                            would you like them sent to you?
                                        </div>
                                        <div class=""small text-gray-500"">Jae Chun · 1d</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""../../img/undraw_profile_3.svg""");
                BeginWriteAttribute("alt", "\r\n                                             alt=\"", 16307, "\"", 16359, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <div class=""status-indicator bg-warning""></div>
                                    </div>
                                    <div>
                                        <div class=""text-truncate"">
                                            Last month's report looks great, I am very happy with
                                            the progress so far, keep up the good work!
                                        </div>
                                        <div class=""small text-gray-500"">Morgan Alvarez · 2d</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""https://source.unsplash.com/Mv9hjnEUHR4/60x60""");
                BeginWriteAttribute("alt", "\r\n                                             alt=\"", 17315, "\"", 17367, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <div class=""status-indicator bg-success""></div>
                                    </div>
                                    <div>
                                        <div class=""text-truncate"">
                                            Am I a good boy? The reason I ask is because someone
                                            told me that people say this to all dogs, even if they aren't good...
                                        </div>
                                        <div class=""small text-gray-500"">Chicken the Dog · 2w</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Read More Messages</a>
                            </div>
                        </li>

                        <div class=""topbar-divider d-none d-sm-block""></div>

                        <!-- Nav Item - User Information -->");
                WriteLiteral(@"
                        <li class=""nav-item dropdown no-arrow"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">Douglas McGee</span>
                                <img class=""img-profile rounded-circle""
                                     src=""../../img/undraw_profile.svg"">
                            </a>
                            <!-- Dropdown - User Information -->
                            <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in""
                                 aria-labelledby=""userDropdown"">
                                <a class=""dropdown-item"" href=""#"">
                                    <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Profile
                  ");
                WriteLiteral(@"              </a>
                                <a class=""dropdown-item"" href=""#"">
                                    <i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Settings
                                </a>
                                <a class=""dropdown-item"" href=""#"">
                                    <i class=""fas fa-list fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Activity Log
                                </a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                                    <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Logout
                                </a>
                            </div>
                        </li>

                    </ul>

                </nav>
           ");
                WriteLiteral("     <!-- End of Topbar -->\r\n                <!-- Begin Page Content -->\r\n                <div class=\"container-fluid\">\r\n\r\n                    <!-- Page Heading -->\r\n                 ");
#nullable restore
#line 374 "C:\Users\User\Desktop\MVC\Yeni klasör\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
            Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                </div>
                <!-- /.container-fluid -->

            </div>
            <!-- End of Main Content -->
            <!-- Footer -->
            <footer class=""sticky-footer bg-white"">
                <div class=""container my-auto"">
                    <div class=""copyright text-center my-auto"">
                        <span>Copyright &copy; Your Website 2020</span>
                    </div>
                </div>
            </footer>
            <!-- End of Footer -->

        </div>
        <!-- End of Content Wrapper -->

    </div>
    <!-- End of Page Wrapper -->
    <!-- Scroll to Top Button-->
    <a class=""scroll-to-top rounded"" href=""#page-top"">
        <i class=""fas fa-angle-up""></i>
    </a>

    <!-- Logout Modal-->
    <div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
         aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">");
                WriteLiteral(@"
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                    <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
                <div class=""modal-footer"">
                    <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                    <a class=""btn btn-primary"" href=""login.html"">Logout</a>
                </div>
            </div>
        </div>
    </div>

 

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
