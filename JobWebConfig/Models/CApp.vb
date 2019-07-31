Imports System.Data.SqlClient
Public Class CApp
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_AppID As String
    Public Property AppID As String
        Get
            Return m_AppID
        End Get
        Set(value As String)
            m_AppID = value
        End Set
    End Property
    Private m_AppNameTH As String
    Public Property AppNameTH As String
        Get
            Return m_AppNameTH
        End Get
        Set(value As String)
            m_AppNameTH = value
        End Set
    End Property
    Private m_AppNameEN As String
    Public Property AppNameEN As String
        Get
            Return m_AppNameEN
        End Get
        Set(value As String)
            m_AppNameEN = value
        End Set
    End Property
    Private m_AppMainURL As String
    Public Property AppMainURL As String
        Get
            Return m_AppMainURL
        End Get
        Set(value As String)
            m_AppMainURL = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM TWTApp" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("AppID") = Me.AppID
                            dr("AppNameTH") = Me.AppNameTH
                            dr("AppNameEN") = Me.AppNameEN
                            dr("AppMainURL") = Me.AppMainURL
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

        m_AppID = ""
        m_AppNameTH = ""
        m_AppNameEN = ""
        m_AppMainURL = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CApp)
        Dim lst As New List(Of CApp)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CApp
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM TWTApp" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CApp(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AppID"))) = False Then
                        row.AppID = rd.GetString(rd.GetOrdinal("AppID")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AppNameTH"))) = False Then
                        row.AppNameTH = rd.GetString(rd.GetOrdinal("AppNameTH")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AppNameEN"))) = False Then
                        row.AppNameEN = rd.GetString(rd.GetOrdinal("AppNameEN")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AppMainURL"))) = False Then
                        row.AppMainURL = rd.GetString(rd.GetOrdinal("AppMainURL")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM TWTApp" + pSQLWhere, cn)
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