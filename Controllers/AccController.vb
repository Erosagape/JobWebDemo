Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json

Namespace Controllers
    Public Class AccController
        Inherits CController
        ' GET: Acc
        Function Index() As ActionResult
            Return View()
        End Function
        '-----Controller-----
        Function Voucher() As ActionResult
            Return GetView("Voucher", "MODULE_ACC")
        End Function
        '-----Controller-----
        Function WHTax() As ActionResult
            Return GetView("WHTax", "MODULE_ACC")
        End Function
        Function FormVoucher() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Voucher")
            If AuthorizeStr.IndexOf("P") < 0 Then
                Return Content("You are not allow to print voucher", textContent)
            End If
            Return GetView("FormVoucher")
        End Function
        Function GetVoucherGrid() As ActionResult
            Try
                Dim tSqlw As String = "
SELECT h.BranchCode,h.ControlNo,h.VoucherDate,h.TRemark,h.RecUser,h.RecDate,h.RecTime,
h.PostedBy,h.PostedDate,h.PostedTime,h.CancelReson,h.CancelProve,h.CancelDate,h.CancelTime,
d.ItemNo,d.PRVoucher,d.PRType,d.ChqNo,d.BookCode,d.BankCode,d.BankBranch,d.ChqDate,d.CashAmount,d.ChqAmount,d.CreditAmount,
d.IsLocal,d.ChqStatus,d.TRemark as DRemark,d.PayChqTo,d.DocNo as DRefNo,d.SICode,d.RecvBank,d.RecvBranch,
d.acType,r.ItemNo as DocItemNo,r.DocType,r.DocNo,r.DocDate,r.CmpType,r.CmpCode,r.CmpBranch,r.PaidAmount,r.TotalAmount 
FROM Job_CashControl h inner join Job_CashControlSub d
on h.BranchCode=d.BranchCode AND h.ControlNo=d.ControlNo
left join Job_CashControlDoc r
on d.BranchCode=r.BranchCode AND d.ControlNo=r.ControlNo
AND d.acType=r.acType
"
                tSqlw &= " WHERE h.ControlNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND h.BranchCode ='{0}'", Request.QueryString("Branch").ToString)
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(tSqlw)
                Dim oHead As String = JsonConvert.SerializeObject(oData.AsEnumerable().ToList())
                Dim json = "{""voucher"":{""data"":" & oHead & ",""msg"":""Complete!""}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("{""voucher"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function GetVoucher() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ControlNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode ='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND ControlNo ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CVoucher(jobWebConn).GetData(tSqlw)
                Dim oHead As String = JsonConvert.SerializeObject(oData)
                Dim oSub As String = JsonConvert.SerializeObject(New CVoucherSub(jobWebConn).GetData(tSqlw))
                Dim oDoc As String = JsonConvert.SerializeObject(New CVoucherDoc(jobWebConn).GetData(tSqlw))
                Dim json = "{""voucher"":{""header"":" & oHead & ",""payment"":" & oSub & ",""document"":" & oDoc & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetVoucherHeader(<FromBody()> data As CVoucher) As ActionResult
            Try
                data.SetConnect(jobWebConn)
                If Not IsNothing(data) Then
                    If "" & data.ControlNo = "" Then
                        data.AddNew(DateTime.Now.ToString("yyMM") & "-___")
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND  ControlNo='{1}' ", data.BranchCode, data.ControlNo))
                    Dim json = "{""result"":{""data"":""" & data.ControlNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function SetVoucherSub(<FromBody()> data As List(Of CVoucherSub)) As ActionResult
            Try
                Dim json As String = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                If IsNothing(data) Then
                    Return Content(json, jsonContent)
                End If
                Dim i As Integer = 0
                Dim str As String = ""
                Dim branchcode As String = ""
                Dim docno As String = ""
                For Each o As CVoucherSub In data
                    i = i + 1
                    branchcode = o.BranchCode
                    docno = o.ControlNo
                    o.SetConnect(jobWebConn)
                    If o.PRVoucher = "" Then
                        o.AddNew(o.PRType & "V-" & DateTime.Today.ToString("yyMM") & "-____")
                    End If
                    If str <> "" Then str &= ","
                    str &= o.SaveData(String.Format(" WHERE BranchCode='{0}' AND  ControlNo='{1}' And ItemNo='{2}' ", o.BranchCode, o.ControlNo, o.ItemNo))
                Next
                Dim obj = New CVoucherSub(jobWebConn).GetData(String.Format(" WHERE BranchCode='{0}' And ControlNo='{1}'", branchcode, docno))
                json = "{""result"":{""msg"":""" & str & """,""data"":[" & JsonConvert.SerializeObject(obj) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Dim json = "{""result"":{""data"":[],""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function SetVoucherDoc(<FromBody()> data As List(Of CVoucherDoc)) As ActionResult
            Try
                Dim json As String = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                If IsNothing(data) Then
                    Return Content(json, jsonContent)
                End If
                Dim i As Integer = 0
                Dim str As String = ""
                Dim branchcode As String = ""
                Dim docno As String = ""
                For Each o As CVoucherDoc In data
                    i = i + 1
                    branchcode = o.BranchCode
                    docno = o.ControlNo
                    o.SetConnect(jobWebConn)
                    If o.ItemNo = 0 Then
                        o.AddNew()
                    End If
                    Dim msg = o.SaveData(String.Format(" WHERE BranchCode='{0}' AND  ControlNo='{1}' And ItemNo='{2}' ", o.BranchCode, o.ControlNo, o.ItemNo))
                    If str <> "" Then str &= ","
                    str &= msg
                Next
                Dim obj = New CVoucherDoc(jobWebConn).GetData(String.Format(" WHERE BranchCode='{0}' And ControlNo='{1}'", branchcode, docno))
                json = "{""result"":{""msg"":""" & str & """,""data"":""" & docno & """,""document"":[" & JsonConvert.SerializeObject(obj) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""Error!"",""error"":""" & ex.Message & """,""document"":[]}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelVoucherSub() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ControlNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND ControlNo='{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""voucher"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If IsNothing(Request.QueryString("Item")) Then
                    Return Content("{""voucher"":{""result"":""Please Select Some Item"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CVoucherSub(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw & String.Format(" AND ItemNo='{0}'", Request.QueryString("Item").ToString))
                Dim oDataSub = oData.GetData(tSqlw)

                Dim json = "{""voucher"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oDataSub) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function DelVoucherDoc() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ControlNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND ControlNo='{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""voucher"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If IsNothing(Request.QueryString("Item")) Then
                    Return Content("{""voucher"":{""result"":""Please Select Some Item"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CVoucherDoc(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw & String.Format(" AND ItemNo='{0}'", Request.QueryString("Item").ToString))
                Dim oDataDoc = oData.GetData(tSqlw)

                Dim json = "{""voucher"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oDataDoc) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function DelVoucher() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ControlNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND ControlNo='{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""voucher"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CVoucher(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)
                If msg.Substring(0, 1) = "D" Then
                    msg = New CVoucherSub(jobWebConn).DeleteData(tSqlw)
                    msg = New CVoucherDoc(jobWebConn).DeleteData(tSqlw)
                End If
                Dim json = "{""voucher"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetWHTax() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo ='{0}' ", Request.QueryString("Code").ToString)
                End If

                Dim oDatah = New CWHTaxHeader(jobWebConn).GetData(tSqlw)
                Dim jsonh As String = JsonConvert.SerializeObject(oDatah)

                Dim oDatad = New CWHTaxDetail(jobWebConn).GetData(tSqlw)
                Dim jsond As String = JsonConvert.SerializeObject(oDatah)

                Dim jsonAll = "{""whtax"":{""header"":" & jsonh & ":""detail"":" & jsond & "}}"
                Return Content(jsonAll, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetWHTaxHeader(<FromBody()> data As CWHTaxHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    If "" & data.DocNo = "" Then
                        data.AddNew("WT-" & DateTime.Now.ToString("yyMM") & "-____")
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND DocNo='{1}' ", data.BranchCode, data.DocNo))
                    Dim json = "{""result"":{""data"":""" & data.DocNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelWHTaxHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode Like '{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""whtax"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo Like '{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""whtax"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CWHTaxHeader(jobWebConn)
                Dim msg = New CWHTaxDetail(jobWebConn).DeleteData(tSqlw)
                msg = oData.DeleteData(tSqlw)

                Dim json = "{""whtax"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetWHTaxDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CWHTaxDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""whtaxdetail"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetWHTaxDetail(<FromBody()> data As CWHTaxDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data.DocNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If

                    data.SetConnect(jobWebConn)
                    If data.ItemNo = 0 Then
                        data.AddNew()
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND DocNo='{1}' AND ItemNo={2} ", data.BranchCode, data.DocNo, data.ItemNo))
                    Dim json = "{""result"":{""data"":""" & data.DocNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelWHTaxDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""whtax"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo ='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""whtax"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("ItemNo")) Then
                    tSqlw &= String.Format("AND ItemNo ='{0}' ", Request.QueryString("ItemNo").ToString)
                Else
                    Return Content("{""whtax"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CWHTaxDetail(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""whtax"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
    End Class
End Namespace