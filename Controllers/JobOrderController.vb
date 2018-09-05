Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json
Namespace Controllers
    Public Class JobOrderController
        Inherits Controller
        Function CreateJob() As ActionResult
            Return View()
        End Function
        Function ShowJob() As ActionResult
            Return View()
        End Function
        Function CheckAPI() As ActionResult
            Return Content("Hi API is Running")
        End Function
        Function GetJobSQL() As ActionResult
            Try
                Dim oJob As New CJobOrder(jobWebConn)
                Dim tSqlW As String = ""
                If Not IsNothing(Request.QueryString("JType")) Then
                    tSqlW &= " AND JobType=" & Request.QueryString("JType") & ""
                End If
                If Not IsNothing(Request.QueryString("SBy")) Then
                    tSqlW &= " AND ShipBy=" & Request.QueryString("SBy") & ""
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlW &= " AND BranchCode='" & Request.QueryString("Branch") & "'"
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlW &= " AND JobStatus='" & Request.QueryString("Status") & "'"
                End If
                If Not IsNothing(Request.QueryString("JNo")) Then
                    tSqlW &= " AND JNo='" & Request.QueryString("JNo") & "'"
                End If
                If Not IsNothing(Request.QueryString("Year")) Then
                    tSqlW &= " AND Year(DocDate)='" & Request.QueryString("Year") & "'"
                End If
                Dim oData = oJob.GetData(" WHERE JNo<>'' " & tSqlW)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""job"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetJobYear() As ActionResult
            Try
                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL("SELECT DISTINCT Year(DocDate) as JobYear from Job_Order")
                Dim json As String = JsonConvert.SerializeObject(oData.AsEnumerable().ToList())
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetJobDataDistinct() As ActionResult
            Try
                Dim tSqlW As String = ""
                If IsNothing(Request.QueryString("Field")) Then
                    Return Content("[]", jsonContent)
                End If
                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL("SELECT DISTINCT " + Request.QueryString("Field").ToString() + " as val from Job_Order")
                Dim json As String = JsonConvert.SerializeObject(oData.AsEnumerable().ToList())
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetFormJobLOV() As ActionResult
            Dim html As String = "
            <div id=""frmSearchCurr"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchUser"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchCust"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchCons"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchProj"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchProd"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchVessel"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchMVessel"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchDType"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchCPort"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchIUnt"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchWUnt"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchCountry"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchFCountry"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchVend"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchForw"" class=""modal fade"" role=""dialog""></div>
            <div id=""frmSearchIPort"" class=""modal fade"" role=""dialog""></div>
"
            Return Content(html, textContent)
        End Function
        Function GetNewJob() As ActionResult
            Try
                Dim oJob As New CJobOrder(jobWebConn)
                Dim prefix As String = "TJOB"
                If Not IsNothing(Request.QueryString("JType")) Then
                    oJob.JobType = Convert.ToInt16("" & Request.QueryString("JType"))
                End If
                If Not IsNothing(Request.QueryString("SBy")) Then
                    oJob.ShipBy = Convert.ToInt16("" & Request.QueryString("SBy"))
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    oJob.BranchCode = "" & Request.QueryString("Branch")
                Else
                    oJob.BranchCode = "00"
                End If
                If Not IsNothing(Request.QueryString("Prefix")) Then
                    prefix = "" & Request.QueryString("Prefix")
                End If
                oJob.AddNew(prefix & DateTime.Now.ToString("yyMM") & "____")
                Dim result As String = oJob.SaveData(" WHERE BranchCode='" & oJob.BranchCode & "' And JNo='" & oJob.JNo & "'")

                Dim json As String = JsonConvert.SerializeObject(oJob)
                json = "{""job"":{""data"":" & json & ",""status"":""Y"",""result"":""" & result & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("{""job"":{""data"":[],""status"":""N"",""result"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function SaveJobData(<FromBody()> ByVal data As CJobOrder) As ActionResult
            If Not IsNothing(data) Then
                data.SetConnect(jobWebConn)
                Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND JNo='{1}'", data.BranchCode, data.JNo))
                'Dim msg = JsonConvert.SerializeObject(data)
                Return Content(msg, textContent)
            Else
                Return Content("No data to save", textContent)
            End If
        End Function
    End Class
End Namespace