using System.Web;
using System.Web.Optimization;

namespace System_Controle
{
    public class BundleConfig
    {
        //Auto completion https://getbootstrap.com/docs/3.4/css/#forms https://twitter.github.io/typeahead.js/examples/
        //install-package Twitter-Typeahead 1.10.02
        // "bootbox" version="4.3.0" modern dialog
        //"EntityFramework" version="6.4.0" for table connection
        //"jquery.datatables" version="1.10.11" sort table
        // "AutoMapper" version="4.1.1" 
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //jquery
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                         "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/scripts/datatables/jquery.datatables.js",
                        "~/scripts/datatables/datatables.bootstrap.js" ,
                        "~/scripts/typeahead.bundle.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //Add reference ex bootbox
            /*bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootbox.js"));*/

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/datatables/css/dataTables.bootstrap.css",//this add style to datatables
                      "~/Content/site.css",
                      "~/Content/TypeaheadStyle.css"));
        }
    }
}
