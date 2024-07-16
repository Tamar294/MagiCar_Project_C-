//using Dal.Api;
//using Dal.Models;
////using Bl.DTO;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
////using Bl.Api;
////using Bl.Implement;

//namespace Project.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AddressesController : ControllerBase
//    {
//        IAddressRepo addressRepo;
//        public AddressesController(IAddressRepo addressRepo)
//        {
//            this.addressRepo = addressRepo;
//        }
//        //private readonly IAddressService addressService;
//        //public AddressesController(IAddressService addressService)
//        //{
//        //    this.addressService = addressService;
//        //}

//        [HttpGet]
//        public ActionResult<List<Address>> GetAll()
//        {
//            var addresses = addressRepo.GetAll();
//            if (addresses == null)
//            {
//                return NotFound();
//            }
//            return addresses;
//        }
//        //[HttpGet]
//        //public ActionResult<List<AddressDTO>> GetAll()
//        //{
//        //    var addresses = addressService.GetAll();
//        //    if (addresses == null)
//        //    {
//        //        return NotFound();
//        //    }
//        //    return addresses;
//        //}

//        [HttpGet("{id}")]
//        public ActionResult<Address> GetById(int id)
//        {
//            Address address = addressRepo.GetById(id);
//            if (address == null)
//            {
//                return NotFound();
//            }
//            return address;
//        }

//        [HttpPost]
//        public ActionResult<Address> Post([FromBody] Address address)
//        {
//            if (address == null)
//            {
//                return NotFound();
//            }
//            return addressRepo.Add(address);
//        }

//        [HttpDelete("{id}")]
//        public ActionResult<Address> Delete(int id)
//        {
//            var delete = addressRepo.Delete(id);
//            if (delete == null)
//            {
//                return NotFound();
//            }
//            return delete;
//        }

//        [HttpPut("{id}")]
//        public ActionResult<Address> Update([FromBody] Address address)
//        {
//            if (address == null)
//            {
//                return NotFound();
//            }
//            //return addressRepo.Update(address);
//            throw new NotImplementedException();
//        }
//    }
//}



using Bl;
using Bl.Api;
using Bl.DTO;
using Bl.Implement;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        AddressService addressService;
        public AddressesController(BlManager manager)
        {
            this.addressService = manager.addressService;
        }

        [HttpGet]
        public ActionResult<List<AddressDTO>> GetAll()
        {
            var addresses = addressService.GetAll();
            if (addresses == null)
            {
                return NotFound();
            }
            return addresses;
        }

        [HttpGet("{id}")]
        public ActionResult<AddressDTO> GetById(int id)
        {
            AddressDTO address = addressService.GetById(id);
            if (address == null)
            {
                return NotFound();
            }
            return address;
        }

        [HttpPost]
        public ActionResult<AddressDTO> Post([FromBody] AddressDTO add)
        {
            if (add == null)
            {
                return NotFound();
            }
            return addressService.Add(add);
        }

        [HttpDelete("{id}")]
        public ActionResult<AddressDTO> Delete(int id)
        {
            var deletedAddress = addressService.Delete(id);
            if (deletedAddress == null)
            {
                return NotFound();
            }
            return deletedAddress;
        }

        [HttpPut("{id}")]
        public ActionResult<AddressDTO> Update(int id, [FromBody] AddressDTO add)
        {
            if (id != add.Id)
            {
                return NotFound();
            }
            var updatedAddress = addressService.Update(add, id);
            if (updatedAddress == null)
            {
                return NotFound();
            }
            return updatedAddress;
        }
    }
}

