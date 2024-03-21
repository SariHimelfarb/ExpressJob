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
    public class InterviewRepository : IInterviewRepository
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public InterviewRepository(DataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //public async Task<IEnumerable<InterviewDto>> GetAsync()
        //{
        //    var interviews = _context.Interviews.Include(i => i.User);
        //    var interviewsDto = _mapper.Map<IEnumerable<InterviewDto>>(interviews);
        //    return await Task.FromResult(interviewsDto);
            
        //}
        public async Task<IEnumerable<InterviewDto>> GetAsync()
        {
            var interviews = await _context.Interviews.Include(i => i.User).ToListAsync(); // Use ToListAsync for async retrieval
            var interviewsDto = _mapper.Map<IEnumerable<InterviewDto>>(interviews);
            return interviewsDto;
        }

        public async Task<Interview> PostAsync(InterviewDto interview)
        {
            var inter = _mapper.Map<Interview>(interview);
            _context.Interviews.Add(inter);
            await _context.SaveChangesAsync();
            return inter;
        }
    }
}


