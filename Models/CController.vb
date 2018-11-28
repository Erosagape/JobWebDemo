Imports System.Web.Mvc

Public Class CController
    Inherits Controller
    Friend Function GetView(vName As String, Optional modName As String = "") As ActionResult
        If IsNothing(Session("CurrUser")) Then
            Session("CurrUser") = ""
        End If
        ViewBag.User = Session("CurrUser").ToString
        If ViewBag.User = "" Then
            Return Redirect("~/index.html")
        End If
        If modName <> "" Then
            If Main.GetAuthorize(ViewBag.User, modName, vName).IndexOf("M") < 0 Then
                Return RedirectToAction("Menu", "AuthError")
            End If
            ViewBag.Module = modName & "." & vName
        Else
            ViewBag.Module = ""
        End If
        Return View(vName)
    End Function
End Class
