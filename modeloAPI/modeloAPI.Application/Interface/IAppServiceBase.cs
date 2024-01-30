using FluentValidation.Results;

namespace modeloAPI.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(Guid id);

    }
}
