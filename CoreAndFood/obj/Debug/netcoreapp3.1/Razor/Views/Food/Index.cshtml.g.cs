#pragma checksum "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56069fe2532f509acc1d4e70838568a8d6bec790"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Index), @"mvc.1.0.view", @"/Views/Food/Index.cshtml")]
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
#line 1 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56069fe2532f509acc1d4e70838568a8d6bec790", @"/Views/Food/Index.cshtml")]
    public class Views_Food_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<CoreAndFood.Data.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Food List</h1>


<table class=""table table-bordered"">
    <tr>
        <th>Id</th>
        <th>Name</th>
        <th>Price</th>
        <th>Stock</th>
        <th>Category Name</th>
        <th>Delete</th>
        <th>Update</th>
        <th>Details</th>
    </tr>

");
#nullable restore
#line 24 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <th>");
#nullable restore
#line 28 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(item.FoodID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 29 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 736, "\"", 772, 2);
            WriteAttributeValue("", 743, "/Food/DeleteFood/", 743, 17, true);
#nullable restore
#line 33 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
WriteAttributeValue("", 760, item.FoodID, 760, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 832, "\"", 865, 2);
            WriteAttributeValue("", 839, "/Food/FoodGet/", 839, 14, true);
#nullable restore
#line 34 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
WriteAttributeValue("", 853, item.FoodID, 853, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-info\">Details</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 39 "D:\Users\merta\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("Index",new  {page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<a href=\"/Food/AddFood/\" class=\"btn btn-primary\">New Food</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
