using DomainLayer.Entity;
using DomainLayer.Repository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class UserRespository : IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRespository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<User> CreateUser(User user)
        {
            await _dataContext.Users.AddAsync(user);
            await _dataContext.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetAllUser()
        {
            return await _dataContext.Users.ToListAsync();
        }

        public Task<User> GetUserById(int id)
        {
            var result = _dataContext.Users.FirstAsync(c=> c.userId == id);
            return result;
        }
    }
}
