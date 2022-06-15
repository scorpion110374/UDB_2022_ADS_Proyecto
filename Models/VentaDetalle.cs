﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Vesa.Models
{
    public class VentaDetalle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Required]
        [DisplayName("Id Detalle")]
        public int Id { get; set; }
        [Required]
        [DisplayName("Id Venta")]
        public int IdVenta { get; set; }
        [Required]
        [DisplayName("Id Destino")]
        public int IdDestino { get; set; }
        [Required]
        [DisplayName("Fecha Paquete")]
        public DateTime FechaPaquete { get; set; }
        [Required,DefaultValue(0)]
        [DisplayName("Cantidad")]
        public int Cantidad { get; set; }
        [Column(TypeName = "decimal(10,2)"), Required, DefaultValue(0)]
        [DisplayName("PrecioUnitario")]
        public decimal PrecioUnitario { get; set; }
        [Column(TypeName = "decimal(10,2)"), Required, DefaultValue(0)]
        [DisplayName("SubTotal")]
        public decimal SubTotal { get; set; }
        [ForeignKey("Key_IdVenta")]
        public Venta Venta { get; set; }
        [ForeignKey("Key_IdProducto")]
        public Destino Destino { get; set; }
    }
}
