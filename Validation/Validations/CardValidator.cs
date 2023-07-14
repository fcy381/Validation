using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation.DTOs;

namespace Validation.Validations
{
    public class CardValidator: AbstractValidator<Card>
    {
        public CardValidator() 
        {
            RuleFor(cdr => cdr.Number)
                .NotEmpty().WithMessage("El número es obligatorio.")
                .CreditCard().WithMessage("El número de tarjeta indicado no es válido.");

            RuleFor(cdr => cdr.ExpirationDate)
                .NotEmpty().WithMessage("La fecha de expiración es obligatoria")
                .Must(ExpirationDate => ExpirationDate > DateTime.UtcNow).WithMessage("La fecha de expiración debe ser futura.");

            RuleFor(cdr => cdr.SecurityCode)
                .NotEmpty().WithMessage("El código de seguridad es obligatorio.")
                .Matches("[0-9]").WithMessage("El código de seguridad debe estar compuesto solo de dígitos.")
                .Length(3).WithMessage("El código de seguridad no debe tener ni más ni menos de 3 dígitos.");

            RuleFor(cdr => cdr.Type)
                .NotEmpty().WithMessage("El tipo es obligatorio.")
                .Must(type => type == "DEV" || type == "CRE").WithMessage("Los tipos válidos son DEV y CRE.");

            RuleFor(cdr => cdr.Entity)
                .NotEmpty().WithMessage("La entidad es obligatoria.")
                .Length(30).WithMessage("La entidad no debe superar los 30 caracteres.");
                
        }
    }
}
