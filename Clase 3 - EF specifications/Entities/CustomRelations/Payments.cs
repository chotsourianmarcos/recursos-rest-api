using Entities.Items;
using System.Text.Json.Serialization;

namespace Entities.CustomRelations
{
    public class Payments
    {
        public Payments() 
        {
            Activity = new ActivityItem();
            Quota = new QuotaItem();
        }
        public int Id { get; set; }
        public int ActivityId { get; set; }
        [JsonIgnore]
        public virtual ActivityItem Activity { get; set; }
        public int QuotaId { get; set; }

        [JsonIgnore]
        public virtual QuotaItem Quota { get; set;}
        public DateTime PaymentDate { get; set; }
    }
}