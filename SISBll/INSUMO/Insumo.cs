using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISDAL;
using SISDAL.CRUD;
using SISDAL.INSUMO;
using SISModels;
using SISModels.ViewModels;

namespace SISBll.INSUMO
{
    public class Insumo : ICrud<SISModels.INSUMO> , IInsumo<SISModels.ViewModels.InsumoViewModel>
    {

        SISDAL.INSUMO.Insumo _insumo = new SISDAL.INSUMO.Insumo();
        public void delete(SISModels.INSUMO entity)
        {
            throw new NotImplementedException();
        }

        public void delete(List<SISModels.INSUMO> list)
        {
            throw new NotImplementedException();
        }

        public List<SISModels.INSUMO> getAll()
        {
            throw new NotImplementedException();
        }

        public List<SISModels.INSUMO> getAll(SISModels.INSUMO entity)
        {
            throw new NotImplementedException();
        }

        public List<InsumoViewModel> getAllVieW()
        {
            return _insumo.getAllVieW();
        }

        public List<InsumoViewModel> getASearch(string xModel)
        {
            return _insumo.getASearch(xModel);
        }

        public SISModels.INSUMO getId(SISModels.INSUMO entity)
        {
            throw new NotImplementedException();
        }

        public void save(SISModels.INSUMO entity)
        {
            _insumo.save(entity);
        }

        public void save(List<SISModels.INSUMO> list)
        {
            throw new NotImplementedException();
        }

        public void update(SISModels.INSUMO entity)
        {
            throw new NotImplementedException();
        }

        public void update(List<SISModels.INSUMO> list)
        {
            throw new NotImplementedException();
        }
    }
}
