Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json
Namespace Controllers
    Public Class MasterController
        Inherits Controller

        Private Function GetView(vName As String) As ActionResult
            If IsNothing(Session("CurrUser")) Then
                Session("CurrUser") = ""
            End If
            ViewBag.User = Session("CurrUser").ToString
            If ViewBag.User = "" Then
                Return Redirect("~/index.html")
            End If
            Return View(vName)
        End Function
        ' GET: Customer
        Function Index() As ActionResult
            Return GetView("Index")
        End Function
        Function ServiceCode() As ActionResult
            Return GetView("ServiceCode")
        End Function
        Function Customers() As ActionResult
            Return GetView("Customers")
        End Function
        Function Users() As ActionResult
            Return GetView("Users")
        End Function
        Function Venders() As ActionResult
            Return GetView("Venders")
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
        Function GetNewUser() As ActionResult
            Try
                Dim oData = New CUser(jobWebConn)
                oData.AddNew()
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
        Function DelUser() As ActionResult
            Try
                Dim tSqlw As String = " WHERE UserID<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND UserID Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""user"":{""result"":""Please Select Some User"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CUser(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""user"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
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
                Dim oData = New CServiceCode(jobWebConn)
                Dim msg As String = "OK"
                oData.AddNew("")
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""servicecode"":{""data"":[" & json & "],""result"":""" & msg & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetCompany(<FromBody()> data As CCompany) As ActionResult
            Try
                If Not IsNothing(data) Then
                    data.setConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE CustCode='{0}' And Branch='{1}' ", data.CustCode, data.Branch))
                    Dim json = "{""result"":{""data"":""" & data.CustCode & """,""msg"":""" & msg & """}}"
                    'Dim msg = JsonConvert.SerializeObject(data)
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, textContent)
                End If

            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, textContent)
            End Try
        End Function
        Function SetVender(<FromBody()> data As CVender) As ActionResult
            Try
                If Not IsNothing(data) Then
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE VenCode='{0}' ", data.VenCode))
                    Dim json = "{""result"":{""data"":""" & data.VenCode & """,""msg"":""" & msg & """}}"
                    'Dim msg = JsonConvert.SerializeObject(data)
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, textContent)
                End If

            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, textContent)
            End Try
        End Function
        Function SetUsers(<FromBody()> data As CUser) As ActionResult
            Try
                If Not IsNothing(data) Then
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE UserID='{0}' ", data.UserID))
                    Dim json = "{""result"":{""data"":""" & data.UserID & """,""msg"":""" & msg & """}}"
                    'Dim msg = JsonConvert.SerializeObject(data)
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, textContent)
                End If

            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, textContent)
            End Try
        End Function
        Function SetServiceCode(<FromBody()> data As CServiceCode) As ActionResult
            Try
                If Not IsNothing(data) Then
                    data.SetConnect(jobWebConn)
                    If data.SICode.ToString().Substring(data.SICode.ToString().Length - 1, 1) = "-" Then
                        data.AddNew(data.SICode + "___")
                    End If
                    Dim msg = data.SaveData(String.Format(" WHERE SICode='{0}' ", data.SICode))
                    Dim json = "{""result"":{""data"":""" & data.SICode & """,""msg"":""" & msg & """}}"
                    'Dim msg = JsonConvert.SerializeObject(data)
                    Return Content(json, jsonContent)
                Else
                    Dim json = "{""result"":{""data"":null,""msg"":""No Data To Save""}}"
                    Return Content(json, textContent)
                End If

            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, textContent)
            End Try
        End Function
    End Class
End Namespace