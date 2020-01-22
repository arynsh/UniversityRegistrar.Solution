#pragma checksum "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0abea61b6f18fb06c22f809e4ea09e8912b90de1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Index.cshtml", typeof(AspNetCore.Views_Students_Index))]
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
#line 1 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Index.cshtml"
using University.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0abea61b6f18fb06c22f809e4ea09e8912b90de1", @"/Views/Students/Index.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(55, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(102, 23, true);
            WriteLiteral("    <h4>Students</h4>\n\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(150, 46, true);
            WriteLiteral("    <h3>No students have been added yet.</h3>\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Index.cshtml"
}

#line default
#line hidden
            BeginContext(198, 5, true);
            WriteLiteral("<ul>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Index.cshtml"
     foreach (Student student in Model)
    {

#line default
#line hidden
            BeginContext(249, 21, true);
            WriteLiteral("        <li>\n        ");
            EndContext();
            BeginContext(271, 76, false);
#line 17 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Index.cshtml"
   Write(Html.ActionLink($"{student.Name}", "Details", new { id = student.StudentId}));

#line default
#line hidden
            EndContext();
            BeginContext(347, 15, true);
            WriteLiteral("\n        </li>\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(368, 10, true);
            WriteLiteral("</ul>\n\n<p>");
            EndContext();
            BeginContext(379, 46, false);
#line 22 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Index.cshtml"
Write(Html.ActionLink("Add a new student", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(425, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(434, 40, false);
#line 23 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(474, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591