using Microsoft.EntityFrameworkCore;
using solid.Core.Dtos;
using solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Core.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetAsync();
        public Task<User> GetAsync(int id);
        public Task<User> PostAsync(User user);
        public Task PutAsync(int id, User user);
        public Task DeleteAsync(int id);
    }
}
