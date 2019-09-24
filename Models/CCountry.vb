Imports System.Data.SqlClient
Public Class CCountry
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_CTYCODE As String
    Public Property CTYCODE As String
        Get
            Return m_CTYCODE
        End Get
        Set(value As String)
            m_CTYCODE = value
        End Set
    End Property
    Private m_CTYName As String
    Public Property CTYName As String
        Get
            Return m_CTYName
        End Get
        Set(value As String)
            m_CTYName = value
        End Set
    End Property
    Private m_CURCODE As String
    Public Property CURCODE As String
        Get
            Return m_CURCODE
        End Get
        Set(value As String)
            m_CURCODE = value
        End Set
    End Property
    Private m_FTCODE As Integer
    Public Property FTCODE As Integer
        Get
            Return m_FTCODE
        End Get
        Set(value As Integer)
            m_FTCODE = value
        End Set
    End Property
    Private m_CUCODE As Integer
    Public Property CUCODE As Integer
        Get
            Return m_CUCODE
        End Get
        Set(value As Integer)
            m_CUCODE = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_CountryFT" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("CTYCODE") = Me.CTYCODE
                            dr("CTYName") = Me.CTYName
                            dr("CURCODE") = Me.CURCODE
                            dr("FTCODE") = Me.FTCODE
                            dr("CUCODE") = Me.CUCODE
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCountry", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCountry", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_CTYCODE = ""
        m_CTYName = ""
        m_CURCODE = ""
        m_FTCODE = 0
        m_CUCODE = 0
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CCountry)
        Dim lst As New List(Of CCountry)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CCountry
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_CountryFT" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CCountry(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CTYCODE"))) = False Then
                        row.CTYCODE = rd.GetString(rd.GetOrdinal("CTYCODE")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CTYName"))) = False Then
                        row.CTYName = rd.GetString(rd.GetOrdinal("CTYName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CURCODE"))) = False Then
                        row.CURCODE = rd.GetString(rd.GetOrdinal("CURCODE")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FTCODE"))) = False Then
                        row.FTCODE = rd.GetInt32(rd.GetOrdinal("FTCODE"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CUCODE"))) = False Then
                        row.CUCODE = rd.GetInt32(rd.GetOrdinal("CUCODE"))
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

                Using cm As New SqlCommand("DELETE FROM Mas_CountryFT" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCountry", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCountry", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class