using System.Web;
using System.Web.Optimization;

namespace RealSchedule
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region JQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/jquery.mask.min.js")
                .Include("~/Scripts/moment.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval")
                .Include("~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                .Include("~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap.css",
                      "~/Content/site.css"));
            #endregion

            #region Angular
            bundles.Add(new ScriptBundle("~/bundles/angular")
                .Include("~/Scripts/angular.min.js")
                .Include("~/Scripts/angular-mocks.js")
                );
            #endregion

            #region directives
            bundles.Add(new ScriptBundle("~/bundles/alert-directive")
                    .Include("~/Assets/scripts/directives/alert.js")
                    );
            #endregion

            #region  Angular Module
            bundles.Add(new ScriptBundle("~/bundles/angular-module")
            .Include("~/Assets/scripts/app.js")
            .Include("~/Assets/scripts/module/repository.module.js")
            .Include("~/Assets/scripts/module/business.module.js")
            .Include("~/Assets/scripts/module/controller.module.js")
            );
            #endregion

            #region Home

            bundles.Add(new ScriptBundle("~/bundles/home")
            .Include("~/Assets/scripts/repositories/home.rep.js")
            .Include("~/Assets/scripts/business/home.bo.js")
            .Include("~/Assets/scripts/controller/home.controller.js")
            );

            #endregion

            #region Schedule

            bundles.Add(new ScriptBundle("~/bundles/schedule")
            .Include("~/Assets/scripts/business/schedule.bo.js")
            .Include("~/Assets/scripts/controller/schedule.controller.js")
            .Include("~/Assets/scripts/repository/schedule.rep.js")
            );

            #endregion
        }
    }
}
