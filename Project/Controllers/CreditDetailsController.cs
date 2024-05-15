using Dal.Api;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditDetailsController : ControllerBase
    {
        ICreditDetailRepo creditDetailRepo;
        public CreditDetailsController(ICreditDetailRepo creditDetailRepo)
        {
            this.creditDetailRepo = creditDetailRepo;
        }

        [HttpGet]
        public ActionResult<List<CreditDetail>> GetAll()
        {
            var creditDetail = creditDetailRepo.GetAll();
            if (creditDetail == null)
            {
                return NotFound();
            }
            return creditDetail;
        }

        [HttpGet("{id}")]
        public ActionResult<CreditDetail> GetById(int id)
        {
            CreditDetail creditDetail = creditDetailRepo.GetById(id);
            if (creditDetail == null)
            {
                return NotFound();
            }
            return creditDetail;
        }

        [HttpPost]
        public ActionResult<CreditDetail> post([FromBody] CreditDetail creditDetail)
        {
            if (creditDetail == null)
            {
                return NotFound();
            }
            return creditDetail;
        }

        [HttpDelete("{id}")]
        public ActionResult<CreditDetail> Delete(int id)
        {
            var delete = creditDetailRepo.Delete(id);
            if (delete == null)
            {
                return NotFound();
            }
            return delete;
        }

        [HttpPut("{id}")]
        public ActionResult<CreditDetail> Update([FromBody] CreditDetail creditDetail)
        {
            if (creditDetail == null)
            {
                return NotFound();
            }
            return creditDetail;
        }
    }
}
