#pragma checksum "D:\Desktop\Drone Local Repo\DronF\Drone.App\Drone.App.Frontend\Pages\DroneViews\vistasEmpresa\infoE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "501994f0edec9fc22ecb356726be8d1ad3be961f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Drone.App.Frontend.Pages.DroneViews.vistasEmpresa.Pages_DroneViews_vistasEmpresa_infoE), @"mvc.1.0.razor-page", @"/Pages/DroneViews/vistasEmpresa/infoE.cshtml")]
namespace Drone.App.Frontend.Pages.DroneViews.vistasEmpresa
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"501994f0edec9fc22ecb356726be8d1ad3be961f", @"/Pages/DroneViews/vistasEmpresa/infoE.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247628214ce0201ef7ac88a845665cac65e1f94d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DroneViews_vistasEmpresa_infoE : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Detalles e información de encargado: ");
#nullable restore
#line 6 "D:\Desktop\Drone Local Repo\DronF\Drone.App\Drone.App.Frontend\Pages\DroneViews\vistasEmpresa\infoE.cshtml"
                                    Write(Model.Encargado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>Id ");
#nullable restore
#line 7 "D:\Desktop\Drone Local Repo\DronF\Drone.App\Drone.App.Frontend\Pages\DroneViews\vistasEmpresa\infoE.cshtml"
 Write(Model.Encargado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Ciudad: ");
#nullable restore
#line 8 "D:\Desktop\Drone Local Repo\DronF\Drone.App\Drone.App.Frontend\Pages\DroneViews\vistasEmpresa\infoE.cshtml"
      Write(Model.Encargado.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Nombre ");
#nullable restore
#line 9 "D:\Desktop\Drone Local Repo\DronF\Drone.App\Drone.App.Frontend\Pages\DroneViews\vistasEmpresa\infoE.cshtml"
     Write(Model.Encargado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Apellido ");
#nullable restore
#line 10 "D:\Desktop\Drone Local Repo\DronF\Drone.App\Drone.App.Frontend\Pages\DroneViews\vistasEmpresa\infoE.cshtml"
       Write(Model.Encargado.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Cedula: ");
#nullable restore
#line 11 "D:\Desktop\Drone Local Repo\DronF\Drone.App\Drone.App.Frontend\Pages\DroneViews\vistasEmpresa\infoE.cshtml"
      Write(Model.Encargado.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Teléfono: ");
#nullable restore
#line 12 "D:\Desktop\Drone Local Repo\DronF\Drone.App\Drone.App.Frontend\Pages\DroneViews\vistasEmpresa\infoE.cshtml"
        Write(Model.Encargado.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Correo: ");
#nullable restore
#line 13 "D:\Desktop\Drone Local Repo\DronF\Drone.App\Drone.App.Frontend\Pages\DroneViews\vistasEmpresa\infoE.cshtml"
      Write(Model.Encargado.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<a href=\"./asignarPedidos\">Atrás</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Drone.App.Frontend.Pages.infoEModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Drone.App.Frontend.Pages.infoEModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Drone.App.Frontend.Pages.infoEModel>)PageContext?.ViewData;
        public Drone.App.Frontend.Pages.infoEModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
