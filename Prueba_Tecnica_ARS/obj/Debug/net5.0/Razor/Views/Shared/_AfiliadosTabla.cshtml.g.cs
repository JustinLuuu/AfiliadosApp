#pragma checksum "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b0494171956798b03e01e4cc37debeb8aa0a525"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AfiliadosTabla), @"mvc.1.0.view", @"/Views/Shared/_AfiliadosTabla.cshtml")]
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
#line 1 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\_ViewImports.cshtml"
using Prueba_Tecnica_ARS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\_ViewImports.cshtml"
using Prueba_Tecnica_ARS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0494171956798b03e01e4cc37debeb8aa0a525", @"/Views/Shared/_AfiliadosTabla.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49397adcfcf7b6c82a4a96288b5c71fbb0bf6f7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AfiliadosTabla : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Afiliados>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white btn-success p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white btn-danger p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
  
    List<Planes> Planes = ViewData["Planes"] as List<Planes>;
    List<Estatus> Estatus = ViewData["Estatus"] as List<Estatus>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table table-dark mt-4"">
    <thead>
        <tr>
            <td>Id</td>
            <td>Nombre </td>
            <td>Apellido</td>
            <td>Fecha de Nacimiento</td>
            <td>Sexo</td>
            <td>Cedula</td>
            <td>Monto Consumido</td>
            <td>Monto Cobertura</td>
            <td>Monto Restante</td>
            <td>Estatus</td>
            <td>Plan</td>
            <td></td>
            <td></td>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 29 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
         foreach (Afiliados afiliado in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
               Write(afiliado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
               Write(afiliado.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
               Write(afiliado.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
               Write(afiliado.Fecha_Nacimiento.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
               Write(afiliado.Sexo.ToString().ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
               Write(afiliado.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>$");
#nullable restore
#line 38 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
                Write(afiliado.Monto_Consumido);

#line default
#line hidden
#nullable disable
            WriteLiteral(" RD$</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
               Write(Planes.Find(p => p.Id == afiliado.Id_Plan).Monto_Cobertura);

#line default
#line hidden
#nullable disable
            WriteLiteral(" RD$</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
                Write(Planes.Find(p => p.Id == afiliado.Id_Plan).Monto_Cobertura - afiliado.Monto_Consumido );

#line default
#line hidden
#nullable disable
            WriteLiteral("RD$ </td>\r\n\r\n                <td>");
#nullable restore
#line 42 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
               Write(Estatus.Find(e => e.Id == afiliado.Id_Estatus).Estatus_Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
               Write(Planes.Find(x => x.Id == afiliado.Id_Plan).Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b0494171956798b03e01e4cc37debeb8aa0a5258770", async() => {
                WriteLiteral("\r\n                        Actualizar\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1552, "~/Afiliados/ActualizarAfiliado?idAfiliado=", 1552, 42, true);
#nullable restore
#line 46 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
AddHtmlAttributeValue("", 1594, afiliado.Id, 1594, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n");
#nullable restore
#line 53 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
                     if (afiliado.Id_Estatus == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b0494171956798b03e01e4cc37debeb8aa0a52510887", async() => {
                WriteLiteral("\r\n                            Inactivar\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1887, "~/Afiliados/CambiarEstatusAfiliado?idAfiliado=", 1887, 46, true);
#nullable restore
#line 55 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
AddHtmlAttributeValue("", 1933, afiliado.Id, 1933, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b0494171956798b03e01e4cc37debeb8aa0a52512960", async() => {
                WriteLiteral("\r\n                            Activar\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2157, "~/Afiliados/CambiarEstatusAfiliado?idAfiliado=", 2157, 46, true);
#nullable restore
#line 61 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
AddHtmlAttributeValue("", 2203, afiliado.Id, 2203, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\justi\OneDrive\Escritorio\Nueva carpeta\AfiliadosApp\Prueba_Tecnica_ARS\Views\Shared\_AfiliadosTabla.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Afiliados>> Html { get; private set; }
    }
}
#pragma warning restore 1591
