#pragma checksum "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e3a610bc7a540fa7be74e160b4aa371b4fb178c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Create), @"mvc.1.0.view", @"/Views/Authors/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authors/Create.cshtml", typeof(AspNetCore.Views_Authors_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e3a610bc7a540fa7be74e160b4aa371b4fb178c", @"/Views/Authors/Create.cshtml")]
    public class Views_Authors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 68, true);
            WriteLiteral("\n<h1>Add New Author:</h1>\n<p>Please fill in the following form:</p>\n");
            EndContext();
            BeginContext(124, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 9 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(156, 20, false);
#line 11 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Create.cshtml"
Write(Html.Label("Name: "));

#line default
#line hidden
            EndContext();
            BeginContext(180, 42, false);
#line 12 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Create.cshtml"
Write(Html.TextBoxFor(model => model.AuthorName));

#line default
#line hidden
            EndContext();
            BeginContext(222, 57, true);
            WriteLiteral("<br><br>\n  <input type=\"submit\" class=\"btn btn-primary\">\n");
            EndContext();
#line 14 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Create.cshtml"
}

#line default
#line hidden
            BeginContext(281, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(285, 44, false);
#line 15 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Create.cshtml"
Write(Html.ActionLink("Show All Authors", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(329, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(338, 55, false);
#line 16 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Create.cshtml"
Write(Html.ActionLink("Return to Main Page", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(393, 6, true);
            WriteLiteral("</p>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Author> Html { get; private set; }
    }
}
#pragma warning restore 1591