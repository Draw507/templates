using System.Web;
using System.Web.Optimization;

namespace com.draw507.web
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/appcss").Include(
                      "~/Content/lib/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/lib/theme/assets/css/plugins.css",
                      "~/Content/lib/theme/plugins/animate/animate.min.css",
                      "~/Content/lib/theme/plugins/sweetalerts/sweetalert2.min.css",
                      "~/Content/lib/theme/plugins/sweetalerts/sweetalert.css",
                      "~/Content/lib/theme/plugins/perfect-scrollbar/perfect-scrollbar.css",
                      "~/Content/lib/theme/plugins/highlight/styles/monokai-sublime.css",
                      "~/Content/app.css"));

            bundles.Add(new ScriptBundle("~/bundles/appjs").Include(
                      "~/Scripts/lib/jquery/dist/jquery.min.js",
                      "~/Scripts/lib/bootstrap/dist/js/popper.min.js",
                      "~/Scripts/lib/bootstrap/dist/js/bootstrap.bundle.min.js",
                      "~/Scripts/lib/theme/plugins/perfect-scrollbar/perfect-scrollbar.min.js",
                      "~/Scripts/lib/theme/plugins/sweetalerts/sweetalert2.min.js",
                      "~/Scripts/lib/theme/plugins/sweetalerts/custom-sweetalert.js",
                      "~/Scripts/lib/theme/assets/js/app.js",
                      "~/Scripts/lib/theme/assets/js/custom.js",
                      "~/Scripts/app.js"));

#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif

        }
    }
}
