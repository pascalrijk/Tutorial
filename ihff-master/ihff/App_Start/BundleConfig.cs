using System.Web;
using System.Web.Optimization;

namespace ihff
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/Bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/Isotope").Include(
                        "~/Scripts/jquery.isotope.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/SmoothScroll").Include(
                        "~/Scripts/SmoothScroll.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/animate.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/owl.theme.css",
                      "~/Content/responsive.css",
                      "~/Content/style.css"));
        }
    }
}
