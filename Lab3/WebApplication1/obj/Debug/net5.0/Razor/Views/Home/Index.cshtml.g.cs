#pragma checksum "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9cf5b235112491010e916f36fa80808c72a14b0"
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
#nullable restore
#line 1 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9cf5b235112491010e916f36fa80808c72a14b0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.PostVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
  
    ViewBag.Title = "All posts List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Post List</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 11 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 14 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.guestLogin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 17 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.NewsHeader));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 20 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.NewsBody));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Rubric));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 26 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Topic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 29 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Tags));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 32 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 36 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
     foreach(var post in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <th>\r\n        ");
#nullable restore
#line 40 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(postItem => post.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th>\r\n    <th>\r\n        ");
#nullable restore
#line 43 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(postItem => post.guestLogin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th>\r\n    <th>\r\n        ");
#nullable restore
#line 46 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(postItem => post.NewsHeader));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th>\r\n    <th>\r\n        ");
#nullable restore
#line 49 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(postItem => post.NewsBody));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th>\r\n    <th>\r\n        ");
#nullable restore
#line 52 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(postItem => post.Rubric));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th>\r\n    <th>\r\n        ");
#nullable restore
#line 55 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(postItem => post.Topic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th>\r\n    <th>\r\n        ");
#nullable restore
#line 58 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(postItem => post.Tags));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th>\r\n    <th>\r\n        ");
#nullable restore
#line 61 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(postItem => post.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th>\r\n</tr>\r\n");
#nullable restore
#line 64 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 67 "C:\Users\Flink\OneDrive\Робочий стіл\Lab3\WebApplication1\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Sign up", "SignUp"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.PostVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
