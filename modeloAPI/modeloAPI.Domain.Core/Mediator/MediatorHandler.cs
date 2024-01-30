using FluentValidation.Results;
using MediatR;
using modeloAPI.Domain.Core.Messaging;

namespace modeloAPI.Domain.Core.Mediator
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator) => _mediator = mediator;

        public virtual async Task<ValidationResult> SendCommand<T>(T command) where T : Command => await _mediator.Send((IRequest<ValidationResult>)command, new CancellationToken());

        public virtual async Task PublishEvent<T>(T @event) where T : Event => await _mediator.Publish(@event, new CancellationToken());
    }
}
