using FluentValidation;

namespace Slotify.Domain.Entities.StylistAggregate
{
    public class StylistValidator : AbstractValidator<Stylist>
    {
        public StylistValidator()
        {
            RuleFor(stylist => stylist.Name)
                .NotEmpty().WithMessage("Stylist name cannot be empty.")
                .MaximumLength(100).WithMessage("Stylist name cannot exceed 100 characters.");

            RuleFor(stylist => stylist.Email)
                .NotEmpty().WithMessage("Email cannot be empty.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(stylist => stylist.Availability)
                .InclusiveBetween(0, 1).WithMessage("Availability must be between 0 and 1.");

            RuleFor(stylist => stylist.Services)
                .NotEmpty().WithMessage("Stylist must offer at least one service.");

            RuleFor(stylist => stylist.DaysOff)
                .NotNull().WithMessage("Days off cannot be null.");
        }
    }
}