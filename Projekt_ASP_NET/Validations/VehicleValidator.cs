using FluentValidation;
using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.Validations
{
    public class VehicleValidator : AbstractValidator<Vehicle>
    {
        public VehicleValidator()
        {
            RuleFor(x => x.Name)
               .NotNull().WithMessage("Nazwa pojazdu jest wymagana.");

            RuleFor(x => x.PricePerDay)
                .NotNull().WithMessage("Cena za dzień jest wymagana.")
                .GreaterThanOrEqualTo(0).WithMessage("Cena nie może być ujemna.");

            RuleFor(x => x.PricePerHour)
                .NotNull().WithMessage("Cena za godzinę jest wymagana.")
                .GreaterThanOrEqualTo(0).WithMessage("Cena nie może być ujemna.");

            RuleFor(x => x.PricePerMonth)
                .NotNull().WithMessage("Cena za miesiąc jest wymagana.")
                .GreaterThanOrEqualTo(0).WithMessage("Cena nie może być ujemna.");

            RuleFor(x => x.BranchId)
                .NotNull().WithMessage("Pojazd musi posiadać swoją lokalizację.");

            RuleFor(x => x.Brand)
                .NotNull().WithMessage("Pojazd musi posiadać markę.");

            RuleFor(x => x.Type)
                .NotNull().WithMessage("Pojazd musi mieć określony typ.");
        }
    }
}
