Imports System.Data
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

    Private m_UserID As String
    Public Property UserID As String
        Get
            Return m_UserID
        End Get
        Set(value As String)
            m_UserID = value
        End Set
    End Property
    Private m_UPassword As String
    Public Property UPassword As String
        Get
            Return m_UPassword
        End Get
        Set(value As String)
            m_UPassword = value
        End Set
    End Property
    Private m_TName As String
    Public Property TName As String
        Get
            Return m_TName
        End Get
        Set(value As String)
            m_TName = value
        End Set
    End Property
    Private m_EName As String
    Public Property EName As String
        Get
            Return m_EName
        End Get
        Set(value As String)
            m_EName = value
        End Set
    End Property
    Private m_TPosition As String
    Public Property TPosition As String
        Get
            Return m_TPosition
        End Get
        Set(value As String)
            m_TPosition = value
        End Set
    End Property
    Private m_LoginDate As Date
    Public Property LoginDate As Date
        Get
            Return m_LoginDate
        End Get
        Set(value As Date)
            m_LoginDate = value
        End Set
    End Property
    Private m_LoginTime As Date
    Public Property LoginTime As Date
        Get
            Return m_LoginTime
        End Get
        Set(value As Date)
            m_LoginTime = value
        End Set
    End Property
    Private m_LogoutDate As Date
    Public Property LogoutDate As Date
        Get
            Return m_LogoutDate
        End Get
        Set(value As Date)
            m_LogoutDate = value
        End Set
    End Property
    Private m_LogoutTime As Date
    Public Property LogoutTime As Date
        Get
            Return m_LogoutTime
        End Get
        Set(value As Date)
            m_LogoutTime = value
        End Set
    End Property
    Private m_UPosition As Integer
    Public Property UPosition As Integer
        Get
            Return m_UPosition
        End Get
        Set(value As Integer)
            m_UPosition = value
        End Set
    End Property
    Private m_MaxRateDisc As Double
    Public Property MaxRateDisc As Double
        Get
            Return m_MaxRateDisc
        End Get
        Set(value As Double)
            m_MaxRateDisc = value
        End Set
    End Property
    Private m_MaxAdvance As Double
    Public Property MaxAdvance As Double
        Get
            Return m_MaxAdvance
        End Get
        Set(value As Double)
            m_MaxAdvance = value
        End Set
    End Property
    Private m_JobAuthorize As String
    Public Property JobAuthorize As String
        Get
            Return m_JobAuthorize
        End Get
        Set(value As String)
            m_JobAuthorize = value
        End Set
    End Property
    Private m_EMail As String
    Public Property EMail As String
        Get
            Return m_EMail
        End Get
        Set(value As String)
            m_EMail = value
        End Set
    End Property
    Private m_MobilePhone As String
    Public Property MobilePhone As String
        Get
            Return m_MobilePhone
        End Get
        Set(value As String)
            m_MobilePhone = value
        End Set
    End Property
    Private m_IsAlertByAgent As Integer
    Public Property IsAlertByAgent As Integer
        Get
            Return m_IsAlertByAgent
        End Get
        Set(value As Integer)
            m_IsAlertByAgent = value
        End Set
    End Property
    Private m_IsAlertByEMail As Integer
    Public Property IsAlertByEMail As Integer
        Get
            Return m_IsAlertByEMail
        End Get
        Set(value As Integer)
            m_IsAlertByEMail = value
        End Set
    End Property
    Private m_IsAlertBySMS As Integer
    Public Property IsAlertBySMS As Integer
        Get
            Return m_IsAlertBySMS
        End Get
        Set(value As Integer)
            m_IsAlertBySMS = value
        End Set
    End Property
    Private m_UserUpline As String
    Public Property UserUpline As String
        Get
            Return m_UserUpline
        End Get
        Set(value As String)
            m_UserUpline = value
        End Set
    End Property
    Private m_GLAccountCode As String
    Public Property GLAccountCode As String
        Get
            Return m_GLAccountCode
        End Get
        Set(value As String)
            m_GLAccountCode = value
        End Set
    End Property
    Private m_UsedLanguage As String
    Public Property UsedLanguage As String
        Get
            Return m_UsedLanguage
        End Get
        Set(value As String)
            m_UsedLanguage = value
        End Set
    End Property
    Private m_DMailAccount As String
    Public Property DMailAccount As String
        Get
            Return m_DMailAccount
        End Get
        Set(value As String)
            m_DMailAccount = value
        End Set
    End Property
    Private m_DMailPassword As String
    Public Property DMailPassword As String
        Get
            Return m_DMailPassword
        End Get
        Set(value As String)
            m_DMailPassword = value
        End Set
    End Property
    Private m_JobPolicy As String
    Public Property JobPolicy As String
        Get
            Return m_JobPolicy
        End Get
        Set(value As String)
            m_JobPolicy = value
        End Set
    End Property
    Private m_AlertPolicy As String
    Public Property AlertPolicy As String
        Get
            Return m_AlertPolicy
        End Get
        Set(value As String)
            m_AlertPolicy = value
        End Set
    End Property
    Private m_DeptID As String
    Public Property DeptID As String
        Get
            Return m_DeptID
        End Get
        Set(value As String)
            m_DeptID = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Dim stepFld As String = 0
            Try
                cn.Open()
                Using da As New SqlDataAdapter("SELECT * FROM Mas_User" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            stepFld = 1 : dr("UserID") = Me.UserID
                            stepFld = 2 : dr("UPassword") = Me.UPassword
                            stepFld = 3 : dr("TName") = Me.TName
                            stepFld = 4 : dr("EName") = Me.EName
                            stepFld = 5 : dr("TPosition") = Me.TPosition
                            stepFld = 6 : dr("LoginDate") = Main.GetDBDate(Me.LoginDate)
                            stepFld = 7 : dr("LoginTime") = Main.GetDBTime(Me.LoginTime)
                            stepFld = 8 : dr("LogoutDate") = Main.GetDBDate(Me.LogoutDate)
                            stepFld = 9 : dr("LogoutTime") = Main.GetDBTime(Me.LogoutTime)
                            stepFld = 10 : dr("UPosition") = Me.UPosition
                            stepFld = 11 : dr("MaxRateDisc") = Me.MaxRateDisc
                            stepFld = 12 : dr("MaxAdvance") = Me.MaxAdvance
                            stepFld = 13 : dr("JobAuthorize") = Me.JobAuthorize
                            stepFld = 14 : dr("EMail") = Me.EMail
                            stepFld = 15 : dr("MobilePhone") = Me.MobilePhone
                            stepFld = 16 : dr("IsAlertByAgent") = Me.IsAlertByAgent
                            stepFld = 17 : dr("IsAlertByEMail") = Me.IsAlertByEMail
                            stepFld = 18 : dr("IsAlertBySMS") = Me.IsAlertBySMS
                            stepFld = 19 : dr("UserUpline") = Me.UserUpline
                            stepFld = 20 : dr("GLAccountCode") = Me.GLAccountCode
                            stepFld = 21 : dr("UsedLanguage") = Me.UsedLanguage
                            stepFld = 22 : dr("DMailAccount") = Me.DMailAccount
                            stepFld = 23 : dr("DMailPassword") = Me.DMailPassword
                            stepFld = 24 : dr("JobPolicy") = Me.JobPolicy
                            stepFld = 25 : dr("AlertPolicy") = Me.AlertPolicy
                            stepFld = 26 : dr("DeptID") = Me.DeptID
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUser", "SaveData", Me)
                            msg = String.Format("Save user {0} Complete", Me.UserID)
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUser", "SaveData", ex.Message)
                msg = "[STEP]=" & stepFld & " :" & ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()
        m_UserID = ""
        m_UPassword = ""
        m_TName = ""
        m_EName = ""
        m_TPosition = ""
        m_LoginDate = DateTime.MinValue
        m_LoginTime = DateTime.MinValue
        m_LogoutDate = DateTime.MinValue
        m_LogoutTime = DateTime.MinValue
        m_UPosition = 0
        m_MaxRateDisc = 0
        m_MaxAdvance = 0
        m_JobAuthorize = ""
        m_EMail = ""
        m_MobilePhone = ""
        m_IsAlertByAgent = 0
        m_IsAlertByEMail = 0
        m_IsAlertBySMS = 0
        m_UserUpline = ""
        m_GLAccountCode = ""
        m_UsedLanguage = ""
        m_DMailAccount = ""
        m_DMailPassword = ""
        m_JobPolicy = ""
        m_AlertPolicy = ""
        m_DeptID = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CUser)
        Dim lst As New List(Of CUser)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CUser
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_User" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CUser(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UserID"))) = False Then
                        row.UserID = rd.GetString(rd.GetOrdinal("UserID")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UPassword"))) = False Then
                        row.UPassword = rd.GetString(rd.GetOrdinal("UPassword")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TName"))) = False Then
                        row.TName = rd.GetString(rd.GetOrdinal("TName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EName"))) = False Then
                        row.EName = rd.GetString(rd.GetOrdinal("EName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TPosition"))) = False Then
                        row.TPosition = rd.GetString(rd.GetOrdinal("TPosition")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LoginDate"))) = False Then
                        row.LoginDate = rd.GetValue(rd.GetOrdinal("LoginDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LoginTime"))) = False Then
                        row.LoginTime = rd.GetValue(rd.GetOrdinal("LoginTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LogoutDate"))) = False Then
                        row.LogoutDate = rd.GetValue(rd.GetOrdinal("LogoutDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LogoutTime"))) = False Then
                        row.LogoutTime = rd.GetValue(rd.GetOrdinal("LogoutTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UPosition"))) = False Then
                        row.UPosition = rd.GetInt16(rd.GetOrdinal("UPosition"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("MaxRateDisc"))) = False Then
                        row.MaxRateDisc = rd.GetDouble(rd.GetOrdinal("MaxRateDisc"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("MaxAdvance"))) = False Then
                        row.MaxAdvance = rd.GetDouble(rd.GetOrdinal("MaxAdvance"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JobAuthorize"))) = False Then
                        row.JobAuthorize = rd.GetString(rd.GetOrdinal("JobAuthorize")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EMail"))) = False Then
                        row.EMail = rd.GetString(rd.GetOrdinal("EMail")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("MobilePhone"))) = False Then
                        row.MobilePhone = rd.GetString(rd.GetOrdinal("MobilePhone")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsAlertByAgent"))) = False Then
                        row.IsAlertByAgent = rd.GetByte(rd.GetOrdinal("IsAlertByAgent"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsAlertByEMail"))) = False Then
                        row.IsAlertByEMail = rd.GetByte(rd.GetOrdinal("IsAlertByEMail"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsAlertBySMS"))) = False Then
                        row.IsAlertBySMS = rd.GetByte(rd.GetOrdinal("IsAlertBySMS"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UserUpline"))) = False Then
                        row.UserUpline = rd.GetString(rd.GetOrdinal("UserUpline")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GLAccountCode"))) = False Then
                        row.GLAccountCode = rd.GetString(rd.GetOrdinal("GLAccountCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UsedLanguage"))) = False Then
                        row.UsedLanguage = rd.GetString(rd.GetOrdinal("UsedLanguage")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DMailAccount"))) = False Then
                        row.DMailAccount = rd.GetString(rd.GetOrdinal("DMailAccount")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DMailPassword"))) = False Then
                        row.DMailPassword = rd.GetString(rd.GetOrdinal("DMailPassword")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JobPolicy"))) = False Then
                        row.JobPolicy = rd.GetString(rd.GetOrdinal("JobPolicy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AlertPolicy"))) = False Then
                        row.AlertPolicy = rd.GetString(rd.GetOrdinal("AlertPolicy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DeptID"))) = False Then
                        row.DeptID = rd.GetString(rd.GetOrdinal("DeptID")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Mas_User" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUser", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CUser", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class