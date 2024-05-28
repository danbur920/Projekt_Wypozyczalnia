using FluentValidation;
using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.Validations.Models
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(x => x.StartOfRental)
                .NotNull().WithMessage("Data początkowa wypożyczenia jest wymagana")
                .LessThan(x => x.EndOfRental).WithMessage("Data początkowa wypożyczenia nie może być późniejsza niż data zakończenia wypożyczenia.");

            RuleFor(x => x.EndOfRental)
                .NotNull().WithMessage("Data zakończenia wypożyczenia nie może być pusta.");

            RuleFor(x => x.VehicleId)
                .NotNull().WithMessage("Rezerwacja musi mieć przypisany identyfikator wypożyczanego pojazdu.");

            RuleFor(x => x.UserId)
                .NotNull().WithMessage("Rezerwacja musi mieć przypisany identyfikator wypożyczającego.");

            RuleFor(x => x.Price)
                .NotNull().WithMessage("Cena wypożyczenia musi być określona.");

            RuleFor(x => x.Price)
                .GreaterThanOrEqualTo(0).WithMessage("Cena wypożyczenia nie może być ujemna.");

        }
    }
}
