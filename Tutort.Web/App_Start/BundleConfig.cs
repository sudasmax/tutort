using System.Web.Optimization;

namespace Tutort.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                        "~/Scripts/Vendor/jquery-1.11.0.min.js",
                        "~/Scripts/Vendor/jquery.gmap3.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr/js").Include(
                        "~/Scripts/Vendor/modernizr-2.6.1-respond-1.1.0.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/main/js").Include(
                        "~/Scripts/main.js",
                        "~/Scripts/plugins.js",
                        "~/Vendor/responsive-nav/responsive-nav.js"));

            bundles.Add(new StyleBundle("~/bundles/content").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/font-awesome.css",
                        "~/Content/templatemo_style.css",
                        "~/Content/templatemo_misc.css",
                        "~/Content/flexslider.css",
                        "~/Content/testimonials.css",
                        "~/Vendor/responsive-nav/responsive-nva.css"));

            // Blueimp gallery
            bundles.Add(new ScriptBundle("~/Vendor/blueimp/js").Include(
                        "~/Vendor/blueimp-gallery/js/jquery.blueimp-gallery.min.js"));

            // Blueimp gallery style
            bundles.Add(new StyleBundle("~/Vendor/blueimp/css").Include(
                        "~/Vendor/blueimp-gallery/css/blueimp-gallery.min.css", new CssRewriteUrlTransform()));

            // jQuery UI
            bundles.Add(new ScriptBundle("~/Vendor/jquery-ui/js").Include(
                        "~/Vendor/jquery-ui/jquery-ui.min.js"));

            bundles.Add(new StyleBundle("~/Vendor/jquery-ui/css").Include(
                        "~/Vendor/jquery-ui/jquery-ui.min.css"));

            #if !DEBUG
            BundleTable.EnableOptimizations = true;
            #endif
        }
    }
}
