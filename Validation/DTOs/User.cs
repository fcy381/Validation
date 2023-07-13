using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Validation.DTOs
{
    public class User
    {   // No debe estar vacío.
        public string Nombre { get; set; }

        // No debe estar vacío y debe ser una dirección de correo electrónico válida.
        public string EmailPrincipal { get; set; }

        // No debe estar vacía y debe estar entre 18 y 99 años (inclusive).
        public int Age { get; set; }

        // No debe estar vacío y debe cumplir con los siguientes requisitos:
        //- Tener al menos 8 caracteres de longitud.
        //- Contener al menos una letra mayúscula.
        //- Contener al menos una letra minúscula.
        //- Contener al menos un dígito.
        //- Contener al menos un carácter especial.
        public string Password { get; set; }

        // No puede estar vacío y debe ser igual al contenido del campo Password.
        public string PasswordConfirmation { get; set; }

        // La lista de correos electrónicos secundarios debe cumplir con los siguientes requisitos:
        //- Debe tener un máximo de 5 correos electrónicos.
        //- Cada correo electrónico secundario en la lista debe ser una dirección de correo electrónico válida.
        public List<string> SecondaryEmails { get; set; }

        // Debe contener al menos una tarjeta. 
        public List<Card> Cards { get; set; }

    }
}
