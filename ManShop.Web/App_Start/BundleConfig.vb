Imports System.Web.Optimization
Imports ManShop.Common.ManShop.Common

Namespace ManShop.Web
    Public Class BundleConfig
        Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)
            bundles.Add(New ScriptBundle("~/js/jquery").Include("~/Assets/client/js/jquery.min.js"))
            bundles.Add(New ScriptBundle("~/js/plugins").Include("~/Assets/admin/libs/jquery-ui/jquery-ui.min.js", "~/Assets/admin/libs/mustache/mustache.js", "~/Assets/admin/libs/numeral/numeral.js", "~/Assets/admin/libs/jquery-validation/dist/jquery.validate.js", "~/Assets/client/js/common.js"))
            bundles.Add(New StyleBundle("~/css/base").Include("~/Assets/client/css/bootstrap.css", New CssRewriteUrlTransform()).Include("~/Assets/client/font-awesome-4.6.3/css/font-awesome.css", New CssRewriteUrlTransform()).Include("~/Assets/admin/libs/jquery-ui/themes/smoothness/jquery-ui.min.css", New CssRewriteUrlTransform()).Include("~/Assets/client/css/style.css", New CssRewriteUrlTransform()).Include("~/Assets/client/css/custom.css", New CssRewriteUrlTransform()))
            BundleTable.EnableOptimizations = Boolean.Parse(ConfigHelper.GetByKey("EnableBundles"))
        End Sub
    End Class
End Namespace
