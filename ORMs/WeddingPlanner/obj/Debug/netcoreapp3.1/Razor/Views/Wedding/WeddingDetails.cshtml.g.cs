#pragma checksum "C:\Users\Luis\Documents\School\CSharp\ORMs\WeddingPlanner\Views\Wedding\WeddingDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23b8c42cf21a777f578f27a2dced5bc8f68ccbde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_WeddingDetails), @"mvc.1.0.view", @"/Views/Wedding/WeddingDetails.cshtml")]
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
#line 1 "C:\Users\Luis\Documents\School\CSharp\ORMs\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luis\Documents\School\CSharp\ORMs\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Luis\Documents\School\CSharp\ORMs\WeddingPlanner\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23b8c42cf21a777f578f27a2dced5bc8f68ccbde", @"/Views/Wedding/WeddingDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74b8ca08b40f37ad1199f2c8f4e56e10e34ca9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_WeddingDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1 class=\"text-center\">");
#nullable restore
#line 4 "C:\Users\Luis\Documents\School\CSharp\ORMs\WeddingPlanner\Views\Wedding\WeddingDetails.cshtml"
                       Write(Model.Couple());

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Wedding</h1>\r\n\r\n    <h3 class=\"text-center\">");
#nullable restore
#line 6 "C:\Users\Luis\Documents\School\CSharp\ORMs\WeddingPlanner\Views\Wedding\WeddingDetails.cshtml"
                       Write(Model.Date.ToString(" MMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n    <h5 class=\"text-center\">Guests:</h5>\r\n    \r\n");
#nullable restore
#line 10 "C:\Users\Luis\Documents\School\CSharp\ORMs\WeddingPlanner\Views\Wedding\WeddingDetails.cshtml"
     foreach (Rsvp rsvps in Model.Rsvps)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-center\">");
#nullable restore
#line 12 "C:\Users\Luis\Documents\School\CSharp\ORMs\WeddingPlanner\Views\Wedding\WeddingDetails.cshtml"
                          Write(rsvps.User.FullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 13 "C:\Users\Luis\Documents\School\CSharp\ORMs\WeddingPlanner\Views\Wedding\WeddingDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591
