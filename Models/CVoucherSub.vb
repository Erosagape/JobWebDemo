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
                            dr("ItemNo") = Me.ItemNo
                            dr("PRVoucher") = Me.PRVoucher
                            dr("PRType") = Me.PRType
                            dr("ChqNo") = Me.ChqNo
                            dr("BookCode") = Me.BookCode
                            dr("BankCode") = Me.BankCode
                            dr("BankBranch") = Me.BankBranch
                            dr("ChqDate") = If(Me.ChqDate.Year < 1900, System.DBNull.Value, Me.ChqDate)
                            dr("CashAmount") = Me.CashAmount
                            dr("ChqAmount") = Me.ChqAmount
                            dr("CreditAmount") = Me.CreditAmount
                            dr("IsLocal") = Me.IsLocal
                            dr("ChqStatus") = Me.ChqStatus
                            dr("TRemark") = Me.TRemark
                            dr("PayChqTo") = Me.PayChqTo
                            dr("DocNo") = Me.DocNo
                            dr("SICode") = Me.SICode
                            dr("RecvBank") = Me.RecvBank
                            dr("RecvBranch") = Me.RecvBranch
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_BranchCode = ""
        m_ControlNo = ""
        m_ItemNo = 0
        m_PRVoucher = ""
        m_PRType = ""
        m_ChqNo = ""
        m_BookCode = ""
        m_BankCode = ""
        m_BankBranch = ""
        m_ChqDate = DateTime.MinValue
        m_CashAmount = 0
        m_ChqAmount = 0
        m_CreditAmount = 0
        m_IsLocal = 0
        m_ChqStatus = ""
        m_TRemark = ""
        m_PayChqTo = ""
        m_DocNo = ""
        m_SICode = ""
        m_RecvBank = ""
        m_RecvBranch = ""
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

                Using cm As New SqlCommand("DELETE FROM Job_CashControlSub" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                End Using
                cn.Close()
                msg = "Delete Complete"
            Catch ex As Exception
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class