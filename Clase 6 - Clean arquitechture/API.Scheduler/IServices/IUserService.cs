using Entities.Filters;
using Entities.Items;
using Entities.RequestModels;

namespace API.Scheduler.IServices
{
    public interface IUserService
    {
        int RegisterNewUser(NewUserRequest newUserRequest);
        List<UserItem> GetAllUsers();
        List<UserItem> GetUsersByCriteria(UserFilter filter);
    }
}