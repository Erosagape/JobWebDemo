Imports System.Data.SqlClient
Public Class CResult
    Public Sub New()

    End Sub
    Public Property IsError As Boolean
    Public Property Source As String
    Public Property Param As String
    Public Property Result As String
End Class
Public Class CUtil
    Private m_ConnStr As String
    Public Property Message As String
    Public Sub New()
        Message = ""
    End Sub
    Public Sub New(Optional pConnStr As String = "")
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Function ExecuteSQL(pSQL As String, Optional bLog As Boolean = True) As String
        Message = "OK"
        Dim dt As New DataTable
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()
                Using cm As New SqlCommand
                    cm.Connection = cn
                    cm.CommandText = pSQL
                    cm.CommandType = CommandType.Text
                    Message &= " Row(s)=" & cm.ExecuteNonQuery()
                    If bLog Then Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "ExecuteSQL", Message, pSQL)
                End Using

            Catch ex As Exception
                Message = "[ERROR]" & ex.Message
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "ExecuteSQL", Message, pSQL)
            End Try
        End Using
        Return Message
    End Function
    Public Function GetTableFromSQL(pSQL As String, Optional saveLog As Boolean = False) As DataTable
        Message = "OK"
        Dim dt As New DataTable
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()
                Using da As New SqlDataAdapter(pSQL, cn)
                    da.Fill(dt)
                End Using

            Catch ex As Exception
                Message = "[ERROR]" & ex.Message
            End Try
        End Using
        If saveLog Then
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPING", "GetTableFromSQL", Message, pSQL)
        End If
        Return dt
    End Function
End Class
