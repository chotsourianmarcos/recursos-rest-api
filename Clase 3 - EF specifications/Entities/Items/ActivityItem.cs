using System.Text.Json.Serialization;
using Entities.CustomRelations;

namespace Entities.Items
{
    public class ActivityItem
    {
        public ActivityItem() 
        {
            Users = new List<UserItem>();
            Payments = new List<Payments>();
        }
        public int Id { get; set; }
        [JsonIgnore]
        public virtual ICollection<UserItem> Users { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
        public string Name { get; set; } = "";
        public string Day { get; set; } = "";
        public string Time { get; set; } = "";
    }
}