#pragma checksum "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e61e8106b60870c187dd5dc57ebb3a4d6aa5b16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Create), @"mvc.1.0.view", @"/Views/Books/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Create.cshtml", typeof(AspNetCore.Views_Books_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e61e8106b60870c187dd5dc57ebb3a4d6aa5b16", @"/Views/Books/Create.cshtml")]
    public class Views_Books_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 66, true);
            WriteLiteral("\n<h1>Add New Book:</h1>\n<p>Please fill in the following form:</p>\n");
            EndContext();
            BeginContext(120, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 9 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(152, 26, false);
#line 11 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml"
Write(Html.Label("Book Title: "));

#line default
#line hidden
            EndContext();
            BeginContext(182, 41, false);
#line 12 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml"
Write(Html.TextBoxFor(model => model.BookTitle));

#line default
#line hidden
            EndContext();
            BeginContext(223, 9, true);
            WriteLiteral("<br><br>\n");
            EndContext();
            BeginContext(238, 26, false);
#line 14 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml"
Write(Html.Label("Book Genre: "));

#line default
#line hidden
            EndContext();
            BeginContext(268, 41, false);
#line 15 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml"
Write(Html.TextBoxFor(model => model.BookGenre));

#line default
#line hidden
            EndContext();
            BeginContext(309, 9, true);
            WriteLiteral("<br><br>\n");
            EndContext();
            BeginContext(322, 42, false);
#line 17 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml"
Write(Html.Label("Number of copies available: "));

#line default
#line hidden
            EndContext();
            BeginContext(368, 73, false);
#line 18 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml"
Write(Html.TextBoxFor(model => model.CopyCount, new { type="number", min="1" }));

#line default
#line hidden
            EndContext();
            BeginContext(441, 9, true);
            WriteLiteral("<br><br>\n");
            EndContext();
            BeginContext(454, 55, false);
#line 20 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml"
Write(Html.Label("Create a new Author to add to this book: "));

#line default
#line hidden
            EndContext();
            BeginContext(513, 26, false);
#line 21 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml"
Write(Html.TextBox("AuthorName"));

#line default
#line hidden
            EndContext();
            BeginContext(539, 9, true);
            WriteLiteral("<br><br>\n");
            EndContext();
            BeginContext(552, 20, false);
#line 23 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml"
Write(Html.Label("Author"));

#line default
#line hidden
            EndContext();
            BeginContext(576, 29, false);
#line 24 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml"
Write(Html.DropDownList("AuthorId"));

#line default
#line hidden
            EndContext();
            BeginContext(605, 9, true);
            WriteLiteral("<br><br>\n");
            EndContext();
            BeginContext(615, 48, true);
            WriteLiteral("  <input type=\"submit\" class=\"btn btn-primary\">\n");
            EndContext();
#line 27 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Books/Create.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
