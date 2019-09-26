Imports System.Web.Mvc

Public Class CController
    Inherits Controller
    Friend Sub ClearSession()
        Session("CurrUser") = Nothing
        Session("UserProfiles") = Nothing
        Session("DatabaseID") = Nothing
        Session("CurrLicense") = Nothing
        Session("ConnJob") = Nothing
        Session("ConnMas") = Nothing
        Session("CurrForm") = Nothing
        Session("CurrRights") = Nothing
        Session("CurrentLang") = Nothing
        Session("CurrBranch") = Nothing
        Session("CurrBranchName") = Nothing
        Session("CompanyLogo") = Nothing
        Session("CompanyName") = Nothing
        Session("CompanyFax") = Nothing
        Session("CompanyTel") = Nothing
        Session("CompanyEmail") = Nothing
        Session("CompanyAddr1") = Nothing
        Session("CompanyAddr2") = Nothing
        Session("Currency") = Nothing
        Session("VatRate") = Nothing
        Session("CreditDays") = Nothing
        Session("TaxNumber") = Nothing
        Session("TaxBranch") = Nothing
    End Sub
    Friend Function GetSession(sName As String) As String
        If IsNothing(Session(sName)) Then
            Select Case sName
                Case "CurrUser"
                    Session(sName) = ""
                Case "DatabaseID"
                    Session(sName) = "1"
                Case "CurrLicense"
                    Session(sName) = "Guest"
                Case "ConnJob"
                    Session(sName) = ""
                Case "ConnMas"
                    Session(sName) = ""
                Case "CurrRights"
                    Session(sName) = "*MIREDP"
                Case "CurrentLang"
                    Session(sName) = GetValueConfig("PROFILE", "DEFAULT_LANGUAGE", "EN")
                Case "CurrBranch"
                    Session(sName) = GetValueConfig("PROFILE", "DEFAULT_BRANCH")
                Case "CurrBranchName"
                    Session(sName) = Main.GetValueSQL(jobWebConn, String.Format("SELECT BrName FROM Mas_Branch WHERE [Code]='{0}'", ViewBag.PROFILE_DEFAULT_BRANCH)).Result
                Case "CompanyLogo"
                    Session(sName) = GetValueConfig("PROFILE", "COMPANY_LOGO", "logo-tawan.jpg")
                Case "CompanyName"
                    Session(sName) = GetValueConfig("PROFILE", "COMPANY_NAME")
                Case "CompanyFax"
                    Session(sName) = GetValueConfig("PROFILE", "COMPANY_FAX")
                Case "CompanyTel"
                    Session(sName) = GetValueConfig("PROFILE", "COMPANY_TEL")
                Case "CompanyEmail"
                    Session(sName) = GetValueConfig("PROFILE", "COMPANY_EMAIL")
                Case "CompanyAddr1"
                    Session(sName) = GetValueConfig("PROFILE", "COMPANY_ADDRESS1")
                Case "CompanyAddr2"
                    Session(sName) = GetValueConfig("PROFILE", "COMPANY_ADDRESS2")
                Case "Currency"
                    Session(sName) = GetValueConfig("PROFILE", "CURRENCY", "THB")
                Case "VatRate"
                    Session(sName) = GetValueConfig("PROFILE", "VATRATE", "0.07")
                Case "CreditDays"
                    Session(sName) = GetValueConfig("PROFILE", "PAYMENT_CREDIT_DAYS", "30")
                Case "TaxNumber"
                    Session(sName) = GetValueConfig("PROFILE", "COMPANY_TAXNUMBER")
                Case "TaxBranch"
                    Session(sName) = GetValueConfig("PROFILE", "COMPANY_TAXBRANCH")
                Case Else
                    Session(sName) = ""
            End Select
        End If
        Return Session(sName).ToString
    End Function
    Friend Function CheckSession(sName) As Boolean
        If IsNothing(Session(sName)) Then
            Return True
        Else
            Return False
        End If
    End Function
    Friend Function LoadCompanyProfile() As Boolean
        Dim bExpired = False

        jobWebConn = GetSession("ConnJob").ToString
        jobMasConn = GetSession("ConnMas").ToString

        ViewBag.User = GetSession("CurrUser").ToString
        If ViewBag.User = "" Then
            bExpired = True
            ViewBag.UserName = "**TIME OUT**"
        End If
        If CheckSession("UserProfiles") = False Then
            ViewBag.UserName = DirectCast(Session("UserProfiles"), CUser).TName
        End If
        ViewBag.CONNECTION_JOB = jobWebConn
        ViewBag.CONNECTION_MAS = jobMasConn
        ViewBag.DATABASE = GetSession("DatabaseID").ToString
        ViewBag.LICENSE_NAME = GetSession("CurrLicense").ToString
        ViewBag.PROFILE_DEFAULT_LANG = GetSession("CurrentLang").ToString()
        If jobWebConn <> "" Then
            ViewBag.PROFILE_DEFAULT_BRANCH = GetSession("CurrBranch").ToString
            ViewBag.PROFILE_DEFAULT_BRANCH_NAME = GetSession("CurrBranchName").ToString
            ViewBag.PROFILE_LOGO = GetSession("CompanyLogo").ToString
            ViewBag.PROFILE_COMPANY_NAME = GetSession("CompanyName").ToString
            ViewBag.PROFILE_COMPANY_FAX = GetSession("CompanyFax").ToString
            ViewBag.PROFILE_COMPANY_TEL = GetSession("CompanyTel").ToString
            ViewBag.PROFILE_COMPANY_EMAIL = GetSession("CompanyEmail").ToString
            ViewBag.PROFILE_COMPANY_ADDR1 = GetSession("CompanyAddr1").ToString
            ViewBag.PROFILE_COMPANY_ADDR2 = GetSession("CompanyAddr2").ToString
            ViewBag.PROFILE_CURRENCY = GetSession("Currency").ToString
            ViewBag.PROFILE_VATRATE = GetSession("VatRate").ToString
            ViewBag.PROFILE_PAYMENT_CREDIT_DAYS = GetSession("CreditDays").ToString
            ViewBag.PROFILE_TAXNUMBER = GetSession("TaxNumber").ToString
            ViewBag.PROFILE_TAXBRANCH = GetSession("TaxBranch").ToString
        Else
            ViewBag.PROFILE_DEFAULT_BRANCH = ""
            ViewBag.PROFILE_DEFAULT_BRANCH_NAME = ""
            ViewBag.PROFILE_LOGO = "tawan.jpg"
            ViewBag.PROFILE_COMPANY_NAME = ""
            ViewBag.PROFILE_COMPANY_FAX = ""
            ViewBag.PROFILE_COMPANY_TEL = ""
            ViewBag.PROFILE_COMPANY_EMAIL = ""
            ViewBag.PROFILE_COMPANY_ADDR1 = ""
            ViewBag.PROFILE_COMPANY_ADDR2 = ""
            ViewBag.PROFILE_CURRENCY = ""
            ViewBag.PROFILE_VATRATE = "7"
            ViewBag.PROFILE_PAYMENT_CREDIT_DAYS = ""
            ViewBag.PROFILE_TAXNUMBER = ""
            ViewBag.PROFILE_TAXBRANCH = ""
        End If
        ViewBag.SESSION_ID = Session.SessionID
        Return Not bExpired
    End Function
    Friend Function GetView(vName As String, Optional modName As String = "") As ActionResult
        Dim baseURL = Me.ControllerContext.RouteData.Values("Controller").ToString() & "\" & vName
        Try
            LoadCompanyProfile()
            If modName <> "" And ViewBag.User <> "" Then
                Session("CurrForm") = modName & "/" & vName
                ViewBag.Module = GetSession("CurrForm").ToString()
                Session("CurrRights") = Main.GetAuthorize(ViewBag.User, modName, vName)
                If Session("CurrRights").ToString().IndexOf("M") < 0 Then
                    Return RedirectToAction("AuthError", "Menu")
                End If
            Else
                Session("CurrForm") = Me.ControllerContext.RouteData.Values("Controller").ToString() & "/" & vName
                Session("CurrRights") = "*MIREDP"
                ViewBag.Module = GetSession("CurrForm").ToString()
            End If
            ViewBag.UserRights = GetSession("CurrRights").ToString()
            Return View(vName)
        Catch ex As Exception
            Return Redirect("~/index.html?message=" & ex.Message)
        End Try
    End Function
End Class
