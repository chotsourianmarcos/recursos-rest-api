using API.Scheduler.IServices;
using Entities.Items;
using Entities.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace API.Scheduler.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) {
            _userService = userService;
        }

        [HttpPost(Name = "InsertUser")]
        public int InsertUser(NewUserRequest newUserRequest)
        {
            return _userService.RegisterNewUser(newUserRequest);
        }
        [HttpGet(Name="GetAllUsers")]
        public List<UserItem> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }
    }
}