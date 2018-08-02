Imports System.Web.Mvc
Imports Newtonsoft.Json
Namespace Controllers
    Public Class MasterController
        Inherits Controller

        ' GET: Customer
        Function Index() As ActionResult
            Return View()
        End Function
        Function GetCompany() As ActionResult
            Try
                Dim tSqlw As String = " WHERE CustCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND CustCode='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND Branch='{0}'", Request.QueryString("Branch").ToString)
                End If
                Dim oData = New CCompany(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""company"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
    End Class
End Namespace