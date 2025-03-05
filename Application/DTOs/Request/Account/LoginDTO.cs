using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Request.Account
{
    public class LoginDTO
    {
        [EmailAddress, Required, DataType(DataType.EmailAddress)]
        [RegularExpression("[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+", ErrorMessage = "Tu Email no es Válido, Agrega un Email que tenga... @gmail, @hotmail, @yahoo")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; } = string.Empty;
        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$",
            ErrorMessage = "Tu constraseña debe tener una combinacion de Alfanúmericos y Cáracteres especiales")]
        public string Password { get; set; } = string.Empty;
    }
}
