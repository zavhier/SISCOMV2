using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISDAL.INSUMO
{
    public interface IInsumo<T>
    {
        List<T> getAllVieW();
        List<T> getASearch(String xModel);

    }
}
