#pragma checksum "C:\DevBuild\Week11\Lab11_1_StackOverflow\Views\Question\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e9e52b6e02bb369b2437024a0991b792fe62b3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_Index), @"mvc.1.0.view", @"/Views/Question/Index.cshtml")]
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
#line 1 "C:\DevBuild\Week11\Lab11_1_StackOverflow\Views\_ViewImports.cshtml"
using Lab11_1_StackOverflow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DevBuild\Week11\Lab11_1_StackOverflow\Views\_ViewImports.cshtml"
using Lab11_1_StackOverflow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9e52b6e02bb369b2437024a0991b792fe62b3b", @"/Views/Question/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c9898497db8eec7fe4747b82238e7958c4706c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Question>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\DevBuild\Week11\Lab11_1_StackOverflow\Views\Question\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>FoC StackOverflow</h1>\r\n\r\n<div>");
#nullable restore
#line 8 "C:\DevBuild\Week11\Lab11_1_StackOverflow\Views\Question\Index.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 10 "C:\DevBuild\Week11\Lab11_1_StackOverflow\Views\Question\Index.cshtml"
  
    ICollection<Question> q = Model as ICollection<Question>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\DevBuild\Week11\Lab11_1_StackOverflow\Views\Question\Index.cshtml"
Write(q);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 16 "C:\DevBuild\Week11\Lab11_1_StackOverflow\Views\Question\Index.cshtml"
 if (q.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>Model is null</div>\r\n");
#nullable restore
#line 19 "C:\DevBuild\Week11\Lab11_1_StackOverflow\Views\Question\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div> Model is not null</div>\r\n");
#nullable restore
#line 23 "C:\DevBuild\Week11\Lab11_1_StackOverflow\Views\Question\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\DevBuild\Week11\Lab11_1_StackOverflow\Views\Question\Index.cshtml"
 foreach (Question question in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>");
#nullable restore
#line 27 "C:\DevBuild\Week11\Lab11_1_StackOverflow\Views\Question\Index.cshtml"
    Write(question.questionTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 28 "C:\DevBuild\Week11\Lab11_1_StackOverflow\Views\Question\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
