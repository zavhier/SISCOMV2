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
    
    public partial class STOCK
    {
        public int STOCK_ID { get; set; }
        public int INSUMO_ID { get; set; }
        public Nullable<System.DateTime> FECHA_ACTUALIZACION { get; set; }
        public string MOTIVO_MOVIMIENTO { get; set; }
        public string TIPO_MOVIMIENTO { get; set; }
        public int CANTIDAD_MODIFICADA { get; set; }
        public int CANTIDAD_DISPONIBLE { get; set; }
    
        public virtual INSUMO INSUMO { get; set; }
    }
}
