using Dal.Api;
using Dal.DalImplement;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulesController : ControllerBase
    {
        IScheduleRepo scheduleRepo;
        public SchedulesController(IScheduleRepo scheduleRepo)
        {
            this.scheduleRepo = scheduleRepo;
        }

        [HttpGet]
        public ActionResult<List<Schedule>> GetAll()
        {
            var schedule = scheduleRepo.GetAll();
            if (schedule == null)
            {
                return NotFound();
            }
            return schedule;
        }

        [HttpGet("{id}")]
        public ActionResult<Schedule> GetById(int id)
        {
            Schedule schedule = scheduleRepo.GetById(id);
            if (schedule == null)
            {
                return NotFound();
            }
            return schedule;
        }

        [HttpPost]
        public ActionResult<Schedule> post([FromBody] Schedule schedule)
        {
            if (schedule == null)
            {
                return NotFound();
            }
            return schedule;
        }

        [HttpDelete("{id}")]
        public ActionResult<Schedule> Delete(int id)
        {
            var delete = scheduleRepo.Delete(id);
            if (delete == null)
            {
                return NotFound();
            }
            return delete;
        }

        [HttpPut("{id}")]
        public ActionResult<Schedule> Update([FromBody] Schedule schedule)
        {
            if (schedule == null)
            {
                return NotFound();
            }
            return schedule;
        }
    }
}
