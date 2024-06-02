using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using solid.Core.Models;
using solid.Core.Services;
using solid.Core;
using solid.Core.Dtos;
using solid.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace solid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController : ControllerBase
    {
        private readonly IInterviewService _interviewService;
        private readonly IMapper _mapper;

        public InterviewController(IInterviewService interviewService, IMapper mapper)
        {
            _interviewService = interviewService;
            _mapper = mapper;
        }


        // GET: api/<InterviewController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InterviewDto>>> Get()
        {
            var list = await _interviewService.GetAsync();
            var listDto = _mapper.Map<IEnumerable<InterviewDto>>(list);
            return Ok(listDto);
        }

        // GET: api/<ValuesController>
        [HttpGet("{id}")]
        public async Task<ActionResult<Interview>> Get(int id)
        {
            var inter = await _interviewService.GetAsync(id);
            var interDto = _mapper.Map<InterviewDto>(inter);
            return Ok(interDto);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<Interview>> Post([FromBody] InterviewPostModel e)
        {
            var interToAdd = _mapper.Map<Interview>(e); // Use the mapping configuration from APIMappingProfile
            await _interviewService.PostAsync(interToAdd);
            var interDto = _mapper.Map<InterviewDto>(interToAdd);
            return Ok(interDto);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] InterviewPostModel e)
        {
            Interview existInter = await _interviewService.GetAsync(id);

            if (existInter == null)
            {
                return NotFound();
            }

            _mapper.Map(e, existInter);

            await _interviewService.PutAsync(id, existInter);

            return Ok(_mapper.Map<InterviewDto>(existInter));
        }


        // DELETE api/<InterviewController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _interviewService.DeleteAsync(id);
        }

    }
}
