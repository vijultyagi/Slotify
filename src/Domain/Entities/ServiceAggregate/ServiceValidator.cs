using FluentValidation;
using Slotify.Domain.Entities.ServiceAggreagate;

namespace Slotify.Domain.Entities.ServiceAggregate
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(s => s.Name)
                .NotEmpty().WithMessage("Service name is required.")
                .MaximumLength(100).WithMessage("Service name cannot exceed 100 characters.");

            RuleFor(s => s.Duration)
                .GreaterThan(0).WithMessage("Service duration must be greater than zero.");

            RuleFor(s => s.Price)
                .GreaterThan(0).WithMessage("Service price must be greater than zero.");
        }
        
    }
}