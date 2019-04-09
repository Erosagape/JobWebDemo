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
        Function GetClearingReport() As ActionResult
            Dim branch As String = ""
            If Not Request.QueryString("Branch") Is Nothing Then
                branch = Request.QueryString("Branch").ToString
            End If
            Dim code As String = ""
            If Not Request.QueryString("Code") Is Nothing Then
                code = Request.QueryString("Code").ToString
            End If
            Dim sql As String = "
select h.BranchCode,h.ClrNo,h.ClrDate,h.DocStatus,c1.ClrStatusName,
h.ClearanceDate,h.JobType,c4.JobTypeName,b.BrName as BranchName,h.CTN_NO,
h.CoPersonCode,h.TRemark,h.ClearType,c2.ClrTypeName,h.ClearFrom,c3.ClrFromName,
h.EmpCode,u1.TName as ClrByName,h.ApproveBy,u2.TName as ApproveByName,
h.ApproveDate,h.ReceiveBy,u3.TName as ReceiveByName, h.ReceiveDate,h.ReceiveRef,
h.AdvTotal,h.ClearTotal,h.TotalExpense,
d.ItemNo,d.AdvNO,d.AdvItemNo,d.SICode,d.SDescription,d.SlipNO,d.JobNo,d.UsedAmount,d.Tax50Tavi,d.ChargeVAT,
d.FCost,d.BCost,d.UnitPrice,d.Qty,d.CurrencyCode,d.CurRate,
d.Remark,j.CustCode,j.CustBranch,j.InvNo,j.NameEng,j.NameThai,
h.CancelProve,h.CancelReson,h.CancelDate
from Job_ClearHeader h left join Mas_Branch b on h.BranchCode=b.Code 
left join Job_ClearDetail d on h.BranchCode=d.BranchCode and h.ClrNo=d.ClrNo
left join (
  select j.BranchCode,j.JNo,j.CustCode,j.CustBranch,j.InvNo,c.NameThai,c.NameEng
  from Job_Order j inner join Mas_Company c
  on j.CustCode=c.CustCode and j.CustBranch=c.Branch
) j
on d.BranchCode=j.BranchCode and d.JobNo=j.JNo
left join 
(SELECT ConfigKey as ClrStatusKey,ConfigValue as ClrStatusName FROM Mas_Config WHERE ConfigCode='CLR_STATUS') c1
on h.DocStatus=c1.ClrStatusKey
left join 
(SELECT ConfigKey as ClrTypeKey,ConfigValue as ClrTypeName FROM Mas_Config WHERE ConfigCode='CLR_TYPE') c2
on h.ClearType=c2.ClrTypeKey
left join 
(SELECT ConfigKey as ClrFromKey,ConfigValue as ClrFromName FROM Mas_Config WHERE ConfigCode='CLR_FROM') c3
on h.ClearType=c3.ClrFromKey
left join 
(SELECT ConfigKey as JobTypeKey,ConfigValue as JobTypeName FROM Mas_Config WHERE ConfigCode='JOB_TYPE') c4
on h.JobType=c4.JobTypeKey
left join Mas_User u1 on h.EmpCode=u1.UserID
left join Mas_User u2 on h.ApproveBy=u2.UserID
left join Mas_User u3 on h.ReceiveBy=u3.UserID 
WHERE h.BranchCode='{0}' AND h.ClrNo='{1}' 
ORDER BY h.BranchCode,h.ClrNo,j.CustCode,j.CustBranch,d.ItemNo 
"
            Try
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(String.Format(sql, branch, code))
                Dim json = "{""data"":" & JsonConvert.SerializeObject(oData.AsEnumerable().ToList()) & "}"
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content("{""data"":[],""msg"":""" & ex.Message & """}", jsonContent)
            End Try

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
                If Not IsNothing(Request.QueryString("TaxNumber")) Then
                    tSqlW &= " AND b.CustCode IN(Select CustCode from Mas_Company where TaxNumber='" & Request.QueryString("TaxNumber") & "') "
                End If
                Dim sql As String = "
select a.BranchCode,a.ClrNo,a.ClrDate,a.EmpCode,a.ClearFrom,a.ClearType,
a.JobType,a.DocStatus,a.TotalExpense,a.TRemark,a.ReceiveDate,a.ApproveDate,
b.CustCode,b.JobNo,b.InvNo as CustInvNo,b.CurrencyCode,b.AdvNO,
b.AdvTotal,b.ClrVat,b.Clr50Tavi,b.BaseVat,b.Base50Tavi,b.RateVAT,b.Rate50Tavi
FROM Job_ClearHeader as a 
left join 
(
    SELECT d.BranchCode,d.ClrNo,d.JobNo,j.InvNo,j.CustCode,j.CustBranch,
    d.AdvNO,d.CurrencyCode,
    SUM(d.UsedAmount) as ClrAmt,sum(d.AdvAmount) as AdvTotal,
    SUM(CASE WHEN d.ChargeVAT>0 THEN d.UsedAmount ELSE 0 END) as BaseVat,
    SUM(CASE WHEN d.Tax50Tavi>0 THEN d.UsedAmount ELSE 0 END) as Base50Tavi,
    SUM(d.ChargeVAT) as ClrVat,SUM(d.Tax50Tavi) as Clr50Tavi,
    MAX(VATRate) as RateVAT,MAX(Tax50TaviRate) as Rate50Tavi
    FROM Job_ClearDetail d
    inner join Job_Order j on d.JobNo=j.JNo and d.BranchCode=j.BranchCode
    GROUP BY d.BranchCode,d.ClrNo,d.JobNo,j.InvNo,j.CustCode,j.CustBranch,
    d.AdvNO,d.CurrencyCode
) b
on b.BranchCode=a.BranchCode
and b.ClrNo=a.ClrNo
{0}
"
                'group by
                'a.BranchCode,a.ClrNo,a.ClrDate,a.EmpCode,a.ClearFrom,a.ClearType,
                'a.JobType,a.DocStatus,a.TotalExpense,a.TRemark,
                'b.CustCode,b.JobNo,b.InvNo,b.CurrencyCode,b.AdvNO,b.AdvTotal,b.ClrVat,b.Clr50Tavi
                '"
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

            Dim tSqlW As String = String.Format(" AND a.BranchCode='{0}'", Branch)
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
Select a.BranchCode,'' as ClrNo,0 as ItemNo,0 as LinkItem,a.STCode,a.SICode,a.SDescription,a.VenCode as VenderCode,
a.AdvQty as Qty,b.UnitCharge as UnitCode,a.CurrencyCode,a.ExchangeRate as CurRate,
(CASE WHEN b.IsExpense=0 THEN a.UnitPrice ELSE 0 END) as UnitPrice,
(CASE WHEN b.IsExpense=0 THEN a.AdvQty*a.UnitPrice ELSE 0 END) as FPrice,
(CASE WHEN b.IsExpense=0 THEN a.AdvQty*a.UnitPrice*a.ExchangeRate ELSE 0 END) as BPrice,
q.TotalCharge as QUnitPrice,a.AdvQty*q.ChargeAmt as QFPrice,a.AdvQty*q.ChargeAmt*q.CurrencyRate as QBPrice,
a.UnitPrice as UnitCost,a.AdvQty*a.UnitPrice as FCost,a.AdvQty*a.UnitPrice*a.ExchangeRate as BCost,
a.ChargeVAT,a.Charge50Tavi as Tax50Tavi,
a.AdvNo as AdvNO,a.AdvAmount-ISNULL(d.TotalCleared,0) as AdvAmount,a.AdvAmount-ISNULL(d.TotalCleared,0) as UsedAmount,
(CASE WHEN ISNULL(q.QNo,'')='' THEN 0 ELSE 1 END) as IsQuoItem,
'' as SlipNO,'' as Remark,a.IsDuplicate,
b.IsLtdAdv50Tavi,a.PayChqTo as Pay50TaviTo,a.Doc50Tavi as NO50Tavi,NULL as Date50Tavi,
'' as VenderBillingNo,
(SELECT STUFF((
	SELECT DISTINCT ',' + Convert(varchar,QtyBegin) + '-'+convert(varchar,QtyEnd)+'='+convert(varchar,ChargeAmt)
	FROM Job_QuotationItem WHERE BranchCode=q.BranchCode
	AND QNo=q.QNo AND SICode=q.SICode AND VenderCode =q.VenderCode
	AND UnitCheck=q.UnitCheck AND CalculateType=1
FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
)) as AirQtyStep,
q.CalculateType as StepSub,
a.ForJNo as JobNo,a.ItemNo as AdvItemNo,a.IsChargeVAT as VATType,a.VATRate,a.Rate50Tavi as Tax50TaviRate,q.QNo
FROM Job_AdvDetail a LEFT JOIN Job_SrvSingle b on a.SICode=b.SICode
INNER JOIN Job_AdvHeader c on a.BranchCode=c.BranchCode and a.AdvNo=c.AdvNo 
left join Job_Order j on a.BranchCode=j.BranchCode and a.ForJNo=j.JNo
left join 
(
	select qh.BranchCode,qh.QNo,
	qd.JobType,qd.ShipBy,qd.SeqNo,
	qi.ItemNo,qi.SICode,qi.CalculateType,
	qi.QtyBegin,qi.QtyEnd,qi.UnitCheck,qi.CurrencyCode,
	qi.CurrencyRate,qi.ChargeAmt,qi.Isvat,qi.VatRate,
	qi.VatAmt,qi.IsTax,qi.TaxRate,qi.TaxAmt,
	qi.TotalAmt,qi.TotalCharge,qi.UnitDiscntPerc,qi.UnitDiscntAmt,
	qi.VenderCode,qi.VenderCost,qi.BaseProfit,qi.CommissionPerc,qi.CommissionAmt,
	qi.NetProfit,qi.IsRequired
	from Job_QuotationHeader qh
	inner join Job_QuotationDetail qd
	ON qh.BranchCode=qd.BranchCode
	and qh.QNo=qd.QNo
	inner join Job_QuotationItem qi
	on qd.BranchCode=qi.BranchCode
	and qd.QNo=qi.QNo
	and qd.SeqNo=qi.SeqNo
	where qh.DocStatus=3 
) q
on a.BranchCode=q.BranchCode and b.SICode=q.SICode and ISNULL(a.VenCode,b.DefaultVender)=q.VenderCode 
and b.UnitCharge=q.UnitCheck and a.AdvQty <=q.QtyEnd and a.AdvQty>=q.QtyBegin and q.QNo=j.QNo
left join 
(
	SELECT cd.BranchCode,cd.AdvNO,cd.AdvItemNo,
    SUM(CASE WHEN ad.IsDuplicate=1 THEN cd.UsedAmount ELSE cd.AdvAmount END) as TotalCleared    
	FROM Job_ClearDetail cd INNER JOIN Job_ClearHeader ch
	on cd.BranchCode=ch.BranchCode
	and cd.ClrNo =ch.ClrNo 
	and ch.DocStatus<>99
    INNER JOIN Job_AdvDetail ad 
    on cd.BranchCode=ad.BranchCode
    and cd.AdvNO=ad.AdvNo
    and cd.AdvItemNo=ad.ItemNo
    INNER JOIN Job_AdvHeader ah
    on ad.BranchCode=ah.BranchCode
    and ad.AdvNo=ah.AdvNo
    WHERE ah.DocStatus<>99
	GROUP BY cd.BranchCode,cd.AdvNO,cd.AdvItemNo
) d
ON a.BranchCode=d.BranchCode and a.AdvNo=d.AdvNO and a.ItemNo=d.AdvItemNo
WHERE a.AdvAmount-ISNULL(d.TotalCleared,0)>0 AND c.DocStatus<5
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