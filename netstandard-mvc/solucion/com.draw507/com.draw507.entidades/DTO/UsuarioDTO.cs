using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.draw507.entidades.DTO
{
    public class UsuarioDTO
    {
        public UsuarioDTO()
        {
            Roles = new List<string>();
            IdRoles = new List<int>();
        }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public List<string> Roles { get; set; }
        public List<int> IdRoles { get; set; }
        public string Estado { get; set; }
        public bool EsUsuarioActiveDirectory { get; set; }

    }
}
