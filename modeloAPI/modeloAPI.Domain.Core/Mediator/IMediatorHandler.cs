using FluentValidation.Results;
using modeloAPI.Domain.Core.Messaging;

namespace modeloAPI.Domain.Core.Mediator
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T @event) where T : Event;
        Task<ValidationResult> SendCommand<T>(T command) where T : Command;
    }
}
