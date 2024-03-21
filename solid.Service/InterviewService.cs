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
        public async Task<IEnumerable<InterviewDto>> GetAsync()
        {
            return await _interviewRepository.GetAsync();
        }

        public async Task<Interview> PostAsync(InterviewDto interview)
        {
            return await _interviewRepository.PostAsync(interview);
        }

    }
}
