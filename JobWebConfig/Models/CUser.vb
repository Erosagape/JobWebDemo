'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CUser
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_TWTUserID As String
    Public Property TWTUserID As String
        Get
            Return m_TWTUserID
        End Get
        Set(value As String)
            m_TWTUserID = value
        End Set
    End Property
    Private m_TWTUserPassword As String
    Public Property TWTUserPassword As String
        Get
            Return m_TWTUserPassword
        End Get
        Set(value As String)
            m_TWTUserPassword = value
        End Set
    End Property
    Private m_TWTUserName As String
    Public Property TWTUserName As String
        Get
            Return m_TWTUserName
        End Get
        Set(value As String)
            m_TWTUserName = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM TWTUser " & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("TWTUserID") = Me.TWTUserID
                            dr("TWTUserPassword") = Me.TWTUserPassword
                            dr("TWTUserName") = Me.TWTUserName
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
        m_TWTUserID = ""
        m_TWTUserPassword = ""
        m_TWTUserName = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CUser)
        Dim lst As New List(Of CUser)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CUser
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM TWTUser " & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CUser(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TWTUserID"))) = False Then
                        row.TWTUserID = rd.GetString(rd.GetOrdinal("TWTUserID")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TWTUserPassword"))) = False Then
                        row.TWTUserPassword = rd.GetString(rd.GetOrdinal("TWTUserPassword")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TWTUserName"))) = False Then
                        row.TWTUserName = rd.GetString(rd.GetOrdinal("TWTUserName")).ToString()
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
                Using cm As New SqlCommand("DELETE FROM TWTUser " + pSQLWhere, cn)
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