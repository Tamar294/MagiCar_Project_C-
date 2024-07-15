using Bl.Api;
using Bl.DTO;
using Dal;
using Dal.Implement;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Implement
{
    public class ScheduleService : IScheduleService
    {
        CarRentalRepo schedules;
        public ScheduleService(DalManager manager) 
        {
            this.schedules = manager.scheduleRepo;
        }

        public ScheduleDTO Add(ScheduleDTO t)
        {
            throw new NotImplementedException();
        }

        public ScheduleDTO Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<ScheduleDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public ScheduleDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public ScheduleDTO Update(int Id, ScheduleDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
