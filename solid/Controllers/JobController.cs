using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using solid.Core.Dtos;
using solid.Core.Models;
using solid.Core.Services;
using solid.Models;
using solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace solid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;
        private readonly IMapper _mapper;

        public JobController(IJobService jobService, IMapper mapper)
        {
            _jobService = jobService;
            _mapper = mapper;
        }

        // GET: api/Job
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobDto>>> Get()
        {
            var jobs = await _jobService.GetAsync();
            var jobDtos = _mapper.Map<IEnumerable<JobDto>>(jobs);
            return Ok(jobDtos);
        }

        // GET: api/Job/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobDto>> Get(int id)
        {
            var job = await _jobService.GetAsync(id);
            if (job == null)
            {
                return NotFound();
            }
            var jobDto = _mapper.Map<JobDto>(job);
            return Ok(jobDto);
        }

        // POST: api/Job
        [HttpPost]
        public async Task<ActionResult<JobDto>> Post([FromBody] JobPostModel jobPostModel)
        {
            var jobToAdd = _mapper.Map<Job>(jobPostModel);
            await _jobService.PostAsync(jobToAdd);
            var jobDto = _mapper.Map<JobDto>(jobToAdd);
            return CreatedAtAction(nameof(Get), new { id = jobDto.Id }, jobDto);

        }

        // PUT: api/Job/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] JobPostModel jobPostModel)
        {
            var existingJob = await _jobService.GetAsync(id);
            if (existingJob == null)
            {
                return NotFound();
            }

            _mapper.Map(jobPostModel, existingJob);
            await _jobService.PutAsync(id, existingJob);

            return NoContent();
        }

        // DELETE: api/Job/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existingJob = await _jobService.GetAsync(id);
            if (existingJob == null)
            {
                return NotFound();
            }

            await _jobService.DeleteAsync(id);
            return NoContent();
        }
    }
}
