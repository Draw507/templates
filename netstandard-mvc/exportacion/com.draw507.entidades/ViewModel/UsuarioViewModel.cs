using System.ComponentModel.DataAnnotations;

namespace $safeprojectname$.ViewModel
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
