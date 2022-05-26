﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Proyecto_Vesa.Models;
using System;
using System.IO;

namespace Proyecto_Vesa.Data
{
    public class ProjectDbContext: DbContext
    {
        public ProjectDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        //entities
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Destino> Destinos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Llenar datos iniciales a tabla Destinos
            modelBuilder.Entity<Destino>()
                .HasData(
                new Destino()
                { 
                    Id = 1,
                    Nombre = "Volcán de Santa Ana",
                    Descripcion = "Volcán de Ilamatepec o Santa Ana, con una altitud de 2,381 metros sobre el nivel del mar, es el volcán más alto de " +
                    "El Salvador con las últimas erupciones en 1904, 1920 y 2005,según el Índice de explosividad volcánica este volcán es nivel 3 de 8. " +
                    "Forma parte del complejo Los Volcanes en la cordillera de Apaneca, dentro de un bosque nuboso montañoso tropical, en una región " +
                    "cafetalera a unos 65 kilómetros al oeste de la capital. Las principales actividades de la región son la agricultura y el turismo.",
                    Cover = "img/covers/1.jpg",
                    Ubicacion = "Pertenece al Área de Conservación y Reserva de Biosfera Apaneca-ilamatepec, certificada por UNESCO en septiembre de 2007, " +
                    "se ubica entre los municipios de Santa Ana y Chalchuapa, del Departamento de Santa Ana." +
                    "El volcán como parte del complejo Los Volcanes tiene la característica principal que ver con la vinculación hidrogeológica de los tres" +
                    " volcanes: Izalco, " +
                    "Cerro Verde e Ilamatepec.Está formada por las porciones de San José Miramar, San Blas o Las Brumas, Ojo de Agua del Venado, Los Andes, " +
                    "El Paraíso, Volcán de Izalco, la Auxiliadora y el Cerro Verde. " +
                    "Se ha establecido declaratoria para San Blas, Volcán Izalco, sus lavas y San José Miramar.Posee Plan de Manejo aprobado y de obligatorio" +
                    " cumplimiento desde el 2006.Presenta paisajes espectaculares, volcanes activos, tres ecosistemas diferentes y es parte de la ecorregión" +
                    " de Bosques Montanos de Centro América.Tiene un potencial turístico de bajo impacto hasta visitaciones masivas y posee sitios con" +
                    " capacidad de infiltración y recarga acuífera con bosques en formación como sucesión primaria sobre colada volcánica.",
                    DireccionMapa = "https://goo.gl/maps/xEGnkGYF5ZTda7tT6",
                    Fecha = Convert.ToDateTime("2022-05-25"),
                    Activo = true,
                    Calificacion = 0,
                    Puntuacón = 0
                },
                new Destino()
                {
                    Id = 2,
                    Nombre = "Volcán de Izalco",
                    Descripcion = "El Volcán de Izalco es el más joven de los volcanes de El Salvador y uno de los más jóvenes del continente americano. " +
                    "Según la versión popular, se originó en el año de 1770 cuando un orificio en la falda del Volcán de Santa Ana comenzó a despedir humo" +
                    " y cenizas. Sin embargo, el historiador Jorge Lardé y Larín indica que sus orígenes se remontan al 19 de marzo de 1722 cuando se formó" +
                    " un nuevo cráter por donde vomitó fuego, lava y cenizas , el cual hizo una importante erupción en 1745​. " +
                    "Según él Índice de explosividad volcánica este volcán es nivel 1 de 8.",
                    Cover = "img/covers/2.jpg",
                    Ubicacion = "El volcán se ubica en el Complejo Los Volcanes, que pertenece al Área de Conservación y Reserva de Biosfera Apaneca," +
                    " certificada por UNESCO en septiembre de 2007. A su vez, el complejo se ubica entre los municipios de Izalco y Nahuizalco del " +
                    "Departamento de Sonsonate. Lacaracterística principal del complejo tiene que ver con la vinculación hidrogeológica de los tres volcanes:" +
                    " Izalco, Cerro Verde e Ilamatepec o Volcán de Santa Ana.Está formado por las porciones de San José Miramar, San Blas o Las Brumas, " +
                    "Ojo de Agua del Venado, Los Andes, El Paraíso, Volcán de Izalco, la Auxiliadora y el Cerro Verde. Se ha establecido declaratoria para" +
                    " San Blas, Volcán Izalco, sus lavas y San José Miramar.Posee Plan de Manejo aprobado y de obligatorio cumplimiento desde el 2006." +
                    "Presenta paisajes espectaculares, volcanes activos, tres ecosistemas diferentes y es parte de la ecorregión de Bosques Montañosos de" +
                    " Centro América.Tiene un potencial turístico de bajo impacto hasta visitaciones masivas y posee sitios con capacidad de infiltración y" +
                    " recarga acuífera con bosques en formación como sucesión primaria sobre colada volcánica.",
                    DireccionMapa = "https://goo.gl/maps/468yqtL2X71zRx3x6",
                    Fecha = Convert.ToDateTime("2022-05-25"),
                    Activo = true,
                    Calificacion = 0,
                    Puntuacón = 0
                },
                new Destino()
                {
                    Id = 3,
                    Nombre = "Playa El Tunco",
                    Descripcion = "El Tunco es una playa de arena negra, muy reconocida internacionalmente por el turismo en el que destaca el surf, " +
                    "esta ubicada en el departamento de La Libertad. En esta playa podrás realizar diversas actividades, desde tomar el sol en una cómoda " +
                    "hamaca, caminatas, degustar de su gastronomía, hasta dominar las arrebatadas olas. " +
                    "Aparte de su belleza, El Tunco también se ha convertido en un importante destino para los surfistas de todo el mundo.Por 15 dólares" +
                    " la hora, surfistas locales enseñan a tomar las primeras olas a los novatos; mientras que los profesionales impresionan a los turistas" +
                    " con sus habilidades surfeando sobre olas que alcanzan hasta los 6 metros de altura.La mejor temporada para surfear es entre abril y" +
                    " agosto, cuando el oleaje es el adecuado.No necesitas llevar o tener tabla. En el lugar hay varias opciones de alquiler, normalmente" +
                    " $20 dólares el día.Desde la capital hasta la playa se toma unos 45 minutos a 1 hora en vehículo.Se ubica a solo 41 kms de la capital" +
                    " San Salvador.",
                    Cover = "img/covers/3.jpg",
                    Ubicacion = "Está situada en el departamento de La Libertad, municipio Tamanique a 7,2 km de El Malecon (Puerto de La Libertad)." +
                    "Para llegar en bus puedes abordar la ruta 102, 107 o 177.El costo es de $1.50 dólares.El viaje es de 1 hora aproximadamente, y los " +
                    "buses salen cada veinte minutos desde las 6 de la mañana hasta las 7 de la noche." +
                    "En vehículo, desde San Salvador, tome la carretera al Puerto de La Libertad, al llegar al desvío tome la carretera de El Litoral " +
                    "hacia El Malecón y siga hasta el kilómetro 42.Hay muchos rótulos que indican.",
                    DireccionMapa = "https://goo.gl/maps/K4oTe4E7pfuCuXov9",
                    Fecha = Convert.ToDateTime("2022-05-25"),
                    Activo = true,
                    Calificacion = 0,
                    Puntuacón = 0
                },
                new Destino()
                {
                    Id = 4,
                    Nombre = "Lago de Coatepeque",
                    Descripcion = "El lago Coatepeque es un lago de origen volcánico, situado a 18 km al sur de la ciudad de Santa Ana en el municipio de " +
                    "El Congo. Tiene una altitud de 745 msnm y una superficie de 25.3 km². Además, su profundidad de 115 m. Cuenta con una isla llamada " +
                    "la Isla del Cerro o Teopán. El topónimo 'coatepeque' significa 'Cerro de Culebras' en lenguaje náhuatl." +
                    "La caldera se formó como resultado de una serie de erupciones explosivas que sucedieron entre 57,000 - 72,000 a.C.Luego se formaron" +
                    " conos de escorias y flujos de lava en la parte occidental de la caldera, así como 6 domos de lava(Rhyodacite).La formación del domo" +
                    " más reciente se inició alrededor de 8000 A.C." +
                    "Sus accidentes más importantes son las dos pequeñas penínsulas denominadas los anteojos; y la Isla del Cerro, donde los indígenas" +
                    " náhuas tenían un templo y un monolito representativo de la diosa Itzqueye." +
                    "En sus riberas hay unas formaciones rocosas llamadas 'los anteojos'.El domo norte tiene 25 m de diámetro y 25 m de altura, y el domo" +
                    " sur tiene 150 m de diámetro y 25 m de altura." +
                    " Cambio de color" +
                    "Según autoridades del Ministerio de Medio Ambiente y Recursos Naturales de El Salvador este es un fenómeno cíclico que ocurre cada " +
                    "cierto tiempo.El lago lleva ya 5 veces que cambia de color en los últimos años.El cambio de color de agua en el lago ha sucedido en 1998," +
                    " 2006, 2012, 2016, 2017 y en el 2018." +
                    "La última vez que fue observado el fenómeno de coloración turquesa fue en agosto de 2017, debido a una floración de micro - algas" +
                    " cianofitas que forman parte del fito - plancton del lago.Se dice que este tipo de micro - algas son altamente tóxicas.En esa ocasión" +
                    " se prohibió consumir el agua del lago, tanto para humanos como animales.Entonces el incremento de algas tóxicas es el que al final," +
                    " debido a su coloración, provocaron el color turquesa en el lago.Además, debido al elevado contenido de fosfato que hace que los rayos" +
                    " solares no entren con la misma intensidad al lago generen esa pigmentación en el mismo.​",
                    Cover = "img/covers/4.jpg",
                    Ubicacion = "Esta ubicado entre los municipios de Santa Ana, El Congo e Izalco y a unos 50 Kilómetros de San Salvador. se encuentra " +
                    "dentro de la Zona de Vida Bosque Húmedo Sub-Tropical (fresco). Es una caldera volcánica, con una extensión aproximada de 6,500 Ha. " +
                    "De las cuales 2,500 corresponden al espejo de agua (unos 25 Km2 ). En la cuenca viven más de 20,000 personas, más un promedio de 5,000" +
                    " turistas mensuales que visitan el lago.",
                    DireccionMapa = "https://goo.gl/maps/Mj36THpugjE6qmeu8",
                    Fecha = Convert.ToDateTime("2022-05-25"),
                    Activo = true,
                    Calificacion = 0,
                    Puntuacón = 0
                }
                );
         }
    }
}
