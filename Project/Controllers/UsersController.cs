using Dal.Interfaces;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<List<User>>> GetAll()
        {
            return await userRepo.GetAllAsync();
        }
    }
}
