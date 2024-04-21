using FluentValidation;
using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.Validations.Models
{
    public class BranchValidator : AbstractValidator<Branch>
    {
        public BranchValidator()
        {
            RuleFor(x => x.Locality)
                 .NotNull().WithMessage("Lokalizacja punktu wypożyczeń jest wymagana");

            RuleFor(x => x.NumberOfVehicles)
                .NotNull().WithMessage("Liczba pojazdów jest wymagana.")
                .GreaterThanOrEqualTo(0).WithMessage("Liczba pojazdów nie może być ujemna.");

            RuleFor(x => x.UserId)
                .NotNull().WithMessage("Punkt wypożyczeń musi posiadać zarządce.");
        }
    }
}


