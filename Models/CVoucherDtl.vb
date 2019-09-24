'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CVoucherDoc
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
    Private m_DocType As String
    Public Property DocType As String
        Get
            Return m_DocType
        End Get
        Set(value As String)
            m_DocType = value
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
    Private m_DocDate As Date
    Public Property DocDate As Date
        Get
            Return m_DocDate
        End Get
        Set(value As Date)
            m_DocDate = value
        End Set
    End Property
    Private m_CmpType As String
    Public Property CmpType As String
        Get
            Return m_CmpType
        End Get
        Set(value As String)
            m_CmpType = value
        End Set
    End Property
    Private m_CmpCode As String
    Public Property CmpCode As String
        Get
            Return m_CmpCode
        End Get
        Set(value As String)
            m_CmpCode = value
        End Set
    End Property
    Private m_CmpBranch As String
    Public Property CmpBranch As String
        Get
            Return m_CmpBranch
        End Get
        Set(value As String)
            m_CmpBranch = value
        End Set
    End Property
    Private m_PaidAmount As Double
    Public Property PaidAmount As Double
        Get
            Return m_PaidAmount
        End Get
        Set(value As Double)
            m_PaidAmount = value
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
    Private m_acType As String
    Public Property acType As String
        Get
            Return m_acType
        End Get
        Set(value As String)
            m_acType = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_CashControlDoc" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("ControlNo") = Me.ControlNo
                            If Me.ItemNo = 0 Then Me.AddNew()
                            dr("ItemNo") = Me.ItemNo
                            dr("DocType") = Me.DocType
                            dr("DocNo") = Me.DocNo
                            dr("DocDate") = If(Me.DocDate.Year < 1900, System.DBNull.Value, Me.DocDate)
                            dr("CmpType") = Me.CmpType
                            dr("CmpCode") = Me.CmpCode
                            dr("CmpBranch") = Me.CmpBranch
                            dr("PaidAmount") = Me.PaidAmount
                            dr("TotalAmount") = Me.TotalAmount
                            dr("acType") = Me.acType
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVoucherDoc", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVoucherDoc", "SaveData", ex.Message)
                msg = "[ERROR]" & ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()
        Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(ItemNo) as t FROM Job_CashControlDoc WHERE BranchCode='{0}' And ControlNo ='{1}' ", m_BranchCode, m_ControlNo), "____")
        m_ItemNo = Convert.ToInt32("0" & retStr)
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CVoucherDoc)
        Dim lst As New List(Of CVoucherDoc)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CVoucherDoc
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_CashControlDoc" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CVoucherDoc(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ControlNo"))) = False Then
                        row.ControlNo = rd.GetString(rd.GetOrdinal("ControlNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ItemNo"))) = False Then
                        row.ItemNo = rd.GetInt32(rd.GetOrdinal("ItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocType"))) = False Then
                        row.DocType = rd.GetString(rd.GetOrdinal("DocType")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocNo"))) = False Then
                        row.DocNo = rd.GetString(rd.GetOrdinal("DocNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocDate"))) = False Then
                        row.DocDate = rd.GetValue(rd.GetOrdinal("DocDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CmpType"))) = False Then
                        row.CmpType = rd.GetString(rd.GetOrdinal("CmpType")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CmpCode"))) = False Then
                        row.CmpCode = rd.GetString(rd.GetOrdinal("CmpCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CmpBranch"))) = False Then
                        row.CmpBranch = rd.GetString(rd.GetOrdinal("CmpBranch")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PaidAmount"))) = False Then
                        row.PaidAmount = rd.GetDouble(rd.GetOrdinal("PaidAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalAmount"))) = False Then
                        row.TotalAmount = rd.GetDouble(rd.GetOrdinal("TotalAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("acType"))) = False Then
                        row.acType = rd.GetString(rd.GetOrdinal("acType")).ToString()
                    End If
                    lst.Add(row)
                End While
            Catch ex As Exception
            End Try
        End Using
        Return lst
    End Function
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
                msg = Me.CancelData
                If msg = "OK" Then
                    Using cm As New SqlCommand("DELETE FROM Job_CashControlDoc" + pSQLWhere, cn)
                        cm.CommandTimeout = 0
                        cm.CommandType = CommandType.Text
                        cm.ExecuteNonQuery()
                        Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVoucherDoc", "DeleteData", cm.CommandText)
                    End Using

                    msg = "Delete Complete"
                End If

            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVoucherDoc", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Function CancelData() As String
        Dim msg As String = "OK"
        Select Case Me.DocType
            Case "ADV" 'Advance Payments
                Dim sql = String.Format(" WHERE BranchCode='{0}' AND AdvNo='{1}'", Me.BranchCode, Me.DocNo)
                Dim tb = New CAdvHeader(jobWebConn).GetData(sql)
                If tb.Count > 0 Then
                    Dim row = tb(0)
                    If row.DocStatus = 3 Then
                        row.DocStatus = 2
                        row.PaymentBy = ""
                        row.PaymentDate = Nothing
                        row.PaymentTime = Nothing
                        row.PaymentRef = ""

                        row.SaveData(sql)
                    Else
                        msg = "Cannot Cancel Document Status=" & row.DocStatus
                    End If
                End If
            Case "CLR"
                'Cancel Clearing Receival
                Dim sql = String.Format(" WHERE BranchCode='{0}' AND ClrNo='{1}'", Me.BranchCode, Me.DocNo)
                Dim tb = New CClrHeader(jobWebConn).GetData(sql)
                If tb.Count > 0 Then
                    Dim row = tb(0)
                    If row.DocStatus = 3 Then
                        row.DocStatus = 2
                        row.SaveData(sql)
                    Else
                        msg = "Cannot Cancel Document Status=" + row.DocStatus
                    End If
                End If
            Case "INV"
                'Cancel Receipt Saved
                Dim oRcv As New CRcpDetail(jobWebConn)
                Dim oRows = oRcv.GetData(String.Format(" WHERE BranchCode='{0}' AND ControlNo='{1}' AND InvoiceNo+'#'+Convert(varchar,InvoiceItemNo)='{2}' ", Me.BranchCode, Me.ControlNo, Me.DocNo))
                If oRows.Count > 0 Then
                    For Each row In oRows
                        row.ControlNo = ""
                        row.VoucherNo = ""
                        row.ControlItemNo = 0
                        row.SaveData(String.Format(" WHERE BranchCode='{0}' AND ReceiptNo='{1}' AND ItemNo='{2}'", row.BranchCode, row.ReceiptNo, row.ItemNo))
                    Next
                End If
                Me.DocNo = If(Me.DocNo.Substring(0, 1) = "*", Me.DocNo, "*" & Me.DocNo)
                Me.SaveData(String.Format(" WHERE BranchCode='{0}' And ControlNo='{1}' And ItemNo='{2}'", Me.BranchCode, Me.ControlNo, Me.ItemNo))
        End Select
        Return msg
    End Function
End Class
