using Dal.DalApi;
using Dal.DalApi;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarRepo carRepo;
        public CarsController(ICarRepo carRepo)
        {
            this.carRepo = carRepo;
        }
        /*[HttpGet]
        public async Task<ActionResult<List<Car>>> GetAll()
        {
            return await carRepo.GetAllAsync();
        }*/
    }
}
