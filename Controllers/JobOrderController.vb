Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json
Namespace Controllers
    Public Class JobOrderController
        Inherits CController
        Function Index() As ActionResult
            Return GetView("Index", "MODULE_CS")
        End Function
        Function CreateJob() As ActionResult
            Return GetView("CreateJob", "MODULE_CS")
        End Function
        Function ShowJob() As ActionResult
            Return GetView("ShowJob", "MODULE_CS")
        End Function
        Function FormJob() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CS", "ShowJob")
            If AuthorizeStr.IndexOf("P") < 0 Then
                Return Content("You are not allow to print job", textContent)
            End If
            Return GetView("FormJob")
        End Function
        Function FormJobSum() As ActionResult
            Return GetView("FormJobSum")
        End Function
        Function FormQuotation() As ActionResult
            Return GetView("FormQuotation")
        End Function
        Function ApproveQuotation(<FromBody()> ByVal data As String()) As HttpResponseMessage
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_SALES", "QuoApprove")
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
                    Dim tSQL As String = String.Format("UPDATE Job_QuotationHeader SET DocStatus=1,ApproveBy='" & user & "',ApproveDate='" & DateTime.Now.ToString("yyyy-MM-dd") & "',ApproveTime='" & DateTime.Now.ToString("HH:mm:ss") & "' 
 WHERE DocStatus=0 AND BranchCode+'|'+QNo in({0})", lst)
                    Dim result = Main.DBExecute(jobWebConn, tSQL)
                    If result = "OK" Then
                        Return New HttpResponseMessage(HttpStatusCode.OK)
                    End If
                End If
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "ApproveQuotation", "ERROR", ex.Message)
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End Try
        End Function
        Function Quotation() As ActionResult
            Return GetView("Quotation", "MODULE_SALES")
        End Function
        Function CopyQuotation() As ActionResult
            Dim tSqlw As String = " WHERE QNo<>'' "
            If Not IsNothing(Request.QueryString("Branch")) Then
                tSqlw &= String.Format(" AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
            End If
            If Not IsNothing(Request.QueryString("Code")) Then
                tSqlw &= String.Format(" AND QNo='{0}' ", Request.QueryString("Code").ToString)
            End If
            Dim custcode As String = ""
            Dim custbranch As String = ""
            If Not IsNothing(Request.QueryString("Cust")) Then
                custcode = Request.QueryString("Cust").ToString().Split("|")(0)
                custbranch = Request.QueryString("Cust").ToString().Split("|")(1)
            Else
                Return Content("{""result"":""Please select customer""}", jsonContent)
            End If
            Try
                Dim oHead = New CQuoHeader(jobWebConn).GetData(tSqlw)
                If oHead.Count > 0 Then
                    Dim oDetails = New CQuoDetail(jobWebConn).GetData(tSqlw)
                    Dim oItems = New CQuoItem(jobWebConn).GetData(tSqlw)
                    oHead(0).DocDate = DateTime.Today
                    oHead(0).CustCode = custcode
                    oHead(0).CustBranch = custbranch
                    oHead(0).BillToCustCode = custcode
                    oHead(0).BillToCustBranch = custbranch
                    oHead(0).DocStatus = 0
                    oHead(0).ApproveBy = ""
                    oHead(0).ApproveDate = DateTime.MinValue
                    oHead(0).ApproveTime = DateTime.MinValue
                    oHead(0).CancelBy = ""
                    oHead(0).CancelDate = DateTime.MinValue
                    oHead(0).CancelReason = ""
                    oHead(0).AddNew("Q-" & DateTime.Now.ToString("yyMM") & "-____")
                    Dim msg = oHead(0).SaveData(String.Format(" WHERE BranchCode='{0}' AND QNo='{1}'", oHead(0).BranchCode, oHead(0).QNo))
                    If msg.Substring(0, 1) = "S" Then
                        For Each detail In oDetails
                            detail.QNo = oHead(0).QNo
                            detail.SaveData(String.Format(" WHERE BranchCode='{0}' AND QNo='{1}' AND SeqNo={2}", oHead(0).BranchCode, oHead(0).QNo, detail.SeqNo))
                        Next
                        For Each item In oItems
                            item.QNo = oHead(0).QNo
                            item.SaveData(String.Format(" WHERE BranchCode='{0}' AND QNo='{1}' AND SeqNo={2} AND ItemNo={3}", oHead(0).BranchCode, oHead(0).QNo, item.SeqNo, item.ItemNo))
                        Next
                        Return Content("{""result"":""" & oHead(0).QNo & """}", jsonContent)
                    Else
                        Return Content("{""result"":""" & msg & """}", jsonContent)
                    End If
                Else
                    Return Content("{""result"":""Not Found Quotation " & Request.QueryString("Code").ToString & """}", jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "CopyQuotation", "ERROR", ex.Message)
                Return Content("{""result"":""" & ex.Message & """}", jsonContent)
            End Try
        End Function
        Function GetQuotationGrid() As ActionResult
            Try
                Dim tSqlW As String = ""
                If Not IsNothing(Request.QueryString("JType")) Then
                    tSqlW &= " AND Job_QuotationDetail.JobType=" & Request.QueryString("JType").ToString & ""
                End If
                If Not IsNothing(Request.QueryString("SBy")) Then
                    tSqlW &= " AND Job_QuotationDetail.ShipBy=" & Request.QueryString("SBy").ToString & ""
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlW &= " AND Job_QuotationHeader.BranchCode='" & Request.QueryString("Branch").ToString & "'"
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlW &= " AND Job_QuotationHeader.DocStatus='" & Request.QueryString("Status").ToString & "'"
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlW &= " AND Job_QuotationHeader.CustCode='" & Request.QueryString("Cust").ToString & "'"
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlW &= " AND Job_QuotationItem.SICode='" & Request.QueryString("Code").ToString & "'"
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectQuotation() & " WHERE NOT ISNULL(Job_QuotationHeader.CancelBy,'')<>'' " & tSqlW & " ORDER BY Job_QuotationHeader.BranchCode,Job_QuotationHeader.QNo,Job_QuotationHeader.ApproveDate DESC,Job_QuotationItem.SICode,Job_QuotationItem.QtyBegin")
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""quotation"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetQuotationGrid", "ERROR", ex.Message)
                Return Content("{""quotation"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function GetQuotation() As ActionResult
            Try
                Dim tSqlw As String = " WHERE QNo<>'' "
                If Not IsNothing(Request.QueryString("Show")) Then
                    If Request.QueryString("Show").ToString() = "ACTIVE" Then
                        tSqlw &= String.Format(" AND NOT ISNULL(CancelBy,'')<>'' ")
                    End If
                    If Request.QueryString("Show").ToString() = "CANCEL" Then
                        tSqlw &= String.Format(" AND ISNULL(CancelBy,'')<>'' ")
                    End If
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlw &= String.Format("AND DocStatus={0} ", Request.QueryString("Status").ToString)
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND QNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format("AND CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                If Not IsNothing(Request.QueryString("Sales")) Then
                    tSqlw &= String.Format("AND ManagerCode='{0}' ", Request.QueryString("Sales").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND DocDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND DocDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                Dim oDataH = New CQuoHeader(jobWebConn).GetData(tSqlw)
                Dim jsonH As String = JsonConvert.SerializeObject(oDataH)
                Dim oDataD = New CQuoDetail(jobWebConn).GetData(tSqlw)
                Dim jsonD As String = JsonConvert.SerializeObject(oDataD)
                Dim oDataI = New CQuoItem(jobWebConn).GetData(tSqlw)
                Dim jsonI As String = JsonConvert.SerializeObject(oDataI)
                Dim json As String = "{""quotation"":{""header"":" & jsonH & ",""detail"":" & jsonD & ",""item"":" & jsonI & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetQuotation", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetQuoHeader(<FromBody()> data As CQuoHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    If "" & data.QNo = "" Then
                        data.AddNew("Q-" & DateTime.Now.ToString("yyMM") & "-____")
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND QNo='{1}' ", data.BranchCode, data.QNo))
                    Dim json = "{""result"":{""data"":""" & data.QNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetQuoHeader", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelQuoHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE QNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""quoheader"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND QNo='{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""quoheader"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CQuoHeader(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)
                Dim oDataD As New CQuoDetail(jobWebConn)
                oDataD.DeleteData(tSqlw)
                Dim oDataI As New CQuoItem(jobWebConn)
                oDataI.DeleteData(tSqlw)
                Dim json = "{""quoheader"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelQuoHeader", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetQuoDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE QNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND QNo='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Seq")) Then
                    tSqlw &= String.Format(" AND SeqNo={0}", Request.QueryString("Seq").ToString)
                End If
                Dim oData = New CQuoDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                Dim oDataD = New CQuoItem(jobWebConn).GetData(tSqlw)
                Dim jsonD As String = JsonConvert.SerializeObject(oDataD)
                json = "{""quotation"":{""detail"":" & json & ",""items"":" & jsonD & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetQuoDetail", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetQuoDetail(<FromBody()> data As CQuoDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data.QNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Q.No""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND QNo='{1}' AND SeqNo={2} ", data.BranchCode, data.QNo, data.SeqNo))
                    Dim json = "{""result"":{""data"":""" & data.SeqNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetQuoDetail", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelQuoDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE QNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""quodetail"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If

                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND QNo='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""quodetail"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Seq")) Then
                    tSqlw &= String.Format(" AND SeqNo={0} ", Request.QueryString("Seq").ToString)
                End If
                Dim oData As New CQuoDetail(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)
                Dim oDataD As New CQuoItem(jobWebConn)
                oDataD.DeleteData(tSqlw)

                Dim json = "{""quodetail"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelQuoDetail", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetQuoItem() As ActionResult
            Try
                Dim tSqlw As String = " WHERE QNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND QNo='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Seq")) Then
                    tSqlw &= String.Format(" AND SeqNo={0}", Request.QueryString("Seq").ToString)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format(" AND ItemNo={0}", Request.QueryString("Item").ToString)
                End If
                Dim oData = New CQuoItem(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""quotation"":{""items"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetQuoItem", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetQuoItem(<FromBody()> data As CQuoItem) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data.QNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    If "" & data.SeqNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Sequence""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND QNo='{1}' And SeqNo={2} And ItemNo={3} ", data.BranchCode, data.QNo, data.SeqNo, data.ItemNo))
                    Dim json = "{""result"":{""data"":""" & data.ItemNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetQuoItem", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelQuoItem() As ActionResult
            Try
                Dim tSqlw As String = " WHERE QNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""quoitem"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND QNo='{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""quoitem"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Seq")) Then
                    tSqlw &= String.Format(" AND SeqNo={0} ", Request.QueryString("Seq").ToString)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format(" AND ItemNo={0} ", Request.QueryString("Item").ToString)
                End If
                Dim oData As New CQuoItem(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""quoitem"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelQuoItem", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function

        Function QuoApprove() As ActionResult
            Return GetView("QuoApprove", "MODULE_SALES")
        End Function
        Function FormDelivery() As ActionResult
            Return GetView("FormDelivery")
        End Function
        Function Transport() As ActionResult
            Return GetView("Transport", "MODULE_CS")
            'Return RedirectToAction("FormDelivery")
        End Function
        Function GetTransport() As ActionResult
            Try
                Dim tSqlw As String = " WHERE JNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BookingNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim oDataH = New CTransportHeader(jobWebConn).GetData(tSqlw)
                Dim jsonH As String = JsonConvert.SerializeObject(oDataH)
                If Not IsNothing(Request.QueryString("Job")) Then
                    tSqlw &= String.Format("AND JNo='{0}' ", Request.QueryString("Job").ToString)
                End If
                Dim oDataD = New CTransportDetail(jobWebConn).GetData(tSqlw)
                Dim jsonD As String = JsonConvert.SerializeObject(oDataD)
                Dim json = "{""transport"":{""header"":" & jsonH & ",""detail"":" & jsonD & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetTransport", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetTransportHeader(<FromBody()> data As CTransportHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If

                    If "" & data.BookingNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND BookingNo='{1}' ", data.BranchCode, data.BookingNo))
                    Dim json = "{""result"":{""data"":""" & data.BookingNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetTransportHeader", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelTransportHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE JNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""transport"":{""result"":""Please Select Some branch""}}", jsonContent)
                End If

                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND BookingNo='{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""transport"":{""result"":""Please Select Some Data""}}", jsonContent)
                End If
                Dim oDataH As New CTransportHeader(jobWebConn)
                Dim msg = ""
                For Each oDoc In oDataH.GetData(tSqlw)
                    msg &= "\n" & oDoc.DeleteData(tSqlw)
                Next
                Dim json = "{""transport"":{""result"":""" & msg & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelTransportHeader", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetTransportDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE JNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BookingNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format("AND ItemNo={0} ", Request.QueryString("Item").ToString)
                End If
                If Not IsNothing(Request.QueryString("Job")) Then
                    tSqlw &= String.Format("AND JNo='{0}' ", Request.QueryString("Job").ToString)
                End If
                Dim oData = New CTransportDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""transport"":{""detail"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetTransportDetail", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetTransportDetail(<FromBody()> data As CTransportDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data.BookingNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND BookingNo='{1}' AND ItemNo='{2}' ", data.BranchCode, data.BookingNo, data.ItemNo))
                    Dim json = "{""result"":{""data"":""" & data.ItemNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetTransportDetail", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelTransportDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE JNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""transport"":{""result"":""Please Select Some branch""}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BookingNo='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""transport"":{""result"":""Please Select Some Job""}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format("AND ItemNo={0}", Request.QueryString("Item").ToString)
                End If
                Dim oData As New CTransportDetail(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""transport"":{""result"":""" & msg & """]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelTransportDetail", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetTrackingReport() As ActionResult
            Try
                Dim tSqlw As String = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND Job_Order.BranchCode='{0}'", Request.QueryString("Branch").ToString())
                End If
                If Not IsNothing(Request.QueryString("Job")) Then
                    tSqlw &= String.Format(" AND Job_Order.JNo='{0}' ", Request.QueryString("Job").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND Job_LoadInfo.BookingNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Doc")) Then
                    tSqlw &= String.Format(" AND Job_LoadInfoDetail.DeliveryNo='{0}' ", Request.QueryString("Doc").ToString)
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format(" AND Job_Order.CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlw &= String.Format(" AND Job_Order.JobStatus='{0}' ", Request.QueryString("Status").ToString)
                End If
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    tSqlw &= String.Format(" AND Mas_Company.TaxNumber='{0}' ", Request.QueryString("TaxNumber").ToString)
                End If
                If Not IsNothing(Request.QueryString("Vend")) Then
                    tSqlw &= String.Format(" AND Job_LoadInfo.VenderCode='{0}' ", Request.QueryString("Vend").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND Job_Order.DocDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND Job_Order.DocDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If

                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectTracking(tSqlw))
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""transport"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetTrackingReport", "ERROR", ex.Message)
                Return Content("{""transport"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function GetTransportReport() As ActionResult
            Try
                Dim tSqlw As String = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND Job_LoadInfo.BranchCode='{0}'", Request.QueryString("Branch").ToString())
                End If
                If Not IsNothing(Request.QueryString("Job")) Then
                    tSqlw &= String.Format(" AND Job_LoadInfoDetail.JNo='{0}' ", Request.QueryString("Job").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND Job_LoadInfo.BookingNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Doc")) Then
                    tSqlw &= String.Format(" AND Job_LoadInfoDetail.DeliveryNo='{0}' ", Request.QueryString("Doc").ToString)
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format(" AND Job_Order.CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlw &= String.Format(" AND Job_Order.JobStatus='{0}' ", Request.QueryString("Status").ToString)
                End If
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    tSqlw &= String.Format(" AND Mas_Company.TaxNumber='{0}' ", Request.QueryString("TaxNumber").ToString)
                End If
                If Not IsNothing(Request.QueryString("Vend")) Then
                    tSqlw &= String.Format(" AND Job_LoadInfo.VenderCode='{0}' ", Request.QueryString("Vend").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND Job_LoadInfo.LoadDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND Job_LoadInfo.LoadDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If

                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectTransport(tSqlw))
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""transport"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetTransportReport", "ERROR", ex.Message)
                Return Content("{""transport"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function FormTransport() As ActionResult
            Return GetView("FormTransport")
        End Function
        Function CheckAPI() As ActionResult
            Return Content("Hi API is Running")
        End Function
        Function GetJobDocument() As ActionResult
            Try
                Dim branch As String = ""
                Dim job As String = ""

                If Not IsNothing(Request.QueryString("Branch")) Then
                    branch = Request.QueryString("Branch").ToString()
                End If
                If Not IsNothing(Request.QueryString("Job")) Then
                    job = Request.QueryString("Job").ToString
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectDocumentByJob(branch, job))
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""job"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetJobDocument", "ERROR", ex.Message)
                Return Content("{""job"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function GetJobReport() As ActionResult
            Try
                Dim tSqlW As String = ""
                If Not IsNothing(Request.QueryString("JType")) Then
                    tSqlW &= " AND j.JobType=" & Request.QueryString("JType") & ""
                End If
                If Not IsNothing(Request.QueryString("SBy")) Then
                    tSqlW &= " AND j.ShipBy=" & Request.QueryString("SBy") & ""
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlW &= " AND j.BranchCode='" & Request.QueryString("Branch") & "'"
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlW &= " AND j.JobStatus='" & Request.QueryString("Status") & "'"
                End If
                If Not IsNothing(Request.QueryString("JNo")) Then
                    tSqlW &= " AND j.JNo='" & Request.QueryString("JNo") & "'"
                End If
                If Not IsNothing(Request.QueryString("Year")) Then
                    tSqlW &= " AND Year(j.DocDate)='" & Request.QueryString("Year") & "'"
                End If
                If Not IsNothing(Request.QueryString("Month")) Then
                    tSqlW &= " AND Month(j.DocDate)='" & Request.QueryString("Month") & "'"
                End If
                If Not IsNothing(Request.QueryString("CustCode")) Then
                    tSqlW &= " AND j.CustCode='" & Request.QueryString("CustCode") & "'"
                End If
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    tSqlW &= " AND j.CustCode IN(SELECT CustCode FROM Mas_Company WHERE TaxNumber='" & Request.QueryString("TaxNumber") & "')"
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectJobReport() & " WHERE j.JNo<>'' " & tSqlW & " ORDER BY j.BranchCode,j.JNo")
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""job"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetJobReport", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetJobSQL() As ActionResult
            Try
                Dim oJob As New CJobOrder(jobWebConn)
                Dim tSqlW As String = ""
                If Not IsNothing(Request.QueryString("JType")) Then
                    tSqlW &= " AND JobType=" & Request.QueryString("JType") & ""
                End If
                If Not IsNothing(Request.QueryString("SBy")) Then
                    tSqlW &= " AND ShipBy=" & Request.QueryString("SBy") & ""
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlW &= " AND BranchCode='" & Request.QueryString("Branch") & "'"
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlW &= " AND JobStatus IN(" & Request.QueryString("Status") & ")"
                End If
                If Not IsNothing(Request.QueryString("JNo")) Then
                    tSqlW &= " AND JNo='" & Request.QueryString("JNo") & "'"
                End If
                If Not IsNothing(Request.QueryString("Year")) Then
                    tSqlW &= " AND Year(DocDate)='" & Request.QueryString("Year") & "'"
                End If
                If Not IsNothing(Request.QueryString("Month")) Then
                    tSqlW &= " AND Month(DocDate)='" & Request.QueryString("Month") & "'"
                End If
                If Not IsNothing(Request.QueryString("CustCode")) Then
                    tSqlW &= " AND CustCode='" & Request.QueryString("CustCode") & "'"
                End If
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    tSqlW &= " AND CustCode IN(SELECT CustCode FROM Mas_Company WHERE TaxNumber='" & Request.QueryString("TaxNumber") & "')"
                End If
                Dim oData = oJob.GetData(" WHERE JNo<>'' " & tSqlW & " ORDER BY BranchCode,DocDate DESC")
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""job"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetJobSQL", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetJobYear() As ActionResult
            Try
                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL("SELECT DISTINCT Year(DocDate) as JobYear from Job_Order")
                Dim json As String = JsonConvert.SerializeObject(oData.AsEnumerable().ToList())
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetJobYear", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetDataDistinct() As ActionResult
            Try
                Dim tSqlW As String = ""
                If IsNothing(Request.QueryString("Field")) Then
                    Return Content("[]", jsonContent)
                End If
                If IsNothing(Request.QueryString("Table")) Then
                    Return Content("[]", jsonContent)
                End If
                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL("SELECT DISTINCT " + Request.QueryString("Field").ToString() + " as val from " & Request.QueryString("Table").ToString())
                Dim json As String = JsonConvert.SerializeObject(oData.AsEnumerable().ToList())
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetDataDistinct", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetJobDataDistinct() As ActionResult
            Try
                Dim tSqlW As String = ""
                If IsNothing(Request.QueryString("Field")) Then
                    Return Content("[]", jsonContent)
                End If
                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL("SELECT DISTINCT " + Request.QueryString("Field").ToString() + " as val from Job_Order")
                Dim json As String = JsonConvert.SerializeObject(oData.AsEnumerable().ToList())
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetJobDataDistinct", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetFormJobLOV() As ActionResult
            Dim html As String = "
            <div id=""frmSearchCurr"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchUser"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchCust"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchCons"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchProj"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchProd"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchVessel"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchMVessel"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchDType"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchCPort"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchIUnt"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchWUnt"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchCountry"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchFCountry"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchVend"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchForw"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchIPort"" class=""modal fade"" role=""dialog""></div>
"
            Return Content(html, textContent)
        End Function
        Function GetNewDelivery() As ActionResult
            Try
                Dim branch As String = ""
                Dim booking As String = ""
                Dim itemno As String = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    branch = Request.QueryString("Branch").ToString
                Else
                    Return Content("[ERROR]:Please Select Branch", textContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    booking = Request.QueryString("Code").ToString
                Else
                    Return Content("[ERROR]:Please Select Booking", textContent)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    itemno = Request.QueryString("Item").ToString
                Else
                    Return Content("[ERROR]:Please Select item", textContent)
                End If
                Dim pFormatSQL As String = "DO" & DateTime.Now().ToString("yyMM") & "_____"
                Dim data = New CTransportDetail(jobWebConn).GetData(String.Format(" WHERE BranchCode='{0}' AND BookingNo='{1}' AND ItemNo={2}", branch, booking, itemno))
                Dim msg = "[ERROR]:Data Not Found"
                If data.Count > 0 Then
                    Dim row = data(0)
                    row.DeliveryNo = Main.GetMaxByMask(jobWebConn, String.Format("SELECT MAX(DeliveryNo) as t FROM Job_LoadInfoDetail WHERE BranchCode='{0}' And DeliveryNo Like '%{1}' ", branch, pFormatSQL), pFormatSQL)
                    msg = row.SaveData(String.Format(" WHERE BranchCode='{0}' AND BookingNo='{1}' AND ItemNo={2}", branch, booking, itemno))
                    If msg.Substring(0, 1) = "S" Then
                        Dim header = New CTransportHeader(jobWebConn).GetData(String.Format(" WHERE BranchCode='{0}' AND BookingNo='{1}' ", branch, booking))
                        If header.Count > 0 Then
                            Dim job = New CJobOrder(jobWebConn).GetData(String.Format(" WHERE BranchCode='{0}' AND JNo='{1}'", row.BranchCode, row.JNo))
                            If job.Count > 0 Then
                                job(0).EstDeliverDate = row.UnloadFinishDate
                                job(0).DeliveryNo = row.DeliveryNo
                                job(0).DeliveryTo = header(0).ContactName
                                job(0).DeliveryAddr = row.Location
                                msg = job(0).SaveData(String.Format(" WHERE BranchCode='{0}' AND JNo='{1}'", row.BranchCode, row.JNo))
                                If msg.Substring(0, 1) = "S" Then
                                    msg = row.DeliveryNo
                                Else
                                    row.DeliveryNo = ""
                                    row.SaveData(String.Format(" WHERE BranchCode='{0}' AND BookingNo='{1}' AND ItemNo={2}", branch, booking, itemno))
                                End If
                            Else
                                msg = "[ERROR]:Job Not Found"
                            End If
                        Else
                            msg = "[ERROR]:Booking Not Found"
                        End If
                    End If
                End If
                Return Content(msg, textContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetNewDelivery", "ERROR", ex.Message)
                Return Content("[ERROR]:" + ex.Message, textContent)
            End Try
        End Function
        Function GetNewJob() As ActionResult
            Try
                Dim oJob As New CJobOrder(jobWebConn)
                If Not IsNothing(Request.QueryString("JType")) Then
                    oJob.JobType = Convert.ToInt16("" & Request.QueryString("JType"))
                End If
                If Not IsNothing(Request.QueryString("SBy")) Then
                    oJob.ShipBy = Convert.ToInt16("" & Request.QueryString("SBy"))
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    oJob.BranchCode = "" & Request.QueryString("Branch")
                Else
                    oJob.BranchCode = "00"
                End If
                If Not IsNothing(Request.QueryString("Inv")) Then
                    oJob.InvNo = "" & Request.QueryString("Inv")
                End If

                Dim sql As String = String.Format(" WHERE BranchCode='{0}' AND JobType='{1}' AND ShipBy='{2}' ", oJob.BranchCode, oJob.JobType, oJob.ShipBy)
                If Not IsNothing(Request.QueryString("Cust")) Then
                    oJob.CustCode = "" & Request.QueryString("Cust").Split("|")(0)
                    oJob.CustBranch = "" & Request.QueryString("Cust").Split("|")(1)
                    Dim oCust = New CCompany(jobWebConn).GetData(String.Format(" WHERE CustCode='{0}' AND Branch='{1}'", oJob.CustCode, oJob.CustBranch))
                    If oCust.Count > 0 Then
                        oJob.Commission = oCust(0).CommRate
                    Else
                        Return Content("{""job"":{""data"":[],""status"":""N"",""result"":""Customer '" + oJob.CustCode + "/" + oJob.CustBranch + "' Not Found!""}}", jsonContent)
                    End If
                End If
                sql &= String.Format(" AND CustCode='{0}' And CustBranch='{1}' And InvNo='{2}' AND JobStatus<>99 ", oJob.CustCode, oJob.CustBranch, oJob.InvNo)
                Dim FindJob = oJob.GetData(sql)
                If FindJob.Count > 0 Then
                    Return Content("{""job"":{""data"":[],""status"":""N"",""result"":""invoice '" + oJob.InvNo + "' has been opened for job '" + FindJob(0).JNo + "' ""}}", jsonContent)
                End If

                Dim CopyFrom As String = ""
                If Not IsNothing(Request.QueryString("CopyFrom")) Then
                    CopyFrom = "" & Request.QueryString("CopyFrom")
                End If
                If CopyFrom <> "" Then
                    FindJob = oJob.GetData(String.Format(" WHERE BranchCode='{0}' AND JNo='{1}'", oJob.BranchCode, CopyFrom))
                    If FindJob.Count > 0 Then
                        oJob = FindJob(0)
                    End If
                End If
                Dim prefix As String = GetJobPrefix(oJob)
                If Not IsNothing(Request.QueryString("Prefix")) Then
                    prefix = "" & Request.QueryString("Prefix")
                End If
                oJob.AddNew(prefix & DateTime.Now.ToString("yyMM") & "____", IIf(CopyFrom <> "", False, True))
                Dim result As String = oJob.SaveData(" WHERE BranchCode='" & oJob.BranchCode & "' And JNo='" & oJob.JNo & "'")

                Dim json As String = JsonConvert.SerializeObject(oJob)
                json = "{""job"":{""data"":" & json & ",""status"":""Y"",""result"":""" + result + """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetNewJob", "ERROR", ex.Message)
                Return Content("{""job"":{""data"":[],""status"":""N"",""result"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function TestSetJobData() As ActionResult
            Dim data = New CJobOrder(jobWebConn).GetData(" WHERE BranchCode='00' AND JNo='IA19090014'")(0)
            Try
                Data.SetConnect(jobWebConn)
                If Data.BranchCode = "" Then
                    Return Content("{""msg"":""Please select Branch""}", jsonContent)
                End If
                If Data.JNo = "" Then
                    Return Content("{""msg"":""Please select JobNo""}", jsonContent)
                End If
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetJobOrder", "Save", JsonConvert.SerializeObject(Data))
                Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND JNo='{1}'", data.BranchCode, data.JNo))
                Return Content("{""msg"":""" & msg & """,""data"":" & JsonConvert.SerializeObject(data) & "}", jsonContent)

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetJobOrder", "ERROR", ex.Message)
                Dim json = "{""msg"":""" & ex.Message & """,""data"":" & JsonConvert.SerializeObject(data) & "}"
                Return Content(json, jsonContent)
            End Try
        End Function

        Function SetJobData(<FromBody()> ByVal data As CJobOrder) As ActionResult
            Try
                If Not IsNothing(data) Then
                    data.SetConnect(jobWebConn)
                    If data.BranchCode = "" Then
                        Return Content("{""msg"":""Please select Branch""}", jsonContent)
                    End If
                    If data.JNo = "" Then
                        Return Content("{""msg"":""Please select JobNo""}", jsonContent)
                    End If
                    Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetJobOrder", "Save", JsonConvert.SerializeObject(data))
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND JNo='{1}'", data.BranchCode, data.JNo))
                    Return Content("{""msg"":""" & msg & """}", jsonContent)
                Else
                    Return Content("{""msg"":""No data to save""}", jsonContent)
                End If

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetJobOrder", "ERROR", ex.Message)
                Dim json = "{""msg"":""" & ex.Message & """}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function UpdateJobStatus() As ActionResult
            Dim tSqlW As String = ""
            Dim bLog As Boolean = True
            If Not IsNothing(Request.QueryString("NoLog")) Then
                bLog = If(Request.QueryString("NoLog").ToString = "Y", False, True)
            End If
            If Not IsNothing(Request.QueryString("JType")) Then
                tSqlW &= " AND j.JobType=" & Request.QueryString("JType") & ""
            End If
            If Not IsNothing(Request.QueryString("SBy")) Then
                tSqlW &= " AND j.ShipBy=" & Request.QueryString("SBy") & ""
            End If
            If Not IsNothing(Request.QueryString("Branch")) Then
                tSqlW &= " AND j.BranchCode='" & Request.QueryString("Branch") & "'"
            End If
            If Not IsNothing(Request.QueryString("Status")) Then
                tSqlW &= " AND j.JobStatus='" & Request.QueryString("Status") & "'"
            End If
            If Not IsNothing(Request.QueryString("JNo")) Then
                tSqlW &= " AND j.JNo='" & Request.QueryString("JNo") & "'"
            End If
            If Not IsNothing(Request.QueryString("Year")) Then
                tSqlW &= " AND Year(j.DocDate)='" & Request.QueryString("Year") & "'"
            End If
            If Not IsNothing(Request.QueryString("Month")) Then
                tSqlW &= " AND Month(j.DocDate)='" & Request.QueryString("Month") & "'"
            End If
            If Not IsNothing(Request.QueryString("CustCode")) Then
                tSqlW &= " AND j.CustCode='" & Request.QueryString("CustCode") & "'"
            End If
            If Not IsNothing(Request.QueryString("TaxNumber")) Then
                tSqlW &= " AND j.CustCode IN(SELECT CustCode FROM Mas_Company WHERE TaxNumber='" & Request.QueryString("TaxNumber") & "')"
            End If
            Dim tResult = New CUtil(jobWebConn).ExecuteSQL(SQLUpdateJobStatus(tSqlW), bLog)
            Return Content(tResult, textContent)
        End Function
        Function GetDashboardSQL() As ActionResult
            Dim json1 = SQLDashboard1("")
            Dim json2 = SQLDashboard2("")
            Dim json3 = SQLDashboard3("")
            Return Content("{""result"":[{""data1"":""" & json1 & """,""data2"":""" & json2 & """,""data3"":""" & json3 & """}]}", jsonContent)
        End Function
        Function GetTimelineReport() As ActionResult
            Try
                Dim tSqlw As String = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString())
                End If
                If Not IsNothing(Request.QueryString("Job")) Then
                    tSqlw &= String.Format(" AND JNo='{0}' ", Request.QueryString("Job").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND BookingNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Doc")) Then
                    tSqlw &= String.Format(" AND DeliveryNo='{0}' ", Request.QueryString("Doc").ToString)
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format(" AND CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlw &= String.Format(" AND JobStatus='{0}' ", Request.QueryString("Status").ToString)
                End If
                If Not IsNothing(Request.QueryString("Vend")) Then
                    tSqlw &= String.Format(" AND AgentCode='{0}' ", Request.QueryString("Vend").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND DutyDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND DutyDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                Dim onDate As Date = DateTime.Today
                If Not IsNothing(Request.QueryString("OnDate")) Then
                    onDate = Convert.ToDateTime(Request.QueryString("OnDate").ToString())
                End If
                Dim useDate As String = "DutyDate"
                If Not IsNothing(Request.QueryString("UseDate")) Then
                    useDate = Request.QueryString("UseDate").ToString()
                End If
                Dim totDays As Integer = 3
                If Not IsNothing(Request.QueryString("Days")) Then
                    totDays = Convert.ToInt32(Request.QueryString("Days").ToString())
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectTrackingDay(useDate, onDate, totDays, tSqlw))
                Dim json As String = ""
                Dim jsonD As String = ""
                For i As Integer = 0 To oData.Rows.Count - 1
                    If i = 0 Then
                        jsonD = "["
                        For j As Integer = 0 To oData.Columns.Count - 1
                            If jsonD <> "[" Then
                                jsonD &= ","
                            End If
                            jsonD &= """" & oData.Columns(j).ColumnName & """"
                        Next
                        jsonD &= "]"
                    End If
                    jsonD &= ",["
                    For j As Integer = 0 To oData.Columns.Count - 1
                        If j > 0 Then
                            jsonD &= ","
                        End If
                        If oData.Columns(j).ColumnName = "JobDay" Then
                            jsonD &= """" & oData.Rows(i)(j) & """"
                        Else
                            jsonD &= "" & oData.Rows(i)(j)
                        End If
                    Next
                    jsonD &= "]"
                Next
                json = "{""tracking"":{""data"":[" & jsonD & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetTimelineReport", "ERROR", ex.Message)
                Return Content("{""tracking"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function GetTrackingSummary() As ActionResult
            Try
                Dim tSqlw As String = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND Job_Order.BranchCode='{0}'", Request.QueryString("Branch").ToString())
                End If
                If Not IsNothing(Request.QueryString("Job")) Then
                    tSqlw &= String.Format(" AND Job_Order.JNo='{0}' ", Request.QueryString("Job").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND Job_LoadInfo.BookingNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Doc")) Then
                    tSqlw &= String.Format(" AND Job_LoadInfoDetail.DeliveryNo='{0}' ", Request.QueryString("Doc").ToString)
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format(" AND Job_Order.CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlw &= String.Format(" AND Job_Order.JobStatus='{0}' ", Request.QueryString("Status").ToString)
                End If
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    tSqlw &= String.Format(" AND Mas_Company.TaxNumber='{0}' ", Request.QueryString("TaxNumber").ToString)
                End If
                If Not IsNothing(Request.QueryString("Vend")) Then
                    tSqlw &= String.Format(" AND Job_LoadInfo.VenderCode='{0}' ", Request.QueryString("Vend").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND Job_Order.DocDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND Job_Order.DocDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If

                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectTrackingCount(tSqlw))
                Dim json As String = ""
                For i As Integer = 0 To oData.Rows.Count - 1
                    If i = 0 Then
                        json = "[""Status"",""Volume"", {""role"": ""style"" }]"
                    End If
                    Dim status As String = Convert.ToInt16(oData.Rows(i)("JobStatus")).ToString("00")
                    json &= ",[""" & GetValueConfig("JOB_STATUS", status) & """," & oData.Rows(i)("TotalJob") & ","
                    Select Case status
                        Case "00"
                            json &= """color:aqua"""
                        Case "01"
                            json &= """color:aquamarine"""
                        Case "02"
                            json &= """color:cadetblue"""
                        Case "03"
                            json &= """color:chocolate"""
                        Case "04"
                            json &= """color:brown"""
                        Case "05"
                            json &= """color:blueviolet"""
                        Case "06"
                            json &= """color:crimson"""
                        Case "07"
                            json &= """color:darkgreen"""
                        Case "98"
                            json &= """color:dimgrey"""
                        Case "99"
                            json &= """color:red"""
                        Case Else
                            json &= """color:black"""
                    End Select
                    json &= "]"
                Next
                json = "{""transport"":{""data"":[" & json & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetTrackingSummary", "ERROR", ex.Message)
                Return Content("{""transport"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function GetDashboard() As ActionResult
            Try
                Dim msg As String = New CUtil(jobWebConn).ExecuteSQL(SQLUpdateJobStatus(""), False)
                Dim tSqlw1 As String = ""
                Dim bCheck As Boolean = False
                If Not Request.QueryString("Period") Is Nothing Then
                    bCheck = True
                    Dim yy = Request.QueryString("Period").ToString().Split("/")(1)
                    Dim mm = Convert.ToInt16(Request.QueryString("Period").ToString().Split("/")(0))
                    tSqlw1 = " WHERE Year(j.DocDate)=" & yy & " AND Month(j.DocDate)=" & mm & " "
                End If
                If Not Request.QueryString("ShipBy") Is Nothing Then
                    If bCheck Then
                        tSqlw1 &= " AND "
                    Else
                        tSqlw1 &= " WHERE "
                        bCheck = True
                    End If
                    tSqlw1 &= " j.ShipBy=" & Request.QueryString("ShipBy").ToString & " "
                End If
                If Not Request.QueryString("JobType") Is Nothing Then
                    If bCheck Then
                        tSqlw1 &= " AND "
                    Else
                        tSqlw1 &= " WHERE "
                        bCheck = True
                    End If
                    tSqlw1 &= " j.JobType=" & Request.QueryString("JobType").ToString & " "
                End If
                Dim oData1 = New CUtil(jobWebConn).GetTableFromSQL(SQLDashboard1(tSqlw1))
                msg = SQLDashboard1(tSqlw1)
                Dim json1 As String = ""
                For i As Integer = 0 To oData1.Rows.Count - 1
                    If i = 0 Then
                        json1 = "[""Status"",""Volume""]"
                    End If
                    Dim status As String = Convert.ToInt16(oData1.Rows(i)("JobStatus")).ToString("00")
                    json1 &= ",[""" & GetValueConfig("JOB_STATUS", status) & """," & oData1.Rows(i)("TotalJob") & "]"
                Next

                Dim oData2 = New CUtil(jobWebConn).GetTableFromSQL(SQLDashboard2(tSqlw1))
                msg = SQLDashboard2(tSqlw1)
                Dim json2 As String = ""
                For i As Integer = 0 To oData2.Rows.Count - 1
                    If i = 0 Then
                        json2 = "["
                        For j As Integer = 0 To oData2.Columns.Count - 1
                            If json2 <> "[" Then
                                json2 &= ","
                            End If
                            json2 &= """" & oData2.Columns(j).ColumnName & """"
                        Next
                        json2 &= "]"
                    End If
                    json2 &= ",["
                    For j As Integer = 0 To oData2.Columns.Count - 1
                        If j > 0 Then
                            json2 &= ","
                        End If
                        If oData2.Columns(j).ColumnName = "JobType" Then
                            Dim status As String = Convert.ToInt16(oData2.Rows(i)("JobType")).ToString("00")
                            json2 &= """" & GetValueConfig("JOB_TYPE", status) & """"
                        Else
                            json2 &= "" & oData2.Rows(i)(j)
                        End If
                    Next
                    json2 &= "]"
                Next

                Dim oData3 = New CUtil(jobWebConn).GetTableFromSQL(SQLDashboard3(tSqlw1))
                msg = SQLDashboard3(tSqlw1)

                Dim json3 As String = ""
                For i As Integer = 0 To oData3.Rows.Count - 1
                    If i = 0 Then
                        json3 = "["
                        For j As Integer = 0 To oData3.Columns.Count - 1
                            If json3 <> "[" Then
                                json3 &= ","
                            End If
                            json3 &= """" & oData3.Columns(j).ColumnName & """"
                        Next
                        json3 &= "]"
                    End If
                    json3 &= ",["
                    For j As Integer = 0 To oData3.Columns.Count - 1
                        If j > 0 Then
                            json3 &= ","
                        End If
                        If oData3.Columns(j).ColumnName = "CustCode" Then
                            json3 &= """" & oData3.Rows(i)(j) & """"
                        Else
                            json3 &= "" & oData3.Rows(i)(j)
                        End If
                    Next
                    json3 &= "]"
                Next
                Return Content("{""result"":[{""data1"":[" & json1 & "],""data2"":[" & json2 & "],""data3"":[" & json3 & "]}]}", jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetDashboard", "ERROR", ex.Message)
                Return Content("{""result"":[],""msg"":""" & ex.Message & """}", jsonContent)
            End Try
        End Function
    End Class
End Namespace