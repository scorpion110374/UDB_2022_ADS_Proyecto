using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Vesa.Migrations.ProjectDb
{
    public partial class ActualizacionDatosTablaDestinos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DireccionMapa",
                table: "Destinos",
                type: "varchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cover",
                value: "img/destinos/cover.jpg");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cover",
                value: "img/destinos/cover.jpg");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cover",
                value: "img/destinos/cover.jpg");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Cover",
                value: "img/destinos/cover.jpg");

            migrationBuilder.InsertData(
                table: "Destinos",
                columns: new[] { "Id", "Activo", "Calificacion", "Cover", "Descripcion", "DireccionMapa", "Fecha", "Nombre", "Puntuacón", "Ubicacion" },
                values: new object[,]
                {
                    { 5, true, 0, "img/destinos/cover.jpg", "Joya de Cerén es un sitio precolombino de El Salvador situado en las proximidades de San Juan Opico y Las Flores, en la región centroccidental de El Salvador. Estuvo habitado al menos desde el año 400 por un pueblo agrícola tributario de San Andrés y fue abandonado alrededor del año 600 a causa de la erupción de la Laguna Caldera. El sitio permite apreciar la vida cotidiana de un pueblo maya agricultor de hace 1400 años (siglo VII), el único conocido en El Salvador.Es uno de los sitios arqueológicos más importantes de Mesoamérica porque muestra cómo era la vida de la gente común y corriente.Por eso se le llama a menudo la Pompeya de América, en comparación con el sitio arqueológico de Pompeya, localizado en Italia.En 1993, Joya de Cerén fue declarada patrimonio de la humanidad por la Unesco.​", "https://www.google.com/maps/place/Joya+de+Ceren/@13.821297,-89.3642815,16z/data=!3m1!4b1!4m5!3m4!1s0x8f63212ab199a6dd:0x51207fe999d8c593!8m2!3d13.8222445!4d-89.3594449", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sitio Arqueológico Joya de Cerén", 0, "El sitio arqueológico Joya de Cerén se ubica al sur del actual caserío con el mismo nombre en el municipio de San Juan Opico, La Libertad." },
                    { 6, true, 0, "img/destinos/cover.jpg", "El Pital es la cima más alta y elevada de El Salvador y la tercera cima más alta de Honduras. Tiene una elevación de 2,730 metros sobre el nivel del mar. Además de clima fresco, El Pital tiene un bosque húmedo conformado por árboles como pino, roble, encino y ciprés.La parte más alta de este cerro se denomina Horqueta y es de gran atractivo turístico ya que es el lugar donde El Salvador colinda con Honduras.Es un pico montañoso de impresionantes laderas escarpadas.Su área total, incluyendo la zona de amortiguamiento, se estima en 38 kilómetros.A El Pital acuden muchas personas con deseos de realizar ecoturismo, como: camping, observación de fauna y flora y caminatas por los diferentes senderos.Considerado, por las personas que gustan del clima frío, uno de los mejores lugares para sentir temperaturas bajas.La zona para acampar se encuentra a unos 2730 msnm aproximadamente, específicamente entre los dos picos de la montaña, por lo que se forma un corredor de viento en ese lugar.En ese sector de la montaña la temperatura es 10 °C menos que los lugares aledaños, aunque estos estén a pocos metros.Su vegetación está poblada de coníferas y encinos.Otras especies incluyen el Pino Blanco, Pinabete y varias especies de robles, plantas casi extintas para el país salvadoreño y únicas de esa zona.​", "https://goo.gl/maps/3mWWyFfZAYUPvPQs7", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cerro El Pital", 0, "El cerro El Pital es una montaña transnacional, ubicada exactamente en la frontera entre El Salvador (Chalatenango) y Honduras." },
                    { 7, true, 0, "img/destinos/cover.jpg", "Si se trata de hacer turismo en El Salvador, la ciudad capital, es una parada obligatoria. Aquí podrás encontrar la mejor oferta de paquetes turísticos en El Salvador, la mayor oferta hotelera, varios centros comerciales, restaurantes y museos.Entre los lugares de San Salvador que puedes visitar destacan el Palacio Nacional, la Plaza Gerardo Barrios, la Catedral Metropolitana, El Museo de Arte, uno de los más importantes del país y la Plaza Futura que ofrece un ambiente activo por la noche con sus terrazas y cafés.Asimismo hay muchos lugares con un enfoque natural, los cuales están cerca de la ciudad.Ejemplo de ello es Parque Nacional El Boquerón Este no te lo puedes perder.Si eres un aventurero, lo podrás visitar, se encuentra en el cráter del volcán y cuenta con miradores, senderos, vistas impresionantes, amplia fauna y flora.No te preocupes si eres menos aventurero, te recomiendo conocer el Boquerón de igual manera ya que queda bastante cerca de la ciudad, es seguro y sus vistas son impresionantes.​", "https://goo.gl/maps/nemAfyZviVMduG9Y7", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Salvador", 0, "Capital de El Salvador" },
                    { 8, true, 0, "img/destinos/cover.jpg", "Tazumal comprende una serie de estructuras que fueron el escenario de un importante y sofisticado asentamiento maya q ue existió alrededor de los años 100 - 1200 DC. Los restos incluyen sistemas de drenaje de aguas, tumbas, pirámides y templos. Su mayor desarrollo corresponde al horizonte Clásico (250 a 900 d. C.). Desde el 900 D.C. Alrededor del año 1,200 D.C. fue abandonado definitivamente.Su mayor estructura mide 24 metros de altura, cuenta con doce escalones o plataformas y en ella se encontraron tumbas con más de 116 vasijas, joyería de jade, “espejos” de pirita de hierro, artefactos de juego de pelota y cerámica con forma de lagartos.En Tazumal se halla también la piedra de las victorias, que consiste en un monolito de influencia Olmeca que presenta cuatro petrograbados distintos en sus cuatro lados, fechado en 700 a.C., aproximadamente.Entre los hallazgos más importantes de Tazumal se encuentra la Virgen de Tazumal, que fue encontrada en 1892 por el historiador Santiago Barberena, quien la trasladó al Museo Nacional; y el llamado Chac-Mool, el cual fue encontrado en la ahora nombrada Laguna Seca de Chalchuapa.El sitio Tazumal es ineludible destino para los amantes de la arqueología. Cuenta con un museo y guías locales.El Museo Stanley Boggs describe la secuencia habitacional de las culturas prehispánicas de los períodos Preclásico, Clásico y Postclásico, y presenta los diferentes sitios que conforman el área arqueológica de Chalchuapa, como son: El Trapiche, Laguna Cuscachapa, Las Victorias, Casa Blanca, Laguna Seca, y Grupo Peñate​", "https://goo.gl/maps/icgJCvJyobD286ka8", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sitio Arqueológico El Tazumal", 0, "Está ubicado en el corazón de Chalchuapa, departamento de Santa Ana, a 80 kilómetros al occidente de la capital. Esta zona está dentro de un área arqueológica de aproximadamente 10 km² en donde también se localizan los sitios de Pampe, Casa Blanca, El Trapiche y Las Victorias.Chalchuapa fue un sitio adonde llegó la influencia de Copán, así como la influencia teotihuacana y tolteca.Comprende una serie de estructuras que fueron el escenario de un importante y sofisticado asentamiento maya que existió alrededor de los años 100 y 1200 d.C.Tras una larga ocupación, cuyo mayor desarrollo corresponde al horizonte Clásico(250 a 900 d.C.), Tazumal fue abandonado definitivamente alrededor del año 1200 d.C." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "DireccionMapa",
                table: "Destinos",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cover",
                value: "img/covers/1.jpg");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cover",
                value: "img/covers/2.jpg");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cover",
                value: "img/covers/3.jpg");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Cover",
                value: "img/covers/4.jpg");
        }
    }
}
