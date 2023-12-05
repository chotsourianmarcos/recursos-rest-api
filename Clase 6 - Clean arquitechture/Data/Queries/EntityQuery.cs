using Logic.IContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Queries
{
    public class EntityQuery<T> : IEntityQuery<T>
        where T : class
    {
        private readonly SchedulerContext _serviceContext;
        public EntityQuery(SchedulerContext serviceContext)
        {
            _serviceContext = serviceContext;
        }
        public void AddItem(T item)
        {
            _serviceContext.Set<T>().Add(item);
        }
        public void AddItems(List<T> itemsList)
        {
            _serviceContext.Set<T>().AddRange(itemsList);
        }
        public void DeleteItem(T item)
        {
            _serviceContext.Set<T>().Remove(item);
        }
        public void DeleteItems(List<T> itemsList)
        {
            _serviceContext.Set<T>().RemoveRange(itemsList);
        }
        public  T? GetFirstOrDefaultUntracked(Expression<Func<T, bool>> funcPred)
        {
            return _serviceContext.Set<T>().Where(funcPred).AsNoTracking().FirstOrDefault();
        }
        public void UpdateItem(T item)
        {
            _serviceContext.Set<T>().Update(item);
        }
        public void UpdateItems(List<T> itemsList)
        {
            _serviceContext.Set<T>().UpdateRange(itemsList);
        }
        public IQueryable<T> GetAll()
        {
            return _serviceContext.Set<T>();
        }
        public IQueryable<T> GetAllUntracked()
        {
            return _serviceContext.Set<T>().AsNoTracking();
        }
        public IQueryable<T> GetByCriteria(Expression<Func<T, bool>> funcPred)
        {
            return _serviceContext.Set<T>().Where(funcPred);
        }
        public IQueryable<T> GetByCriteriaUntracked(Expression<Func<T, bool>> funcPred)
        {
            return _serviceContext.Set<T>().Where(funcPred).AsNoTracking();
        }
        public List<T> ToList(IQueryable<T> itemsList)
        {
            return itemsList.ToList();
        }
        public T? GetFirstOrDefault(Expression<Func<T, bool>> funcPred)
        {
            return _serviceContext.Set<T>().Where(funcPred).FirstOrDefault();
        }
    }
}
