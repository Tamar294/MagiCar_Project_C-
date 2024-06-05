using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Api
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        T Add(T t);
        T Update( T t);
        T Delete(int id);
    }
}
