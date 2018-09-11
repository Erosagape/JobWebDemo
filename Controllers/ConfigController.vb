Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json

Namespace Controllers
    Public Class ConfigController
        Inherits Controller

        ' GET: Config
        Function Index() As ActionResult
            Return View()
        End Function
        Public Function SetConfig(<FromBody()> ByVal data As CConfig) As HttpResponseMessage
            If Not IsNothing(data) Then
                data.SetConnect(jobWebConn)
                data.SaveData()
                Return New HttpResponseMessage(HttpStatusCode.OK)
            Else
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End If
        End Function
        Function GetList() As ActionResult
            Try
                Dim oData = (From ds In New CConfig(jobWebConn).GetData()
                             Select
                                 ConfigCode = ds.ConfigCode).Distinct()
                Dim json As String = ""
                Dim i As Integer = 0
                For Each data As String In oData.ToArray
                    If json <> "" Then json = json & ","
                    json &= "{""Id"":""" & i.ToString("00") & """,""ConfigCode"":""" & data & """}"
                    i += 1
                Next
                json = "{""config"":{""data"":[" & json & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetConfig() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ConfigCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ConfigCode='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Key")) Then
                    tSqlw &= String.Format("AND ConfigKey='{0}'", Request.QueryString("Key").ToString)
                End If
                Dim oData = New CConfig(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""config"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetBranch() As ActionResult
            Try
                Dim tSql As String = ""
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSql = String.Format(" WHERE [Code]='{0}'", Request.QueryString("Code").ToString())
                End If
                Dim oData = New CBranch(jobWebConn).GetData(tSql)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""branch"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function ListValue() As ActionResult
            Dim Head As String = Request.QueryString("Head").ToString()
            Dim ID As String = Request.QueryString("ID").ToString()
            Dim Flds As String = Request.QueryString("FLD").ToString()
            Dim List As New List(Of String)
            If Flds.IndexOf(",") > 0 Then
                For Each Str As String In Flds.Split(",")
                    List.Add(Str)
                Next
            Else
                List.Add(Flds)
            End If
            Dim htmlStr As String = GetLOV(Head, ID, List.ToArray)
            Return Content(htmlStr, textContent)
        End Function
        Private Function GetListTable(arr As String())
            Dim html As String = ""
            For Each str As String In arr
                html &= "<th>" & str & "</th>" & vbCrLf
            Next
            Return html
        End Function
        Private Function GetLOV(captionStr As String, tblStr As String, fldList As String()) As String
            Return "
            <div class=""modal-dialog modal-lg"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal""></button>
                        <h4 class=""modal-title""><label id=""lblHeader"">Search " & captionStr & "</label></h4>
                    </div>
                    <div class=""modal-body"">
                        <table id=""" & tblStr & """ class=""table table-responsive"">
                            <thead>
                                <tr>
                                    <th>
                                    " & GetListTable(fldList) & "
                                </tr>
                            </thead>
                        </table>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
"
        End Function

    End Class
End Namespace