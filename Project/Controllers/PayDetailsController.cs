using Dal.Api;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayDetailsController : ControllerBase
    {
        IPayDetailRepo payDetailRepo;
        public PayDetailsController(IPayDetailRepo payDetailRepo)
        {
            this.payDetailRepo = payDetailRepo;
        }

        [HttpGet]
        public ActionResult<List<PayDetail>> GetAll()
        {
            var payDetail = payDetailRepo.GetAll();
            if (payDetail == null)
            {
                return NotFound();
            }
            return payDetail;
        }

        [HttpGet("{id}")]
        public ActionResult<PayDetail> GetById(int id)
        {
            PayDetail payDetail = payDetailRepo.GetById(id);
            if (payDetail == null)
            {
                return NotFound();
            }
            return payDetail;
        }

        [HttpPost]
        public ActionResult<PayDetail> Post([FromBody] PayDetail payDetail)
        {
            if (payDetail == null)
            {
                return NotFound();
            }
            return payDetailRepo.Add(payDetail);
        }

        [HttpDelete("{id}")]
        public ActionResult<PayDetail> Delete(int id)
        {
            var delete = payDetailRepo.Delete(id);
            if (delete == null)
            {
                return NotFound();
            }
            return delete;
        }

        [HttpPut]
<<<<<<< HEAD
        public ActionResult<PayDetail> Update([FromBody] PayDetail payDetail, int id)
=======
        public ActionResult<PayDetail> Update([FromBody] PayDetail payDetail)
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
        {
            if (payDetail == null)
            {
                return NotFound();
            }
<<<<<<< HEAD
            return payDetailRepo.Update(payDetail, id);
=======
            return payDetailRepo.Update(payDetail);
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
        }
    }
}
