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
    
    public partial class ORDEN_DE_COMPRA
    {
        public int ORDEN_COMPRA_ID { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string ESTADO { get; set; }
        public int PROVEEDOR_ID { get; set; }
        public Nullable<int> SOLICITUD_PEDIDO_ID { get; set; }
    
        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}