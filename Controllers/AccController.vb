Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json

Namespace Controllers
    Public Class AccController
        Inherits CController

        ' GET: Acc
        Function Index() As ActionResult
            Return View()
        End Function
        '-----Controller-----
        Function Voucher() As ActionResult
            Return GetView("Voucher")
        End Function
        '-----Controller-----
        Function WHTax() As ActionResult
            Return GetView("WHTax")
        End Function
        Function GetVoucher() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ControlNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode ='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND ControlNo ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CVoucher(jobWebConn).GetData(tSqlw)
                Dim oHead As String = JsonConvert.SerializeObject(oData)
                Dim oSub As String = JsonConvert.SerializeObject(New CVoucherSub(jobWebConn).GetData(tSqlw))
                Dim oDoc As String = JsonConvert.SerializeObject(New CVoucherDoc(jobWebConn).GetData(tSqlw))
                Dim json = "{""voucher"":{""header"":" & oHead & ",""payment"":" & oSub & ",""document"":" & oDoc & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetVoucherHeader(<FromBody()> data As CVoucher) As ActionResult
            Try
                data.SetConnect(jobWebConn)
                If Not IsNothing(data) Then
                    If "" & data.ControlNo = "" Then
                        data.AddNew(DateTime.Now.ToString("yyMM") & "-___")
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND  ControlNo='{1}' ", data.BranchCode, data.ControlNo))
                    Dim json = "{""result"":{""data"":""" & data.ControlNo & """,""msg"":""" & msg & """}}"
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
        Function SetVoucherSub(<FromBody()> data As List(Of CVoucherSub)) As ActionResult
            Try
                Dim json As String = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                If IsNothing(data) Then
                    Return Content(json, jsonContent)
                End If
                Dim i As Integer = 0
                Dim str As String = ""
                Dim docno As String = ""
                For Each o As CVoucherSub In data
                    i = i + 1
                    docno = o.ControlNo
                    o.SetConnect(jobWebConn)
                    If o.PRVoucher = "" Then
                        o.AddNew(o.PRType & "V-" & DateTime.Today.ToString("yyMM") & "-____")
                    End If
                    If str <> "" Then str &= ","
                    str &= o.SaveData(String.Format(" WHERE BranchCode='{0}' AND  ControlNo='{1}' And ItemNo='{2}' ", o.BranchCode, o.ControlNo, o.ItemNo))
                Next
                json = "{""result"":{""msg"":""Save " & docno & " Complete!!"",""data"":""" & str & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function SetVoucherDoc(<FromBody()> data As List(Of CVoucherDoc)) As ActionResult
            Try
                Dim json As String = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                If IsNothing(data) Then
                    Return Content(json, jsonContent)
                End If
                Dim i As Integer = 0
                Dim str As String = ""
                Dim docno As String = ""
                For Each o As CVoucherDoc In data
                    i = i + 1
                    docno = o.ControlNo
                    o.SetConnect(jobWebConn)
                    If o.ItemNo = 0 Then
                        o.AddNew()
                    End If
                    Dim msg = o.SaveData(String.Format(" WHERE BranchCode='{0}' AND  ControlNo='{1}' And ItemNo='{2}' ", o.BranchCode, o.ControlNo, o.ItemNo))
                    If str <> "" Then str &= ","
                    str &= msg
                Next
                json = "{""result"":{""msg"":""Save " & docno & "Complete!!"",""data"":""" & docno & """,""error"":""" & str & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""Error!"",""error"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelVoucher() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ControlNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND ControlNo='{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""voucher"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CVoucher(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)
                If msg.Substring(0, 1) = "D" Then
                    msg = New CVoucherSub(jobWebConn).DeleteData(tSqlw)
                    msg = New CVoucherDoc(jobWebConn).DeleteData(tSqlw)
                End If
                Dim json = "{""voucher"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetWHTax() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo ='{0}' ", Request.QueryString("Code").ToString)
                End If

                Dim oDatah = New CWHTaxHeader(jobWebConn).GetData(tSqlw)
                Dim jsonh As String = JsonConvert.SerializeObject(oDatah)

                Dim oDatad = New CWHTaxDetail(jobWebConn).GetData(tSqlw)
                Dim jsond As String = JsonConvert.SerializeObject(oDatah)

                Dim jsonAll = "{""whtax"":{""header"":" & jsonh & ":""detail"":" & jsond & "}}"
                Return Content(jsonAll, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetWHTaxHeader(<FromBody()> data As CWHTaxHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    If "" & data.DocNo = "" Then
                        data.AddNew("WT-" & DateTime.Now.ToString("yyMM") & "-____")
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND DocNo='{1}' ", data.BranchCode, data.DocNo))
                    Dim json = "{""result"":{""data"":""" & data.DocNo & """,""msg"":""" & msg & """}}"
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
        Function DelWHTaxHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode Like '{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""whtax"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo Like '{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""whtax"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CWHTaxHeader(jobWebConn)
                Dim msg = New CWHTaxDetail(jobWebConn).DeleteData(tSqlw)
                msg = oData.DeleteData(tSqlw)

                Dim json = "{""whtax"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetWHTaxDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CWHTaxDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""whtaxdetail"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetWHTaxDetail(<FromBody()> data As CWHTaxDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data.DocNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If

                    data.SetConnect(jobWebConn)
                    If data.ItemNo = 0 Then
                        data.AddNew()
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND DocNo='{1}' AND ItemNo={2} ", data.BranchCode, data.DocNo, data.ItemNo))
                    Dim json = "{""result"":{""data"":""" & data.DocNo & """,""msg"":""" & msg & """}}"
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
        Function DelWHTaxDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE DocNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""whtax"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND DocNo ='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""whtax"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("ItemNo")) Then
                    tSqlw &= String.Format("AND ItemNo ='{0}' ", Request.QueryString("ItemNo").ToString)
                Else
                    Return Content("{""whtax"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CWHTaxDetail(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""whtax"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
    End Class
End Namespace