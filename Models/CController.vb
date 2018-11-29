Imports System.Web.Mvc

Public Class CController
    Inherits Controller
    Friend Function CheckSession(sName) As Boolean
        If IsNothing(Session(sName)) Then
            Return True
        Else
            Return False
        End If
    End Function
    Friend Function GetView(vName As String, Optional modName As String = "") As ActionResult
        If CheckSession("CurrUser") Then
            Session("CurrUser") = ""
        End If
        ViewBag.User = Session("CurrUser").ToString
        If ViewBag.User = "" Then
            Return Redirect("~/index.html")
        End If
        If CheckSession("CurrForm") Then
            Session("CurrForm") = ""
        End If
        If CheckSession("CurrRights") Then
            Session("CurrRights") = "*MIREDP"
        End If
        If modName <> "" Then
            Session("CurrForm") = modName & "/" & vName
            Session("CurrRights") = Main.GetAuthorize(ViewBag.User, modName, vName)
            If Session("CurrRights").ToString().IndexOf("M") < 0 Then
                Return RedirectToAction("AuthError", "Menu")
            End If
        End If
        ViewBag.Module = Session("CurrForm").ToString()
        ViewBag.UserRights = Session("CurrRights").ToString()
        Return View(vName)
    End Function
End Class
