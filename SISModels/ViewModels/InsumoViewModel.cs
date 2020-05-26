using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISModels.ViewModels
{
   public class InsumoViewModel
    {
        public int INSUMO_ID { get; set; }
        public string DESCRIPCION { get; set; }
        public int STOCK { get; set; }

        public Decimal PRECIO { get; set; }
        public String PROVEEDOR { get; set; }
    }
}
