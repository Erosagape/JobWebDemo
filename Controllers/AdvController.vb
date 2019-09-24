Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json
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
            Return GetView("EstimateCost", "MODULE_ADV")
        End Function
        Function GetClearExpReport() As ActionResult
            Try
                Dim tSqlw As String = " WHERE a.JNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND a.BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Job")) Then
                    tSqlw &= String.Format("AND a.JNo ='{0}' ", Request.QueryString("Job").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND a.SICode ='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectClearExp() & tSqlw)
                Dim json = JsonConvert.SerializeObject(oData)
                json = "{""estimate"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetClearExpReport", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetClearExp() As ActionResult
            Try
                Dim tSqlw As String = " WHERE JNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Job")) Then
                    tSqlw &= String.Format("AND JNo ='{0}' ", Request.QueryString("Job").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND SICode ='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CClearExp(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""estimate"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetClearExp", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function CopyClearExp() As ActionResult
            Dim msg As String = ""
            Try
                Dim cliteria = Request.QueryString("cliteria").ToString()
                Dim jobSource = cliteria.Split("=")(0)
                Dim jobDest = cliteria.Split("=")(1)
                Dim oSrc = New CClearExp(jobWebConn).GetData(String.Format(" WHERE BranchCode+'|'+JNo='{0}'", jobSource))
                For Each oRow In oSrc
                    Dim oDesc = New CClearExp(jobWebConn).GetData(String.Format(" WHERE BranchCode+'|'+JNo='{0}' AND SICode='{1}' ", jobDest, oRow.SICode))
                    Dim oRec = New CClearExp(jobWebConn)
                    If oDesc.Count > 0 Then
                        oRec = oDesc(0)
                    Else
                        oRec.BranchCode = jobDest.Split("|")(0).Trim()
                        oRec.SICode = oRow.SICode
                        oRec.JNo = jobDest.Split("|")(1).Trim()
                    End If
                    oRec.SDescription = oRow.SDescription
                    oRec.AmountCharge = oRow.AmountCharge
                    oRec.TRemark = oRow.TRemark
                    oRec.Status = oRow.Status
                    msg &= "<br/>" & oRec.SaveData(String.Format(" WHERE BranchCode+'|'+JNo='{0}' AND SICode='{1}' ", jobDest, oRow.SICode))
                Next
                If msg = "" Then msg = "No data to copy"
                msg = "Result:<br/>" & msg
                Return Content(msg, textContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "CopyClearExp", "ERROR", ex.Message)
                Return Content("[ERROR] " + ex.Message, textContent)
            End Try
        End Function
        Function SetClearExp(<FromBody()> data As CClearExp) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.JNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Job""}}", jsonContent)
                    End If
                    If "" & data.SICode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Code""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE SICode='{0}' AND BranchCode='{1}' AND JNo='{2}' ", data.SICode, data.BranchCode, data.JNo))
                    Dim json = "{""result"":{""data"":""" & data.SICode & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetClearExp", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelClearExp() As ActionResult
            Try
                Dim tSqlw As String = " WHERE JNo<>'' "

                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode = '{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""estimate"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Job")) Then
                    tSqlw &= String.Format("AND JNo = '{0}' ", Request.QueryString("Job").ToString)
                Else
                    Return Content("{""estimate"":{""result"":""Please Select Some Job"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND SICode = '{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim oData As New CClearExp(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""estimate"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelClearExp", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function FormCreditAdv() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "CreditAdv")
            If AuthorizeStr.IndexOf("P") < 0 Then
                Return Content("You are not allow to print credit-advance", textContent)
            End If
            Return GetView("FormCreditAdv")
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
                    i += 1
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
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "PaymentAdvance", "ERROR", ex.Message)
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
                    Dim prefix As String = advPrefix
                    If data.AdvNo = "" Then
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            Return Content("{""result"":{""data"":null,""msg"":""You are not allow to add advance""}}", jsonContent)
                        End If
                        If data.AdvDate = DateTime.MinValue Then
                            data.AdvDate = Today.Date
                        End If
                        data.AddNew(prefix & "-" & data.AdvDate.ToString("yyMM") & "____")
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
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SaveAdvanceHeader", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" + ex.Message + """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function SaveCustAdvance(<FromBody()> ByVal data As CAdvHeader) As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Index")
                If Not IsNothing(data) Then
                    data.SetConnect(jobWebConn)
                    Dim prefix As String = expPrefix
                    If data.AdvNo = "" Then
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            Return Content("{""result"":{""data"":null,""msg"":""You are not allow to add advance""}}", jsonContent)
                        End If
                        If data.AdvDate = DateTime.MinValue Then
                            data.AdvDate = Today.Date
                        End If
                        data.AddNew(prefix & "-" & data.AdvDate.ToString("yyMM") & "____")
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
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SaveCustAdvance", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" + ex.Message + """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function SetAdvDetail(<FromBody()> ByVal data As List(Of CAdvDetail)) As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()

                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Index")
                If AuthorizeStr.IndexOf("E") < 0 Then
                    Return Content("{""result"":{""data"":null,""msg"":""You are not authorize to edit document""}}", jsonContent)
                End If

                Dim json As String = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                If IsNothing(data) Then
                    Return Content(json, jsonContent)
                End If

                If "" & data(0).BranchCode = "" Then
                    Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                End If

                If "" & data(0).AdvNo = "" Then
                    Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                End If

                If data(0).ItemNo = 0 Then
                    AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Index")
                    If AuthorizeStr.IndexOf("I") < 0 Then
                        Return Content("{""result"":{""data"":null,""msg"":""You are not authorize to add document""}}", jsonContent)
                    End If
                End If

                Dim i As Integer = 0
                Dim str As String = ""
                Dim branchcode As String = ""
                Dim docno As String = ""

                For Each o As CAdvDetail In data
                    i += 1
                    branchcode = o.BranchCode
                    docno = o.AdvNo
                    o.SetConnect(jobWebConn)
                    Dim msg = o.SaveData(String.Format(" WHERE BranchCode='{0}' AND AdvNo='{1}' And ItemNo='{2}' ", o.BranchCode, o.AdvNo, o.ItemNo))
                    If str <> "" Then str &= ","
                    str &= msg
                Next

                Dim obj = New CAdvDetail(jobWebConn).GetData(String.Format(" WHERE BranchCode='{0}' And AdvNo='{1}'", branchcode, docno))
                json = "{""result"":{""msg"":""" & str & """,""data"":""" & docno & """,""document"":[" & JsonConvert.SerializeObject(obj) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetAdvDetail", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""Error!"",""error"":""" & ex.Message & """,""document"":[]}}"
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
                        Return Content("{""result"":{""data"":null,""msg"":""You are not allow to edit advance""}}", jsonContent)
                    End If
                    Dim msg As String = ""
                    If data.ForJNo <> "" Then
                        Dim chkDupRows = New CAdvDetail(jobWebConn).GetData(String.Format(" WHERE BranchCode='{0}' AND ForJNo='{1}' AND SICode='{2}' AND AdvNo<>'{3}' ", data.BranchCode, data.ForJNo, data.SICode, data.AdvNo))
                        If chkDupRows.Count > 0 Then
                            If data.SDescription.IndexOf("ซ้ำ") < 0 Then
                                data.SDescription = "**ซ้ำ**" & data.SDescription
                            End If
                            msg &= "This expenses has been advanced in " & chkDupRows(0).AdvNo & "\n"
                        End If
                    End If
                    msg &= data.SaveData(String.Format(" WHERE BranchCode='{0}' AND AdvNo='{1}' AND ItemNo={2} ", data.BranchCode, data.AdvNo, data.ItemNo))
                    'Dim msg = JsonConvert.SerializeObject(data)
                    Dim json = "{""result"":{""data"":""" & data.ItemNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SaveAdvanceDetail", "ERROR", ex.Message)
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
                Dim Docno As String = ""
                Dim tSqlW As String = String.Format(" WHERE BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    tSqlW &= " AND AdvNo='" & Request.QueryString("AdvNo").ToString & "'"
                    Docno = Request.QueryString("AdvNo").ToString
                End If

                Dim ItemNo As String = "0"
                If Not IsNothing(Request.QueryString("ItemNo")) Then
                    ItemNo = Request.QueryString("ItemNo").ToString
                End If
                tSqlW &= " AND ItemNo=" & ItemNo & ""

                Dim oADVD As New CAdvDetail(jobWebConn) With {
                    .BranchCode = Branch,
                    .AdvNo = Docno,
                    .ItemNo = ItemNo
                }
                Dim msg As String = oADVD.DeleteData(tSqlW)

                Dim json = "{""adv"":{""result"":""" & msg & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelAdvanceDetail", "ERROR", ex.Message)
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
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelAdvanceHeader", "ERROR", ex.Message)
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

                Dim oAdvH As New CAdvHeader(jobWebConn) With {
                    .BranchCode = Branch,
                    .AdvNo = "",
                    .AdvDate = DateTime.Today,
                    .DocStatus = 1
                }

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
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetNewAdvanceHeader", "ERROR", ex.Message)
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
                        .ItemNo = 0,
                        .IsDuplicate = 1
                    }

                'Dim msg As String = oAdvD.SaveData(String.Format(" WHERE BranchCode='{0}' And AdvNo='{1}' And ItemNo={2}", oAdvD.BranchCode, oAdvD.AdvNo, oAdvD.ItemNo))
                Dim jsonh As String = JsonConvert.SerializeObject(oAdvD)
                Dim json = "{""adv"":{""detail"":" & jsonh & ",""result"":""OK""}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetNewAdvanceDetail", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetAdvanceReport() As ActionResult
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
                    tSqlW &= " AND d.ForJNo='" & Request.QueryString("JobNo") & "'"
                End If
                If Not IsNothing(Request.QueryString("Vend")) Then
                    tSqlW &= " AND d.VenCode='" & Request.QueryString("Vend") & "'"
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
                Else
                    tSqlW &= " AND a.DocStatus<>99 "
                End If
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    tSqlW &= " AND b.TaxNumber='" & Request.QueryString("TaxNumber") & "' "
                End If
                If Not IsNothing(Request.QueryString("Currency")) Then
                    tSqlW &= " AND a.SubCurrency='" & Request.QueryString("Currency") & "' "
                End If
                If Not IsNothing(Request.QueryString("AdvType")) Then
                    tSqlW &= " AND a.AdvType IN(" & Request.QueryString("AdvType") & ") "
                Else
                    tSqlW &= " AND a.AdvType IN(1,2,3,4) "
                End If
                Dim sql As String = SQLSelectAdvDetail()
                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL(sql + tSqlW + " ORDER BY a.AdvDate DESC")
                Dim json = "{""adv"":{""data"":" & JsonConvert.SerializeObject(oData.AsEnumerable().ToList()) & ",""msg"":""" & tSqlW & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetAdvanceReport", "ERROR", ex.Message)
                Return Content("{""adv"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
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
                Else
                    tSqlW &= " AND a.DocStatus<>99 "
                End If
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    tSqlW &= " AND b.TaxNumber='" & Request.QueryString("TaxNumber") & "' "
                End If
                If Not IsNothing(Request.QueryString("Currency")) Then
                    tSqlW &= " AND a.SubCurrency='" & Request.QueryString("Currency") & "' "
                End If
                If Not IsNothing(Request.QueryString("AdvType")) Then
                    tSqlW &= " AND a.AdvType IN(" & Request.QueryString("AdvType") & ") "
                Else
                    tSqlW &= " AND a.AdvType IN(1,2,3,4) "
                End If
                Dim sql As String = SQLSelectAdvHeader()
                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL(sql + tSqlW + " ORDER BY a.AdvDate DESC")
                Dim json = "{""adv"":{""data"":" & JsonConvert.SerializeObject(oData.AsEnumerable().ToList()) & ",""msg"":""" & tSqlW & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetAdvanceGrid", "ERROR", ex.Message)
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
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetAdvance", "ERROR", ex.Message)
                Return Content("{""adv"":{""header"":[],""detail"":[],""msg"":""" & ex.Message & """}}", jsonContent)
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
                Else
                    Return Content("{""adv"":{""detail"":[],""msg"":""Please select Branch""}}", jsonContent)
                End If

                Dim tSqlW As String = String.Format(" WHERE BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    tSqlW &= " AND AdvNo='" & Request.QueryString("AdvNo") & "'"
                End If
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    tSqlW &= " AND AdvNo IN(SELECT AdvNo FROM Job_AdvHeader WHERE BranchCode='" & Branch & "' AND CustCode IN(SELECT CustCode FROM Mas_Company WHERE TaxNumber='" & Request.QueryString("TaxNumber") & "'))"
                End If

                Dim oDataD = oADVD.GetData(tSqlW)
                Dim jsond As String = JsonConvert.SerializeObject(oDataD)
                Dim oDataH = New CAdvHeader(jobWebConn).GetData(tSqlW)
                Dim jsonh As String = JsonConvert.SerializeObject(oDataH)

                Dim json = "{""adv"":{""detail"":" & jsond & ",""header"":" & jsonh & "}}"

                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetAdvanceDetail", "ERROR", ex.Message)
                Return Content("{""adv"":{""detail"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
    End Class
End Namespace