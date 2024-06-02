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
    public class JobService:IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public async Task<IEnumerable<Job>> GetAsync()
        {
            return await _jobRepository.GetAsync();
        }

        public async Task<Job> GetAsync(int id)
        {
            return await _jobRepository.GetAsync(id);
        }

        public  async Task<Job> PostAsync(Job job)
        {
            return await _jobRepository.PostAsync(job);
        }
        
        public async Task PutAsync(int id, Job job)
        {
            await _jobRepository.PutAsync(id, job);
        }

        public async Task DeleteAsync(int id)
        {
            await _jobRepository.DeleteAsync(id);
        }

        
    }
}
