Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json
Namespace Controllers
    Public Class JobOrderController
        Inherits CController
        Function Index() As ActionResult
            Return GetView("Index", "MODULE_CS")
        End Function
        Function CreateJob() As ActionResult
            Return GetView("CreateJob", "MODULE_CS")
        End Function
        Function ShowJob() As ActionResult
            Return GetView("ShowJob", "MODULE_CS")
        End Function
        Function FormJob() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CS", "ShowJob")
            If AuthorizeStr.IndexOf("P") < 0 Then
                Return Content("You are not allow to print job", textContent)
            End If
            Return GetView("FormJob")
        End Function
        Function FormJobSum() As ActionResult
            Return GetView("FormJobSum")
        End Function
        Function FormQuotation() As ActionResult
            Return GetView("FormQuotation")
        End Function
        Function Quotation() As ActionResult
            'Return GetView("Quotation", "MODULE_SALES")
            Return RedirectToAction("FormQuotation")
        End Function
        Function QuoApprove() As ActionResult
            Return GetView("QuoApprove", "MODULE_SALES")
        End Function
        Function FormDelivery() As ActionResult
            Return GetView("FormDelivery")
        End Function
        Function Transport() As ActionResult
            'Return GetView("Transport", "MODULE_CS")
            Return RedirectToAction("FormDelivery")
        End Function
        Function FormTransport() As ActionResult
            Return GetView("FormTransport")
        End Function
        Function CheckAPI() As ActionResult
            Return Content("Hi API is Running")
        End Function
        Function GetJobReport() As ActionResult
            Try
                Dim tSqlW As String = ""
                If Not IsNothing(Request.QueryString("JType")) Then
                    tSqlW &= " AND j.JobType=" & Request.QueryString("JType") & ""
                End If
                If Not IsNothing(Request.QueryString("SBy")) Then
                    tSqlW &= " AND j.ShipBy=" & Request.QueryString("SBy") & ""
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlW &= " AND j.BranchCode='" & Request.QueryString("Branch") & "'"
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlW &= " AND j.JobStatus='" & Request.QueryString("Status") & "'"
                End If
                If Not IsNothing(Request.QueryString("JNo")) Then
                    tSqlW &= " AND j.JNo='" & Request.QueryString("JNo") & "'"
                End If
                If Not IsNothing(Request.QueryString("Year")) Then
                    tSqlW &= " AND Year(j.DocDate)='" & Request.QueryString("Year") & "'"
                End If
                If Not IsNothing(Request.QueryString("Month")) Then
                    tSqlW &= " AND Month(j.DocDate)='" & Request.QueryString("Month") & "'"
                End If
                If Not IsNothing(Request.QueryString("CustCode")) Then
                    tSqlW &= " AND j.CustCode='" & Request.QueryString("CustCode") & "'"
                End If
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    tSqlW &= " AND j.CustCode IN(SELECT CustCode FROM Mas_Company WHERE TaxNumber='" & Request.QueryString("TaxNumber") & "')"
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectJobReport() & " WHERE j.JNo<>'' " & tSqlW)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""job"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
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
                If Not IsNothing(Request.QueryString("Month")) Then
                    tSqlW &= " AND Month(DocDate)='" & Request.QueryString("Month") & "'"
                End If
                If Not IsNothing(Request.QueryString("CustCode")) Then
                    tSqlW &= " AND CustCode='" & Request.QueryString("CustCode") & "'"
                End If
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    tSqlW &= " AND CustCode IN(SELECT CustCode FROM Mas_Company WHERE TaxNumber='" & Request.QueryString("TaxNumber") & "')"
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
                Dim prefix As String = jobPrefix
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
                If Not IsNothing(Request.QueryString("Inv")) Then
                    oJob.InvNo = "" & Request.QueryString("Inv")
                End If
                Dim sql As String = String.Format(" WHERE BranchCode='{0}' AND JobType='{1}' AND ShipBy='{2}' ", oJob.BranchCode, oJob.JobType, oJob.ShipBy)
                If Not IsNothing(Request.QueryString("Cust")) Then
                    oJob.CustCode = "" & Request.QueryString("Cust").Split("|")(0)
                    oJob.CustBranch = "" & Request.QueryString("Cust").Split("|")(1)
                End If
                sql = sql + String.Format(" AND CustCode='{0}' And CustBranch='{1}' And InvNo='{2}'", oJob.CustCode, oJob.CustBranch, oJob.InvNo)
                Dim FindJob = oJob.GetData(sql)
                If FindJob.Count > 0 Then
                    Return Content("{""job"":{""data"":[],""status"":""N"",""result"":""invoice '" + oJob.InvNo + "' has been opened for job '" + FindJob(0).JNo + "' ""}}", jsonContent)
                End If

                Dim CopyFrom As String = ""
                If Not IsNothing(Request.QueryString("CopyFrom")) Then
                    CopyFrom = "" & Request.QueryString("CopyFrom")
                End If
                If CopyFrom <> "" Then
                    FindJob = oJob.GetData(String.Format(" WHERE BranchCode='{0}' AND JNo='{1}'", oJob.BranchCode, CopyFrom))
                    If FindJob.Count > 0 Then
                        oJob = FindJob(0)
                    End If
                End If
                oJob.AddNew(prefix & DateTime.Now.ToString("yyMM") & "____", IIf(CopyFrom <> "", False, True))
                Dim result As String = oJob.SaveData(" WHERE BranchCode='" & oJob.BranchCode & "' And JNo='" & oJob.JNo & "'")

                Dim json As String = JsonConvert.SerializeObject(oJob)
                json = "{""job"":{""data"":" & json & ",""status"":""Y"",""result"":""" + result + """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("{""job"":{""data"":[],""status"":""N"",""result"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function SaveJobData(<FromBody()> ByVal data As CJobOrder) As ActionResult
            If Not IsNothing(data) Then
                data.SetConnect(jobWebConn)
                If data.JNo = "" Then
                    data.AddNew(jobPrefix & DateTime.Now.ToString("yyMM") & "____", False)
                End If
                Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND JNo='{1}'", data.BranchCode, data.JNo))
                'Dim msg = JsonConvert.SerializeObject(data)
                Return Content(msg, textContent)
            Else
                Return Content("No data to save", textContent)
            End If
        End Function
    End Class
End Namespace