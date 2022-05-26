using Microsoft.EntityFrameworkCore;
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
                    Cover = "img/destinos/cover.jpg",
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
                    DireccionMapa = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d15495.269403943099!2d-89.6294444!3d13.84999975!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f62c16156d6e997%3A0x2fd88a9ab0dbc675!2sVolc%C3%A1n%20de%20Santa%20Ana!5e0!3m2!1ses-419!2ssv!4v1653589254629!5m2!1ses-419!2ssv",
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
                    Cover = "img/destinos/cover.jpg",
                    Ubicacion = "El volcán se ubica en el Complejo Los Volcanes, que pertenece al Área de Conservación y Reserva de Biosfera Apaneca," +
                    " certificada por UNESCO en septiembre de 2007. A su vez, el complejo se ubica entre los municipios de Izalco y Nahuizalco del " +
                    "Departamento de Sonsonate. Lacaracterística principal del complejo tiene que ver con la vinculación hidrogeológica de los tres volcanes:" +
                    " Izalco, Cerro Verde e Ilamatepec o Volcán de Santa Ana.Está formado por las porciones de San José Miramar, San Blas o Las Brumas, " +
                    "Ojo de Agua del Venado, Los Andes, El Paraíso, Volcán de Izalco, la Auxiliadora y el Cerro Verde. Se ha establecido declaratoria para" +
                    " San Blas, Volcán Izalco, sus lavas y San José Miramar.Posee Plan de Manejo aprobado y de obligatorio cumplimiento desde el 2006." +
                    "Presenta paisajes espectaculares, volcanes activos, tres ecosistemas diferentes y es parte de la ecorregión de Bosques Montañosos de" +
                    " Centro América.Tiene un potencial turístico de bajo impacto hasta visitaciones masivas y posee sitios con capacidad de infiltración y" +
                    " recarga acuífera con bosques en formación como sucesión primaria sobre colada volcánica.",
                    DireccionMapa = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d18907.988373693042!2d-89.63263819999999!3d13.81365735!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f62c6ae5d0724cd%3A0x575417b5f2cc024b!2sVolcan%20de%20Izalco!5e1!3m2!1ses-419!2ssv!4v1653590216152!5m2!1ses-419!2ssv",
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
                    Cover = "img/destinos/cover.jpg",
                    Ubicacion = "Está situada en el departamento de La Libertad, municipio Tamanique a 7,2 km de El Malecon (Puerto de La Libertad)." +
                    "Para llegar en bus puedes abordar la ruta 102, 107 o 177.El costo es de $1.50 dólares.El viaje es de 1 hora aproximadamente, y los " +
                    "buses salen cada veinte minutos desde las 6 de la mañana hasta las 7 de la noche." +
                    "En vehículo, desde San Salvador, tome la carretera al Puerto de La Libertad, al llegar al desvío tome la carretera de El Litoral " +
                    "hacia El Malecón y siga hasta el kilómetro 42.Hay muchos rótulos que indican.",
                    DireccionMapa = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d18933.772221654366!2d-89.3813889!3d13.49222195!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f7cd59f22c8da2b%3A0xc9cb9224ff2461d7!2sPlaya%20El%20Tunco!5e1!3m2!1ses-419!2ssv!4v1653590300412!5m2!1ses-419!2ssv",
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
                    Cover = "img/destinos/cover.jpg",
                    Ubicacion = "Esta ubicado entre los municipios de Santa Ana, El Congo e Izalco y a unos 50 Kilómetros de San Salvador. se encuentra " +
                    "dentro de la Zona de Vida Bosque Húmedo Sub-Tropical (fresco). Es una caldera volcánica, con una extensión aproximada de 6,500 Ha. " +
                    "De las cuales 2,500 corresponden al espejo de agua (unos 25 Km2 ). En la cuenca viven más de 20,000 personas, más un promedio de 5,000" +
                    " turistas mensuales que visitan el lago.",
                    DireccionMapa = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d37807.92262660518!2d-89.54761955!3d13.86320075!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f62dcd48bbf3581%3A0xcbb51df50ff589a9!2sLago%20de%20Coatepeque!5e1!3m2!1ses-419!2ssv!4v1653590348500!5m2!1ses-419!2ssv",
                    Fecha = Convert.ToDateTime("2022-05-25"),
                    Activo = true,
                    Calificacion = 0,
                    Puntuacón = 0
                },
                new Destino()
                {
                    Id = 5,
                    Nombre = "Sitio Arqueológico Joya de Cerén",
                    Descripcion = "Joya de Cerén es un sitio precolombino de El Salvador situado en las proximidades de San Juan Opico y Las Flores, en la región centroccidental de El Salvador. Estuvo habitado" +
                    " al menos desde el año 400 por un pueblo agrícola tributario de San Andrés y fue abandonado alrededor del año 600 a causa de la erupción de la Laguna Caldera. El sitio permite apreciar la vida" +
                    " cotidiana de un pueblo maya agricultor de hace 1400 años (siglo VII), el único conocido en El Salvador." +
                    "Es uno de los sitios arqueológicos más importantes de Mesoamérica porque muestra cómo era la vida de la gente común y corriente.Por eso se le llama a menudo la Pompeya de América," +
                    " en comparación con el sitio arqueológico de Pompeya, localizado en Italia." +
                    "En 1993, Joya de Cerén fue declarada patrimonio de la humanidad por la Unesco.​",
                    Cover = "img/destinos/cover.jpg",
                    Ubicacion = "El sitio arqueológico Joya de Cerén se ubica al sur del actual caserío con el mismo nombre en el municipio de San Juan Opico, La Libertad.",
                    DireccionMapa = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7748.5909908063095!2d-89.3599041!3d13.8212866!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f63212ab199a6dd%3A0x51207fe999d8c593!2sJoya%20de%20Ceren!5e0!3m2!1ses-419!2ssv!4v1653590378443!5m2!1ses-419!2ssv",
                    Fecha = Convert.ToDateTime("2022-05-25"),
                    Activo = true,
                    Calificacion = 0,
                    Puntuacón = 0
                },
                new Destino()
                {
                    Id = 6,
                    Nombre = "Cerro El Pital",
                    Descripcion = "El Pital es la cima más alta y elevada de El Salvador y la tercera cima más alta de Honduras. Tiene una elevación de 2,730 metros sobre el nivel del mar. Además de clima fresco," +
                    " El Pital tiene un bosque húmedo conformado por árboles como pino, roble, encino y ciprés." +
                    "La parte más alta de este cerro se denomina Horqueta y es de gran atractivo turístico ya que es el lugar donde El Salvador colinda con Honduras.Es un pico montañoso de impresionantes laderas" +
                    " escarpadas.Su área total, incluyendo la zona de amortiguamiento, se estima en 38 kilómetros." +
                    "A El Pital acuden muchas personas con deseos de realizar ecoturismo, como: camping, observación de fauna y flora y caminatas por los diferentes senderos.Considerado, por las personas que gustan" +
                    " del clima frío, uno de los mejores lugares para sentir temperaturas bajas.La zona para acampar se encuentra a unos 2730 msnm aproximadamente, específicamente entre los dos picos de la montaña," +
                    " por lo que se forma un corredor de viento en ese lugar.En ese sector de la montaña la temperatura es 10 °C menos que los lugares aledaños, aunque estos estén a pocos metros." +
                    "Su vegetación está poblada de coníferas y encinos.Otras especies incluyen el Pino Blanco, Pinabete y varias especies de robles, plantas casi extintas para el país salvadoreño y únicas de esa zona.​",
                    Cover = "img/destinos/cover.jpg",
                    Ubicacion = "El cerro El Pital es una montaña transnacional, ubicada exactamente en la frontera entre El Salvador (Chalatenango) y Honduras.",
                    DireccionMapa = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d15458.673462276234!2d-89.12600760000001!3d14.388589600000001!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f63a22e2515544b%3A0x29d828ff57aed1dd!2sCerro%20El%20Pital!5e0!3m2!1ses-419!2ssv!4v1653590419048!5m2!1ses-419!2ssv",
                    Fecha = Convert.ToDateTime("2022-05-25"),
                    Activo = true,
                    Calificacion = 0,
                    Puntuacón = 0
                },
                new Destino()
                {
                    Id = 7,
                    Nombre = "San Salvador",
                    Descripcion = "Si se trata de hacer turismo en El Salvador, la ciudad capital, es una parada obligatoria. Aquí podrás encontrar la mejor oferta de paquetes turísticos en El Salvador, la mayor" +
                    " oferta hotelera, varios centros comerciales, restaurantes y museos.Entre los lugares de San Salvador que puedes visitar destacan el Palacio Nacional, la Plaza Gerardo Barrios, la Catedral" +
                    " Metropolitana, El Museo de Arte, uno de los más importantes del país y la Plaza Futura que ofrece un ambiente activo por la noche con sus terrazas y cafés." +
                    "Asimismo hay muchos lugares con un enfoque natural, los cuales están cerca de la ciudad.Ejemplo de ello es Parque Nacional El Boquerón Este no te lo puedes perder.Si eres un aventurero, " +
                    "lo podrás visitar, se encuentra en el cráter del volcán y cuenta con miradores, senderos, vistas impresionantes, amplia fauna y flora.No te preocupes si eres menos aventurero, te recomiendo" +
                    " conocer el Boquerón de igual manera ya que queda bastante cerca de la ciudad, es seguro y sus vistas son impresionantes.​",
                    Cover = "img/destinos/cover.jpg",
                    Ubicacion = "Capital de El Salvador",
                    DireccionMapa = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d15505.305056993278!2d-89.1943073!3d13.69867895!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f6330ebffdbfb45%3A0x513c506801a25f0e!2sCentro%20Hist%C3%B3rico%20de%20SS%2C%20San%20Salvador!5e0!3m2!1ses-419!2ssv!4v1653590454327!5m2!1ses-419!2ssv",
                    Fecha = Convert.ToDateTime("2022-05-25"),
                    Activo = true,
                    Calificacion = 0,
                    Puntuacón = 0
                },
                new Destino()
                {
                    Id = 8,
                    Nombre = "Sitio Arqueológico El Tazumal",
                    Descripcion = "Tazumal comprende una serie de estructuras que fueron el escenario de un importante y sofisticado asentamiento maya q ue existió alrededor de los años 100 - 1200 DC. Los restos" +
                    " incluyen sistemas de drenaje de aguas, tumbas, pirámides y templos. Su mayor desarrollo corresponde al horizonte Clásico (250 a 900 d. C.). Desde el 900 D.C. Alrededor del año 1,200 D.C. fue" +
                    " abandonado definitivamente." +
                    "Su mayor estructura mide 24 metros de altura, cuenta con doce escalones o plataformas y en ella se encontraron tumbas con más de 116 vasijas, joyería de jade, “espejos” de pirita de hierro, " +
                    "artefactos de juego de pelota y cerámica con forma de lagartos.En Tazumal se halla también la piedra de las victorias, que consiste en un monolito de influencia Olmeca que presenta cuatro " +
                    "petrograbados distintos en sus cuatro lados, fechado en 700 a.C., aproximadamente." +
                    "Entre los hallazgos más importantes de Tazumal se encuentra la Virgen de Tazumal, que fue encontrada en 1892 por el historiador Santiago Barberena, quien la trasladó al Museo Nacional; y el " +
                    "llamado Chac-Mool, el cual fue encontrado en la ahora nombrada Laguna Seca de Chalchuapa." +
                    "El sitio Tazumal es ineludible destino para los amantes de la arqueología. Cuenta con un museo y guías locales.El Museo Stanley Boggs describe la secuencia habitacional de las culturas " +
                    "prehispánicas de los períodos Preclásico, Clásico y Postclásico, y presenta los diferentes sitios que conforman el área arqueológica de Chalchuapa, como son: El Trapiche, Laguna Cuscachapa, " +
                    "Las Victorias, Casa Blanca, Laguna Seca, y Grupo Peñate​",
                    Cover = "img/destinos/cover.jpg",
                    Ubicacion = "Está ubicado en el corazón de Chalchuapa, departamento de Santa Ana, a 80 kilómetros al occidente de la capital. Esta zona está dentro de un área arqueológica de aproximadamente" +
                    " 10 km² en donde también se localizan los sitios de Pampe, Casa Blanca, El Trapiche y Las Victorias." +
                    "Chalchuapa fue un sitio adonde llegó la influencia de Copán, así como la influencia teotihuacana y tolteca.Comprende una serie de estructuras que fueron el escenario de un importante y " +
                    "sofisticado asentamiento maya que existió alrededor de los años 100 y 1200 d.C.Tras una larga ocupación, cuyo mayor desarrollo corresponde al horizonte Clásico(250 a 900 d.C.)," +
                    " Tazumal fue abandonado definitivamente alrededor del año 1200 d.C.",
                    DireccionMapa = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3871.624372032057!2d-89.6795008!3d13.9809501!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x7495b8397db2b9bf!2sSitio%20Arqueol%C3%B3gico%20El%20Tazumal!5e0!3m2!1ses-419!2ssv!4v1653590488480!5m2!1ses-419!2ssv",
                    Fecha = Convert.ToDateTime("2022-05-25"),
                    Activo = true,
                    Calificacion = 0,
                    Puntuacón = 0
                }
                );
         }
    }
}
