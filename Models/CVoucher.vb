'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CVoucher
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
    Private m_VoucherDate As Date
    Public Property VoucherDate As Date
        Get
            Return m_VoucherDate
        End Get
        Set(value As Date)
            m_VoucherDate = value
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
    Private m_RecUser As String
    Public Property RecUser As String
        Get
            Return m_RecUser
        End Get
        Set(value As String)
            m_RecUser = value
        End Set
    End Property
    Private m_RecDate As Date
    Public Property RecDate As Date
        Get
            Return m_RecDate
        End Get
        Set(value As Date)
            m_RecDate = value
        End Set
    End Property
    Private m_RecTime As Date
    Public Property RecTime As Date
        Get
            Return m_RecTime
        End Get
        Set(value As Date)
            m_RecTime = value
        End Set
    End Property
    Private m_PostedBy As String
    Public Property PostedBy As String
        Get
            Return m_PostedBy
        End Get
        Set(value As String)
            m_PostedBy = value
        End Set
    End Property
    Private m_PostedDate As Date
    Public Property PostedDate As Date
        Get
            Return m_PostedDate
        End Get
        Set(value As Date)
            m_PostedDate = value
        End Set
    End Property
    Private m_PostedTime As Date
    Public Property PostedTime As Date
        Get
            Return m_PostedTime
        End Get
        Set(value As Date)
            m_PostedTime = value
        End Set
    End Property
    Private m_CancelReson As String
    Public Property CancelReson As String
        Get
            Return m_CancelReson
        End Get
        Set(value As String)
            m_CancelReson = value
        End Set
    End Property
    Private m_CancelProve As String
    Public Property CancelProve As String
        Get
            Return m_CancelProve
        End Get
        Set(value As String)
            m_CancelProve = value
        End Set
    End Property
    Private m_CancelDate As Date
    Public Property CancelDate As Date
        Get
            Return m_CancelDate
        End Get
        Set(value As Date)
            m_CancelDate = value
        End Set
    End Property
    Private m_CancelTime As Date
    Public Property CancelTime As Date
        Get
            Return m_CancelTime
        End Get
        Set(value As Date)
            m_CancelTime = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_CashControl" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("ControlNo") = Me.ControlNo
                            dr("VoucherDate") = If(Me.VoucherDate.Year < 1900, System.DBNull.Value, Me.VoucherDate)
                            dr("TRemark") = Me.TRemark
                            dr("RecUser") = Me.RecUser
                            dr("RecDate") = If(Me.RecDate.Year < 1900, System.DBNull.Value, Me.RecDate)
                            dr("RecTime") = Me.RecTime
                            dr("PostedBy") = Me.PostedBy
                            dr("PostedDate") = If(Me.PostedDate.Year < 1900, System.DBNull.Value, Me.PostedDate)
                            dr("PostedTime") = Me.PostedTime
                            dr("CancelReson") = Me.CancelReson
                            dr("CancelProve") = Me.CancelProve
                            dr("CancelDate") = If(Me.CancelDate.Year < 1900, System.DBNull.Value, Me.CancelDate)
                            dr("CancelTime") = Me.CancelTime
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
        m_VoucherDate = DateTime.MinValue
        m_TRemark = ""
        m_RecUser = ""
        m_RecDate = DateTime.MinValue
        m_RecTime = DateTime.MinValue
        m_PostedBy = ""
        m_PostedDate = DateTime.MinValue
        m_PostedTime = DateTime.MinValue
        m_CancelReson = ""
        m_CancelProve = ""
        m_CancelDate = DateTime.MinValue
        m_CancelTime = DateTime.MinValue
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CVoucher)
        Dim lst As New List(Of CVoucher)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CVoucher
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_CashControl" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CVoucher(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ControlNo"))) = False Then
                        row.ControlNo = rd.GetString(rd.GetOrdinal("ControlNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VoucherDate"))) = False Then
                        row.VoucherDate = rd.GetValue(rd.GetOrdinal("VoucherDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TRemark"))) = False Then
                        row.TRemark = rd.GetString(rd.GetOrdinal("TRemark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("RecUser"))) = False Then
                        row.RecUser = rd.GetString(rd.GetOrdinal("RecUser")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("RecDate"))) = False Then
                        row.RecDate = rd.GetValue(rd.GetOrdinal("RecDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("RecTime"))) = False Then
                        row.RecTime = rd.GetValue(rd.GetOrdinal("RecTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PostedBy"))) = False Then
                        row.PostedBy = rd.GetString(rd.GetOrdinal("PostedBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PostedDate"))) = False Then
                        row.PostedDate = rd.GetValue(rd.GetOrdinal("PostedDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PostedTime"))) = False Then
                        row.PostedTime = rd.GetValue(rd.GetOrdinal("PostedTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelReson"))) = False Then
                        row.CancelReson = rd.GetString(rd.GetOrdinal("CancelReson")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelProve"))) = False Then
                        row.CancelProve = rd.GetString(rd.GetOrdinal("CancelProve")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelDate"))) = False Then
                        row.CancelDate = rd.GetValue(rd.GetOrdinal("CancelDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelTime"))) = False Then
                        row.CancelTime = rd.GetValue(rd.GetOrdinal("CancelTime"))
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

                Using cm As New SqlCommand("DELETE FROM Job_CashControl" + pSQLWhere, cn)
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