using AutoMapper;
using Microsoft.EntityFrameworkCore;
using solid.Core.Models;
using solid.Core.Repositories;
using solid.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid.Core.Dtos;

namespace solid.Data.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<User>> GetAsync()
        {
            return await _context.Users.ToListAsync();
        }
        public async Task<User> GetAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }


        public async Task<User> PostAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task PutAsync(int id, User u)
        {
            var user = _context.Users.Find(id);
            user.Category = u.Category;
            user.Name = u.Name;
            user.Interviews = u.Interviews;
            user.Experience = u.Experience;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

    }
}
