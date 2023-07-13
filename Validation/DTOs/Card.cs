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
        public string Numero { get; set; }

        // No debe estar vacía y debe ser una fecha futura.
        public DateTime ExpirationDate { get; set; }

        // No debe estar vacío y debe tener una longitud de 3 caracteres.
        public string SecurityCode { get; set; }

        // No debe estar vacío y puede tomar uno de estos valores: {DEV, CRE} 
        public string type { get; set; }

        // No debe estar vacío.
        public string Entity { get; set; }
    }
}
