#pragma checksum "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\Consultar\Consultar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b0bd0c13c69ee77e3bcdb7b3aec68447fc437eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Mascota.Consultar.Pages_Mascota_Consultar_Consultar), @"mvc.1.0.razor-page", @"/Pages/Mascota/Consultar/Consultar.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Mascota.Consultar
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
#line 1 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/consultarMascotas")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0bd0c13c69ee77e3bcdb7b3aec68447fc437eb", @"/Pages/Mascota/Consultar/Consultar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mascota_Consultar_Consultar : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row gy-2 gx-3 align-items-end clss-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\Consultar\Consultar.cshtml"
  
  ViewData["Title"] = "Consultar Mascostas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Consultar", async() => {
                WriteLiteral(@"
<div id=""consultar"" class=""container py-3 mt-3 animate__animated animate__fadeIn"">
  <div class=""p-3 pb-md-4 mx-auto border-bottom"">
    <h3 class=""fw-bolder mb-0  text-center"">Consultar Mascotas</h3>
    <p class=""fs-6 lead  text-center"">En esta sección podrás consultar la información de las mascostas</p>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b0bd0c13c69ee77e3bcdb7b3aec68447fc437eb4354", async() => {
                    WriteLiteral(@"
      <div class=""col"">
        <label for=""propietario"" class=""form-label mb-0"">Propietario</label>
        <input type=""text"" class=""form-control"" id=""propietario"" placeholder=""Ingresar Propietario"">
        <div class=""invalid-feedback"">
          Se requiere un Propietario.
        </div>
      </div>

      <div class=""col"">
        <label for=""nombre"" class=""form-label mb-0"">Mascota</label>
        <input type=""text"" class=""form-control"" id=""nombre"" placeholder=""Ingresar nombre de mascota"" required>
        <div class=""invalid-feedback"">
          Se requiere un nombre válido.
        </div>
      </div>

      <div class=""col"">
        <label for=""veterinario"" class=""form-label mb-0"">Veterinario</label>
        <input type=""text"" class=""form-control"" id=""especie"" placeholder=""Ingresar veterinario"" required>
        <div class=""invalid-feedback"">
          Se requiere que ingrese veterinario.
        </div>
      </div>
      <button class=""col btn btn-primary py-2"" type=""submit");
                    WriteLiteral("\">Consultar</button>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
  </div>
  <main>
    <div class=""table-responsive mt-3"">
      <table class=""table table-striped"">
        <thead>
          <tr>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Especie</th>
            <th scope=""col"">Color</th>
            <th scope=""col"">Raza</th>
            <th scope=""col"">Propietario</th>
            <th scope=""col"">Veterinario</th>
          </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 55 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\Consultar\Consultar.cshtml"
           foreach (var propietario in Model.propietarios)
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("          <tr>\r\n            <td>");
#nullable restore
#line 58 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\Consultar\Consultar.cshtml"
           Write(propietario.Nombres);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 59 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\Consultar\Consultar.cshtml"
           Write(propietario.Apellidos);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 60 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\Consultar\Consultar.cshtml"
           Write(propietario.Direccion);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 61 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\Consultar\Consultar.cshtml"
           Write(propietario.Telefono);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 62 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\Consultar\Consultar.cshtml"
           Write(propietario.Correo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>Jorge Uribe Petro</td>\r\n          </tr>\r\n");
#nullable restore
#line 65 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\Consultar\Consultar.cshtml"
          }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </tbody>\r\n      </table>\r\n    </div>\r\n  </main>\r\n\r\n</div>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.ConsultarModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ConsultarModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ConsultarModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.ConsultarModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591