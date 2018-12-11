Imports System.Web.Mvc

Namespace Controllers
    Public Class ReportController
        Inherits Controller

        ' GET: Report
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace