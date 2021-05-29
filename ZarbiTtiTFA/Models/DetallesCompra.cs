using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZarbiTtiTFA.Models
{
    public class DetallesCompra
    {
        public int IDDetallesCompra { get; set; }
        [Required]
        public Nullable<int> IDMiembro { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string ciudad { get; set; }
        [Required]
        public string provincia { get; set; }
        [Required]
        public string pais { get; set; }
        [Required]
        public string codigozip { get; set; }
        public Nullable<int> IDOrder { get; set; }
        public Nullable<decimal> precioPagado { get; set; }
        [Required]
        public string formaPago { get; set; }
    }
}