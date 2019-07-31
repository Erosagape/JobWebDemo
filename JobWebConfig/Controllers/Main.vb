Imports System.Data.SqlClient
Module Main
    Friend Const jsonContent As String = "application/json;charset=UTF-8"
    Friend Const xmlContent As String = "application/xml;charset=UTF-8"
    Friend Const textContent As String = "text/html"
    Friend Const logoApp As String = "logo-tawan.jpg"
    Friend Const logoRep As String = "logo-idl.jpg"
    Friend debugConn As String = "Data Source=.\DEVTEST;Initial Catalog=DEVTEST;Integrated Security=True"
    Friend productionConn As String = "Data Source=.\MSSQLSERVER2016;Initial Catalog=tawancust;User id=tawantech;password=ucrC89I55y;Persist Security Info=false;"
    Public Enum DatabaseType
        MSSQL = 2
        MYSQL = 1
    End Enum
    Public Function GetConnection() As String
        Dim cnStr As String = If(New CUtil().IsLocalHost(), Main.debugConn, Main.productionConn)
        Return cnStr
    End Function
    Friend Function GetDBDate(pDate As Date, Optional pTodayAsDefault As Boolean = False) As Object
        If pDate.Year > 2000 Then
            Return pDate
        Else
            If pTodayAsDefault Then
                Return DateTime.Today
            Else
                Return System.DBNull.Value
            End If
        End If
    End Function
    Friend Function GetDBTime(pDate As Date) As Object
        If pDate.Hour > 0 Then
            Return pDate
        Else
            Return System.DBNull.Value
        End If
    End Function
    Friend Function GetValueSQL(conn As String, sql As String) As CResult
        Dim ret As New CResult With {
            .Source = sql,
            .Param = conn,
            .Result = ""
        }
        Try
            Using cn As New SqlConnection(conn)
                cn.Open()
                Using rd As SqlDataReader = New SqlCommand(sql, cn).ExecuteReader
                    If rd.Read Then
                        If rd.HasRows Then
                            Dim val As String = rd.GetValue(0).ToString()
                            ret.Result = val
                        End If
                    End If
                    rd.Close()
                End Using
            End Using
        Catch ex As Exception
            ret.IsError = True
            ret.Result = ex.Message
        End Try
        Return ret
    End Function
    Friend Function GetMaxByMask(sConn As String, sSQL As String, sFormat As String) As String
        Dim retStr As String = ""
        Try
            Using cn As New SqlConnection(sConn)
                cn.Open()
                Using rd As SqlDataReader = New SqlCommand(sSQL, cn).ExecuteReader
                    If rd.Read Then
                        If rd.HasRows Then
                            Dim numStr As String = ""
                            Dim formatStr As String = ""
                            Dim val As String = rd.GetValue(0).ToString()
                            Dim i As Integer = 0
                            For i = 1 To val.Length
                                If IsNumeric(val.Substring(val.Length - i, 1)) Then
                                    numStr = val.Substring(val.Length - i, 1) & numStr
                                    formatStr &= "0"
                                Else
                                    Exit For
                                End If
                            Next
                            If numStr <> "" Then
                                retStr = val.Substring(0, val.Length - i + 1) & Format(CLng(numStr) + 1, formatStr)
                            End If
                        End If
                    End If
                    rd.Close()
                End Using

            End Using
        Catch ex As Exception

        End Try
        If retStr = "" Then
            Dim j As Integer = sFormat.Count(Function(c As Char) c = "_")
            retStr = Replace(sFormat, Strings.StrDup(j, "_"), Format(1, Strings.StrDup(j, "0")))
        End If
        Return retStr
    End Function
    Friend Function DBExecute(conn As String, SQL As String) As String
        Try
            Using cn As New SqlConnection(conn)
                cn.Open()
                Using cm As New SqlCommand()
                    cm.Connection = cn
                    cm.CommandType = CommandType.Text
                    cm.CommandText = SQL
                    cm.ExecuteNonQuery()
                End Using

            End Using
            Return "OK"
        Catch ex As Exception
            Return "[ERROR]" & ex.Message
        End Try
    End Function
End Module
