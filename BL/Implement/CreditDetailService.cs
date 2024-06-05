using Bl.Api;
using Bl.DTO;
using Dal;
using Dal.Implement;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Implement
{
    public class CreditDetailService : ICreditDetailService
    {
        PayDetailRepo creditDetails;
        public CreditDetailService(DalManager manager) 
        { 
            this.creditDetails = manager.creditDetailRepo;
        }

        public CreditDetailDTO Add(CreditDetailDTO t)
        {
            throw new NotImplementedException();
        }

        public CreditDetailDTO Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<CreditDetailDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public CreditDetailDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public CreditDetailDTO Update(int Id, CreditDetailDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
