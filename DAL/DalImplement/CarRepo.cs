using Dal.DalApi;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplement
{
    public class CarRepo : ICarRepo
    {
        MagiCarContext context;
        public CarRepo(MagiCarContext context)
        {
            this.context = context;
        }
        public async Task<Car> AddAsync(Car entity)
        {
            try
            {
                context.Cars.Add(entity);
                await context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to add a new car🙁");
            }
        }

        public async Task<Car> DeleteAsync(int id)
        {
            try
            {
                Car car = await context.Cars.FirstOrDefaultAsync(car => car.CarId == id);
                if (car != null)
                {
                    context.Cars.Remove(car);
                }
                await context.SaveChangesAsync();
                return car;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Failed to delete car {id}🙁");
            }
        }

        public async Task<List<Car>> GetAllAsync()
        {
            try
            {
                return await context.Cars.ToListAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to get all the cars🙁");
            }
        }

        public async Task<Car> GetSingleAsync(int id)
        {
            try
            {
                return await context.Cars
                    .Where(user => user.CarId == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting a single user {id} data🙁");
            }
        }

        public async Task<Car> UpdateAsync(Car entity)
        {
            try
            {
                var car = await context.Cars.FindAsync(entity.CarId);
                if (car != null)
                {
                    car.Address = entity.Address;

                }
                context.Cars.Update(car);
                await context.SaveChangesAsync();
                return car;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to update the user🙁.");
            }
        }
    }
}
