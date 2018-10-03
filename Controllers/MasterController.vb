Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json
Namespace Controllers
    Public Class MasterController
        Inherits Controller
        Private Sub CheckSession()
            If IsNothing(Session("CurrUser")) Then
                Session("CurrUser") = ""
            End If
            ViewBag.User = Session("CurrUser")
        End Sub
        Private Function GetView(vName As String) As ActionResult
            If IsNothing(Session("CurrUser")) Then
                Return View("Index")
            End If
            Return View(vName)
        End Function
        ' GET: Customer
        Function Index() As ActionResult
            CheckSession()
            Return View()
        End Function
        Function ServiceCode() As ActionResult
            CheckSession()
            Return GetView("ServiceCode")
        End Function
        Function GetServUnit() As ActionResult
            Try
                Dim tSqlw As String = " WHERE [UnitType]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [UnitType]='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CServUnit(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""servunit"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try

        End Function
        Function GetCustomsPort() As ActionResult
            Try
                Dim tSqlw As String = " WHERE [AreaCode]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [AreaCode]='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CCustomsPort(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""RFARS"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try

        End Function
        Function GetDeclareType() As ActionResult
            Try
                Dim tSqlw As String = " WHERE [Type]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Type]='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CDeclareType(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""RFDCT"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try

        End Function

        Function GetCurrency() As ActionResult
            Try
                Dim tSqlw As String = " WHERE [Code]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Code]='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CCurrency(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""currency"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try

        End Function
        Function GetUser() As ActionResult
            Try
                Dim tSqlw As String = " WHERE UserID<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND UserID='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Pass")) Then
                    tSqlw &= String.Format("AND UPassword='{0}'", Request.QueryString("Pass").ToString)
                End If
                Dim oData = New CUser(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""user"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetCountry() As ActionResult
            Try
                Dim tSqlw As String = " WHERE CTYCODE<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND CTYCODE='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CCountry(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""country"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetCompany() As ActionResult
            Try
                Dim tSqlw As String = " WHERE CustCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND CustCode='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND Branch='{0}'", Request.QueryString("Branch").ToString)
                End If
                Dim oData = New CCompany(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""company"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetVender() As ActionResult
            Try
                Dim tSqlw As String = " WHERE VenCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND VenCode='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CVender(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""vender"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetInterPort() As ActionResult
            Try
                Dim tSqlw As String = " WHERE CountryCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND PortCode='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Key")) Then
                    tSqlw &= String.Format("AND CountryCode='{0}'", Request.QueryString("Key").ToString)
                End If
                Dim oData = New CInterPort(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""interport"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function DelServiceCode() As ActionResult
            Try
                Dim tSqlw As String = " WHERE SICode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND SICode Like '{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData As New CServiceCode(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""servicecode"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetServiceCode() As ActionResult
            Try
                Dim tSqlw As String = " WHERE SICode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND SICode Like '{0}%'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CServiceCode(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""servicecode"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetNewServiceCode() As ActionResult
            Try
                Dim Code As String = "SNG-"
                If Not IsNothing(Request.QueryString("Code")) Then
                    Code = Request.QueryString("Code").ToString
                End If
                Dim IsSave As String = "Y"
                If Not IsNothing(Request.QueryString("Save")) Then
                    IsSave = Request.QueryString("Save").ToString
                End If
                Dim oData = New CServiceCode(jobWebConn)
                Dim msg As String = "OK"
                If IsSave = "Y" Then
                    oData.AddNew(Code & "___")
                    msg = oData.SaveData(String.Format(" WHERE SICode='{0}' ", oData.SICode))
                End If

                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""servicecode"":{""data"":[" & json & "],""result"":""" & msg & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetServiceCode(<FromBody()> data As CServiceCode) As ActionResult
            If Not IsNothing(data) Then
                data.SetConnect(jobWebConn)
                Dim msg = data.SaveData(String.Format(" WHERE SICode='{0}' ", data.SICode))
                'Dim msg = JsonConvert.SerializeObject(data)
                Return Content(msg, textContent)
            Else
                Return Content("No data to save", textContent)
            End If
        End Function
    End Class
End Namespace