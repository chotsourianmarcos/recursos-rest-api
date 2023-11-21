using Data;
using Entities.Items;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return _schedulerContext.Users.ToList();
        }

        public int InsertUser(UserItem userItem)
        {
            _schedulerContext.Users.Add(userItem);
            _schedulerContext.SaveChanges();
            return userItem.Id;
        }
    }
}