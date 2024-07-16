using Dal.Api;
using Dal.Implement;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Implement
{

    public class TypeCarRepo : ITypeCarRepo
    {
        MagiCarContext context;
        public TypeCarRepo(MagiCarContext context)
        {
            this.context = context;
        }

        public TypeCar Add(TypeCar t)
        {
            try
            {
                context.TypeCars.Add(t);
                context.SaveChanges();
                return t;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to add a new typeCar🙁");
            }
        }

        public TypeCar Delete(int id)
        {
            try
            {
                TypeCar remove = context.TypeCars.FirstOrDefault(typeCar => typeCar.Id == id);
                context.TypeCars.Remove(remove);
                context.SaveChanges();
                return remove;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Failed to delete TypeCar {id}🙁.");
            }
        }

        public List<TypeCar> GetAll()
        {
            try
            {
                return context.TypeCars.ToList();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to get all the typeCar🙁.");
            }
        }

        public TypeCar GetById(int id)
        {
            try
            {
                return context.TypeCars.FirstOrDefault(typeCar => typeCar.Id == id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting a single typeCar {id} data.");
            }
        }

        public TypeCar Update(TypeCar t, int id)
        {
            try
            {
                TypeCar typeCar = context.TypeCars.FirstOrDefault(typeCar => typeCar.Id == t.Id);
                if (typeCar != null)
                {
                    typeCar.Name = t.Name;
                    typeCar.SeatsNumber = t.SeatsNumber;
                    typeCar.HourlyPrice = t.HourlyPrice;
                    typeCar.DailyPrice = t.DailyPrice;
                    typeCar.WeeklyPrice = t.WeeklyPrice;
                    typeCar.KilometerPrice = t.KilometerPrice;
                }
                context.SaveChanges();
                return t;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to update the typeCar🙁.");
            }
        }
    }
}


