﻿using System.Web.Optimization;

namespace Project
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/ng-grid.js",
                "~/Scripts/ui-grid.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.js"));


            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                        "~/App/project.js")); // Main Angular Application

            bundles.Add(new ScriptBundle("~/bundles/services").Include(
            "~/App/service.js"));

            bundles.Add(new ScriptBundle("~/bundles/directives").Include(
                        "~/App/directives.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/ng-grid.css",
                      "~/Content/ui-grid.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/ui-bootstrap-csp.css"));

        }
    }
}
