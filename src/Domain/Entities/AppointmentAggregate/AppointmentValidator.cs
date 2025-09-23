using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Slotify.Domain.Entities.AppointmentAggregate;

namespace Domain.Entities.AppointmentAggregate
{
    public class AppointmentValidator : AbstractValidator<Appointment>
    {
        public AppointmentValidator()
        {
            RuleFor(appointment => appointment.CustomerId)
                .NotEmpty().WithMessage("Customer ID is required.");

            RuleFor(appointment => appointment.StartTime)
                .NotEmpty()
                .Must(appointment => appointment != default)
                .WithMessage("Start time is required.");

            RuleFor(appointment => appointment.StartTime)
                .GreaterThan(DateTime.UtcNow)
                .WithMessage("Start time must be in the future.");

            RuleFor(appointment => appointment.EndTime)
                .NotEmpty()
                .Must(appointment => appointment != default)
                .WithMessage("End time is required.");

            RuleFor(appointment => appointment.EndTime)
                .GreaterThan(appointment => appointment.StartTime)
                .WithMessage("End time must be after start time.");

            RuleFor(appointment => appointment.Status)
                .IsInEnum()
                .WithMessage("Invalid appointment status.");

            RuleFor(appointment => appointment.Service)
                .NotNull().WithMessage("Service details are required.");
        }
    }
}