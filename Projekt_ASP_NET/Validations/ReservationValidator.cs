using FluentValidation;
using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.Validations
{
    public class ReservationValidator : AbstractValidator<Reservation>
    {
        public ReservationValidator()
        {
            RuleFor(x => x.StartOfRental)
                .NotNull().WithMessage("Data początkowa rezerwacji jest wymagana")
                .LessThan(x => x.EndOfRental).WithMessage("Data początkowa rezerwacji nie może być późniejsza niż data zakończenia rezerwacji.");

            RuleFor(x => x.EndOfRental)
                .NotNull().WithMessage("Data zakończenia rezerwacji nie może być pusta.");

            RuleFor(x => x.VehicleId)
                .NotNull().WithMessage("Rezerwacja musi mieć przypisany identyfikator wypożyczanego pojazdu.");

            RuleFor(x => x.UserId)
                .NotNull().WithMessage("Rezerwacja musi mieć przypisany identyfikator wypożyczającego.");
        }
    }
}
