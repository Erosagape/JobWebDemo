Imports System.Web.Mvc
Imports System.Xml
Imports Newtonsoft.Json
Namespace Controllers
    Public Class JobOrderController
        Inherits Controller
        Private Const jsonContent As String = "application/json;charset=UTF-8"
        Private Const xmlContent As String = "application/xml;charset=UTF-8"
        Private Const jobDataPath As String = "~/App_Data/job_data.xml"
        Private jobWebConn As String = ConfigurationManager.ConnectionStrings("JobWebConnectionString").ConnectionString
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
                If Not IsNothing(Request.QueryString("JNo")) Then
                    tSqlW = " WHERE JNo='" & Request.QueryString("JNo") & "'"
                End If
                Dim oData = oJob.GetData(tSqlW)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""job"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
    End Class
End Namespace