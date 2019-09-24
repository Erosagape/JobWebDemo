Imports System.Data.SqlClient
Public Class CCurrency
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_Code As String
    Public Property Code As String
        Get
            Return m_Code
        End Get
        Set(value As String)
            m_Code = value
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
    Private m_LastUpdate As Date
    Public Property LastUpdate As Date
        Get
            Return m_LastUpdate
        End Get
        Set(value As Date)
            m_LastUpdate = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_CurrencyCode" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("Code") = Me.Code
                            dr("TName") = Me.TName
                            dr("StartDate") = Me.StartDate
                            dr("FinishDate") = Me.FinishDate
                            dr("LastUpdate") = Me.LastUpdate
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCurrency", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCurrency", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_Code = ""
        m_TName = ""
        m_StartDate = DateTime.MinValue
        m_FinishDate = DateTime.MinValue
        m_LastUpdate = DateTime.MinValue
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CCurrency)
        Dim lst As New List(Of CCurrency)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CCurrency
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_CurrencyCode" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CCurrency(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Code"))) = False Then
                        row.Code = rd.GetString(rd.GetOrdinal("Code")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TName"))) = False Then
                        row.TName = rd.GetString(rd.GetOrdinal("TName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("StartDate"))) = False Then
                        row.StartDate = rd.GetValue(rd.GetOrdinal("StartDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FinishDate"))) = False Then
                        row.FinishDate = rd.GetValue(rd.GetOrdinal("FinishDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LastUpdate"))) = False Then
                        row.LastUpdate = rd.GetValue(rd.GetOrdinal("LastUpdate"))
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

                Using cm As New SqlCommand("DELETE FROM Mas_CurrencyCode" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCurrency", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCurrency", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class