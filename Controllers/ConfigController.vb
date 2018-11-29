Imports System.Net
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
                    tSql = String.Format(" WHERE [Code]='{0}'", Request.QueryString("Code").ToString())
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
                        <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
"
        End Function
        Function GetLogin() As ActionResult
            If IsNothing(Session("CurrUser")) Then
                Session("CurrUser") = ""
            End If
            ViewBag.User = Session("CurrUser")
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
            json = "{""user"":{""data"":" & json & "}}"
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
                Dim oData = New CUser(jobWebConn).GetData(tSqlw)
                If chk = 2 And oData.Count > 0 Then
                    ViewBag.User = oData(0).UserID
                    Session("CurrUser") = ViewBag.User
                    Session("UserProfiles") = oData(0)
                Else
                    ViewBag.User = ""
                    Session("CurrUser") = ""
                    Session("UserProfiles") = Nothing
                End If
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""user"":{""data"":" & json & "}}"
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
        Function UploadPicture() As ActionResult
            Dim msg As String = ""
            Dim exts As String = ".jpg,.jpeg,.png,.bmp,.gif,.tiff,.svg"

            Try
                For Each fileIdx As String In Request.Files
                    Dim File As HttpPostedFileBase = Request.Files.Item(fileIdx)
                    Dim filename = System.IO.Path.GetFileName(File.FileName)
                    If File.ContentLength > 0 Then
                        If exts.IndexOf(System.IO.Path.GetExtension(filename).ToLower) >= 0 Then
                            Try
                                Dim path = System.IO.Path.Combine(Server.MapPath("~/Resource/uploads"), filename)
                                File.SaveAs(path)
                                msg = msg + "Upload " + filename + " successfully" + vbCrLf
                            Catch ex As Exception
                                msg = msg + "[Error]" + filename + "=>" + ex.Message + vbCrLf
                            End Try
                        Else
                            msg = msg + "[Error]" + filename + " is not allowed to upload" + vbCrLf
                        End If
                    Else
                        msg = msg + "[Error]" + filename + " cannot upload" + vbCrLf
                    End If
                Next
            Catch e As Exception
                msg = "[Error]" + e.Message
            End Try
            If msg = "" Then msg = "No File To Upload"
            Return Content(msg, textContent)
        End Function
        Function FileManager() As ActionResult
            Return View()
        End Function
        Function GetFileList() As ActionResult
            Dim path As String = ""
            If Not Request.QueryString("Path") Is Nothing Then
                path = Request.QueryString("Path").ToString
            End If
            Dim data = JsonConvert.SerializeObject(GetUploadFiles(path))
            Return Content(data, jsonContent)
        End Function
        Private Function GetUploadFiles(path As String) As List(Of String)
            Dim lst As New List(Of String)
            Dim files As New System.IO.DirectoryInfo(Server.MapPath("~/" + path))
            For Each file As System.IO.FileInfo In files.GetFiles("*.*", IO.SearchOption.AllDirectories)
                lst.Add(file.Name)
            Next
            Return lst
        End Function
    End Class
End Namespace