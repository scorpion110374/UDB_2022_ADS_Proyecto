#pragma checksum "C:\Users\Eduardo Trujillo\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fd2957c95163a3d429b1ae890fd9d43517af28b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Eduardo Trujillo\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\_ViewImports.cshtml"
using Proyecto_Vesa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eduardo Trujillo\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\_ViewImports.cshtml"
using Proyecto_Vesa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd2957c95163a3d429b1ae890fd9d43517af28b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95f89f9698316dcdbde9c63a544921f4cbbe7dde", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Eduardo Trujillo\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 7 "C:\Users\Eduardo Trujillo\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Home\Index.cshtml"
         foreach (var item in ViewBag.Banner)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 9 "C:\Users\Eduardo Trujillo\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Home\Index.cshtml"
                                                                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\"></li>\r\n");
#nullable restore
#line 10 "C:\Users\Eduardo Trujillo\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ol>\r\n    <div class=\"carousel-inner text-center\">\r\n");
#nullable restore
#line 14 "C:\Users\Eduardo Trujillo\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Home\Index.cshtml"
         foreach (var item in ViewBag.Banner)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 467, "\"", 518, 3);
            WriteAttributeValue("", 475, "carousel-item", 475, 13, true);
#nullable restore
#line 16 "C:\Users\Eduardo Trujillo\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 488, item == 1 ? "active" : "", 489, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 517, "", 518, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2fd2957c95163a3d429b1ae890fd9d43517af28b6158", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 570, "~/img/carrusel/", 570, 15, true);
#nullable restore
#line 17 "C:\Users\Eduardo Trujillo\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 585, item, 585, 7, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 592, ".jpg", 592, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\Eduardo Trujillo\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>
<h2 class=""text-center textColor pt-3"">CONOZCAMOS JUNTOS EL SALVADOR</h2>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //Verificar totales de carrito
        var carrito = JSON.parse(localStorage.getItem('listaCarritoDestinos'));
        let cuentaCarrito = 0;
        let totalCarrito = 0;

        if (carrito) {

            cuentaCarrito = carrito.length;

            for (var i = 0; i < cuentaCarrito; i++) {
                totalCarrito = totalCarrito + parseFloat(carrito[i].subTotal);
            }

            $('.quantityCart').html(cuentaCarrito);
            $('#cart').addClass('backColor2');
        } else {
            $('.quantityCart').html(0);
            $('#cart').removeClass('backColor2');
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
