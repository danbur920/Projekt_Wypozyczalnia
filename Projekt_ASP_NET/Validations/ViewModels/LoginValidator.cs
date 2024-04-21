using FluentValidation;
using Projekt_ASP_NET.ViewModels;

namespace Projekt_ASP_NET.Validations.ViewModels
{
    public class LoginValidator : AbstractValidator<LoginViewModel>
    {
        public LoginValidator()
        {
            RuleFor(x => x.UserName)
            .NotNull().WithMessage("Login nie może być pusty.");

            RuleFor(x => x.Password)
                .NotNull().WithMessage("Hasło jest wymagane.")
                .MinimumLength(6).WithMessage("Hasło musi mieć co najmniej 6 znaków.")
                .Matches("[A-Z]").WithMessage("Hasło musi zawierać co najmniej jedną wielką literę.")
                .Matches("[a-z]").WithMessage("Hasło musi zawierać co najmniej jedną małą literę.");
        }
    }
}
