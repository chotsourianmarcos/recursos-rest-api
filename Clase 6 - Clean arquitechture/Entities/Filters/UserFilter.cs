using Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Filters
{
    public class UserFilter
    {
        public int MinId { get; set; }
        public int MaxId { get; set; }
        public string UserName { get; set; }
        //fix
        public Expression<Func<UserItem, bool>> ToFunction()
        {
            return (u =>
            (MinId > 0 && u.Id > MinId) &&
            (MaxId > 0 && u.Id < MaxId) &&
            u.UserName.Contains(UserName));
        }
    }
}
