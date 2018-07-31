Imports System.Data.SqlClient

Public Class CBranch
    Private m_ConnStr As String
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Property Code As String
    Public Property BrName As String
    Public Function GetData() As List(Of CBranch)
        Dim lst As New List(Of CBranch)
        Try
            Using cn As New SqlConnection(m_ConnStr)
                cn.Open()

                Using rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_Branch", cn).ExecuteReader
                    While rd.Read
                        Dim data As New CBranch(m_ConnStr)
                        data.Code = rd.GetString(0)
                        data.BrName = rd.GetString(1)
                        lst.Add(data)
                    End While
                    rd.Close()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
        End Try
        Return lst
    End Function
End Class
