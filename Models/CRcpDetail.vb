'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CRcpDetail
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_BranchCode As String
    Public Property BranchCode As String
        Get
            Return m_BranchCode
        End Get
        Set(value As String)
            m_BranchCode = value
        End Set
    End Property
    Private m_ReceiptNo As String
    Public Property ReceiptNo As String
        Get
            Return m_ReceiptNo
        End Get
        Set(value As String)
            m_ReceiptNo = value
        End Set
    End Property
    Private m_ItemNo As Integer
    Public Property ItemNo As Integer
        Get
            Return m_ItemNo
        End Get
        Set(value As Integer)
            m_ItemNo = value
        End Set
    End Property
    Private m_CreditAmount As Double
    Public Property CreditAmount As Double
        Get
            Return m_CreditAmount
        End Get
        Set(value As Double)
            m_CreditAmount = value
        End Set
    End Property
    Private m_CashAmount As Double
    Public Property CashAmount As Double
        Get
            Return m_CashAmount
        End Get
        Set(value As Double)
            m_CashAmount = value
        End Set
    End Property
    Private m_TransferAmount As Double
    Public Property TransferAmount As Double
        Get
            Return m_TransferAmount
        End Get
        Set(value As Double)
            m_TransferAmount = value
        End Set
    End Property
    Private m_ChequeAmount As Double
    Public Property ChequeAmount As Double
        Get
            Return m_ChequeAmount
        End Get
        Set(value As Double)
            m_ChequeAmount = value
        End Set
    End Property
    Private m_ControlNo As String
    Public Property ControlNo As String
        Get
            Return m_ControlNo
        End Get
        Set(value As String)
            m_ControlNo = value
        End Set
    End Property
    Private m_VoucherNo As String
    Public Property VoucherNo As String
        Get
            Return m_VoucherNo
        End Get
        Set(value As String)
            m_VoucherNo = value
        End Set
    End Property
    Private m_ControlItemNo As Integer
    Public Property ControlItemNo As Integer
        Get
            Return m_ControlItemNo
        End Get
        Set(value As Integer)
            m_ControlItemNo = value
        End Set
    End Property
    Private m_InvoiceNo As String
    Public Property InvoiceNo As String
        Get
            Return m_InvoiceNo
        End Get
        Set(value As String)
            m_InvoiceNo = value
        End Set
    End Property
    Private m_InvoiceItemNo As Integer
    Public Property InvoiceItemNo As Integer
        Get
            Return m_InvoiceItemNo
        End Get
        Set(value As Integer)
            m_InvoiceItemNo = value
        End Set
    End Property
    Private m_SICode As String
    Public Property SICode As String
        Get
            Return m_SICode
        End Get
        Set(value As String)
            m_SICode = value
        End Set
    End Property
    Private m_SDescription As String
    Public Property SDescription As String
        Get
            Return m_SDescription
        End Get
        Set(value As String)
            m_SDescription = value
        End Set
    End Property
    Private m_VATRate As Double
    Public Property VATRate As Double
        Get
            Return m_VATRate
        End Get
        Set(value As Double)
            m_VATRate = value
        End Set
    End Property
    Private m_Rate50Tavi As Double
    Public Property Rate50Tavi As Double
        Get
            Return m_Rate50Tavi
        End Get
        Set(value As Double)
            m_Rate50Tavi = value
        End Set
    End Property
    Private m_Amt As Double
    Public Property Amt As Double
        Get
            Return m_Amt
        End Get
        Set(value As Double)
            m_Amt = value
        End Set
    End Property
    Private m_AmtVAT As Double
    Public Property AmtVAT As Double
        Get
            Return m_AmtVAT
        End Get
        Set(value As Double)
            m_AmtVAT = value
        End Set
    End Property
    Private m_Amt50Tavi As Double
    Public Property Amt50Tavi As Double
        Get
            Return m_Amt50Tavi
        End Get
        Set(value As Double)
            m_Amt50Tavi = value
        End Set
    End Property
    Private m_Net As Double
    Public Property Net As Double
        Get
            Return m_Net
        End Get
        Set(value As Double)
            m_Net = value
        End Set
    End Property
    Private m_DCurrencyCode As String
    Public Property DCurrencyCode As String
        Get
            Return m_DCurrencyCode
        End Get
        Set(value As String)
            m_DCurrencyCode = value
        End Set
    End Property
    Private m_DExchangeRate As Double
    Public Property DExchangeRate As Double
        Get
            Return m_DExchangeRate
        End Get
        Set(value As Double)
            m_DExchangeRate = value
        End Set
    End Property
    Private m_FAmt As Double
    Public Property FAmt As Double
        Get
            Return m_FAmt
        End Get
        Set(value As Double)
            m_FAmt = value
        End Set
    End Property
    Private m_FAmtVAT As Double
    Public Property FAmtVAT As Double
        Get
            Return m_FAmtVAT
        End Get
        Set(value As Double)
            m_FAmtVAT = value
        End Set
    End Property
    Private m_FAmt50Tavi As Double
    Public Property FAmt50Tavi As Double
        Get
            Return m_FAmt50Tavi
        End Get
        Set(value As Double)
            m_FAmt50Tavi = value
        End Set
    End Property
    Private m_FNet As Double
    Public Property FNet As Double
        Get
            Return m_FNet
        End Get
        Set(value As Double)
            m_FNet = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_ReceiptDetail" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("ReceiptNo") = Me.ReceiptNo
                            If Me.ItemNo = 0 Then Me.AddNew()
                            dr("ItemNo") = Me.ItemNo
                            dr("CreditAmount") = Me.CreditAmount
                            dr("CashAmount") = Me.CashAmount
                            dr("TransferAmount") = Me.TransferAmount
                            dr("ChequeAmount") = Me.ChequeAmount
                            dr("ControlNo") = Me.ControlNo
                            dr("VoucherNo") = Me.VoucherNo
                            dr("ControlItemNo") = Me.ControlItemNo
                            dr("InvoiceNo") = Me.InvoiceNo
                            dr("InvoiceItemNo") = Me.InvoiceItemNo
                            dr("SICode") = Me.SICode
                            dr("SDescription") = Me.SDescription
                            dr("VATRate") = Me.VATRate
                            dr("Rate50Tavi") = Me.Rate50Tavi
                            dr("Amt") = Me.Amt
                            dr("AmtVAT") = Me.AmtVAT
                            dr("Amt50Tavi") = Me.Amt50Tavi
                            dr("Net") = Me.Net
                            dr("DCurrencyCode") = Me.DCurrencyCode
                            dr("DExchangeRate") = Me.DExchangeRate
                            dr("FAmt") = Me.FAmt
                            dr("FAmtVAT") = Me.FAmtVAT
                            dr("FAmt50Tavi") = Me.FAmt50Tavi
                            dr("FNet") = Me.FNet
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            UpdateTotal(cn)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CRcpDetail", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CRcpDetail", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()
        Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(ItemNo) as t FROM Job_ReceiptDetail WHERE BranchCode='{0}' And ReceiptNo ='{1}' ", m_BranchCode, m_ReceiptNo), "____")
        m_ItemNo = Convert.ToInt32("0" & retStr)
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CRcpDetail)
        Dim lst As New List(Of CRcpDetail)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CRcpDetail
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_ReceiptDetail" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CRcpDetail(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReceiptNo"))) = False Then
                        row.ReceiptNo = rd.GetString(rd.GetOrdinal("ReceiptNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ItemNo"))) = False Then
                        row.ItemNo = rd.GetInt16(rd.GetOrdinal("ItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CreditAmount"))) = False Then
                        row.CreditAmount = rd.GetDouble(rd.GetOrdinal("CreditAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CashAmount"))) = False Then
                        row.CashAmount = rd.GetDouble(rd.GetOrdinal("CashAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TransferAmount"))) = False Then
                        row.TransferAmount = rd.GetDouble(rd.GetOrdinal("TransferAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ChequeAmount"))) = False Then
                        row.ChequeAmount = rd.GetDouble(rd.GetOrdinal("ChequeAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ControlNo"))) = False Then
                        row.ControlNo = rd.GetString(rd.GetOrdinal("ControlNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VoucherNo"))) = False Then
                        row.VoucherNo = rd.GetString(rd.GetOrdinal("VoucherNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ControlItemNo"))) = False Then
                        row.ControlItemNo = rd.GetInt32(rd.GetOrdinal("ControlItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvoiceNo"))) = False Then
                        row.InvoiceNo = rd.GetString(rd.GetOrdinal("InvoiceNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvoiceItemNo"))) = False Then
                        row.InvoiceItemNo = rd.GetInt32(rd.GetOrdinal("InvoiceItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SICode"))) = False Then
                        row.SICode = rd.GetString(rd.GetOrdinal("SICode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SDescription"))) = False Then
                        row.SDescription = rd.GetString(rd.GetOrdinal("SDescription")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VATRate"))) = False Then
                        row.VATRate = rd.GetDouble(rd.GetOrdinal("VATRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Rate50Tavi"))) = False Then
                        row.Rate50Tavi = rd.GetDouble(rd.GetOrdinal("Rate50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Amt"))) = False Then
                        row.Amt = rd.GetValue(rd.GetOrdinal("Amt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AmtVAT"))) = False Then
                        row.AmtVAT = rd.GetDouble(rd.GetOrdinal("AmtVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Amt50Tavi"))) = False Then
                        row.Amt50Tavi = rd.GetDouble(rd.GetOrdinal("Amt50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Net"))) = False Then
                        row.Net = rd.GetValue(rd.GetOrdinal("Net"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DCurrencyCode"))) = False Then
                        row.DCurrencyCode = rd.GetString(rd.GetOrdinal("DCurrencyCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DExchangeRate"))) = False Then
                        row.DExchangeRate = rd.GetDouble(rd.GetOrdinal("DExchangeRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FAmt"))) = False Then
                        row.FAmt = rd.GetDouble(rd.GetOrdinal("FAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FAmtVAT"))) = False Then
                        row.FAmtVAT = rd.GetDouble(rd.GetOrdinal("FAmtVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FAmt50Tavi"))) = False Then
                        row.FAmt50Tavi = rd.GetDouble(rd.GetOrdinal("FAmt50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FNet"))) = False Then
                        row.FNet = rd.GetDouble(rd.GetOrdinal("FNet"))
                    End If
                    lst.Add(row)
                End While
            Catch ex As Exception
            End Try
        End Using
        Return lst
    End Function
    Public Function DeleteData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using cm As New SqlCommand("DELETE FROM Job_ReceiptDetail" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CRcpDetail", "DeleteData", cm.CommandText)
                End Using
                UpdateTotal(cn)

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CRcpDetail", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub UpdateTotal(cn As SqlConnection)
        Dim sql As String = "
update h
set h.TotalCharge=ISNULL(d.TotalCharge,0),
h.TotalVAT =ISNULL(d.TotalVAT,0),
h.Total50Tavi =ISNULL(d.Total50Tavi,0),
h.TotalNet=ISNULL(d.TotalNet,0),
h.FTotalNet=ISNULL(d.TotalNet,0)/h.ExchangeRate,
h.ReceiveRef=d.LastControl,
h.ReceiveBy=c.RecUser,
h.ReceiveDate=c.RecDate,
h.ReceiveTime=c.RecTime
from Job_ReceiptHeader h
inner join (
	select BranchCode,ReceiptNo,
	sum(Amt) as TotalCharge,
	sum(AmtVAT) as TotalVAT,
	sum(Amt50Tavi) as Total50Tavi,
	sum(Net) as TotalNet,
    max(ControlNo) as LastControl
	from Job_ReceiptDetail 
	group by BranchCode,ReceiptNo
) d
on h.BranchCode=d.BranchCode
and h.ReceiptNo=d.ReceiptNo
left join Job_CashControl c
ON d.BranchCode=c.BranchCode
AND d.LastControl=c.ControlNo
"
        Using cm As New SqlCommand(sql, cn)
            cm.CommandText = sql + " and h.BranchCode='" + Me.BranchCode + "' and h.ReceiptNo='" + Me.ReceiptNo + "'"
            cm.CommandType = CommandType.Text
            cm.ExecuteNonQuery()
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CRcpDetail", "UpdateRcpHeader", cm.CommandText)
        End Using
    End Sub
End Class
