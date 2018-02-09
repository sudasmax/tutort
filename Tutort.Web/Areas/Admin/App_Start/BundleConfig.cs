﻿using System.Web.Optimization;

namespace Tutort.Web.Areas.Admin
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			// Homer style
			bundles.Add(new StyleBundle("~/bundles/homer/css").Include(
					"~/Areas/Admin/Content/style.css", new CssRewriteUrlTransform()));

			// Homer script
			bundles.Add(new ScriptBundle("~/bundles/homer/js").Include(
					"~/Areas/Admin/Vendor/metisMenu/dist/metisMenu.min.js",
					"~/Areas/Admin/Scripts/homer.js"));

			// Animate.css
			bundles.Add(new StyleBundle("~/bundles/animate/css").Include(
					"~/Areas/Admin/Vendor/animate.css/animate.min.css"));

			// Pe-icon-7-stroke
			bundles.Add(new StyleBundle("~/bundles/peicon7stroke/css").Include(
					"~/Areas/Admin/Icons/pe-icon-7-stroke/css/pe-icon-7-stroke.css", new CssRewriteUrlTransform()));

			// Font Awesome icons style
			bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
					"~/Areas/Admin/Vendor/fontawesome/css/font-awesome.min.css", new CssRewriteUrlTransform()));

			// Bootstrap style
			bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
					"~/Areas/Admin/Vendor/bootstrap/dist/css/bootstrap.min.css", new CssRewriteUrlTransform()));

			// Bootstrap
			bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
					"~/Areas/Admin/Vendor/bootstrap/dist/js/bootstrap.min.js"));

			// jQuery
			bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
					"~/Areas/Admin/Vendor/jquery/dist/jquery.min.js"));

			// jQuery UI
			bundles.Add(new ScriptBundle("~/bundles/jqueryui/js").Include(
					"~/Areas/Admin/Vendor/jquery-ui/jquery-ui.min.js"));

			// jQuery Validation
			bundles.Add(new ScriptBundle("~/bundles/validation/js").Include(
					"~/Areas/Admin/Vendor/jquery-validation/jquery.validate.min.js"));
		}

	}
}