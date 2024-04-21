using FluentValidation;
using Projekt_ASP_NET.ViewModels;

namespace Projekt_ASP_NET.Validations.ViewModels
{
    public class BranchViewModelValidator : AbstractValidator<BranchViewModel>
    {
        public BranchViewModelValidator()
        {
            RuleFor(x => x.Branch.Locality)
                    .NotNull().WithMessage("Lokalizacja punktu wypożyczeń jest wymagana");

            RuleFor(x => x.Branch.NumberOfVehicles)
                    .NotNull().WithMessage("Liczba pojazdów jest wymagana.")
                    .GreaterThanOrEqualTo(0).WithMessage("Liczba pojazdów nie może być ujemna.");

            RuleFor(x => x.Branch.UserId)
                    .NotNull().WithMessage("Punkt wypożyczeń musi posiadać zarządce.");
        }
    }
}
