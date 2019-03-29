using System.Web;
using System.Web.Optimization;

namespace WMP
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterStyleBundles(bundles);
            RegisterScriptBundles(bundles);

            // Set true for encrypt js,css bundle
            BundleTable.EnableOptimizations = false;
        }

        #region Private Methods
        private static void RegisterStyleBundles(BundleCollection bundles)
        {
            // Css bundle: Login page 
            bundles.Add(new StyleBundle("~/Content/cssLogin").Include(
                "~/Content/bootstrap.min.css"
            ));

            // Css bundle: Master page
            bundles.Add(new StyleBundle("~/Content/cssMaster").Include(
                "~/assets/vendor/fonts/fontawesome.css",
                "~/assets/vendor/fonts/ionicons.css",
                "~/assets/vendor/fonts/linearicons.css",
                "~/assets/vendor/fonts/open-iconic.css",
                "~/assets/vendor/fonts/pe-icon-7-stroke.css",
                "~/assets/vendor/css/bootstrap-material.css",
                "~/assets/vendor/css/appwork-material.css",
                "~/assets/vendor/css/theme-corporate-material.css",
                "~/assets/vendor/css/colors-material.css",
                "~/assets/vendor/css/uikit.css",
                "~/assets/css/demo.css",
                "~/assets/vendor/libs/bootstrap-multiselect/bootstrap-a.css",
                "~/assets/vendor/libs/bootstrap-datepicker/bootstrap-datepicker.css",
                "~/assets/vendor/libs/perfect-scrollbar/perfect-scrollbar.css",
                "~/assets/vendor/libs/datatables/datatables.css",
                "~/assets/vendor/libs/dropzone/dropzone.css",
                "~/assets/css/custom.css"
            ));
        }

        private static void RegisterScriptBundles(BundleCollection bundles)
        {
            // Javascript bundle: Init top of master page for support document.ready in content page
            bundles.Add(new ScriptBundle("~/bundles/jsStarter").Include(
                "~/Scripts/modernizr-2.8.3.js",
                "~/assets/vendor/js/material-ripple.js",
                "~/assets/vendor/js/layout-helpers.js",
                "~/assets/vendor/js/pace.js",
                "~/Scripts/jquery-3.3.1.min.js"
            ));

            // Javascript bundle: Login page
            bundles.Add(new ScriptBundle("~/bundles/jsLogin").Include(
                "~/Scripts/bootstrap.min.js"
            ));

            // Javascript bundle: Master page
            bundles.Add(new ScriptBundle("~/bundles/jsMaster").Include(
                "~/assets/vendor/libs/popper/popper.js",
                "~/assets/vendor/js/bootstrap.js",
                "~/assets/vendor/js/sidenav.js",
                "~/assets/vendor/libs/bootstrap-multiselect/bootstrap-multiselect.js",
                "~/assets/vendor/libs/bootstrap-datepicker/bootstrap-datepicker.js",
                "~/assets/vendor/libs/perfect-scrollbar/perfect-scrollbar.js",
                "~/assets/vendor/libs/datatables/datatables.js",
                "~/assets/vendor/libs/dropzone/dropzone.js",
                "~/assets/js/ui_button-groups.js",
                "~/assets/js/ui_modals.js",
                "~/assets/js/demo.js",
                "~/assets/js/forms_selects.js",
                "~/assets/js/forms_pickers.js",
                "~/assets/js/forms_file-upload.js",
                "~/assets/js/tables_datatables.js",
                "~/assets/js/dashboards_dashboard-1.js",
                "~/Scripts/jquery.validate.min.js",
                "~/Scripts/jquery.validate.unobtrusive.min.js",
                "~/Scripts/jquery.unobtrusive-ajax.min.js",
                "~/Scripts/moment.min.js"
            ));
        }
        #endregion
    }
}
