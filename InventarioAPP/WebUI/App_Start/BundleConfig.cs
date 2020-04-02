using System.Web;
using System.Web.Optimization;

namespace WebUI
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
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/vendor/scripts").Include(
                      "~/assets/js/app*",
                      "~/assets/js/bootstrap*",
                      "~/assets/js/demo.js",
                      "~/assets/js/npm.js",
                      "~/assets/js/pages/dashboard*",
                      "~/assets/vendor/jquery/jquery-3.2.1.min.js",
                      "~/assets/vendor/animsition/js/animsition.min.js",
                      "~/assets/vendor/bootstrap/js/popper.js",
                      "~/assets/vendor/select2/select2.min.js",
                      "~/assets/vendor/daterangepicker/moment.min.js",
                      "~/assets/vendor/daterangepicker/daterangepicker.js",
                      "~/assets/vendor/countdowntime/countdowntime.js",
                      "~/assets/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/assets/css/AdminLTE*",
                      "~/assets/css/bootstrap*",
                      "~/assets/css/skins/_all-skins*",
                      "~/assets/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
                      "~/assets/fonts/iconic/css/material-design-iconic-font.min.css",
                      "~/assets/vendor/animate/animate.css",
                      "~/assets/vendor/css-hamburgers/hamburgers.min.css",
                      "~/assets/vendor/animsition/css/animsition.min.css",
                      "~/assets/vendor/select2/select2.min.css",
                      "~/assets/vendor/daterangepicker/daterangepicker.css",
                      "~/assets/css/util.css",
                      "~/assets/css/main.css"));
        }
    }
}
