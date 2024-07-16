using Dal.Api;
using Dal.Implement;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsRentalController : ControllerBase
    {
        ICarRentalRepo carRenctalRepo;
        public CarsRentalController(ICarRentalRepo carRenctalRepo)
        {
            this.carRenctalRepo = carRenctalRepo;
        }

        [HttpGet]
        public ActionResult<List<CarsRental>> GetAll()
        {
            var carsRental = carRenctalRepo.GetAll();
            if (carsRental == null)
            {
                return NotFound();
            }
            return carsRental;
        }

        [HttpGet("{id}")]
        public ActionResult<CarsRental> GetById(int id)
        {
            CarsRental carsRental = carRenctalRepo.GetById(id);
            if (carsRental == null)
            {
                return NotFound();
            }
            return carsRental;
        }

        [HttpPost]
        public ActionResult<CarsRental> Post([FromBody] CarsRental carsRental)
        {
            if (carsRental == null)
            {
                return NotFound();
            }
            return carRenctalRepo.Add(carsRental);
        }


        [HttpDelete("{id}")]
        public ActionResult<CarsRental> Delete(int id)
        {
            var delete = carRenctalRepo.Delete(id);
            if (delete == null)
            {
                return NotFound();
            }
            return delete;
        }

        [HttpPut]
        public ActionResult<CarsRental> Update([FromBody] CarsRental carsRental, int id)
        {
            if (carsRental == null)
            {
                return NotFound();
            }
            return carRenctalRepo.Update(carsRental, id);
        }
    }
}
