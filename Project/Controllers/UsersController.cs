using Dal.Interfaces;
using Dal.Models;
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
        //[HttpGet("~/{id}")]
        //public async Task<ActionResult<User>> GetById(int id)
        //{
        //    return await userRepo.FirstOrDefaultAsync(user => user.UserId == id);
        //}
        //[HttpPost("{user}")]
        //public async Task<ActionResult<List<User>>> Post(User user)
        //{
        //    return await userRepo.AddAsync(user);
        //}

        //[HttpPut("{prodId},{product}")]
        //public void Put(int prodId, Product product)
        //{
        //    Products.ProductsList.Remove(Products.ProductsList.FirstOrDefault(p => p.Id == prodId));
        //    Products.ProductsList.Add(product);
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult<List<User>>> Delete(int id)
        //{

        //}
    }
}
