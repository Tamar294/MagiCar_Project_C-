using Bl.Api;
using Bl.DTO;
using Dal;
using Dal.Api;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Implement
{
    public class TypeCarService : ITypeCarService
    {
        ITypeCarRepo typeCars;
        public TypeCarService(DalManager manager)
        {
            //this.typeCars = manager.typeCarRepo;
            throw new NotImplementedException();
        }

        public TypeCarDTO Add(TypeCarDTO t)
        {
            throw new NotImplementedException();
        }

        public TypeCarDTO Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<TypeCarDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public TypeCarDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public TypeCarDTO Update(int Id, TypeCarDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
