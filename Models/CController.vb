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
        'Dim oConfig = Main.GetDataConfig("PROFILE")
        ViewBag.PROFILE_DEFAULT_BRANCH = GetValueConfig("PROFILE", "DEFAULT_BRANCH")
        ViewBag.PROFILE_DEFAULT_BRANCH_NAME = Main.GetValueSQL(jobWebConn, String.Format("SELECT BrName FROM Mas_Branch WHERE [Code]='{0}'", ViewBag.PROFILE_DEFAULT_BRANCH))
        ViewBag.PROFILE_LOGO = GetValueConfig("PROFILE", "COMPANY_LOGO")
        ViewBag.PROFILE_COMPANY_NAME = GetValueConfig("PROFILE", "COMPANY_NAME")
        ViewBag.PROFILE_COMPANY_FAX = GetValueConfig("PROFILE", "COMPANY_FAX")
        ViewBag.PROFILE_COMPANY_TEL = GetValueConfig("PROFILE", "COMPANY_TEL")
        ViewBag.PROFILE_COMPANY_EMAIL = GetValueConfig("PROFILE", "COMPANY_EMAIL")
        ViewBag.PROFILE_COMPANY_ADDR1 = GetValueConfig("PROFILE", "COMPANY_ADDRESS1")
        ViewBag.PROFILE_COMPANY_ADDR2 = GetValueConfig("PROFILE", "COMPANY_ADDRESS2")
        ViewBag.PROFILE_CURRENCY = GetValueConfig("PROFILE", "CURRENCY")
        ViewBag.PROFILE_VATRATE = GetValueConfig("PROFILE", "VATRATE")
        ViewBag.PROFILE_PAYMENT_CREDIT_DAYS = GetValueConfig("PROFILE", "PAYMENT_CREDIT_DAYS")
        ViewBag.PROFILE_TAXNUMBER = GetValueConfig("PROFILE", "COMPANY_TAXNUMBER")
        ViewBag.PROFILE_TAXBRANCH = GetValueConfig("PROFILE", "COMPANY_TAXBRANCH")
    End Sub
    Friend Function GetView(vName As String, Optional modName As String = "") As ActionResult
        Try
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
        Catch ex As Exception
            Return Redirect("~/index.html")
        End Try
    End Function
End Class
