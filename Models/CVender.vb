Imports System.Data.SqlClient
Public Class CVender
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_VenCode As String
    Public Property VenCode As String
        Get
            Return m_VenCode
        End Get
        Set(value As String)
            m_VenCode = value
        End Set
    End Property
    Private m_BranchCode As String
    Public Property BranchCode As String
        Get
            Return m_BranchCode
        End Get
        Set(value As String)
            m_BranchCode = value
        End Set
    End Property
    Private m_TaxNumber As String
    Public Property TaxNumber As String
        Get
            Return m_TaxNumber
        End Get
        Set(value As String)
            m_TaxNumber = value
        End Set
    End Property
    Private m_Title As String
    Public Property Title As String
        Get
            Return m_Title
        End Get
        Set(value As String)
            m_Title = value
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
    Private m_English As String
    Public Property English As String
        Get
            Return m_English
        End Get
        Set(value As String)
            m_English = value
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
    Private m_LoginName As String
    Public Property LoginName As String
        Get
            Return m_LoginName
        End Get
        Set(value As String)
            m_LoginName = value
        End Set
    End Property
    Private m_LoginPassword As String
    Public Property LoginPassword As String
        Get
            Return m_LoginPassword
        End Get
        Set(value As String)
            m_LoginPassword = value
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
    Private m_ContactAcc As String
    Public Property ContactAcc As String
        Get
            Return m_ContactAcc
        End Get
        Set(value As String)
            m_ContactAcc = value
        End Set
    End Property
    Private m_ContactSale As String
    Public Property ContactSale As String
        Get
            Return m_ContactSale
        End Get
        Set(value As String)
            m_ContactSale = value
        End Set
    End Property
    Private m_ContactSupport1 As String
    Public Property ContactSupport1 As String
        Get
            Return m_ContactSupport1
        End Get
        Set(value As String)
            m_ContactSupport1 = value
        End Set
    End Property
    Private m_ContactSupport2 As String
    Public Property ContactSupport2 As String
        Get
            Return m_ContactSupport2
        End Get
        Set(value As String)
            m_ContactSupport2 = value
        End Set
    End Property
    Private m_ContactSupport3 As String
    Public Property ContactSupport3 As String
        Get
            Return m_ContactSupport3
        End Get
        Set(value As String)
            m_ContactSupport3 = value
        End Set
    End Property
    Private m_WEB_SITE As String
    Public Property WEB_SITE As String
        Get
            Return m_WEB_SITE
        End Get
        Set(value As String)
            m_WEB_SITE = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_Vender" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("VenCode") = Me.VenCode
                            dr("BranchCode") = Me.BranchCode
                            dr("TaxNumber") = Me.TaxNumber
                            dr("Title") = Me.Title
                            dr("TName") = Me.TName
                            dr("English") = Me.English
                            dr("TAddress1") = Me.TAddress1
                            dr("TAddress2") = Me.TAddress2
                            dr("EAddress1") = Me.EAddress1
                            dr("EAddress2") = Me.EAddress2
                            dr("Phone") = Me.Phone
                            dr("FaxNumber") = Me.FaxNumber
                            dr("LoginName") = Me.LoginName
                            dr("LoginPassword") = Me.LoginPassword
                            dr("GLAccountCode") = Me.GLAccountCode
                            dr("ContactAcc") = Me.ContactAcc
                            dr("ContactSale") = Me.ContactSale
                            dr("ContactSupport1") = Me.ContactSupport1
                            dr("ContactSupport2") = Me.ContactSupport2
                            dr("ContactSupport3") = Me.ContactSupport3
                            dr("WEB_SITE") = Me.WEB_SITE
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVender", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVender", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_VenCode = ""
        m_BranchCode = ""
        m_TaxNumber = ""
        m_Title = ""
        m_TName = ""
        m_English = ""
        m_TAddress1 = ""
        m_TAddress2 = ""
        m_EAddress1 = ""
        m_EAddress2 = ""
        m_Phone = ""
        m_FaxNumber = ""
        m_LoginName = ""
        m_LoginPassword = ""
        m_GLAccountCode = ""
        m_ContactAcc = ""
        m_ContactSale = ""
        m_ContactSupport1 = ""
        m_ContactSupport2 = ""
        m_ContactSupport3 = ""
        m_WEB_SITE = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CVender)
        Dim lst As New List(Of CVender)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CVender
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_Vender" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CVender(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VenCode"))) = False Then
                        row.VenCode = rd.GetString(rd.GetOrdinal("VenCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TaxNumber"))) = False Then
                        row.TaxNumber = rd.GetString(rd.GetOrdinal("TaxNumber")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Title"))) = False Then
                        row.Title = rd.GetString(rd.GetOrdinal("Title")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TName"))) = False Then
                        row.TName = rd.GetString(rd.GetOrdinal("TName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("English"))) = False Then
                        row.English = rd.GetString(rd.GetOrdinal("English")).ToString()
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
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LoginName"))) = False Then
                        row.LoginName = rd.GetString(rd.GetOrdinal("LoginName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LoginPassword"))) = False Then
                        row.LoginPassword = rd.GetString(rd.GetOrdinal("LoginPassword")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GLAccountCode"))) = False Then
                        row.GLAccountCode = rd.GetString(rd.GetOrdinal("GLAccountCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ContactAcc"))) = False Then
                        row.ContactAcc = rd.GetString(rd.GetOrdinal("ContactAcc")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ContactSale"))) = False Then
                        row.ContactSale = rd.GetString(rd.GetOrdinal("ContactSale")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ContactSupport1"))) = False Then
                        row.ContactSupport1 = rd.GetString(rd.GetOrdinal("ContactSupport1")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ContactSupport2"))) = False Then
                        row.ContactSupport2 = rd.GetString(rd.GetOrdinal("ContactSupport2")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ContactSupport3"))) = False Then
                        row.ContactSupport3 = rd.GetString(rd.GetOrdinal("ContactSupport3")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("WEB_SITE"))) = False Then
                        row.WEB_SITE = rd.GetString(rd.GetOrdinal("WEB_SITE")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Mas_Vender" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVender", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVender", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
