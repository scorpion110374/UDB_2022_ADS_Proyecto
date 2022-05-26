using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Vesa.Models
{
    public class Destino
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Required]
        public int Id { get; set; }
        [Column(TypeName = "varchar(100)"), MaxLength(100), Required]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [Column(TypeName = "text"), Required]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [Column(TypeName = "varchar(100)"), Required]
        [DisplayName("Cover")]
        public string Cover { get; set; }
        [Column(TypeName = "text"), Required]
        [DisplayName("Ubicación")]
        public string Ubicacion { get; set; }
        [Column(TypeName = "varchar(100)"), Required]
        [DisplayName("Dirección Mapa")]
        public string DireccionMapa { get; set; }
        [DisplayName("Fecha de Creación")]
        public DateTime Fecha { get; set; }
        [DefaultValue(true)]
        public bool Activo { get; set; }
        [DisplayName("Calificación")]
        [DefaultValue(0)]
        public int Calificacion { get; set; }
        [DisplayName("Puntuación")]
        [DefaultValue(0)]
        public int Puntuacón { get; set; }
    }
}
