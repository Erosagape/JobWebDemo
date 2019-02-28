Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json
Namespace Controllers
    Public Class ClrController
        Inherits CController
        ' GET: Clr
        Function Index() As ActionResult
            Return GetView("Index", "MODULE_CLR")
        End Function
        Function Approve() As ActionResult
            Return GetView("Approve", "MODULE_CLR")
        End Function
        Function Receive() As ActionResult
            Return GetView("Receive", "MODULE_CLR")
        End Function
        Function Costing() As ActionResult
            Return View()
        End Function
        Function GenerateInv() As ActionResult
            Return View()
        End Function
        Function Earnest() As ActionResult
            Return View()
        End Function

        '-----Controller-----
        Function ApproveClearing() As HttpResponseMessage
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Approve")
            If AuthorizeStr.IndexOf("I") < 0 Then
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End If
            Return New HttpResponseMessage(HttpStatusCode.OK)
        End Function
        Function ReceiveClearing() As HttpResponseMessage
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
            If AuthorizeStr.IndexOf("I") < 0 Then
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End If
            Return New HttpResponseMessage(HttpStatusCode.OK)
        End Function
        Function GetClearing() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""clr"":{""header"":[],""detail"":[],""msg"":""You are not authorize to read""}}", jsonContent)
                End If

                Dim tSqlw As String = " WHERE ClrNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ClrNo ='{0}' ", Request.QueryString("Code").ToString)
                End If

                Dim oData = New CClrHeader(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)

                Dim oDataD = New CClrDetail(jobWebConn).GetData(tSqlw)
                Dim jsonD As String = JsonConvert.SerializeObject(oDataD)

                json = "{""clr"":{""header"":" & json & ",""detail"":" & jsonD & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetClrHeader(<FromBody()> data As CClrHeader) As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("E") < 0 Then
                    Return Content("{""result"":{""data"":[],""msg"":""You are not authorize to edit""}}", jsonContent)
                End If

                If Not IsNothing(data) Then
                    data.SetConnect(jobWebConn)
                    If "" & data.ClrNo = "" Then
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            Return Content("{""result"":{""data"":[],""msg"":""You are not authorize to add""}}", jsonContent)
                        End If
                        data.AddNew(clrPrefix & DateTime.Now.ToString("yyMM") & "-_____")
                    End If

                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND ClrNo='{1}' ", data.BranchCode, data.ClrNo))

                    Dim json = "{""result"":{""data"":""" & data.ClrNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelClearing() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("D") < 0 Then
                    Return Content("{""clr"":{""data"":[],""result"":""You are not authorize to delete""}}", jsonContent)
                End If

                Dim tSqlw As String = " WHERE ClrNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If

                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ClrNo ='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If

                Dim oDataD As New CClrDetail(jobWebConn)
                Dim msg = oDataD.DeleteData(tSqlw)

                Dim oData As New CClrHeader(jobWebConn)
                msg = oData.DeleteData(tSqlw)

                Dim json = "{""clr"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetClrDetail() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""clr"":{""detail"":[],""msg"":""You are not authorize to read""}}", jsonContent)
                End If

                Dim tSqlw As String = " WHERE ClrNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ClrNo ='{0}' ", Request.QueryString("Code").ToString)
                End If

                Dim oData = New CClrDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""clr"":{""detail"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetClrDetail(<FromBody()> data As CClrDetail) As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("E") < 0 Then
                    Return Content("{""result"":{""data"":[],""msg"":""You are not authorize to edit""}}", jsonContent)
                End If

                If Not IsNothing(data) Then
                    If "" & data.ClrNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    If data.ItemNo = 0 Then
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            Return Content("{""result"":{""data"":[],""msg"":""You are not authorize to add""}}", jsonContent)
                        End If
                    End If

                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND ClrNo='{1}' AND ItemNo={2} ", data.BranchCode, data.ClrNo, data.ItemNo))
                    Dim json = "{""result"":{""data"":""" & data.ClrNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelClrDetail() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("D") < 0 Then
                    Return Content("{""clr"":{""data"":[],""result"":""You are not authorize to delete""}}", jsonContent)
                End If

                Dim tSqlw As String = " WHERE ClrNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ClrNo ='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format("AND ItemNo ={0} ", Request.QueryString("Item").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Item"",""data"":[]}}", jsonContent)
                End If

                Dim oData As New CClrDetail(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""clr"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
    End Class
End Namespace