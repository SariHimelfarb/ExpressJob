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
        Task<IEnumerable<JobDto>> GetAsync();
        Task<Job> PostAsync(JobDto job);
    }
}
