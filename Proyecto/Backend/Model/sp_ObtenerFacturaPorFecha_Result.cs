//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend.Model
{
    using System;
    
    public partial class sp_ObtenerFacturaPorFecha_Result
    {
        public int ID_FACTURA { get; set; }
        public Nullable<decimal> PRECIO_UNIDAD { get; set; }
        public Nullable<decimal> PRECIO_TOTAL { get; set; }
        public string METODO_PAGO { get; set; }
        public string MENSAJE { get; set; }
        public string NOMBRE_CAJERO { get; set; }
        public Nullable<decimal> TOTAL_CANCELADO { get; set; }
        public Nullable<decimal> VUELTO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<int> ID_ORDEN { get; set; }
    }
}
