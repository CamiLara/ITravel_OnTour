using System.Web.Optimization;

namespace ITravel_OnTour
{
    public class BundleConfig
    {    
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.UseCdn = true;   //enable CDN support

            ////add link to bootstrap on the CDN
            //var FontGooglePath1 = "https://fonts.googleapis.com/css?family=Montserrat:400,700";
            //var FontGooglePath2 = "https://fonts.googleapis.com/css?family=Kaushan+Script";
            //var FontGooglePath3 = "https://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic";
            //var FontGooglePath4 = "https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700";

            bundles.Add(new StyleBundle("~/bundles/css").
                Include(
                "~/Content/css/agency.min.css",
                "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                "~/Content/vendor/font-awesome/css/font-awesome.min.css"));
                //FontGooglePath1,
                //FontGooglePath2,
                //FontGooglePath3,
                //FontGooglePath4));

             bundles.Add(new ScriptBundle("~/bundles/js").
                Include(
                "~/Content/js/agency.min.js",
                "~/Content/js/contact_me.js",
                "~/Content/js/jqBootstrapValidation.js",
                "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                "~/Content/vendor/bootstrap/js/bootstrap.min.js",
                "~/Content/vendor/popper/popper.min.js",
                "~/Content/vendor/jquery/jquery.min.js"));

        }
    }
}
