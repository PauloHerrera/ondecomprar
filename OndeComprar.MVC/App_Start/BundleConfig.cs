using System.Web;
using System.Web.Optimization;

namespace OndeComprar.MVC
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Public/Scripts/jQueryv2.0.3.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/pagestart").Include(
                        "~/Public/Scripts/owl.carousel.js",
                        "~/Public/Scripts/pxgradient-1.0.2.jquery.js",
                        "~/Public/Scripts/bootstrap.js",
                        "~/Public/Scripts/less-1.7.0.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jsAdmin").Include(
                       "~/Public/Scripts/bootstrap.js",
                        "~/Public/Scripts/Admin/plugins.js",
                        "~/Public/Scripts/Admin/app.js" ));
            
            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Public/Scripts/jquery-ui-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Public/Scripts/jquery.unobtrusive*",
            //            "~/Public/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Public/Scripts/modernizr-*"));

            /** CSS ANTIGO **/
            bundles.Add(new StyleBundle("~/Public/Styles/css")
                .Include("~/Public/Styles/bootstrap.css",
                "~/Public/Styles/main.css",
                "~/Public/Styles/layout.css",
                "~/Public/Styles/whhg.css"));

            /** CSS NOVO **/
            //bundles.Add(new StyleBundle("~/Public/Styles/css2")
            //        .Include("~/Public/Styles/layout.css",
            //        "~/Public/Styles/whhg.css",
            //        "~/Public/Styles/style.css"));

            /** CSS COM O LESS **/
            bundles.Add(new LessBundle("~/Content/less").Include("~/Public/Styles/Default/*.less"));
            bundles.Add(new StyleBundle("~/Public/Styles/css2").Include("~/Public/Styles/whhg.css"));

            /** CSS ADMIN **/
            bundles.Add(new StyleBundle("~/Public/Styles/cssAdmin")
                .Include("~/Public/Styles/bootstrap.css",
                "~/Public/Styles/Admin/plugins.css",
                "~/Public/Styles/Admin/main.css",
                "~/Public/Styles/Admin/themes.css"
                ));
           
        }
    }
}