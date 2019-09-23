Imports System.Net.Http
Imports System.Web.Http
Imports Newtonsoft.Json
Public Class HomeController
    Inherits Controller
    Function Index() As ActionResult
        ViewBag.Title = "Main Page"
        ViewBag.User = "System"
        Return View()
    End Function
    Function Apps() As ActionResult
        ViewBag.Title = "Application Management"
        ViewBag.User = "System"
        Return View()
    End Function
    Function Users() As ActionResult
        ViewBag.Title = "Users Management"
        ViewBag.User = "System"
        Return View()
    End Function
    Function Customers() As ActionResult
        ViewBag.Title = "Customers Management"
        ViewBag.User = "System"
        Return View()
    End Function
    Function GetListApp() As ActionResult
        Dim oData = New CApp(Main.GetConnection()).GetData(" ORDER BY AppID")
        Dim json = JsonConvert.SerializeObject(oData)
        Return Content(json, jsonContent)
    End Function
    Function SetAppData(<FromBody()> data As CApp) As ActionResult
        data.SetConnect(Main.GetConnection())
        Return Content(data.SaveData(String.Format(" WHERE AppID='{0}'", data.AppID)), textContent)
    End Function
    Function DelAppData() As ActionResult
        Dim id As String = Request.QueryString("id").ToString
        Dim tSql As String = String.Format(" WHERE AppID='{0}'", id)
        Dim oData = New CApp(Main.GetConnection()).GetData(tSql)
        If oData.Count > 0 Then
            Return Content(oData(0).DeleteData(tSql), textContent)
        Else
            Return Content("Data Not Found", textContent)
        End If
    End Function
    Function GetUser() As ActionResult
        Try
            Dim tSqlw As String = " WHERE TWTUserID<>'' "
            If Not IsNothing(Request.QueryString("Code")) Then
                tSqlw &= String.Format("AND TWTUserID ='{0}'", Request.QueryString("Code").ToString)
            End If
            Dim oData = New CUser(Main.GetConnection()).GetData(tSqlw)
            Dim json As String = JsonConvert.SerializeObject(oData)
            json = "{""user"":{""data"":" & json & "}}"
            Return Content(json, jsonContent)
        Catch ex As Exception
            Return Content("{""user"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
        End Try
    End Function
    Function SetUser(<FromBody()> data As CUser) As ActionResult
        Try
            If Not IsNothing(data) Then
                If "" & data.TWTUserID = "" Then
                    Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                End If
                data.SetConnect(Main.GetConnection())
                Dim msg = data.SaveData(String.Format(" WHERE TWTUserID='{0}' ", data.TWTUserID))
                Dim json = "{""user"":{""data"":""" & data.TWTUserID & """,""msg"":""" & msg & """}}"
                Return Content(json, jsonContent)
            Else
                Dim json = "{""user"":{""data"":[],""msg"":""No Data To Save""}}"
                Return Content(json, jsonContent)
            End If
        Catch ex As Exception
            Dim json = "{""user"":{""data"":[],""msg"":""" & ex.Message & """}}"
            Return Content(json, jsonContent)
        End Try
    End Function
    Function DelUser() As ActionResult
        Try
            Dim tSqlw As String = " WHERE TWTUserID<>'' "
            If Not IsNothing(Request.QueryString("Code")) Then
                tSqlw &= String.Format("AND TWTUserID Like '{0}'", Request.QueryString("Code").ToString)
            Else
                Return Content("{""user"":{""msg"":""Please Select Some Data"",""data"":[]}}", jsonContent)
            End If
            Dim oData As New CUser(Main.GetConnection())
            Dim msg = oData.DeleteData(tSqlw)

            Dim json = "{""user"":{""msg"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
            Return Content(json, jsonContent)
        Catch ex As Exception
            Return Content("{""user"":{""msg"":""" & ex.Message & """,""data"":[]}}", jsonContent)
        End Try
    End Function
    Function GetCustomer() As ActionResult
        Try
            Dim tSqlw As String = " WHERE CustID<>'' "
            If Not IsNothing(Request.QueryString("Code")) Then
                tSqlw &= String.Format("AND CustID ='{0}'", Request.QueryString("Code").ToString)
            End If
            Dim oData = New CCustomer(Main.GetConnection()).GetData(tSqlw)
            Dim json As String = JsonConvert.SerializeObject(oData)
            json = "{""customer"":{""data"":" & json & "}}"
            Return Content(json, jsonContent)
        Catch ex As Exception
            Return Content("[]", jsonContent)
        End Try
    End Function
    Function SetCustomer(<FromBody()> data As CCustomer) As ActionResult
        Try
            If Not IsNothing(data) Then
                If "" & data.CustID = "" Then
                    Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                End If
                data.SetConnect(Main.GetConnection())
                Dim msg = data.SaveData(String.Format(" WHERE CustID='{0}' ", data.CustID))
                Dim json = "{""result"":{""data"":""" & data.CustID & """,""msg"":""" & msg & """}}"
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
    Function DelCustomer() As ActionResult
        Try
            Dim tSqlw As String = " WHERE CustID<>'' "
            If Not IsNothing(Request.QueryString("Code")) Then
                tSqlw &= String.Format("AND CustID Like '{0}'", Request.QueryString("Code").ToString)
            Else
                Return Content("{""customer"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
            End If
            Dim oData As New CCustomer(Main.GetConnection())
            Dim msg = oData.DeleteData(tSqlw)

            Dim json = "{""customer"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
            Return Content(json, jsonContent)
        Catch ex As Exception
            Return Content("[]", jsonContent)
        End Try
    End Function
End Class
