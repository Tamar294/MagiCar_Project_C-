using Dal.Api;
using Dal.DalImplementations;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        IAddressRepo adrressRepo;
        public AddressesController (IAddressRepo adrressRepo)
        {
            this.adrressRepo = adrressRepo;
        }

        [HttpGet]
        public ActionResult<List<Address>> GetAll()
        {
            var addresses = adrressRepo.GetAll();
            if (addresses == null)
            {
                return NotFound();
            }
            return addresses;
        }

        [HttpGet("{id}")]
        public ActionResult<Address> GetById(int id)
        {
            Address address = adrressRepo.GetById(id);
            if (address == null)
            {
                return NotFound();
            }
            return address;
        }

        [HttpPost]
        public ActionResult<Address> post([FromBody] Address address)
        {
            if (address == null)
            {
                return NotFound();
            }
            return address;
        }

        [HttpDelete("{id}")]
        public ActionResult<Address> Delete(int id)
        {
            var delete = adrressRepo.Delete(id);
            if (delete == null)
            {
                return NotFound();
            }
            return delete;
        }

        [HttpPut("{id}")]
        public ActionResult<Address> Update([FromBody] Address address)
        {
            if (address == null)
            {
                return NotFound();
            }
            return address;
        }
    }
}
