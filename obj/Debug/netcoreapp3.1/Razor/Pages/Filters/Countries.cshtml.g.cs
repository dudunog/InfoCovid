#pragma checksum "/home/eduardo/Desktop/infoc/InfoCovid/Pages/Filters/Countries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a95b95a2dc07bd31dbf8300ef24e38b19fdc8e0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(InfoCovid.Pages.Filters.Pages_Filters_Countries), @"mvc.1.0.razor-page", @"/Pages/Filters/Countries.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a95b95a2dc07bd31dbf8300ef24e38b19fdc8e0b", @"/Pages/Filters/Countries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdee0a2dea7ecbacd12e51a707f16084d2873c91", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Filters_Countries : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/eduardo/Desktop/infoc/InfoCovid/Pages/Filters/Countries.cshtml"
  
  ViewData["Title"] = "InfoCovid";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>Países</h3>\n<p>Última atualização: ");
#nullable restore
#line 8 "/home/eduardo/Desktop/infoc/InfoCovid/Pages/Filters/Countries.cshtml"
                  Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
<div class=""table-responsive"">
  <table id=""CountriesTable"" class=""table table-striped table-hover table-dark"" style=""width:100%"">
    <thead class=""thead-dark"">
      <tr>
        <th scope=""col"">País</th>
        <th scope=""col"">Casos confirmados</th>
        <th scope=""col"">Casos recuperados</th>
        <th scope=""col"">Óbitos</th>
      </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "/home/eduardo/Desktop/infoc/InfoCovid/Pages/Filters/Countries.cshtml"
       foreach (var item in @Model.Countries)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n          <a href=\"/fitro/pais\"");
            BeginWriteAttribute("class", " class=\"", 596, "\"", 604, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"pais\" role=\"button\"><td>");
#nullable restore
#line 23 "/home/eduardo/Desktop/infoc/InfoCovid/Pages/Filters/Countries.cshtml"
                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></a>\n          <a href=\"/fitro/pais\"");
            BeginWriteAttribute("class", " class=\"", 687, "\"", 695, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"pais\" role=\"button\"><td>");
#nullable restore
#line 24 "/home/eduardo/Desktop/infoc/InfoCovid/Pages/Filters/Countries.cshtml"
                                                                  Write(item.TotalConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></a>\n          <a href=\"/fitro/pais\"");
            BeginWriteAttribute("class", " class=\"", 788, "\"", 796, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"pais\" role=\"button\"><td>");
#nullable restore
#line 25 "/home/eduardo/Desktop/infoc/InfoCovid/Pages/Filters/Countries.cshtml"
                                                                  Write(item.TotalRecovered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></a>\n          <a href=\"/fitro/pais\"");
            BeginWriteAttribute("class", " class=\"", 889, "\"", 897, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"pais\" role=\"button\"><td>");
#nullable restore
#line 26 "/home/eduardo/Desktop/infoc/InfoCovid/Pages/Filters/Countries.cshtml"
                                                                  Write(item.TotalDeaths);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></a>\n        </tr>\n");
#nullable restore
#line 28 "/home/eduardo/Desktop/infoc/InfoCovid/Pages/Filters/Countries.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n    <tfoot>\n    </tfoot>\n  </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CountriesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CountriesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CountriesModel>)PageContext?.ViewData;
        public CountriesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591