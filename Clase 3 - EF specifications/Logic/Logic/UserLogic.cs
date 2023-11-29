using Data;
using Entities.Items;
using Logic.ILogic;
using Microsoft.EntityFrameworkCore;

namespace Logic.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly SchedulerContext _schedulerContext;
        public UserLogic(SchedulerContext schedulerContext)
        {
            _schedulerContext = schedulerContext;
        }
        public List<UserItem> GetAllUsers()
        {
            //return _schedulerContext.Users.ToList();
            //return _schedulerContext.Users.Include(u => u.Person).ToList();

            var queryResult = from Users in _schedulerContext.Users
                              select Users;
            var result = queryResult.ToList();
            return result;
        }

        //public List<Tuple<UserItem, int>> GetUserActivitiesAmount()
        //{
        //    var users = _schedulerContext.Set<UserItem>();
        //    var result = users.Select(u => new Tuple<UserItem, int>(u, u.Activities.Count));
        //    return result.ToList();
        //}

        public int InsertUser(UserItem userItem)
        {
            _schedulerContext.Users.Add(userItem);
            _schedulerContext.SaveChanges();
            return userItem.Id;
        }
    }
}