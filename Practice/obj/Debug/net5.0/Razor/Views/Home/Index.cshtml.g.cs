#pragma checksum "D:\Azure\Practice-ASP.NET-Core-MVC\Practice\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ad2edb14b29b25bff04312f0afecd3d6024e536"
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
#line 1 "D:\Azure\Practice-ASP.NET-Core-MVC\Practice\Views\_ViewImports.cshtml"
using Practice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Azure\Practice-ASP.NET-Core-MVC\Practice\Views\_ViewImports.cshtml"
using Practice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad2edb14b29b25bff04312f0afecd3d6024e536", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd757ed8785d7859154d904007503f4f18d9d71", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Azure\Practice-ASP.NET-Core-MVC\Practice\Views\Home\Index.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h3>Name: ");
#nullable restore
#line 5 "D:\Azure\Practice-ASP.NET-Core-MVC\Practice\Views\Home\Index.cshtml"
             Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        Age: ");
#nullable restore
#line 6 "D:\Azure\Practice-ASP.NET-Core-MVC\Practice\Views\Home\Index.cshtml"
        Write(p.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Address: ");
#nullable restore
#line 7 "D:\Azure\Practice-ASP.NET-Core-MVC\Practice\Views\Home\Index.cshtml"
            Write(p.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <p>----------------</p>\r\n        <br />\r\n    </div>\r\n");
#nullable restore
#line 11 "D:\Azure\Practice-ASP.NET-Core-MVC\Practice\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
