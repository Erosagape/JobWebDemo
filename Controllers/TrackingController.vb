Imports System.Web.Mvc

Namespace Controllers
    Public Class TrackingController
        Inherits Controller

        ' GET: Tracking
        Function Index() As ActionResult
            Return View()
        End Function
        Function Document() As ActionResult
            Return View()
        End Function
    End Class
End Namespace