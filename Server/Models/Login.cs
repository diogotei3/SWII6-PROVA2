using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Campo requirido!")]
        public required string Login { get; set; }

        [Required(ErrorMessage = "Campo requirido!")]
        public required string Senha { get; set; }
    }

}
