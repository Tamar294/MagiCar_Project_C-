using Bl.Api;
using Bl.DTO;
using Dal;
using Dal.Implement;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Implement
{
    public class UserService : IUserService
    {
        UserRepo users;
        public UserService(DalManager manager) 
        {
            this.users = manager.userRepo;
        }

        public UserDTO Add(UserDTO t)
        {
            throw new NotImplementedException();
        }

        public UserDTO Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public UserDTO Update(int Id, UserDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
