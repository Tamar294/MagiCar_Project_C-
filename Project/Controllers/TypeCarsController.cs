using Dal.Api;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeCarsController : ControllerBase
    {
        ITypeCarRepo typeCarRepo;
        public TypeCarsController(ITypeCarRepo typeCarRepo)
        {
            this.typeCarRepo = typeCarRepo;
        }

        [HttpGet]
        public ActionResult<List<TypeCar>> GetAll()
        {
            var typeCars = typeCarRepo.GetAll();
            if (typeCars == null)
            {
                return NotFound();
            }
            return typeCars;
        }

        [HttpGet("{id}")]
        public ActionResult<TypeCar> GetById(int id)
        {
            TypeCar typeCar = typeCarRepo.GetById(id);
            if (typeCar == null)
            {
                return NotFound();
            }
            return typeCar;


        }

        [HttpPost]
        public ActionResult<TypeCar> Post([FromBody] TypeCar typeCar)
        {
            if (typeCar == null)
            {
                return NotFound();
            }
            return typeCarRepo.Add(typeCar);
        }

        [HttpDelete("{id}")]
        public ActionResult<TypeCar> Delete(int id)
        {
            var delete = typeCarRepo.Delete(id);
            if (delete == null)
            {
                return NotFound();
            }
            return delete;
        }

        [HttpPut]
        public ActionResult<TypeCar> Update([FromBody] TypeCar typeCar, int id)
        {
            if (typeCar == null)
            {
                return NotFound();
            }
            return typeCarRepo.Update(typeCar, id);
        }
    }
}
