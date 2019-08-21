﻿Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json

Namespace Controllers
    Public Class ConfigController
        Inherits CController
        ' GET: Config
        Function Index() As ActionResult
            Return GetView("Index", "MODULE_MAS")
        End Function
        Function UserAuth() As ActionResult
            Return GetView("UserAuth", "MODULE_MAS")
        End Function
        Function SQLAdmin() As ActionResult
            Return GetView("SQLAdmin", "MODULE_ADM")
        End Function
        Function FileManager() As ActionResult
            Return GetView("FileManager", "MODULE_ADM")
        End Function
        Function Role() As ActionResult
            Return GetView("Role", "MODULE_ADM")
        End Function
        Function GetDatabase() As ActionResult
            Dim company As String = My.MySettings.Default.LicenseTo
            Dim companyName As String = ""
            Dim oData = Main.GetDatabaseList(company, "JOBSHIPPING")
            Using tb As DataTable = Main.GetDatabaseProfile(company)
                If tb.Rows.Count > 0 Then
                    companyName = tb.Rows(0)("CustName").ToString()
                End If
            End Using
            Dim json = "{""database"":" & JsonConvert.SerializeObject(oData) & ",""company"":""" & companyName & """}"
            Return Content(json, jsonContent)
        End Function
        Function GetJSONResult(data As CResult) As ActionResult
            Dim tSQL As String = data.Source
            Dim tConn As String = ""
            Select Case data.Param
                Case "JOB"
                    tConn = jobWebConn
                Case "MAS"
                    tConn = jobMasConn
            End Select
            Dim msg As String = "No Data Execute"
            Dim fname As String = DateTime.Now.ToString("yyyyMMddHHMMss") + ".json"
            Dim path = System.IO.Path.Combine(Server.MapPath("~/"), fname)
            'Dim columns As String = "[]"
            If tConn <> "" Then
                Select Case data.Result
                    Case "Y"
                        Try
                            Dim oUtil As New CUtil(tConn)
                            Dim oTable = oUtil.GetTableFromSQL(data.Source)
                            If oTable.Columns.Count > 0 Then
                                'columns = "["
                                'For Each col As DataColumn In oTable.Columns
                                'If columns <> "[" Then columns &= ","
                                'columns &= "{""data"":""" & col.ColumnName & """,""title"":""" & col.ColumnName & """}"
                                'Next
                                'columns &= "]"
                                Dim json = "{""source"":""" & data.Source & """,""data"":" & JsonConvert.SerializeObject(oTable.Rows) & "}"
                                Dim writer = New System.IO.StreamWriter(path, False, UTF8Encoding.UTF8)
                                writer.WriteLine(json)
                                writer.Close()
                                msg = "OK (" & oTable.Rows.Count & " Rows inserted)"
                            Else
                                msg = oUtil.Message
                            End If
                        Catch ex As Exception
                            msg = "[ERROR]" & ex.Message
                        End Try
                    Case Else
                        msg = Main.DBExecute(tConn, data.Source)
                End Select
            End If
            Return Content("{""result"":{""data"":""" & fname & """,""msg"":""" + msg.Replace("\", "\\") + """}}", jsonContent)

        End Function
        Function GetSQLResult(<FromBody> data As CResult) As ActionResult
            Dim tSQL As String = data.Source
            Dim tConn As String = ""
            Select Case data.Param
                Case "JOB"
                    tConn = jobWebConn
                Case "MAS"
                    tConn = jobMasConn
            End Select
            Dim msg As String = "No Data Execute"
            Dim json As String = "[]"
            'Dim columns As String = "[]"
            If tConn <> "" Then
                Select Case data.Result
                    Case "Y"
                        Try
                            Dim oUtil As New CUtil(tConn)
                            Dim oTable = oUtil.GetTableFromSQL(data.Source)
                            If oTable.Columns.Count > 0 Then
                                'columns = "["
                                'For Each col As DataColumn In oTable.Columns
                                'If columns <> "[" Then columns &= ","
                                'columns &= "{""data"":""" & col.ColumnName & """,""title"":""" & col.ColumnName & """}"
                                'Next
                                'columns &= "]"
                                json = JsonConvert.SerializeObject(oTable.AsEnumerable().ToList())
                                msg = "OK (" & oTable.Rows.Count & " Rows selected)"
                            Else
                                msg = oUtil.Message
                            End If
                        Catch ex As Exception
                            msg = "[ERROR]" & ex.Message
                        End Try
                    Case Else
                        msg = Main.DBExecute(tConn, data.Source)
                End Select
            End If
            Return Content("{""result"":{""data"":" & json & ",""msg"":""" + msg + """}}", jsonContent)
        End Function
        Function CheckMenuAuth() As ActionResult
            Dim user As String = ""
            If IsNothing(Session("CurrUser")) = False Then
                user = Session("CurrUser").ToString()
            End If
            Dim app As String = ""
            Dim menu As String = ""
            If Not IsNothing(Request.QueryString("Code")) Then
                user = Request.QueryString("Code").ToString
            End If
            If Not IsNothing(Request.QueryString("App")) Then
                app = Request.QueryString("App").ToString
            End If
            If Not IsNothing(Request.QueryString("Menu")) Then
                menu = Request.QueryString("Menu").ToString
            End If
            Dim result = Main.GetAuthorize(user, app, menu)
            Return Content(result, textContent)
        End Function
        Function GetUserAuth() As ActionResult
            Try
                Dim tSqlw As String = " WHERE UserID<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND UserID ='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("App")) Then
                    tSqlw &= String.Format("AND AppID ='{0}' ", Request.QueryString("App").ToString)
                End If
                If Not IsNothing(Request.QueryString("Menu")) Then
                    tSqlw &= String.Format("AND MenuID ='{0}' ", Request.QueryString("Menu").ToString)
                End If
                Dim oData = New CUserAuth(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""userauth"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetUserAuth(<FromBody()> data As CUserAuth) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.UserID = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter User""}}", jsonContent)
                    End If
                    If "" & data.AppID = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter App""}}", jsonContent)
                    End If
                    If "" & data.MenuID = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Menu""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE UserID='{0}' AND AppID='{1}' AND MenuID='{2}' ", data.UserID, data.AppID, data.MenuID))
                    Dim json = "{""result"":{""data"":""" & data.UserID & """,""msg"":""" & msg & """}}"
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
        Function DelUserAuth() As ActionResult
            Try
                Dim tSqlw As String = " WHERE UserID<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND UserID = '{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""userauth"":{""result"":""Please Select User"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("App")) Then
                    tSqlw &= String.Format("AND AppID = '{0}' ", Request.QueryString("App").ToString)
                End If
                If Not IsNothing(Request.QueryString("Menu")) Then
                    tSqlw &= String.Format("AND MenuID = '{0}' ", Request.QueryString("Menu").ToString)
                End If
                Dim oData As New CUserAuth(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""userauth"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function

        Public Function SetConfig(<FromBody()> ByVal data As CConfig) As HttpResponseMessage
            If Not IsNothing(data) Then
                data.SetConnect(jobWebConn)
                data.SaveData()
                Return New HttpResponseMessage(HttpStatusCode.OK)
            Else
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End If
        End Function
        Function GetList() As ActionResult
            Try
                Dim oData = (From ds In New CConfig(jobWebConn).GetData()
                             Select
                                 ConfigCode = ds.ConfigCode).Distinct()
                Dim json As String = ""
                Dim i As Integer = 0
                For Each data As String In oData.ToArray
                    If json <> "" Then json = json & ","
                    json &= "{""Id"":""" & i.ToString("00") & """,""ConfigCode"":""" & data & """}"
                    i += 1
                Next
                json = "{""config"":{""data"":[" & json & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function DelConfig() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ConfigCode<>'' "
                tSqlw &= String.Format("AND ConfigCode='{0}'", Request.QueryString("Code").ToString)
                tSqlw &= String.Format("AND ConfigKey='{0}'", Request.QueryString("Key").ToString)
                Dim msg = New CConfig(jobWebConn).DeleteData(tSqlw)
                Dim json = "{""config"":{""result"":""" & msg & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Dim json = "{""config"":{""result"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function GetConfig() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ConfigCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ConfigCode IN('{0}')", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Prefix")) Then
                    tSqlw &= String.Format("AND ConfigCode Like '{0}'", Request.QueryString("Prefix").ToString)
                End If
                If Not IsNothing(Request.QueryString("Key")) Then
                    tSqlw &= String.Format("AND ConfigKey='{0}'", Request.QueryString("Key").ToString)
                End If
                Dim oData = New CConfig(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""config"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetBranch() As ActionResult
            Try
                Dim tSql As String = ""
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSql = String.Format(" WHERE [Code]='{0}' ORDER BY [Code]", Request.QueryString("Code").ToString())
                End If
                Dim oData = New CBranch(jobWebConn).GetData(tSql)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""branch"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function ListValue() As ActionResult
            Dim Head As String = Request.QueryString("Head").ToString()
            Dim ID As String = Request.QueryString("ID").ToString()
            Dim Flds As String = Request.QueryString("FLD").ToString()
            Dim List As New List(Of String)
            If Flds.IndexOf(",") > 0 Then
                For Each Str As String In Flds.Split(",")
                    List.Add(Str)
                Next
            Else
                List.Add(Flds)
            End If
            Dim htmlStr As String = GetLOV(Head, ID, List.ToArray)
            Return Content(htmlStr, textContent)
        End Function
        Private Function GetListTable(arr As String()) As String
            Dim html As String = ""
            For Each str As String In arr
                html &= "<th>" & str & "</th>" & vbCrLf
            Next
            Return html
        End Function
        Private Function GetLOV(captionStr As String, tblStr As String, fldList As String()) As String
            Return "
            <div class=""modal-dialog modal-lg"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal""></button>
                        <h4 class=""modal-title""><label id=""lblHeader"">Search " & captionStr & "</label></h4>
                    </div>
                    <div class=""modal-body"">
                        <table id=""" & tblStr & """ class=""table table-responsive"">
                            <thead>
                                <tr>
                                    <th>
                                    " & GetListTable(fldList) & "
                                </tr>
                            </thead>
                        </table>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">X</button>
                    </div>
                </div>
            </div>
"
        End Function
        Function GetLogin() As ActionResult
            If IsNothing(Session("CurrUser")) Then
                Session("CurrUser") = ""
            End If
            ViewBag.User = Session("CurrUser").ToString
            If IsNothing(Session("DatabaseID")) Then
                Session("DatabaseID") = "1"
            End If
            ViewBag.DATABASE = Session("DatabaseID").ToString
            Dim oData
            If ViewBag.User <> "" Then
                oData = New CUser(jobWebConn).GetData(String.Format(" WHERE UserID='{0}'", ViewBag.User))
                If oData.Count > 0 Then
                    oData = oData(0)
                Else
                    oData = New CUser(jobWebConn)
                End If
            Else
                oData = New CUser(jobWebConn)
            End If
            Dim json As String = JsonConvert.SerializeObject(oData)
            json = "{""user"":{""data"":" & json & ",""connection_job"":""" & jobWebConn.Replace("\", "\\") & """,""connection_mas"":""" & jobMasConn.Replace("\", "\\") & """,""database"":""" & ViewBag.DATABASE & """}}"
            Return Content(json, jsonContent)
        End Function
        Function SetLogOut() As ActionResult
            ViewBag.User = ""
            Session("CurrUser") = ""
            Session("UserProfiles") = Nothing
            Return Content("Y", textContent)
        End Function
        Function SetLogin() As ActionResult
            Try
                Dim dbID As String = "1"
                If Not IsNothing(Request.QueryString("Database")) Then
                    dbID = Request.QueryString("Database").ToString
                End If
                'Load Connections by Database which selected
                Dim dbConn As String() = Main.GetDatabaseConnection(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", dbID)
                Session("ConnJob") = dbConn(0)
                Session("ConnMas") = dbConn(1)
                Main.SetDatabaseMaster(Session("ConnMas").ToString)
                Main.SetDatabaseJob(Session("ConnJob").ToString)
                'check user
                Dim chk As Integer = 0
                Dim tSqlw As String = " WHERE UserID<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND UserID='{0}'", Request.QueryString("Code").ToString)
                    chk += 1
                End If
                If Not IsNothing(Request.QueryString("Pass")) Then
                    tSqlw &= String.Format("AND UPassword='{0}'", Request.QueryString("Pass").ToString)
                    chk += 1
                End If
                'Load License Name
                Using tbLicense = Main.GetDatabaseProfile(My.MySettings.Default.LicenseTo.ToString)
                    If tbLicense.Rows.Count > 0 Then
                        Session("CurrLicense") = tbLicense.Rows(0)("CustName").ToString & " / " & dbID
                    Else
                        Return Content("[]", jsonContent)
                    End If
                End Using

                Dim oData = New CUser(jobWebConn).GetData(tSqlw)
                If chk = 2 And oData.Count > 0 Then
                    Session("CurrUser") = oData(0).UserID
                    Session("UserProfiles") = oData(0)
                Else
                    Session("CurrUser") = ""
                    Session("UserProfiles") = Nothing
                End If
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""user"":{""data"":" & json & ",""database_job"":""" & jobWebConn.Replace("\", "\\") & """,""database_mas"":""" & jobMasConn.Replace("\", "\\") & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function RemovePicture() As ActionResult
            Dim path As String = ""
            If Not Request.QueryString("Path") Is Nothing Then
                path = Request.QueryString("Path").ToString
            End If
            Dim file As String = ""
            If Not Request.QueryString("Name") Is Nothing Then
                file = Request.QueryString("Name").ToString
            End If
            Dim msg As String = ""
            If file = "" Then
                msg = "No File To Delete"
            Else
                Dim files As New System.IO.DirectoryInfo(Server.MapPath("~/" + path))
                For Each f As System.IO.FileInfo In files.GetFiles(file)
                    f.Delete()
                    msg += "File " + file + " Deleted"
                Next
                If msg = "" Then
                    msg = "File " + file + " Not Found on " + path
                End If
            End If
            Return Content(msg, textContent)
        End Function
        Function ImportData() As ActionResult
            Dim path As String = ""
            If Not Request.QueryString("Path") Is Nothing Then
                path = Request.QueryString("Path").ToString
            End If
            Dim msg As String = "No data processed"
            Try
                Dim fileName = System.IO.Path.Combine(Server.MapPath("~"), path)
                Dim fReader = New System.IO.StreamReader(fileName, UTF8Encoding.UTF8)
                Dim obj = JsonConvert.DeserializeObject(Of CJsonData)(fReader.ReadToEnd)
                msg = "{""result"":"""
                Select Case obj.source
                    Case "CBranch"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CBranch)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [Code]='{0}'", oData.Code))
                        Next
                    Case "CAdvDetail"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CAdvDetail)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND AdvNo='{1}' AND ItemNo={2} ", oData.BranchCode, oData.AdvNo, oData.ItemNo))
                        Next
                    Case "CAdvHeader"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CAdvHeader)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND AdvNo='{1}' ", oData.BranchCode, oData.AdvNo))
                        Next
                    Case "CBank"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CBank)(oArr)
                            oData.SetConnect(jobMasConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [Code]='{0}' ", oData.Code))
                        Next
                    Case "CBillDetail"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CBillDetail)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND BillAcceptNo='{1}' AND ItemNo={2} ", oData.BranchCode, oData.BillAcceptNo, oData.ItemNo))
                        Next
                    Case "CBillHeader"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CBillHeader)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND BillAcceptNo='{1}' ", oData.BranchCode, oData.BillAcceptNo))
                        Next
                    Case "CBookAccount"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CBookAccount)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND BookCode='{1}' ", oData.BranchCode, oData.BookCode))
                        Next
                    Case "CBudgetPolicy"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CBudgetPolicy)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND JobType={1} AND ShipBy={2} AND SICode='{3}' ", oData.BranchCode, oData.JobType, oData.ShipBy, oData.SICode))
                        Next
                    Case "CClrDetail"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CClrDetail)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND ClrNo='{1}' AND ItemNo={2} ", oData.BranchCode, oData.ClrNo, oData.ItemNo))
                        Next
                    Case "CClrHeader"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CClrHeader)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND ClrNo='{1}' ", oData.BranchCode, oData.ClrNo))
                        Next
                    Case "CCompany"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CCompany)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [CustCode]='{0}' AND Branch='{1}' ", oData.CustCode, oData.Branch))
                        Next
                    Case "CConfig"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CConfig)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData
                        Next
                    Case "CCompanyContact"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CCompanyContact)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [CustCode]='{0}' AND [Branch]='{1}' AND ItemNo={2} ", oData.CustCode, oData.Branch, oData.ItemNo))
                        Next
                    Case "CCountry"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CCountry)(oArr)
                            oData.SetConnect(jobMasConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [CTYCODE]='{0}' ", oData.CTYCODE))
                        Next
                    Case "CCNDNHeader"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CCNDNHeader)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND DocNo='{1}' ", oData.BranchCode, oData.DocNo))
                        Next
                    Case "CCNDNDetail"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CCNDNDetail)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND DocNo='{1}' AND ItemNo='{2}' ", oData.BranchCode, oData.DocNo, oData.ItemNo))
                        Next
                    Case "CCurrency"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CCurrency)(oArr)
                            oData.SetConnect(jobMasConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [Code]='{0}' ", oData.Code))
                        Next
                    Case "CCustomsPort"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CCustomsPort)(oArr)
                            oData.SetConnect(jobMasConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [AreaCode]='{0}' ", oData.AreaCode))
                        Next
                    Case "CCustomsUnit"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CCustomsUnit)(oArr)
                            oData.SetConnect(jobMasConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [Code]='{0}' ", oData.Code))
                        Next
                    Case "CDeclareType"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CDeclareType)(oArr)
                            oData.SetConnect(jobMasConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [Type]='{0}' ", oData.Type))
                        Next
                    Case "CInterPort"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CInterPort)(oArr)
                            oData.SetConnect(jobMasConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [PortCode]='{0}' AND [CountryCode]='{1}' ", oData.PortCode, oData.CountryCode))
                        Next
                    Case "CInvDetail"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CInvDetail)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND DocNo='{1}' AND ItemNo='{2}' ", oData.BranchCode, oData.DocNo, oData.ItemNo))
                        Next
                    Case "CInvHeader"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CInvHeader)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND DocNo='{1}' ", oData.BranchCode, oData.DocNo))
                        Next
                    Case "CJobOrder"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CJobOrder)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND [JNo]='{1}' ", oData.BranchCode, oData.JNo))
                        Next
                    Case "CPayDetail"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CPayDetail)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND DocNo='{1}' AND ItemNo='{2}' ", oData.BranchCode, oData.DocNo, oData.ItemNo))
                        Next
                    Case "CPayHeader"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CPayHeader)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND DocNo='{1}' ", oData.BranchCode, oData.DocNo))
                        Next
                    Case "CQuoItem"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CQuoItem)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND QNo='{1}' AND SeqNo={2} AND ItemNo={3} ", oData.BranchCode, oData.QNo, oData.SeqNo, oData.ItemNo))
                        Next
                    Case "CQuoDetail"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CQuoDetail)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND QNo='{1}' AND SeqNo={2} ", oData.BranchCode, oData.QNo, oData.SeqNo))
                        Next
                    Case "CQuoHeader"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CQuoHeader)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND QNo='{1}' ", oData.BranchCode, oData.QNo))
                        Next
                    Case "CRcpDetail"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CRcpDetail)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND ReceiptNo='{1}' AND ItemNo={2} ", oData.BranchCode, oData.ReceiptNo, oData.ItemNo))
                        Next
                    Case "CRcpHeader"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CRcpHeader)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND ReceiptNo='{1}' ", oData.BranchCode, oData.ReceiptNo))
                        Next
                    Case "CUserRole"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CUserRole)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [RoleID]='{0}' ", oData.RoleID))
                        Next
                    Case "CUserRolePolicy"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CUserRolePolicy)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [RoleID]='{0}' AND [ModuleID]='{1}' ", oData.RoleID, oData.ModuleID))
                        Next
                    Case "CUserRoleDetail"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CUserRoleDetail)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [RoleID]='{0}' AND UserID='{1}' ", oData.RoleID, oData.UserID))
                        Next
                    Case "CServiceCode"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CServiceCode)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [SICode]='{0}' ", oData.SICode))
                        Next
                    Case "CServiceGroup"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CServiceGroup)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [GroupCode]='{0}' ", oData.GroupCode))
                        Next
                    Case "CServUnit"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CServUnit)(oArr)
                            oData.SetConnect(jobMasConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [UnitType]='{0}' ", oData.UnitType))
                        Next
                    Case "CUser"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CUser)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [UserID]='{0}' ", oData.UserID))
                        Next
                    Case "CUserAuth"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CUserAuth)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [AppID]='{0}' AND MenuID='{1}' AND UserID='{2}' ", oData.AppID, oData.MenuID, oData.UserID))
                        Next
                    Case "CVender"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CVender)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [VenCode]='{0}' ", oData.VenCode))
                        Next
                    Case "CVessel"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CVessel)(oArr)
                            oData.SetConnect(jobMasConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [RegsNumber]='{0}' ", oData.RegsNumber))
                        Next
                    Case "CVoucher"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CVoucher)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND [ControlNo]='{1}' ", oData.BranchCode, oData.ControlNo))
                        Next
                    Case "CVoucherSub"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CVoucherSub)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND [ControlNo]='{1}' AND ItemNo={2} ", oData.BranchCode, oData.ControlNo, oData.ItemNo))
                        Next
                    Case "CVoucherDoc"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CVoucherDoc)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND [ControlNo]='{1}' AND ItemNo={2}", oData.BranchCode, oData.ControlNo, oData.ItemNo))
                        Next
                    Case "CWHTaxDetail"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CWHTaxDetail)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND DocNo='{1}' AND ItemNo='{2}' ", oData.BranchCode, oData.DocNo, oData.ItemNo))
                        Next
                    Case "CWHTaxHeader"
                        For Each o In obj.data
                            Dim oArr = JsonConvert.SerializeObject(o)
                            Dim oData = JsonConvert.DeserializeObject(Of CWHTaxHeader)(oArr)
                            oData.SetConnect(jobWebConn)
                            msg &= "\n" & oData.SaveData(String.Format(" WHERE [BranchCode]='{0}' AND DocNo='{1}' ", oData.BranchCode, oData.DocNo))
                        Next
                End Select
                msg &= """}"
                Return Content(msg, jsonContent)
            Catch ex As Exception
                Return Content("{""result"":""" & ex.Message & """}", jsonContent)
            End Try
        End Function
        Function UploadJson() As ActionResult
            Dim msg As String = ""
            Dim exts As String = ".json"

            Try
                For Each fileIdx As String In Request.Files
                    Dim File As HttpPostedFileBase = Request.Files.Item(fileIdx)
                    Dim filename = System.IO.Path.GetFileName(File.FileName)
                    If File.ContentLength > 0 Then
                        If exts.IndexOf(System.IO.Path.GetExtension(filename).ToLower) >= 0 Then
                            Try
                                Dim path = System.IO.Path.Combine(Server.MapPath("~"), filename)
                                File.SaveAs(path)
                                msg = msg + "Upload " + filename + " successfully" + vbCrLf
                            Catch ex As Exception
                                msg = msg + "[Error] " + filename + "=>" + ex.Message + vbCrLf
                            End Try
                        Else
                            msg = msg + "[Error] " + filename + " Is Not allowed To upload" + vbCrLf
                        End If
                    Else
                        msg = msg + "[Error] " + filename + " cannot upload" + vbCrLf
                    End If
                Next
            Catch e As Exception
                msg = "[Error]" + e.Message
            End Try
            If msg = "" Then msg = "[Error] No File To Upload"
            Return Content(msg, textContent)
        End Function
        Function UploadPicture() As ActionResult
            Dim msg As String = ""
            Dim exts As String = ".jpg, .jpeg, .png, .bmp, .gif, .tiff, .svg"

            Try
                For Each fileIdx As String In Request.Files
                    Dim File As HttpPostedFileBase = Request.Files.Item(fileIdx)
                    Dim filename = System.IO.Path.GetFileName(File.FileName)
                    If File.ContentLength > 0 Then
                        If exts.IndexOf(System.IO.Path.GetExtension(filename).ToLower) >= 0 Then
                            Try
                                If System.IO.Directory.Exists(Server.MapPath("~/Resource/uploads")) = False Then
                                    IO.Directory.CreateDirectory(Server.MapPath("~/Resource/uploads"))
                                End If
                                Dim path = System.IO.Path.Combine(Server.MapPath("~/Resource/uploads"), filename)
                                File.SaveAs(path)
                                msg = msg + "Upload " + filename + " successfully" + vbCrLf
                            Catch ex As Exception
                                msg = msg + "[Error] " + filename + "=>" + ex.Message + vbCrLf
                            End Try
                        Else
                            msg = msg + "[Error] " + filename + " Is Not allowed to upload" + vbCrLf
                        End If
                    Else
                        msg = msg + "[Error] " + filename + " cannot upload" + vbCrLf
                    End If
                Next
            Catch e As Exception
                msg = "[Error] " + e.Message
            End Try
            If msg = "" Then msg = "[Error] No File To Upload"
            Return Content(msg, textContent)
        End Function
        Function GetFileList() As ActionResult
            Dim path As String = ""
            If Not Request.QueryString("Path") Is Nothing Then
                path = Request.QueryString("Path").ToString
            End If
            Dim ext As String = "*"
            If Not Request.QueryString("Ext") Is Nothing Then
                ext = Request.QueryString("Ext").ToString
            End If
            Dim data = JsonConvert.SerializeObject(GetUploadFiles(path, ext))
            Return Content(data, jsonContent)
        End Function
        Private Function GetUploadFiles(path As String, Optional ext As String = "*") As List(Of String)
            Dim lst As New List(Of String)
            Dim files As New System.IO.DirectoryInfo(Server.MapPath("~/" + path))
            For Each file As System.IO.FileInfo In files.GetFiles("*." + ext, IO.SearchOption.TopDirectoryOnly)
                lst.Add(file.Name)
            Next
            Return lst
        End Function
        Function GetUserRole() As ActionResult
            Try
                Dim tSqlw As String = " WHERE RoleID<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND RoleID ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CUserRole(jobWebConn).GetData(tSqlw)
                Dim oDetail = New CUserRoleDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                Dim jsonD As String = JsonConvert.SerializeObject(oDetail)
                json = "{""userrole"":{""data"":" & json & ",""detail"":" + jsonD + "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetUserRolePolicy() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ModuleID<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND RoleID ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CUserRolePolicy(jobWebConn).GetData(tSqlw)
                Dim oConfig = New CConfig(jobWebConn).GetData(" WHERE ConfigCode Like 'MODULE_%'")
                Dim jsonD = "["
                For Each oRow As CUserRolePolicy In oData
                    Dim moduleCode = Mid(oRow.ModuleID, 1, oRow.ModuleID.IndexOf("/"))
                    Dim moduleKey = Mid(oRow.ModuleID, oRow.ModuleID.IndexOf("/") + 2)
                    Dim moduleName As String = (From conf In oConfig
                                                Where conf.ConfigCode = moduleCode And conf.ConfigKey = moduleKey
                                                Select conf.ConfigValue).FirstOrDefault()

                    If jsonD <> "[" Then jsonD += ","
                    jsonD += "{""RoleID"":""" & oRow.RoleID & """,""ModuleID"":""" & oRow.ModuleID & """,""Author"":""" & oRow.Author & """,""ModuleName"":""" & moduleName & """}"
                Next
                jsonD += "]"
                Dim json As String = "{""userrole"":{""policy"":" & jsonD & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("{""userrole"":{""policy"":[],""message"":""" & ex.Message & """}}", jsonContent)
            End Try

        End Function
        Function GetUserRolePolicyTest() As ActionResult
            Try
                Dim tSqlw As String = " WHERE ModuleID<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND RoleID ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CUserRolePolicy(jobWebConn).GetData(tSqlw)
                Dim json As String = "{""userrole"":{""policy"":" & JsonConvert.SerializeObject(oData) & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("{""userrole"":{""policy"":[],""message"":""" & ex.Message & """}}", jsonContent)
            End Try

        End Function

        Function GetUserRoleDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE UserID<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND RoleID ='{0}' ", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("ID")) Then
                    tSqlw &= String.Format("AND UserID ='{0}' ", Request.QueryString("ID").ToString)
                End If
                Dim oData = New CUserRoleDetail(jobWebConn).GetData(tSqlw & " ORDER BY RoleID,UserID")
                Dim jsonD = "["
                Dim oUser = New CUser(jobWebConn).GetData(" ORDER BY UserID")
                Dim oRole = New CUserRole(jobWebConn).GetData(" ORDER BY RoleID")
                For Each oRow As CUserRoleDetail In oData
                    If jsonD <> "[" Then jsonD += ","
                    Dim userName As String = "" & oRow.UserID
                    Dim roleDescr As String = "" & oRow.RoleID
                    Try
                        userName = (From user In oUser
                                    Where user.UserID = oRow.UserID
                                    Select user.TName).FirstOrDefault()
                        roleDescr = (From role In oRole
                                     Where role.RoleID = oRow.RoleID
                                     Select role.RoleDesc).FirstOrDefault()
                    Catch ex As Exception

                    End Try
                    jsonD += "{""RoleID"":""" & oRow.RoleID & """,""UserID"":""" & oRow.UserID & """,""UserName"":""" & userName & """,""RoleDesc"":""" & roleDescr & """}"
                Next
                jsonD += "]"
                Dim json As String = "{""userrole"":{""detail"":" & jsonD & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("{""userrole"":{""msg"":" & ex.Message & "}}", jsonContent)
            End Try
        End Function
        Function SetUserRole(<FromBody()> data As CUserRole) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.RoleID = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE roleId='{0}' ", data.RoleID))
                    Dim json = "{""result"":{""data"":""" & data.RoleID & """,""msg"":""" & msg & """}}"
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
        Function SetUserRoleDetail(<FromBody()> data As CUserRoleDetail) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.RoleID = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Role""}}", jsonContent)
                    End If
                    If "" & data.UserID = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter User""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE roleId='{0}' AND userId='{1}' ", data.RoleID, data.UserID))
                    Dim log = ""
                    If msg.Substring(0, 1) = "S" Then
                        log = Main.SetAuthorizeFromRole(data.UserID)
                    End If
                    Dim json = "{""result"":{""data"":""" & data.UserID & """,""msg"":""" & msg & """,""log"":""" + log + """}}"
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save"",""log"":null}}"
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """,""log"":null}}"
                Return Content(json, jsonContent)
            End Try

        End Function
        Function SetUserRolePolicy(<FromBody()> data As CUserRolePolicy) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.RoleID = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Role""}}", jsonContent)
                    End If
                    If "" & data.ModuleID = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Module""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE RoleID='{0}' AND ModuleID='{1}' ", data.RoleID, data.ModuleID))
                    If msg.Substring(0, 1) = "S" Then
                        msg = Main.SetAuthorizeFromPolicy(data.RoleID)
                    End If
                    Dim json = "{""result"":{""data"":""" & data.ModuleID & """,""msg"":""" & msg & """}}"
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

        Function DelUserRole() As ActionResult
            Try
                Dim tSqlw As String = " WHERE roleId<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND roleId Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""userrole"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CUserRole(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""userrole"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function DelUserRoleDetail() As ActionResult
            Try
                Dim tSqlw As String = " WHERE RoleId<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND RoleId Like '{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""userrole"":{""result"":""Please Select Some Role"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("ID")) Then
                    tSqlw &= String.Format("AND UserID Like '{0}' ", Request.QueryString("ID").ToString)
                Else
                    Return Content("{""userrole"":{""result"":""Please Select Some User"",""data"":[]}}", jsonContent)
                End If

                Dim oData As New CUserRoleDetail(jobWebConn)
                oData.RoleID = Request.QueryString("Code").ToString()
                oData.UserID = Request.QueryString("ID").ToString()
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""userrole"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function DelUserRolePolicy() As ActionResult
            Try
                Dim tSqlw As String = " WHERE RoleID<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND RoleID Like '{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""userrole"":{""result"":""Please Select Some Role"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("ID")) Then
                    tSqlw &= String.Format("AND ModuleID Like '{0}' ", Request.QueryString("ID").ToString)
                Else
                    Return Content("{""userrole"":{""result"":""Please Select Some Module"",""data"":[]}}", jsonContent)
                End If

                Dim oData As New CUserRolePolicy(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""userrole"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetTable() As ActionResult
            Try
                Dim conn As String = jobWebConn
                If Not IsNothing(Request.QueryString("DB")) Then
                    If Request.QueryString("DB").ToString = "MAS" Then
                        conn = jobMasConn
                    End If
                End If
                Dim oData = New CUtil(conn).GetTableFromSQL("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' ")
                Dim json = "{""data"":" & JsonConvert.SerializeObject(oData.Rows) & ",""msg"":""""}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("{""data"":[],""msg"":""" & ex.Message & """}", jsonContent)
            End Try
        End Function
    End Class
End Namespace