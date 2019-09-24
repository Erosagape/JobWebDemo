'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CBookAccount
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
    Private m_BookCode As String
    Public Property BookCode As String
        Get
            Return m_BookCode
        End Get
        Set(value As String)
            m_BookCode = value
        End Set
    End Property
    Private m_BookName As String
    Public Property BookName As String
        Get
            Return m_BookName
        End Get
        Set(value As String)
            m_BookName = value
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
    Private m_IsLocal As Integer
    Public Property IsLocal As Integer
        Get
            Return m_IsLocal
        End Get
        Set(value As Integer)
            m_IsLocal = value
        End Set
    End Property
    Private m_ACType As String
    Public Property ACType As String
        Get
            Return m_ACType
        End Get
        Set(value As String)
            m_ACType = value
        End Set
    End Property
    Private m_TAddress1 As String
    Public Property TAddress1 As String
        Get
            Return m_TAddress1
        End Get
        Set(value As String)
            m_TAddress1 = value
        End Set
    End Property
    Private m_TAddress2 As String
    Public Property TAddress2 As String
        Get
            Return m_TAddress2
        End Get
        Set(value As String)
            m_TAddress2 = value
        End Set
    End Property
    Private m_EAddress1 As String
    Public Property EAddress1 As String
        Get
            Return m_EAddress1
        End Get
        Set(value As String)
            m_EAddress1 = value
        End Set
    End Property
    Private m_EAddress2 As String
    Public Property EAddress2 As String
        Get
            Return m_EAddress2
        End Get
        Set(value As String)
            m_EAddress2 = value
        End Set
    End Property
    Private m_Phone As String
    Public Property Phone As String
        Get
            Return m_Phone
        End Get
        Set(value As String)
            m_Phone = value
        End Set
    End Property
    Private m_FaxNumber As String
    Public Property FaxNumber As String
        Get
            Return m_FaxNumber
        End Get
        Set(value As String)
            m_FaxNumber = value
        End Set
    End Property
    Private m_LimitBalance As Double
    Public Property LimitBalance As Double
        Get
            Return m_LimitBalance
        End Get
        Set(value As Double)
            m_LimitBalance = value
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
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_BookAccount" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("BookCode") = Me.BookCode
                            dr("BookName") = Me.BookName
                            dr("BankCode") = Me.BankCode
                            dr("BankBranch") = Me.BankBranch
                            dr("IsLocal") = Me.IsLocal
                            dr("ACType") = Me.ACType
                            dr("TAddress1") = Me.TAddress1
                            dr("TAddress2") = Me.TAddress2
                            dr("EAddress1") = Me.EAddress1
                            dr("EAddress2") = Me.EAddress2
                            dr("Phone") = Me.Phone
                            dr("FaxNumber") = Me.FaxNumber
                            dr("LimitBalance") = Me.LimitBalance
                            dr("GLAccountCode") = Me.GLAccountCode
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBookAccount", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBookAccount", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_BranchCode = ""
        m_BookCode = ""
        m_BookName = ""
        m_BankCode = ""
        m_BankBranch = ""
        m_IsLocal = 0
        m_ACType = ""
        m_TAddress1 = ""
        m_TAddress2 = ""
        m_EAddress1 = ""
        m_EAddress2 = ""
        m_Phone = ""
        m_FaxNumber = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CBookAccount)
        Dim lst As New List(Of CBookAccount)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CBookAccount
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_BookAccount" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CBookAccount(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BookCode"))) = False Then
                        row.BookCode = rd.GetString(rd.GetOrdinal("BookCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BookName"))) = False Then
                        row.BookName = rd.GetString(rd.GetOrdinal("BookName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BankCode"))) = False Then
                        row.BankCode = rd.GetString(rd.GetOrdinal("BankCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BankBranch"))) = False Then
                        row.BankBranch = rd.GetString(rd.GetOrdinal("BankBranch")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsLocal"))) = False Then
                        row.IsLocal = rd.GetByte(rd.GetOrdinal("IsLocal"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ACType"))) = False Then
                        row.ACType = rd.GetString(rd.GetOrdinal("ACType")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TAddress1"))) = False Then
                        row.TAddress1 = rd.GetString(rd.GetOrdinal("TAddress1")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TAddress2"))) = False Then
                        row.TAddress2 = rd.GetString(rd.GetOrdinal("TAddress2")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EAddress1"))) = False Then
                        row.EAddress1 = rd.GetString(rd.GetOrdinal("EAddress1")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EAddress2"))) = False Then
                        row.EAddress2 = rd.GetString(rd.GetOrdinal("EAddress2")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Phone"))) = False Then
                        row.Phone = rd.GetString(rd.GetOrdinal("Phone")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FaxNumber"))) = False Then
                        row.FaxNumber = rd.GetString(rd.GetOrdinal("FaxNumber")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LimitBalance"))) = False Then
                        row.LimitBalance = rd.GetDouble(rd.GetOrdinal("LimitBalance")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GLAccountCode"))) = False Then
                        row.GLAccountCode = rd.GetString(rd.GetOrdinal("GLAccountCode")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Mas_BookAccount" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBookAccount", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBookAccount", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class