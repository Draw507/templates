using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class SeguridadController : Controller
    {
        #region LOGIN

        // GET: Seguridad
        [AllowAnonymous]
        public ActionResult Login(string urlRetorno)
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToLocal(urlRetorno);
            }
            return View();
        }

        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(LoginViewModel model, string returnUrl)
        //{
        //    if (Request.IsAuthenticated)
        //    {
        //        return RedirectToAction("Login", "Seguridad");
        //    }
        //    else if (ModelState.IsValid)
        //    {
        //        bool isDebug = HttpContext.IsDebuggingEnabled;
        //        var loginInfo = new Usuarios()
        //                       .ObtenerUsuario(model.NombreUsuario,
        //                                       model.Contrasena,
        //                                       isDebug);

        //        if (loginInfo != null)
        //        {
        //            SignInUser(loginInfo, false);

        //            return RedirectToLocal(returnUrl);
        //        }
        //        else
        //        {
        //            ModelState.AddModelError(string.Empty, RecursosLocalizables.StringResources.MsgUsuarioInvalido);
        //        }
        //    }

        //    return View(model);
        //}

        [HttpPost]
        public ActionResult LogOff()
        {
            var ctx = Request.GetOwinContext();
            var authenticationManager = ctx.Authentication;

            authenticationManager.SignOut();

            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();

            return this.RedirectToAction("Login", "Seguridad");
        }

        #endregion

        #region HELPERS

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("PD", "NoSegmentos");
        }

        //private void SignInUser(UsuarioDTO usuario, bool isPersistent)
        //{
        //    var claims = new List<Claim>();

        //    claims.Add(new Claim(ClaimTypes.Name, usuario.Nombre));

        //    var claimIdenties = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);

        //    var ctx = Request.GetOwinContext();
        //    var authenticationManager = ctx.Authentication;

        //    authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, claimIdenties);
        //}

        #endregion
    }
}