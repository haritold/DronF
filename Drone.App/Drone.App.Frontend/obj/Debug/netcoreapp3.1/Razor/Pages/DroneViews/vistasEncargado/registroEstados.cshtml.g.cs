#pragma checksum "D:\Desktop\Drone Local Repo\DronF\Drone.App\Drone.App.Frontend\Pages\DroneViews\vistasEncargado\registroEstados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f7ca416261301a0497155cbb68d5d16c54702a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Drone.App.Frontend.Pages.DroneViews.vistasEncargado.Pages_DroneViews_vistasEncargado_registroEstados), @"mvc.1.0.razor-page", @"/Pages/DroneViews/vistasEncargado/registroEstados.cshtml")]
namespace Drone.App.Frontend.Pages.DroneViews.vistasEncargado
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
#line 1 "D:\Desktop\Drone Local Repo\DronF\Drone.App\Drone.App.Frontend\Pages\_ViewImports.cshtml"
using Drone.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f7ca416261301a0497155cbb68d5d16c54702a5", @"/Pages/DroneViews/vistasEncargado/registroEstados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247628214ce0201ef7ac88a845665cac65e1f94d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DroneViews_vistasEncargado_registroEstados : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
            WriteLiteral("\r\n <div class=\"row\">\r\n\r\n            <div class=\"col-md-4 \" >\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f7ca416261301a0497155cbb68d5d16c54702a53376", async() => {
                WriteLiteral(@"

                    <p><i>ID pedido: </i></p>

                    <div class=""mb-3 form-group"">
                      <label for=""exampleInputEmail1"">Fecha y Hora</label>
                      <input type=""email"" class=""form-control"" placeholder=""0000-00-00 00:00:00"">
                    </div>
                    <div class=""mb-3 form-group"">
                      <label for=""exampleInputPassword1"">Ubicación</label>
                      <input type=""password"" class=""form-control"">
                    </div>
                    <div class=""mb-3 form-group"">
                        <label for=""exampleInputPassword1"">Temperatura</label>
                        <input type=""password"" class=""form-control"">
                    </div>
                    <div class=""mb-3 form-group"">
                        <label for=""exampleInputPassword1"">Tiempo faltante</label>
                        <input type=""password"" class=""form-control"">
                    </div>
    
                    <butto");
                WriteLiteral("n type=\"submit\" class=\"myButton btn btn-primary\">Actualizar</button>\r\n                  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n            ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Drone.App.Frontend.Pages.registroEstadosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Drone.App.Frontend.Pages.registroEstadosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Drone.App.Frontend.Pages.registroEstadosModel>)PageContext?.ViewData;
        public Drone.App.Frontend.Pages.registroEstadosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591