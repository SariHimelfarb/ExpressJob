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
        private readonly IMapper _mapper;
        public JobRepository(DataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<JobDto>> GetAsync()
        {
            var jobList = _context.Jobs;
            var dtoList = _mapper.Map<IEnumerable<JobDto>>(jobList);
            return await Task.FromResult(dtoList);
        }
        public async Task<Job> PostAsync(JobDto job)
        {
            var jobEntity = _mapper.Map<Job>(job);
            _context.Jobs.Add(jobEntity);
            await _context.SaveChangesAsync();
            return jobEntity;
        }
    }
}


