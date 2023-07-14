using FluentValidation;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation.DTOs;

namespace Validation.Validations
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator() 
        {
            RuleFor(usr => usr.Name)
                .NotEmpty().WithMessage("EL nombre es obligatorio y debe procurarse que sea completo, es decir, que incluya nombre/s y apellido/s., y en ese orden.");

            RuleFor(usr => usr.PrincipalEmail)
                .NotEmpty().WithMessage("El email principal es obligatorio")
                .EmailAddress().WithMessage("El email indicado debe ser válido.");
            
            RuleFor(usr => usr.Age)
                .NotEmpty().WithMessage("La edad es obligatorio, y debe estar entre 18 y 99, inclusive.");

            RuleFor(usr => usr.Password).NotEmpty().WithMessage("El password es obligatorio.")
                .MinimumLength(8).WithMessage("El password debe tener al menos 8 caracteres de longitud.")
                .Matches("[A-Z]").WithMessage("El password debe tener al menos una letra mayúscula.")
                .Matches("[a-z]").WithMessage("El password debe tener al menos una letra minúscula.")
                .Matches("[0-9]").WithMessage("El password debe tener al menos un ´dígito.")
                .Matches("[^a-zA-Z0-9]").WithMessage("El password debe tener al menos un caracter especial.");

            RuleFor(usr => usr.PasswordConfirmation)
                .Equal(usr => usr.Password).WithMessage("La confirmación de contraseña no es igual a la contraseña indicada.");

            RuleFor(usr => usr.SecondaryEmails)
                .Must(SecondaryEmails => SecondaryEmails != null && SecondaryEmails.Count <= 5).WithMessage("Sólo se permiten cinco emails secundarios.")
                .ForEach(SecondaryEmail => SecondaryEmail.EmailAddress()).WithMessage("Uno de los emails secundarios no es válido.");                
        }
    }
}
