using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISDAL.CRUD;
using SISModels;

namespace SISDAL.BITACORA
{
    public class Bitacora : ICrud<SISModels.BITACORA>
    {
        public void delete(SISModels.BITACORA entity)
        {
            throw new NotImplementedException();
        }

        public void delete(List<SISModels.BITACORA> list)
        {
            throw new NotImplementedException();
        }

        public List<SISModels.BITACORA> getAll()
        {
            throw new NotImplementedException();
        }

        public List<SISModels.BITACORA> getAll(SISModels.BITACORA entity)
        {
            using (SISCOMEntities db = new SISCOMEntities()) {
                return db.BITACORA.ToList();
            }
        }

        public SISModels.BITACORA getId(SISModels.BITACORA entity)
        {
            using (SISCOMEntities db = new SISCOMEntities()) {

                return db.BITACORA.Find(entity.BITACORA_ID);
            }
        }

        public void save(SISModels.BITACORA entity)
        {
            using (SISCOMEntities db = new SISCOMEntities())
            {
                db.BITACORA.Add(entity);
                db.SaveChanges();
            }
        }

        public void save(List<SISModels.BITACORA> list)
        {
            throw new NotImplementedException();
        }

        public void update(SISModels.BITACORA entity)
        {
            throw new NotImplementedException();
        }

        public void update(List<SISModels.BITACORA> list)
        {
            throw new NotImplementedException();
        }
    }
}
