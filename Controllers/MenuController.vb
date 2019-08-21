Imports System.Web.Mvc

Namespace Controllers
    Public Class MenuController
        Inherits CController
        ' GET: Menu
        Function Index() As ActionResult
            Return GetView("Index")
        End Function
        Function AuthError() As ActionResult
            Return GetView("AuthError")
        End Function
        Function About() As ActionResult
            Return GetView("About")
        End Function
    End Class
End Namespace