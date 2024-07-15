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
            List<Car> list = context.Cars.ToList();
            foreach (var car in list) 
            {
                car.AddressCode = context.Addresses.FirstOrDefault(add => add.Id == car.AddressCode).Id;

            }
            foreach (var car in list)
            {
                car.TypeCodeNavigation = context.TypeCars.FirstOrDefault(type => type.Id == car.TypeCode);
            }
            return list;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception(ex.ToString());
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

<<<<<<< HEAD
    public Car Update(Car c, int id)
=======
    public Car Update(Car c)
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
    {
        try
        {
            Car car = context.Cars.FirstOrDefault(car => car.CarId == c.CarId);
            if (car != null)
            {
                car.Company = c.Company;
                car.AddressCode = c.AddressCode;
                car.TypeCode = c.TypeCode;
                car.LockCode = c.LockCode;
                car.ImageAvailable = c.ImageAvailable;
                car.ImagePartiallyAvailable = c.ImagePartiallyAvailable;
                car.ImageNotAvailable = c.ImageNotAvailable;
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
