using AutoMapper;
using Microsoft.EntityFrameworkCore;
using solid.Core.Dtos;
using solid.Core.Models;
using solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Data.Repositories
{
    public class JobRepository : IJobRepository
    {

        private readonly DataContext _context;
        public JobRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Job>> GetAsync()
        {
            //var jobList = _context.Jobs;
            //var dtoList = _mapper.Map<IEnumerable<JobDto>>(jobList);
            return await _context.Jobs.ToListAsync();
        }
        public async Task<Job> GetAsync(int id)
        {
            //var jobList = _context.Jobs;
            //var dtoList = _mapper.Map<IEnumerable<JobDto>>(jobList);
            return await _context.Jobs.FindAsync(id);
        }
        public async Task<Job> PostAsync(Job job)
        {
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
            return job;
        }

        public async Task PutAsync(int id, Job j)
        {
            var job = _context.Jobs.Find(id);
            job.Description = j.Description;
            job.Id = id;
            job.intervies = j.intervies;
            job.Category = j.Category;
            job.RequiredExperience = j.RequiredExperience;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var job = _context.Jobs.Find(id);
            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();
        }
    }
}


