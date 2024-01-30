using modeloAPI.Domain.Core.Messaging;

namespace modeloAPI.Domain.Core.Events
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}
