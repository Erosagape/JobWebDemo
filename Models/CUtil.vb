﻿Imports System.Data.SqlClient
Public Class CResult
    Public Sub New()

    End Sub
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
    Public Function GetTableFromSQL(pSQL As String) As DataTable
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
        Return dt
    End Function
End Class
