//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZarbiTtiTFA.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class detallesCompra
    {
        public int IDDetallesCompra { get; set; }
        public Nullable<int> IDMiembro { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string provincia { get; set; }
        public string pais { get; set; }
        public string codigozip { get; set; }
        public Nullable<int> IDOrder { get; set; }
        public Nullable<decimal> precioPagado { get; set; }
        public string formaPago { get; set; }
    
        public virtual miembro miembro { get; set; }
    }
}