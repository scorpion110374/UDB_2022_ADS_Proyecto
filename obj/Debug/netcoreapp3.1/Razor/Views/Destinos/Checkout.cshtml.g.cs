#pragma checksum "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd2765a4c12398a7e6475fe3eacc94b7bc7b59c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destinos_Checkout), @"mvc.1.0.view", @"/Views/Destinos/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd2765a4c12398a7e6475fe3eacc94b7bc7b59c2", @"/Views/Destinos/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95f89f9698316dcdbde9c63a544921f4cbbe7dde", @"/Views/_ViewImports.cshtml")]
    public class Views_Destinos_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Proyecto_Vesa.Models.Destino>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container px-3 my-5 clearfix bg-light rounded-lg pt-2 pb-2"">
    <div class=""text-center border border-primary rounded"">
        <h2>Formulario de Pago</h2>
    </div>
    <div class=""row"">
        <div class=""col-md-4 order-md-2 mb-4 pt-2"">
            <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                <span class=""text-muted"">Contenido Carrito</span>
                <span class=""badge badge-secondary badge-pill quantityCart"">0</span>
            </h4>
            <ul class=""list-group mb-3 sticky-top"" id=""detalleCarrito"">
                <!-- Llenado con script -->
            </ul>
        </div>
        <div class=""col-md-8 order-md-1 pt-2"">
            <h4 class=""mb-3"">Detalles de Env??o</h4>
");
#nullable restore
#line 22 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Checkout.cshtml"
             using (Html.BeginForm("Checkout", "Destinos", FormMethod.Post, new { @class = "needs-validation checkoutForm", id = "checkoutForm" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-6 mb-3\">\r\n                        <label for=\"nombre\">Nombre</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"nombre\" name=\"nombre\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1260, "\"", 1274, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1275, "\"", 1283, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 1284, "\"", 1295, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""invalid-feedback""> Nombre es un campo requerido. </div>
                    </div>
                    <div class=""col-md-6 mb-3"">
                        <label for=""apellido"">Apellido</label>
                        <input type=""text"" class=""form-control"" id=""apellido"" name=""apellido""");
            BeginWriteAttribute("value", " value=\"", 1626, "\"", 1634, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 1635, "\"", 1646, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""invalid-feedback""> Apellido es un nombre requerido. </div>
                    </div>
                </div>
                <div class=""mb-3"">
                    <label for=""email"">Email <span class=""text-muted"">(Optional)</span></label>
                    <input type=""email"" class=""form-control"" id=""email"" name=""email"" placeholder=""you@mail.com"">
                    <div class=""invalid-feedback""> Correo es un campo requerido. </div>
                </div>
                <div class=""mb-3"">
                    <label for=""direccion"">Direcci??n</label>
                    <input type=""text"" class=""form-control"" id=""direccion"" name=""direccion"" placeholder=""Col. Flor Blanca""");
            BeginWriteAttribute("required", " required=\"", 2378, "\"", 2389, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""invalid-feedback""> Direcci??n es un campo requerido. </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-6 mb-3"">
                        <label for=""direccion2"">Direcci??n 2 <span class=""text-muted"">(Optional)</span></label>
                        <input type=""text"" class=""form-control"" id=""direccion2"" name=""direccion2"" placeholder=""# de casa o apartamento"">
                    </div>
                    <div class=""col-md-6 mb-3"">
                        <label for=""telefono"">Tel??fono</label>
                        <input type=""text"" class=""form-control"" id=""telefono"" name=""telefono"" placeholder=""# de tel??fono de contacto"">
                    </div>
                </div>
");
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-5 mb-3\">\r\n                        <label for=\"pais\">Pa??s</label>\r\n                        ");
#nullable restore
#line 60 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Checkout.cshtml"
                   Write(Html.DropDownList("pais", new[] {
                            new SelectListItem(){Text="El Salvador",Value="El Salvador"}
                            }, "Seleccione Pa??s", new { @class = "form-control", required = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""invalid-feedback""> Selecciones un pa??s valido. </div>
                    </div>
                    <div class=""col-md-4 mb-3"">
                        <label for=""departamento"">Departamento</label>
                        ");
#nullable restore
#line 67 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Checkout.cshtml"
                   Write(Html.DropDownList("departamento", new[] {
                            new SelectListItem(){Text="Ahuachapan",Value="Ahuachapan"},
                            new SelectListItem(){Text="Caba??as",Value="Caba??as"},
                            new SelectListItem(){Text="Chalatenango",Value="Chalatenango"},
                            new SelectListItem(){Text="Cuscatlan",Value="Cuscatlan"},
                            new SelectListItem(){Text="La Libertad",Value="La Libertad"},
                            new SelectListItem(){Text="La Paz",Value="La Paz"},
                            new SelectListItem(){Text="La Union",Value="La Union"},
                            new SelectListItem(){Text="Morazan",Value="Morazan"},
                            new SelectListItem(){Text="San Miguel",Value="San Miguel"},
                            new SelectListItem(){Text="San Salvador",Value="San Salvador"},
                            new SelectListItem(){Text="San Vicente",Value="San Vicente"},
                            new SelectListItem(){Text="Santa Ana",Value="Santa Ana"},
                            new SelectListItem(){Text="Chalatenango",Value="Chalatenango"},
                            new SelectListItem(){Text="Sonsonate",Value="Sonsonate"}
                            }, "Seleccione Departamento", new { @class = "form-control", required = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""invalid-feedback""> Seleccione un departamento valido. </div>
                    </div>
                    <div class=""col-md-3 mb-3"">
                        <label for=""codpostal"">C??digo Postal</label>
                        <input type=""text"" class=""form-control"" id=""codpostal"" name=""codpostal""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 5549, "\"", 5563, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
                <hr class=""mb-1"">
                <!-- Section oculta para uso futuro
        <section class=""d-none"">
            <div class=""custom-control custom-checkbox"">
                <input type=""checkbox"" class=""custom-control-input"" id=""same-address"">
                <label class=""custom-control-label"" for=""same-address"">Shipping address is the same as my billing address</label>
            </div>
            <div class=""custom-control custom-checkbox"">
                <input type=""checkbox"" class=""custom-control-input"" id=""save-info"">
                <label class=""custom-control-label"" for=""save-info"">Save this information for next time</label>
            </div>
        </section>
        -->
                <h4 class=""mt-2"">Tipo de Pago</h4>
                <div class=""d-block my-3"">
                    <div class=""custom-control custom-radio"">
                        <input id=""cash"" name=""paymentMethod"" type=""radio"" class=""");
            WriteLiteral("custom-control-input\" value=\"cash\"");
            BeginWriteAttribute("checked", " checked=\"", 6622, "\"", 6632, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 6633, "\"", 6644, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <label class=""custom-control-label pt-2"" for=""cash"">Efectivo</label>
                    </div>
                    <div class=""custom-control custom-radio"">
                        <input id=""credit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" value=""credit""");
            BeginWriteAttribute("required", " required=\"", 6953, "\"", 6964, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <label class=""custom-control-label pt-2"" for=""credit"">Tarjeta de Cr??dito</label>
                    </div>
                    <div class=""custom-control custom-radio"">
                        <input id=""debit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" value=""debit""");
            BeginWriteAttribute("required", " required=\"", 7283, "\"", 7294, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <label class=""custom-control-label pt-2"" for=""debit"">Tarjeta de D??bito</label>
                    </div>
                </div>
                <section class=""d-none"" id=""datosTarjeta"">
                    <div class=""row"">
                        <div class=""col-md-6 mb-3"">
                            <label for=""Cc_name"">Nombre en Tarjeta</label>
                            <input type=""text"" class=""form-control reqTarjeta"" id=""Cc_name"" name=""Cc_name"" placeholder=""Nombre completo seg??n tarjeta"">
                            <div class=""invalid-feedback""> Nombre en tarjeta es requerido. </div>
                        </div>
                        <div class=""col-md-6 mb-3"">
                            <label for=""Cc_number"">N??mero de tarjeta</label>
                            <input type=""text"" class=""form-control reqTarjeta"" id=""Cc_number"" name=""Cc_number""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 8207, "\"", 8221, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""invalid-feedback"">N??mero de tarjeta es requerido </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-3 mb-3"">
                            <label for=""Cc_expiration"">Fecha de Expiraci??n</label>
                            <input type=""text"" class=""form-control reqTarjeta"" id=""Cc_expiration"" name=""Cc_expiration""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 8676, "\"", 8690, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""invalid-feedback""> Fecha de Expiraci??n es requerida. </div>
                        </div>
                        <div class=""col-md-3 mb-3"">
                            <label for=""Cc_cvv"">CVV</label>
                            <input type=""text"" class=""form-control reqTarjeta"" id=""Cc_cvv"" name=""Cc_cvv""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 9045, "\"", 9059, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"invalid-feedback\"> C??digo de Seguridad es requerido. </div>\r\n                        </div>\r\n                    </div>\r\n                </section>\r\n");
#nullable restore
#line 144 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Checkout.cshtml"
           Write(Html.Hidden("detalleCarrito", "", new { id = "detalleCarrito" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Checkout.cshtml"
           Write(Html.Hidden("Fecha", @DateTime.Now, new { id = "Fecha" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Checkout.cshtml"
           Write(Html.Hidden("IdUsuario", @ViewBag.UserId, new { id = "IdUsuario" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Checkout.cshtml"
           Write(Html.Hidden("Valor", "", new { id = "Valor" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Checkout.cshtml"
           Write(Html.Hidden("listadoProductos", "", new { id = "listadoProductos" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-success btn-lg btn-block\" type=\"submit\">Efectuar Compra</button>\r\n");
#nullable restore
#line 151 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\ADS901\ProyectoCatedra_Fase2\Proyecto_Vesa\Views\Destinos\Checkout.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //Cargar datos de Carrito
        var carrito = JSON.parse(localStorage.getItem('listaCarritoDestinos'));
        let cuentaCarrito = 0;
        let totalCarrito = 0;

        if (carrito) {

            cuentaCarrito = carrito.length;

            for (var i = 0; i < cuentaCarrito; i++) {
                totalCarrito = totalCarrito + parseFloat(carrito[i].subTotal);

                //Llenar tabla de detalle
                $('#detalleCarrito').append(
                    '<li class=""list-group-item d-flex justify-content-between lh-condensed"">' +
                    '<div>' +
                    '<h6 class=""my-0"">' + carrito[i].id + '</h6>' +
                    '<small class=""text-muted"">' + carrito[i].nombre + '</small>' +
                    '</div>' +
                    '<span class=""text-muted"">$ ' + carrito[i].subTotal + '</span>' +
                    '</li>'
                );
            }

            //Agregar Total
            $('#detalleCarrito'");
                WriteLiteral(@").append(
                '<li class=""list-group-item d-flex justify-content-between"">' +
                '<span>Total (USD)</span>' +
                '<strong>$ ' + totalCarrito + '</strong>' +
                '</li>'
            );

            //Actualizar total carrito
            $('.totalCarrito').html(""$ "" + totalCarrito);
            $('.quantityCart').html(cuentaCarrito);
            $('#cart').addClass('backColor2');

            //Enviar lista de productos de carrito a input hidden
            $(""#listadoProductos"").val(localStorage.getItem('listaCarritoDestinos'));
            $('#Valor').val(totalCarrito);
        } else {
            $('.quantityCart').html(0);
            $('.sumCart').html(""$ 0.00"");
        }


        //remover item del carrito de compras
        $('.removerItem').on('click', function () {

            let itemBorrar = $(this).data('id');

            Swal.fire({
                title: 'Esta seguro?',
                text: ""Esta seguro de querer b");
                WriteLiteral(@"orrar este art??culo?"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                cancelButtonText: 'Cancelar',
                confirmButtonText: 'S??, remover art??culo de mi carrito de compras!'
            }).then((result) => {
                if (result.isConfirmed) {
                    //Eliminar art??culo
                    for (var i = 0; i < carrito.length; i++) {
                        if (i === itemBorrar) {
                            carrito.splice(i, 1);
                        }
                    }

                    //Actualizar localStorage con array actualizado
                    localStorage.setItem('listaCarrito', JSON.stringify(carrito));

                    //Recargar pagina carrito
                    location.reload();
                }
            })
        });

        //Borrar carrito de compras
        function borrarCarrito() {
 ");
                WriteLiteral(@"           Swal.fire({
                title: 'Esta seguro?',
                text: ""Esta seguro de borrar todo el contenido del Carrito de Compras!"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                cancelButtonText: 'Cancelar',
                confirmButtonText: 'S??, borrar contenido de carrito!'
            }).then((result) => {
                if (result.isConfirmed) {
                    //Eliminar localStorage
                    localStorage.removeItem('listaCarrito');

                    Swal.fire(
                        'Borrado!',
                        'Contenido de Carrito de Compras eliminado!',
                        'success'
                    )

                    window.location.href = '/productos';
                }
            })
        };


        //Detectar forma de pago
        $('input[name=paymentMethod]').on('click', func");
                WriteLiteral(@"tion () {
            var checked_paymentMethod = document.querySelector('input[name = ""paymentMethod""]:checked');

            if (checked_paymentMethod != null) {  //Test if something was checked
                if (checked_paymentMethod.value == ""credit"" || checked_paymentMethod.value == ""debit"") {
                    $('#datosTarjeta').removeClass('d-none');
                    $('.reqTarjeta').prop('required',true);
                } else {
                    $('#datosTarjeta').addClass('d-none');
                    $('.reqTarjeta').removeAttr('required');
                }
            } else {
                alert('Nothing checked'); //Alert, nothing was checked.
            }
        });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Proyecto_Vesa.Models.Destino>> Html { get; private set; }
    }
}
#pragma warning restore 1591
