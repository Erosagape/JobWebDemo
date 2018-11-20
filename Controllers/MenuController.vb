Imports System.Web.Mvc

Namespace Controllers
    Public Class MenuController
        Inherits Controller

        Private Function GetView(vName As String) As ActionResult
            If IsNothing(Session("CurrUser")) Then
                Session("CurrUser") = ""
            End If
            ViewBag.User = Session("CurrUser").ToString
            If ViewBag.User = "" Then
                Return Redirect("~/index.html")
            End If
            Return View(vName)
        End Function
        ' GET: Menu
        Function Index() As ActionResult
            Return GetView("Index")
        End Function
    End Class
End Namespace