#pragma checksum "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "440855e9d9e68df1c4448c4129a2038132204c44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryGet), @"mvc.1.0.view", @"/Views/Category/CategoryGet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"440855e9d9e68df1c4448c4129a2038132204c44", @"/Views/Category/CategoryGet.cshtml")]
    public class Views_Category_CategoryGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
  
    ViewData["Title"] = "CategoryGet";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>Category Update</h1>\r\n<br />\r\n");
#nullable restore
#line 11 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
 using (Html.BeginForm("CategoryUpdate", "Category", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.LabelFor(x => x.CategoryID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.TextBoxFor(x => x.CategoryID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br>\r\n");
#nullable restore
#line 16 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.LabelFor(x => x.CategoryName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.ValidationMessageFor(x => x.CategoryName, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br>\r\n");
#nullable restore
#line 20 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.LabelFor(x => x.CategoryDescription));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.TextBoxFor(x => x.CategoryDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br>\r\n    <button class=\"btn btn-info\">Update</button>\r\n");
#nullable restore
#line 24 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
