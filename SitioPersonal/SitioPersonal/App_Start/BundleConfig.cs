using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SitioPersonal.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //"https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700,900",
            bundles.Add(new StyleBundle("~/bundles/css").Include(

                "~/assets/css/bootstrap.min.css",
                 "~/assets/css/font-awesome.min.css",
                "~/assets/css/normalize.css",
                "~/assets/css/owl.carousel.min.css",
                "~/assets/css/owl.theme.min.css",
                "~/assets/css/magnific-popup.css",
                "~/assets/css/style.css",
                "~/assets/css/responsive.css",
                "~/assets/css/prism.css",
                "~/assets/css/ModalFile1.css"));
            /*
                "~/Content/css/404.css",
                "~/Content/vendors/popup/lightbox.css",


             */

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/assets/js/jquery.min.js",
                "~/assets/js/bootstrap.min.js",
                "~/assets/js/owl.carousel.min.js",
                "~/assets/js/jquery.mixitup.js",
                "~/assets/js/jquery.magnific-popup.min.js",
                "~/assets/js/main_script.js",
                "~/assets/js/prism.js",
                "~/assets/js/ModalFile1.js"));
        }
    }
}