Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json
Namespace Controllers
    Public Class ClrController
        Inherits CController
        ' GET: Clr
        Function Index() As ActionResult
            Return GetView("Index")
        End Function
        Function Approve() As ActionResult
            Return GetView("Approve")
        End Function
        Function Clear() As ActionResult
            Return GetView("Clear")
        End Function
        '-----Controller-----
        Function ApproveClearing() As ActionResult
            Return View()
        End Function
        Function CloseClearing() As ActionResult
            Return View()
        End Function
        Function GetClearing() As ActionResult
            Try
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
                If Not IsNothing(data) Then
                    If "" & data.ClrNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
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
                If Not IsNothing(data) Then
                    If "" & data.ClrNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    If data.ItemNo = 0 Then
                        data.AddNew()
                    End If
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