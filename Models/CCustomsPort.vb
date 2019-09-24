Imports System.Data.SqlClient
Public Class CCustomsPort
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_AreaCode As String
    Public Property AreaCode As String
        Get
            Return m_AreaCode
        End Get
        Set(value As String)
            m_AreaCode = value
        End Set
    End Property
    Private m_AreaName As String
    Public Property AreaName As String
        Get
            Return m_AreaName
        End Get
        Set(value As String)
            m_AreaName = value
        End Set
    End Property
    Private m_AccNo As String
    Public Property AccNo As String
        Get
            Return m_AccNo
        End Get
        Set(value As String)
            m_AccNo = value
        End Set
    End Property
    Private m_Payee As String
    Public Property Payee As String
        Get
            Return m_Payee
        End Get
        Set(value As String)
            m_Payee = value
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
    Private m_AcType As String
    Public Property AcType As String
        Get
            Return m_AcType
        End Get
        Set(value As String)
            m_AcType = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_RFARS" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("AreaCode") = Me.AreaCode
                            dr("AreaName") = Me.AreaName
                            dr("AccNo") = Me.AccNo
                            dr("Payee") = Me.Payee
                            dr("BankCode") = Me.BankCode
                            dr("AcType") = Me.AcType
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCustomsPort", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCustomsPort", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_AreaCode = ""
        m_AreaName = ""
        m_AccNo = ""
        m_Payee = ""
        m_BankCode = ""
        m_AcType = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CCustomsPort)
        Dim lst As New List(Of CCustomsPort)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CCustomsPort
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_RFARS" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CCustomsPort(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AreaCode"))) = False Then
                        row.AreaCode = rd.GetString(rd.GetOrdinal("AreaCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AreaName"))) = False Then
                        row.AreaName = rd.GetString(rd.GetOrdinal("AreaName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AccNo"))) = False Then
                        row.AccNo = rd.GetString(rd.GetOrdinal("AccNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Payee"))) = False Then
                        row.Payee = rd.GetString(rd.GetOrdinal("Payee")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BankCode"))) = False Then
                        row.BankCode = rd.GetString(rd.GetOrdinal("BankCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AcType"))) = False Then
                        row.AcType = rd.GetString(rd.GetOrdinal("AcType")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Mas_RFARS" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCustomsPort", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCustomsPort", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class