using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISDAL.CRUD
{
    public interface ICrud <T>
    {

        List<T> getAll();
        List<T> getAll( T entity);
        T getId(T entity);
        void save(T entity);
        void save(List<T> list);
        void update(T entity);
        void update(List<T> list);
        void delete(T entity);
        void delete(List<T> list);

    }
}
