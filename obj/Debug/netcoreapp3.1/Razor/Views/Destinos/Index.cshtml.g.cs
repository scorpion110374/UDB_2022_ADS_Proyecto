#pragma checksum "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14d1752b9abf01f9393733259d07bbb65b62d152"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destinos_Index), @"mvc.1.0.view", @"/Views/Destinos/Index.cshtml")]
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
#line 1 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\_ViewImports.cshtml"
using Proyecto_Vesa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\_ViewImports.cshtml"
using Proyecto_Vesa.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14d1752b9abf01f9393733259d07bbb65b62d152", @"/Views/Destinos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95f89f9698316dcdbde9c63a544921f4cbbe7dde", @"/Views/_ViewImports.cshtml")]
    public class Views_Destinos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/banners/banner-destinos.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Nature"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
  
    ViewData["Title"] = "Destinos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Secci??n donde va la imagen de cabecera para la p??gina -->\r\n<div class=\"container banner text-center\">\r\n    <div class=\"col-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14d1752b9abf01f9393733259d07bbb65b62d1525022", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container fondoContainer\">\r\n    <h2 class=\"text-center textColor\">DESTINOS TURISTICOS</h2>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 19 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
         foreach (var destino in ViewBag.Destinos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-12, col-md-6 col-lg-4  mb-4\">\r\n                <div class=\"card card-lugares mr-3\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 657, "\"", 699, 3);
            WriteAttributeValue("", 663, "img/destinos/", 663, 13, true);
#nullable restore
#line 23 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
WriteAttributeValue("", 676, destino.Id, 676, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 689, "/cover.jpg", 689, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 721, "\"", 744, 1);
#nullable restore
#line 23 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
WriteAttributeValue("", 727, destino.Nombre, 727, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card-body text-center\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 25 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
                                           Write(destino.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <div class=\"row justify-content-between\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 973, "\"", 1010, 2);
            WriteAttributeValue("", 980, "Destinos/Details/", 980, 17, true);
#nullable restore
#line 27 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
WriteAttributeValue("", 997, destino.Id, 997, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Ver m??s</a>\r\n                            <h5 class=\"bg-warning rounded-lg p-2\">$ ");
#nullable restore
#line 28 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
                                                                Write(destino.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <!-- Boton para abril modal -->\r\n                            <button class=\"btn btn-primary abrirModal\"");
            BeginWriteAttribute("iddestino", " iddestino=\"", 1274, "\"", 1299, 1);
#nullable restore
#line 30 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
WriteAttributeValue("", 1286, destino.Id, 1286, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("nombredestino", " nombredestino=\"", 1300, "\"", 1331, 1);
#nullable restore
#line 30 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
WriteAttributeValue("", 1316, destino.Nombre, 1316, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("precio", " precio=\"", 1332, "\"", 1356, 1);
#nullable restore
#line 30 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
WriteAttributeValue("", 1341, destino.Precio, 1341, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#myModal\">Comprar</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 35 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <!--Modal para seleccionar fecha y enviar producto a carrito-->
    <!-- Modal -->
    <div id=""myModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Seleccione Fecha:</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>Verifique y seleccione la fecha en que desea disfrutar de su paquete tur??stico. Los precios son por persona.</p>
                    <div class=""form-group border rounded-lg"">
                        <div class=""row pl-5"">
                            ");
#nullable restore
#line 52 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
                       Write(Html.Label("Iddestino", "IdDestino:", new { @class = "label font-weight-bold w-25 pt-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 53 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
                       Write(Html.TextBox("modal_IdDestino", "", new { @class = "border-0 pl-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row pl-5\">\r\n                            ");
#nullable restore
#line 56 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
                       Write(Html.Label("NombreDestino", "Destino:", new { @class = "label font-weight-bold w-25 pt-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 57 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
                       Write(Html.TextBox("modal_NombreDestino", "", new { @class = "border-0 pl-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row pl-5\">\r\n                            ");
#nullable restore
#line 60 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
                       Write(Html.Label("Precio", "Precio/Persona:", new { @class = "label font-weight-bold w-25 pt-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 61 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
                       Write(Html.TextBox("modal_Precio", "", new { @class = "border-0 pl-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 62 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
                       Write(Html.Hidden("modal_PrecioHidden"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 63 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
                       Write(Html.Hidden("fechaPaquete"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""row border rounded-lg"">
                        <div class=""col-sm-6 pt-2 border rounded-lg"">
                            <div class=""form-group"">
                                <div class='input-group datefield' id='datetimepicker1'>
                                    <input type='text' class=""form-control text-center""  id=""datepicker""/>
                                    <span class=""input-group-addon"">
                                        <span class=""glyphicon glyphicon-calendar""></span>
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-6 text-center border rounded-lg"" id=""numeroPersonas"">
                            <label>Personas que acompa??aran:</label>
                            <input required type=""number"" value=""1"" min=""1"" max=""100"" class="" borde");
            WriteLiteral(@"r rounded-lg"" id=""personas"" />
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" id=""cerrarModal"">Close</button>
                    <button class=""btn btn-primary agregarCarrito"">Enviar a Carrito</button>
                </div>
            </div>
        </div>
    </div>
    <!---->
    <div class=""paginationDiv fondoContainer pt-4"">
        ");
#nullable restore
#line 92 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Index.cshtml"
   Write(Html.PagedListPager((IPagedList)ViewBag.Destinos, page => Url.Action("Index", new { page = page }),
        new X.PagedList.Mvc.Common.PagedListRenderOptions
        {
            DisplayItemSliceAndTotal = true,
            ContainerDivClasses = new[] { "page-item" },
            LiElementClasses = new[] { "page-item" },
            PageClasses = new[] { "page-link" },
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //Corregir error en estilos de paginacion
        $(document).ready(function () {
            $('ul.pagination > li.disabled > a').addClass('page-link');

            //Activar DatePicker
            $(function () {
                $(""#datepicker"").datepicker({
                    dateFormat: 'yy-mm-dd',
                    onSelect: function(date, datepicker) {
                        if (date != """") {
                            $('#fechaPaquete').val(date);
                        }
                    }
                });
            });

        });

 
        //Verificar totales de carrito
        var carrito = JSON.parse(localStorage.getItem('listaCarritoDestinos'));
        let cuentaCarrito = 0;
        let totalCarrito = 0;

        if (carrito) {

            cuentaCarrito = carrito.length;

            for (var i = 0; i < cuentaCarrito; i++) {
                totalCarrito = totalCarrito + parseFloat(carrito[i].subTotal);
            }

     ");
                WriteLiteral(@"       $('.quantityCart').html(cuentaCarrito);
            $('#cart').addClass('backColor2');
        } else {
            $('.quantityCart').html(0);
            $('#cart').removeClass('backColor2');
        }


        //Enviar datos acampos ocultos de modal
        $('.abrirModal').on('click', function () {
            let idDestino = $(this).attr('iddestino');
            let nombreDestino = $(this).attr('nombredestino');
            let precioItem = $(this).attr('precio');

            $('.modal-body #modal_IdDestino').val(idDestino);
            $('.modal-body #modal_NombreDestino').val(nombreDestino);
            $('.modal-body #modal_Precio').val(""$ "" + precioItem);
            $('.modal-body #modal_PrecioHidden').val(precioItem);
        });

        //Agregar producto a Carrito de Compras
        $('.agregarCarrito').on('click', function () {

            if ($('#fechaPaquete').val().length == 0) {
                Swal.fire('Seleccione una fecha por favor!')
            }
 ");
                WriteLiteral(@"           else {
                // Array para carrito de compras, si existe llenara array con elementos de LocalStorage
                var name = localStorage.getItem('listaCarritoDestinos');
                var listaProductosCarrito = [];

                if (name) {
                    listaProductosCarrito = JSON.parse(localStorage.getItem('listaCarritoDestinos'));
                }

                let idDestino = $('#modal_IdDestino').val();
                let nombreDestino = $('#modal_NombreDestino').val();
                let fechaPaquete = $('#fechaPaquete').val();
                let precioItem = $('#modal_PrecioHidden').val();
                let cantProducto = $('#personas').val();
                let subTotal = parseFloat(precioItem) * parseFloat(cantProducto);

                Swal.fire({
                    title: 'Esta seguro?',
                    text: ""Esta por agregar el destino: "" + idDestino + "" / "" + nombreDestino + "" al Carrito de Compras!"",
                    ic");
                WriteLiteral(@"on: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    cancelButtonText: 'Cancelar',
                    confirmButtonText: 'S??, agregar a mi carrito!'
                }).then((result) => {
                    if (result.isConfirmed) {
                        //Agregar producto a variable
                        listaProductosCarrito.push({
                            ""id"": idDestino,
                            ""nombre"": nombreDestino,
                            ""fecha"": fechaPaquete,
                            ""precio"": precioItem,
                            ""cantidad"": cantProducto,
                            ""subTotal"": subTotal
                        })

                        //Enviar arreglo de carrito a variable de localStorage y actualizar totales de carrito
                        localStorage.setItem('listaCarritoDestinos', JSON.stringify(listaProductosC");
                WriteLiteral(@"arrito));
                        //Actualizar totales de carrito
                        $('.quantityCart').html(listaProductosCarrito.length);
                        //Cambiar color a logo
                        $('#cart').addClass('backColor2');
                        $('#cerrarModal').click();

                        Swal.fire(
                            'Agregado!',
                            'Producto agregado a carrito de compras.',
                            'success'
                        )
                    }
                })
            }
        });

        //FormatDate
        const formatDate = (date) => {
            let d = new Date(date);
            let month = (d.getMonth() + 1).toString().padStart(2, '0');
            let day = d.getDate().toString().padStart(2, '0');
            let year = d.getFullYear();
            return [year, month, day].join('-');
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
