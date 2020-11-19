using System.ComponentModel.DataAnnotations;

namespace com.draw507.entidades.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string NombreUsuario
        {
            get;
            set;
        }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Contrasena
        {
            get;
            set;
        }
    }
}
