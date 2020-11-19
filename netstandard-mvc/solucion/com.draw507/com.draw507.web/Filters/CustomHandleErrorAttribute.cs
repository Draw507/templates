using com.draw507.web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace com.draw507.web.Filters
{
    public class CustomHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            try
            {
                //Se genera un identificador unico que se mostrara al usuario para que contacte a soporte y se puede encontrar el error
                var guid = Guid.NewGuid().ToString();

                //Si la excepción ha sido manejada no hacer nada
                if (filterContext.ExceptionHandled)
                {
                    return;
                }

                //Logger
                var ex = filterContext.Exception;
                ex.Data["GUID"] = guid;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);

                string message = "";// ValidateMessageError(filterContext.Exception, guid);

                filterContext.Controller.ViewBag.ErrorMessage = message;

                //AJAX Request, se retorna el error en formato JSON
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    var jsonResult = new ErrorController { ControllerContext = filterContext }.JsonErrorResult(message);
                    jsonResult.ExecuteResult(filterContext);

                    filterContext.ExceptionHandled = true;
                }
                else
                {
                    filterContext.Result = new ViewResult
                    {
                        ViewName = "~/Views/Shared/Error.cshtml",
                        ViewData = filterContext.Controller.ViewData
                    };
                    filterContext.ExceptionHandled = true;
                }
            }
            catch (Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                filterContext.Result = new ViewResult
                {
                    ViewName = "~/Views/Shared/Error.cshtml",
                    ViewData = filterContext.Controller.ViewData
                };
                filterContext.ExceptionHandled = true;
            }

            base.OnException(filterContext);
        }
    }
}