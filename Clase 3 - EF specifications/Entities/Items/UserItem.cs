using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Items
{
    public class UserItem
    {
        public UserItem()
        {
            Person = new PersonItem();
            Activities = new List<ActivityItem>();
        }
        public int Id { get; set; }
        public int PersonId { get; set; }
        public virtual PersonItem Person { get; set; }
        public virtual ICollection<ActivityItem> Activities { get; set; }
        public string UserName { get; set; } = "";
        public string UserEmail { get; set; } = "";

        [NotMapped]
        public string NotMappedExample { get; set; } = "";
    }
}