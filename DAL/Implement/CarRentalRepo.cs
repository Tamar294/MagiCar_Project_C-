using Dal.Api;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Implement;

public class CarRentalRepo: ICarRentalRepo
{
    MagiCarContext context;
    public CarRentalRepo( MagiCarContext context)
    {
        this.context = context;
    }

    public CarsRental Add(CarsRental c)
    {
        try
        {
            context.CarsRentals.Add(c);
            context.SaveChanges();
            return c;

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to add a new CarsRental🙁");
        }
    }

    public CarsRental Delete(int id)
    {
        try
        {
            CarsRental remove = context.CarsRentals.FirstOrDefault(carsRental => carsRental.Id == id);
            context.CarsRentals.Remove(remove);
            context.SaveChanges();
            return remove;

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"Failed to delete CarsRental {id}🙁.");
        }
    }

    public List<CarsRental> GetAll()
    {
        try
        {
            return context.CarsRentals.ToList();

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to get all the CarsRental🙁.");
        }
    }

    public CarsRental GetById(int id)
    {
        try
        {
            return context.CarsRentals.FirstOrDefault(Schedule => Schedule.Id == id);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"Error in getting a single CarsRental {id} data.");
        }
    }

    public CarsRental Update(CarsRental c, int id)
    {
        try
        {
            CarsRental carsRental = context.CarsRentals.FirstOrDefault(carsRental => carsRental.Id == c.Id);
            if (carsRental != null)
            {
                carsRental.CarCode = c.CarCode;
                carsRental.UserCode = c.UserCode;
                carsRental.StartTime = c.StartTime;
                carsRental.EndTime = c.EndTime;
                carsRental.Returned = c.Returned;
            }
            context.SaveChanges();
            return c;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to update the carsRental🙁.");
        }
    }
}
