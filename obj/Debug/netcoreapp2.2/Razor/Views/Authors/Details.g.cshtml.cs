#pragma checksum "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6d011c2ca18557b55b2dd2f676d169f0d12d06f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Details), @"mvc.1.0.view", @"/Views/Authors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authors/Details.cshtml", typeof(AspNetCore.Views_Authors_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d011c2ca18557b55b2dd2f676d169f0d12d06f", @"/Views/Authors/Details.cshtml")]
    public class Views_Authors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(57, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(63, 16, false);
#line 7 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Details.cshtml"
Write(Model.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(79, 17, true);
            WriteLiteral("\'s Details</h1>\n\n");
            EndContext();
#line 9 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Details.cshtml"
 if (Model.Books.Count == 0)
{

#line default
#line hidden
            BeginContext(127, 5, true);
            WriteLiteral("  <p>");
            EndContext();
            BeginContext(133, 16, false);
#line 11 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Details.cshtml"
Write(Model.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(149, 25, true);
            WriteLiteral(" has no publications</p>\n");
            EndContext();
#line 12 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Details.cshtml"
}

#line default
#line hidden
            BeginContext(176, 5, true);
            WriteLiteral("<ul>\n");
            EndContext();
#line 14 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Details.cshtml"
   foreach (var book in Model.Books)
  {

#line default
#line hidden
            BeginContext(222, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(231, 19, false);
#line 16 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Details.cshtml"
   Write(book.Book.BookTitle);

#line default
#line hidden
            EndContext();
            BeginContext(250, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 17 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(260, 10, true);
            WriteLiteral("</ul>\n\n<p>");
            EndContext();
            BeginContext(271, 72, false);
#line 20 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Details.cshtml"
Write(Html.ActionLink("Edit Author Info", "Edit", new { id = Model.AuthorId }));

#line default
#line hidden
            EndContext();
            BeginContext(343, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(352, 86, false);
#line 21 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Details.cshtml"
Write(Html.ActionLink("Delete Author from Catalogue", "Delete", new { id = Model.AuthorId }));

#line default
#line hidden
            EndContext();
            BeginContext(438, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(447, 44, false);
#line 22 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Details.cshtml"
Write(Html.ActionLink("View All Authors", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(491, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(500, 40, false);
#line 23 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Details.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(540, 4, true);
            WriteLiteral("</p>");
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
