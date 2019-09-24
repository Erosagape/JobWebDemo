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
        Function Payment() As ActionResult
            Return GetView("Payment", "MODULE_ACC")
        End Function
        Function GetPayment() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND DocNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("VenCode")) Then
                    tSqlw &= String.Format(" AND VenCode='{0}' ", Request.QueryString("VenCode").ToString)
                End If
                If Not IsNothing(Request.QueryString("Currency")) Then
                    tSqlw &= String.Format(" AND CurrencyCode='{0}' ", Request.QueryString("Currency").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND DocDate>='" & Request.QueryString("DateFrom") & " 00:00:00' "
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND DocDate<='" & Request.QueryString("DateTo") & " 23:59:00' "
                End If
                If Not IsNothing(Request.QueryString("Type")) Then
                    If Request.QueryString("Type").ToString = "NOPAY" Then
                        tSqlw &= String.Format(" AND NOT (DocNo IN(SELECT p.DocNo FROM (SELECT h.DocNo FROM Job_CashControlDoc h INNER JOIN Job_CashControlSub d ON h.BranchCode=d.BranchCode AND h.ControlNo=d.ControlNo AND h.acType=d.acType WHERE h.DocType='PAY' AND d.PRType='P' AND h.BranchCode='{0}') p  )", Request.QueryString("Branch").ToString)
                        tSqlw &= String.Format(" OR DocNo IN(SELECT DISTINCT p.PaymentNo FROM (SELECT h.PaymentNo FROM Job_AdvHeader h WHERE h.DocStatus<>99 AND h.BranchCode='{0}') p WHERE p.PaymentNo IS NOT NULL))", Request.QueryString("Branch").ToString)
                    End If
                End If
                Dim oData = New CPayHeader(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                Dim oDataD = New CPayDetail(jobWebConn).GetData(tSqlw)
                Dim jsonD As String = JsonConvert.SerializeObject(oDataD)

                json = "{""payment"":{""header"":" & json & ",""detail"":" & jsonD & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetPayment", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetPaymentGrid() As ActionResult
            Try
                Dim tSqlw As String = SQLSelectPaymentReport() & " WHERE h.DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND h.BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND h.DocNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("VenCode")) Then
                    tSqlw &= String.Format(" AND h.VenCode='{0}' ", Request.QueryString("VenCode").ToString)
                End If
                If Not IsNothing(Request.QueryString("Currency")) Then
                    tSqlw &= String.Format(" AND h.CurrencyCode='{0}' ", Request.QueryString("Currency").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND h.DocDate>='" & Request.QueryString("DateFrom") & " 00:00:00' "
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND h.DocDate<='" & Request.QueryString("DateTo") & " 23:59:00' "
                End If
                If Not IsNothing(Request.QueryString("Type")) Then
                    If Request.QueryString("Type").ToString = "NOPAY" Then
                        tSqlw &= String.Format(" AND NOT (h.DocNo IN(SELECT p.DocNo FROM (SELECT hd.DocNo FROM Job_CashControlDoc hd INNER JOIN Job_CashControlSub dt ON hd.BranchCode=dt.BranchCode AND hd.ControlNo=dt.ControlNo AND hd.acType=dt.acType WHERE hd.DocType='PAY' AND dt.PRType='P' AND hd.BranchCode='{0}') p  )", Request.QueryString("Branch").ToString)
                        tSqlw &= String.Format(" OR h.DocNo IN(SELECT DISTINCT p.PaymentNo FROM (SELECT hd.PaymentNo FROM Job_AdvHeader hd WHERE hd.DocStatus<>99 AND hd.BranchCode='{0}') p WHERE p.PaymentNo IS NOT NULL))", Request.QueryString("Branch").ToString)
                    End If
                End If
                If Not IsNothing(Request.QueryString("Show")) Then
                    If Request.QueryString("Show").ToString = "ACTIVE" Then
                        tSqlw &= " AND NOT ISNULL(h.CancelProve,'')<>'' "
                    End If
                    If Request.QueryString("Show").ToString = "CANCEL" Then
                        tSqlw &= " AND ISNULL(h.CancelProve,'')<>'' "
                    End If
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(tSqlw)
                Dim json = JsonConvert.SerializeObject(oData)
                Return Content("{""payment"":{""data"":" & json & ",""msg"":""" & oData.Rows.Count & """}}", jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetPaymentGrid", "ERROR", ex.Message)
                Return Content("{""payment"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function SetPayHeader(<FromBody()> data As CPayHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data.DocNo = "" Then
                        data.AddNew(payPrefix & Now.ToString("yyMM") & "-____")
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND DocNo='{1}' ", data.BranchCode, data.DocNo))
                    Dim json = "{""result"":{""data"":""" & data.DocNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetPayHeader", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelPayHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""payment"":{""result"":""Please Select Some branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""payment"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CPayHeader(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)
                Dim oDataD As New CPayDetail(jobWebConn)
                oDataD.DeleteData(tSqlw)

                Dim json = "{""payment"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelPayHeader", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetPayDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format("AND ItemNo={0} ", Request.QueryString("Item").ToString)
                End If
                Dim oData = New CPayDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""payment"":{""detail"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetPayDetail", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetPayDetail(<FromBody()> data As CPayDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data.DocNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Document""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)

                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND DocNo='{1}' AND ItemNo={2} ", data.BranchCode, data.DocNo, data.ItemNo))
                    Dim json = "{""result"":{""data"":""" & data.ItemNo & """,""msg"":""" & msg & """}}"

                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetPayDetail", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelPayDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                Dim oData As New CPayDetail(jobWebConn)
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                    oData.BranchCode = Request.QueryString("Branch").ToString
                Else
                    Return Content("{""payment"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND DocNo='{0}' ", Request.QueryString("Code").ToString)
                    oData.DocNo = Request.QueryString("Code").ToString
                Else
                    Return Content("{""payment"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format(" AND ItemNo={0} ", Request.QueryString("Item").ToString)
                    oData.ItemNo = Request.QueryString("Item").ToString
                Else
                    Return Content("{""payment"":{""result"":""Please Select Some Item"",""data"":[]}}", jsonContent)
                End If

                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""payment"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelPayDetail", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function FormInv() As ActionResult
            Try
                If Not Request.QueryString("branch") Is Nothing Then
                    If Not Request.QueryString("code") Is Nothing Then
                        Dim oRec = New CInvHeader(jobWebConn)
                        Dim sqlw = String.Format(" WHERE BranchCode='{0}' AND DocNo='{1}'", Request.QueryString("branch").ToString, Request.QueryString("code").ToString)
                        Dim oRow = oRec.GetData(sqlw)
                        If oRow.Count > 0 Then
                            oRow(0).PrintedBy = Session("CurrUser").ToString
                            oRow(0).PrintedDate = DateTime.Today
                            oRow(0).PrintedTime = DateTime.Now
                            oRow(0).SaveData(sqlw)
                        End If
                    End If
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "FormInv", "ERROR", ex.Message)
            End Try
            Return GetView("FormInv")
        End Function
        Function FormBill() As ActionResult
            Return GetView("FormBill")
        End Function
        Function FormRcp() As ActionResult
            Try
                If Not Request.QueryString("branch") Is Nothing Then
                    If Not Request.QueryString("code") Is Nothing Then
                        Dim oRec = New CRcpHeader(jobWebConn)
                        Dim sqlw = String.Format(" WHERE BranchCode='{0}' AND ReceiptNo='{1}'", Request.QueryString("branch").ToString, Request.QueryString("code").ToString)
                        Dim oRow = oRec.GetData(sqlw)
                        If oRow.Count > 0 Then
                            oRow(0).PrintedBy = Session("CurrUser").ToString
                            oRow(0).PrintedDate = DateTime.Today
                            oRow(0).PrintedTime = DateTime.Now
                            oRow(0).SaveData(sqlw)
                        End If
                    End If
                End If

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "FormRcp", "ERROR", ex.Message)
            End Try
            Return GetView("FormRcp")
        End Function
        Function FormTaxInv() As ActionResult
            Try
                If Not Request.QueryString("branch") Is Nothing Then
                    If Not Request.QueryString("code") Is Nothing Then
                        Dim oRec = New CRcpHeader(jobWebConn)
                        Dim sqlw = String.Format(" WHERE BranchCode='{0}' AND ReceiptNo='{1}'", Request.QueryString("branch").ToString, Request.QueryString("code").ToString)
                        Dim oRow = oRec.GetData(sqlw)
                        If oRow.Count > 0 Then
                            oRow(0).PrintedBy = Session("CurrUser").ToString
                            oRow(0).PrintedDate = DateTime.Today
                            oRow(0).PrintedTime = DateTime.Now
                            oRow(0).SaveData(sqlw)
                        End If
                    End If
                End If

            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "FormTaxInv", "ERROR", ex.Message)
            End Try

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
        Function GenerateBilling() As ActionResult
            Return GetView("GenerateBilling")
        End Function
        Function GenerateReceipt() As ActionResult
            Return GetView("GenerateReceipt")
        End Function
        Function GenerateTaxInv() As ActionResult
            Return GetView("GenerateTaxInv")
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
        Function GetCNDNDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode ='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND DocNo ='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format(" AND ItemNo ='{0}'", Request.QueryString("Item").ToString)
                End If
                Dim oData = New CCNDNDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""creditnote"":{""detail"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetCNDNDetail", "ERROR", ex.Message)

                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetCNDNDetail(<FromBody()> data As CCNDNDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data.DocNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    If data.ItemNo = 0 Then
                        data.AddNew()
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
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetCNDNDetail", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelCNDNDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode Like '{0}'", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""creditnote"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If

                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND DocNo Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""creditnote"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CCNDNDetail(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""creditnote"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelCNDNDetail", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetCNDNGrid() As ActionResult
            Try
                Dim tSqlw As String = ""
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlw = String.Format(" WHERE a.DocStatus IN('{0}') ", Request.QueryString("Status").ToString().Replace(",", "','"))
                Else
                    tSqlw = " WHERE a.DocStatus <>'99' "
                End If
                If Not IsNothing(Request.QueryString("Show")) Then
                    If Request.QueryString("Show").ToString = "CN" Then
                        tSqlw &= " AND b.TotalNet>0 "
                    End If
                    If Request.QueryString("Show").ToString = "DN" Then
                        tSqlw &= " AND b.TotalNet<0 "
                    End If
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND a.BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND a.DocDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND a.DocDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format(" AND a.CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(Main.SQLSelectCNDNSummary() & tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""creditnote"":{""data"":" & json & ",""msg"":""" & tSqlw & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetCNDNGrid", "ERROR", ex.Message)
                Return Content("{""creditnote"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetCreditNote() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode ='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND DocNo ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CCNDNHeader(jobWebConn).GetData(tSqlw)
                Dim strCust As String = "[]"
                If oData.Count > 0 Then
                    Dim oCust = New CCompany(jobWebConn).GetData(String.Format(" WHERE CustCode='{0}' AND Branch='{1}'", oData(0).CustCode, oData(0).CustBranch))
                    If oCust.Count > 0 Then
                        strCust = JsonConvert.SerializeObject(oCust(0))
                    End If
                End If
                Dim jsonH As String = JsonConvert.SerializeObject(oData)
                Dim oDataD = New CCNDNDetail(jobWebConn).GetData(tSqlw)
                Dim jsonD As String = JsonConvert.SerializeObject(oDataD)
                Dim json = "{""creditnote"":{""header"":" & jsonH & ",""detail"":" & jsonD & ",""customer"":" & strCust & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetCreditNote", "ERROR", ex.Message)
                Return Content("{""creditnote"":{""header"":[],""detail"":[],""customer"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function SetCNDNHeader(<FromBody()> data As CCNDNHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    data.SetConnect(jobWebConn)
                    If "" & data.DocNo = "" Then
                        If data.DocDate = DateTime.MinValue Then
                            data.DocDate = Today.Date
                        End If
                        data.AddNew(If(data.DocType = 0, "CN", "DN") & "-" & data.DocDate.ToString("yyMM") & "-____")
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND DocNo='{1}' ", data.BranchCode, data.DocNo))
                    Dim json = "{""result"":{""data"":""" & data.DocNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetCNDNHeader", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelCreditNote() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                Dim oData As New CCNDNHeader(jobWebConn)
                Dim oDataD As New CCNDNDetail(jobWebConn)
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}'", Request.QueryString("Branch").ToString)
                    oData.BranchCode = Request.QueryString("Branch").ToString
                    oDataD.BranchCode = Request.QueryString("Branch").ToString
                Else
                    Return Content("{""creditnote"":{""result"":""Please Select Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo Like '{0}'", Request.QueryString("Code").ToString)
                    oData.DocNo = Request.QueryString("Code").ToString
                    oDataD.DocNo = Request.QueryString("Code").ToString
                Else
                    Return Content("{""creditnote"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                oDataD.DeleteData(tSqlw)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""creditnote"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelCreditNote", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GLNote() As ActionResult
            Return GetView("GLNote", "MODULE_ACC")
            'Return RedirectToAction("FormGL")
        End Function
        Function GetJournalEntry() As ActionResult
            Try
                Dim tSqlw As String = " WHERE GLRefNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND GLRefNo ='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim oDataD = New CGLDetail(jobWebConn).GetData(tSqlw)
                Dim jsonD As String = JsonConvert.SerializeObject(oDataD)
                If Not IsNothing(Request.QueryString("Year")) Then
                    tSqlw &= String.Format("AND FiscalYear='{0}' ", Request.QueryString("Year").ToString)
                End If
                Dim oData = New CGLHeader(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""journal"":{""header"":" & json & ",""detail"":" & jsonD & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetJournalEntry", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetGLDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE GLRefNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND GLRefNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format(" AND ItemNo={0} ", Request.QueryString("Item").ToString)
                End If
                Dim oData = New CGLDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""journal"":{""detail"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetGLDetail", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetGLDetail(<FromBody()> data As CGLDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data.GLRefNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND GLRefNo='{1}' AND ItemNo={2} ", data.BranchCode, data.GLRefNo, data.ItemNo))
                    Dim json = "{""result"":{""data"":""" & data.ItemNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetGLDetail", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelGLDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE GLRefNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""journal"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND GLRefNo='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""journal"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format(" AND ItemNo={0} ", Request.QueryString("Item").ToString)
                Else
                    Return Content("{""journal"":{""result"":""Please Select Some Item"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CGLDetail(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""journal"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelGLDetail", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetGLHeader(<FromBody()> data As CGLHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    If "" & data.GLRefNo = "" Then
                        data.AddNew(data.GLType & DateTime.Today.ToString("yyMM") & "____")
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND GLRefNo='{1}' ", data.BranchCode, data.GLRefNo))
                    Dim json = "{""result"":{""data"":""" & data.GLRefNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetGLHeader", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelGLHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE GLRefNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""journal"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND GLRefNo='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""journal"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CGLHeader(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)
                Dim oDataD As New CGLDetail(jobWebConn)
                Dim msgD = oDataD.DeleteData(tSqlw)

                Dim json = "{""journal"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelGLHeader", "ERROR", ex.Message)
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function FormExpense() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "Expense")
            If AuthorizeStr.IndexOf("P") < 0 Then
                Return Content("You are not allow to print expenses", textContent)
            End If

            Return GetView("FormExpense")
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

                Dim tSqlw As String = SQLSelectVoucher()
                tSqlw &= " WHERE h.ControlNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND h.BranchCode ='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Job")) Then
                    tSqlw &= String.Format(" AND d.ForJNo ='{0}'", Request.QueryString("Job").ToString)
                End If
                If IsNothing(Request.QueryString("Cancel")) Then
                    tSqlw &= " AND NOT ISNULL(h.CancelProve,'')<>'' "
                Else
                    tSqlw &= String.Format(" AND ISNULL(h.CancelProve,'')='{0}' ", Request.QueryString("Cancel").ToString())
                End If
                If Not IsNothing(Request.QueryString("Type")) Then
                    Select Case Request.QueryString("Type").ToString
                        Case "CHQP"
                            tSqlw &= " AND d.ChqAmount>0 AND PRType='P'"
                        Case "CHQR"
                            tSqlw &= " AND d.ChqAmount>0 AND PRType='R'"
                        Case "CASHP"
                            tSqlw &= " AND d.CashAmount>0 AND PRType='P'"
                        Case "CASHR"
                            tSqlw &= " AND d.CashAmount>0 AND PRType='R'"
                        Case "TACC"
                            tSqlw &= String.Format(" AND d.DocNo Like '{0}%'", Request.QueryString("Type").ToString)
                    End Select
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(tSqlw)
                Dim oHead As String = JsonConvert.SerializeObject(oData.AsEnumerable().ToList())
                Dim json = "{""voucher"":{""data"":" & oHead & ",""msg"":""Complete!""}}"

                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetVoucherGrid", "ERROR", ex.Message)
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
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetVoucher", "ERROR", ex.Message)
                Return Content("{""voucher"":{""header"":null,""payment"":null,""document"":null,""msg"":""" & ex.Message & """}}", jsonContent)
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
                        If data.VoucherDate = DateTime.MinValue Then
                            data.VoucherDate = Today.Date
                        End If
                        data.AddNew(data.VoucherDate.ToString("yyMM") & "-___")
                    End If
                    Dim tSql As String = String.Format(" WHERE BranchCode='{0}' AND  ControlNo='{1}' ", data.BranchCode, data.ControlNo)
                    Dim msg = data.SaveData(tSql)
                    Dim json = "{""result"":{""data"":""" & data.ControlNo & """,""msg"":""" & msg & """}}"

                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetVoucherHeader", "ERROR", ex.Message)
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
                    i += 1
                    branchcode = o.BranchCode
                    docno = o.ControlNo
                    o.SetConnect(jobWebConn)
                    If o.PRVoucher = "" Then
                        o.AddNew(o.PRType & "V-" & DateTime.Today.ToString("yyMM") & "-____")
                    End If
                    If str <> "" Then str &= ","
                    Dim msg = o.SaveData(String.Format(" WHERE BranchCode='{0}' AND  ControlNo='{1}' And ItemNo='{2}' ", o.BranchCode, o.ControlNo, o.ItemNo))
                    If msg.Substring(0, 1) = "[" Then
                        Return Content("{""result"":{""data"":[],""msg"":""" & msg & """}}", jsonContent)
                    End If
                    str &= msg
                Next

                Dim obj = New CVoucherSub(jobWebConn).GetData(String.Format(" WHERE BranchCode='{0}' And ControlNo='{1}'", branchcode, docno))
                json = "{""result"":{""msg"":""" & str & """,""data"":[" & JsonConvert.SerializeObject(obj) & "]}}"

                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetVoucherSub", "ERROR", ex.Message)
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
                    i += 1
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
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetVoucherDoc", "ERROR", ex.Message)
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
                Dim oData As New CVoucherSub(jobWebConn)
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                    oData.BranchCode = Request.QueryString("Branch").ToString
                End If

                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND ControlNo='{0}'", Request.QueryString("Code").ToString)
                    oData.ControlNo = Request.QueryString("Code").ToString
                Else
                    Return Content("{""voucher"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If

                If IsNothing(Request.QueryString("Item")) Then
                    Return Content("{""voucher"":{""result"":""Please Select Some Item"",""data"":[]}}", jsonContent)
                Else
                    oData.ItemNo = Request.QueryString("Item").ToString
                    tSqlw &= String.Format(" AND ItemNo='{0}'", Request.QueryString("Item").ToString)
                End If
                Dim msg = ""
                Dim oDataSub = oData.GetData(tSqlw)
                For Each oRow In oDataSub
                    msg &= oRow.DeleteData()
                Next

                Dim json = "{""voucher"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oDataSub) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelVoucherSub", "ERROR", ex.Message)
                Return Content("{""voucher"":{""result"":""" & ex.Message & """,""data"":[]}}", jsonContent)
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
                Dim oDataDoc = oData.GetData(tSqlw & String.Format(" AND ItemNo='{0}'", Request.QueryString("Item").ToString))
                Dim msg = ""
                For Each oRow In oDataDoc
                    msg &= oRow.DeleteData()
                Next

                Dim json = "{""voucher"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oDataDoc) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelVoucherDoc", "ERROR", ex.Message)
                Return Content("{""voucher"":{""result"":""" & ex.Message & """,""data"":[]}}", jsonContent)
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
                Dim oData As New CVoucher(jobWebConn)
                Dim tSqlw As String = " WHERE ControlNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                    oData.BranchCode = Request.QueryString("Branch").ToString
                End If

                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND ControlNo='{0}'", Request.QueryString("Code").ToString)
                    oData.ControlNo = Request.QueryString("Code").ToString
                Else
                    Return Content("{""voucher"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If

                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""voucher"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"

                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelVoucher", "ERROR", ex.Message)
                Return Content("{""voucher"":{""result"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetWHTax() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "WHTax")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""whtax"":{""header"":null,""detail"":null,""msg"":""You are not authorize to read""}}", jsonContent)
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
                Dim jsond As String = JsonConvert.SerializeObject(oDatad)

                Dim jsonAll = "{""whtax"":{""header"":" & jsonh & ",""detail"":" & jsond & "}}"
                Return Content(jsonAll, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetWHTax", "ERROR", ex.Message)
                Return Content("{""whtax"":{""msg"":""" & ex.Message & """,""header"":[],""detail"":[]}}", jsonContent)
            End Try
        End Function
        Function GetWHTaxGrid()
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr = Main.GetAuthorize(ViewBag.User, "MODULE_ACC", "WHTax")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""whtax"":{""data"":null,""msg"":""You are not authorize to read""}}", jsonContent)
                End If

                Dim tSqlw As String = SQLSelectWHTax()

                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" WHERE h.BranchCode ='{0}'", Request.QueryString("Branch").ToString)
                Else
                    tSqlw &= " WHERE NOT ISNULL(h.CancelProve,'')<>'' "
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND h.DocNo ='{0}'", Request.QueryString("Code").ToString)
                End If

                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(tSqlw)
                Dim oHead As String = JsonConvert.SerializeObject(oData.AsEnumerable().ToList())
                Dim json = "{""whtax"":{""data"":" & oHead & ",""msg"":""Complete!""}}"

                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetWHTaxGrid", "ERROR", ex.Message)
                Return Content("{""whtax"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
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
                        If data.DocDate = DateTime.MinValue Then
                            data.DocDate = Today.Date
                        End If
                        data.AddNew(whtPrefix & data.DocDate.ToString("yyMM") & "-____")
                    End If

                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND DocNo='{1}' ", data.BranchCode, data.DocNo))
                    Dim json = "{""result"":{""data"":""" & data.DocNo & """,""msg"":""" & msg & """}}"

                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetWHTaxHeader", "ERROR", ex.Message)
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
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelWHTaxHeader", "ERROR", ex.Message)
                Return Content("{""whtax"":{""result"":""" & ex.Message & """,""data"":[]}}", jsonContent)
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
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetWHTaxDetail", "ERROR", ex.Message)
                Return Content("{""whtax"":{""msg"":""" & ex.Message & """,""detail"":[]}}", jsonContent)
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
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetWHTaxDetail", "ERROR", ex.Message)
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
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelWHTaxDetail", "ERROR", ex.Message)
                Return Content("{""whtax"":{""result"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetInvoice() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                Dim docNo As String = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo='{0}' ", Request.QueryString("Code").ToString)
                    docNo = Request.QueryString("Code").ToString
                End If

                Dim oHead = New CInvHeader(jobWebConn).GetData(tSqlw)
                Dim oDet = New CInvDetail(jobWebConn).GetData(tSqlw)

                Dim jsonH As String = ""
                Dim jsonD As String = ""
                Dim jsonC As String = ""
                Dim jsonJob As String = ""

                If oHead.Count > 0 Then
                    jsonH = JsonConvert.SerializeObject(oHead)
                    If oDet.Count > 0 Then
                        jsonD = JsonConvert.SerializeObject(oDet)
                    End If
                    Dim oCust = New CCompany(jobWebConn).GetData(String.Format(" WHERE CustCode='{0}' AND Branch='{1}'", oHead(0).CustCode, oHead(0).CustBranch))
                    jsonC = JsonConvert.SerializeObject(oCust)
                End If

                If oDet.Count > 0 Then
                    Dim oJob = New CJobOrder(jobWebConn).GetData(String.Format(" WHERE BranchCode='{0}' AND JNo IN(SELECT JobNo FROM Job_ClearDetail WHERE BranchCode='{0}' AND LinkBillNo='{1}')", oDet(0).BranchCode, oDet(0).DocNo))
                    jsonJob = JsonConvert.SerializeObject(oJob)
                End If
                Return Content("{""invoice"":{""msg"":""" & docNo & """,""header"":[" & jsonH & "],""detail"":[" & jsonD & "],""customer"":[" & jsonC & "],""job"":[" & jsonJob & "]}}", jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetInvoice", "ERROR", ex.Message)
                Return Content("{""invoice"":{""msg"":""" & ex.Message & """,""header"":[],""detail"":[]}}", jsonContent)
            End Try
        End Function
        Function GetInvHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo ='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format("AND CustCode ='{0}' ", Request.QueryString("Cust").ToString)
                End If
                If Not IsNothing(Request.QueryString("Cancel")) Then
                    tSqlw &= String.Format("AND ISNULL(CancelProve,''){0}", If(Request.QueryString("Cancel").ToString.ToUpper = "Y", "<>''", "=''"))
                End If
                Dim oData = New CInvHeader(jobWebConn).GetData(tSqlw & " ORDER BY DocDate DESC")
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""invheader"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetInvHeader", "ERROR", ex.Message)
                Return Content("{""invheader"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function SetInvHeader(<FromBody()> data As CInvHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    If "" & data.DocNo = "" Then
                        If data.DocType = "" Then
                            data.DocType = invPrefix
                        End If
                        If data.DocDate = DateTime.MinValue Then
                            data.DocDate = Today
                        End If
                        data.AddNew(data.DocType & data.DocDate.ToString("yyMM") & "____")
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND DocNo='{1}' ", data.BranchCode, data.DocNo))
                    Dim json = "{""result"":{""data"":""" & data.DocNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetInvHeader", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelInvHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                    Branch = Request.QueryString("Branch").ToString
                Else
                    Return Content("{""invheader"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                Dim DocNo As String = ""
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo Like '{0}' ", Request.QueryString("Code").ToString)
                    DocNo = Request.QueryString("Code").ToString
                Else
                    Return Content("{""invheader"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If

                Dim oData As New CInvHeader(jobWebConn) With {
                    .BranchCode = Branch,
                    .DocNo = DocNo
                }
                Dim msg = oData.DeleteData(tSqlw)

                Dim oDet As New CInvDetail(jobWebConn)
                oDet.DeleteData(tSqlw)

                Dim json = "{""invheader"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelInvHeader", "ERROR", ex.Message)
                Return Content("{""invheader"":{""result"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetBillHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE BillAcceptNo<>'' "
                If Not IsNothing(Request.QueryString("Show")) Then
                    If Request.QueryString("Show").ToString() = "ACTIVE" Then
                        tSqlw &= String.Format(" AND NOT ISNULL(CancelProve,'')<>'' ")
                    End If
                    If Request.QueryString("Show").ToString() = "CANCEL" Then
                        tSqlw &= String.Format(" AND ISNULL(CancelProve,'')<>'' ")
                    End If
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BillAcceptNo ='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format("AND CustCode ='{0}' ", Request.QueryString("Cust").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND BillDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND BillDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                Dim oData = New CBillHeader(jobWebConn).GetData(tSqlw & " ORDER BY BillDate DESC")
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""billheader"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetBillHeader", "ERROR", ex.Message)
                Return Content("{""billheader"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function SetBillHeader(<FromBody()> data As CBillHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    If "" & data.BillAcceptNo = "" Then
                        If data.BillDate = DateTime.MinValue Then
                            data.BillDate = Today.Date
                        End If
                        data.AddNew(billPrefix & data.BillDate.ToString("yyMM") & "____")
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND BillAcceptNo='{1}' ", data.BranchCode, data.BillAcceptNo))
                    Dim json = "{""result"":{""data"":""" & data.BillAcceptNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetBillHeader", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelBillHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE BillAcceptNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""billheader"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BillAcceptNo Like '{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""billheader"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim Branch As String = Request.QueryString("Branch").ToString
                Dim Code As String = Request.QueryString("Code").ToString

                Dim oData As New CBillHeader(jobWebConn) With {
                    .BranchCode = Branch,
                    .BillAcceptNo = Code
                }
                Dim msg = oData.DeleteData(tSqlw)

                Dim oDet As New CBillDetail(jobWebConn)
                oDet.DeleteData(tSqlw)

                Dim json = "{""billheader"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelBillHeader", "ERROR", ex.Message)
                Return Content("{""billheader"":{""result"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetReceiveReport() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ISNULL(rh.CancelProve,'')='' "

                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND rh.BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND rh.ReceiptNo ='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND rh.ReceiptDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND rh.ReceiptDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format(" AND rh.CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                If Not IsNothing(Request.QueryString("InvDateFrom")) Then
                    tSqlw &= " AND ih.DocDate>='" & Request.QueryString("InvDateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("InvDateTo")) Then
                    tSqlw &= " AND ih.DocDate<='" & Request.QueryString("InvDateTo") & " 23:59:00'"
                End If
                If Not IsNothing(Request.QueryString("BillTo")) Then
                    tSqlw &= String.Format(" AND rh.BillToCustCode='{0}' ", Request.QueryString("BillTo").ToString)
                End If
                Dim isSummary As Boolean = False
                If Not IsNothing(Request.QueryString("Type")) Then
                    If Request.QueryString("Type").ToString = "SUM" Then
                        isSummary = True
                    End If
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectReceiptReport() & tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""receipt"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetReceiptReport", "ERROR", ex.Message)
                Return Content("{""receipt"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetReceipt() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ReceiptNo<>'' "
                Dim docNo As String = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ReceiptNo='{0}' ", Request.QueryString("Code").ToString)
                    docNo = Request.QueryString("Code").ToString
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format("AND CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND ReceiptDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND ReceiptDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                If Not IsNothing(Request.QueryString("Type")) Then
                    Select Case Request.QueryString("Type").ToString()
                        Case "RCV"
                            tSqlw &= " AND ReceiptNo like 'RC%' "
                        Case "TAX"
                            tSqlw &= " AND ReceiptNo like 'TX%' "
                        Case "SRV"
                            tSqlw &= " AND ReceiptNo like 'SV%' "
                        Case "REC"
                            tSqlw &= " AND ReceiptNo like 'RV%' "
                        Case "ADV"
                            tSqlw &= " AND ReceiptNo like 'AV%' "
                        Case Else
                            Return Content("{""result"":{""data"":null,""msg"":""Please Enter Receipt Type""}}", jsonContent)
                    End Select
                End If
                If Not IsNothing(Request.QueryString("Show")) Then
                    If Request.QueryString("Show").ToString() = "ACTIVE" Then
                        tSqlw &= String.Format(" AND NOT ISNULL(CancelProve,'')<>'' ")
                    End If
                    If Request.QueryString("Show").ToString() = "CANCEL" Then
                        tSqlw &= String.Format(" AND ISNULL(CancelProve,'')<>'' ")
                    End If
                End If

                Dim oHead = New CRcpHeader(jobWebConn).GetData(tSqlw & " ORDER BY ReceiptDate DESC")
                Dim oDet = New CRcpDetail(jobWebConn).GetData(tSqlw)

                Dim jsonH As String = ""
                Dim jsonD As String = ""
                Dim jsonC As String = ""

                If oHead.Count > 0 Then
                    jsonH = JsonConvert.SerializeObject(oHead)
                    If oDet.Count > 0 Then
                        jsonD = JsonConvert.SerializeObject(oDet)
                    End If

                    Dim oCust = New CCompany(jobWebConn).GetData(String.Format(" WHERE CustCode='{0}' AND Branch='{1}'", oHead(0).CustCode, oHead(0).CustBranch))
                    If oCust.Count > 0 Then
                        jsonC = JsonConvert.SerializeObject(oCust)
                    End If
                End If

                Return Content("{""receipt"":{""msg"":""" & docNo & """,""header"":[" & jsonH & "],""detail"":[" & jsonD & "],""customer"":[" & jsonC & "]}}", jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetReceipt", "ERROR", ex.Message)
                Return Content("{""receipt"":{""msg"":""" & ex.Message & """,""header"":[],""detail"":[],""customer"":[]}}", jsonContent)
            End Try
        End Function
        Function GetRcpHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ReceiptNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If

                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ReceiptNo ='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CRcpHeader(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""rcpheader"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetRcpHeader", "ERROR", ex.Message)
                Return Content("{""rcpheader"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function SetRcpHeader(<FromBody()> data As CRcpHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    If "" & data.ReceiptNo = "" Then
                        If data.ReceiptDate = DateTime.MinValue Then
                            data.ReceiptDate = Today.Date
                        End If
                        Select Case data.ReceiptType
                            Case "REC"
                                data.AddNew("RC-" & data.ReceiptDate.ToString("yyMM") & "___")
                            Case "TAX"
                                data.AddNew("TX-" & data.ReceiptDate.ToString("yyMM") & "___")
                            Case "SRV"
                                data.AddNew("SV-" & data.ReceiptDate.ToString("yyMM") & "___")
                            Case "RCV"
                                data.AddNew("RV-" & data.ReceiptDate.ToString("yyMM") & "___")
                            Case "ADV"
                                data.AddNew("AV-" & data.ReceiptDate.ToString("yyMM") & "___")
                            Case Else
                                Return Content("{""result"":{""data"":null,""msg"":""Please Enter Receipt Type""}}", jsonContent)
                        End Select
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND ReceiptNo='{1}' ", data.BranchCode, data.ReceiptNo))
                    Dim json = "{""result"":{""data"":""" & data.ReceiptNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetRcpHeader", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelRcpHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ReceiptNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""rcpheader"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ReceiptNo Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""rcpheader"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If

                Dim oData As New CRcpHeader(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim oDetail As New CRcpDetail(jobWebConn) With {
                    .BranchCode = Request.QueryString("Branch").ToString,
                    .ReceiptNo = Request.QueryString("Code").ToString
                }
                oDetail.DeleteData(tSqlw)

                Dim json = "{""rcpheader"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelRcpHeader", "ERROR", ex.Message)
                Return Content("{""rcpheader"":{""result"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetCheque() As ActionResult
            Try
                Dim tSqlw = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND b.BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND b.ChqNo ='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim chqType = "CU"
                If Not IsNothing(Request.QueryString("Type")) Then
                    chqType = Request.QueryString("Type").ToString
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format(" AND b.CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                If Not IsNothing(Request.QueryString("Cancel")) Then
                    If Request.QueryString("Cancel").ToString() = "Y" Then
                        tSqlw &= " AND ISNULL(b.CancelProve,'')<>'' "
                    Else
                        tSqlw &= " AND ISNULL(b.CancelProve,'')='' "
                    End If
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectChequeBalance(chqType) & tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""cheque"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetCheque", "ERROR", ex.Message)
                Return Content("{""cheque"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetDocBalance() As ActionResult
            Try
                Dim tSqlw = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND b.BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND b.DocNo ='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim prType = "R"
                If Not IsNothing(Request.QueryString("Type")) Then
                    prType = Request.QueryString("Type").ToString
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format(" AND b.CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                If Not IsNothing(Request.QueryString("Cancel")) Then
                    If Request.QueryString("Cancel").ToString() = "Y" Then
                        tSqlw &= " AND ISNULL(b.CancelProve,'')<>'' "
                    Else
                        tSqlw &= " AND ISNULL(b.CancelProve,'')='' "
                    End If
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectDocumentBalance(prType) & tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""document"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetDocBalance", "ERROR", ex.Message)
                Return Content("{""document"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetClearForInv() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ISNULL(b.LinkBillNo,'')='' AND a.DocStatus NOT IN('99','1') AND b.UsedAmount>0 "

                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND b.BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Job")) Then
                    tSqlw &= String.Format(" AND b.JobNo ='{0}' ", Request.QueryString("Job").ToString)
                End If
                If Not IsNothing(Request.QueryString("JType")) Then
                    tSqlw &= String.Format(" AND c.JobType ={0} ", Request.QueryString("JType").ToString)
                End If
                If Not IsNothing(Request.QueryString("SBy")) Then
                    tSqlw &= String.Format(" AND c.ShipBy ={0} ", Request.QueryString("SBy").ToString)
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format(" AND c.CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectClrForInvoice() & tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""invdetail"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetClearForInv", "ERROR", ex.Message)
                Return Content("{""invdetail"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetInvDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo ='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CInvDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""invdetail"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetInvDetail", "ERROR", ex.Message)
                Return Content("{""invdetail"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function SaveInvDetail(<FromBody()> data As List(Of CInvDetail)) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data(0).BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data(0).DocNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    Dim i As Integer = 0
                    Dim msg As String = ""
                    For Each dt In data
                        'Invoice's Service+Advance
                        If dt.ItemNo > 0 Then
                            dt.SetConnect(jobWebConn)
                            Dim result = dt.SaveData(String.Format(" WHERE BranchCode='{0}' AND DocNo='{1}' AND ItemNo={2}", dt.BranchCode, dt.DocNo, dt.ItemNo))
                            If result.Substring(0, 1) = "S" Then
                                i += 1
                                msg &= i & " row(s) saved!\n"
                            Else
                                msg &= i & " Error: " & result & "\n"
                            End If
                        Else
                            'Invoice's Cost
                            Dim Sql = String.Format("UPDATE Job_ClearDetail SET LinkBillNo='{0}',LinkItem={1} ", dt.DocNo, dt.ItemNo)
                            Sql &= String.Format(" WHERE ClrNo+'/'+Convert(varchar,ItemNo) IN('{0}')", dt.ClrNoList.Replace(",", "','"))
                            msg &= "Update " & dt.ClrNoList & "=" & Main.DBExecute(jobWebConn, Sql) & "\n"
                        End If
                    Next
                    Dim json = "{""result"":{""data"":""" & data(0).DocNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SaveInvDetail", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function

        Function SetInvDetail(<FromBody()> data As CInvDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data.DocNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND DocNo='{1}' AND ItemNo='{2}'", data.BranchCode, data.DocNo, data.ItemNo))
                    Dim json = "{""result"":{""data"":""" & data.DocNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetInvDetail", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelInvDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                    Branch = Request.QueryString("Branch").ToString
                Else
                    Return Content("{""invdetail"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                Dim DocNo As String = ""
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo Like '{0}' ", Request.QueryString("Code").ToString)
                    DocNo = Request.QueryString("Code").ToString
                Else
                    Return Content("{""invdetail"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format("AND ItemNo ='{0}' ", Request.QueryString("Item").ToString)
                End If
                Dim oData As New CInvDetail(jobWebConn)
                Dim oRec = oData.GetData(tSqlw)
                If oRec.Count > 0 Then
                    Dim msg = ""
                    For Each doc In oRec
                        msg &= doc.DeleteData(tSqlw) & vbCrLf
                    Next
                    Dim json = "{""invdetail"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oRec(0)) & "]}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""invdetail"":{""result"":""Data Not Found"",""data"":[]}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelInvDetail", "ERROR", ex.Message)
                Return Content("{""invdetail"":{""result"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetInvReport() As ActionResult
            Try
                Dim defaultWhere As String = "(id.TotalAmt-ISNULL(id.AmtCredit,0)-ISNULL(r.ReceivedNet,0)-ISNULL(c.CreditNet,0))"
                Dim tSqlw As String = " AND " & defaultWhere & " >0 "
                If Not IsNothing(Request.QueryString("Show")) Then
                    If Request.QueryString("Show").ToString.ToUpper = "NOPAY" Then
                        tSqlw &= " AND ISNULL(r.ReceivedNet,0)=0 "
                    End If
                    If Request.QueryString("Show").ToString.ToUpper = "RECEIVED" Then
                        tSqlw = " AND ISNULL(r.ReceivedNet,0)>0 "
                    End If
                    If Request.QueryString("Show").ToString.ToUpper = "CLEARED" Then
                        tSqlw = " AND " & defaultWhere & "<=0 "
                    End If
                    If Request.QueryString("Show").ToString.ToUpper = "ALL" Then
                        tSqlw = ""
                    End If
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND ih.BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND ih.DocDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND ih.DocDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format(" AND ih.CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                If Not IsNothing(Request.QueryString("BillDateFrom")) Then
                    tSqlw &= " AND ih.BillIssueDate>='" & Request.QueryString("BillDateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("BillDateTo")) Then
                    tSqlw &= " AND ih.BillIssueDate<='" & Request.QueryString("BillDateTo") & " 23:59:00'"
                End If
                If Not IsNothing(Request.QueryString("BillTo")) Then
                    tSqlw &= String.Format(" AND ih.BillToCustCode='{0}' ", Request.QueryString("BillTo").ToString)
                End If
                Dim isSummary As Boolean = False
                If Not IsNothing(Request.QueryString("Type")) Then
                    If Request.QueryString("Type").ToString.ToUpper = "SUM" Then
                        isSummary = True
                    End If
                End If
                Dim oData = If(isSummary, New CUtil(jobWebConn).GetTableFromSQL(SQLSelectInvSummary(tSqlw)), New CUtil(jobWebConn).GetTableFromSQL(SQLSelectInvReport(tSqlw)))
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""inv"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetInvReport", "ERROR", ex.Message)
                Return Content("{""inv"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetInvForReceive() As ActionResult
            Dim defaultWhere As String = "(id.TotalAmt-ISNULL(id.AmtCredit,0)-ISNULL(c.CreditNet,0)-ISNULL(r.ReceivedNet,0))"
            Dim tSqlw As String = " AND " & defaultWhere & ">0 "
            Try
                Dim bCheckVoucher As Boolean = False
                Dim byReceipt As Boolean = False
                If Not IsNothing(Request.QueryString("Show")) Then
                    If Request.QueryString("Show").ToString.ToUpper = "WAIT" Then
                        'don't have receipt document yet
                        tSqlw &= " AND ISNULL(r.ReceivedNet,0)=0 "
                    End If
                    If Request.QueryString("Show").ToString.ToUpper = "RECV" Then
                        'have receipt document
                        tSqlw = " AND ISNULL(r.ReceivedNet,0)>0 "
                    End If
                    If Request.QueryString("Show").ToString.ToUpper = "OPEN" Then
                        'by receipt document
                        bCheckVoucher = True
                        byReceipt = True
                        tSqlw = ""
                    End If
                    If Request.QueryString("Show").ToString.ToUpper = "FULLPAY" Then
                        tSqlw = " AND " & defaultWhere & "<=0 "
                    End If
                    If Request.QueryString("Show").ToString.ToUpper = "PARTPAY" Then
                        tSqlw = " AND " & defaultWhere & ">0 "
                    End If
                    If Request.QueryString("Show").ToString.ToUpper = "WAITPAY" Then
                        bCheckVoucher = True
                        tSqlw = " AND ISNULL(r.LastReceiptNo,'')<>'' AND ISNULL(r.LastControlNo,'')='' "
                        tSqlw &= " AND " & defaultWhere & ">=0 "
                    End If
                    If Request.QueryString("Show").ToString.ToUpper = "ALL" Then
                        tSqlw = ""
                    Else
                        If Request.QueryString("Show").ToString.ToUpper = "CANCEL" Then
                            tSqlw = " AND NOT ISNULL(ih.CancelProve,'')='' " & tSqlw
                        Else
                            tSqlw = " AND ISNULL(ih.CancelProve,'')='' " & tSqlw
                        End If
                    End If
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND ih.BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If byReceipt = True Then
                    If Not IsNothing(Request.QueryString("DateFrom")) Then
                        tSqlw &= " AND r.ReceiptDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                    End If
                    If Not IsNothing(Request.QueryString("DateTo")) Then
                        tSqlw &= " AND r.ReceiptDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                    End If
                    If Not IsNothing(Request.QueryString("DueDateFrom")) Then
                        tSqlw &= " AND bh.DuePaymentDate>='" & Request.QueryString("DueDateFrom") & " 00:00:00'"
                    End If
                    If Not IsNothing(Request.QueryString("DueDateTo")) Then
                        tSqlw &= " AND bh.DuePaymentDate<='" & Request.QueryString("DueDateTo") & " 23:59:00'"
                    End If
                Else
                    If Not IsNothing(Request.QueryString("DateFrom")) Then
                        tSqlw &= " AND ih.DocDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                    End If
                    If Not IsNothing(Request.QueryString("DateTo")) Then
                        tSqlw &= " AND ih.DocDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                    End If
                End If
                If Not IsNothing(Request.QueryString("BillDateFrom")) Then
                    tSqlw &= " AND ih.BillIssueDate>='" & Request.QueryString("BillDateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("BillDateTo")) Then
                    tSqlw &= " AND ih.BillIssueDate<='" & Request.QueryString("BillDateTo") & " 23:59:00'"
                End If
                If Not IsNothing(Request.QueryString("BillTo")) Then
                    tSqlw &= String.Format(" AND ih.BillToCustCode='{0}' ", Request.QueryString("BillTo").ToString)
                End If

                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format(" AND ih.CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                Dim recvNo As String = ""
                If Not IsNothing(Request.QueryString("RecvNo")) Then
                    recvNo = Request.QueryString("RecvNo").ToString
                End If
                If Not IsNothing(Request.QueryString("Type")) Then
                    If Request.QueryString("Type").ToString.ToUpper = "ADV" Then
                        tSqlw &= " AND ISNULL(id.AmtAdvance,0)>0 "
                    End If
                    If Request.QueryString("Type").ToString.ToUpper = "SRV" Then
                        tSqlw &= " AND ISNULL(id.AmtCharge,0)>0 "
                    End If
                    If Request.QueryString("Type").ToString.ToUpper = "TAX" Then
                        'have advance or have service
                        tSqlw &= " AND ((ISNULL(id.AmtCharge,0)>0 AND ISNULL(id.AmtVat,0)>0) OR ISNULL(id.AmtAdvance,0)>0) "
                    End If
                    If Request.QueryString("Type").ToString.ToUpper = "REC" Then
                        'have service but no vat
                        tSqlw &= " AND ISNULL(id.AmtCharge,0)>0 AND ISNULL(id.AmtVat,0)=0 "
                    End If
                    If Request.QueryString("Type").ToString.ToUpper = "RCP" Then
                        'have service non vat or advance
                        tSqlw &= " AND ((ISNULL(id.AmtCharge,0)>0 AND ISNULL(id.AmtVat,0)=0) OR ISNULL(id.AmtAdvance,0)>0)) "
                    End If
                End If
                tSqlw &= " ORDER BY ih.DocNo DESC"
                Dim sql As String = If(Not byReceipt, SQLSelectInvForReceive(bCheckVoucher) & tSqlw, SQLSelectInvByReceive(recvNo, bCheckVoucher) & tSqlw)
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(sql)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""invdetail"":{""data"":" & json & ",""condition"":""" & tSqlw & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetInvForReceive", "ERROR", ex.Message)
                Return Content("{""invdetail"":{""msg"":""" & ex.Message & """,""data"":[],""condition"":""" & tSqlw & """}}", jsonContent)
            End Try
        End Function
        Function GetInvForBill() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ISNULL(a.CustCode,'')<>'' "
                If Not IsNothing(Request.QueryString("Show")) Then
                    If Request.QueryString("Show").ToString = "BILLED" Then
                        tSqlw &= " AND ISNULL(a.BillAcceptNo,'')<>'' "
                    End If
                    If Request.QueryString("Show").ToString = "ACTIVE" Then
                        tSqlw &= " AND NOT ISNULL(a.CancelProve,'')<>'' "
                    End If
                    If Request.QueryString("Show").ToString = "CANCEL" Then
                        tSqlw &= " AND ISNULL(a.CancelProve,'')<>'' "
                    End If
                Else
                    tSqlw &= " AND ISNULL(a.BillAcceptNo,'')='' "
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND a.BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND a.DocDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND a.DocDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format(" AND a.CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectInvForBilling() & tSqlw & " ORDER BY a.DocDate DESC ")
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""invdetail"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetInvForBill", "ERROR", ex.Message)
                Return Content("{""invdetail"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetBilling() As ActionResult
            Try
                Dim tSqlw As String = " WHERE BillAcceptNo<>'' "
                Dim docNo As String = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BillAcceptNo='{0}' ", Request.QueryString("Code").ToString)
                    docNo = Request.QueryString("Code").ToString
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format("AND CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If

                Dim oHead = New CBillHeader(jobWebConn).GetData(tSqlw)
                Dim oDet = New CBillDetail(jobWebConn).GetData(tSqlw)

                Dim jsonH As String = ""
                Dim jsonD As String = ""
                Dim jsonC As String = ""

                If oHead.Count > 0 Then
                    jsonH = JsonConvert.SerializeObject(oHead)
                    If oDet.Count > 0 Then
                        jsonD = JsonConvert.SerializeObject(oDet)
                    End If

                    Dim oCust = New CCompany(jobWebConn).GetData(String.Format(" WHERE CustCode='{0}' AND Branch='{1}'", oHead(0).CustCode, oHead(0).CustBranch))
                    If oCust.Count > 0 Then
                        jsonC = JsonConvert.SerializeObject(oCust)
                    End If
                End If

                Return Content("{""billing"":{""msg"":""" & docNo & """,""header"":[" & jsonH & "],""detail"":[" & jsonD & "],""customer"":[" & jsonC & "]}}", jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetBilling", "ERROR", ex.Message)
                Return Content("{""billing"":{""msg"":""" & ex.Message & """,""header"":[],""detail"":[],""customer"":[]}}", jsonContent)
            End Try
        End Function
        Function GetBillDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE BillAcceptNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BillAcceptNo ='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CBillDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""billdetail"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetBillDetail", "ERROR", ex.Message)
                Return Content("{""billdetail"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function SetBillDetail(<FromBody()> data As List(Of CBillDetail)) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data(0).BillAcceptNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    Else
                        Dim o = New CBillDetail(jobWebConn) With {
                            .BranchCode = data(0).BranchCode,
                            .BillAcceptNo = data(0).BillAcceptNo
                        }
                        o.DeleteData(String.Format(" WHERE BranchCode='{0}' And BillAcceptNo='{1}'", data(0).BranchCode, data(0).BillAcceptNo))
                    End If
                    Dim msg = ""
                    For Each dt In data
                        dt.SetConnect(jobWebConn)
                        msg &= "\n" & dt.SaveData(String.Format(" WHERE BranchCode='{0}' AND BillAcceptNo='{1}' AND ItemNo='{2}' ", dt.BranchCode, dt.BillAcceptNo, dt.ItemNo))
                    Next
                    Dim json = "{""result"":{""data"":""" & data(0).BillAcceptNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetBillDetail", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelBillDetail() As ActionResult
            Try
                Dim Branch As String = ""
                Dim tSqlw As String = " WHERE BillAcceptNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                    Branch = Request.QueryString("Branch").ToString
                Else
                    Return Content("{""billdetail"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                Dim Code As String = ""
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND BillAcceptNo ='{0}' ", Request.QueryString("Code").ToString)
                    Code = Request.QueryString("Code").ToString
                Else
                    Return Content("{""billdetail"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim Item As String = ""
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format("AND ItemNo ='{0}' ", Request.QueryString("Item").ToString)
                    Item = Request.QueryString("Item").ToString
                End If
                Dim oData As New CBillDetail(jobWebConn)
                Dim oRec = oData.GetData(tSqlw)
                If oRec.Count > 0 Then
                    Dim msg = oRec(0).DeleteData(tSqlw)
                    Dim json = "{""billdetail"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oRec(0)) & "]}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""billdetail"":{""result"":""Data Not Found"",""data"":[]}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelRcpDetail", "ERROR", ex.Message)
                Return Content("{""billdetail"":{""result"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function GetRcpDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ReceiptNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ReceiptNo ='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CRcpDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""rcpdetail"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "GetRcpDetail", "ERROR", ex.Message)
                Return Content("{""rcpdetail"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
        Function SaveRcpDetail(<FromBody()> data As List(Of CRcpDetail)) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data(0).BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data(0).ReceiptNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    Dim i As Integer = 0
                    Dim msg As String = ""
                    For Each dt In data
                        'Invoice's Service+Advance
                        dt.SetConnect(jobWebConn)
                        Dim result = dt.SaveData(String.Format(" WHERE BranchCode='{0}' AND ReceiptNo='{1}' AND ItemNo={2}", dt.BranchCode, dt.ReceiptNo, dt.ItemNo))
                        If result.Substring(0, 1) = "S" Then
                            i += 1
                            msg &= i & " row(s) saved!\n"
                        Else
                            msg &= i & " Error: " & result & "\n"
                        End If
                    Next
                    Dim json = "{""result"":{""data"":""" & data(0).ReceiptNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SaveRcpDetail", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function

        Function SetRcpDetail(<FromBody()> data As CRcpDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data.ReceiptNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND ReceiptNo='{1}' AND ItemNo='{2}' ", data.BranchCode, data.ReceiptNo, data.ItemNo))
                    Dim json = "{""result"":{""data"":""" & data.ReceiptNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "SetRcpDetail", "ERROR", ex.Message)
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelRcpDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ReceiptNo<>'' "
                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                    Branch = Request.QueryString("Branch").ToString
                Else
                    Return Content("{""rcpdetail"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                Dim DocNo As String = ""
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ReceiptNo Like '{0}' ", Request.QueryString("Code").ToString)
                    DocNo = Request.QueryString("Code").ToString
                Else
                    Return Content("{""rcpdetail"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format("AND ItemNo='{0}' ", Request.QueryString("Item").ToString)
                End If

                Dim oData As New CRcpDetail(jobWebConn) With {
                    .BranchCode = Branch,
                    .ReceiptNo = DocNo
                }
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""rcpdetail"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Main.SaveLog(GetSession("CurrLicense").ToString(), "JOBSHIPPING", "DelRcpDetail", "ERROR", ex.Message)
                Return Content("{""rcpdetail"":{""result"":""" & ex.Message & """,""data"":[]}}", jsonContent)
            End Try
        End Function
    End Class
End Namespace