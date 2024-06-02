using Microsoft.EntityFrameworkCore;
using solid.Core.Dtos;
using solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Core.Repositories
{
    public interface IJobRepository
    {
        public Task<IEnumerable<Job>> GetAsync();
        public Task<Job> GetAsync(int id);
        public Task<Job> PostAsync(Job job);
        public Task PutAsync(int id, Job job);
        public Task DeleteAsync(int id);
    }
}
