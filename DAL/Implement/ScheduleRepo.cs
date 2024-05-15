using Dal.Api;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Implement;

public class ScheduleRepo: IScheduleRepo
{
    MagiCarContext context;
    public ScheduleRepo( MagiCarContext context)
    {
        this.context = context;
    }

    public Schedule Add(Schedule s)
    {
        try
        {
            context.Schedules.Add(s);
            context.SaveChanges();
            return s;

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to add a new Schedule🙁");
        }
    }

    public Schedule Delete(int id)
    {
        try
        {
            Schedule remove = context.Schedules.FirstOrDefault(Schedule => Schedule.Id == id);
            context.Schedules.Remove(remove);
            context.SaveChanges();
            return remove;

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"Failed to delete Schedule {id}🙁.");
        }
    }

    public List<Schedule> GetAll()
    {
        try
        {
            return context.Schedules.ToList();

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to get all the Schedule🙁.");
        }
    }

    public Schedule GetById(int id)
    {
        try
        {
            return context.Schedules.FirstOrDefault(Schedule => Schedule.Id == id);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"Error in getting a single Schedule {id} data.");
        }
    }

    public Schedule Update(int id, Schedule s)
    {
        try
        {
            Schedule schedule = context.Schedules.FirstOrDefault(Schedule => Schedule.Id == id);
            if (schedule != null)
            {
                schedule.StartDate = s.StartDate;
                schedule.EndDate = s.EndDate;
                schedule.CarId = s.CarId;
            }
            context.SaveChanges();
            return s;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to update the schedule🙁.");
        }
    }
}
