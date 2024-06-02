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
    public interface IInterviewRepository
    {
        public Task<IEnumerable<Interview>> GetAsync();
        public Task<Interview> GetAsync(int id);
        public Task<Interview> PostAsync(Interview interview);
        public Task PutAsync(int id, Interview interview);
        public Task DeleteAsync(int id);
    }
}
