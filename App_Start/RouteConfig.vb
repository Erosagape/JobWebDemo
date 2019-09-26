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
            name:="Home",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Menu", .action = "Index", .id = UrlParameter.Optional}
        )
    End Sub
End Module