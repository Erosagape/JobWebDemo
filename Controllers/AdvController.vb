Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json

Namespace Controllers
    Public Class AdvController
        Inherits Controller
        Private Function GetView(vName As String) As ActionResult
            If IsNothing(Session("CurrUser")) Then
                Session("CurrUser") = ""
            End If
            ViewBag.User = Session("CurrUser").ToString
            If ViewBag.User = "" Then
                Return Redirect("~/index.html")
            End If
            Return View(vName)
        End Function
        ' GET: Advance
        Function Index() As ActionResult
            Return GetView("Index")
        End Function
        Function FormAdv() As ActionResult
            Return View()
        End Function
        Function SaveAdvanceHeader(<FromBody()> ByVal data As CAdvHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    data.SetConnect(jobWebConn)
                    If data.AdvNo = "" Then
                        data.AddNew(advPrefix & "-" & DateTime.Now.ToString("yyMM") & "____")
                    End If
                    Dim msg As String = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND AdvNo='{1}'", data.BranchCode, data.AdvNo))
                    'Dim msg = JsonConvert.SerializeObject(data)
                    Dim json = "{""result"":{""data"":""" & data.AdvNo & """,""msg"":""" & msg & """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, jsonContent)
                End If

            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" + ex.Message + """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function SaveAdvanceDetail(<FromBody()> ByVal data As CAdvDetail) As ActionResult
            If Not IsNothing(data) Then
                data.SetConnect(jobWebConn)
                If data.ItemNo = 0 Then
                    data.AddNew()
                End If
                Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND AdvNo='{1}' AND ItemNo={2} ", data.BranchCode, data.AdvNo, data.ItemNo))
                'Dim msg = JsonConvert.SerializeObject(data)
                Dim json = "{""result"":{""data"":""" & data.ItemNo & """,""msg"":""" & msg & """}}"
                Return Content(json, jsonContent)
            Else
                Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                Return Content(json, jsonContent)
            End If
        End Function
        Function DelAdvanceDetail() As ActionResult
            Try
                Dim oADVD As New CAdvDetail(jobWebConn)
                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If
                Dim tSqlW As String = String.Format(" WHERE BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    tSqlW &= " AND AdvNo='" & Request.QueryString("AdvNo") & "'"
                End If
                Dim ItemNo As String = "0"
                If Not IsNothing(Request.QueryString("ItemNo")) Then
                    ItemNo = Request.QueryString("ItemNo")
                End If
                tSqlW &= " AND ItemNo=" & ItemNo & ""
                Dim msg As String = oADVD.DeleteData(tSqlW)
                Dim json = "{""adv"":{""result"":""" & msg & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Dim json = "{""adv"":{""result"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function DelAdvanceHeader() As ActionResult
            Try
                Dim oAdvH As New CAdvHeader(jobWebConn)
                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If
                Dim tSqlW As String = String.Format(" WHERE BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    tSqlW &= " AND AdvNo='" & Request.QueryString("AdvNo") & "'"
                End If
                Dim msg As String = oAdvH.DeleteData(tSqlW)
                Dim oAdvD As New CAdvDetail(jobWebConn)
                Dim msgD As String = oAdvD.DeleteData(tSqlW)
                Dim json = "{""adv"":{""result"":""" & msg & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Dim json = "{""adv"":{""result"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function GetNewAdvanceHeader() As ActionResult
            Try
                Dim oAdvH As New CAdvHeader(jobWebConn)
                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If
                oAdvH.BranchCode = Branch
                oAdvH.AdvNo = ""
                oAdvH.AdvDate = DateTime.Today
                Dim oAdvD As New CAdvDetail(jobWebConn)
                oAdvD.BranchCode = Branch
                oAdvD.AdvNo = ""
                oAdvD.ItemNo = 0
                'Dim msg As String = oAdvH.SaveData(String.Format(" WHERE BranchCode='{0}' AND AdVNo='{1}'", oAdvH.BranchCode, oAdvH.AdvNo))
                Dim jsonh As String = JsonConvert.SerializeObject(oAdvH)
                Dim jsond As String = JsonConvert.SerializeObject(oAdvD)
                Dim json = "{""adv"":{""header"":" & jsonh & ",""detail"":" & jsond & ",""result"":""OK""}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetNewAdvanceDetail() As ActionResult
            Try
                Dim oAdvD As New CAdvDetail(jobWebConn)
                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If
                Dim AdvNo As String = ""
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    AdvNo = Request.QueryString("AdvNo")
                End If
                oAdvD.BranchCode = Branch
                oAdvD.AdvNo = AdvNo
                oAdvD.ItemNo = 0
                'Dim msg As String = oAdvD.SaveData(String.Format(" WHERE BranchCode='{0}' And AdvNo='{1}' And ItemNo={2}", oAdvD.BranchCode, oAdvD.AdvNo, oAdvD.ItemNo))
                Dim jsonh As String = JsonConvert.SerializeObject(oAdvD)
                Dim json = "{""adv"":{""detail"":" & jsonh & ",""result"":""OK""}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetAdvanceGrid() As ActionResult
            Try
                Dim Branch As String = ""
                Dim JobNo As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If
                Dim tSqlW As String = String.Format(" WHERE a.BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("JobNo")) Then
                    tSqlW &= " AND a.AdvNo IN(SELECT AdvNo FROM Job_AdvDetail WHERE BranchCode='" & Branch & "' And ForJNo='" & Request.QueryString("JobNo") & "')"
                End If
                Dim sql As String = "
select a.*,
(SELECT STUFF((
SELECT DISTINCT ',' + ForJNo
FROM Job_AdvDetail WHERE BranchCode=a.BranchCode
AND AdvNo=a.AdvNo AND ForJNo<>'' 
FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
)) as JobNo
FROM Job_AdvHeader as a
"
                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL(sql + tSqlW)
                Dim json As String = JsonConvert.SerializeObject(oData.AsEnumerable().ToList())
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetAdvance() As ActionResult
            Try
                Dim oAdvH As New CAdvHeader(jobWebConn)
                Dim oADVD As New CAdvDetail(jobWebConn)
                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If
                Dim tSqlW As String = String.Format(" WHERE BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    tSqlW &= " AND AdvNo='" & Request.QueryString("AdvNo") & "'"
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
        Function GetAdvanceDetail() As ActionResult
            Try
                Dim oADVD As New CAdvDetail(jobWebConn)
                Dim Branch As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If
                Dim tSqlW As String = String.Format(" WHERE BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("AdvNo")) Then
                    tSqlW &= " AND AdvNo='" & Request.QueryString("AdvNo") & "'"
                End If
                Dim oDataD = oADVD.GetData(tSqlW)
                Dim jsond As String = JsonConvert.SerializeObject(oDataD)
                Dim json = "{""adv"":{""detail"":" & jsond & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
    End Class
End Namespace