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
    
    public partial class USUARIO
    {
        public int USUARIO_ID { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<int> DIGITO_VERIFICADOR { get; set; }
        public string SECTOR { get; set; }
        public string DNI { get; set; }
        public string APELLIDO { get; set; }
        public string NOMBRE { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> PERMISO_ID { get; set; }
    }
}
