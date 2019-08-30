Imports System.Web.Mvc

Namespace Controllers
    Public Class ReportController
        Inherits CController

        ' GET: Report
        Function Index() As ActionResult
            ViewBag.ReportName = "Reports"
            Return GetView("Index", "MODULE_REP")
        End Function
        Function Import() As ActionResult
            Return GetView("Import", "MODULE_REP")
        End Function
        Function Export() As ActionResult
            Return GetView("Export", "MODULE_REP")
        End Function
        Function Preview() As ActionResult
            Return GetView("Preview")
        End Function
    End Class
End Namespace