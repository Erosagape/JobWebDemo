Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json
Namespace Controllers
    Public Class ClrController
        Inherits CController
        ' GET: Clr
        Function Index() As ActionResult
            Return GetView("Index", "MODULE_CLR")
        End Function
        Function Approve() As ActionResult
            Return GetView("Approve", "MODULE_CLR")
        End Function
        Function Receive() As ActionResult
            Return GetView("Receive", "MODULE_CLR")
        End Function
        Function FormClr() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
            If AuthorizeStr.IndexOf("P") < 0 Then
                Return Content("You are not allow to print clear", textContent)
            End If
            Return GetView("FormClr")
        End Function
        Function Costing() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Costing")
            If AuthorizeStr.IndexOf("M") < 0 Then
                Return Content("You are not allow to view costing", textContent)
            End If
            Return GetView("Costing", "MODULE_ACC")
        End Function
        Function GenerateInv() As ActionResult
            Return GetView("GenerateInv", "MODULE_ACC")
        End Function
        Function Earnest() As ActionResult
            Return GetView("Earnest", "MODULE_CLR")
        End Function

        '-----Controller-----
        Function ApproveClearing(<FromBody()> ByVal data As String()) As HttpResponseMessage
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Approve")
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
                    Dim tSQL As String = String.Format("UPDATE Job_ClearHeader SET DocStatus=2,ApproveBy='" & user & "',ApproveDate='" & DateTime.Now.ToString("yyyy-MM-dd") & "',ApproveTime='" & DateTime.Now.ToString("HH:mm:ss") & "' 
 WHERE DocStatus=1 AND BranchCode+'|'+ClrNo in({0})", lst)
                    Dim result = Main.DBExecute(jobWebConn, tSQL)
                    If result = "OK" Then
                        Return New HttpResponseMessage(HttpStatusCode.OK)
                    End If
                End If
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "ApproveClearing", "ERROR", ex.Message)
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End Try
        End Function
        Function ReceiveEarnest(<FromBody()> data As String()) As HttpResponseMessage
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Earnest")
            If AuthorizeStr.IndexOf("I") < 0 Then
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End If
            If IsNothing(data) Then
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End If

            Dim lst As String = ""
            Dim docno As String = ""
            Dim i As Integer = 0
            For Each str As String In data
                i += 1
                If i = 1 Then
                    docno = str
                Else
                    If str.IndexOf("|") >= 0 Then
                        If lst <> "" Then lst &= ","
                        lst &= "'" & str & "'"
                    End If
                End If
            Next

            If lst <> "" Then
                Dim tSQL As String = String.Format("UPDATE Job_ClearDetail SET LinkBillNo='{0}',LinkItem=1,UsedAmount=0,ChargeVAT=0,Tax50Tavi=0,FNet=0,BNet=0 WHERE BranchCode+'|'+ClrNo+'|'+Convert(varchar,ItemNo) in({1})", docno, lst)
                Dim result = Main.DBExecute(jobWebConn, tSQL)
                If result = "OK" Then
                    Return New HttpResponseMessage(HttpStatusCode.OK)
                End If
            End If
            Return New HttpResponseMessage(HttpStatusCode.NoContent)
        End Function
        Function ReceiveClearing(<FromBody()> data As String()) As HttpResponseMessage
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
            If AuthorizeStr.IndexOf("I") < 0 Then
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End If
            If IsNothing(data) Then
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End If

            Dim lst As String = ""
            Dim i As Integer = 0
            Dim doctype As String = "CLR"
            For Each str As String In data
                i += 1
                If i = 1 Then
                    Dim user As String = str.Split("|")(0)
                    Dim docno As String = str.Split("|")(1)
                    doctype = str.Split("|")(2)
                Else
                    If str.IndexOf("|") >= 0 Then
                        If lst <> "" Then lst &= ","
                        lst &= "'" & str & "'"
                    End If
                End If
            Next

            If lst <> "" Then
                If doctype = "CLR" Then
                    Dim tSQL As String = String.Format("UPDATE Job_ClearHeader SET DocStatus=3 WHERE DocStatus<3 AND BranchCode+'|'+ClrNo in({0})", lst)
                    Dim result = Main.DBExecute(jobWebConn, tSQL)
                    If result = "OK" Then
                        Return New HttpResponseMessage(HttpStatusCode.OK)
                    End If
                End If
                If doctype = "ADV" Then
                    Dim tSQL As String = String.Format("UPDATE Job_AdvHeader SET DocStatus=6 WHERE DocStatus<6 AND BranchCode+'|'+AdvNo in({0})", lst)
                    Dim result = Main.DBExecute(jobWebConn, tSQL)
                    If result = "OK" Then
                        Return New HttpResponseMessage(HttpStatusCode.OK)
                    End If
                End If

            End If
            Return New HttpResponseMessage(HttpStatusCode.NoContent)
        End Function
        Function GetClearingReport() As ActionResult
            Dim branch As String = ""
            If Not Request.QueryString("Branch") Is Nothing Then
                branch = Request.QueryString("Branch").ToString
            End If
            Dim sql As String = SQLSelectClrDetail() & String.Format(" WHERE h.BranchCode='{0}' ", branch)
            Try
                If Not Request.QueryString("Code") Is Nothing Then
                    sql &= " AND h.ClrNo='" & Request.QueryString("Code").ToString & "' "
                End If

                If Not Request.QueryString("Job") Is Nothing Then
                    sql &= " AND d.JobNo='" & Request.QueryString("Job").ToString & "' AND h.DocStatus<>99 "
                End If

                If Not IsNothing(Request.QueryString("JType")) Then
                    sql &= " AND h.JobType=" & Request.QueryString("JType") & ""
                End If
                If Not IsNothing(Request.QueryString("CFrom")) Then
                    sql &= " AND h.ClearFrom=" & Request.QueryString("CFrom") & ""
                End If
                If Not IsNothing(Request.QueryString("CType")) Then
                    sql &= " AND h.ClearType=" & Request.QueryString("CType") & ""
                End If
                If Not IsNothing(Request.QueryString("ClrBy")) Then
                    sql &= " AND h.EmpCode='" & Request.QueryString("ClrBy") & "'"
                End If
                If Not IsNothing(Request.QueryString("CustCode")) Then
                    sql &= " AND j.CustCode='" & Request.QueryString("CustCode") & "'"
                End If
                If Not IsNothing(Request.QueryString("CustBranch")) Then
                    sql &= " AND j.CustBranch='" & Request.QueryString("CustBranch") & "'"
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    sql &= " AND h.ClrDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    sql &= " AND h.ClrDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    sql &= " AND h.DocStatus='" & Request.QueryString("Status") & "' "
                Else
                    sql &= " AND h.DocStatus<>99 "
                End If
                If Not IsNothing(Request.QueryString("SICode")) Then
                    sql &= " AND d.SICode='" & Request.QueryString("SICode") & "' "
                End If
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    sql &= " AND j.CustCode IN(Select CustCode from Mas_Company where TaxNumber='" & Request.QueryString("TaxNumber") & "') "
                End If
                If Not IsNothing(Request.QueryString("Condition")) Then
                    Select Case Request.QueryString("Condition").ToString()
                        Case "ERN"
                            sql &= " AND d.LinkBillNo is null AND d.BNet > 0 "
                    End Select
                End If
                sql &= " ORDER BY h.BranchCode,h.ClrDate DESC,h.ClrNo,j.CustCode,j.CustBranch,d.ItemNo "

                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(sql)
                Dim json = "{""data"":" & JsonConvert.SerializeObject(oData.AsEnumerable().ToList()) & "}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetClearingReport", "ERROR", ex.Message)
                Return Content("{""data"":[],""msg"":""" & ex.Message & """}", jsonContent)
            End Try

        End Function
        Function GetClearingSum() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""clr"":{""data"":[],""msg"":""You Are not authorize to view data""}}", jsonContent)
                End If

                Dim Branch As String = ""
                Dim JobNo As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If

                Dim tSqlW As String = String.Format(" WHERE h.BranchCode='{0}'", Branch)

                Dim tbPrefix = "a"
                If Not IsNothing(Request.QueryString("Data")) Then
                    If Request.QueryString("Data").ToString = "CLR" Then
                        tbPrefix = "h"
                    End If
                    tSqlW &= " And h.DocStatus<3"
                End If
                Dim bClrDoc As Boolean = False
                If Not IsNothing(Request.QueryString("ClrNo")) Then
                    tSqlW &= " AND h.ClrNo='" & Request.QueryString("ClrNo") & "'"
                    bClrDoc = True
                End If
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    tSqlW &= " AND a.AdvNo='" & Request.QueryString("AdvNo") & "'"
                    bClrDoc = True
                End If
                If Not IsNothing(Request.QueryString("JType")) Then
                    tSqlW &= " AND " & tbPrefix & ".JobType=" & Request.QueryString("JType") & ""
                End If
                If Not IsNothing(Request.QueryString("AdvBy")) Then
                    tSqlW &= " AND " & tbPrefix & ".EmpCode='" & Request.QueryString("AdvBy") & "'"
                End If
                If Not IsNothing(Request.QueryString("CustCode")) Then
                    tSqlW &= " AND " & Replace(tbPrefix, "h", "j") & ".CustCode='" & Request.QueryString("CustCode") & "'"
                End If
                If Not IsNothing(Request.QueryString("CustBranch")) Then
                    tSqlW &= " AND " & Replace(tbPrefix, "h", "j") & ".CustBranch='" & Request.QueryString("CustBranch") & "'"
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlW &= " AND " & IIf(tbPrefix = "a", "a.PaymentDate", "h.ClrDate") & ">='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlW &= " AND " & IIf(tbPrefix = "a", "a.PaymentDate", "h.ClrDate") & "<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                If bClrDoc = False Then
                    If tbPrefix = "a" Then
                        tSqlW &= " AND a.AdvNo IS NOT NULL"
                        tSqlW &= " AND a.AdvNo+'#'+Convert(varchar,a.ItemNo) NOT IN(SELECT c1.DocNo FROM Job_CashControlDoc c1 inner join Job_CashControl c2 on c1.BranchCode=c2.BranchCode and c1.ControlNo=c2.ControlNo where ISNULL(c2.CancelProve,'')='')"
                    Else
                        tSqlW &= " AND a.AdvNo IS NULL"
                        tSqlW &= " AND h.ClrNo+'#'+Convert(varchar,d.ItemNo) NOT IN(SELECT c1.DocNo FROM Job_CashControlDoc c1 inner join Job_CashControl c2 on c1.BranchCode=c2.BranchCode and c1.ControlNo=c2.ControlNo where ISNULL(c2.CancelProve,'')='')"
                    End If
                Else
                    If tbPrefix = "a" Then
                        tSqlW &= " AND a.DocStatus<6 "
                    Else
                        tSqlW &= " AND h.DocStatus<3 "
                    End If
                End If

                Dim sql As String = If(tbPrefix = "a", SQLSelectClrFromAdvance(), SQLSelectClrNoAdvance())
                If Not IsNothing(Request.QueryString("Show")) Then
                    If Request.QueryString("Show").ToString = "BAL" Then
                        sql &= " having (ISNULL(a.AdvAmount,0)+ISNULL(a.ChargeVAT,0))-sum(d.UsedAmount+d.ChargeVAT)<>0"
                    End If
                End If
                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL(String.Format(sql, tSqlW))
                Dim json = "{""clr"":{""data"":" & JsonConvert.SerializeObject(oData.AsEnumerable().ToList()) & ",""msg"":""" & tSqlW & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetClearingSum", "ERROR", ex.Message)
                Return Content("{""clr"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function GetClearingGrid() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""clr"":{""data"":[],""msg"":""You Are not authorize to view data""}}", jsonContent)
                End If

                Dim Branch As String = ""
                Dim JobNo As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If

                Dim tSqlW As String = String.Format(" WHERE a.BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("JobNo")) Then
                    tSqlW &= " AND b.JobNo='" & Request.QueryString("JobNo") & "' "
                End If
                If Not IsNothing(Request.QueryString("JType")) Then
                    tSqlW &= " AND a.JobType=" & Request.QueryString("JType") & ""
                End If
                If Not IsNothing(Request.QueryString("CFrom")) Then
                    tSqlW &= " AND a.ClearFrom=" & Request.QueryString("CFrom") & ""
                End If
                If Not IsNothing(Request.QueryString("CType")) Then
                    tSqlW &= " AND a.ClearType=" & Request.QueryString("CType") & ""
                End If
                If Not IsNothing(Request.QueryString("ClrBy")) Then
                    tSqlW &= " AND a.EmpCode='" & Request.QueryString("ClrBy") & "'"
                End If
                If Not IsNothing(Request.QueryString("CustCode")) Then
                    tSqlW &= " AND b.CustCode='" & Request.QueryString("CustCode") & "'"
                End If
                If Not IsNothing(Request.QueryString("CustBranch")) Then
                    tSqlW &= " AND b.CustBranch='" & Request.QueryString("CustBranch") & "'"
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlW &= " AND a.ClrDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlW &= " AND a.ClrDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlW &= " AND a.DocStatus='" & Request.QueryString("Status") & "' "
                Else
                    tSqlW &= " AND a.DocStatus<>99 "
                End If
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    tSqlW &= " AND b.CustCode IN(Select CustCode from Mas_Company where TaxNumber='" & Request.QueryString("TaxNumber") & "') "
                End If

                Dim sql As String = SQLSelectClrHeader() & "{0} ORDER BY a.ClrDate DESC"

                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL(String.Format(sql, tSqlW))
                Dim json = "{""clr"":{""data"":" & JsonConvert.SerializeObject(oData.AsEnumerable().ToList()) & ",""msg"":""" & tSqlW & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetClearingGrid", "ERROR", ex.Message)
                Return Content("{""clr"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function GetAdvForClear() As ActionResult
            Try
                Dim tSqlW As String = " WHERE (a.AdvNet-ISNULL(d.TotalCleared,0))>0 AND c.DocStatus IN('3','4') "
                If Not IsNothing(Request.QueryString("Show")) Then
                    If Request.QueryString("Show").ToString = "NOCLR" Then
                        tSqlW = " WHERE d.AdvNo IS NULL AND c.DocStatus IN('2','3') "
                    End If
                    If Request.QueryString("Show").ToString = "CLR" Then
                        tSqlW = " WHERE d.AdvNo IS NOT NULL AND c.DocStatus IN('4','5') "
                    End If
                    If Request.QueryString("Show").ToString = "ALL" Then
                        tSqlW = " WHERE c.DocStatus>0 "
                    End If
                End If

                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Dim Branch = Request.QueryString("BranchCode")
                    tSqlW &= String.Format(" AND c.BranchCode='{0}'", Branch)
                End If

                If Not IsNothing(Request.QueryString("JobNo")) Then
                    tSqlW &= " AND a.ForJNo='" & Request.QueryString("JobNo") & "' "
                End If
                If Not IsNothing(Request.QueryString("JType")) Then
                    tSqlW &= " AND c.JobType=" & Request.QueryString("JType") & ""
                End If
                If Not IsNothing(Request.QueryString("CFrom")) Then
                    tSqlW &= " AND c.EmpCode IN(SELECT UserID FROM Mas_User WHERE DeptID='" & Request.QueryString("CFrom") & "')"
                End If
                If Not IsNothing(Request.QueryString("ReqBy")) Then
                    tSqlW &= " AND c.EmpCode='" & Request.QueryString("ReqBy") & "'"
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlW &= " AND c.AdvDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlW &= " AND c.AdvDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlW &= " AND c.DocStatus='" & Request.QueryString("Status") & "' "
                End If
                Dim sql As String = SQLSelectAdvForClear() & "{0}"

                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL(String.Format(sql, tSqlW))
                Dim json = "{""clr"":{""data"":" & JsonConvert.SerializeObject(oData.AsEnumerable().ToList()) & ",""msg"":""" & tSqlW & """}}"
                Return Content(json, jsonContent)

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetAdvForClear", "ERROR", ex.Message)
                Return Content("{""clr"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function GetNewClearHeader() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
            If AuthorizeStr.IndexOf("I") < 0 Then
                Return Content("[]", jsonContent)
            End If

            Dim Branch As String = ""
            If Not IsNothing(Request.QueryString("BranchCode")) Then
                Branch = Request.QueryString("BranchCode")
            End If

            Dim oHead As New CClrHeader(jobWebConn) With {
                .BranchCode = Branch,
                .ClrNo = "",
                .ClrDate = DateTime.Today,
                .ClearFrom = 1,
                .ClearType = 1,
                .DocStatus = 1
            }

            Dim oDetail As New CClrDetail(jobWebConn) With {
                .BranchCode = Branch,
                .ClrNo = "",
                .ItemNo = 0
            }

            Dim json As String = "{""clr"":{""header"":[" + JsonConvert.SerializeObject(oHead) + "],""detail"":[" + JsonConvert.SerializeObject(oDetail) + "],""result"":""OK""}}"
            Return Content(json, jsonContent)
        End Function
        Function GetNewClearDetail() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
            If AuthorizeStr.IndexOf("I") < 0 Then
                Return Content("[]", jsonContent)
            End If

            Dim Branch As String = ""
            If Not IsNothing(Request.QueryString("BranchCode")) Then
                Branch = Request.QueryString("BranchCode")
            End If

            Dim ClrNo As String = ""
            If Not IsNothing(Request.QueryString("ClrNo")) Then
                ClrNo = Request.QueryString("ClrNo")
            End If

            Dim oDetail As New CClrDetail(jobWebConn) With
                {
                    .BranchCode = Branch,
                    .ClrNo = ClrNo,
                    .ItemNo = 0
                }

            Dim jsond As String = JsonConvert.SerializeObject(oDetail)
            Dim json = "{""clr"":{""detail"":" & jsond & ",""result"":""OK""}}"
            Return Content(json, jsonContent)
        End Function
        Function GetClearing() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""clr"":{""header"":[],""detail"":[],""msg"":""You are not authorize to read""}}", jsonContent)
                End If

                Dim tSqlw As String = " WHERE ClrNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ClrNo ='{0}' ", Request.QueryString("Code").ToString)
                End If

                Dim oData = New CClrHeader(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)

                Dim oDataD = New CClrDetail(jobWebConn).GetData(tSqlw)
                Dim jsonD As String = JsonConvert.SerializeObject(oDataD)

                json = "{""clr"":{""header"":" & json & ",""detail"":" & jsonD & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetClearing", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetClrHeader(<FromBody()> data As CClrHeader) As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("E") < 0 Then
                    Return Content("{""result"":{""data"":[],""msg"":""You are not authorize to edit""}}", jsonContent)
                End If

                If Not IsNothing(data) Then
                    data.SetConnect(jobWebConn)
                    If "" & data.ClrNo = "" Then
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            Return Content("{""result"":{""data"":[],""msg"":""You are not authorize to add""}}", jsonContent)
                        End If
                        If data.ClrDate = DateTime.MinValue Then
                            data.ClrDate = Today.Date
                        End If
                        Select Case data.ClearType
                            Case 2
                                data.AddNew(costPrefix & data.ClrDate.ToString("yyMM") & "_____")
                            Case 3
                                data.AddNew(servPrefix & data.ClrDate.ToString("yyMM") & "_____")
                            Case Else
                                data.AddNew(clrPrefix & data.ClrDate.ToString("yyMM") & "_____")
                        End Select

                    End If

                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND ClrNo='{1}' ", data.BranchCode, data.ClrNo))

                    Dim json = "{""result"":{""data"":""" & data.ClrNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetClrHeader", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelClearing() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("D") < 0 Then
                    Return Content("{""clr"":{""data"":[],""result"":""You are not authorize to delete""}}", jsonContent)
                End If

                Dim tSqlw As String = " WHERE ClrNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If

                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ClrNo ='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If

                Dim oDataD As New CClrDetail(jobWebConn)
                Dim msg = oDataD.DeleteData(tSqlw)

                Dim oData As New CClrHeader(jobWebConn)
                msg = oData.DeleteData(tSqlw)

                Dim json = "{""clr"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelClearing", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetClrDetail() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""clr"":{""detail"":[],""msg"":""You are not authorize to read""}}", jsonContent)
                End If

                Dim tSqlw As String = " WHERE ClrNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ClrNo ='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format("AND ItemNo IN({0}) ", Request.QueryString("Item").ToString)
                End If

                Dim oData = New CClrDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""clr"":{""detail"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetClrDetail", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SaveClearDetail(<FromBody()> data As List(Of CClrDetail)) As ActionResult
            Try
                Dim branchcode As String = ""
                Dim clrno As String = ""
                Dim icount As Integer = 0
                For Each o As CClrDetail In data
                    branchcode = o.BranchCode
                    clrno = o.ClrNo
                    o.SetConnect(jobWebConn)
                    Dim msg = o.SaveData(String.Format(" WHERE BranchCode='{0}' AND  ClrNo='{1}' And ItemNo='{2}' ", o.BranchCode, o.ClrNo, o.ItemNo))
                    If msg.Substring(0, 1) = "S" Then
                        icount += 1
                    End If
                Next
                Dim obj = New CClrDetail(jobWebConn).GetData(String.Format(" WHERE BranchCode='{0}' And ClrNo='{1}'", branchcode, clrno))
                Dim json = "{""result"":{""msg"":""" & icount & " row saved! (Clearing No=" + clrno + ")"",""data"":""" & clrno & """,""detail"":[" & JsonConvert.SerializeObject(obj) & "]}}"
                Return Content(Json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SaveClearDetail", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """,""detail"":[]}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function SetClrDetail(<FromBody()> data As CClrDetail) As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("E") < 0 Then
                    Return Content("{""result"":{""data"":[],""msg"":""You are not authorize to edit""}}", jsonContent)
                End If

                If Not IsNothing(data) Then
                    If "" & data.ClrNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    If data.ItemNo = 0 Then
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            Return Content("{""result"":{""data"":[],""msg"":""You are not authorize to add""}}", jsonContent)
                        End If
                    End If

                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND ClrNo='{1}' AND ItemNo={2} ", data.BranchCode, data.ClrNo, data.ItemNo))
                    Dim json = "{""result"":{""data"":""" & data.ClrNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetClrDetail", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelClrDetail() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("D") < 0 Then
                    Return Content("{""clr"":{""data"":[],""result"":""You are not authorize to delete""}}", jsonContent)
                End If

                Dim tSqlw As String = " WHERE ClrNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ClrNo ='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format("AND ItemNo ={0} ", Request.QueryString("Item").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Item"",""data"":[]}}", jsonContent)
                End If

                Dim oData As New CClrDetail(jobWebConn)
                Dim oRows = oData.GetData(tSqlw)
                If oRows.Count > 0 Then
                    oData = oRows(0)
                End If
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""clr"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelClrDetail", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
    End Class
End Namespace