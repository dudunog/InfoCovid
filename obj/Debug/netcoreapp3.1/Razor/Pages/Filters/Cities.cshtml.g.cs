#pragma checksum "/home/eduardo/Documentos/git-projects/InfoCovid/InfoCovid/Pages/Filters/Cities.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f32784a1b6a4ce4d4d0f690456565432df8718d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(InfoCovid.Pages.Filters.Pages_Filters_Cities), @"mvc.1.0.razor-page", @"/Pages/Filters/Cities.cshtml")]
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
#line 1 "/home/eduardo/Documentos/git-projects/InfoCovid/InfoCovid/Pages/_ViewImports.cshtml"
using InfoCovid;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f32784a1b6a4ce4d4d0f690456565432df8718d7", @"/Pages/Filters/Cities.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdee0a2dea7ecbacd12e51a707f16084d2873c91", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Filters_Cities : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/eduardo/Documentos/git-projects/InfoCovid/InfoCovid/Pages/Filters/Cities.cshtml"
  
  ViewData["Title"] = "InfoCovid";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>Países</h3>\n\n<div class=\"card-group\">\n");
#nullable restore
#line 10 "/home/eduardo/Documentos/git-projects/InfoCovid/InfoCovid/Pages/Filters/Cities.cshtml"
   foreach (var item in Model.Countries)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-xxl-3 col-lg-3"">
      <div class=""card mb-4"" style=""background-color: #2E3140;"">
        <div class=""card-body"">
          <div class=""d-flex justify-content-between"">
            <div class=""mr-3"">
              <div class=""text-white"">");
#nullable restore
#line 17 "/home/eduardo/Documentos/git-projects/InfoCovid/InfoCovid/Pages/Filters/Cities.cshtml"
                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n              <div class=\"text-lg text-white font-bold\">");
#nullable restore
#line 18 "/home/eduardo/Documentos/git-projects/InfoCovid/InfoCovid/Pages/Filters/Cities.cshtml"
                                                   Write(item.TotalDeaths);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            </div>\n          </div>\n        </div>\n        <div class=\"card-footer d-flex justify-content-between\">\n          <a class=\"small text-white stretched-link\" href=\"#\">View Report</a>\n        </div>\n      </div>\n    </div>\n");
#nullable restore
#line 27 "/home/eduardo/Documentos/git-projects/InfoCovid/InfoCovid/Pages/Filters/Cities.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CitiesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CitiesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CitiesModel>)PageContext?.ViewData;
        public CitiesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
