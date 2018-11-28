﻿Imports System.Web.Http
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
        Function Branch() As ActionResult
            Return GetView("Branch")
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
        Function Country() As ActionResult
            Return GetView("Country")
        End Function
        Function ServUnit() As ActionResult
            Return GetView("ServUnit")
        End Function
        Function DeclareType() As ActionResult
            Return GetView("DeclareType")
        End Function
        Function CustomsPort() As ActionResult
            Return GetView("CustomsPort")
        End Function
        Function InterPort() As ActionResult
            Return GetView("InterPort")
        End Function
        Function GetInterPort() As ActionResult
            Try
                Dim tSqlw As String = " WHERE PortCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND PortCode ='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Key")) Then
                    tSqlw &= String.Format(" AND CountryCode ='{0}'", Request.QueryString("Key").ToString)
                End If
                Dim oData = New CInterPort(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""interport"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetInterPort(<FromBody()> data As CInterPort) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.PortCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Port Code""}}", jsonContent)
                    End If
                    If "" & data.CountryCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Country Code""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE PortCode='{0}' AND CountryCode='{1}' ", data.PortCode, data.CountryCode))
                    Dim json = "{""result"":{""data"":""" & data.PortCode & """,""msg"":""" & msg & """}}"
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
        Function DelInterPort() As ActionResult
            Try
                Dim tSqlw As String = " WHERE PortCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND PortCode Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""interport"":{""result"":""Please Select Port Code"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Key")) Then
                    tSqlw &= String.Format(" AND CountryCode Like '{0}'", Request.QueryString("Key").ToString)
                Else
                    Return Content("{""interport"":{""result"":""Please Select Country Code"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CInterPort(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""interport"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function

        Function GetCustomsPort() As ActionResult
            Try

                Dim tSqlw As String = " WHERE AreaCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND AreaCode ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CCustomsPort(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""RFARS"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)

            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetCustomsPort(<FromBody()> data As CCustomsPort) As ActionResult

            Try
                If Not IsNothing(data) Then
                    If "" & data.AreaCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE AreaCode='{0}' ", data.AreaCode))
                    Dim json = "{""result"":{""data"":""" & data.AreaCode & """,""msg"":""" & msg & """}}"
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
        Function DelCustomsPort() As ActionResult

            Try
                Dim tSqlw As String = " WHERE AreaCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND AreaCode Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""RFARS"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CCustomsPort(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""RFARS"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try

        End Function
        Function SetDeclareType(<FromBody()> data As CDeclareType) As ActionResult

            Try
                If Not IsNothing(data) Then
                    If "" & data.Type = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE Type='{0}' ", data.Type))
                    Dim json = "{""result"":{""data"":""" & data.Type & """,""msg"":""" & msg & """}}"
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
        Function DelDeclareType() As ActionResult

            Try
                Dim tSqlw As String = " WHERE Type<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND Type Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""RFDCT"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CDeclareType(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""RFDCT"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try

        End Function
        Function GetServUnit() As ActionResult
            Try

                Dim tSqlw As String = " WHERE UnitType<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND UnitType ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CServUnit(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""servunit"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)

            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetServUnit(<FromBody()> data As CServUnit) As ActionResult

            Try
                If Not IsNothing(data) Then
                    If "" & data.UnitType = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE UnitType='{0}' ", data.UnitType))
                    Dim json = "{""result"":{""data"":""" & data.UnitType & """,""msg"":""" & msg & """}}"
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
        Function DelServUnit() As ActionResult

            Try
                Dim tSqlw As String = " WHERE UnitType<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND UnitType Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""servunit"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CServUnit(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""servunit"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
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
        Function Currency() As ActionResult
            Return GetView("Currency")
        End Function
        Function SetCurrency(<FromBody()> data As CCurrency) As ActionResult

            Try
                If Not IsNothing(data) Then
                    If "" & data.Code = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE [Code]='{0}' ", data.Code))
                    Dim json = "{""result"":{""data"":""" & data.Code & """,""msg"":""" & msg & """}}"
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
        Function DelCurrency() As ActionResult

            Try
                Dim tSqlw As String = " WHERE [Code]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Code] ='{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""currency"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CCurrency(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""currency"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
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
        Function GetNewCompany() As ActionResult
            Try
                Dim oData = New CCompany(jobWebConn)
                oData.AddNew()
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""company"":{""data"":" & json & "}}"
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
        Function GetNewVender() As ActionResult
            Try
                Dim oData = New CVender(jobWebConn)
                oData.AddNew()
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""vender"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetCountry() As ActionResult
            Try
                Dim tSqlw As String = " WHERE CTYCODE<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND CTYCODE ='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CCountry(jobMasConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""country"":{""data"":" & json & "}}"
                Return Content(json, jsonContent)

            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetCountry(<FromBody()> data As CCountry) As ActionResult

            Try
                If Not IsNothing(data) Then
                    If "" & data.CTYCODE = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobMasConn)
                    Dim msg = data.SaveData(String.Format(" WHERE CTYCODE='{0}' ", data.CTYCODE))
                    Dim json = "{""result"":{""data"":""" & data.CTYCODE & """,""msg"":""" & msg & """}}"
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
        Function DelCountry() As ActionResult

            Try
                Dim tSqlw As String = " WHERE CTYCODE<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND CTYCODE Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""country"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CCountry(jobMasConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""country"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try

        End Function
        Function GetCompany() As ActionResult
            Try
                Dim tSqlw As String = " WHERE CustCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND CustCode='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format(" AND Branch='{0}'", Request.QueryString("Branch").ToString)
                End If
                Dim oData = New CCompany(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""company"":{""data"":" & json & "},""sql"":""" & tSqlw & """}"
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
        Function _GetInterPort() As ActionResult
            Try
                Dim tSqlw As String = " WHERE CountryCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format(" AND PortCode='{0}'", Request.QueryString("Code").ToString)
                End If
                If Not IsNothing(Request.QueryString("Key")) Then
                    tSqlw &= String.Format(" AND CountryCode='{0}'", Request.QueryString("Key").ToString)
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
        Function DelVender() As ActionResult
            Try
                Dim tSqlw As String = " WHERE VenCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND VenCode Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""vender"":{""result"":""Please Select Some Vender"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CVender(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""vender"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function DelCompany() As ActionResult
            Try
                Dim tSqlw As String = " WHERE CustCode<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND CustCode = '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""company"":{""result"":""Please Select Some Customer"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND Branch = '{0}'", Request.QueryString("Branch").ToString)
                End If
                Dim oData As New CCompany(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""company"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
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
                    If "" & data.CustCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter CustCode""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE CustCode='{0}' And Branch='{1}' ", data.CustCode, data.Branch))
                    Dim json = "{""result"":{""data"":""" & data.CustCode & """,""msg"":""" & msg & """}}"
                    'Dim msg = JsonConvert.SerializeObject(data)
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
        Function SetVender(<FromBody()> data As CVender) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.VenCode = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Vender Code""}}", jsonContent)
                    End If

                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE VenCode='{0}' ", data.VenCode))
                    Dim json = "{""result"":{""data"":""" & data.VenCode & """,""msg"":""" & msg & """}}"
                    'Dim msg = JsonConvert.SerializeObject(data)
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
        Function SetUser(<FromBody()> data As CUser) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.UserID = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter User ID""}}", jsonContent)
                    End If

                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE UserID='{0}' ", data.UserID))
                    Dim json = "{""result"":{""data"":""" & data.UserID & """,""msg"":""" & msg & """}}"
                    'Dim msg = JsonConvert.SerializeObject(data)
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
                    Return Content(json, jsonContent)
                End If

            Catch ex As Exception
                Dim json = "{""result"":{""data"":null,""msg"":""" & ex.Message & """}}"
                Return Content(json, jsonContent)
            End Try
        End Function
        Function GetBranch() As ActionResult
            Try
                Dim tSqlw As String = " WHERE [Code]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Code]='{0}'", Request.QueryString("Code").ToString)
                End If
                Dim oData = New CBranch(jobWebConn).GetData("SELECT * FROM Mas_Branch " & tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""branch"":{""data"":""" & json & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetBranch(<FromBody()> data As CBranch) As ActionResult
            Try
                If Not IsNothing(data) Then
                    If "" & data.Code = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE [Code]='{0}' ", data.Code))
                    Dim json = "{""result"":{""data"":""" & data.Code & """,""msg"":""" & msg & """}}"
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
        Function DelBranch() As ActionResult

            Try
                Dim tSqlw As String = " WHERE [Code]<>'' "
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND [Code] Like '{0}'", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""branch"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                Dim oData As New CBranch(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""branch"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
    End Class
End Namespace