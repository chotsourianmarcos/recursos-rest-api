using API.Scheduler.IServices;
using Entities.Filters;
using Entities.Items;
using Entities.RequestModels;
using Logic.ILogic;

namespace API.Scheduler.Services
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        public UserService(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        public List<UserItem> GetAllUsers()
        {
            return _userLogic.GetAllUsers();
        }

        public List<UserItem> GetUsersByCriteria(UserFilter filter)
        {
            return _userLogic.GetUsersByCriteria(filter.ToFunction());
        }

        public int RegisterNewUser(NewUserRequest newUserRequest)
        {
            var newUser = newUserRequest.ToUserItem();
            return _userLogic.InsertUser(newUser);
        }
    }
}