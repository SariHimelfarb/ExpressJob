using Microsoft.AspNetCore.Mvc;
using solid.Core.Dtos;
using solid.Core.Models;
using solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace solid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }


        // GET: api/<InterviewController>
        [HttpGet]
        public async Task<IEnumerable<JobDto>> GetAsync()
        {
            return await _jobService.GetAsync();
        }

        //        // GET: api/<JobController>
        //        [HttpGet]
        //        public IEnumerable<string> Get()
        //        {
        //            return new string[] { "value1", "value2" };
        //        }

        //        // GET api/<JobController>/5
        //        [HttpGet("{id}")]
        //        public string Get(int id)
        //        {
        //            return "value";
        //        }

        // POST api/<JobController>
        [HttpPost]
        public async Task<Job> PostAsync(JobDto job)
        {
            return await _jobService.PostAsync(job);
        }

        //        // PUT api/<JobController>/5
        //        [HttpPut("{id}")]
        //        public void Put(int id, [FromBody] string value)
        //        {
        //        }

        //        // DELETE api/<JobController>/5
        //        [HttpDelete("{id}")]
        //        public void Delete(int id)
        //        {
        //        }
    }
}
