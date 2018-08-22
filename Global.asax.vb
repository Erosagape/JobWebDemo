Imports System.Web.Http
Imports System.Web.Mvc
Imports System.Web.Routing
Imports System.Web.Optimization
Public Class WebApiApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        AreaRegistration.RegisterAllAreas()
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        BundleConfig.RegisterBundles(BundleTable.Bundles)

    End Sub
End Class
