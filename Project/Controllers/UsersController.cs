using Dal.Api;
using Dal.DalImplementations;
using Dal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserRepo userRepo;
        public UsersController(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }

        [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            var users = userRepo.GetAll();
            if (users == null)
            {
                return NotFound();
            }
            return users;
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            User user = userRepo.GetById(id);
            if(user == null)
            {
                return NotFound();
            }
            return user;
            

        }

        [HttpPost]
        public ActionResult<User> post([FromBody]User user)
        {
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        [HttpDelete("{id}")]
        public ActionResult<User> Delete(int id) 
        {
            var delete = userRepo.Delete(id);
            if(delete == null)
            {
                return NotFound();
            }
            return delete;
        }

        [HttpPut("{id}")]
        public ActionResult<User> Update([FromBody] User user)
        {
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        //[HttpPut("{id}")]
        //public ActionResult<User> Update([FromBody] string name, [FromBody] string email, [FromBody] string password, [FromBody] int phoneNumber, [FromBody] Address addressId, [FromBody] CreditDetail creditCardId)
        //{
        //    //User user = userRepo.Update()
        //    //User user = userRepo.Update(name, email, password, phoneNumber, addressId, creditCardId);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    return user;
        //}


    } 
}

