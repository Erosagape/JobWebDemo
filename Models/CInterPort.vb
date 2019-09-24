Imports System.Data.SqlClient
Public Class CInterPort
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_PortCode As String
    Public Property PortCode As String
        Get
            Return m_PortCode
        End Get
        Set(value As String)
            m_PortCode = value
        End Set
    End Property
    Private m_PortName As String
    Public Property PortName As String
        Get
            Return m_PortName
        End Get
        Set(value As String)
            m_PortName = value
        End Set
    End Property
    Private m_CountryCode As String
    Public Property CountryCode As String
        Get
            Return m_CountryCode
        End Get
        Set(value As String)
            m_CountryCode = value
        End Set
    End Property
    Private m_StartDate As Date
    Public Property StartDate As Date
        Get
            Return m_StartDate
        End Get
        Set(value As Date)
            m_StartDate = value
        End Set
    End Property
    Private m_FinishDate As Date
    Public Property FinishDate As Date
        Get
            Return m_FinishDate
        End Get
        Set(value As Date)
            m_FinishDate = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_RFIPC" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("PortCode") = Me.PortCode
                            dr("PortName") = Me.PortName
                            dr("CountryCode") = Me.CountryCode
                            dr("StartDate") = Me.StartDate
                            dr("FinishDate") = Me.FinishDate
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInterPort", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInterPort", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_PortCode = ""
        m_PortName = ""
        m_CountryCode = ""
        m_StartDate = DateTime.MinValue
        m_FinishDate = DateTime.MinValue
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CInterPort)
        Dim lst As New List(Of CInterPort)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CInterPort
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_RFIPC" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CInterPort(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PortCode"))) = False Then
                        row.PortCode = rd.GetString(rd.GetOrdinal("PortCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PortName"))) = False Then
                        row.PortName = rd.GetString(rd.GetOrdinal("PortName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CountryCode"))) = False Then
                        row.CountryCode = rd.GetString(rd.GetOrdinal("CountryCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("StartDate"))) = False Then
                        row.StartDate = rd.GetValue(rd.GetOrdinal("StartDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FinishDate"))) = False Then
                        row.FinishDate = rd.GetValue(rd.GetOrdinal("FinishDate"))
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

                Using cm As New SqlCommand("DELETE FROM Mas_RFIPC" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInterPort", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInterPort", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class