using Elmah;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace com.draw507.web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private List<string> sensitiveKeys = new List<string>() { "password", "pwd", "Contrasena" };

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.Name;
            //AutoMapperConfiguration.RegisterMappings();
        }

        void ErrorLog_Filtering(object sender, ExceptionFilterEventArgs args)
        {
            Filter(args);
        }

        void ErrorMail_Filtering(object sender, ExceptionFilterEventArgs args)
        {
            Filter(args);
        }

        void Filter(ExceptionFilterEventArgs args)
        {
            if (args.Context != null)
            {
                HttpContext context = (HttpContext)args.Context;
                if (context.Request != null && context.Request.Form.AllKeys.Count() > 0)
                {
                    foreach (var key in context.Request.Form.AllKeys)
                    {
                        if (context.Request.Form.AllKeys.Any
                            (
                                k => sensitiveKeys.Any(sk => k.IndexOf(sk, StringComparison.OrdinalIgnoreCase) >= 0)
                            ))
                        {
                            //I've got sentitive information
                            ElmahSensitiveHandle(args, context);
                        }
                    }
                }
            }
        }

        private void ElmahSensitiveHandle(ExceptionFilterEventArgs args, HttpContext context)
        {
            var newError = new Elmah.Error(args.Exception, (HttpContext)args.Context);
            foreach
                    (var key in context.Request.Form.OfType<String>().Where
                        (
                            k => sensitiveKeys.Any(sk => k.IndexOf(sk, StringComparison.OrdinalIgnoreCase) >= 0)
                        )
                    )
            {
                newError.Form.Set(key, "*******************");
            }

            Elmah.ErrorLog.GetDefault(HttpContext.Current).Log(newError);
            args.Dismiss();
        }
    }
}
