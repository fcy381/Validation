using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation.DTOs
{
    public class Card
    {
        // No debe estar vacío y debe ser un número de tarjeta válido.
        public string Number { get; set; }

        // No debe estar vacía y debe ser una fecha futura.
        public DateTime ExpirationDate { get; set; }

        // No debe estar vacío y debe tener una longitud de 3 digitos.
        public string SecurityCode { get; set; }

        // No debe estar vacío y puede tomar uno de estos valores: {DEV, CRE} 
        public string Type { get; set; }

        // No debe estar vacío y no debe superar los 30 caracteres.
        public string Entity { get; set; }
    }
}
