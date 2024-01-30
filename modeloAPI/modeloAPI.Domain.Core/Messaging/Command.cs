using FluentValidation.Results;
using MediatR;

namespace modeloAPI.Domain.Core.Messaging
{
    public abstract class Command : Message, IRequest<ValidationResult>, IBaseRequest
    {
        public DateTime TimeStamp { get; set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
            ValidationResult = new ValidationResult();
        }

        public virtual bool IsValid()
        {
            return ValidationResult.IsValid;
        }
    }
}
