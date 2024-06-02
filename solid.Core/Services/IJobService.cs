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
    public interface IJobService
    {
        public Task<IEnumerable<Job>> GetAsync();
        public Task<Job> GetAsync(int id);
        public Task<Job> PostAsync(Job user);
        public Task PutAsync(int id, Job user);
        public Task DeleteAsync(int id);
    }
}
