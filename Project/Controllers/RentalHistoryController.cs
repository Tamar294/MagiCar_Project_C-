using Dal.Api;
using Dal.Implement;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalHistoryController : ControllerBase
    {
        IRentalHistoryRepo rentalHistoryRepo;
        public RentalHistoryController(IRentalHistoryRepo rentalHistoryRepo)
        {
            this.rentalHistoryRepo = rentalHistoryRepo;
        }

        [HttpGet]
        public ActionResult<List<RentalHistory>> GetAll()
        {
            var RentalHistory = rentalHistoryRepo.GetAll();
            if (RentalHistory == null)
            {
                return NotFound();
            }
            return RentalHistory;
        }

        [HttpGet("{id}")]
        public ActionResult<RentalHistory> GetById(int id)
        {
            RentalHistory RentalHistory = rentalHistoryRepo.GetById(id);
            if (RentalHistory == null)
            {
                return NotFound();
            }
            return RentalHistory;
        }

        [HttpPost]
        public ActionResult<RentalHistory> Post([FromBody] RentalHistory rentalHistory)
        {
            if (rentalHistory == null)
            {
                return NotFound();
            }
            return rentalHistoryRepo.Add(rentalHistory);
        }

        [HttpDelete("{id}")]
        public ActionResult<RentalHistory> Delete(int id)
        {
            var delete = rentalHistoryRepo.Delete(id);
            if (delete == null)
            {
                return NotFound();
            }
            return delete;
        }

        [HttpPut]
        public ActionResult<RentalHistory> Update([FromBody] RentalHistory rentalHistory, int id)
        {
            if (rentalHistory == null)
            {
                return NotFound();
            }
            return rentalHistoryRepo.Update(rentalHistory, id);
        }
    }
}
