using Entities.Items;
using Logic.IContext;
using Logic.ILogic;
using System.Linq.Expressions;

namespace Logic.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly ITransactionQuery _transactionQuery;
        private readonly IEntityQuery<UserItem> _userQuery;
        
        public UserLogic(ITransactionQuery transactionQuery,
                         IEntityQuery<UserItem> entityQuery)
        {
            _transactionQuery = transactionQuery;
            _userQuery = entityQuery;
        }
        public List<UserItem> GetAllUsers()
        {
            var users = _userQuery.GetAll();
            return users.ToList();
        }

        public List<UserItem> GetUsersByCriteria(Expression<Func<UserItem, bool>> funcPred)
        {
            var users = _userQuery.GetByCriteria(funcPred);
            return users.ToList();
        }

        public int InsertUser(UserItem userItem)
        {
            _userQuery.AddItem(userItem);
            _transactionQuery.ConfirmChanges();
            return userItem.Id;
        }
    }
}