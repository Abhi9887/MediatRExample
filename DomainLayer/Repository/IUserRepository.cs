using DomainLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Repository
{
    public interface IUserRepository
    {
        Task<User> CreateUser(User user);
        Task<List<User>> GetAllUser();
        Task<User> GetUserById(int id);
    }
}
