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
        Function FormWTax3() As ActionResult
            Return GetView("FormWTax3")
        End Function
        Function FormWTax53() As ActionResult
            Return GetView("FormWTax53")
        End Function
        Function FormWTax3D() As ActionResult
            Return GetView("FormWTax3D")
        End Function
        Function FormWTax53D() As ActionResult
            Return GetView("FormWTax53D")
        End Function
        Function FormInv() As ActionResult
            Return GetView("FormInv")
        End Function
        Function FormBill() As ActionResult
            Return GetView("FormBill")
        End Function
        Function FormRcp() As ActionResult
            Return GetView("FormRcp")
        End Function
        Function FormTaxInv() As ActionResult
            Return GetView("FormTaxInv")
        End Function
        Function FormCreditNote() As ActionResult
            Return GetView("FormCreditNote")
        End Function
        Function FormGL() As ActionResult
            Return GetView("FormGL")
        End Function
        Function Expense() As ActionResult
            Return GetView("Expense", "MODULE_ACC")
        End Function
        Function Invoice() As ActionResult
            Return GetView("Invoice", "MODULE_ACC")
        End Function
        Function Billing() As ActionResult
            Return GetView("Billing", "MODULE_ACC")
        End Function
        Function PettyCash() As ActionResult
            Return GetView("PettyCash", "MODULE_ACC")
        End Function
        Function Cheque() As ActionResult
            Return GetView("Cheque", "MODULE_ACC")
        End Function
        Function Receipt() As ActionResult
            Return GetView("Receipt", "MODULE_ACC")
        End Function
        Function RecvInv() As ActionResult
            Return GetView("RecvInv", "MODULE_ACC")
        End Function
        Function TaxInvoice() As ActionResult
            Return GetView("TaxInvoice", "MODULE_ACC")
        End Function
        Function CreditNote() As ActionResult
            Return GetView("CreditNote", "MODULE_ACC")
        End Function
        Function GLNote() As ActionResult
            Return GetView("GLNote", "MODULE_ACC")
        End Function
        Function FormVoucher() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Voucher")
            If AuthorizeStr.IndexOf("P") < 0 Then
                Return Content("You are not allow to print voucher", textContent)
            End If

            Return GetView("FormVoucher")
        End Function
        Function FormWHTax() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "WHTax")
            If AuthorizeStr.IndexOf("P") < 0 Then
                Return Content("You are not allow to print wh-tax form", textContent)
            End If

            Return GetView("FormWHTax")
        End Function
        Function GetVoucherGrid() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Voucher")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Payment")
                    If AuthorizeStr.IndexOf("R") < 0 Then
                        AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
                        If AuthorizeStr.IndexOf("R") < 0 Then
                            Return Content("{""voucher"":{""data"":null,""msg"":""You are not authorize to read""}}", jsonContent)
                        End If
                    End If
                End If

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
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Voucher")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Payment")
                    If AuthorizeStr.IndexOf("R") < 0 Then
                        AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
                        If AuthorizeStr.IndexOf("R") < 0 Then
                            Return Content("{""voucher"":{""header"":null,""payment"":null,""document"":null,""msg"":""You are not authorize to read""}}", jsonContent)
                        End If
                    End If
                End If

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
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Voucher")
                If AuthorizeStr.IndexOf("E") < 0 Then
                    AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Payment")
                    If AuthorizeStr.IndexOf("E") < 0 Then
                        AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
                        If AuthorizeStr.IndexOf("E") < 0 Then
                            Return Content("{""result"":{""data"":null,""msg"":""You are not authorize to edit voucher""}}", jsonContent)
                        End If
                    End If
                End If

                If Not IsNothing(data) Then

                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If

                    data.SetConnect(jobWebConn)

                    If "" & data.ControlNo = "" Then
                        AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Voucher")
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Payment")
                            If AuthorizeStr.IndexOf("I") < 0 Then
                                AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
                                If AuthorizeStr.IndexOf("I") < 0 Then
                                    Return Content("{""result"":{""data"":null,""msg"":""You are not authorize to add voucher""}}", jsonContent)
                                End If
                            End If
                        End If
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
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Voucher")
                If AuthorizeStr.IndexOf("E") < 0 Then
                    AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Payment")
                    If AuthorizeStr.IndexOf("E") < 0 Then
                        AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
                        If AuthorizeStr.IndexOf("E") < 0 Then
                            Return Content("{""result"":{""data"":null,""msg"":""You are not authorize to edit detail""}}", jsonContent)
                        End If
                    End If
                End If

                Dim json As String = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                If IsNothing(data) Then
                    Return Content(json, jsonContent)
                End If

                If "" & data(0).BranchCode = "" Then
                    Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                End If

                If "" & data(0).ControlNo = "" Then
                    Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                End If

                If data(0).ItemNo = 0 Then
                    AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Voucher")
                    If AuthorizeStr.IndexOf("I") < 0 Then
                        AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Payment")
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
                            If AuthorizeStr.IndexOf("I") < 0 Then
                                Return Content("{""result"":{""data"":null,""msg"":""You are not authorize to add detail""}}", jsonContent)
                            End If
                        End If
                    End If
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
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Voucher")
                If AuthorizeStr.IndexOf("E") < 0 Then
                    AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Payment")
                    If AuthorizeStr.IndexOf("E") < 0 Then
                        AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
                        If AuthorizeStr.IndexOf("E") < 0 Then
                            Return Content("{""result"":{""data"":null,""msg"":""You are not authorize to edit document""}}", jsonContent)
                        End If
                    End If
                End If

                Dim json As String = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                If IsNothing(data) Then
                    Return Content(json, jsonContent)
                End If

                If "" & data(0).BranchCode = "" Then
                    Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                End If

                If "" & data(0).ControlNo = "" Then
                    Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                End If

                If data(0).ItemNo = 0 Then
                    AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Voucher")
                    If AuthorizeStr.IndexOf("I") < 0 Then
                        AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Payment")
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
                            If AuthorizeStr.IndexOf("I") < 0 Then
                                Return Content("{""result"":{""data"":null,""msg"":""You are not authorize to add document""}}", jsonContent)
                            End If
                        End If
                    End If
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
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Voucher")
                If AuthorizeStr.IndexOf("D") < 0 Then
                    AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Payment")
                    If AuthorizeStr.IndexOf("D") < 0 Then
                        AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
                        If AuthorizeStr.IndexOf("D") < 0 Then
                            Return Content("{""voucher"":{""data"":null,""result"":""You are not authorize to delete document""}}", jsonContent)
                        End If
                    End If
                End If

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
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Voucher")
                If AuthorizeStr.IndexOf("D") < 0 Then
                    AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Payment")
                    If AuthorizeStr.IndexOf("D") < 0 Then
                        AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
                        If AuthorizeStr.IndexOf("D") < 0 Then
                            Return Content("{""voucher"":{""data"":null,""result"":""You are not authorize to delete document""}}", jsonContent)
                        End If
                    End If
                End If

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
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Voucher")
                If AuthorizeStr.IndexOf("D") < 0 Then
                    AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ADV", "Payment")
                    If AuthorizeStr.IndexOf("D") < 0 Then
                        AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
                        If AuthorizeStr.IndexOf("D") < 0 Then
                            Return Content("{""voucher"":{""data"":null,""result"":""You are not authorize to delete""}}", jsonContent)
                        End If
                    End If
                End If

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
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "WHTax")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""whtax"":{""header"":null,""detail"":null,""result"":""You are not authorize to read""}}", jsonContent)
                End If

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
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "WHTax")
                If AuthorizeStr.IndexOf("E") < 0 Then
                    Return Content("{""result"":{""data"":null,""msg"":""You are not authorize to edit""}}", jsonContent)
                End If

                If Not IsNothing(data) Then

                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If

                    data.SetConnect(jobWebConn)

                    If "" & data.DocNo = "" Then
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            Return Content("{""result"":{""data"":null,""msg"":""You are not authorize to add""}}", jsonContent)
                        End If
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
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "WHTax")
                If AuthorizeStr.IndexOf("D") < 0 Then
                    Return Content("{""whtax"":{""data"":null,""result"":""You are not authorize to delete""}}", jsonContent)
                End If

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
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "WHTax")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""whtax"":{""detail"":null,""msg"":""You are not authorize to read""}}", jsonContent)
                End If

                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If

                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo='{0}' ", Request.QueryString("Code").ToString)
                End If

                Dim oData = New CWHTaxDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""whtax"":{""detail"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetWHTaxDetail(<FromBody()> data As CWHTaxDetail) As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "WHTax")
                If AuthorizeStr.IndexOf("E") < 0 Then
                    Return Content("{""result"":{""data"":null,""msg"":""You are not authorize to edit""}}", jsonContent)
                End If

                If Not IsNothing(data) Then

                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If

                    If "" & data.DocNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If

                    If data.ItemNo = 0 Then
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            Return Content("{""result"":{""data"":null,""msg"":""You are not authorize to add""}}", jsonContent)
                        End If
                    End If

                    data.SetConnect(jobWebConn)
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
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "WHTax")
                If AuthorizeStr.IndexOf("D") < 0 Then
                    Return Content("{""whtax"":{""data"":null,""result"":""You are not authorize to delete""}}", jsonContent)
                End If

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
        Function GetInvHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CInvHeader(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""invheader"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetInvHeader(<FromBody()> data As CInvHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.DocNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE DocNo='{0}' ", data.DocNo))
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
        Function DelInvHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""invheader"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CInvHeader(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""invheader"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetBillHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE BillAcceptNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BillAcceptNo ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CBillHeader(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""billheader"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetBillHeader(<FromBody()> data As CBillHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BillAcceptNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BillAcceptNo='{0}' ", data.BillAcceptNo))
                    Dim json = "{""result"":{""data"":""" & data.BillAcceptNo & """,""msg"":""" & msg & """}}"
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
        Function DelBillHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE BillAcceptNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BillAcceptNo Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""billheader"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CBillHeader(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""billheader"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetRcpHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ReceiptNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ReceiptNo ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CRcpHeader(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""rcpheader"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetRcpHeader(<FromBody()> data As CRcpHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.ReceiptNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE ReceiptNo='{0}' ", data.ReceiptNo))
                    Dim json = "{""result"":{""data"":""" & data.ReceiptNo & """,""msg"":""" & msg & """}}"
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
        Function DelRcpHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ReceiptNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ReceiptNo Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""rcpheader"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CRcpHeader(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""rcpheader"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetInvDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CInvDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""invdetail"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetInvDetail(<FromBody()> data As CInvDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.DocNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE DocNo='{0}' ", data.DocNo))
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
        Function DelInvDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""invdetail"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CInvDetail(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""invdetail"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetBillDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE BillAcceptNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BillAcceptNo ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CBillDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""billdetail"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetBillDetail(<FromBody()> data As CBillDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BillAcceptNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BillAcceptNo='{0}' ", data.BillAcceptNo))
                    Dim json = "{""result"":{""data"":""" & data.BillAcceptNo & """,""msg"":""" & msg & """}}"
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
        Function DelBillDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE BillAcceptNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BillAcceptNo Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""billdetail"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CBillDetail(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""billdetail"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetRcpDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ReceiptNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ReceiptNo ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CRcpDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""rcpdetail"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetRcpDetail(<FromBody()> data As CRcpDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.ReceiptNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE ReceiptNo='{0}' ", data.ReceiptNo))
                    Dim json = "{""result"":{""data"":""" & data.ReceiptNo & """,""msg"":""" & msg & """}}"
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
        Function DelRcpDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ReceiptNo<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ReceiptNo Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""rcpdetail"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CRcpDetail(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""rcpdetail"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
    End Class
End Namespace