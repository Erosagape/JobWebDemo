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
    Friend Sub LoadCompanyProfile()
        ViewBag.PROFILE_LOGO = Main.GetValueConfig("PROFILE", "COMPANY_LOGO")
        ViewBag.PROFILE_COMPANY_NAME = Main.GetValueConfig("PROFILE", "COMPANY_NAME")
        ViewBag.PROFILE_COMPANY_ADDR1 = Main.GetValueConfig("PROFILE", "COMPANY_ADDRESS1")
        ViewBag.PROFILE_COMPANY_ADDR2 = Main.GetValueConfig("PROFILE", "COMPANY_ADDRESS2")
        ViewBag.PROFILE_CURRENCY = Main.GetValueConfig("PROFILE", "CURRENCY")
        ViewBag.PROFILE_VATRATE = Main.GetValueConfig("PROFILE", "VAT_RATE")
        ViewBag.PROFILE_TAXNUMBER = Main.GetValueConfig("PROFILE", "COMPANY_TAXNUMBER")
        ViewBag.PROFILE_TAXBRANCH = Main.GetValueConfig("PROFILE", "COMPANY_TAXBRANCH")
    End Sub
    Friend Function GetView(vName As String, Optional modName As String = "") As ActionResult
        LoadCompanyProfile()
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
