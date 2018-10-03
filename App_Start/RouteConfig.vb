Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        routes.MapRoute(
            name:="Adv",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.action = "Index", .id = UrlParameter.Optional}
        )
        routes.MapRoute(
            name:="Config",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.action = "Index", .id = UrlParameter.Optional}
        )
        routes.MapRoute(
            name:="JobOrder",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.action = "ShowJob", .id = UrlParameter.Optional}
        )
        routes.MapRoute(
            name:="Master",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.action = "Index", .id = UrlParameter.Optional}
        )



    End Sub
End Module