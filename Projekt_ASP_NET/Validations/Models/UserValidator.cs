using FluentValidation;
using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.Validations.Models
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email)
                .NotNull().WithMessage("Email jest wymagany.")
                .Matches("@").WithMessage("Email musi posiadać małpę.");

            RuleFor(x => x.UserName)
                .NotNull().WithMessage("Nazwa użytkownika jest wymagana.");

            RuleFor(x => x.PasswordHash)
                .NotNull().WithMessage("Hasło jest wymagane.")
                .MinimumLength(6).WithMessage("Hasło musi mieć co najmniej 8 znaków.")
                .Matches("[A-Z]").WithMessage("Hasło musi zawierać co najmniej jedną wielką literę.")
                .Matches("[a-z]").WithMessage("Hasło musi zawierać co najmniej jedną małą literę.");
        }
    }
}

