using System.Web;
using System.Web.Optimization;

namespace Vidly
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/Datatables-1.10.12/media/js/jquery.datatables.js",
                        "~/Scripts/Datatables-1.10.12/media/js/datatables.bootstrap.js",
                        "~/Scripts/Datatables-1.10.12/extensions/Buttons/js/datatables.buttons.js",
                        "~/Scripts/Datatables-1.10.12/extensions/Buttons/js/buttons.bootstrap.js",
                        "~/Scripts/Datatables-1.10.12/extensions/Buttons/js/buttons.html5.js",
                        "~/Scripts/Datatables-1.10.12/extensions/Select/js/datatables.select.js",
                        "~/Scripts/Datatables-1.10.12/extensions/Buttons/js/buttons.jqueryui.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-lumen.css",
                      "~/Content/site.css",
                      "~/Content/Datatables-1.10.12/media/css/datatables.bootstrap.css",
                      "~/Content/Datatables-1.10.12/extensions/Buttons/css/buttons.bootstrap.css",
                      "~/Content/Datatables-1.10.12/extensions/Buttons/css/buttons.datatables.css",
                      "~/Content/Datatables-1.10.12/extensions/Buttons/css/buttons.jqueryui.css",
                      "~/Content/Datatables-1.10.12/extensions/Select/css/select.bootstrap.css",
                      "~/Content/Datatables-1.10.12/extensions/Select/css/select.datatables.css",
                      "~/Content/Datatables-1.10.12/extensions/Select/css/select.jqueryui.css"

                      ));
        }
    }
}
