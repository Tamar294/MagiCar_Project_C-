using Dal.Api;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Implement;

public class CarRepo : ICarRepo
{
    MagiCarContext context;
    public CarRepo(MagiCarContext context)
    {
        this.context = context;
    }

    public Car Add(Car c)
    {
        try
        {
            context.Cars.Add(c);
            context.SaveChanges();
            return c;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to add a new car🙁");
        }
    }

    public Car Delete(int id)
    {
        try
        {
            Car remove = context.Cars.FirstOrDefault(car => car.CarId == id);
            context.Cars.Remove(remove);
            context.SaveChanges();
            return remove;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"Failed to delete car {id}🙁.");
        }
    }

    public List<Car> GetAll()
    {
        try
        {
            return context.Cars.ToList();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to get all the cars🙁.");
        }
    }

    public Car GetById(int id)
    {
        try
        {
            return context.Cars.FirstOrDefault(user => user.CarId == id);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"Error in getting a single car {id} data.");
        }
    }

    public Car Update(int id, Car c)
    {
        try
        {
            Car car = context.Cars.FirstOrDefault(car => car.CarId == id);
            if (car != null)
            {
                car.Company = c.Company;
                car.AddressId = c.AddressId;
                car.TypeCode = c.TypeCode;
                car.LockCode = c.LockCode;
                car.Image = c.Image;
            }
            context.SaveChanges();
            return c;

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to update the car🙁.");
        }
    }

}
