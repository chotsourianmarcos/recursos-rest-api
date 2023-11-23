using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Items
{
    public class ActivityItem
    {
        public int Id { get; set; }
        [JsonIgnore]
        public virtual ICollection<UserItem> Users { get; set; }
        public string Name { get; set; } = "";
        public string Day { get; set; } = "";
        public string Time { get; set; } = "";
    }
}
