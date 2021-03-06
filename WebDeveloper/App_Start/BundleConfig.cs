﻿using System.Web;
using System.Web.Optimization;

namespace WebDeveloper
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/moment.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/datepicker").Include(                     
                      "~/Scripts/moment.js",
                      "~/Scripts/bootstrap-datepicker.js"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                        "~/Scripts/Shared/modal.js"));

            bundles.Add(new ScriptBundle("~/bundles/Personal").Include(
                        "~/Scripts/Personal/functions.js"));

            bundles.Add(new StyleBundle("~/Content/datepicker").Include(
                      "~/Content/bootstrap.css")
                      .Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Css/datepicker.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css")
                      .Include("~/Css/site.css")
                      .Include("~/Content/bootstrap-datepicker.css"));

            bundles.Add(new DynamicFolderBundle("js", "*.js", false, new JsMinify()));
            bundles.Add(new DynamicFolderBundle("css", "*.css", false, new JsMinify()));

            #if DEBUG
            BundleTable.EnableOptimizations = false;
            #else
            BundleTable.EnableOptimizations = true;
            #endif
        }
    }
}
