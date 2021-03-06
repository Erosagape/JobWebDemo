﻿Imports System.Data.SqlClient
Module Main
    Friend Const jsonContent As String = "application/json;charset=UTF-8"
    Friend Const xmlContent As String = "application/xml;charset=UTF-8"
    Friend Const textContent As String = "text/html"
    Friend Const jobDataPath As String = "~/App_Data/job_data.xml"
    Friend Const logoApp As String = "logo-tawan.jpg"
    Friend Const logoRep As String = "logo-idl.jpg"
    Friend Const jobPrefix As String = "TJOB"
    Friend Const advPrefix As String = "TADV"
    Friend Const clrPrefix As String = "TCLR"
    Friend Const invPrefix As String = "INV-"
    Friend jobWebConn As String = ConfigurationManager.ConnectionStrings("JobWebConnectionStringR").ConnectionString
    Friend jobMasConn As String = ConfigurationManager.ConnectionStrings("JobMasConnectionStringR").ConnectionString
    Friend Function GetDBDate(pDate As Date, Optional pTodayAsDefault As Boolean = False) As Object
        If pDate.Year > 2000 Then
            Return pDate
        Else
            If pTodayAsDefault Then
                Return DateTime.Today
            Else
                Return System.DBNull.Value
            End If
        End If
    End Function
    Friend Function GetDBTime(pDate As Date) As Object
        If pDate.Hour > 0 Then
            Return pDate
        Else
            Return System.DBNull.Value
        End If
    End Function
    Friend Function GetValueSQL(conn As String, sql As String) As CResult
        Dim ret As New CResult
        ret.Source = sql
        ret.Param = conn
        ret.Result = ""
        Try
            Using cn As New SqlConnection(conn)
                cn.Open()
                Using rd As SqlDataReader = New SqlCommand(sql, cn).ExecuteReader
                    If rd.Read Then
                        If rd.HasRows Then
                            Dim val As String = rd.GetValue(0).ToString()
                            ret.Result = val
                        End If
                    End If
                    rd.Close()
                End Using
            End Using
        Catch ex As Exception
            ret.IsError = True
            ret.Result = ex.Message
        End Try
        Return ret
    End Function

    Friend Function GetValueConfig(sCode As String, sKey As String) As String
        Dim tSqlw As String = " WHERE ConfigCode<>'' "
        tSqlw &= String.Format("AND ConfigCode='{0}'", sCode)
        tSqlw &= String.Format("AND ISNULL(ConfigKey,'')='{0}'", sKey)
        Dim oData = New CConfig(jobWebConn).GetData(tSqlw)
        If oData.Count > 0 Then
            Return oData(0).ConfigValue
        Else
            Return ""
        End If
    End Function
    Friend Function GetDataConfig(sCode As String) As List(Of CConfig)
        Dim tSqlw As String = " WHERE ConfigCode<>'' "
        If sCode <> "" Then tSqlw &= String.Format("AND ConfigCode='{0}'", sCode)
        Dim oData = New CConfig(jobWebConn).GetData(tSqlw)
        Return oData
    End Function
    Friend Function GetMaxByMask(sConn As String, sSQL As String, sFormat As String) As String
        Dim retStr As String = ""
        Try
            Using cn As New SqlConnection(sConn)
                cn.Open()
                Using rd As SqlDataReader = New SqlCommand(sSQL, cn).ExecuteReader
                    If rd.Read Then
                        If rd.HasRows Then
                            Dim numStr As String = ""
                            Dim formatStr As String = ""
                            Dim val As String = rd.GetValue(0).ToString()
                            Dim i As Integer = 0
                            For i = 1 To val.Length
                                If IsNumeric(val.Substring(val.Length - i, 1)) Then
                                    numStr = val.Substring(val.Length - i, 1) & numStr
                                    formatStr &= "0"
                                Else
                                    Exit For
                                End If
                            Next
                            If numStr <> "" Then
                                retStr = val.Substring(0, val.Length - i + 1) & Format(CLng(numStr) + 1, formatStr)
                            End If
                        End If
                    End If
                    rd.Close()
                End Using

            End Using
        Catch ex As Exception

        End Try
        If retStr = "" Then
            Dim j As Integer = sFormat.Count(Function(c As Char) c = "_")
            retStr = Replace(sFormat, Strings.StrDup(j, "_"), Format(1, Strings.StrDup(j, "0")))
        End If
        Return retStr
    End Function
    Friend Function GetAuthorize(uname As String, app As String, mnu As String) As String
        'M=Can Manage
        'I=Can Insert Data
        'R=Can Query Data
        'E=Can Edit Data
        'D=Can Delete Data
        'P=Can Print Data
        Dim data = ""
        If uname <> "" Then
            Dim auth = New CUserAuth(jobWebConn).GetData(" WHERE UserID='" & uname & "' AND AppID='" & app & "' AND MenuID='" & mnu & "'")
            data = If(auth.Count > 0, "" & auth(0).Author, "")
        End If
        Return data
    End Function
    Friend Function SetAuthorizeFromRole(uname As String) As String
        Dim msg As String = ""
        Try
            Dim SQL As String = "
SELECT a.UserID,SUBSTRING(b.ModuleID,1,CHARINDEX('/',b.ModuleID)-1) as ModuleCode,
SUBSTRING(b.ModuleID,CHARINDEX('/',b.ModuleID)+1,50) as ModuleFunc,
(CASE WHEN MAX(CASE WHEN CHARINDEX('M',b.Author)>=0 THEN 1 ELSE 0 END)=1 THEN 'M' ELSE '' END) +
(CASE WHEN MAX(CASE WHEN CHARINDEX('E',b.Author)>=0 THEN 1 ELSE 0 END)=1 THEN 'E' ELSE '' END) +
(CASE WHEN MAX(CASE WHEN CHARINDEX('I',b.Author)>=0 THEN 1 ELSE 0 END)=1 THEN 'I' ELSE '' END) +
(CASE WHEN MAX(CASE WHEN CHARINDEX('R',b.Author)>=0 THEN 1 ELSE 0 END)=1 THEN 'R' ELSE '' END) +
(CASE WHEN MAX(CASE WHEN CHARINDEX('D',b.Author)>=0 THEN 1 ELSE 0 END)=1 THEN 'D' ELSE '' END) +
(CASE WHEN MAX(CASE WHEN CHARINDEX('P',b.Author)>=0 THEN 1 ELSE 0 END)=1 THEN 'P' ELSE '' END) 
 as Authorize
FROM Mas_UserRolePolicy b,Mas_UserRoleDetail a
WHERE a.RoleID=b.RoleID {0}
GROUP BY a.UserID,b.ModuleID
"
            If uname <> "" Then
                SQL = String.Format(SQL, " AND a.UserID='" & uname & "'")
            End If
            Dim dt As DataTable = New CUtil(jobWebConn).GetTableFromSQL(SQL)
            Dim iRow As Integer = 0
            For Each dr As DataRow In dt.Rows

                Dim oAuth = New CUserAuth(jobWebConn) With {
                    .UserID = If(uname <> "", uname, dr("UserID").ToString()),
                    .AppID = dr("ModuleCode").ToString(),
                    .MenuID = dr("ModuleFunc").ToString(),
                    .Author = dr("Authorize").ToString()
                }
                msg += oAuth.SaveData(String.Format(" WHERE UserID='{0}' AND AppID='{1}' AND MenuID='{2}'", oAuth.UserID, oAuth.AppID, oAuth.MenuID)) & "\n"
                iRow += 1
            Next
            Return msg & iRow & " Processed"
        Catch ex As Exception
            Return "[ERROR] SetAuthorizeByRole:" + ex.Message
        End Try
    End Function
    Friend Function DBExecute(conn As String, SQL As String) As String
        Try
            Using cn As New SqlConnection(conn)
                cn.Open()
                Using cm As New SqlCommand()
                    cm.Connection = cn
                    cm.CommandType = CommandType.Text
                    cm.CommandText = SQL
                    cm.ExecuteNonQuery()
                End Using

            End Using
            Return "OK"
        Catch ex As Exception
            Return "[ERROR]" & ex.Message
        End Try
    End Function
    Public Function SQLUpdateClearHeader() As String
        Return "
UPDATE a
SET a.AdvTotal=ISNULL(b.AdvTotal,0)
,a.TotalExpense=ISNULL(b.TotalNET,0)
,a.ClearTotal=ISNULL(b.AdvTotal-b.TotalNET,0)
,a.ClearVat=ISNULL(b.TotalVAT,0)
,a.ClearWht=ISNULL(b.TotalWHT,0)
,a.ClearNet=ISNULL(b.TotalNET,0)
,a.ClearBill=ISNULL(b.TotalBill,0)
,a.ClearCost=ISNULL(b.TotalCost,0)
FROM Job_ClearHeader a LEFT JOIN (
  SELECT BranchCode,ClrNo,Sum(AdvAmount) as AdvTotal,
  Sum(ChargeVAT) as TotalVAT,Sum(Tax50Tavi) as TotalWHT,Sum(BNet) as TotalNET,
  Sum(CASE WHEN BPrice >0 THEN BPrice ELSE 0 END) as TotalBill,
  Sum(CASE WHEN BPrice =0 THEN BCost ELSE 0 END) as TotalCost
  FROM Job_ClearDetail
  GROUP BY BranchCode,ClrNo
) b
ON a.BranchCode=b.BranchCode AND a.ClrNo=b.ClrNo
"
    End Function
    Public Function SQLUpdateAdvStatus() As String
        Return "
update adv
set adv.DocStatus=src.ClrStatus
from Job_AdvHeader adv inner join
(
    select BranchCode,AdvNo,
    (CASE WHEN sum(ClrNet)-Sum(AdvNet)>=0 THEN 5 ELSE 
         (CASE WHEN Sum(ClrNet) > 0 THEN 4 ELSE AdvStatus END) 
     END) as ClrStatus 
    ,sum(ClrNet) as ClrNet,Sum(AdvNet) as AdvNet
    from
    (
        select h.BranchCode,d.AdvNo,d.ItemNo,d.AdvAmount as AdvNet,
        (CASE WHEN d.IsDuplicate=1 THEN ISNULL(c.ClrNet,0) ELSE ISNULL(c.AdvNet,0) END) as ClrNet,
        (CASE WHEN h.PaymentRef<>'' THEN 3 ELSE (CASE WHEN h.ApproveBy<>'' THEN 2 ELSE 1 END) END) as AdvStatus
        from Job_AdvHeader h inner join Job_AdvDetail d
        on h.BranchCode=d.BranchCode
        and h.AdvNo=d.AdvNo 
        left join
        (
            select a.BranchCode,a.AdvNO,a.AdvItemNo,Sum(a.BNet) as ClrNet,Sum(a.AdvAmount) as AdvNet 
            FROM Job_ClearDetail a inner join Job_ClearHeader b
            on a.BranchCode=b.BranchCode
            and a.ClrNo=b.ClrNo
            where b.DocStatus<>99
            group by a.BranchCode,a.AdvNO,a.AdvItemNo
        ) c
        on h.BranchCode=c.BranchCode
        and h.AdvNo=c.AdvNO
        and d.ItemNo=c.AdvItemNo
        where h.DocStatus<>99
    ) clr
    group by BranchCode,AdvNo,AdvStatus
) src
on adv.BranchCode=src.BranchCode
and adv.AdvNo=src.AdvNo
"
    End Function
    Public Function SQLUpdateAdvHeader()
        Return "
update b 
set b.TotalAdvance =ISNULL(a.SumAdvance,0)
,b.TotalVAT=ISNULL(a.SumVAT,0)
,b.Total50Tavi=ISNULL(a.Sum50Tavi,0)
from Job_AdvHeader b left join 
(
	select BranchCode,AdvNo,Sum(AdvNet) as SumAdvance,
	sum(ChargeVAT) as SumVAT,
	sum(Charge50Tavi) as Sum50Tavi
	from Job_AdvDetail 
	group by BranchCode,AdvNo
) a                                     
on b.BranchCode =a.BranchCode
and b.AdvNo=a.AdvNo
"
    End Function
    Function SQLUpdateWHTaxHeader() As String
        Return "
UPDATE h
SET h.TotalPayAmount=d.TotalAmt,
h.TotalPayTax=d.TotalTax
FROM Job_WHTax h INNER JOIN (
    SELECT BranchCode,DocNo,Sum(PayAmount) as TotalAmt,Sum(PayTax) as TotalTax
    FROM Job_WHTaxDetail 
    GROUP BY BranchCode,DocNo
) d
ON h.BranchCode=d.BranchCode
AND h.DocNo=d.DocNo 
"
    End Function
    Function SQLSelectVoucher() As String
        Return "
SELECT h.BranchCode,h.ControlNo,h.VoucherDate,h.TRemark,h.CustCode,h.CustBranch,h.RecUser,h.RecDate,h.RecTime,
h.PostedBy,h.PostedDate,h.PostedTime,h.CancelReson,h.CancelProve,h.CancelDate,h.CancelTime,
d.ItemNo,d.PRVoucher,d.PRType,d.ChqNo,d.BookCode,d.BankCode,d.BankBranch,d.ChqDate,d.CashAmount,d.ChqAmount,d.CreditAmount,
d.SumAmount,d.CurrencyCode,d.ExchangeRate,d.VatInc+d.VatExc as VatAmount,d.WhtInc+d.WhtExc as WhtAmount,d.TotalAmount,
d.TotalNet,d.IsLocal,d.ChqStatus,d.TRemark as DRemark,d.PayChqTo,d.DocNo as DRefNo,d.SICode,d.RecvBank,d.RecvBranch,
d.acType,d.ForJNo,r.ItemNo as DocItemNo,r.DocType,r.DocNo,r.DocDate,r.CmpType,r.CmpCode,r.CmpBranch,r.PaidAmount as PaidTotal,r.TotalAmount as DocTotal
FROM Job_CashControl h inner join Job_CashControlSub d
on h.BranchCode=d.BranchCode AND h.ControlNo=d.ControlNo
left join Job_CashControlDoc r
on d.BranchCode=r.BranchCode AND d.ControlNo=r.ControlNo
AND d.acType=r.acType
"
    End Function
    Function SQLSelectWHTax()
        Return "
SELECT h.*,d.ItemNo,d.IncType,d.PayDate,d.PayAmount,d.PayTax,d.PayTaxDesc,
d.JNo,d.DocRefType,d.DocRefNo,d.PayRate,
j.InvNo,j.CustCode,j.CustBranch,u.TName as UpdateName 
FROM dbo.Job_WHTax h LEFT JOIN dbo.Job_WHTaxDetail d
ON h.BranchCode=d.BranchCode AND h.DocNo=d.DocNo
LEFT JOIN dbo.Job_Order j ON d.BranchCode=j.BranchCode
AND d.JNo=j.JNo 
LEFT JOIN dbo.Mas_User u ON h.UpdateBy=u.UserID
"
    End Function
    Function SQLSelectAdvHeader() As String
        Return "
select a.*,
(SELECT STUFF((
    SELECT DISTINCT ',' + ForJNo
    FROM Job_AdvDetail WHERE BranchCode=a.BranchCode
    AND AdvNo=a.AdvNo AND ForJNo<>'' 
FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
)) as JobNo
,
(SELECT STUFF((
    SELECT DISTINCT ',' + InvNo
    FROM Job_Order WHERE BranchCode=a.BranchCode AND JNo in(SELECT ForJNo FROM Job_AdvDetail WHERE BranchCode=a.BranchCode
    AND AdvNo=a.AdvNo AND ForJNo<>'')
FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
)) as CustInvNo
,b.TaxNumber,b.NameThai,b.NameEng
,c.BaseAmount,c.RateVAT,c.Rate50Tavi,c.BaseVATInc,c.Base50TaviInc,c.BaseVATExc,c.Base50TaviExc
,c.BaseVATInc+c.BaseVATExc as BaseVAT,c.Base50TaviExc+c.Base50TaviInc as Base50Tavi
,c.VATInc,c.VATExc,c.WHTInc,c.WHTExc,c.TotalNet
,a.AdvCash*a.ExchangeRate as AdvCashCal
,a.AdvChq*a.ExchangeRate as AdvChqCal
,a.AdvChqCash*a.ExchangeRate as AdvChqCashCal
,a.AdvCred*a.ExchangeRate as AdvCredCal
FROM Job_AdvHeader as a LEFT JOIN
Mas_Company b ON a.CustCode=b.CustCode AND a.CustBranch=b.Branch
LEFT JOIN (
    SELECT BranchCode,AdvNo,MAX(VATRate) as RateVAT,MAX(Rate50Tavi) as Rate50Tavi,
    SUM(CASE WHEN Charge50Tavi>0 And IsChargeVAT<>2 THEN AdvAmount ELSE 0 END) as Base50TaviExc,
    SUM(CASE WHEN ChargeVAT>0 And IsChargeVAT<>2 THEN AdvAmount ELSE 0 END) as BaseVATExc,
    SUM(CASE WHEN Charge50Tavi>0 And IsChargeVAT=2 THEN AdvAmount ELSE 0 END) as Base50TaviInc,
    SUM(CASE WHEN ChargeVAT>0 And IsChargeVAT=2 THEN AdvAmount ELSE 0 END) as BaseVATInc,
    SUM(CASE WHEN IsChargeVAT<>2 THEN ChargeVAT ELSE 0 END) as VATExc,
    SUM(CASE WHEN IsChargeVAT=2 THEN ChargeVAT ELSE 0 END) as VATInc,
    SUM(CASE WHEN IsChargeVAT<>2 THEN Charge50Tavi ELSE 0 END) as WHTExc,
    SUM(CASE WHEN IsChargeVAT=2 THEN Charge50Tavi ELSE 0 END) as WHTInc,
    SUM(AdvAmount) as BaseAmount,SUM(AdvNet) as TotalNet  
    FROM Job_AdvDetail 
    GROUP BY BranchCode,AdvNo
) c
ON a.BranchCode=c.BranchCode AND a.AdvNo=c.AdvNo
"
    End Function
    Function SQLSelectAdvDetail() As String
        Return "
select a.*,d.ForJNo,d.ItemNo,d.SICode,d.SDescription,
d.IsDuplicate,d.IsChargeVAT,d.Is50Tavi,d.CurrencyCode,d.ExchangeRate,
b.TaxNumber,b.NameThai,b.NameEng,d.VenCode,d.TRemark as DRemark,
d.BaseAmount,d.RateVAT,d.ChargeVAT,d.Rate50Tavi,d.Charge50Tavi,
d.AdvQty,d.UnitPrice,d.AdvNet,d.AdvPayAmount,
d.BaseVATExc,d.VATExc,d.BaseVATInc,d.VATInc,
d.Base50TaviInc,d.WHTExc,d.Base50TaviExc,d.WHTInc,
d.BaseVATInc+d.BaseVATExc as BaseVAT,d.Base50TaviExc+d.Base50TaviInc as Base50Tavi
FROM Job_AdvHeader as a LEFT JOIN
Mas_Company b ON a.CustCode=b.CustCode AND a.CustBranch=b.Branch
LEFT JOIN (
    SELECT *,
    VATRate as RateVAT,AdvAmount+ChargeVAT as AdvPayAmount,
    AdvAmount as BaseAmount,
    (CASE WHEN Charge50Tavi>0 And IsChargeVAT<>2 THEN AdvAmount ELSE 0 END) as Base50TaviExc,
    (CASE WHEN ChargeVAT>0 And IsChargeVAT<>2 THEN AdvAmount ELSE 0 END) as BaseVATExc,
    (CASE WHEN Charge50Tavi>0 And IsChargeVAT=2 THEN AdvAmount ELSE 0 END) as Base50TaviInc,
    (CASE WHEN ChargeVAT>0 And IsChargeVAT=2 THEN AdvAmount ELSE 0 END) as BaseVATInc,
    (CASE WHEN IsChargeVAT<>2 THEN ChargeVAT ELSE 0 END) as VATExc,
    (CASE WHEN IsChargeVAT=2 THEN ChargeVAT ELSE 0 END) as VATInc,
    (CASE WHEN IsChargeVAT<>2 THEN Charge50Tavi ELSE 0 END) as WHTExc,
    (CASE WHEN IsChargeVAT=2 THEN Charge50Tavi ELSE 0 END) as WHTInc
    FROM Job_AdvDetail 
) d
ON a.BranchCode=d.BranchCode AND a.AdvNo=d.AdvNo
"
    End Function
    Function SQLSelectAdvForClear() As String
        Return "
Select a.BranchCode,'' as ClrNo,0 as ItemNo,0 as LinkItem,
a.STCode,a.SICode,a.SDescription,a.VenCode as VenderCode,
a.AdvQty as Qty,b.UnitCharge as UnitCode,a.CurrencyCode,a.ExchangeRate as CurRate,
(CASE WHEN b.IsExpense=0 THEN a.UnitPrice ELSE 0 END) as UnitPrice,
(CASE WHEN b.IsExpense=0 THEN a.AdvQty*a.UnitPrice ELSE 0 END) as FPrice,
(CASE WHEN b.IsExpense=0 THEN a.AdvQty*a.UnitPrice*a.ExchangeRate ELSE 0 END) as BPrice,
q.TotalCharge as QUnitPrice,a.AdvQty*q.ChargeAmt as QFPrice,a.AdvQty*q.ChargeAmt*q.CurrencyRate as QBPrice,
a.UnitPrice as UnitCost,a.AdvQty*a.UnitPrice as FCost,a.AdvQty*a.UnitPrice*a.ExchangeRate as BCost,
a.ChargeVAT,a.Charge50Tavi as Tax50Tavi,a.AdvNo as AdvNO,a.ItemNo as AdvItemNo,a.AdvAmount,a.AdvNet,
a.AdvNet-ISNULL(d.TotalCleared,0) as AdvBalance,ISNULL(d.TotalCleared,0) as UsedAmount,
(CASE WHEN ISNULL(q.QNo,'')='' THEN 0 ELSE 1 END) as IsQuoItem,
a.IsDuplicate,b.IsExpense,
b.IsLtdAdv50Tavi,a.PayChqTo as Pay50TaviTo,a.Doc50Tavi as NO50Tavi,NULL as Date50Tavi,
'' as VenderBillingNo,'' as SlipNO,'' as Remark,
(SELECT STUFF((
	SELECT DISTINCT ',' + Convert(varchar,QtyBegin) + '-'+convert(varchar,QtyEnd)+'='+convert(varchar,ChargeAmt)
	FROM Job_QuotationItem WHERE BranchCode=q.BranchCode
	AND QNo=q.QNo AND SICode=q.SICode AND VenderCode =q.VenderCode
	AND UnitCheck=q.UnitCheck AND CalculateType=1
FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
)) as AirQtyStep,q.CalculateType as StepSub,
a.ForJNo as JobNo,a.IsChargeVAT as VATType,a.VATRate,a.Rate50Tavi as Tax50TaviRate,q.QNo
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
	from Job_QuotationHeader qh	inner join Job_QuotationDetail qd ON qh.BranchCode=qd.BranchCode and qh.QNo=qd.QNo
	inner join Job_QuotationItem qi	on qd.BranchCode=qi.BranchCode and qd.QNo=qi.QNo and qd.SeqNo=qi.SeqNo 
    where qh.DocStatus=3 
) q
on a.BranchCode=q.BranchCode and b.SICode=q.SICode and ISNULL(a.VenCode,b.DefaultVender)=q.VenderCode 
and b.UnitCharge=q.UnitCheck and a.AdvQty <=q.QtyEnd and a.AdvQty>=q.QtyBegin and q.QNo=j.QNo
left join 
(
	SELECT ad.BranchCode,ad.AdvNo,ad.ItemNo,
    SUM(CASE WHEN ad.IsDuplicate=1 THEN ISNULL(cd.BNet,0) ELSE ISNULL(cd.AdvAmount,0) END) as TotalCleared    
	FROM Job_ClearDetail cd INNER JOIN Job_ClearHeader ch
	on cd.BranchCode=ch.BranchCode	and cd.ClrNo =ch.ClrNo 	and ch.DocStatus<>99
    RIGHT JOIN Job_AdvDetail ad on cd.BranchCode=ad.BranchCode and cd.AdvNO=ad.AdvNo and cd.AdvItemNo=ad.ItemNo
    INNER JOIN Job_AdvHeader ah on ad.BranchCode=ah.BranchCode and ad.AdvNo=ah.AdvNo
    WHERE ah.DocStatus<>99
	GROUP BY ad.BranchCode,ad.AdvNo,ad.ItemNo
) d
ON a.BranchCode=d.BranchCode and a.AdvNo=d.AdvNo and a.ItemNo=d.ItemNo
WHERE (a.AdvNet-ISNULL(d.TotalCleared,0))>0 AND c.DocStatus IN('3','4') "
    End Function
    Function SQLSelectClrHeader() As String
        Return "
select a.*,
b.CustCode,b.CustBranch,b.JobNo,b.InvNo as CustInvNo,b.CurrencyCode,b.AdvNO,b.AdvNet,
b.ClrAmt,b.BaseVat,b.RateVAT,b.ClrVat,b.Base50Tavi,b.Rate50Tavi,b.Clr50Tavi,b.ClrNet
FROM Job_ClearHeader as a 
left join 
(
    SELECT d.BranchCode,d.ClrNo,d.JobNo,j.InvNo,j.CustCode,j.CustBranch,
    d.AdvNO,d.CurrencyCode,
    SUM(d.UsedAmount) as ClrAmt,sum(d.AdvAmount) as AdvNet,
    SUM(CASE WHEN d.ChargeVAT>0 THEN d.UsedAmount ELSE 0 END) as BaseVat,
    SUM(CASE WHEN d.Tax50Tavi>0 THEN d.UsedAmount ELSE 0 END) as Base50Tavi,
    SUM(d.ChargeVAT) as ClrVat,SUM(d.Tax50Tavi) as Clr50Tavi,
    MAX(VATRate) as RateVAT,MAX(Tax50TaviRate) as Rate50Tavi,
    SUM(d.BNet) as ClrNet
    FROM Job_ClearDetail d
    inner join Job_Order j on d.JobNo=j.JNo and d.BranchCode=j.BranchCode
    GROUP BY d.BranchCode,d.ClrNo,d.JobNo,j.InvNo,j.CustCode,j.CustBranch,
    d.AdvNO,d.CurrencyCode
) b
on b.BranchCode=a.BranchCode
and b.ClrNo=a.ClrNo"
    End Function
    Function SQLSelectClrDetail() As String
        Return "select 
h.BranchCode,h.ClrNo,h.ClrDate,h.DocStatus,c1.ClrStatusName,
h.ClearanceDate,h.JobType,c4.JobTypeName,j.ShipBy,c6.ShipByName,
b.BrName as BranchName,h.CTN_NO,h.CoPersonCode,h.TRemark,h.ClearType,c2.ClrTypeName,h.ClearFrom,c3.ClrFromName,
h.EmpCode,u1.TName as ClrByName,h.ApproveBy,u2.TName as ApproveByName,
h.ApproveDate,h.ReceiveBy,u3.TName as ReceiveByName, h.ReceiveDate,h.ReceiveRef,
h.AdvTotal,h.ClearTotal,h.TotalExpense,h.ClearVat,h.ClearWht,h.ClearNet,h.ClearBill,h.ClearCost,
d.ItemNo,d.AdvNO,d.AdvItemNo,a.IsDuplicate,d.AdvAmount,a.AdvNet,a.PaymentDate,a.AdvDate,
d.SICode,d.SDescription,d.SlipNO,d.JobNo,d.VenderCode,v.TName as VenderName,
d.UsedAmount,d.Tax50Tavi,d.ChargeVAT,d.BNet as ClrNet,
d.FPrice,d.BPrice,d.FCost,d.BCost,
d.UnitPrice,d.Qty,d.CurrencyCode,d.CurRate,d.UnitCost,d.FNet,d.BNet,d.Tax50TaviRate,d.VATRate,
d.LinkItem,d.LinkBillNo,s.IsExpense,s.IsCredit,s.IsTaxCharge,s.Is50Tavi,s.IsHaveSlip,s.IsLtdAdv50Tavi,
d.Remark,j.CustCode,j.CustBranch,j.InvNo,j.NameEng,j.NameThai,j.TotalContainer,j.VesselName,j.Commission,
j.JobDate,j.JobStatus,c5.JobStatusName,j.CloseJobDate,j.DeclareNumber,j.InvProduct,j.TotalGW,j.InvProductQty,
h.CancelProve,h.CancelReson,h.CancelDate
from Job_ClearHeader h left join Mas_Branch b on h.BranchCode=b.Code 
left join Job_ClearDetail d on h.BranchCode=d.BranchCode and h.ClrNo=d.ClrNo
left join (
  select ah.BranchCode,ah.AdvNo,ad.ItemNo,ah.PaymentDate,ah.EmpCode,ah.AdvDate,ad.AdvAmount,ad.ChargeVAT,
  ad.IsDuplicate,ad.AdvNet 
  from Job_AdvHeader ah inner join Job_AdvDetail ad
  on ah.BranchCode=ad.BranchCode and ah.AdvNo=ad.AdvNo
) a 
on d.BranchCode=a.BranchCode and d.AdvNO=a.AdvNo and d.AdvItemNo=a.ItemNo
left join (
  select j.BranchCode,j.JNo,j.DocDate as JobDate,j.DeclareNumber,j.VesselName,j.InvProduct,j.TotalGW,
  j.CustCode,j.CustBranch,j.InvNo,j.JobStatus,j.CloseJobDate,j.TotalContainer,j.InvProductQty,
  c.NameThai,c.NameEng,j.ShipBy,j.Commission 
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
on h.ClearFrom=c3.ClrFromKey
left join 
(SELECT ConfigKey as JobTypeKey,ConfigValue as JobTypeName FROM Mas_Config WHERE ConfigCode='JOB_TYPE') c4
on h.JobType=c4.JobTypeKey
left join 
(SELECT ConfigKey as JobTypeKey,ConfigValue as JobStatusName FROM Mas_Config WHERE ConfigCode='JOB_STATUS') c5
on j.JobStatus=c5.JobTypeKey
left join 
(SELECT ConfigKey as JobTypeKey,ConfigValue as ShipByName FROM Mas_Config WHERE ConfigCode='SHIP_BY') c6
on j.ShipBy=c6.JobTypeKey
left join Mas_User u1 on h.EmpCode=u1.UserID
left join Mas_User u2 on h.ApproveBy=u2.UserID
left join Mas_User u3 on h.ReceiveBy=u3.UserID 
left join Job_SrvSingle s on d.SICode=s.SICode
left join Mas_Vender v on d.VenderCode=v.VenCode
"
    End Function
    Function SQLSelectClrNoAdvance() As String
        Return "
select h.ClrDate,h.ReceiveRef,h.ClrNo,d.ItemNo,a.AdvAmount,a.ChargeVAT,a.Charge50Tavi,a.AdvNet,
d.SICode,d.SDescription,j.CustCode,j.CustBranch,sum(d.UsedAmount+d.ChargeVAT) as ClrTotal,
ISNULL(a.AdvNet,0)-sum(d.UsedAmount+d.ChargeVAT) as ClrBal,
sum(d.UsedAmount) as ClrAmount,
SUM(d.Tax50Tavi) as Clr50Tavi,SUM(d.ChargeVAT) as ClrVat,
SUM(d.BNet) as ClrNet
from Job_ClearHeader h
left join Job_ClearDetail d on h.BranchCode=d.BranchCode and h.ClrNo=d.ClrNo
left join (
  select ah.BranchCode,ah.AdvNo,ad.ItemNo,ah.PaymentDate,ah.PaymentRef,ah.JobType,
  ah.EmpCode,ah.AdvDate,ad.SICode,ad.SDescription,ad.AdvAmount,ad.ChargeVAT,ad.Charge50Tavi,ad.AdvNet,
  ah.CustCode,ah.CustBranch
  from Job_AdvHeader ah inner join Job_AdvDetail ad
  on ah.BranchCode=ad.BranchCode and ah.AdvNo=ad.AdvNo
) a 
on d.BranchCode=a.BranchCode and d.AdvNO=a.AdvNo and d.AdvItemNo=a.ItemNo
left join (
  select j.BranchCode,j.JNo,j.CustCode,j.CustBranch,j.InvNo,j.JobStatus,j.CloseJobDate,
  c.NameThai,c.NameEng
  from Job_Order j inner join Mas_Company c
  on j.CustCode=c.CustCode and j.CustBranch=c.Branch
) j
on d.BranchCode=j.BranchCode and d.JobNo=j.JNo
{0} 
group by h.ClrDate,h.ReceiveRef,h.ClrNo,d.ItemNo,a.AdvAmount,a.ChargeVAT,a.Charge50Tavi,a.AdvNet,
d.SICode,d.SDescription,j.CustCode,j.CustBranch
"
    End Function
    Function SQLSelectClrFromAdvance() As String
        Return "
select a.PaymentDate,a.PaymentRef,a.AdvNo,a.ItemNo,a.AdvAmount,a.ChargeVAT,a.Charge50Tavi,a.AdvNet,
a.SICode,a.SDescription,a.CustCode,a.CustBranch,
sum(d.UsedAmount+d.ChargeVAT) as ClrTotal,
ISNULL(a.AdvNet,0)-sum(d.UsedAmount+d.ChargeVAT) as ClrBal,
sum(d.UsedAmount) as ClrAmount,
SUM(d.Tax50Tavi) as Clr50Tavi,SUM(d.ChargeVAT) as ClrVat,
SUM(d.BNet) as ClrNet
from Job_ClearHeader h
left join Job_ClearDetail d on h.BranchCode=d.BranchCode and h.ClrNo=d.ClrNo
left join (
  select ah.BranchCode,ah.AdvNo,ad.ItemNo,ah.PaymentDate,ah.PaymentRef,ah.JobType,
  ah.EmpCode,ah.AdvDate,ad.SICode,ad.SDescription,ad.AdvAmount,ad.ChargeVAT,ad.Charge50Tavi,ad.AdvNet,
  ah.CustCode,ah.CustBranch
  from Job_AdvHeader ah inner join Job_AdvDetail ad
  on ah.BranchCode=ad.BranchCode and ah.AdvNo=ad.AdvNo
) a 
on d.BranchCode=a.BranchCode and d.AdvNO=a.AdvNo and d.AdvItemNo=a.ItemNo
left join (
  select j.BranchCode,j.JNo,j.CustCode,j.CustBranch,j.InvNo,j.JobStatus,j.CloseJobDate,
  c.NameThai,c.NameEng
  from Job_Order j inner join Mas_Company c
  on j.CustCode=c.CustCode and j.CustBranch=c.Branch
) j
on d.BranchCode=j.BranchCode and d.JobNo=j.JNo
{0} 
group by a.PaymentDate,a.PaymentRef,a.AdvNo,a.ItemNo,a.AdvAmount,a.ChargeVAT,a.Charge50Tavi,a.AdvNet,
a.SICode,a.SDescription,a.CustCode,a.CustBranch
"
    End Function
    Function SQLSelectBookAccBalance() As String
        Return "
SELECT q.*,q.SumCashOnhand+q.SumChqClear as SumCash,
q.SumCashOnhand+q.SumChqClear+q.SumChqOnhand-q.LimitBalance as SumCashInBank,
q.SumCashOnhand+q.SumChqClear+q.SumChqOnhand+q.SumCredit as SumBal,
q.SumCredit+q.SumChqReturn as SumCreditable
FROM (
select c.BookCode,c.LimitBalance,
Sum(Case when a.PRType='P' then -1*(a.CashAmount) else a.CashAmount end) as SumCashOnhand,
Sum(Case when a.ChqStatus='P' then (CASE WHEN a.PRType='P' THEN -1*a.ChqAmount ELSE a.ChqAmount end) else 0 end) as SumChqClear,
Sum(Case when a.ChqStatus='R' then (CASE WHEN a.PRType='P' THEN -1*a.ChqAmount ELSE a.ChqAmount end) else 0 end) as SumChqReturn,
Sum(Case when a.ChqStatus NOT IN('P','R') then (CASE WHEN a.PRType='P' THEN -1*a.ChqAmount ELSE a.ChqAmount end) else 0 end) as SumChqOnhand,
Sum(Case when a.PRType='P' then -1*a.CreditAmount else a.CreditAmount end) as SumCredit,
Sum(Case when a.PRType='P' then -1*(a.CreditAmount) else 0 end) as SumAP,
Sum(Case when a.PRType='R' then (a.CreditAmount) else 0 end) as SumAR,
Sum(Case when a.PRType='P' then -1*(a.CashAmount+a.ChqAmount) else 0 end) as SumPV,
Sum(Case when a.PRType='R' then (a.CashAmount+a.ChqAmount) else 0 end) as SumRV
from Job_CashControlSub a inner join Job_CashControl b
on a.BranchCode=b.BranchCode and a.ControlNo=b.ControlNo
inner join Mas_BookAccount c 
on a.BookCode=c.BookCode
WHERE ISNULL(b.CancelProve,'')='' {0}
group by c.BookCode,c.LimitBalance) q
"
    End Function
    Function SQLSelectChequeBalance(pType As String) As String
        Return "
SELECT a.*,ISNULL(c.ChqUsed,0) AS AmountUsed,a.ChqAmount-ISNULL(c.ChqUsed,0) as AmountRemain,
b.CustCode,b.CustBranch,b.VoucherDate
FROM Job_CashControlSub a INNER JOIN Job_CashControl b
ON a.BranchCode=b.BranchCode AND a.ControlNo=b.ControlNo
LEFT JOIN (
    SELECT h.BranchCode,h.ChqNo,SUM(d.PaidAmount) as ChqUsed,
    " & If(pType = "CU", "h.RecvBank,h.RecvBranch", "h.BankCode,h.BankBranch") & "
    FROM Job_CashControlSub h INNER JOIN Job_CashControlDoc d
    ON h.BranchCode=d.BranchCode AND h.ControlNo=d.ControlNo
    WHERE h.PRType='P' AND NOT EXISTS(
        select ControlNo from Job_CashControl
        where BranchCode=h.BranchCode AND ControlNo=h.ControlNo AND ISNULL(CancelProve,'')<>''
    )
    GROUP BY h.BranchCode,h.ChqNo
    " & If(pType = "CU", ",h.RecvBank,h.RecvBranch", ",h.BankCode,h.BankBranch") & "
) c
ON a.BranchCode=c.BranchCode
AND a.ChqNo=c.ChqNo " & If(pType = "CU", "AND a.RecvBank=c.RecvBank ", "AND a.BankCode=c.BankCode ") & "
WHERE a.acType='" & pType & "'
AND a.PRType='R' AND a.ChqAmount>0 AND ISNULL(a.ChqNo,'')<>''
"
    End Function
    Function SQLSelectDocumentBalance(pType As String) As String
        Return "
SELECT a.*,ISNULL(c.CreditUsed,0) AS AmountUsed,a.CreditAmount-ISNULL(c.CreditUsed,0) as AmountRemain,
b.CustCode,b.CustBranch,b.VoucherDate
FROM Job_CashControlSub a INNER JOIN Job_CashControl b
ON a.BranchCode=b.BranchCode AND a.ControlNo=b.ControlNo
LEFT JOIN (
    SELECT h.BranchCode,h.DocNo,SUM(d.PaidAmount) as CreditUsed    
    FROM Job_CashControlSub h INNER JOIN Job_CashControlDoc d
    ON h.BranchCode=d.BranchCode AND h.ControlNo=d.ControlNo
    WHERE h.PRType='" & If(pType = "R", "P", "R") & "' AND NOT EXISTS(
        select ControlNo from Job_CashControl
        where BranchCode=h.BranchCode AND ControlNo=h.ControlNo AND ISNULL(CancelProve,'')<>''
    )
    GROUP BY h.BranchCode,h.DocNo
) c
ON a.BranchCode=c.BranchCode
AND a.DocNo=c.DocNo 
WHERE a.PRType='" & pType & "' AND a.CreditAmount>0 AND ISNULL(a.DocNo,'')<>'' 
"
    End Function
    Function SQLSelectJobReport() As String
        Return "
select j.*,c2.JobStatusName,c1.JobTypeName,c3.ShipByName,
u1.ManagerName,u2.CSName,u3.ShippingName,
c4.ConsigneeName,v1.AgentName,v2.ForwarderName
from (
  select j.*,
  c.NameThai as CustTName,c.NameEng as CustEName
  from Job_Order j inner join Mas_Company c
  on j.CustCode=c.CustCode and j.CustBranch=c.Branch
) j
left join 
(SELECT ConfigKey as JobTypeKey,ConfigValue as JobTypeName FROM Mas_Config WHERE ConfigCode='JOB_TYPE') c1
on j.JobType=c1.JobTypeKey
left join 
(SELECT ConfigKey as JobTypeKey,ConfigValue as JobStatusName FROM Mas_Config WHERE ConfigCode='JOB_STATUS') c2
on j.JobStatus=c2.JobTypeKey
left join 
(SELECT ConfigKey as JobTypeKey,ConfigValue as ShipByName FROM Mas_Config WHERE ConfigCode='SHIP_BY') c3
on j.ShipBy=c3.JobTypeKey
left join (select UserID,TName as ManagerName from Mas_User ) u1 on j.ManagerCode=u1.UserID
left join (select UserID,TName as CSName from Mas_User ) u2 on j.CSCode=u2.UserID
left join (select UserID,TName as ShippingName from Mas_User ) u3 on j.ShippingEmp=u3.UserID
left join (select CustCode,Max(NameThai) as ConsigneeName from Mas_Company group by CustCode) c4 on j.consigneecode=c4.CustCode
left join (select VenCode,TName as AgentName from Mas_Vender) v1 on j.AgentCode=v1.VenCode
left join (select VenCode,TName as ForwarderName from Mas_Vender) v2 on j.ForwarderCode=v2.VenCode
"
    End Function
    Function SQLUpdateInvoiceHeader() As String
        Return "
update h
set h.TotalAdvance=d.TotalAdvance,
h.TotalCharge=d.TotalCharge,
h.TotalIsTaxCharge=d.TotalIsTaxCharge,
h.TotalIs50Tavi=d.TotalIs50Tavi,
h.TotalVAT=d.TotalVAT,
h.Total50Tavi=d.Total50Tavi,
h.SumDiscount=d.SumDiscount,
h.DiscountCal=d.TotalNet*(h.DiscountRate/100),
h.TotalDiscount=d.SumDiscount+(d.TotalNet*(h.DiscountRate/100)),
h.TotalNet=d.TotalNet-(d.SumDiscount+(d.TotalNet*(h.DiscountRate/100))),
h.ForeignNet=d.TotalNet-(d.SumDiscount+(d.TotalNet*(h.DiscountRate/100)))/h.ExchangeRate
from Job_InvoiceHeader h
inner join (
	select BranchCode,DocNo,
	sum(AmtCharge) as TotalCharge,
	sum(AmtAdvance) as TotalAdvance,
	sum(case when IsTaxCharge=1 And AmtCharge>0 then Amt else 0 end) as TotalIsTaxCharge, 
	sum(case when Is50Tavi=1 And AmtCharge>0 then Amt else 0 end) as TotalIs50Tavi,
	sum(case when AmtCharge>0 then AmtVat else 0 end) as TotalVAT,
	sum(case when AmtCharge>0 then Amt50Tavi else 0 end) as Total50Tavi,
    sum(AmtDiscount) as SumDiscount,
	sum(TotalAmt) as TotalNet
	from Job_InvoiceDetail
	group by BranchCode,DocNo
) d
on h.BranchCode=d.BranchCode
and h.DocNo=d.DocNo 
"
    End Function
    Function SQLSelectClrForInvoice() As String
        Return "
select b.BranchCode,
b.LinkBillNo as DocNo,
b.LinkItem as ItemNo,
b.SICode,
b.SDescription,
b.SlipNO as ExpSlipNO,
b.Remark as SRemark,
b.CurrencyCode,
b.CurRate as ExchangeRate,
b.Qty,
b.UnitCode as QtyUnit,
b.UnitCost as UnitPrice,
b.UnitCost*b.CurRate as FUnitPrice,
b.UsedAmount as Amt,
b.UsedAmount/b.CurRate as FAmt,
0 as DiscountType,
0 as DiscountPerc,
0 as AmtDiscount,
0 as FAmtDiscount,
CASE WHEN b.Tax50TaviRate>0 THEN 1 ELSE 0 END as Is50Tavi,
b.Tax50TaviRate as Rate50Tavi,
CASE WHEN ISNULL(b.SlipNO,'')='' AND b.BPrice>0 THEN b.Tax50Tavi ELSE 0 END as Amt50Tavi,
b.VATType as IsTaxCharge,
CASE WHEN ISNULL(b.SlipNO,'')='' AND b.BPrice>0 THEN b.ChargeVAT ELSE 0 END as AmtVat,
b.BNet as TotalAmt,
b.BNet/b.CurRate as FTotalAmt,
CASE WHEN ISNULL(b.SlipNO,'')<>'' AND b.BPrice>0 THEN b.BNet ELSE 0 END as AmtAdvance,
CASE WHEN ISNULL(b.SlipNO,'')='' AND b.BPrice>0 THEN b.UsedAmount ELSE 0 END as AmtCharge,
'' as CurrencyCodeCredit,
1 as ExchangeRateCredit,
0 as AmtCredit,
0 as FAmtCredit,
b.VATRate,
c.CustCode,c.CustBranch,
b.JobNo,b.ClrNo,b.ItemNo as ClrItemNo,b.ClrNo+'/'+Convert(varchar,b.ItemNo) as ClrNoList,
(CASE WHEN b.BPrice=0 THEN b.BNet ELSE 0 END) as AmtCost,
(CASE WHEN b.BPrice=0 THEN 0 ELSE b.BNet END) as AmtNet
from Job_ClearHeader a INNER JOIN Job_ClearDetail b
ON a.BranchCode=b.BranchCode
AND a.ClrNo=b.ClrNo
INNER JOIN Job_Order c
ON b.BranchCode=c.BranchCode
and b.JobNo=c.JNo
"
    End Function
    Function SQLSelectClrSumForInvoice() As String
        Return "
select b.BranchCode,
b.LinkBillNo as DocNo,
b.LinkItem as ItemNo,
b.SICode,
b.SDescription,
b.SlipNO as ExpSlipNO,
b.Remark as SRemark,
b.CurrencyCode,
b.CurRate as ExchangeRate,
b.Qty,
b.UnitCode as QtyUnit,
b.UnitCost as UnitPrice,
b.UnitCost*b.CurRate as FUnitPrice,
b.UsedAmount as Amt,
b.UsedAmount/b.CurRate as FAmt,
0 as DiscountType,
0 as DiscountPerc,
0 as AmtDiscount,
0 as FAmtDiscount,
CASE WHEN b.Tax50TaviRate>0 THEN 1 ELSE 0 END as Is50Tavi,
b.Tax50TaviRate as Rate50Tavi,
CASE WHEN ISNULL(b.SlipNO,'')='' AND b.BPrice>0 THEN b.Tax50Tavi ELSE 0 END as Amt50Tavi,
b.VATType as IsTaxCharge,
CASE WHEN ISNULL(b.SlipNO,'')='' AND b.BPrice>0 THEN b.ChargeVAT ELSE 0 END as AmtVat,
b.BNet as TotalAmt,
b.BNet/b.CurRate as FTotalAmt,
CASE WHEN ISNULL(b.SlipNO,'')<>'' AND b.BPrice>0 THEN b.BNet ELSE 0 END as AmtAdvance,
CASE WHEN ISNULL(b.SlipNO,'')='' AND b.BPrice>0 THEN b.UsedAmount ELSE 0 END as AmtCharge,
'' as CurrencyCodeCredit,
1 as ExchangeRateCredit,
0 as AmtCredit,
0 as FAmtCredit,
b.VATRate,
c.CustCode,c.CustBranch,
b.JobNo,b.ClrNo,b.ItemNo as ClrItemNo,
(CASE WHEN b.BPrice=0 THEN b.BNet ELSE 0 END) as AmtCost,
(CASE WHEN b.BPrice=0 THEN 0 ELSE b.BNet END) as AmtNet
from Job_ClearHeader a INNER JOIN Job_ClearDetail b
ON a.BranchCode=b.BranchCode
AND a.ClrNo=b.ClrNo
INNER JOIN Job_Order c
ON b.BranchCode=c.BranchCode
and b.JobNo=c.JNo
"
    End Function
    Function SQLSelectInvForBilling() As String
        Return "
SELECT a.*,b.NameThai,b.NameEng FROM Job_InvoiceHeader a
LEFT JOIN Mas_Company b ON a.CustCode=b.CustCode AND a.CustBranch=b.Branch
WHERE ISNULL(a.CancelProve,'')='' 
"
    End Function
    Function SQLUpdateBillHeader(branch As String, billno As String) As String
        Dim sql As String = "
UPDATE a
SET a.TotalCustAdv=ISNULL(b.SumCustAdvance,0),
a.TotalAdvance=ISNULL(b.SumAdvance,0),
a.TotalChargeVAT=ISNULL(b.SumChargeVAT,0),
a.TotalChargeNonVAT=ISNULL(b.SumChargeNonVAT,0),
a.TotalVAT=ISNULL(b.SumVAT,0),
a.TotalWH=ISNULL(b.SumWH,0),
a.TotalDiscount=ISNULL(b.SumDiscount,0),
a.TotalNet=ISNULL(b.SumNet,0)
FROM Job_BillAcceptHeader a 
LEFT JOIN (
    SELECT BranchCode,BillAcceptNo,
    SUM(AmtCustAdvance) as SumCustAdvance,
    SUM(AmtAdvance) as SumAdvance,
    SUM(AmtChargeVAT) as SumChargeVAT,
    SUM(AmtChargeNonVAT) as SumChargeNonVAT,
    SUM(AmtVAT) as SumVAT,
    SUM(AmtWH) as SumWH,
    SUM(AmtDiscount) as SumDiscount,
    SUM(AmtTotal) as SumNet
    FROM Job_BillAcceptDetail
    GROUP BY BranchCode,BillAcceptNo
) b
ON a.BranchCode=b.BranchCode
AND a.BillAcceptNo=b.BillAcceptNo
"
        Return sql & If(billno <> "" And branch <> "", String.Format(" WHERE a.BranchCode='{0}' AND a.BillAcceptNo='{1}' ", branch, billno), "")
    End Function
    Function SQLUpdateBillToInv(branch As String, billno As String, Optional iscancel As Boolean = False) As String
        Dim sql As String = "UPDATE a"
        If iscancel Then
            sql &= " SET a.BillAcceptNo=null,a.BillIssueDate=null,a.BillAcceptDate=null,"
            sql &= " a.BillToCustCode=null,a.BillToCustBranch=null"
            sql &= " FROM Job_InvoiceHeader a "
            sql &= " WHERE a.BranchCode='{0}' AND a.BillAcceptNo='{1}' "
        Else
            sql &= " SET a.BillAcceptNo=b.BillAcceptNo,a.BillIssueDate=b.BillDate,a.BillAcceptDate=b.BillRecvDate,"
            sql &= " a.BillToCustCode=b.CustCode,a.BillToCustBranch=b.CustBranch "
            sql &= " FROM Job_InvoiceHeader a,Job_BillAcceptHeader b "
            sql &= " WHERE a.BranchCode=b.BranchCode AND a.BranchCode='{0}' AND b.BillAcceptNo='{1}' "
        End If
        Return String.Format(sql, branch, billno)
    End Function
    Function SQLUpdateJobStatus(sqlwhere As String) As String
        Dim sql As String = "
UPDATE j
SET j.JobStatus=c.JobStatus
FROM Job_Order j INNER JOIN (
    SELECT s.BranchCode,s.JNo,MAX(s.JobStatus) as JobStatus
    FROM (
        SELECT BranchCode,JNo,0 as JobStatus FROM Job_Order 
        WHERE ConfirmDate IS NULL 
        AND JobStatus<>99 AND NOT ISNULL(CancelReson,'')<>''
        UNION
        SELECT BranchCode,JNo,1 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND DutyDate>GETDATE() 
        AND JobStatus<>1 AND NOT ISNULL(CancelReson,'')<>''
        UNION
        SELECT BranchCode,JNo,2 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND DutyDate<=GETDATE()
        AND JobStatus<>2 AND NOT ISNULL(CancelReson,'')<>'' 
        UNION
        SELECT BranchCode,JNo,3 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NOT NULL  
        AND JobStatus<>3 AND NOT ISNULL(CancelReson,'')<>''
        UNION
        SELECT a.BranchCode,a.JNo,4 FROM Job_Order a 
        WHERE EXISTS(
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'')<>'' THEN 1 ELSE 0 END) as TotalBill
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING SUM(CASE WHEN ISNULL(b.LinkBillNo,'')<>'' THEN 1 ELSE 0 END)=0
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'')<>''
        UNION 
        SELECT a.BranchCode,a.JNo,5 FROM Job_Order a 
        WHERE EXISTS(
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'')<>'' THEN 1 ELSE 0 END) as TotalBill,
              COUNT(*) as TotalDoc
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING COUNT(*)>SUM(CASE WHEN ISNULL(b.LinkBillNo,'')<>'' THEN 1 ELSE 0 END)
              AND SUM(CASE WHEN ISNULL(b.LinkBillNo,'')<>'' THEN 1 ELSE 0 END)>0
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'')<>''
        UNION 
        SELECT a.BranchCode,a.JNo,6 FROM Job_Order a 
        WHERE EXISTS (
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'')<>'' THEN 1 ELSE 0 END) as TotalBill,
              COUNT(*) as TotalDoc
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING COUNT(*)=SUM(CASE WHEN ISNULL(b.LinkBillNo,'')<>'' THEN 1 ELSE 0 END)
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'')<>''
        UNION
        SELECT a.BranchCode,a.JNo,7 FROM Job_Order a 
        WHERE EXISTS
        (
              SELECT b.BranchCode,b.JobNo as JNo,SUM(b.BNet-ISNULL(r.TotalRcv,0)) as Balance
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              LEFT JOIN (
                SELECT rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,Sum(rd.Net) as TotalRcv
                FROM Job_ReceiptHeader rh INNER JOIN Job_ReceiptDetail rd
                ON rh.BranchCode=rd.BranchCode AND rh.ReceiptNo=rd.ReceiptNo
                INNER JOIN Job_InvoiceHeader i
                ON rd.BranchCode=i.BranchCode AND rd.InvoiceNo=i.DocNo
                WHERE ISNULL(rh.CancelProve,'')='' AND ISNULL(i.CancelProve,'')='' 
                GROUP BY rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo
              ) r
              ON b.BranchCode=r.BranchCode AND b.LinkBillNo=r.InvoiceNo AND b.LinkItem=r.InvoiceItemNo
              WHERE h.DocStatus<>99 AND b.BranchCode=a.BranchCode AND b.JobNo=a.JNo 
              AND b.LinkItem>0 AND ISNULL(b.LinkBillNo,'')<>'' 
              GROUP BY b.BranchCode,b.JobNo
              HAVING SUM(b.BNet-ISNULL(r.TotalRcv,0))<=0
        ) AND a.ConfirmDate IS NOT NULL AND a.CloseJobDate IS NOT NULL  
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'')<>''
        UNION
        SELECT BranchCode,JNo,98 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'')<>'' AND JobStatus<>99
        UNION
        SELECT BranchCode,JNo,98 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'')<>'' AND JobStatus=99
    ) s
    GROUP BY s.BranchCode,s.JNo
) c
ON j.BranchCode=c.BranchCode
AND j.JNo=c.JNo 
WHERE j.JobStatus<> c.JobStatus
{0}
"
        Return String.Format(sql, sqlwhere)
    End Function
End Module
