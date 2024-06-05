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
    public class AddressService : IAddressService
    {
        AddressRepo addresses;
        public AddressService(DalManager manager)
        {
            this.addresses = manager.addressRepo;
        }

        public AddressDTO Add(AddressDTO t)
        {
            throw new NotImplementedException();
        }

        public AddressDTO Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<AddressDTO> GetAll()
        {
            List<Address> listDal = addresses.GetAll();
            List<AddressDTO> listDTO = new List<AddressDTO>();
            foreach(Address address in listDal)
            {
                listDTO.Add(new AddressDTO(address));
            }
            return listDTO;
        }

        public AddressDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public AddressDTO Update(int Id, AddressDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
