#pragma checksum "/home/eduardo/Desktop/infoc/InfoCovid/Pages/Filters/Deaths.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c9e2dc66bdf43d3b1ef96dd6d39fd5e96b21359"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(InfoCovid.Pages.Filters.Pages_Filters_Deaths), @"mvc.1.0.razor-page", @"/Pages/Filters/Deaths.cshtml")]
namespace InfoCovid.Pages.Filters
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
#line 1 "/home/eduardo/Desktop/infoc/InfoCovid/Pages/_ViewImports.cshtml"
using InfoCovid;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c9e2dc66bdf43d3b1ef96dd6d39fd5e96b21359", @"/Pages/Filters/Deaths.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdee0a2dea7ecbacd12e51a707f16084d2873c91", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Filters_Deaths : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/eduardo/Desktop/infoc/InfoCovid/Pages/Filters/Deaths.cshtml"
  
  ViewData["Title"] = "InfoCovid";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>Óbitos</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeathsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeathsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeathsModel>)PageContext?.ViewData;
        public DeathsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
