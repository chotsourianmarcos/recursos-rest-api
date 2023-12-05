using System.Linq.Expressions;

namespace Logic.IContext
{
    public interface IEntityQuery<Item>
    {
        IQueryable<Item> GetAll();
        IQueryable<Item> GetAllUntracked();
        IQueryable<Item> GetByCriteria(Expression<Func<Item, bool>> funcPred);
        IQueryable<Item> GetByCriteriaUntracked(Expression<Func<Item, bool>> funcPred);
        List<Item> ToList(IQueryable<Item> itemsList);
        Item? GetFirstOrDefault(Expression<Func<Item, bool>> funcPred);
        Item? GetFirstOrDefaultUntracked(Expression<Func<Item, bool>> funcPred);
        void AddItem(Item item);
        void AddItems(List<Item> itemsList);
        void UpdateItem(Item item);
        void UpdateItems(List<Item> itemsList);
        void DeleteItem(Item item);
        void DeleteItems(List<Item> itemsList);
    }
}