Imports System.Web.Mvc
Imports Newtonsoft.Json

Namespace Controllers
    Public Class AdvanceController
        Inherits Controller

        ' GET: Advance
        Function Index() As ActionResult
            Return View()
        End Function
        Function GetAdvance() As ActionResult
            Try
                Dim oAdvH As New CAdvHeader(jobWebConn)
                Dim oADVD As New CAdvDetail(jobWebConn)
                Dim tSqlW As String = ""
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    tSqlW &= " WHERE AdvNo='" & Request.QueryString("AdvNo") & "'"
                End If
                Dim oDataH = oAdvH.GetData(tSqlW)
                Dim oDataD = oADVD.GetData(tSqlW)
                Dim jsonh As String = JsonConvert.SerializeObject(oDataH)
                Dim jsond As String = JsonConvert.SerializeObject(oDataD)
                Dim json = "{""adv"":{""header"":" & jsonh & ",""detail"":" & jsond & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
    End Class
End Namespace