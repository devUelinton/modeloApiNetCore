namespace modeloAPI.Domain.Adapters.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(Guid id);
    }
}

