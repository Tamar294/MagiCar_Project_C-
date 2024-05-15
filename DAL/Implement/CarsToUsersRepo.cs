using Dal.Api;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal. Implement
{
    public class CarsToUsersRepo: ICarsToUsersRepo
    {
        MagiCarContext context;
        public CarsToUsersRepo(MagiCarContext context)
        {
            this.context = context;
        }
        public CarsToUser Add(CarsToUser c)
        {
            try
            {
                context.CarsToUsers.Add(c);
                context.SaveChanges();
                return c;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to add a new CarsToUsers🙁");
            }
        }

        public CarsToUser Delete(int id)
        {
            try
            {
                CarsToUser remove = context.CarsToUsers.FirstOrDefault(CarsToUser => CarsToUser.Id == id);
                context.CarsToUsers.Remove(remove);
                context.SaveChanges();
                return remove;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Failed to delete CarsToUser {id}🙁.");
            }
        }

        public List<CarsToUser> GetAll()
        {
            try
            {
                return context.CarsToUsers.ToList();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to get all the CarsToUsers🙁.");
            }
        }

        public CarsToUser GetById(int id)
        {
            try
            {
                return context.CarsToUsers.FirstOrDefault(CarsToUser => CarsToUser.Id == id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting a single CarsToUsers {id} data.");
            }
        }

        public CarsToUser Update(int id, CarsToUser c)
        {
            try
            {
                CarsToUser carsToUser = context.CarsToUsers.FirstOrDefault(CarsToUser => CarsToUser.Id == id);
                if (carsToUser != null)
                {
                    c.UserId = carsToUser.UserId;
                    c.CarId = carsToUser.CarId;
                }
                context.SaveChanges();
                return c;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to update the carsToUser🙁.");
            }
        }
    }
}
