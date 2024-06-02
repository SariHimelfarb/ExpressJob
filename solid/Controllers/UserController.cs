using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using solid.Core.Dtos;
using solid.Core.Models;
using solid.Core.Services;
using solid.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace solid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> Get()
        {
            var users = await _userService.GetAsync();
            var userDtos = _mapper.Map<IEnumerable<UserDto>>(users);
            return Ok(userDtos);
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> Get(int id)
        {
            var user = await _userService.GetAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var userDto = _mapper.Map<UserDto>(user);
            return Ok(userDto);
        }

        // POST: api/User
        [HttpPost]
        public async Task<ActionResult<UserDto>> Post([FromBody] UserPostModel userPostModel)
        {
            var userToAdd = _mapper.Map<User>(userPostModel);
            var createdUser = await _userService.PostAsync(userToAdd);
            var userDto = _mapper.Map<UserDto>(createdUser);
            return CreatedAtAction(nameof(Get), new { id = userDto.Id }, userDto);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UserPostModel userPostModel)
        {
            var existingUser = await _userService.GetAsync(id);
            if (existingUser == null)
            {
                return NotFound();
            }

            _mapper.Map(userPostModel, existingUser);
            await _userService.PutAsync(id, existingUser);

            return NoContent();
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existingUser = await _userService.GetAsync(id);
            if (existingUser == null)
            {
                return NotFound();
            }

            await _userService.DeleteAsync(id);
            return NoContent();
        }
    }
}
