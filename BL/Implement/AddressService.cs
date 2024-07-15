//using Bl.Api;
//using Bl.DTO;
//using Dal;
//using Dal.Implement;
//using Dal.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bl.Implement
//{
//    public class AddressService : IAddressService
//    {
//        AddressRepo addresses;
//        public AddressService(DalManager manager)
//        {
//            addresses = manager.address;
//        }

//        public AddressDTO Add(AddressDTO addressDTO)
//        {
//            Address newAddress = new Address
//            {
//                City = addressDTO.City,
//                Neighborhood = addressDTO.Neighborhood,
//                Street = addressDTO.Street,
//                BuildingNumber = addressDTO.BuildingNumber
//            };

//            try
//            {
//                Address addedAddress = addresses.Add(newAddress);
//                return new AddressDTO
//                {
//                    Id = addedAddress.Id,
//                    City = addedAddress.City,
//                    Neighborhood = addedAddress.Neighborhood,
//                    Street = addedAddress.Street,
//                    BuildingNumber = addedAddress.BuildingNumber
//                };
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error adding address: {ex.Message}");
//                return null;
//            }
//        }


//        //public async Task<UserBl> AddUser(UserBl user)
//        //{
//        //    try
//        //    {
//        //        await emailService.SendWelcomeEmail(user.Email);
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        //throw new Exception("unable to send email. "+ ex.Message);
//        //    }
//        //    user.Id = newUser.Id;
//        //    return user;
//        //}






//        public AddressDTO Delete(int Id)
//        {
//            throw new NotImplementedException();
//        }

//        public List<AddressDTO> GetAll()
//        {
//            List<Address> listDal = addresses.GetAll();
//            List<AddressDTO> listDTO = new List<AddressDTO>();
//            foreach(Address address in listDal)
//            {
//                listDTO.Add(new AddressDTO(address));
//            }
//            return listDTO;
//        }

//        public AddressDTO GetByID(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public AddressDTO Update(int Id, AddressDTO t)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
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
        private readonly AddressRepo addresses;

        public AddressService(DalManager manager)
        {
            addresses = manager.address;
        }

        public AddressDTO Add(AddressDTO addressDTO)
        {
            Address newAddress = new Address
            {
                City = addressDTO.City,
                Neighborhood = addressDTO.Neighborhood,
                Street = addressDTO.Street,
                BuildingNumber = addressDTO.BuildingNumber
            };

            try
            {
                Address addedAddress = addresses.Add(newAddress);
                return new AddressDTO(addedAddress);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding address: {ex.Message}");
                return null;
            }
        }

        public AddressDTO Delete(int id)
        {
            try
            {
                Address deletedAddress = addresses.Delete(id);
                return new AddressDTO(deletedAddress);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting address: {ex.Message}");
                return null;
            }
        }

        public List<AddressDTO> GetAll()
        {
            try
            {
                List<Address> addressList = addresses.GetAll();
                return addressList.Select(address => new AddressDTO(address)).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting all addresses: {ex.Message}");
                return null;
            }
        }

        public AddressDTO GetByID(int id)
        {
            try
            {
                Address address = addresses.GetById(id);
                return new AddressDTO(address);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting address by ID: {ex.Message}");
                return null;
            }
        }

        public AddressDTO Update(int id, AddressDTO addressDTO)
        {
            Address updatedAddress = new Address
            {
                Id = addressDTO.Id,
                City = addressDTO.City,
                Neighborhood = addressDTO.Neighborhood,
                Street = addressDTO.Street,
                BuildingNumber = addressDTO.BuildingNumber,
                //Cars = addressDTO.Cars,
                //Users = addressDTO.Users
            };

            try
            {
                Address address = addresses.Update(updatedAddress, id);
                return new AddressDTO(address);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating address: {ex.Message}");
                return null;
            }
        }
    }
}

