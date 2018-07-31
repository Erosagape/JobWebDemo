Imports System.Web.Mvc
Imports System.Xml
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
        <HttpGet()>
        Function GetAll() As ActionResult
            Return Content("Hi API is Running")
        End Function
        <HttpGet()>
        Function GetJobCount() As ActionResult
            Dim strContent As String
            Try
                Dim ds As New DataSet
                ds.ReadXml(Server.MapPath(jobDataPath))
                Using tb As DataTable = ds.Tables(0)
                    strContent = "Job Count =" & tb.Rows.Count.ToString()
                End Using
            Catch ex As Exception
                strContent = ex.Message.ToString()
            End Try
            Return Content(strContent)
        End Function
        <HttpGet()>
        Function _GetJobCount() As ActionResult
            Dim strContent As String
            Try
                Using o As New dsJobOrderTableAdapters.Job_OrderTableAdapter
                    Using tb As DataTable = o.GetData()
                        strContent = "Job Count =" & tb.Rows.Count.ToString()
                    End Using
                End Using
            Catch ex As Exception
                strContent = ex.Message.ToString()
            End Try
            Return Content(strContent)
        End Function
        <HttpGet()>
        Function _GetJobAll() As ActionResult
            Using o As New dsJobOrderTableAdapters.Job_OrderTableAdapter
                Dim lst = o.GetData().AsEnumerable().ToList()
                Return Json(lst, JsonRequestBehavior.AllowGet)
            End Using
        End Function
        <HttpGet()>
        Function GetNewJob() As ActionResult
            Return Json(New dsJobOrder.Job_OrderDataTable().ToList(), JsonRequestBehavior.AllowGet)
        End Function
        <HttpGet()>
        Function GetJobXml() As ActionResult
            Dim oXml As XmlDocument = New CXMLData(Server.MapPath(jobDataPath)).getJobXML()
            Try
                Dim str As String = oXml.InnerXml
                Return Content(str, xmlContent)
            Catch ex As Exception
                Return Content("<job><data/></job>", xmlContent)
            End Try
        End Function
        <HttpGet()>
        Function GetJobJson() As ActionResult
            Dim oXml As XmlDocument = New CXMLData(Server.MapPath(jobDataPath)).getJobXML()
            Try
                Dim str As String = JsonConvert.SerializeObject(oXml.DocumentElement)
                Return Content(str, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        <HttpGet()>
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
                Dim oData = oJob.GetData(" WHERE JobStatus<>0 " & tSqlW)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""job"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
    End Class
End Namespace