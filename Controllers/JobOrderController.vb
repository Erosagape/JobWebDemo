Imports System.Net
Imports System.Net.Http
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
        Function ApproveQuotation(<FromBody()> ByVal data As String()) As HttpResponseMessage
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_SALES", "QuoApprove")
                If AuthorizeStr.IndexOf("I") < 0 Then
                    Return New HttpResponseMessage(HttpStatusCode.BadRequest)
                End If

                If IsNothing(data) Then
                    Return New HttpResponseMessage(HttpStatusCode.BadRequest)
                End If

                Dim json As String = ""
                Dim lst As String = ""
                Dim user As String = ""
                For Each str As String In data
                    If str.IndexOf("|") >= 0 Then
                        If lst <> "" Then lst &= ","
                        lst &= "'" & str & "'"
                    Else
                        user = str
                    End If
                Next

                If lst <> "" Then
                    Dim tSQL As String = String.Format("UPDATE Job_QuotationHeader SET DocStatus=1,ApproveBy='" & user & "',ApproveDate='" & DateTime.Now.ToString("yyyy-MM-dd") & "',ApproveTime='" & DateTime.Now.ToString("HH:mm:ss") & "' 
 WHERE DocStatus=0 AND BranchCode+'|'+QNo in({0})", lst)
                    Dim result = Main.DBExecute(jobWebConn, tSQL)
                    If result = "OK" Then
                        Return New HttpResponseMessage(HttpStatusCode.OK)
                    End If
                End If
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            Catch ex As Exception
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End Try
        End Function
        Function Quotation() As ActionResult
            Return GetView("Quotation", "MODULE_SALES")
        End Function
        Function GetQuotation() As ActionResult
            Try
                Dim tSqlw As String = " WHERE QNo<>'' "
                If Not IsNothing(Request.QueryString("Show")) Then
                    If Request.QueryString("Show").ToString() = "ACTIVE" Then
                        tSqlw &= String.Format(" AND NOT ISNULL(CancelBy,'')<>'' ")
                    End If
                    If Request.QueryString("Show").ToString() = "CANCEL" Then
                        tSqlw &= String.Format(" AND ISNULL(CancelBy,'')<>'' ")
                    End If
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlw &= String.Format("AND DocStatus={0} ", Request.QueryString("Status").ToString)
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND QNo='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Cust")) Then
                    tSqlw &= String.Format("AND CustCode='{0}' ", Request.QueryString("Cust").ToString)
                End If
                If Not IsNothing(Request.QueryString("Sales")) Then
                    tSqlw &= String.Format("AND ManagerCode='{0}' ", Request.QueryString("Sales").ToString)
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlw &= " AND DocDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlw &= " AND DocDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                Dim oDataH = New CQuoHeader(jobWebConn).GetData(tSqlw)
                Dim jsonH As String = JsonConvert.SerializeObject(oDataH)
                Dim oDataD = New CQuoDetail(jobWebConn).GetData(tSqlw)
                Dim jsonD As String = JsonConvert.SerializeObject(oDataD)
                Dim oDataI = New CQuoItem(jobWebConn).GetData(tSqlw)
                Dim jsonI As String = JsonConvert.SerializeObject(oDataI)
                Dim json As String = "{""quotation"":{""header"":" & jsonH & ",""detail"":" & jsonD & ",""item"":" & jsonI & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetQuoHeader(<FromBody()> data As CQuoHeader) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    If "" & data.QNo = "" Then
                        data.AddNew("Q-" & DateTime.Now.ToString("yyMM") & "-____")
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND QNo='{1}' ", data.BranchCode, data.QNo))
                    Dim json = "{""result"":{""data"":""" & data.QNo & """,""msg"":""" & msg & """}}"
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
        Function DelQuoHeader() As ActionResult
            Try
                Dim tSqlw As String = " WHERE QNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""quoheader"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND QNo='{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""quoheader"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CQuoHeader(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)
                Dim oDataD As New CQuoDetail(jobWebConn)
                oDataD.DeleteData(tSqlw)
                Dim oDataI As New CQuoItem(jobWebConn)
                oDataI.DeleteData(tSqlw)
                Dim json = "{""quoheader"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetQuoDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE QNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND QNo='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Seq")) Then
                    tSqlw &= String.Format(" AND SeqNo={0}", Request.QueryString("Seq").ToString)
                End If
                Dim oData = New CQuoDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                Dim oDataD = New CQuoItem(jobWebConn).GetData(tSqlw)
                Dim jsonD As String = JsonConvert.SerializeObject(oDataD)
                json = "{""quotation"":{""detail"":" & json & ",""items"":" & jsonD & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetQuoDetail(<FromBody()> data As CQuoDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data.QNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Q.No""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND QNo='{1}' AND SeqNo={2} ", data.BranchCode, data.QNo, data.SeqNo))
                    Dim json = "{""result"":{""data"":""" & data.SeqNo & """,""msg"":""" & msg & """}}"
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
        Function DelQuoDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE QNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""quodetail"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If

                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND QNo='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""quodetail"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Seq")) Then
                    tSqlw &= String.Format(" AND SeqNo={0} ", Request.QueryString("Seq").ToString)
                End If
                Dim oData As New CQuoDetail(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)
                Dim oDataD As New CQuoItem(jobWebConn)
                oDataD.DeleteData(tSqlw)

                Dim json = "{""quodetail"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetQuoItem() As ActionResult
            Try
                Dim tSqlw As String = " WHERE QNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND QNo='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Seq")) Then
                    tSqlw &= String.Format(" AND SeqNo={0}", Request.QueryString("Seq").ToString)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format(" AND ItemNo={0}", Request.QueryString("Item").ToString)
                End If
                Dim oData = New CQuoItem(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""quotation"":{""items"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetQuoItem(<FromBody()> data As CQuoItem) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.BranchCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Branch""}}", jsonContent)
                    End If
                    If "" & data.QNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    If "" & data.SeqNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Sequence""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND QNo='{1}' And SeqNo={2} And ItemNo={3} ", data.BranchCode, data.QNo, data.SeqNo, data.ItemNo))
                    Dim json = "{""result"":{""data"":""" & data.ItemNo & """,""msg"":""" & msg & """}}"
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
        Function DelQuoItem() As ActionResult
            Try
                Dim tSqlw As String = " WHERE QNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND BranchCode='{0}'", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""quoitem"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND QNo='{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""quoitem"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Seq")) Then
                    tSqlw &= String.Format(" AND SeqNo={0} ", Request.QueryString("Seq").ToString)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format(" AND ItemNo={0} ", Request.QueryString("Item").ToString)
                End If
                Dim oData As New CQuoItem(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""quoitem"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
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
        Function GetJobDocument() As ActionResult
            Try
                Dim branch As String = ""
                Dim job As String = ""

                If Not IsNothing(Request.QueryString("Branch")) Then
                    branch = Request.QueryString("Branch").ToString()
                End If
                If Not IsNothing(Request.QueryString("Job")) Then
                    job = Request.QueryString("Job").ToString
                End If
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectDocumentByJob(branch, job))
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""job"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("{""job"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
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
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(SQLSelectJobReport() & " WHERE j.JNo<>'' " & tSqlW & " ORDER BY j.BranchCode,j.JNo")
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
                Dim oData = oJob.GetData(" WHERE JNo<>'' " & tSqlW & " ORDER BY BranchCode,DocDate DESC")
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
                    Dim oCust = New CCompany(jobWebConn).GetData(String.Format(" WHERE CustCode='{0}' AND Branch='{1}'", oJob.CustCode, oJob.CustBranch))
                    If oCust.Count > 0 Then
                        oJob.Commission = oCust(0).CommRate
                    Else
                        Return Content("{""job"":{""data"":[],""status"":""N"",""result"":""Customer '" + oJob.CustCode + "/" + oJob.CustBranch + "' Not Found!""}}", jsonContent)
                    End If
                End If
                sql &= String.Format(" AND CustCode='{0}' And CustBranch='{1}' And InvNo='{2}'", oJob.CustCode, oJob.CustBranch, oJob.InvNo)
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
                    data.AddNew(GetJobPrefix(data) & DateTime.Now.ToString("yyMM") & "____", False)
                End If
                Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND JNo='{1}'", data.BranchCode, data.JNo))
                'Dim msg = JsonConvert.SerializeObject(data)
                Return Content(msg, textContent)
            Else
                Return Content("No data to save", textContent)
            End If
        End Function
        Function UpdateJobStatus() As ActionResult
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
            Dim tResult = New CUtil(jobWebConn).ExecuteSQL(SQLUpdateJobStatus(tSqlW))
            Return Content(tResult, textContent)
        End Function
    End Class
End Namespace