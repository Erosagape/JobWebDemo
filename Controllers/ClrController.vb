Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json
Namespace Controllers
    Public Class ClrController
        Inherits CController
        ' GET: Clr
        Function Index() As ActionResult
            Return GetView("Index", "MODULE_CLR")
        End Function
        Function Approve() As ActionResult
            Return GetView("Approve", "MODULE_CLR")
        End Function
        Function Receive() As ActionResult
            Return GetView("Receive", "MODULE_CLR")
        End Function
        Function FormClr() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
            If AuthorizeStr.IndexOf("P") < 0 Then
                Return Content("You are not allow to print clear", textContent)
            End If
            Return GetView("FormClr")
        End Function
        Function Costing() As ActionResult
            Return GetView("Costing", "MODULE_ACC")
        End Function
        Function GenerateInv() As ActionResult
            Return GetView("GenerateInv", "MODULE_ACC")
        End Function
        Function Earnest() As ActionResult
            Return GetView("Earnest", "MODULE_CLR")
        End Function

        '-----Controller-----
        Function ApproveClearing() As HttpResponseMessage
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Approve")
            If AuthorizeStr.IndexOf("I") < 0 Then
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End If
            Return New HttpResponseMessage(HttpStatusCode.OK)
        End Function
        Function ReceiveClearing() As HttpResponseMessage
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Receive")
            If AuthorizeStr.IndexOf("I") < 0 Then
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End If
            Return New HttpResponseMessage(HttpStatusCode.OK)
        End Function
        Function GetClearingGrid() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""clr"":{""data"":[],""msg"":""You Are not authorize to view data""}}", jsonContent)
                End If

                Dim Branch As String = ""
                Dim JobNo As String = ""
                If Not IsNothing(Request.QueryString("BranchCode")) Then
                    Branch = Request.QueryString("BranchCode")
                End If

                Dim tSqlW As String = String.Format(" WHERE a.BranchCode='{0}'", Branch)
                If Not IsNothing(Request.QueryString("JobNo")) Then
                    tSqlW &= " AND a.ClrNo IN(SELECT ClrNo FROM Job_ClearDetail WHERE BranchCode='" & Branch & "' And JobNo='" & Request.QueryString("JobNo") & "')"
                End If
                If Not IsNothing(Request.QueryString("JType")) Then
                    tSqlW &= " AND a.JobType=" & Request.QueryString("JType") & ""
                End If
                If Not IsNothing(Request.QueryString("CFrom")) Then
                    tSqlW &= " AND a.ClrFrom=" & Request.QueryString("CFrom") & ""
                End If
                If Not IsNothing(Request.QueryString("CType")) Then
                    tSqlW &= " AND a.ClrType=" & Request.QueryString("CType") & ""
                End If
                If Not IsNothing(Request.QueryString("ClrBy")) Then
                    tSqlW &= " AND a.EmpCode='" & Request.QueryString("ClrBy") & "'"
                End If
                If Not IsNothing(Request.QueryString("DateFrom")) Then
                    tSqlW &= " AND a.ClrDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
                End If
                If Not IsNothing(Request.QueryString("DateTo")) Then
                    tSqlW &= " AND a.ClrDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
                End If
                If Not IsNothing(Request.QueryString("Status")) Then
                    tSqlW &= " AND a.DocStatus='" & Request.QueryString("Status") & "' "
                End If

                Dim sql As String = "
select a.BranchCode,a.ClrNo,a.ClrDate,a.EmpCode,a.ClearFrom,a.ClearType,
a.JobType,a.DocStatus,a.TotalExpense,a.TRemark,
b.CustCode,b.JobNo,b.InvNo as CustInvNo,b.CurrencyCode,b.AdvNO,b.AdvTotal
FROM Job_ClearHeader as a 
left join 
(
SELECT d.BranchCode,d.ClrNo,d.JobNo,j.InvNo,j.CustCode,j.CustBranch,
d.AdvNO,d.CurrencyCode,
SUM(d.FCost) as ClrAmt,sum(d.AdvAmount) as AdvTotal
FROM Job_ClearDetail d
inner join Job_Order j on d.JobNo=j.JNo and d.BranchCode=j.BranchCode
GROUP BY d.BranchCode,d.ClrNo,d.JobNo,j.InvNo,j.CustCode,j.CustBranch,
d.AdvNO,d.CurrencyCode
) b
on b.BranchCode=a.BranchCode
and b.ClrNo=a.ClrNo
{0}
group by
a.BranchCode,a.ClrNo,a.ClrDate,a.EmpCode,a.ClearFrom,a.ClearType,
a.JobType,a.DocStatus,a.TotalExpense,a.TRemark,
b.CustCode,b.JobNo,b.InvNo,b.CurrencyCode,b.AdvNO,b.AdvTotal
"
                Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL(String.Format(sql, tSqlW))
                Dim json = "{""clr"":{""data"":" & JsonConvert.SerializeObject(oData.AsEnumerable().ToList()) & ",""msg"":""" & tSqlW & """}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("{""clr"":{""data"":[],""msg"":""" & ex.Message & """}}", jsonContent)
            End Try
        End Function
        Function GetAdvForClear() As ActionResult
            Dim Branch As String = ""
            Dim JobNo As String = ""
            If Not IsNothing(Request.QueryString("BranchCode")) Then
                Branch = Request.QueryString("BranchCode")
            End If

            Dim tSqlW As String = String.Format(" WHERE a.BranchCode='{0}'", Branch)
            If Not IsNothing(Request.QueryString("JobNo")) Then
                tSqlW &= " AND a.ForJNo='" & Request.QueryString("JobNo") & "' "
            End If
            If Not IsNothing(Request.QueryString("JType")) Then
                tSqlW &= " AND c.JobType=" & Request.QueryString("JType") & ""
            End If
            If Not IsNothing(Request.QueryString("CFrom")) Then
                tSqlW &= " AND c.AdvBy IN(SELECT DISTINCT UserID FROM Job_UserRoleDetail WHERE RoleID Like '" & Request.QueryString("CFrom") & "%')"
            End If
            If Not IsNothing(Request.QueryString("ReqBy")) Then
                tSqlW &= " AND c.EmpCode='" & Request.QueryString("ReqBy") & "'"
            End If
            If Not IsNothing(Request.QueryString("DateFrom")) Then
                tSqlW &= " AND c.AdvDate>='" & Request.QueryString("DateFrom") & " 00:00:00'"
            End If
            If Not IsNothing(Request.QueryString("DateTo")) Then
                tSqlW &= " AND c.AdvDate<='" & Request.QueryString("DateTo") & " 23:59:00'"
            End If
            If Not IsNothing(Request.QueryString("Status")) Then
                tSqlW &= " AND c.DocStatus='" & Request.QueryString("Status") & "' "
            End If
            Dim sql As String = "
Select a.BranchCode,
'' as ClrNo,
0 as ItemNo,
0 as LinkItem,
a.STCode,
a.SICode,
a.SDescription,
a.VenCode as VenderCode,
a.AdvQty as Qty,
b.UnitCharge as UnitCode,
a.CurrencyCode,
a.ExchangeRate as CurRate,
a.UnitPrice,
(CASE WHEN b.IsExpense=0 THEN a.AdvQty*a.UnitPrice ELSE 0 END) as FPrice,
(CASE WHEN b.IsExpense=0 THEN a.AdvQty*a.UnitPrice*a.ExchangeRate ELSE 0 END) as BPrice,
0 as QUnitPrice,
0 as QFPrice,
0 as QBPrice,
a.UnitPrice as UnitCost,
a.AdvQty*a.UnitPrice as FCost,
a.AdvQty*a.UnitPrice*a.ExchangeRate as BCost,
a.ChargeVAT,
a.Charge50Tavi as Tax50Tavi,
a.AdvNo as AdvNO,
a.AdvNet as AdvAmount,
a.AdvNet as UsedAmount,
0 as IsQuoItem,
'' as SlipNO,
'' as Remark,
0 as IsDuplicate,
b.IsLtdAdv50Tavi,
a.PayChqTo as Pay50TaviTo,
a.Doc50Tavi as NO50Tavi,
NULL as Date50Tavi,
'' as VenderBillingNo,
'' as AirQtyStep,
'' as StepSub,
a.ForJNo as JobNo,
a.ItemNo as AdvItemNo,
a.IsChargeVAT as VATType,
a.VATRate,
a.Rate50tavi as Tax50TaviRate
FROM Job_AdvDetail a 
INNER JOIN Job_SrvSingle b
on a.SICode=b.SICode
INNER JOIN Job_AdvHeader c
on a.BranchCode=c.BranchCode
and a.AdvNo=c.AdvNo 
{0}
"
            Dim oData As DataTable = New CUtil(jobWebConn).GetTableFromSQL(String.Format(sql, tSqlW))
            Dim json = "{""clr"":{""data"":" & JsonConvert.SerializeObject(oData.AsEnumerable().ToList()) & ",""msg"":""" & tSqlW & """}}"
            Return Content(json, jsonContent)
        End Function
        Function GetNewClearHeader() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
            If AuthorizeStr.IndexOf("I") < 0 Then
                Return Content("[]", jsonContent)
            End If

            Dim Branch As String = ""
            If Not IsNothing(Request.QueryString("BranchCode")) Then
                Branch = Request.QueryString("BranchCode")
            End If
            Dim oHead As New CClrHeader(jobWebConn)
            oHead.BranchCode = Branch
            oHead.ClrNo = ""
            oHead.ClrDate = DateTime.Today
            oHead.ClearFrom = 1
            oHead.ClearType = 1
            oHead.DocStatus = 1

            Dim oDetail As New CClrDetail(jobWebConn) With {
                .BranchCode = Branch,
                .ClrNo = "",
                .ItemNo = 0
            }

            Dim json As String = "{""clr"":{""header"":[" + JsonConvert.SerializeObject(oHead) + "],""detail"":[" + JsonConvert.SerializeObject(oDetail) + "],""result"":""OK""}}"
            Return Content(json, jsonContent)
        End Function
        Function GetNewClearDetail() As ActionResult
            ViewBag.User = Session("CurrUser").ToString()
            Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
            If AuthorizeStr.IndexOf("I") < 0 Then
                Return Content("[]", jsonContent)
            End If

            Dim Branch As String = ""
            If Not IsNothing(Request.QueryString("BranchCode")) Then
                Branch = Request.QueryString("BranchCode")
            End If

            Dim ClrNo As String = ""
            If Not IsNothing(Request.QueryString("ClrNo")) Then
                ClrNo = Request.QueryString("ClrNo")
            End If

            Dim oDetail As New CClrDetail(jobWebConn) With
                {
                    .BranchCode = Branch,
                    .ClrNo = ClrNo,
                    .ItemNo = 0
                }

            Dim jsond As String = JsonConvert.SerializeObject(oDetail)
            Dim json = "{""clr"":{""detail"":" & jsond & ",""result"":""OK""}}"
            Return Content(json, jsonContent)
        End Function
        Function GetClearing() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""clr"":{""header"":[],""detail"":[],""msg"":""You are not authorize to read""}}", jsonContent)
                End If

                Dim tSqlw As String = " WHERE ClrNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ClrNo ='{0}' ", Request.QueryString("Code").ToString)
                End If

                Dim oData = New CClrHeader(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)

                Dim oDataD = New CClrDetail(jobWebConn).GetData(tSqlw)
                Dim jsonD As String = JsonConvert.SerializeObject(oDataD)

                json = "{""clr"":{""header"":" & json & ",""detail"":" & jsonD & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetClrHeader(<FromBody()> data As CClrHeader) As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("E") < 0 Then
                    Return Content("{""result"":{""data"":[],""msg"":""You are not authorize to edit""}}", jsonContent)
                End If

                If Not IsNothing(data) Then
                    data.SetConnect(jobWebConn)
                    If "" & data.ClrNo = "" Then
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            Return Content("{""result"":{""data"":[],""msg"":""You are not authorize to add""}}", jsonContent)
                        End If
                        Select Case data.ClearType
                            Case 2
                                data.AddNew("TEXP" & DateTime.Now.ToString("yyMM") & "-_____")
                            Case 3
                                data.AddNew("TSRV" & DateTime.Now.ToString("yyMM") & "-_____")
                            Case Else
                                data.AddNew(clrPrefix & DateTime.Now.ToString("yyMM") & "-_____")
                        End Select

                    End If

                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND ClrNo='{1}' ", data.BranchCode, data.ClrNo))

                    Dim json = "{""result"":{""data"":""" & data.ClrNo & """,""msg"":""" & msg & """}}"
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
        Function DelClearing() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("D") < 0 Then
                    Return Content("{""clr"":{""data"":[],""result"":""You are not authorize to delete""}}", jsonContent)
                End If

                Dim tSqlw As String = " WHERE ClrNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If

                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ClrNo ='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If

                Dim oDataD As New CClrDetail(jobWebConn)
                Dim msg = oDataD.DeleteData(tSqlw)

                Dim oData As New CClrHeader(jobWebConn)
                msg = oData.DeleteData(tSqlw)

                Dim json = "{""clr"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function GetClrDetail() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("R") < 0 Then
                    Return Content("{""clr"":{""detail"":[],""msg"":""You are not authorize to read""}}", jsonContent)
                End If

                Dim tSqlw As String = " WHERE ClrNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ClrNo ='{0}' ", Request.QueryString("Code").ToString)
                End If

                Dim oData = New CClrDetail(jobWebConn).GetData(tSqlw)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = "{""clr"":{""detail"":" & json & "}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
        Function SetClrDetail(<FromBody()> data As CClrDetail) As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("E") < 0 Then
                    Return Content("{""result"":{""data"":[],""msg"":""You are not authorize to edit""}}", jsonContent)
                End If

                If Not IsNothing(data) Then
                    If "" & data.ClrNo = "" Then
                        Return Content("{""result"":{""data"":null,""msg"":""Please Enter Data""}}", jsonContent)
                    End If
                    If data.ItemNo = 0 Then
                        If AuthorizeStr.IndexOf("I") < 0 Then
                            Return Content("{""result"":{""data"":[],""msg"":""You are not authorize to add""}}", jsonContent)
                        End If
                    End If

                    data.SetConnect(jobWebConn)
                    Dim msg = data.SaveData(String.Format(" WHERE BranchCode='{0}' AND ClrNo='{1}' AND ItemNo={2} ", data.BranchCode, data.ClrNo, data.ItemNo))
                    Dim json = "{""result"":{""data"":""" & data.ClrNo & """,""msg"":""" & msg & """}}"
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
        Function DelClrDetail() As ActionResult
            Try
                ViewBag.User = Session("CurrUser").ToString()
                Dim AuthorizeStr As String = Main.GetAuthorize(ViewBag.User, "MODULE_CLR", "Index")
                If AuthorizeStr.IndexOf("D") < 0 Then
                    Return Content("{""clr"":{""data"":[],""result"":""You are not authorize to delete""}}", jsonContent)
                End If

                Dim tSqlw As String = " WHERE ClrNo<>'' "
                If Not IsNothing(Request.QueryString("Branch")) Then
                    tSqlw &= String.Format("AND BranchCode ='{0}' ", Request.QueryString("Branch").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Branch"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Code")) Then
                    tSqlw &= String.Format("AND ClrNo ='{0}' ", Request.QueryString("Code").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Data"",""data"":[]}}", jsonContent)
                End If
                If Not IsNothing(Request.QueryString("Item")) Then
                    tSqlw &= String.Format("AND ItemNo ={0} ", Request.QueryString("Item").ToString)
                Else
                    Return Content("{""clr"":{""result"":""Please Select Some Item"",""data"":[]}}", jsonContent)
                End If

                Dim oData As New CClrDetail(jobWebConn)
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = "{""clr"":{""result"":""" & msg & """,""data"":[" & JsonConvert.SerializeObject(oData) & "]}}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("[]", jsonContent)
            End Try
        End Function
    End Class
End Namespace