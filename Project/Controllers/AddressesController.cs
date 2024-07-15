<<<<<<< HEAD
﻿//using Dal.Api;
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
=======
﻿using Dal.Api;
using Dal.Models;
//using Bl.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Bl.Api;
//using Bl.Implement;
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
<<<<<<< HEAD
        private readonly IAddressService addressService;

        public AddressesController(IAddressService addressService)
        {
            this.addressService = addressService;
=======
        IAddressRepo addressRepo;
        public AddressesController(IAddressRepo addressRepo)
        {
            this.addressRepo = addressRepo;
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
        }
        //private readonly IAddressService addressService;
        //public AddressesController(IAddressService addressService)
        //{
        //    this.addressService = addressService;
        //}

        [HttpGet]
        public ActionResult<List<AddressDTO>> GetAll()
        {
<<<<<<< HEAD
            var addresses = addressService.GetAll();
=======
            var addresses = addressRepo.GetAll();
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
            if (addresses == null)
            {
                return NotFound();
            }
            return addresses;
        }
        //[HttpGet]
        //public ActionResult<List<AddressDTO>> GetAll()
        //{
        //    var addresses = addressService.GetAll();
        //    if (addresses == null)
        //    {
        //        return NotFound();
        //    }
        //    return addresses;
        //}

        [HttpGet("{id}")]
        public ActionResult<AddressDTO> GetById(int id)
        {
<<<<<<< HEAD
            AddressDTO address = addressService.GetByID(id);
=======
            Address address = addressRepo.GetById(id);
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
            if (address == null)
            {
                return NotFound();
            }
            return address;
        }

        [HttpPost]
<<<<<<< HEAD
        public ActionResult<AddressDTO> Post([FromBody] AddressDTO addressDTO)
=======
        public ActionResult<Address> Post([FromBody] Address address)
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
        {
            if (addressDTO == null)
            {
                return BadRequest();
            }
<<<<<<< HEAD
            var addedAddress = addressService.Add(addressDTO);
            if (addedAddress == null)
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }
            return CreatedAtAction(nameof(GetById), new { id = addedAddress.Id }, addedAddress);
=======
            return addressRepo.Add(address);
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
        }

        [HttpDelete("{id}")]
        public ActionResult<AddressDTO> Delete(int id)
        {
<<<<<<< HEAD
            var deletedAddress = addressService.Delete(id);
            if (deletedAddress == null)
=======
            var delete = addressRepo.Delete(id);
            if (delete == null)
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
            {
                return NotFound();
            }
            return deletedAddress;
        }

<<<<<<< HEAD
        [HttpPut("{id}")]
        public ActionResult<AddressDTO> Update(int id, [FromBody] AddressDTO addressDTO)
=======
        [HttpPut]
        public ActionResult<Address> Update([FromBody] Address address)
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
        {
            if (addressDTO == null)
            {
                return BadRequest();
            }
<<<<<<< HEAD
            var updatedAddress = addressService.Update(id, addressDTO);
            if (updatedAddress == null)
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }
            return updatedAddress;
=======
            return addressRepo.Update(address);
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
        }
    }
}

