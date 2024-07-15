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
<<<<<<< HEAD
        T Update( T t, int id);
=======
        T Update( T t);
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
        T Delete(int id);
    }
}
