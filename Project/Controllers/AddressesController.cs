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



using Bl.Api;
using Bl.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IAddressService addressService;

        public AddressesController(IAddressService addressService)
        {
            this.addressService = addressService;
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
            AddressDTO address = addressService.GetByID(id);
            if (address == null)
            {
                return NotFound();
            }
            return address;
        }

        [HttpPost]
        public ActionResult<AddressDTO> Post([FromBody] AddressDTO addressDTO)
        {
            if (addressDTO == null)
            {
                return BadRequest();
            }
            var addedAddress = addressService.Add(addressDTO);
            if (addedAddress == null)
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }
            return CreatedAtAction(nameof(GetById), new { id = addedAddress.Id }, addedAddress);
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
        public ActionResult<AddressDTO> Update(int id, [FromBody] AddressDTO addressDTO)
        {
            if (addressDTO == null)
            {
                return BadRequest();
            }
            var updatedAddress = addressService.Update(id, addressDTO);
            if (updatedAddress == null)
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }
            return updatedAddress;
        }
    }
}

