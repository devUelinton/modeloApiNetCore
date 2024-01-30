using modeloAPI.Domain.Core.Messaging;

namespace modeloAPI.Domain.Core.Domain
{
    public abstract class Entity
    {
        private List<Event> _domainEvents;

        protected Entity() => Id = Guid.NewGuid();

        public Guid Id { get; set; }

        public IReadOnlyCollection<Event>? DomainEvents
        {
            get
            {
                List<Event> domainEvents = _domainEvents;
                return domainEvents == null ? null : (IReadOnlyCollection<Event>)domainEvents.AsReadOnly();
            }
        }

        public void AddDomainEvent(Event domainEvent)
        {
            _domainEvents = _domainEvents ?? new List<Event>();
            _domainEvents.Add(domainEvent);
        }

        public void RemoveDomainEvent(Event domainEvent) => _domainEvents?.Remove(domainEvent);

        public void ClearDomainEvents() => _domainEvents?.Clear();

        public override bool Equals(object obj)
        {
            Entity? entity = obj as Entity;

            if (this == (object)entity)
                return true;
            return (object)entity != null && Id.Equals(entity.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if ((object)a == null && (object)b == null)
                return true;
            return a is not null && (object)b != null && a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b) => !(a == b);

        public override int GetHashCode() => (GetType().GetHashCode() ^ 93) + Id.GetHashCode();

        public override string ToString() => string.Format("{0} [Id={1}]", GetType().Name, Id);
    }
}

