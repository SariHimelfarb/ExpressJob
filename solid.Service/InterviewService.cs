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
    public class InterviewService:IInterviewService
    {
        private readonly IInterviewRepository _interviewRepository;

        public InterviewService(IInterviewRepository interviewRepository)
        {
            _interviewRepository =interviewRepository ;
        }
        public async Task<IEnumerable<Interview>> GetAsync()
        {
            return await _interviewRepository.GetAsync();
        }

        public async Task<Interview> GetAsync(int id)
        {
            return await _interviewRepository.GetAsync(id);
        }
        public async Task<Interview> PostAsync(Interview interview)
        {
            return await _interviewRepository.PostAsync(interview);
        }
       
        public async Task PutAsync(int id,  Interview interview)
        {
            await _interviewRepository.PutAsync(id, interview);
        }

        public async Task DeleteAsync(int id)
        {
            await _interviewRepository.DeleteAsync(id);
        }


    }
}
