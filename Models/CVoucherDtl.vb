'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CVoucherDtl
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
                            dr("ItemNo") = Me.ItemNo
                            dr("DocType") = Me.DocType
                            dr("DocNo") = Me.DocNo
                            dr("DocDate") = If(Me.DocDate.Year < 1900, System.DBNull.Value, Me.DocDate)
                            dr("CmpType") = Me.CmpType
                            dr("CmpCode") = Me.CmpCode
                            dr("CmpBranch") = Me.CmpBranch
                            dr("PaidAmount") = Me.PaidAmount
                            dr("TotalAmount") = Me.TotalAmount
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
        m_DocType = ""
        m_DocNo = ""
        m_DocDate = DateTime.MinValue
        m_CmpType = ""
        m_CmpCode = ""
        m_CmpBranch = ""
        m_PaidAmount = 0
        m_TotalAmount = 0
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CVoucherDtl)
        Dim lst As New List(Of CVoucherDtl)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CVoucherDtl
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_CashControlDoc" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CVoucherDtl(m_ConnStr)
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

                Using cm As New SqlCommand("DELETE FROM Job_CashControlDoc" + pSQLWhere, cn)
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
