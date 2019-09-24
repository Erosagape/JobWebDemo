Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json
Namespace Controllers
    Public Class MasterController
        Inherits CController
        ' GET: Customer
        Function Index() As ActionResult
            Return GetView("Index")
        End Function
        Function Branch() As ActionResult
            Return GetView("Branch", "MODULE_MAS")
        End Function
        Function ServiceCode() As ActionResult
            Return GetView("ServiceCode", "MODULE_MAS")
        End Function
        Function ServiceGroup() As ActionResult
            Return GetView("ServiceGroup", "MODULE_MAS")
        End Function
        Function Customers() As ActionResult
            Return GetView("Customers", "MODULE_MAS")
        End Function
        Function Currency() As ActionResult
            Return GetView("Currency", "MODULE_MAS")
        End Function
        Function Users() As ActionResult
            Return GetView("Users", "MODULE_MAS")
        End Function
        Function Venders() As ActionResult
            Return GetView("Venders", "MODULE_MAS")
        End Function
        Function Country() As ActionResult
            Return GetView("Country", "MODULE_MAS")
        End Function
        Function ServUnit() As ActionResult
            Return GetView("ServUnit", "MODULE_MAS")
        End Function
        Function DeclareType() As ActionResult
            Return GetView("DeclareType", "MODULE_MAS")
        End Function
        Function CustomsPort() As ActionResult
            Return GetView("CustomsPort", "MODULE_MAS")
        End Function
        Function InterPort() As ActionResult
            Return GetView("InterPort", "MODULE_MAS")
        End Function
        Function BookAccount() As ActionResult
            Return GetView("BookAccount", "MODULE_MAS")
        End Function
        Function Bank() As ActionResult
            Return GetView("Bank", "MODULE_MAS")
        End Function
        Function BudgetPolicy() As ActionResult
            Return GetView("BudgetPolicy", "MODULE_MAS")
        End Function
        Function CustomsUnit() As ActionResult
            Return GetView("CustomsUnit", "MODULE_MAS")
        End Function
        Function CompanyContact() As ActionResult
            Return GetView("CompanyContact", "MODULE_MAS")
        End Function
        Function AccountCode() As ActionResult
            Return GetView("AccountCode", "MODULE_ACC")
        End Function
        Function GetAccountCode() As ActionResult
            Try
                Dim tSqlw As String = " WHERE AccCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND AccCode Like '{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Group")) Then
                    tSqlw &= String.Format("AND AccMain ='{0}' ", Request.QueryString("Group").ToString)
                End If
                Dim oData = New CAccountCode(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""accountcode"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetAccountCode", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetAccountCode(<FromBody()> data As CAccountCode) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.AccCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE AccCode='{0}' ", data.AccCode))
                    Dim json = "{""result"":{""data"":""" & data.AccCode & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetAccountCode", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelAccountCode() As ActionResult
            Try
                Dim tSqlw As String = " WHERE AccCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND AccCode='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""accountcode"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CAccountCode(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""accountcode"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelAccountCode", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetCompanyContact() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ItemNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND CustCode='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND Branch='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format(" AND ItemNo={0}", Request.QueryString("Item").ToString)
                End If
                Dim oData = New CCompanyContact(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""companycontact"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetCompanyContact", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function Province() As ActionResult
            Return GetView("Province", "MODULE_MAS")
        End Function
        Function GetProvince() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ProvinceCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ProvinceCode ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CProvince(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""province"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetProvince", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetProvince(<FromBody()> data As CProvince) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.ProvinceCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE ProvinceCode='{0}' ", data.ProvinceCode))
                    Dim json = "{""result"":{""data"":""" & data.ProvinceCode & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetProvince", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelProvince() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ProvinceCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ProvinceCode='{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""province"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CProvince(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""province"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelProvince", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetProvinceSub() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ProvinceCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ProvinceCode='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CProvinceSub(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""province"":{""detail"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetProvinceSub", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetProvinceSub(<FromBody()> data As CProvinceSub) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.id = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE id='{0}' ", data.id))
                    Dim json = "{""result"":{""data"":""" & data.id & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetProvinceSub", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelProvinceSub() As ActionResult
            Try
                Dim tSqlw As String = " WHERE id<>'' "
                If Not IsNothing(Request.QueryString("ID")) Then
                    tSqlw &= String.Format("AND id Like '{0}'", Request.QueryString("ID").ToString)
                Else
                    Return Content("{""province"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CProvinceSub(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""province"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelProvinceSub", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetCompanyContact(<FromBody()> data As CCompanyContact) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.CustCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Customer""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE CustCode='{0}' AND Branch='{1}' AND ItemNo='{2}' ", data.CustCode, data.Branch, data.ItemNo))
                    Dim json = "{""result"":{""data"":""" & data.ItemNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetCompanyContact", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelCompanyContact() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ItemNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND CustCode='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND Branch='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format(" AND ItemNo={0}", Request.QueryString("Item").ToString)
                Else
                    Return Content("{""companycontact"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CCompanyContact(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""companycontact"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelCompanyContact", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function

        Function Vessel() As ActionResult
            Return GetView("Vessel", "MODULE_MAS")
        End Function
        Function GetVessel() As ActionResult
            Try
                Dim tSqlw As String = " WHERE RegsNumber<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND RegsNumber ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CVessel(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""vessel"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetVessel", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetVessel(<FromBody()> data As CVessel) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.RegsNumber = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE RegsNumber='{0}' ", data.RegsNumber))
                    Dim json = "{""result"":{""data"":""" & data.RegsNumber & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetVessel", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelVessel() As ActionResult
            Try
                Dim tSqlw As String = " WHERE RegsNumber<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND RegsNumber Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""vessel"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CVessel(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""vessel"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelVessel", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function

        Function GetServiceGroup() As ActionResult
            Try
                Dim tSqlw As String = " WHERE GroupCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND GroupCode ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CServiceGroup(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""servicegroup"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetServiceGroup", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetServiceGroup(<FromBody()> data As CServiceGroup) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.GroupCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE GroupCode='{0}' ", data.GroupCode))
                    If data.IsApplyPolicy = 1 Then
                        Dim cmd As New CUtil(jobWebConn)
                        Dim sql As String = "
UPDATE a
SET a.IsTaxCharge=b.IsTaxCharge,
a.Is50Tavi=b.Is50Tavi,
a.Rate50Tavi=b.Rate50Tavi,
a.IsCredit=b.IsCredit,
a.IsExpense=b.IsExpense,
a.IsHaveSlip=b.IsHaveSlip,
a.IsLtdAdv50Tavi=b.IsLtdAdv50Tavi
FROM Job_SrvSingle a
INNER JOIN Job_SrvGroup b
ON a.GroupCode=b.GroupCode
AND b.GroupCode='{0}'
AND b.IsApplyPolicy=1
"
                        cmd.ExecuteSQL(String.Format(sql, data.GroupCode))
                    End If
                    Dim json = "{""result"":{""data"":""" & data.GroupCode & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetServiceGroup", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelServiceGroup() As ActionResult
            Try
                Dim tSqlw As String = " WHERE GroupCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND GroupCode Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""servicegroup"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CServiceGroup(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""servicegroup"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelServiceGroup", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetBank() As ActionResult
            Try
                Dim tSqlw As String = " WHERE [Code]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Code] ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CBank(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""bank"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetBank", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetBank(<FromBody()> data As CBank) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.Code = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE [Code]='{0}' ", data.Code))
                    Dim json = "{""result"":{""data"":""" & data.Code & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetBank", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelBank() As ActionResult
            Try
                Dim tSqlw As String = " WHERE [Code]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Code] Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""bank"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CBank(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""bank"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelBank", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetBookAccount() As ActionResult
            Try
                Dim tSqlw As String = " WHERE BookCode<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BookCode ='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CBookAccount(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""bookaccount"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetBookAccount", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetBookBalance() As ActionResult
            Try
                Dim tSqlw As String = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND a.BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND c.BookCode ='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(String.Format(SQLSelectBookAccBalance(), tSqlw))
                Dim json As String = JsonConvert.SerializeObject(oData.Rows)
                json = "{""bookaccount"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetBookBalance", "ERROR", ex.Message)
                Return Content("{""bookaccount"":{""data"":[],""msg"":" & ex.Message & "}}", jsonContent)
            End Try
        End Function
        Function SetBookAccount(<FromBody()> data As CBookAccount) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BookCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND BookCode='{1}' ", data.BranchCode, data.BookCode))
                    Dim json = "{""result"":{""data"":""" & data.BookCode & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetBookAccount", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelBookAccount() As ActionResult
            Try
                Dim tSqlw As String = " WHERE BookCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BookCode = '{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""bookaccount"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                Dim oData As New CBookAccount(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""bookaccount"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelBookAccount", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetInterPort() As ActionResult
            Try
                Dim tSqlw As String = " WHERE PortCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND PortCode ='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Key")) Then
                    tSqlw &= String.Format(" AND CountryCode ='{0}'", Request.QueryString("Key").ToString)
                End If
                Dim oData = New CInterPort(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""interport"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetInterPort", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetInterPort(<FromBody()> data As CInterPort) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.PortCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Port Code""}}", jsonContent)
                    End If
                    If "" & data.CountryCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Country Code""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE PortCode='{0}' AND CountryCode='{1}' ", data.PortCode, data.CountryCode))
                    Dim json = "{""result"":{""data"":""" & data.PortCode & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetInterPort", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelInterPort() As ActionResult
            Try
                Dim tSqlw As String = " WHERE PortCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND PortCode Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""interport"":{""result"":""Please Select Port Code"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Key")) Then
                    tSqlw &= String.Format(" AND CountryCode Like '{0}'", Request.QueryString("Key").ToString)
                Else
                    Return Content("{""interport"":{""result"":""Please Select Country Code"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CInterPort(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""interport"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelInterPort", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function

        Function GetCustomsPort() As ActionResult
            Try

                Dim tSqlw As String = " WHERE AreaCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND AreaCode ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CCustomsPort(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""RFARS"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetCustomsPort", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetCustomsPort(<FromBody()> data As CCustomsPort) As ActionResult

            Try
                If Not IsNothing(data) Then
                    If "" & data.AreaCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE AreaCode='{0}' ", data.AreaCode))
                    Dim json = "{""result"":{""data"":""" & data.AreaCode & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetCustomsPort", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try

        End Function
        Function DelCustomsPort() As ActionResult

            Try
                Dim tSqlw As String = " WHERE AreaCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND AreaCode Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""RFARS"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CCustomsPort(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""RFARS"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelCustomsPort", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try

        End Function
        Function SetDeclareType(<FromBody()> data As CDeclareType) As ActionResult

            Try
                If Not IsNothing(data) Then
                    If "" & data.Type = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE Type='{0}' ", data.Type))
                    Dim json = "{""result"":{""data"":""" & data.Type & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetDeclareType", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try

        End Function
        Function DelDeclareType() As ActionResult

            Try
                Dim tSqlw As String = " WHERE Type<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND Type Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""RFDCT"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CDeclareType(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""RFDCT"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelDeclareType", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try

        End Function
        Function GetServUnit() As ActionResult
            Try

                Dim tSqlw As String = " WHERE UnitType<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND UnitType ='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Type")) Then
                    tSqlw &= String.Format("AND IsCTNUnit={0} ", Request.QueryString("Type").ToString)
                End If
                Dim oData = New CServUnit(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""servunit"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetServUnit", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetServUnit(<FromBody()> data As CServUnit) As ActionResult

            Try
                If Not IsNothing(data) Then
                    If "" & data.UnitType = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE UnitType='{0}' ", data.UnitType))
                    Dim json = "{""result"":{""data"":""" & data.UnitType & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetServUnit", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try

        End Function
        Function DelServUnit() As ActionResult

            Try
                Dim tSqlw As String = " WHERE UnitType<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND UnitType Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""servunit"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CServUnit(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""servunit"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelServUnit", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try

        End Function
        Function GetDeclareType() As ActionResult
            Try
                Dim tSqlw As String = " WHERE [Type]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Type]='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CDeclareType(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""RFDCT"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetDeclareType", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try

        End Function

        Function GetCurrency() As ActionResult
            Try
                Dim tSqlw As String = " WHERE [Code]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Code]='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CCurrency(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""currency"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetCurrency", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try

        End Function
        Function SetCurrency(<FromBody()> data As CCurrency) As ActionResult

            Try
                If Not IsNothing(data) Then
                    If "" & data.Code = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE [Code]='{0}' ", data.Code))
                    Dim json = "{""result"":{""data"":""" & data.Code & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetCurrency", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try

        End Function
        Function DelCurrency() As ActionResult

            Try
                Dim tSqlw As String = " WHERE [Code]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Code] ='{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""currency"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CCurrency(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""currency"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelCurrency", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try

        End Function
        Function GetUser() As ActionResult
            Try
                Dim tSqlw As String = " WHERE UserID<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND UserID='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Pass")) Then
                    tSqlw &= String.Format("AND UPassword='{0}'", Request.QueryString("Pass").ToString)
                End If
                Dim oData = New CUser(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""user"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetUser", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetNewCompany() As ActionResult
            Try
                Dim oData = New CCompany(jobWebConn)
                oData.AddNew()
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""company"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetNewCompany", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetNewUser() As ActionResult
            Try
                Dim oData = New CUser(jobWebConn)
                oData.AddNew()
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""user"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetNewUser", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetNewVender() As ActionResult
            Try
                Dim oData = New CVender(jobWebConn)
                oData.AddNew()
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""vender"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetNewVender", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetCountry() As ActionResult
            Try
                Dim tSqlw As String = " WHERE CTYCODE<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND CTYCODE ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CCountry(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""country"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetCountry", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetCountry(<FromBody()> data As CCountry) As ActionResult

            Try
                If Not IsNothing(data) Then
                    If "" & data.CTYCODE = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE CTYCODE='{0}' ", data.CTYCODE))
                    Dim json = "{""result"":{""data"":""" & data.CTYCODE & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetCountry", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try

        End Function
        Function DelCountry() As ActionResult

            Try
                Dim tSqlw As String = " WHERE CTYCODE<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND CTYCODE Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""country"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CCountry(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""country"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelCountry", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try

        End Function
        Function GetCompany() As ActionResult
            Try
                Dim tSqlw As String = " WHERE CustCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND CustCode='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND Branch='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    tSqlw &= String.Format(" AND TaxNumber='{0}'", Request.QueryString("TaxNumber").ToString)
                End If
                If Not IsNothing(Request.QueryString("Group")) Then
                    tSqlw &= String.Format(" AND CustGroup IN('{0}')", Request.QueryString("Group").ToString.Replace(",", "','"))
                End If
                Dim oData = New CCompany(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                Dim oContact = New CCompanyContact(jobWebConn).GetData(tSqlw)
                Dim jsonc As String = JsonConvert.SerializeObject(oContact)
                json = "{""company"":{""data"":" & json & ",""contact"":" & jsonc & "},""sql"":""" & tSqlw & """}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetCompany", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetVender() As ActionResult
            Try
                Dim tSqlw As String = " WHERE VenCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND VenCode='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CVender(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""vender"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetVender", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function DelServiceCode() As ActionResult
            Try
                Dim tSqlw As String = " WHERE SICode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND SICode Like '{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData As New CServiceCode(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""servicecode"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelServiceCode", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function DelVender() As ActionResult
            Try
                Dim tSqlw As String = " WHERE VenCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND VenCode Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""vender"":{""result"":""Please Select Some Vender"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CVender(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""vender"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelVender", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function DelCompany() As ActionResult
            Try
                Dim tSqlw As String = " WHERE CustCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND CustCode = '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""company"":{""result"":""Please Select Some Customer"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND Branch = '{0}'", Request.QueryString("Branch").ToString)
                End If
                Dim oData As New CCompany(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""company"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelCompany", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function

        Function DelUser() As ActionResult
            Try
                Dim tSqlw As String = " WHERE UserID<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND UserID Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""user"":{""result"":""Please Select Some User"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CUser(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""user"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelUser", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetServiceCode() As ActionResult
            Try
                Dim tSqlw As String = " WHERE SICode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND SICode Like '{0}%' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Group")) Then
                    tSqlw &= String.Format("AND GroupCode Like '{0}%' ", Request.QueryString("Group").ToString)
                End If
                If Not IsNothing(Request.QueryString("Type")) Then
                    Dim type = Request.QueryString("Type").ToString
                    Select Case type
                        Case "A"
                            tSqlw &= "AND IsCredit=1 AND IsExpense=0 "
                        Case "C"
                            tSqlw &= "AND IsExpense=1 "
                        Case "S"
                            tSqlw &= "AND IsCredit=0 AND IsExpense=0 "
                    End Select
                End If
                Dim oData = New CServiceCode(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""servicecode"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetServiceCode", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetNewServiceCode() As ActionResult
            Try
                Dim oData = New CServiceCode(jobWebConn)
                Dim msg As String = "OK"
                oData.AddNew("")
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""servicecode"":{""data"":[" & json & "],""result"":""" & msg & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetNewServiceCode", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetCompany(<FromBody()> data As CCompany) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.CustCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter CustCode""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE CustCode='{0}' And Branch='{1}' ", data.CustCode, data.Branch))
                    Dim json = "{""result"":{""data"":""" & data.CustCode & """,""msg"":""" & msg & """}}"
                    'Dim msg = JsonConvert.SerializeObject(data)
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetCompany", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function SetVender(<FromBody()> data As CVender) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.VenCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Vender Code""}}", jsonContent)
                    End If

                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE VenCode='{0}' ", data.VenCode))
                    Dim json = "{""result"":{""data"":""" & data.VenCode & """,""msg"":""" & msg & """}}"
                    'Dim msg = JsonConvert.SerializeObject(data)
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetVender", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function SetUser(<FromBody()> data As CUser) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.UserID = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter User ID""}}", jsonContent)
                    End If

                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE UserID='{0}' ", data.UserID))
                    Dim json = "{""result"":{""data"":""" & data.UserID & """,""msg"":""" & msg & """}}"
                    'Dim msg = JsonConvert.SerializeObject(data)
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetUser", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function SetServiceCode(<FromBody()> data As CServiceCode) As ActionResult
            Try
                If Not IsNothing(data) Then
                    data.SetConnect(jobWebConn)
                    If data.SICode.ToString().Substring(data.SICode.ToString().Length - 1, 1) = "-" Then
                        data.AddNew(data.SICode + "___")
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE SICode='{0}' ", data.SICode))
                    Dim json = "{""result"":{""data"":""" & data.SICode & """,""msg"":""" & msg & """}}"
                    'Dim msg = JsonConvert.SerializeObject(data)
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetServicecode", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function GetBranch() As ActionResult
            Try
                Dim tSqlw As String = " WHERE [Code]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Code]='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CBranch(jobWebConn).GetData("SELECT * FROM Mas_Branch " & tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""branch"":{""data"":""" & json & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetBranch", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetBranch(<FromBody()> data As CBranch) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.Code = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE [Code]='{0}' ", data.Code))
                    Dim json = "{""result"":{""data"":""" & data.Code & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetBranch", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try

        End Function
        Function DelBranch() As ActionResult

            Try
                Dim tSqlw As String = " WHERE [Code]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Code] Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""branch"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CBranch(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""branch"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelBranch", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetServiceBudget() As ActionResult
            Try
                Dim tSqlW As String = " AND b.Active=1 "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlW &= String.Format(" AND b.BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("JType")) Then
                    tSqlW &= String.Format(" AND b.JobType={0} ", Request.QueryString("JType").ToString)
                End If
                If Not IsNothing(Request.QueryString("SBy")) Then
                    tSqlW &= String.Format(" AND b.ShipBy={0} ", Request.QueryString("SBy").ToString)
                End If

                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(Main.SQLSelectServiceBudget() & tSqlW)
                Dim json As String = JsonConvert.SerializeObject(oData.Rows)
                json = "{""budgetpolicy"":{""data"":" & json & ",""msg"":""OK""}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetServiceBudget", "ERROR", ex.Message)
                Return Content("{""budgetpolicy"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function GetBudgetPolicy() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ID<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND ID={0}", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CBudgetPolicy(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""budgetpolicy"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetBudgetPolicy", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetBudgetPolicy(<FromBody()> data As CBudgetPolicy) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.ID = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE ID={0} ", data.ID))
                    Dim json = "{""result"":{""data"":""" & data.ID & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetBudgetPolicy", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelBudgetPolicy() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ID<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ID Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""budgetpolicy"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CBudgetPolicy(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""budgetpolicy"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelBudgetPolicy", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetCustomsUnit() As ActionResult
            Try
                Dim tSqlw As String = " WHERE [Code]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Code] ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CCustomsUnit(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""customsunit"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetCustomsUnit", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetCustomsUnit(<FromBody()> data As CCustomsUnit) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.Code = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE [Code]='{0}' ", data.Code))
                    Dim json = "{""result"":{""data"":""" & data.Code & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetCustomsUnit", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelCustomsUnit() As ActionResult
            Try
                Dim tSqlw As String = " WHERE [Code]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Code] Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""customsunit"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CCustomsUnit(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""customsunit"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelCustomsUnit", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function

    End Class
End Namespace