using Data;
using Entities.Items;
using Logic.ILogic;
using Microsoft.EntityFrameworkCore;
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
            //return _schedulerContext.Users.ToList();
            return _schedulerContext.Users.Include(u => u.Person).ToList();
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