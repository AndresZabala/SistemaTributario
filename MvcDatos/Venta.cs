//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public long Id { get; set; }
        public long IdTercero { get; set; }
        public long IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Tercero Tercero { get; set; }
    }
}
