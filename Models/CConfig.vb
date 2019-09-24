Imports System.Data.SqlClient

Public Class CConfig
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(Optional pConnStr As String = "")
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Property ConfigCode As String
    Public Property ConfigKey As String
    Public Property ConfigValue As String
    Public Function SaveData() As Boolean
        Dim bComplete As Boolean = False
        Try
            Using cn As New SqlConnection(m_ConnStr)
                cn.Open()
                Using da As New SqlDataAdapter(String.Format("SELECT * FROM Mas_Config WHERE ConfigCode='{0}' AND ConfigKey='{1}'", Me.ConfigCode, Me.ConfigKey), cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count <> 0 Then
                                dr = dt.Rows(0)
                            End If
                            dr(0) = Me.ConfigCode
                            dr(1) = Me.ConfigKey
                            dr(2) = Me.ConfigValue
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            If da.Update(dt) > 0 Then
                                Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CConfig", "SaveData", Me)
                                bComplete = True
                            End If
                        End Using
                    End Using
                End Using

            End Using
        Catch ex As Exception
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CConfig", "SaveData", ex.Message)
        End Try
        Return bComplete
    End Function
    Public Function DeleteData(Optional pSqlWhere As String = "") As String
        Try
            Using cn As New SqlConnection(m_ConnStr)
                cn.Open()

                Using cm = New SqlCommand("DELETE FROM Mas_Config " & pSqlWhere, cn)
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CConfig", "DeleteData", cm.CommandText)
                End Using

            End Using
            Return "Delete Data Complete"
        Catch ex As Exception
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CConfig", "DeleteData", ex.Message)
            Return String.Format("[exception] {0}", ex.Message)
        End Try
    End Function
    Public Function GetData(Optional pSqlWhere As String = "") As List(Of CConfig)
        Dim lst As New List(Of CConfig)
        Try
            Using cn As New SqlConnection(m_ConnStr)
                cn.Open()

                Using rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_Config " & pSqlWhere, cn).ExecuteReader
                    While rd.Read
                        Dim data As New CConfig(m_ConnStr)
                        data.ConfigCode = rd.GetString(0)
                        data.ConfigKey = rd.GetString(1)
                        data.ConfigValue = rd.GetString(2)
                        lst.Add(data)
                    End While
                End Using

            End Using
        Catch ex As Exception
        End Try
        Return lst
    End Function
End Class
