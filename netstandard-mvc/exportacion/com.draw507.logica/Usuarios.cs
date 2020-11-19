using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    public class Usuarios
    {
        //public UsuarioDTO ObtenerUsuario(string nombreUsuario, string contrasena, bool isDebug)
        //{
        //    UsuarioDTO usuario = null;

        //    if (isDebug)
        //    {
        //        usuario = new UsuarioDTO
        //        {
        //            Nombre = nombreUsuario,
        //            Estado = "A",
        //            EsUsuarioActiveDirectory = true
        //        };
        //    }
        //    else
        //    {
        //        //Define el dominio del Banco
        //        //PrincipalContext contexto = new PrincipalContext(ContextType.Domain, "CAPITALBANK", "DC=capitalbank,DC=com");
        //        PrincipalContext contexto = new PrincipalContext(ContextType.Domain, null);
        //        bool isValid = contexto.ValidateCredentials(nombreUsuario, contrasena);

        //        if (isValid)
        //        {
        //            UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(contexto, IdentityType.SamAccountName, nombreUsuario);

        //            //Pertenece al grupo
        //            if (userPrincipal != null && userPrincipal.IsMemberOf(contexto, IdentityType.Name, "NIIF09_RD_Usuarios"))
        //            {
        //                usuario = new UsuarioDTO
        //                {
        //                    Nombre = userPrincipal.SamAccountName,
        //                    Estado = "A",
        //                    EsUsuarioActiveDirectory = true
        //                };
        //            }
        //        }
        //    }

        //    return usuario;
        //}
    }
}
