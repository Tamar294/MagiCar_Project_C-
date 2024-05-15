using Dal.Api;
using Dal.DalImplement;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsToUsersController : ControllerBase
    {
        ICarsToUsersRepo carsToUsersRepo;
        public CarsToUsersController(ICarsToUsersRepo carsToUsersRepo)
        {
            this.carsToUsersRepo = carsToUsersRepo;
        }

        [HttpGet]
        public ActionResult<List<CarsToUser>> GetAll()
        {
            var carsToUsers = carsToUsersRepo.GetAll();
            if (carsToUsers == null)
            {
                return NotFound();
            }
            return carsToUsers;
        }

        [HttpGet("{id}")]
        public ActionResult<CarsToUser> GetById(int id)
        {
            CarsToUser carsToUsers = carsToUsersRepo.GetById(id);
            if (carsToUsers == null)
            {
                return NotFound();
            }
            return carsToUsers;
        }

        [HttpPost]
        public ActionResult<CarsToUser> post([FromBody] CarsToUser carsToUsers)
        {
            if (carsToUsers == null)
            {
                return NotFound();
            }
            return carsToUsers;
        }


        [HttpDelete("{id}")]
        public ActionResult<CarsToUser> Delete(int id)
        {
            var delete = carsToUsersRepo.Delete(id);
            if (delete == null)
            {
                return NotFound();
            }
            return delete;
        }

        [HttpPut("{id}")]
        public ActionResult<CarsToUser> Update([FromBody] CarsToUser carsToUsers)
        {
            if (carsToUsers == null)
            {
                return NotFound();
            }
            return carsToUsers;
        }
    }
}
