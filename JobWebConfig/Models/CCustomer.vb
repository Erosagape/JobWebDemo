Imports System.Data.SqlClient
Public Class CCustomer
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
    Private m_CustName As String
    Public Property CustName As String
        Get
            Return m_CustName
        End Get
        Set(value As String)
            m_CustName = value
        End Set
    End Property
    Private m_CustTaxID As String
    Public Property CustTaxID As String
        Get
            Return m_CustTaxID
        End Get
        Set(value As String)
            m_CustTaxID = value
        End Set
    End Property
    Private m_CustAddress As String
    Public Property CustAddress As String
        Get
            Return m_CustAddress
        End Get
        Set(value As String)
            m_CustAddress = value
        End Set
    End Property
    Private m_CustContact As String
    Public Property CustContact As String
        Get
            Return m_CustContact
        End Get
        Set(value As String)
            m_CustContact = value
        End Set
    End Property
    Private m_CustTelFaxMobile As String
    Public Property CustTelFaxMobile As String
        Get
            Return m_CustTelFaxMobile
        End Get
        Set(value As String)
            m_CustTelFaxMobile = value
        End Set
    End Property
    Private m_BeginDate As Date
    Public Property BeginDate As Date
        Get
            Return m_BeginDate
        End Get
        Set(value As Date)
            m_BeginDate = value
        End Set
    End Property
    Private m_ExpireDate As Date
    Public Property ExpireDate As Date
        Get
            Return m_ExpireDate
        End Get
        Set(value As Date)
            m_ExpireDate = value
        End Set
    End Property
    Private m_Active As Integer
    Public Property Active As Integer
        Get
            Return m_Active
        End Get
        Set(value As Integer)
            m_Active = value
        End Set
    End Property
    Private m_CustRemark As String
    Public Property CustRemark As String
        Get
            Return m_CustRemark
        End Get
        Set(value As String)
            m_CustRemark = value
        End Set
    End Property
    Private m_CustMessage As String
    Public Property CustMessage As String
        Get
            Return m_CustMessage
        End Get
        Set(value As String)
            m_CustMessage = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM TWTCustomer" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("CustID") = Me.CustID
                            dr("CustName") = Me.CustName
                            dr("CustTaxID") = Me.CustTaxID
                            dr("CustAddress") = Me.CustAddress
                            dr("CustContact") = Me.CustContact
                            dr("CustTelFaxMobile") = Me.CustTelFaxMobile
                            dr("BeginDate") = Main.GetDBDate(Me.BeginDate)
                            dr("ExpireDate") = Main.GetDBDate(Me.ExpireDate)
                            dr("Active") = Me.Active
                            dr("CustRemark") = Me.CustRemark
                            dr("CustMessage") = Me.CustMessage
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
        m_CustName = ""
        m_CustTaxID = ""
        m_CustAddress = ""
        m_CustContact = ""
        m_CustTelFaxMobile = ""
        m_BeginDate = DateTime.MinValue
        m_ExpireDate = DateTime.MinValue
        m_Active = 0
        m_Seq = 1
        m_CustRemark = ""
        m_CustMessage = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CCustomer)
        Dim lst As New List(Of CCustomer)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CCustomer
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM TWTCustomer" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CCustomer(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustID"))) = False Then
                        row.CustID = rd.GetString(rd.GetOrdinal("CustID")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustName"))) = False Then
                        row.CustName = rd.GetString(rd.GetOrdinal("CustName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustTaxID"))) = False Then
                        row.CustTaxID = rd.GetString(rd.GetOrdinal("CustTaxID")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustAddress"))) = False Then
                        row.CustAddress = rd.GetString(rd.GetOrdinal("CustAddress")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustContact"))) = False Then
                        row.CustContact = rd.GetString(rd.GetOrdinal("CustContact")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustTelFaxMobile"))) = False Then
                        row.CustTelFaxMobile = rd.GetString(rd.GetOrdinal("CustTelFaxMobile")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BeginDate"))) = False Then
                        row.BeginDate = rd.GetValue(rd.GetOrdinal("BeginDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ExpireDate"))) = False Then
                        row.ExpireDate = rd.GetValue(rd.GetOrdinal("ExpireDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Active"))) = False Then
                        row.Active = rd.GetBoolean(rd.GetOrdinal("Active"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustRemark"))) = False Then
                        row.CustRemark = rd.GetString(rd.GetOrdinal("CustRemark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustMessage"))) = False Then
                        row.CustMessage = rd.GetString(rd.GetOrdinal("CustMessage")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM TWTCustomer" + pSQLWhere, cn)
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