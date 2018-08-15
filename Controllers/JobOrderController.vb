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
        <HttpGet>
        Function GetJobYear() As ActionResult
            Try
                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL("SELECT DISTINCT Year(DocDate) as JobYear from Job_Order")
                Dim json As String = JsonConvert.SerializeObject(oData.AsEnumerable().ToList())
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        <HttpGet>
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
        <HttpGet>
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
"
            Return Content(html, textContent)
        End Function
    End Class
End Namespace