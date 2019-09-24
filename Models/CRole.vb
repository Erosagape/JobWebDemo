'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CUserRole
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_RoleID As String
    Public Property RoleID As String
        Get
            Return m_RoleID
        End Get
        Set(value As String)
            m_RoleID = value
        End Set
    End Property
    Private m_RoleDesc As String
    Public Property RoleDesc As String
        Get
            Return m_RoleDesc
        End Get
        Set(value As String)
            m_RoleDesc = value
        End Set
    End Property
    Private m_RoleGroup As Integer
    Public Property RoleGroup As Integer
        Get
            Return m_RoleGroup
        End Get
        Set(value As Integer)
            m_RoleGroup = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_UserRole" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("RoleID") = Me.RoleID
                            dr("RoleDesc") = Me.RoleDesc
                            dr("RoleGroup") = Me.RoleGroup
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUserRole", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUserRole", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_RoleID = ""
        m_RoleDesc = ""
        m_RoleGroup = 0
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CUserRole)
        Dim lst As New List(Of CUserRole)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CUserRole
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_UserRole" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CUserRole(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("RoleID"))) = False Then
                        row.RoleID = rd.GetString(rd.GetOrdinal("RoleID")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("RoleDesc"))) = False Then
                        row.RoleDesc = rd.GetString(rd.GetOrdinal("RoleDesc")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("RoleGroup"))) = False Then
                        row.RoleGroup = rd.GetValue(rd.GetOrdinal("RoleGroup"))
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
                Using cm As New SqlCommand("DELETE FROM Mas_UserRole" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUserRole", "DeleteData", cm.CommandText)
                End Using
                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUserRole", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
Public Class CUserRoleDetail
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_RoleID As String
    Public Property RoleID As String
        Get
            Return m_RoleID
        End Get
        Set(value As String)
            m_RoleID = value
        End Set
    End Property
    Private m_UserID As String
    Public Property UserID As String
        Get
            Return m_UserID
        End Get
        Set(value As String)
            m_UserID = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_UserRoleDetail " & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("RoleID") = Me.RoleID
                            dr("UserID") = Me.UserID
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUserRoleDetail", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUserRoleDetail", "SaveData", ex.Message)
                msg = "[ERROR]:" & ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_RoleID = ""
        m_UserID = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CUserRoleDetail)
        Dim lst As New List(Of CUserRoleDetail)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CUserRoleDetail
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_UserRoleDetail " & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CUserRoleDetail(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("RoleID"))) = False Then
                        row.RoleID = rd.GetString(rd.GetOrdinal("RoleID")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UserID"))) = False Then
                        row.UserID = rd.GetString(rd.GetOrdinal("UserID")).ToString()
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

                Using cm As New SqlCommand("UPDATE a SET a.Author='' FROM Mas_UserAuth a INNER JOIN Mas_UserRoleDetail b ON a.UserID=b.UserID INNER JOIN Mas_UserRolePolicy c ON c.ModuleID= a.AppID +'/'+ a.MenuID WHERE a.UserID='" + Me.UserID + "' AND b.RoleID='" + Me.RoleID + "'", cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    If Me.UserID <> "" And Me.RoleID <> "" Then
                        cm.ExecuteNonQuery()
                        Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUserRoleDetail", "DeleteData", cm.CommandText)
                    End If
                    cm.CommandText = "DELETE FROM Mas_UserRoleDetail" + pSQLWhere
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUserRoleDetail", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUserRoleDetail", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
Public Class CUserRolePolicy
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_RoleID As String
    Public Property RoleID As String
        Get
            Return m_RoleID
        End Get
        Set(value As String)
            m_RoleID = value
        End Set
    End Property
    Private m_ModuleID As String
    Public Property ModuleID As String
        Get
            Return m_ModuleID
        End Get
        Set(value As String)
            m_ModuleID = value
        End Set
    End Property
    Private m_Author As String
    Public Property Author As String
        Get
            Return m_Author
        End Get
        Set(value As String)
            m_Author = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_UserRolePolicy" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("RoleID") = Me.RoleID
                            dr("ModuleID") = Me.ModuleID
                            dr("Author") = Me.Author
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUserRolePolicy", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUserRolePolicy", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_RoleID = ""
        m_ModuleID = ""
        m_Author = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CUserRolePolicy)
        Dim lst As New List(Of CUserRolePolicy)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CUserRolePolicy
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_UserRolePolicy" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CUserRolePolicy(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("RoleID"))) = False Then
                        row.RoleID = rd.GetString(rd.GetOrdinal("RoleID")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ModuleID"))) = False Then
                        row.ModuleID = rd.GetString(rd.GetOrdinal("ModuleID")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Author"))) = False Then
                        row.Author = rd.GetString(rd.GetOrdinal("Author")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Mas_UserRolePolicy" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUserRolePolicy", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUserRolePolicy", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class

