#pragma checksum "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ee749f756203197b3ef8f4ed86ab99eaa25e316"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Afiliados_Index), @"mvc.1.0.view", @"/Views/Afiliados/Index.cshtml")]
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
#line 1 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\_ViewImports.cshtml"
using Prueba_Tecnica_ARS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\_ViewImports.cshtml"
using Prueba_Tecnica_ARS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee749f756203197b3ef8f4ed86ab99eaa25e316", @"/Views/Afiliados/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49397adcfcf7b6c82a4a96288b5c71fbb0bf6f7e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Afiliados_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Afiliados>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link btn btn-primary text-white w-25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Afiliados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearAfiliado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link btn btn-primary text-white w-25 mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActualizarMontoConsumido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white btn-success p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white btn-danger p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
  
    List<Planes> Planes = ViewData["Planes"] as List<Planes>;
    List<Estatus> Estatus = ViewData["Estatus"] as List<Estatus>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section>\r\n    <header>\r\n        <h1 class=\"text-center\">Mantenimiento Afiliados</h1>\r\n\r\n        <div class=\"d-flex flex-column align-items-end\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee749f756203197b3ef8f4ed86ab99eaa25e3166631", async() => {
                WriteLiteral("\r\n                Crear Afiliado\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee749f756203197b3ef8f4ed86ab99eaa25e3168331", async() => {
                WriteLiteral("\r\n                Actualizar Monto\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </header>

    <table class=""table table-dark mt-4 pt-2"">
        <thead>
            <tr>
                <td>Id</td>
                <td>Nombre </td>
                <td>Apellido</td>
                <td>Fecha de Nacimiento</td>
                <td>Sexo</td>
                <td>Cedula</td>
                <td>Numero de Seguridad Social</td>
                <td>Fecha de Registro</td>
                <td>Monto Consumido</td>
                <td>Monto Cobertura</td>
                <td>Monto Restante</td>
                <td>Estatus</td>
                <td>Plan</td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 47 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
             foreach (Afiliados afiliado in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
               Write(afiliado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
               Write(afiliado.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
               Write(afiliado.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
               Write(afiliado.Fecha_Nacimiento.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
               Write(afiliado.Sexo.ToString().ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
               Write(afiliado.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
               Write(afiliado.Numero_Seguridad_Social);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
               Write(afiliado.Fecha_Registro.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>$");
#nullable restore
#line 58 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
                Write(afiliado.Monto_Consumido);

#line default
#line hidden
#nullable disable
            WriteLiteral(" RD$</td>\r\n                <td>");
#nullable restore
#line 59 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
               Write(Planes.Find(p => p.Id == afiliado.Id_Plan).Monto_Cobertura);

#line default
#line hidden
#nullable disable
            WriteLiteral(" RD$</td>\r\n                <td>");
#nullable restore
#line 60 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
                Write(Planes.Find(p => p.Id == afiliado.Id_Plan).Monto_Cobertura - afiliado.Monto_Consumido );

#line default
#line hidden
#nullable disable
            WriteLiteral("RD$ </td>\r\n\r\n                <td>");
#nullable restore
#line 62 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
               Write(Estatus.Find(e => e.Id == afiliado.Id_Estatus).Estatus_Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 63 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
               Write(Planes.Find(x => x.Id == afiliado.Id_Plan).Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee749f756203197b3ef8f4ed86ab99eaa25e31615134", async() => {
                WriteLiteral("\r\n                        Actualizar\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2463, "~/Afiliados/ActualizarAfiliado?idAfiliado=", 2463, 42, true);
#nullable restore
#line 66 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
AddHtmlAttributeValue("", 2505, afiliado.Id, 2505, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n");
#nullable restore
#line 73 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
                     if (afiliado.Id_Estatus == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee749f756203197b3ef8f4ed86ab99eaa25e31617224", async() => {
                WriteLiteral("\r\n                            Inactivar\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2797, "~/Afiliados/SwitchActivarAfiliado?idAfiliado=", 2797, 45, true);
#nullable restore
#line 75 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
AddHtmlAttributeValue("", 2842, afiliado.Id, 2842, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee749f756203197b3ef8f4ed86ab99eaa25e31619268", async() => {
                WriteLiteral("\r\n                            Activar\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3066, "~/Afiliados/SwitchActivarAfiliado?idAfiliado=", 3066, 45, true);
#nullable restore
#line 81 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
AddHtmlAttributeValue("", 3111, afiliado.Id, 3111, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 84 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 87 "C:\Users\jminaya\Desktop\ARS_Prueba\Prueba_Tecnica_ARS\Prueba_Tecnica_ARS\Views\Afiliados\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Afiliados>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591