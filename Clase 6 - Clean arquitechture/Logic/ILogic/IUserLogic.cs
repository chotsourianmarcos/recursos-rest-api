using Entities.Filters;
using Entities.Items;
using System.Linq.Expressions;

namespace Logic.ILogic
{
    public interface IUserLogic
    {
        int InsertUser(UserItem userItem);
        List<UserItem> GetAllUsers();
        List<UserItem> GetUsersByCriteria(Expression<Func<UserItem, bool>> funcPred);
    }
}