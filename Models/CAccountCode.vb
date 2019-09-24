'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CAccountCode
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_AccCode As String
    Public Property AccCode As String
        Get
            Return m_AccCode
        End Get
        Set(value As String)
            m_AccCode = value
        End Set
    End Property
    Private m_AccTName As String
    Public Property AccTName As String
        Get
            Return m_AccTName
        End Get
        Set(value As String)
            m_AccTName = value
        End Set
    End Property
    Private m_AccEName As String
    Public Property AccEName As String
        Get
            Return m_AccEName
        End Get
        Set(value As String)
            m_AccEName = value
        End Set
    End Property
    Private m_AccType As Integer
    Public Property AccType As Integer
        Get
            Return m_AccType
        End Get
        Set(value As Integer)
            m_AccType = value
        End Set
    End Property
    Private m_AccMain As String
    Public Property AccMain As String
        Get
            Return m_AccMain
        End Get
        Set(value As String)
            m_AccMain = value
        End Set
    End Property
    Private m_AccSide As String
    Public Property AccSide As String
        Get
            Return m_AccSide
        End Get
        Set(value As String)
            m_AccSide = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_Account" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("AccCode") = Me.AccCode
                            dr("AccTName") = Me.AccTName
                            dr("AccEName") = Me.AccEName
                            dr("AccType") = Me.AccType
                            dr("AccMain") = Me.AccMain
                            dr("AccSide") = Me.AccSide
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            msg = "Save Complete"
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CAccountCode", "SaveData", Me)
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CAccountCode", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_AccCode = ""
        m_AccTName = ""
        m_AccEName = ""
        m_AccType = ""
        m_AccMain = ""
        m_AccSide = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CAccountCode)
        Dim lst As New List(Of CAccountCode)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CAccountCode
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_Account" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CAccountCode(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AccCode"))) = False Then
                        row.AccCode = rd.GetString(rd.GetOrdinal("AccCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AccTName"))) = False Then
                        row.AccTName = rd.GetString(rd.GetOrdinal("AccTName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AccEName"))) = False Then
                        row.AccEName = rd.GetString(rd.GetOrdinal("AccEName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AccType"))) = False Then
                        row.AccType = rd.GetValue(rd.GetOrdinal("AccType")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AccMain"))) = False Then
                        row.AccMain = rd.GetString(rd.GetOrdinal("AccMain")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AccSide"))) = False Then
                        row.AccSide = rd.GetString(rd.GetOrdinal("AccSide")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Mas_Account" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CAccountCode", "DeleteData", cm.CommandText)
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
