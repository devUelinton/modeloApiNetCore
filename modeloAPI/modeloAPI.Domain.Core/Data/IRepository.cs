using modeloAPI.Domain.Core.Domain;

namespace modeloAPI.Domain.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
    }
}
