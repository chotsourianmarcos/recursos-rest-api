using Entities.CustomRelations;

namespace Entities.Items
{
    public class QuotaItem
    {
        public QuotaItem() 
        {
            Payments = new List<Payments>();
        }
        public int Id { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
        public decimal Price { get; set; }
    }
}