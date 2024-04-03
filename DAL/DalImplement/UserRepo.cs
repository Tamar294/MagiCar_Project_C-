using Dal.DalApi;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementations
{
    public class UserRepo : IUserRepo
    {
        MagiCarContext context;
        public UserRepo(MagiCarContext context)
        {
            this.context = context;
        }

        public User Add(User t)
        {
            try
            {
                context.Users.Add(t);
                context.SaveChanges();
                return t;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to add a new user🙁");
            }
        }

        public User Delete(int id)
        {
            try
            {
                User remove = context.Users.FirstOrDefault(user => user.UserId == id);
                context.Users.Remove(remove);
                context.SaveChanges();
                return remove;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Failed to delete user {id}🙁.");
            }
        }

        public List<User> GetAll()
        {
            try
            {
                return context.Users.ToList();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to get all the users🙁.");
            }
        }

        public User GetById(int id)
        {
            try
            {
                return context.Users.FirstOrDefault(user => user.UserId == id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting a single user {id} data.");
            }
        }

        public User Update(int id, User t)
        {
            try
            {
                User u = context.Users.FirstOrDefault(user => user.UserId == id);
                if (u != null) 
                {
                    u.Name = t.Name;
                    u.Email = t.Email;
                    u.Password = t.Password;
                    u.Address = t.Address;
                    u.PhoneNumber = t.PhoneNumber;
                    u.CreditCard = t.CreditCard;
                }
                context.SaveChanges();
                return t;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to update the user🙁.");
            }
        }
    }
}
