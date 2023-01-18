Imports System.Web.Http
Imports System.Web.Optimization
Imports ManShop.Web.ManShop.Web
Imports ManShop.Web.ManShop.Web.Mappings

Public Class MvcApplication
    Inherits System.Web.HttpApplication
    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        AutoMapperConfiguration.Configure()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub
End Class