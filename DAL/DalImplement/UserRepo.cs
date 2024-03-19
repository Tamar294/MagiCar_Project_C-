using Dal.Interfaces;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repo
{
    public class UserRepo : IUserRepo
    {
        MagiCarContext context;
        public UserRepo(MagiCarContext context)
        {
            this.context = context;
        }
        public async Task<User> AddAsync(User entity)
        {
            try
            {
                context.Users.Add(entity);
                await context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to add a new user🙁");
            }
        }

        public async Task<User> DeleteAsync(int id)
        {
            try
            {
                User user = await context.Users.FirstOrDefaultAsync(user => user.UserId == id);
                if (user != null)
                {
                    context.Users.Remove(user);
                }
                await context.SaveChangesAsync();
                return user;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Failed to delete user {id}.");
            }
        }

        public async Task<List<User>> GetAllAsync()
        {
            try
            {
                List<User> users = await context.Users.ToListAsync();
                return users;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine($"Exception in GetAllAsync: {ex}");
                throw new Exception("Failed to get all the users🙁", ex);
                throw new Exception("Failed to get all the users🙁.");
            }
        }

        public async Task<User> GetSingleAsync(int id)
        {
            try
            {
                return await context.Users
                                    .Where(user => user.UserId == id)
                                    .FirstOrDefaultAsync();                         
            }
            catch(Exception ex) 
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting a single user {id} data.");
            }
        }
        public async Task<User> UpdateAsync(User entity)
        {
            try
            {
                var user = await context.Users.FindAsync(entity.UserId);
                if (user != null)
                {
                    user.Name = entity.Name;
                    user.Password = entity.Password;
                    user.Email = entity.Email;
                    user.PhoneNumber = entity.PhoneNumber;
                    user.Address = entity.Address;
                    user.CreditCard = entity.CreditCard;
                }
                await context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to update the user🙁.");
            }
        }
    }
}
