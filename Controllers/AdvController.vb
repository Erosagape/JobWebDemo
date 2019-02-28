Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json
Imports System.Data.SqlClient
Imports System.Net.Http
Imports System.Net

Namespace Controllers
    Public Class AdvController
        Inherits CController
        ' GET: Advance
        Function Index() As ActionResult
            Return GetView("Index", "MODULE_ADV")
        End Function
        Function Approve() As ActionResult
            Return GetView("Approve", "MODULE_ADV")
        End Function
        Function Payment() As ActionResult
            Return GetView("Payment", "MODULE_ADV")
        End Function
        Function CreditAdv() As ActionResult
            Return GetView("CreditAdv", "MODULE_ADV")
        End Function
        Function EstimateCost() As ActionResult
            Return View()
        End Function
        Function FormCreditAdv() As ActionResult
            Return View()
        End Function
        Function FormAdv() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Index")
            If AuthorizeStr.IndexOf("P") < 0 Then
                Return Content("You are not allow to print advance", textContent)
            End If
            Return GetView("FormAdv")
        End Function
        Function PaymentAdvance(<FromBody()> ByVal data As String()) As HttpResponseMessage
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Payment")
                If AuthorizeStr.IndexOf("I") < 0 Then
                    Return New HttpResponseMessage(HttpStatusCode.BadRequest)
                End If

                If IsNothing(data) Then
                    Return New HttpResponseMessage(HttpStatusCode.BadRequest)
                End If

                Dim json As String = ""
                Dim lst As String = ""
                Dim user As String = ""
                Dim docno As String = ""
                Dim i As Integer = 0
                For Each str As String In data
                    i = i + 1
                    If i = 1 Then
                        user = str.Split("|")(0)
                        docno = str.Split("|")(1)
                    Else
                        If str.IndexOf("|") >= 0 Then
                            If lst <> "" Then lst &= ","
                            lst &= "'" & str & "'"
                        End If
                    End If
                Next

                If lst <> "" Then
                    Dim tSQL As String = String.Format("UPDATE Job_AdvHeader SET DocStatus=3,PaymentRef='" & docno & "',PaymentBy='" & user & "',PaymentDate='" & DateTime.Now.ToString("yyyy-MM-dd") & "',PaymentTime='" & DateTime.Now.ToString("HH:mm:ss") & "' 
 WHERE DocStatus=2 AND BranchCode+'|'+AdvNo in({0})", lst)
                    Dim result = Main.DBExecute(jobWebConn, tSQL)
                    If result = "OK" Then
                        Return New HttpResponseMessage(HttpStatusCode.OK)
                    End If
                End If
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            Catch ex As Exception
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End Try
        End Function
        Function ApproveAdvance(<FromBody()> ByVal data As String()) As HttpResponseMessage
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Approve")
                If AuthorizeStr.IndexOf("I") < 0 Then
                    Return New HttpResponseMessage(HttpStatusCode.BadRequest)
                End If

                If IsNothing(data) Then
                    Return New HttpResponseMessage(HttpStatusCode.BadRequest)
                End If

                Dim json As String = ""
                Dim lst As String = ""
                Dim user As String = ""
                For Each str As String In data
                    If str.IndexOf("|") >= 0 Then
                        If lst <> "" Then lst &= ","
                        lst &= "'" & str & "'"
                    Else
                        user = str
                    End If
                Next

                If lst <> "" Then
                    Dim tSQL As String = String.Format("UPDATE Job_AdvHeader SET DocStatus=2,ApproveBy='" & user & "',ApproveDate='" & DateTime.Now.ToString("yyyy-MM-dd") & "',ApproveTime='" & DateTime.Now.ToString("HH:mm:ss") & "' 
 WHERE DocStatus=1 AND BranchCode+'|'+AdvNo in({0})", lst)
                    Dim result = Main.DBExecute(jobWebConn, tSQL)
                    If result = "OK" Then
                        Return New HttpResponseMessage(HttpStatusCode.OK)
                    End If
                End If
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            Catch ex As Exception
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End Try
        End Function
        Function SaveAdvanceHeader(<FromBody()> ByVal data As CAdvHeader) As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Index")
                If Not IsNothing(data) Then
                    data.SetConnect(jobWebConn)

                    If data.AdvNo = "" Then
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            Return Content("{""result"":{""data"":null,""msg"":""You are not allow to add advance""}}", jsonContent)
                        End If
                        data.AddNew(advPrefix & "-" & DateTime.Now.ToString("yyMM") & "____")
                    End If

                    If AuthorizeStr.IndexOf("E") < 0 Then
                        Return Content("{""result"":{""data"":null,""msg"":""You are not allow to edit advance""}}", jsonContent)
                    End If

                    Dim msg As String = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND AdvNo='{1}'", data.BranchCode, data.AdvNo))
                    Dim json = "{""result"":{""data"":""" & data.AdvNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If

            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" + ex.Message + """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function SaveAdvanceDetail(<FromBody()> ByVal data As CAdvDetail) As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Index")
                If Not IsNothing(data) Then
                    data.SetConnect(jobWebConn)

                    If data.ItemNo = 0 Then
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            Return Content("{""result"":{""data"":null,""msg"":""You are not allow to add advance""}}", jsonContent)
                        End If
                    End If

                    If AuthorizeStr.IndexOf("E") < 0 Then
                        Return Content("{""result"":{""data"":null,""msg"":""You are not allow to add advance""}}", jsonContent)
                    End If

                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND AdvNo='{1}' AND ItemNo={2} ", data.BranchCode, data.AdvNo, data.ItemNo))
                    'Dim msg = JsonConvert.SerializeObject(data)
                    Dim json = "{""result"":{""data"":""" & data.ItemNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" + ex.Message + """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelAdvanceDetail() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Index")
                If AuthorizeStr.IndexOf("D") < 0 Then
                    Return Content("{""adv"":{""result"":""You are not allow to Delete item In advance""}}", jsonContent)
                End If

                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If

                Dim tSqlW As String = String.Format(" WHERE BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    tSqlW &= " AND AdvNo='" & Request.QueryString("AdvNo") & "'"
                End If

                Dim ItemNo As String = "0"
                If Not IsNothing(Request.QueryString("ItemNo")) Then
                    ItemNo = Request.QueryString("ItemNo")
                End If
                tSqlW &= " AND ItemNo=" & ItemNo & ""

                Dim oADVD As New CAdvDetail(jobWebConn)
                Dim msg As String = oADVD.DeleteData(tSqlW)

                Dim json = "{""adv"":{""result"":""" & msg & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Dim json = "{""adv"":{""result"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelAdvanceHeader() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Index")
                If AuthorizeStr.IndexOf("D") < 0 Then
                    Return Content("{""adv"":{""result"":""you are not allow to delete advance""}}", jsonContent)
                End If

                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If

                Dim tSqlW As String = String.Format(" WHERE BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    tSqlW &= " AND AdvNo='" & Request.QueryString("AdvNo") & "'"
                End If

                Dim oAdvH As New CAdvHeader(jobWebConn)
                Dim msg As String = oAdvH.DeleteData(tSqlW)
                Dim oAdvD As New CAdvDetail(jobWebConn)
                Dim msgD As String = oAdvD.DeleteData(tSqlW)

                Dim json = "{""adv"":{""result"":""" & msg & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Dim json = "{""adv"":{""result"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function GetNewAdvanceHeader() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Index")
                If AuthorizeStr.IndexOf("I") < 0 Then
                    Return Content("[]", jsonContent)
                End If

                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If

                Dim oAdvH As New CAdvHeader(jobWebConn)
                oAdvH.BranchCode = Branch
                oAdvH.AdvNo = ""
                oAdvH.AdvDate = DateTime.Today
                oAdvH.DocStatus = 1

                Dim oAdvD As New CAdvDetail(jobWebConn) With {
                    .BranchCode = Branch,
                    .AdvNo = "",
                    .ItemNo = 0
                }

                Dim jsonh As String = JsonConvert.SerializeObject(oAdvH)
                Dim jsond As String = JsonConvert.SerializeObject(oAdvD)
                Dim json = "{""adv"":{""header"":" & jsonh & ",""detail"":" & jsond & ",""result"":""OK""}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetNewAdvanceDetail() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Index")
                If AuthorizeStr.IndexOf("I") < 0 Then
                    Return Content("[]", jsonContent)
                End If

                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If

                Dim AdvNo As String = ""
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    AdvNo = Request.QueryString("AdvNo")
                End If

                Dim oAdvD As New CAdvDetail(jobWebConn) With
                    {
                        .BranchCode = Branch,
                        .AdvNo = AdvNo,
                        .ItemNo = 0
                    }

                'Dim msg As String = oAdvD.SaveData(String.Format(" WHERE BranchCode='{0}' And AdvNo='{1}' And ItemNo={2}", oAdvD.BranchCode, oAdvD.AdvNo, oAdvD.ItemNo))
                Dim jsonh As String = JsonConvert.SerializeObject(oAdvD)
                Dim json = "{""adv"":{""detail"":" & jsonh & ",""result"":""OK""}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetAdvanceGrid() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Index")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""adv"":{""data"":[],""msg"":""You Are not authorize to view data""}}", jsonContent)
                End If

                Dim Branch As String = ""
                Dim JobNo As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If

                Dim tSqlW As String = String.Format(" WHERE a.BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("JobNo")) Then
                    tSqlW &= " AND a.AdvNo IN(SELECT AdvNo FROM Job_AdvDetail WHERE BranchCode='" & Branch & "' And ForJNo='" & Request.QueryString("JobNo") & "')"
                End If
                If Not IsNothing(Request.QueryString("JType")) Then
                    tSqlW &= " AND a.JobType=" & Request.QueryString("JType") & ""
                End If
                If Not IsNothing(Request.QueryString("SBy")) Then
                    tSqlW &= " AND a.ShipBy=" & Request.QueryString("SBy") & ""
                End If
                If Not IsNothing(Request.QueryString("ReqBy")) Then
                    tSqlW &= " AND a.Empcode='" & Request.QueryString("ReqBy") & "'"
                End If
                If Not IsNothing(Request.QueryString("CustCode")) Then
                    tSqlW &= " AND a.CustCode='" & Request.QueryString("CustCode") & "'"
                End If
                If Not IsNothing(Request.QueryString("CustBranch")) Then
                    tSqlW &= " AND a.CustBranch='" & Request.QueryString("CustBranch") & "'"
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlW &= " AND a.Advdate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlW &= " AND a.Advdate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlW &= " AND a.DocStatus='" & Request.QueryString("Status") & "' "
                End If

                Dim sql As String = "
select a.*,
(SELECT STUFF((
SELECT DISTINCT ',' + ForJNo
FROM Job_AdvDetail WHERE BranchCode=a.BranchCode
AND AdvNo=a.AdvNo AND ForJNo<>'' 
FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
)) as JobNo
,
(SELECT STUFF((
SELECT DISTINCT ',' + InvNo
FROM Job_Order WHERE BranchCode=a.BranchCode AND JNo in(SELECT ForJNo FROM Job_AdvDetail WHERE BranchCode=a.BranchCode
AND AdvNo=a.AdvNo AND ForJNo<>'')
FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
)) as CustInvNo
FROM Job_AdvHeader as a
"
                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL(sql + tSqlW)
                Dim json = "{""adv"":{""data"":" & JsonConvert.SerializeObject(oData.AsEnumerable().ToList()) & ",""msg"":""" & tSqlW & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("{""adv"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function GetAdvance() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Index")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""adv"":{""header"":[],""detail"":[],""msg"":""You Are not authorize to view data""}}", jsonContent)
                End If

                Dim oAdvH As New CAdvHeader(jobWebConn)
                Dim oADVD As New CAdvDetail(jobWebConn)
                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If
                Dim tSqlW As String = String.Format(" WHERE BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    tSqlW &= " AND AdvNo='" & Request.QueryString("AdvNo") & "'"
                End If

                Dim oDataH = oAdvH.GetData(tSqlW)
                Dim oDataD = oADVD.GetData(tSqlW)

                Dim jsonh As String = JsonConvert.SerializeObject(oDataH)
                Dim jsond As String = JsonConvert.SerializeObject(oDataD)
                Dim json = "{""adv"":{""header"":" & jsonh & ",""detail"":" & jsond & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetAdvanceDetail() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Index")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""adv"":{""detail"":[],""msg"":""You Are not authorize to view data""}}", jsonContent)
                End If

                Dim oADVD As New CAdvDetail(jobWebConn)
                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If

                Dim tSqlW As String = String.Format(" WHERE BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    tSqlW &= " AND AdvNo='" & Request.QueryString("AdvNo") & "'"
                End If

                Dim oDataD = oADVD.GetData(tSqlW)
                Dim jsond As String = JsonConvert.SerializeObject(oDataD)
                Dim json = "{""adv"":{""detail"":" & jsond & "}}"

                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
    End Class
End Namespace