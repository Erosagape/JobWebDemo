Imports System.Data.SqlClient

Module Main
    Friend Const jsonContent As String = "application/json;charset=UTF-8"
    Friend Const xmlContent As String = "application/xml;charset=UTF-8"
    Friend Const textContent As String = "text/html"
    Friend Const jobDataPath As String = "~/App_Data/job_data.xml"
    Friend Const logoApp As String = "logo-tawan.jpg"
    Friend Const logoRep As String = "logo-idl.jpg"
    Friend jobWebConn As String = ConfigurationManager.ConnectionStrings("JobWebConnectionString").ConnectionString
    Friend jobMasConn As String = ConfigurationManager.ConnectionStrings("JobMasConnectionString").ConnectionString
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
    Friend Function GetValueConfig(sCode As String, sKey As String) As String
        Dim tSqlw As String = " WHERE ConfigCode<>'' "
        tSqlw &= String.Format("AND ConfigCode='{0}'", sCode)
        tSqlw &= String.Format("AND ISNULL(ConfigKey,'')='{0}'", sKey)
        Dim oData = New CConfig(jobWebConn).GetData(tSqlw)
        If oData.Count > 0 Then
            Return oData(0).ConfigValue
        Else
            Return ""
        End If
    End Function
    Friend Function GetDataConfig(sCode As String, sKey As String) As List(Of CConfig)
        Dim tSqlw As String = " WHERE ConfigCode<>'' "
        If sCode <> "" Then tSqlw &= String.Format("AND ConfigCode='{0}'", sCode)
        If sKey <> "" Then tSqlw &= String.Format("AND ConfigKey='{0}'", sKey)
        Dim oData = New CConfig(jobWebConn).GetData(tSqlw)
        Return oData
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
                            Dim i As Integer = 0
                            For i = 1 To rd.GetString(0).Length
                                If IsNumeric(rd.GetString(0).Substring(rd.GetString(0).Length - i, 1)) Then
                                    numStr = rd.GetString(0).Substring(rd.GetString(0).Length - i, 1) & numStr
                                    formatStr &= "0"
                                Else
                                    Exit For
                                End If
                            Next
                            If numStr <> "" Then
                                retStr = rd.GetString(0).Substring(0, rd.GetString(0).Length - i + 1) & Format(CLng(numStr) + 1, formatStr)
                            End If
                        End If
                    End If
                    rd.Close()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception

        End Try
        If retStr = "" Then
            Dim j As Integer = sFormat.Count(Function(c As Char) c = "_")
            retStr = Replace(sFormat, Strings.StrDup(j, "_"), Format(1, Strings.StrDup(j, "0")))
        End If
        Return retStr
    End Function
End Module
