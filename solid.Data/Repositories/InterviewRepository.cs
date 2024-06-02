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
        public InterviewRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Interview>> GetAsync()
        {
            return await _context.Interviews.ToListAsync();

        }
        public async Task<Interview> GetAsync(int id)
        {
            return await _context.Interviews.FindAsync(id);

        }

        public async Task<Interview> PostAsync(Interview interview)
        {
            _context.Interviews.Add(interview);
            await _context.SaveChangesAsync();
            return interview;
        }

        public async Task PutAsync(int id, Interview inter)
        {
            var interview = _context.Interviews.Find(id);
            interview.CurrentJob = inter.CurrentJob;
            interview.Date = inter.Date;
            interview.Id = inter.Id;
            interview.User = inter.User;
            interview.UserId = inter.UserId;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var inter = _context.Interviews.Find(id);
            _context.Interviews.Remove(inter);
            await _context.SaveChangesAsync();
        }
    }
}


