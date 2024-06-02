using Microsoft.EntityFrameworkCore;
using solid.Core.Dtos;
using solid.Core.Models;
using solid.Core.Repositories;
using solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<User>> GetAsync()
        {
            return await _userRepository.GetAsync();
        }
        public async Task<User> GetAsync(int id)
        {
            return await _userRepository.GetAsync(id);
        }

        public async Task<User> PostAsync(User user)
        {
            return await _userRepository.PostAsync(user);
        }

        public async Task PutAsync(int id, User u)
        {
            await _userRepository.PutAsync(id, u);
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        
    }

}
