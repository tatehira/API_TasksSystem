using Microsoft.AspNetCore.Mvc;
using SistemasTarefas.Models;
using TasksSystem.Repository.Interfaces;

namespace TasksSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> FindAllUsers(); 
        {
            List<UserModel> Users = await _userRepository.FindAllUsers();
            return Ok(Users);
        }
    }
}
