using Entities.Items;

namespace Logic.ILogic
{
    public interface IUserLogic
    {
        int InsertUser(UserItem userItem);
        List<UserItem> GetAllUsers();
    }
}