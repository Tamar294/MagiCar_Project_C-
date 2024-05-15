using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Api
{
    public interface IService<T>
    {
        List<T> GetAll();
        T GetByID(int id);
        T Add(T t);
        T Update(int Id, T t);
        T Delete(int Id);

    }
}
