#pragma checksum "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb5931068855893b17eb1f3c89d4b5f3c460a683"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb5931068855893b17eb1f3c89d4b5f3c460a683", @"/Views/Login/Index.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Login/Index/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Login\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb5931068855893b17eb1f3c89d4b5f3c460a6834165", async() => {
                WriteLiteral(@"
    <title>Login</title>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!--===============================================================================================-->
    <link rel=""icon"" type=""image/png"" href=""/Login_v6/images/icons/favicon.ico"" />
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/vendor/bootstrap/css/bootstrap.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/fonts/iconic/css/material-design-iconic-font.min.css"">
    <!--==========================================");
                WriteLiteral(@"=====================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/vendor/animate/animate.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/vendor/css-hamburgers/hamburgers.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/vendor/animsition/css/animsition.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/vendor/select2/select2.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/vendor/daterangepicker/daterangepicker.css"">
    <!--=================================");
                WriteLiteral(@"==============================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/css/util.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/css/main.css"">
    <!--===============================================================================================-->
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb5931068855893b17eb1f3c89d4b5f3c460a6837645", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"limiter\">\r\n        <div class=\"container-login100\">\r\n            <div class=\"wrap-login100 p-t-85 p-b-20\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb5931068855893b17eb1f3c89d4b5f3c460a6838059", async() => {
                    WriteLiteral(@"
                    <span class=""login100-form-title p-b-70"">
                        Welcome to Admin Panel
                    </span>
                    

                    <div class=""wrap-input100 validate-input m-t-85 m-b-35"" data-validate=""Enter username"">
                        <input class=""input100"" type=""text"" name=""UserName"">
                        <span class=""focus-input100"" data-placeholder=""UserName""></span>
                    </div>

                    <div class=""wrap-input100 validate-input m-b-50"" data-validate=""Enter password"">
                        <input class=""input100"" type=""password"" name=""Password"">
                        <span class=""focus-input100"" data-placeholder=""Password""></span>
                    </div>

                    <div class=""container-login100-form-btn"">
                        <button class=""login100-form-btn"">
                            Login
                        </button>
                    </div>

                    <ul ");
                    WriteLiteral(@"class=""login-more p-t-190"">
                        <li class=""m-b-8"">
                            <a href=""#"" class=""txt2"">
                                To Mainpage
                            </a>
                        </li>
                    </ul>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
        </div>
    </div>


    <div id=""dropDownSelect1""></div>

    <!--===============================================================================================-->
    <script src=""/Login_v6/vendor/jquery/jquery-3.2.1.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/Login_v6/vendor/animsition/js/animsition.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/Login_v6/vendor/bootstrap/js/popper.js""></script>
    <script src=""/Login_v6/vendor/bootstrap/js/bootstrap.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/Login_v6/vendor/select2/select2.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/Login_v");
                WriteLiteral(@"6/vendor/daterangepicker/moment.min.js""></script>
    <script src=""/Login_v6/vendor/daterangepicker/daterangepicker.js""></script>
    <!--===============================================================================================-->
    <script src=""/Login_v6/vendor/countdowntime/countdowntime.js""></script>
    <!--===============================================================================================-->
    <script src=""/Login_v6/js/main.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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