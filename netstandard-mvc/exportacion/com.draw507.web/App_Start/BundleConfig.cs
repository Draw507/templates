using System.Web;
using System.Web.Optimization;

namespace $safeprojectname$
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/perfect-scrollbar.jquery.min.js",
                      "~/Scripts/material.min.js",
                      "~/Scripts/bootstrap-notify.js",
                      "~/Scripts/material-dashboard.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/pnotify.custom.min.js",
                      "~/Scripts/niif.js"));

            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
                        "~/Scripts/DataTables/jquery.dataTables.js",
                        "~/Scripts/DataTables/dataTables.responsive.js",
                        "~/Scripts/DataTables/dataTables.bootstrap.js",
                        "~/Scripts/DataTables/responsive.bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/pd").Include(
                        "~/Scripts/niff-pd.js",
                        "~/Scripts/niif-export.js"));

            bundles.Add(new ScriptBundle("~/bundles/ead").Include(
                        "~/Scripts/niif-ead.js",
                        "~/Scripts/niif-export.js"));

            bundles.Add(new ScriptBundle("~/bundles/lgd").Include(
                        "~/Scripts/niif-lgd.js",
                        "~/Scripts/niif-export.js"));

            bundles.Add(new ScriptBundle("~/bundles/pdss").Include(
                        "~/Scripts/niff-pdss.js"));

            bundles.Add(new ScriptBundle("~/bundles/eadss").Include(
                        "~/Scripts/niif-eadss.js"));

            bundles.Add(new ScriptBundle("~/bundles/lgdss").Include(
                        "~/Scripts/niif-lgdss.js"));

            bundles.Add(new ScriptBundle("~/bundles/revisionFormularios").Include(
                        "~/Scripts/niif-revision-formularios.js"));

            bundles.Add(new ScriptBundle("~/bundles/cargaDeDatos").Include(
                        "~/Scripts/niif-carga.js"));

            bundles.Add(new ScriptBundle("~/bundles/auditoria").Include(
                        "~/Scripts/niif-auditoria.js"));

            bundles.Add(new ScriptBundle("~/bundles/segmentos").Include(
                        "~/Scripts/niif-segmentos.js"));

            bundles.Add(new ScriptBundle("~/bundles/tratamientos").Include(
                        "~/Scripts/niif-tratamientos.js"));

            bundles.Add(new ScriptBundle("~/bundles/banca").Include(
                        "~/Scripts/niif-banca.js"));

            bundles.Add(new ScriptBundle("~/bundles/compania").Include(
                        "~/Scripts/niif-compania.js"));

            bundles.Add(new ScriptBundle("~/bundles/sistemas").Include(
                        "~/Scripts/niif-sistema.js"));

            bundles.Add(new ScriptBundle("~/bundles/opesegmentos").Include(
                        "~/Scripts/niif-opesegmento.js"));

            bundles.Add(new ScriptBundle("~/bundles/opecompanias").Include(
                        "~/Scripts/niif-opecompania.js"));

            bundles.Add(new ScriptBundle("~/bundles/opetratamientos").Include(
                        "~/Scripts/niif-opetratamiento.js"));

            bundles.Add(new ScriptBundle("~/bundles/correos").Include(
                        "~/Scripts/niif-correos.js"));

            bundles.Add(new ScriptBundle("~/bundles/datetime").Include(
                        "~/Scripts/moment.min.js",
                        "~/Scripts/moment-with-locales.min.js",
                        "~/Scripts/bootstrap-material-datetimepicker.js"
                        //"~/Scripts/moment-with-locales.min.js",
                        //"~/Scripts/bootstrap-datetimepicker.min.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/datetimecss").Include(
                      "~/Content/bootstrap-material-datetimepicker.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/material-icons.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/animate.min.css",
                      "~/Content/material-dashboard.css",
                      "~/Content/pnotify.custom.min.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/dataTablescss").Include(
                      "~/Content/DataTables/css/dataTables.bootstrap.css",
                      "~/Content/DataTables/css/responsive.bootstrap.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
