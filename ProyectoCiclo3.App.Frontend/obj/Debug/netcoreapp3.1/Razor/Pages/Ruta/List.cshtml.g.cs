#pragma checksum "C:\Users\10\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Ruta\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a13b8390639344aa34222b32654e6940bb331602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Ruta.Pages_Ruta_List), @"mvc.1.0.razor-page", @"/Pages/Ruta/List.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Ruta
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
#line 1 "C:\Users\10\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13b8390639344aa34222b32654e6940bb331602", @"/Pages/Ruta/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Ruta_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-hover"">
  <thead>
    <tr>
      <th scope=""col"">Id</th>
      <th scope=""col"">Origen</th>
      <th scope=""col"">Destino</th>
      <th scope=""col"">tiempo estimado</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope=""row"">1</th>
      <td>Bogota</td>
      <td>Armenia</td>
      <td>2</td>
    </tr>
    <tr>
      <th scope=""row"">2</th>
      <td>Armenia</td>
      <td>Bogota</td>
      <td>2</td>
    </tr>
    <tr>
      <th scope=""row"">3</th>
      <td>Bogota</td>
      <td>Bucaramanga</td>
      <td>4</td>
    </tr>
  </tbody>
</table>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Ruta_List> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Ruta_List> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Ruta_List>)PageContext?.ViewData;
        public Pages_Ruta_List Model => ViewData.Model;
    }
}
#pragma warning restore 1591
