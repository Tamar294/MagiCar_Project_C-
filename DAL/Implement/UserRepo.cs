using Dal.Api;
using Dal.Models;
using System.Diagnostics;

namespace Dal.Implement
{
    public class UserRepo : IUserRepo
    {
        MagiCarContext context;
        public UserRepo(MagiCarContext context)
        {
            this.context = context;
        }

        public User Add(User u)
        {
            try
            {
                context.Users.Add(u);
                context.SaveChanges();
                return u;

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
                List<User> users = context.Users.ToList();
                foreach (var user in users)
                {
                    user.AddressCode = context.Addresses.FirstOrDefault(add => add.Id == user.AddressCode).Id;
                }
                return users;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception(ex.ToString());
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

<<<<<<< HEAD
        public User Update(User t, int id)
=======
        public User Update(User t)
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394
        {
            try
            {
                User u = context.Users.FirstOrDefault(user => user.UserId == t.UserId);
                if (u != null)
                {
                    u.Name = t.Name;
                    u.Email = t.Email;
                    u.Password = t.Password;
                    u.PhoneNumber = t.PhoneNumber;
                    u.AddressCode = t.AddressCode;
                    u.PaymentCode = t.PaymentCode;
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
