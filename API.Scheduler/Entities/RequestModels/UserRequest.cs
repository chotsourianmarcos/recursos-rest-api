using Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RequestModels
{
    public class NewUserRequest
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public UserItem ToUserItem()
        {
            var userItem = new UserItem();

            userItem.Name = Name;
            userItem.LastName = LastName;

            return userItem;
        }
    }
}
