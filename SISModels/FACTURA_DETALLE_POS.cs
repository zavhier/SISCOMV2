//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SISModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class FACTURA_DETALLE_POS
    {
        public int FACTURA_DETALLE_POS_ID { get; set; }
        public int FACTURA_ID { get; set; }
        public Nullable<int> POSICION { get; set; }
        public Nullable<int> CANTIDAD { get; set; }
        public Nullable<decimal> PRECIO_UNITARIO { get; set; }
        public int INSUMO_ID { get; set; }
    
        public virtual FACTURA FACTURA { get; set; }
        public virtual INSUMO INSUMO { get; set; }
    }
}
