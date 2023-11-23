using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Items
{
    public class UserItem
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public virtual PersonItem Person { get; set; }
        public virtual ICollection<ActivityItem> Activities { get; set; }
        public string UserName { get; set; } = "";
        public string UserEmail { get; set; } = "";

        //[NotMapped]
        //public string NotMappedExample { get; set; }

        //many to many con atributos extra - automática! o con clase tercera?

        //this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

        //nullear o no virtual navigation attributes
    }
}
