using System.Web;
using System.Web.Optimization;

namespace _3HM
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"

                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                       "~/Scripts/carousel.js",
                        "~/Scripts/custom.js",
                        "~/Scripts/jquery.gmap.min.js",
                        "~/Scripts/flexslider.js",
                        "~/Scripts/jquery.cslider.js",
                        "~/Scripts/slider.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-responsive.css",
                       "~/Content/site.css",
                      "~/Content/hover.css",
                      "~/Content/icons",
                      "~/Content/icons-color.css",
                      "~/Content/Social-icons.css",
                      "~/Content/parallax-slider.css"
                     
                      
                      ));
        }
    }
}
