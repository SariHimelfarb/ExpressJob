using Microsoft.AspNetCore.Mvc;
using solid.Core.Models;
using solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace restfullProject.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {


        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        
        // GET: api/<InterviewController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetAll();
        }

        // GET api/<InterviewController>/5
        //[HttpGet("{id}")]
        //public Interview Get(int id)
        //{
        //    return 1;
        //}


        //// POST api/<InterviewController>
        //[HttpPost]
        //public void Post([FromBody] Interview interview)
        //{
        //    _dataContext.Interviews.Add(interview);
        //}

        //// PUT api/<InterviewController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Interview interview)
        //{
        //    Interview i = _dataContext.Interviews.Find(i => i.Id == id);
        //    if (i != null)
        //    {
        //        i.CurrentJob = interview.CurrentJob;
        //        i.Date = interview.Date;
        //        i.Employee = interview.Employee;
        //    }
        //    else
        //        _dataContext.Interviews.Add(i);
        //}

        //// DELETE api/<InterviewController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    Interview i = _dataContext.Interviews.Find(i => i.Id == id);
        //    _dataContext.Interviews.Remove(i);
        //}

    }
}
