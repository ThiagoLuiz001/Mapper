

namespace Mapper.Domain.Interfaces
{
    public interface IQuery<T, K>
    {
        public T SelectByConditionAsync(Func<T,bool> condition);
        public List<T> SelectAllByConditionAsync(Func<T, bool> condition);
        public bool ExistByConditionAsync(Func<T, bool> condition);
        public void InsertAsync(T entity);
        public void UpdateAsync(T entity);
        public void DeleteAsync(T entity);
        public void DeleteById(K id);
        public void DeleteByConditionAsync(Func<T,bool> condition);
    }
}
