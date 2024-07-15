using Dal.Api;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Implement
{
    public class RentalHistoryRepo : IRentalHistoryRepo
    {
        MagiCarContext context;
        public RentalHistoryRepo(MagiCarContext context)
        {
            this.context = context;
        }

        public RentalHistory Add(RentalHistory r)
        {
            try
            {
                context.RentalHistories.Add(r);
                context.SaveChanges();
                return r;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to add a new RentalHistory🙁");
            }
        }

        public RentalHistory Delete(int id)
        {
            try
            {
                RentalHistory remove = context.RentalHistories.FirstOrDefault(rentalHistory => rentalHistory.Id == id);
                context.RentalHistories.Remove(remove);
                context.SaveChanges();
                return remove;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Failed to delete rentalHistory {id}🙁.");
            }
        }

        public List<RentalHistory> GetAll()
        {
            try
            {
                return context.RentalHistories.ToList();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to get all the rentalHistory🙁.");
            }
        }

        public RentalHistory GetById(int id)
        {
            try
            {
                return context.RentalHistories.FirstOrDefault(rentalHistory => rentalHistory.Id == id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting a single RentalHistory {id} data.");
            }
        }

<<<<<<< HEAD
        public RentalHistory Update(RentalHistory r, int id)
=======
        public RentalHistory Update(RentalHistory r)
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
        {
            try
            {
                RentalHistory rentalHistory = context.RentalHistories.FirstOrDefault(rentalHistory => rentalHistory.Id == r.Id);
                if (rentalHistory != null)
                {
                    rentalHistory.CarCode = r.CarCode;
                    rentalHistory.UserCode = r.UserCode;
                    rentalHistory.StartTime = r.StartTime;
                    rentalHistory.EndTime = r.EndTime;
                }
                context.SaveChanges();
                return r;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to update the rentalHistory🙁.");
            }
        }
    }
}
