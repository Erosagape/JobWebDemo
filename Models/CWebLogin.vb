'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CWebLogin
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_CustID As String
    Public Property CustID As String
        Get
            Return m_CustID
        End Get
        Set(value As String)
            m_CustID = value
        End Set
    End Property
    Private m_AppID As String
    Public Property AppID As String
        Get
            Return m_AppID
        End Get
        Set(value As String)
            m_AppID = value
        End Set
    End Property
    Private m_UserLogIN As String
    Public Property UserLogIN As String
        Get
            Return m_UserLogIN
        End Get
        Set(value As String)
            m_UserLogIN = value
        End Set
    End Property
    Private m_FromIP As String
    Public Property FromIP As String
        Get
            Return m_FromIP
        End Get
        Set(value As String)
            m_FromIP = value
        End Set
    End Property
    Private m_SessionID As String
    Public Property SessionID As String
        Get
            Return m_SessionID
        End Get
        Set(value As String)
            m_SessionID = value
        End Set
    End Property
    Private m_LoginDateTime As DateTime
    Public Property LoginDateTime As Date
        Get
            Return m_LoginDateTime
        End Get
        Set(value As Date)
            m_LoginDateTime = value
        End Set
    End Property
    Private m_ExpireDateTime As Date
    Public Property ExpireDateTime As Date
        Get
            Return m_ExpireDateTime
        End Get
        Set(value As Date)
            m_ExpireDateTime = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM TWTWebLogin" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("CustID") = Me.CustID
                            dr("AppID") = Me.AppID
                            dr("UserLogIN") = Me.UserLogIN
                            dr("FromIP") = Me.FromIP
                            dr("SessionID") = Me.SessionID
                            dr("LoginDateTime") = Main.GetDBDate(Me.LoginDateTime)
                            dr("ExpireDateTime") = Main.GetDBDate(Me.ExpireDateTime)
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

        m_CustID = ""
        m_AppID = ""
        m_UserLogIN = ""
        m_FromIP = ""
        m_SessionID = ""
        m_LoginDateTime = DateTime.Now
        m_ExpireDateTime = DateTime.Now.AddMinutes(20)
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CWebLogin)
        Dim lst As New List(Of CWebLogin)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CWebLogin
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM TWTWebLogin" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CWebLogin(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustID"))) = False Then
                        row.CustID = rd.GetString(rd.GetOrdinal("CustID")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AppID"))) = False Then
                        row.AppID = rd.GetString(rd.GetOrdinal("AppID")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UserLogIN"))) = False Then
                        row.UserLogIN = rd.GetString(rd.GetOrdinal("UserLogIN")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FromIP"))) = False Then
                        row.FromIP = rd.GetString(rd.GetOrdinal("FromIP")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SessionID"))) = False Then
                        row.SessionID = rd.GetString(rd.GetOrdinal("SessionID")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LoginDateTime"))) = False Then
                        row.LoginDateTime = rd.GetValue(rd.GetOrdinal("LoginDateTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ExpireDateTime"))) = False Then
                        row.ExpireDateTime = rd.GetValue(rd.GetOrdinal("ExpireDateTime"))
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

                Using cm As New SqlCommand("DELETE FROM TWTWebLogin" + pSQLWhere, cn)
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