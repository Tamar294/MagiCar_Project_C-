using Dal.Api;
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
        public ActionResult<User> Post([FromBody]User user)
        {
            if (user == null)
            {
                return NotFound();
            }
            return userRepo.Add(user);
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

        [HttpPut]
<<<<<<< HEAD
        public ActionResult<User> Update([FromBody] User user, int id)
=======
        public ActionResult<User> Update([FromBody] User user)
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
        {
            if (user == null)
            {
                return NotFound();
            }
<<<<<<< HEAD
            return userRepo.Update(user, id);
=======
            return userRepo.Update(user);
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
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

