#pragma checksum "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82525130c6d7b3043da146aee9e38ece3d33dbf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Login_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82525130c6d7b3043da146aee9e38ece3d33dbf4", @"/Areas/Admin/Views/Login/Index.cshtml")]
    public class Areas_Admin_Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vatan.Areas.Admin.Models.VM.LoginVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-gradient-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82525130c6d7b3043da146aee9e38ece3d33dbf43170", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 298, "\"", 308, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 335, "\"", 345, 0);
                EndWriteAttribute();
                WriteLiteral(@">

    <title>SB Admin 2 - Login</title>

    <!-- Custom fonts for this template-->
    <link href=""/vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i""
          rel=""stylesheet"">

    <!-- Custom styles for this template-->
    <link href=""/css/sb-admin-2.min.css"" rel=""stylesheet"">
    <!-- Bootstrap core JavaScript-->
    <script src=""/vendor/jquery/jquery.min.js""></script>
    <script src=""/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Core plugin JavaScript-->
    <script src=""/vendor/jquery-easing/jquery.easing.min.js""></script>

    <!-- Custom scripts for all pages-->
    <script src=""/js/sb-admin-2.min.js""></script>


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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82525130c6d7b3043da146aee9e38ece3d33dbf45561", async() => {
                WriteLiteral(@"

    <div class=""container"">

        <!-- Outer Row -->
        <div class=""row justify-content-center"">

            <div class=""col-xl-10 col-lg-12 col-md-9"">

                <div class=""card o-hidden border-0 shadow-lg my-5"">
                    <div class=""card-body p-0"">
                        <!-- Nested Row within Card Body -->
                        <div class=""row"">
                            <div class=""col-lg-6 d-none d-lg-block bg-login-image""></div>
                            <div class=""col-lg-6"">
                                <div class=""p-5"">
                                    <div class=""text-center"">
                                        <h1 class=""h4 text-gray-900 mb-4"">Welcome Back!</h1>
                                        ");
#nullable restore
#line 53 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\Login\Index.cshtml"
                                   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <p style=\"color:red\">");
#nullable restore
#line 54 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\Login\Index.cshtml"
                                                        Write(ViewBag.error);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                    </div>
                                    <form class=""user"" action=""/Admin/Login/Index"" method=""post"">
                                        <div class=""form-group"">
                                            <input type=""email"" class=""form-control form-control-user""
                                                   id=""exampleInputEmail"" aria-describedby=""emailHelp""
                                                   placeholder=""Enter Email Address..."" name=""EMail"">
                                        </div>
                                        <div class=""form-group"">
                                            <input type=""password"" class=""form-control form-control-user""
                                                   id=""exampleInputPassword"" placeholder=""Password"" name=""Password"">
                                        </div>
                                        <div class=""form-group"">
                                            <");
                WriteLiteral(@"div class=""custom-control custom-checkbox small"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck"">
                                                <label class=""custom-control-label"" for=""customCheck"">
                                                    Remember
                                                    Me
                                                </label>
                                            </div>
                                        </div>
                                        <input class=""btn btn-primary btn-user btn-block"" type=""submit"" name=""name"" value=""Login"">
                                          
                                        
                                        <hr>
                                        <a href=""index.html"" class=""btn btn-google btn-user btn-block"">
                                            <i class=""fab fa-google fa-fw""></i> Login with Google
      ");
                WriteLiteral(@"                                  </a>
                                        <a href=""index.html"" class=""btn btn-facebook btn-user btn-block"">
                                            <i class=""fab fa-facebook-f fa-fw""></i> Login with Facebook
                                        </a>
                                    </form>
                                    <hr>
                                    <div class=""text-center"">
                                        <a class=""small"" href=""forgot-password.html"">Forgot Password?</a>
                                    </div>
                                    <div class=""text-center"">
                                        <a class=""small"" href=""register.html"">Create an Account!</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </div>

");
                WriteLiteral("  \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vatan.Areas.Admin.Models.VM.LoginVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
