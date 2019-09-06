Imports System.Web.Mvc

Namespace Controllers
    Public Class TrackingController
        Inherits CController

        ' GET: Tracking
        Function Index() As ActionResult
            Return GetView("Index")
        End Function
        Function Document() As ActionResult
            Return GetView("Document")
        End Function
        Function PublicIndex() As ActionResult
            Return View()
        End Function
    End Class
End Namespace