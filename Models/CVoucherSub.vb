'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CVoucherSub
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
    Private m_ControlNo As String
    Public Property ControlNo As String
        Get
            Return m_ControlNo
        End Get
        Set(value As String)
            m_ControlNo = value
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
    Private m_PRVoucher As String
    Public Property PRVoucher As String
        Get
            Return m_PRVoucher
        End Get
        Set(value As String)
            m_PRVoucher = value
        End Set
    End Property
    Private m_PRType As String
    Public Property PRType As String
        Get
            Return m_PRType
        End Get
        Set(value As String)
            m_PRType = value
        End Set
    End Property
    Private m_ChqNo As String
    Public Property ChqNo As String
        Get
            Return m_ChqNo
        End Get
        Set(value As String)
            m_ChqNo = value
        End Set
    End Property
    Private m_BookCode As String
    Public Property BookCode As String
        Get
            Return m_BookCode
        End Get
        Set(value As String)
            m_BookCode = value
        End Set
    End Property
    Private m_BankCode As String
    Public Property BankCode As String
        Get
            Return m_BankCode
        End Get
        Set(value As String)
            m_BankCode = value
        End Set
    End Property
    Private m_BankBranch As String
    Public Property BankBranch As String
        Get
            Return m_BankBranch
        End Get
        Set(value As String)
            m_BankBranch = value
        End Set
    End Property
    Private m_ChqDate As Date
    Public Property ChqDate As Date
        Get
            Return m_ChqDate
        End Get
        Set(value As Date)
            m_ChqDate = value
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
    Private m_ChqAmount As Double
    Public Property ChqAmount As Double
        Get
            Return m_ChqAmount
        End Get
        Set(value As Double)
            m_ChqAmount = value
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
    Private m_SumAmount As Double
    Public Property SumAmount As Double
        Get
            Return m_SumAmount
        End Get
        Set(value As Double)
            m_SumAmount = value
        End Set
    End Property
    Private m_CurrencyCode As String
    Public Property CurrencyCode As String
        Get
            Return m_CurrencyCode
        End Get
        Set(value As String)
            m_CurrencyCode = value
        End Set
    End Property
    Private m_ExchangeRate As Double
    Public Property ExchangeRate As Double
        Get
            Return m_ExchangeRate
        End Get
        Set(value As Double)
            m_ExchangeRate = value
        End Set
    End Property
    Private m_TotalAmount As Double
    Public Property TotalAmount As Double
        Get
            Return m_TotalAmount
        End Get
        Set(value As Double)
            m_TotalAmount = value
        End Set
    End Property
    Private m_VatInc As Double
    Public Property VatInc As Double
        Get
            Return m_VatInc
        End Get
        Set(value As Double)
            m_VatInc = value
        End Set
    End Property
    Private m_VatExc As Double
    Public Property VatExc As Double
        Get
            Return m_VatExc
        End Get
        Set(value As Double)
            m_VatExc = value
        End Set
    End Property
    Private m_WhtInc As Double
    Public Property WhtInc As Double
        Get
            Return m_WhtInc
        End Get
        Set(value As Double)
            m_WhtInc = value
        End Set
    End Property
    Private m_WhtExc As Double
    Public Property WhtExc As Double
        Get
            Return m_WhtExc
        End Get
        Set(value As Double)
            m_WhtExc = value
        End Set
    End Property
    Private m_TotalNet As Double
    Public Property TotalNet As Double
        Get
            Return m_TotalNet
        End Get
        Set(value As Double)
            m_TotalNet = value
        End Set
    End Property
    Private m_IsLocal As Integer
    Public Property IsLocal As Integer
        Get
            Return m_IsLocal
        End Get
        Set(value As Integer)
            m_IsLocal = value
        End Set
    End Property
    Private m_ChqStatus As String
    Public Property ChqStatus As String
        Get
            Return m_ChqStatus
        End Get
        Set(value As String)
            m_ChqStatus = value
        End Set
    End Property
    Private m_TRemark As String
    Public Property TRemark As String
        Get
            Return m_TRemark
        End Get
        Set(value As String)
            m_TRemark = value
        End Set
    End Property
    Private m_PayChqTo As String
    Public Property PayChqTo As String
        Get
            Return m_PayChqTo
        End Get
        Set(value As String)
            m_PayChqTo = value
        End Set
    End Property
    Private m_DocNo As String
    Public Property DocNo As String
        Get
            Return m_DocNo
        End Get
        Set(value As String)
            m_DocNo = value
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
    Private m_RecvBank As String
    Public Property RecvBank As String
        Get
            Return m_RecvBank
        End Get
        Set(value As String)
            m_RecvBank = value
        End Set
    End Property
    Private m_RecvBranch As String
    Public Property RecvBranch As String
        Get
            Return m_RecvBranch
        End Get
        Set(value As String)
            m_RecvBranch = value
        End Set
    End Property
    Private m_acType As String
    Public Property acType As String
        Get
            Return m_acType
        End Get
        Set(value As String)
            m_acType = value
        End Set
    End Property
    Private m_ForJNo As String
    Public Property ForJNo As String
        Get
            Return m_ForJNo
        End Get
        Set(value As String)
            m_ForJNo = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_CashControlSub" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("ControlNo") = Me.ControlNo
                            If Me.ItemNo = 0 Then
                                Dim retStr = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(ItemNo) as t FROM Job_CashControlSub WHERE BranchCode='{0}' And ControlNo ='{1}' ", m_BranchCode, m_ControlNo), "____")
                                m_ItemNo = Convert.ToInt32("0" & retStr)
                                If m_PRType = "P" Then
                                    Dim bal As Double = 0
                                    If m_CashAmount > 0 Then
                                        bal = Me.GetBalance("CashOnhand") - m_CashAmount
                                    End If
                                    If m_ChqAmount > 0 Then
                                        bal = Me.GetBalance("Cash") - m_ChqAmount
                                    End If
                                    If bal <= 0 Then
                                        msg = "[ERROR] Book " & Me.BookCode & " Is over balance=" & bal
                                    End If
                                End If
                            End If
                            dr("ItemNo") = Me.ItemNo
                            dr("PRVoucher") = Me.PRVoucher
                            dr("PRType") = Me.PRType
                            dr("ChqNo") = Me.ChqNo
                            dr("BookCode") = Me.BookCode
                            dr("BankCode") = Me.BankCode
                            dr("BankBranch") = Me.BankBranch
                            dr("ChqDate") = Main.GetDBDate(Me.ChqDate)
                            dr("CashAmount") = Me.CashAmount
                            dr("ChqAmount") = Me.ChqAmount
                            dr("CreditAmount") = Me.CreditAmount
                            dr("SumAmount") = Me.SumAmount
                            dr("CurrencyCode") = Me.CurrencyCode
                            dr("ExchangeRate") = Me.ExchangeRate
                            dr("TotalAmount") = Me.TotalAmount
                            dr("VatInc") = Me.VatInc
                            dr("WhtInc") = Me.WhtInc
                            dr("VatExc") = Me.VatExc
                            dr("WhtExc") = Me.WhtExc
                            dr("TotalNet") = Me.TotalNet
                            dr("IsLocal") = Me.IsLocal
                            dr("ChqStatus") = Me.ChqStatus
                            dr("TRemark") = Me.TRemark
                            dr("PayChqTo") = Me.PayChqTo
                            dr("DocNo") = Me.DocNo
                            dr("SICode") = Me.SICode
                            dr("RecvBank") = Me.RecvBank
                            dr("RecvBranch") = Me.RecvBranch
                            dr("acType") = Me.acType
                            dr("ForJNo") = Me.ForJNo
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVoucherSub", "SaveData", Me)
                            msg = Me.PRVoucher
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVoucherSub", "SaveData", ex.Message)
                msg = "[ERROR] " & ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew(pFormatSQL As String)
        If pFormatSQL = "" Then
            m_PRVoucher = ""
        Else
            Dim tSql As String = String.Format("SELECT MAX(PRVoucher) as t FROM Job_CashControlSub WHERE BranchCode='{0}' And PRVoucher Like '%{1}' ", m_BranchCode, pFormatSQL)
            Dim retStr = Main.GetMaxByMask(m_ConnStr, tSql, pFormatSQL)
            m_PRVoucher = retStr
        End If
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CVoucherSub)
        Dim lst As New List(Of CVoucherSub)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CVoucherSub
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_CashControlSub" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CVoucherSub(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ControlNo"))) = False Then
                        row.ControlNo = rd.GetString(rd.GetOrdinal("ControlNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ItemNo"))) = False Then
                        row.ItemNo = rd.GetInt32(rd.GetOrdinal("ItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PRVoucher"))) = False Then
                        row.PRVoucher = rd.GetString(rd.GetOrdinal("PRVoucher")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PRType"))) = False Then
                        row.PRType = rd.GetString(rd.GetOrdinal("PRType")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ChqNo"))) = False Then
                        row.ChqNo = rd.GetString(rd.GetOrdinal("ChqNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BookCode"))) = False Then
                        row.BookCode = rd.GetString(rd.GetOrdinal("BookCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BankCode"))) = False Then
                        row.BankCode = rd.GetString(rd.GetOrdinal("BankCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BankBranch"))) = False Then
                        row.BankBranch = rd.GetString(rd.GetOrdinal("BankBranch")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ChqDate"))) = False Then
                        row.ChqDate = rd.GetValue(rd.GetOrdinal("ChqDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CashAmount"))) = False Then
                        row.CashAmount = rd.GetDouble(rd.GetOrdinal("CashAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ChqAmount"))) = False Then
                        row.ChqAmount = rd.GetDouble(rd.GetOrdinal("ChqAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CreditAmount"))) = False Then
                        row.CreditAmount = rd.GetDouble(rd.GetOrdinal("CreditAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SumAmount"))) = False Then
                        row.SumAmount = rd.GetDouble(rd.GetOrdinal("SumAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CurrencyCode"))) = False Then
                        row.CurrencyCode = rd.GetString(rd.GetOrdinal("CurrencyCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ExchangeRate"))) = False Then
                        row.ExchangeRate = rd.GetDouble(rd.GetOrdinal("ExchangeRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalAmount"))) = False Then
                        row.TotalAmount = rd.GetDouble(rd.GetOrdinal("TotalAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VatInc"))) = False Then
                        row.VatInc = rd.GetDouble(rd.GetOrdinal("VatInc"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VatExc"))) = False Then
                        row.VatExc = rd.GetDouble(rd.GetOrdinal("VatExc"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("WhtInc"))) = False Then
                        row.WhtInc = rd.GetDouble(rd.GetOrdinal("WhtInc"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("WhtExc"))) = False Then
                        row.WhtExc = rd.GetDouble(rd.GetOrdinal("WhtExc"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalNet"))) = False Then
                        row.TotalNet = rd.GetDouble(rd.GetOrdinal("TotalNet"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsLocal"))) = False Then
                        row.IsLocal = rd.GetByte(rd.GetOrdinal("IsLocal"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ChqStatus"))) = False Then
                        row.ChqStatus = rd.GetString(rd.GetOrdinal("ChqStatus")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TRemark"))) = False Then
                        row.TRemark = rd.GetString(rd.GetOrdinal("TRemark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PayChqTo"))) = False Then
                        row.PayChqTo = rd.GetString(rd.GetOrdinal("PayChqTo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocNo"))) = False Then
                        row.DocNo = rd.GetString(rd.GetOrdinal("DocNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SICode"))) = False Then
                        row.SICode = rd.GetString(rd.GetOrdinal("SICode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("RecvBank"))) = False Then
                        row.RecvBank = rd.GetString(rd.GetOrdinal("RecvBank")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("RecvBranch"))) = False Then
                        row.RecvBranch = rd.GetString(rd.GetOrdinal("RecvBranch")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("acType"))) = False Then
                        row.acType = rd.GetString(rd.GetOrdinal("acType")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ForJNo"))) = False Then
                        row.ForJNo = rd.GetString(rd.GetOrdinal("ForJNo")).ToString()
                    End If
                    lst.Add(row)
                End While
            Catch ex As Exception
            End Try
        End Using
        Return lst
    End Function
    Public Sub CancelData()
        Dim oDtl As New CVoucherDoc(jobWebConn)
        Dim oRows = oDtl.GetData(String.Format(" WHERE BranchCode='{0}' AND ControlNo='{1}' AND acType='{2}'", Me.BranchCode, Me.ControlNo, Me.acType))
        If oRows.Count > 1 Then
            For Each row In oRows
                row.DeleteData()
            Next
        End If
    End Sub
    Public Function DeleteData(Optional pSQLWhere As String = "") As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()
                If pSQLWhere = "" Then
                    pSQLWhere &= String.Format(" WHERE BranchCode='{0}'", Me.BranchCode)
                    pSQLWhere &= String.Format(" AND ControlNo='{0}'", Me.ControlNo)
                    pSQLWhere &= String.Format(" AND ItemNo='{0}'", Me.ItemNo)
                End If
                Me.CancelData()

                Using cm As New SqlCommand("DELETE FROM Job_CashControlSub" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVoucherSub", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVoucherSub", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Function GetBalance(Optional pField As String = "Bal") As Double
        Dim bal = 0
        Try
            Dim dt = New CUtil(m_ConnStr).GetTableFromSQL(String.Format(SQLSelectBookAccBalance, " AND c.BookCode='" & Me.BookCode & "'"))
            If dt.Rows.Count > 0 Then
                Dim dr = dt.Rows(0)
                bal = Convert.ToDouble(dr("Sum" & pField).ToString()) - Convert.ToDouble(dr("LimitBalance").ToString())
            End If
            Return bal
        Catch ex As Exception
            Return bal
        End Try
    End Function
End Class