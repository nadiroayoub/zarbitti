using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZarbiTtiTFA.Models
{
    public class DetallesCategoria
    {
        public int IDCategoria { get; set; }
        [Required(ErrorMessage = "nombre de categoria es obligatorio")]
        [StringLength(100, ErrorMessage = "caracteris entre 3 y 100", MinimumLength = 3)]
        public string nombreCategoria { get; set; }
        public Nullable<bool> active { get; set; }
        public Nullable<bool> eliminado { get; set; }
    }

    public class DetallesProducto
    {
        public int IDProducto { get; set; }

        [Required(ErrorMessage = "nombre del producto es obligatorio")]
        [StringLength(100, ErrorMessage = "caracteres entre 3 y 100", MinimumLength = 3)]
        public string nombreProducto { get; set; }
        
        [Required]
        [Range(1, 50)]
        public Nullable<int> IDCategoria { get; set; }
        public Nullable<bool> active { get; set; }
        public Nullable<bool> eliminado { get; set; }
        public Nullable<System.DateTime> fechaDeCreacion { get; set; }
        public Nullable<System.DateTime> fechaDeModificacion { get; set; }
        
        [Required(ErrorMessage = "Descripcion es obligatoria")]
        public Nullable<System.DateTime> descripcion { get; set; }
        public string ProductImage { get; set; }
        public Nullable<bool> IsFeatured { get; set; }

        [Required]
        [Range(typeof(int), "1", "500", ErrorMessage = "cantidad no valida")]
        public Nullable<int> cantidad { get; set; }

        [Required]
        [Range(typeof(decimal), "1", "200000", ErrorMessage = "Precio no valido")]
        public Nullable<decimal> precio { get; set; }

        public SelectList Categories { get; set; }

    }
}