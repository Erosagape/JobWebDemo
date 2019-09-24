'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CCompanyContact
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_CustCode As String
    Public Property CustCode As String
        Get
            Return m_CustCode
        End Get
        Set(value As String)
            m_CustCode = value
        End Set
    End Property
    Private m_Branch As String
    Public Property Branch As String
        Get
            Return m_Branch
        End Get
        Set(value As String)
            m_Branch = value
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
    Private m_Department As String
    Public Property Department As String
        Get
            Return m_Department
        End Get
        Set(value As String)
            m_Department = value
        End Set
    End Property
    Private m_Position As String
    Public Property Position As String
        Get
            Return m_Position
        End Get
        Set(value As String)
            m_Position = value
        End Set
    End Property
    Private m_ContactName As String
    Public Property ContactName As String
        Get
            Return m_ContactName
        End Get
        Set(value As String)
            m_ContactName = value
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
    Private m_Phone As String
    Public Property Phone As String
        Get
            Return m_Phone
        End Get
        Set(value As String)
            m_Phone = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_CompanyContact" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("CustCode") = Me.CustCode
                            dr("Branch") = Me.Branch
                            If Me.ItemNo = 0 Then Me.AddNew()
                            dr("ItemNo") = Me.ItemNo
                            dr("Department") = Me.Department
                            dr("Position") = Me.Position
                            dr("ContactName") = Me.ContactName
                            dr("EMail") = Me.EMail
                            dr("Phone") = Me.Phone
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCompanyContact", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCompanyContact", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()
        Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(ItemNo) as t FROM Mas_CompanyContact WHERE CustCode='{0}' And Branch='{1}' ", m_CustCode, m_Branch), "____")
        m_ItemNo = Convert.ToInt32("0" & retStr)
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CCompanyContact)
        Dim lst As New List(Of CCompanyContact)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CCompanyContact
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_CompanyContact" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CCompanyContact(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustCode"))) = False Then
                        row.CustCode = rd.GetString(rd.GetOrdinal("CustCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Branch"))) = False Then
                        row.Branch = rd.GetString(rd.GetOrdinal("Branch")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ItemNo"))) = False Then
                        row.ItemNo = rd.GetInt16(rd.GetOrdinal("ItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Department"))) = False Then
                        row.Department = rd.GetString(rd.GetOrdinal("Department")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Position"))) = False Then
                        row.Position = rd.GetString(rd.GetOrdinal("Position")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ContactName"))) = False Then
                        row.ContactName = rd.GetString(rd.GetOrdinal("ContactName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EMail"))) = False Then
                        row.EMail = rd.GetString(rd.GetOrdinal("EMail")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Phone"))) = False Then
                        row.Phone = rd.GetString(rd.GetOrdinal("Phone")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Mas_CompanyContact" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCompanyContact", "DeleteData", cm.CommandText)
                End Using
                cn.Close()
                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCompanyContact", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class