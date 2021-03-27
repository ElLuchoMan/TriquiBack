using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace registro.Models
{

    public class Registro
    {           public int id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string TipoDocumento { get; set; }
        [Required]
        public string Documento { get; set; }
        [Required, MinLength(5), MaxLength(10)]
        public string Password { get; set; }
        [Required]
        public string Correo { get; set; }

        
    }
   
}
