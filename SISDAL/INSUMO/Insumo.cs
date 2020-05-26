using SISDAL.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISModels;
using SISModels.ViewModels;

namespace SISDAL.INSUMO
{
    public  class Insumo : ICrud<SISModels.INSUMO>, IInsumo<SISModels.ViewModels.InsumoViewModel>
    {
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
            using (SISCOMEntities db = new SISCOMEntities())
            {

                return db.INSUMO.ToList();

            }
         
        }

        public  List<SISModels.INSUMO> getAll(SISModels.INSUMO entity)
        {
            throw new NotImplementedException();
        }

        public List<InsumoViewModel> getAllVieW()
        {
            using (SISCOMEntities db = new SISCOMEntities())
            {
                var list = (from d in db.INSUMO
                             join e in db.STOCK
                             on  d.INSUMO_ID equals e.INSUMO_ID
                             join p in db.PROVEEDOR
                             on  d.PROVEEDOR_ID equals p.PROVEEDOR_ID
                            select new SISModels.ViewModels.InsumoViewModel
                            {

                                INSUMO_ID = d.INSUMO_ID,
                                DESCRIPCION = d.DESCRIPCION,
                                STOCK = e.CANTIDAD_DISPONIBLE,
                                PRECIO =  d.PRECIO,
                                PROVEEDOR  = p.NOMBRE

                            }).AsQueryable();

                return list.ToList<InsumoViewModel>();
            }
        }

        public List<InsumoViewModel> getASearch(string xModel)
        {
            using (SISCOMEntities db = new SISCOMEntities()) {
                var list = (from d in db.INSUMO
                            join e in db.STOCK
                            on d.INSUMO_ID equals e.STOCK_ID
                            join p in db.PROVEEDOR
                            on d.PROVEEDOR_ID equals p.PROVEEDOR_ID

                            select new SISModels.ViewModels.InsumoViewModel
                            {
                                INSUMO_ID = d.INSUMO_ID,
                                DESCRIPCION = d.DESCRIPCION,
                                STOCK   = e.CANTIDAD_DISPONIBLE,
                                PROVEEDOR = p.NOMBRE
                            }).AsQueryable();

            //    list.Where(p => p.DESCRIPCION.Contains(xModel));
                return list.Where(p => p.DESCRIPCION.Contains(xModel)).ToList<InsumoViewModel>();
            }
        }

        public SISModels.INSUMO getId(SISModels.INSUMO entity)
        {
            throw new NotImplementedException();
        }

        public void save(SISModels.INSUMO entity)
        {
            using (SISCOMEntities db = new SISCOMEntities()) {
                db.INSUMO.Add(entity);
                db.SaveChanges();
            }
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
