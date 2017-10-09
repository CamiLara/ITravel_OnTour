using System.Web.Optimization;

namespace ITravel_OnTour
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").
                Include(
                "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                "~/Content/vendor/metisMenu/metisMenu.min.css",
                "~/Content/dist/css/sb-admin-2.css",
                "~/Content/vendor/morrisjs/morris.css",
                "~/Content/vendor/font-awesome/css/font-awesome.min.css"));

                   bundles.Add(new ScriptBundle("~/bundles/js").
                Include(
                "~/Content/vendor/jquery/jquery.min.js",
                "~/Content/dist/js/sb-admin-2.js",
                "~/Content/data/morris-data.js",
                "~/Content/vendor/morrisjs/morris.min.js",
                "~/Content/vendor/raphael/raphael.min.js",
                "~/Content/vendor/metisMenu/metisMenu.min.js",
                "~/Content/vendor/bootstrap/js/bootstrap.min.js"));

        }
    }
}
