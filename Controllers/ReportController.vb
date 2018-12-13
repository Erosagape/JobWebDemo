Imports System.Web.Mvc

Namespace Controllers
    Public Class ReportController
        Inherits CController

        ' GET: Report
        Function Index() As ActionResult
            ViewBag.ReportName = "Shipment Total Report"
            Return GetView("Index")
        End Function
    End Class
End Namespace