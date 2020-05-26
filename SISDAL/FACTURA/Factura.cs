using SISDAL.CRUD;
using SISModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISDAL.FACTURA
{
    public class Factura : ICrud<SISModels.FACTURA>
    {
        public void delete(SISModels.FACTURA entity)
        {
            throw new NotImplementedException();
        }

        public void delete(List<SISModels.FACTURA> list)
        {
            throw new NotImplementedException();
        }

        public List<SISModels.FACTURA> getAll()
        {
            throw new NotImplementedException();
        }

        public List<SISModels.FACTURA> getAll(SISModels.FACTURA entity)
        {
            throw new NotImplementedException();
        }

        public SISModels.FACTURA getId(SISModels.FACTURA entity)
        {
            throw new NotImplementedException();
        }

        public void save(SISModels.FACTURA entity)
        {
            using (SISCOMEntities db = new SISCOMEntities()) {
                db.FACTURA.Add(entity);
                db.SaveChanges();

            }
        }

        public void save(List<SISModels.FACTURA> list)
        {
            throw new NotImplementedException();
        }

        public void update(SISModels.FACTURA entity)
        {
            throw new NotImplementedException();
        }

        public void update(List<SISModels.FACTURA> list)
        {
            throw new NotImplementedException();
        }
    }
}
