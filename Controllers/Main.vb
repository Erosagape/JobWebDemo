Imports System.Data.SqlClient
Imports Newtonsoft.Json
Module Main
    Friend Const jsonContent As String = "application/json;charset=UTF-8"
    Friend Const xmlContent As String = "application/xml;charset=UTF-8"
    Friend Const textContent As String = "text/html"
    Friend Const jobPrefix As String = "[J][S]"
    Friend Const advPrefix As String = "ADV"
    Friend Const clrPrefix As String = "CLR"
    Friend Const invPrefix As String = "INV-"
    Friend Const billPrefix As String = "BL-"
    Friend Const payPrefix As String = "PAY-"
    Friend Const whtPrefix As String = "WT-"
    Friend Const costPrefix As String = "CST-"
    Friend Const expPrefix As String = "ACC-"
    Friend Const servPrefix As String = "SRV-"
    Friend jobWebConn As String = ""
    Friend jobMasConn As String = ""
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
        Dim ret As New CResult With {
            .Source = sql,
            .Param = conn,
            .Result = ""
        }
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
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "GetValueSQL", "ERROR", ex.Message & "=>" & sql & " (" & conn & ")")
            ret.IsError = True
            ret.Result = ex.Message
        End Try
        Return ret
    End Function

    Friend Function GetValueConfig(sCode As String, sKey As String, Optional sDef As String = "") As String
        Try
            Dim tSqlw As String = " WHERE ConfigCode<>'' "
            If sCode <> "" Then tSqlw &= String.Format("AND ConfigCode='{0}'", sCode)
            tSqlw &= String.Format("AND ISNULL(ConfigKey,'')='{0}'", sKey)
            Dim oData = New CConfig(jobWebConn).GetData(tSqlw)
            If oData.Count > 0 Then
                Return oData(0).ConfigValue
            Else
                Return sDef
            End If
        Catch ex As Exception
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "GetValueConfig", "ERROR", ex.Message)
            Return sDef
        End Try
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
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "GetMaxByMask", "ERROR", ex.Message)
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
            Dim SQL As String = SQLSelectRoleAll()
            If uname <> "" Then
                SQL = String.Format(SQL, " AND a.UserID='" & uname & "'")
            Else
                SQL = String.Format(SQL, "")
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
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "SetAuthorizeFromRole", "ERROR", ex.Message)
            Return "[ERROR] SetAuthorizeByRole:" + ex.Message
        End Try
    End Function

    Friend Function SetAuthorizeFromPolicy(roleid As String) As String
        Dim msg As String = ""
        Try
            Dim SQL As String = SQLSelectRoleAll()

            If roleid <> "" Then
                SQL = String.Format(SQL, " AND b.RoleID='" & roleid & "'")
            Else
                SQL = String.Format(SQL, "")
            End If
            Dim dt As DataTable = New CUtil(jobWebConn).GetTableFromSQL(SQL)
            Dim iRow As Integer = 0
            For Each dr As DataRow In dt.Rows

                Dim oAuth = New CUserAuth(jobWebConn) With {
                    .UserID = dr("UserID").ToString(),
                    .AppID = dr("ModuleCode").ToString(),
                    .MenuID = dr("ModuleFunc").ToString(),
                    .Author = dr("Authorize").ToString()
                }
                msg += oAuth.SaveData(String.Format(" WHERE UserID='{0}' AND AppID='{1}' AND MenuID='{2}'", oAuth.UserID, oAuth.AppID, oAuth.MenuID)) & "\n"
                iRow += 1
            Next
            Return msg & iRow & " Processed"
        Catch ex As Exception
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "SetAuthorizeByRole", "ERROR", ex.Message)
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
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "DBExecute", conn, SQL)
                End Using
            End Using
            Return "OK"
        Catch ex As Exception
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "DBExecute", "ERROR", ex.Message)
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
    (CASE WHEN sum(ClrCount)=Count(*) THEN 5 ELSE 
         (CASE WHEN Sum(ClrCount) > 0 THEN 4 ELSE Max(AdvStatus) END) 
     END) as ClrStatus 
    ,sum(ClrNet) as ClrNet,Sum(AdvNet) as AdvNet
    from
    (
        select h.BranchCode,d.AdvNo,d.ItemNo,d.AdvAmount as AdvNet,
        (CASE WHEN d.IsDuplicate=1 THEN ISNULL(c.ClrNet,0) ELSE ISNULL(c.AdvNet,0) END) as ClrNet,
        (CASE WHEN h.PaymentRef<>'' THEN 3 ELSE (CASE WHEN h.ApproveBy<>'' THEN 2 ELSE 1 END) END) as AdvStatus,
        (CASE WHEN c.ClrNo IS NULL THEN 0 ELSE 1 END) as ClrCount
        from Job_AdvHeader h inner join Job_AdvDetail d
        on h.BranchCode=d.BranchCode
        and h.AdvNo=d.AdvNo 
        left join
        (
            select a.BranchCode,a.AdvNO,a.AdvItemNo
            ,Max(a.ClrNo) as ClrNo
            ,Sum(a.BNet) as ClrNet,Sum(a.AdvAmount) as AdvNet 
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
    group by BranchCode,AdvNo
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
    Public Function SQLUpdatePayHeader()
        Return "
update b 
set b.TotalExpense =ISNULL(a.SumNet,0)
,b.TotalVAT=ISNULL(a.SumAmtVAT,0)
,b.TotalTax=ISNULL(a.SumAmtWHT,0)
,b.TotalDiscount=ISNULL(a.SumAmtDisc,0)
,b.TotalNet=ISNULL(a.SumTotal,0)
,b.ForeignAmt=ISNULL(a.SumFTotal,0)
from Job_PaymentHeader b left join 
(
	select BranchCode,DocNo,Sum(Amt-AmtDisc) as SumNet,
	sum(AmtVAT) as SumAmtVAT,
	sum(AmtWHT) as SumAmtWHT,
    sum(AmtDisc) as SumAmtDisc,
    sum(Total) as SumTotal,
    sum(FTotal) as SumFTotal
	from Job_PaymentDetail 
	group by BranchCode,DocNo
) a                                     
on b.BranchCode =a.BranchCode
and b.DocNo=a.DocNo
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
    Function SQLSelectCNDNByInvoice() As String
        Return "
select cd.BranchCode,cd.BillingNo,cd.BillItemNo,    
	sum(cd.DiffAmt) as CreditAmt,
	sum(cd.VATAmt) as CreditVat,
	sum(cd.WHTAmt) as CreditWht,
	sum(cd.TotalNet) as CreditNet,
    max(cd.DocNo) as CreditNo
	from Job_CNDNDetail cd inner join Job_CNDNHeader ch
	on cd.BranchCode=ch.BranchCode AND cd.DocNo=ch.DocNo
	and ch.DocStatus=1
	group by cd.BranchCode,cd.BillingNo,cd.BillItemNo
"
    End Function

    Function SQLSelectCNDNSummary() As String
        Return "
SELECT a.*,b.InvoiceNo,
b.TotalAmt,b.TotalVAT,b.TotalWHT,b.TotalNet,b.FTotalNet
FROM Job_CNDNHeader a LEFT JOIN
(
    SELECT BranchCode,DocNo,
    (SELECT STUFF((
        SELECT DISTINCT ',' + BillingNo
        FROM Job_CNDNDetail WHERE BranchCode=d.BranchCode
        AND DocNo=d.DocNo  
    FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
    )) as InvoiceNo,
    Sum(DiffAmt) as TotalAmt,
    Sum(VATAmt) as TotalVAT,
    Sum(WHTAmt) as TotalWHT,
    Sum(TotalNet) as TotalNet,
    Sum(ForeignNet) as FTotalNet
    FROM Job_CNDNDetail d
    GROUP BY BranchCode,DocNo
) b
ON a.BranchCode=b.BranchCode
AND a.DocNo=b.DocNo
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
a.ForJNo as JobNo,a.IsChargeVAT as VATType,a.VATRate,a.Rate50Tavi as Tax50TaviRate,q.QNo,
c.DocStatus,c.AdvBy,c.EmpCode as ReqBy,c.PaymentDate,c.CustCode
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
    INNER JOIN Job_AdvDetail ad on cd.BranchCode=ad.BranchCode and cd.AdvNO=ad.AdvNo and cd.AdvItemNo=ad.ItemNo
    INNER JOIN Job_AdvHeader ah on ad.BranchCode=ah.BranchCode and ad.AdvNo=ah.AdvNo
    WHERE ah.DocStatus<>99
	GROUP BY ad.BranchCode,ad.AdvNo,ad.ItemNo
) d
ON a.BranchCode=d.BranchCode and a.AdvNo=d.AdvNo and a.ItemNo=d.ItemNo "
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
d.ItemNo,d.AdvNO,d.AdvItemNo,a.IsDuplicate,d.AdvAmount,
a.AdvNet,a.PaymentDate,a.AdvDate,a.DocStatus,
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
  select ah.BranchCode,ah.AdvNo,ad.ItemNo,ah.PaymentDate,ah.EmpCode,ad.AdvAmount,ad.ChargeVAT,
  ad.IsDuplicate,ad.AdvNet,ah.AdvDate,ah.DocStatus
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
ISNULL(a.AdvNet,0)-sum(d.BNet) as ClrBal,
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
ISNULL(a.AdvNet,0)-sum(d.BNet) as ClrBal,
sum(d.UsedAmount) as ClrAmount,
SUM(d.Tax50Tavi) as Clr50Tavi,SUM(d.ChargeVAT) as ClrVat,
SUM(d.BNet) as ClrNet
from Job_ClearHeader h
left join Job_ClearDetail d on h.BranchCode=d.BranchCode and h.ClrNo=d.ClrNo
left join (
  select ah.BranchCode,ah.AdvNo,ad.ItemNo,ah.PaymentDate,ah.PaymentRef,ah.JobType,
  ah.EmpCode,ah.AdvDate,ad.SICode,ad.SDescription,ad.AdvAmount,ad.ChargeVAT,ad.Charge50Tavi,ad.AdvNet,
  ah.CustCode,ah.CustBranch,ah.DocStatus
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
FROM 
(   
    SELECT BranchCode,ControlNo,ChqNo,ChqDate,PayChqTo," & If(pType = "CU", "RecvBank,RecvBranch", "BankCode,BankBranch") & ",acType,PRType,
    SUM(ChqAmount) as ChqAmount
    FROM Job_CashControlSub
    GROUP BY BranchCode,ControlNo,ChqNo,ChqDate,PayChqTo," & If(pType = "CU", "RecvBank,RecvBranch", "BankCode,BankBranch") & ",acType,PRType
) a INNER JOIN Job_CashControl b
ON a.BranchCode=b.BranchCode AND a.ControlNo=b.ControlNo
LEFT JOIN (
    SELECT h.BranchCode,h.ChqNo,SUM(d.PaidAmount) as ChqUsed,
    " & If(pType = "CU", "h.RecvBank,h.RecvBranch", "h.BankCode,h.BankBranch") & "
    FROM Job_CashControlSub h INNER JOIN Job_CashControlDoc d
    ON h.BranchCode=d.BranchCode AND h.ControlNo=d.ControlNo
    WHERE NOT EXISTS(
        select ControlNo from Job_CashControl
        where BranchCode=h.BranchCode AND ControlNo=h.ControlNo AND ISNULL(CancelProve,'')<>''
    )
    GROUP BY h.BranchCode,h.ChqNo
    " & If(pType = "CU", ",h.RecvBank,h.RecvBranch", ",h.BankCode,h.BankBranch") & "
) c
ON a.BranchCode=c.BranchCode
AND a.ChqNo=c.ChqNo " & If(pType = "CU", "AND a.RecvBank=c.RecvBank AND a.RecvBranch=c.RecvBranch ", "AND a.BankCode=c.BankCode AND a.BankBranch=c.BankBranch ") & "
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
set h.TotalAdvance=ROUND(d.TotalAdvance,2),
h.TotalCharge=ROUND(d.TotalCharge,2),
h.TotalIsTaxCharge=ROUND(d.TotalIsTaxCharge,2),
h.TotalIs50Tavi=ROUND(d.TotalIs50Tavi,2),
h.TotalVAT=ROUND(d.TotalVAT,2),
h.Total50Tavi=ROUND(d.Total50Tavi,2),
h.SumDiscount=ROUND(d.SumDiscount,2),
h.DiscountCal=ROUND((d.TotalNet-h.TotalCustAdv)*(h.DiscountRate*0.01),2),
h.TotalNet=ROUND((d.TotalNet-h.TotalCustAdv)-((d.TotalNet-h.TotalCustAdv)*(h.DiscountRate*0.01)),2),
h.ForeignNet=ROUND(((d.TotalNet-h.TotalCustAdv)-((d.TotalNet-h.TotalCustAdv)*(h.DiscountRate*0.01)))/h.ExchangeRate,2)
from Job_InvoiceHeader h
inner join (
	select BranchCode,DocNo,
	sum((CASE WHEN AmtCharge>0 THEN Amt-AmtDiscount ELSE 0 END)) as TotalCharge,
	sum((CASE WHEN AmtAdvance>0 THEN TotalAmt ELSE 0 END)) as TotalAdvance,
	sum(case when IsTaxCharge=1 And AmtCharge>0 then Amt-AmtDiscount else 0 end) as TotalIsTaxCharge, 
	sum(case when Is50Tavi=1 And AmtCharge>0 then Amt-AmtDiscount else 0 end) as TotalIs50Tavi,
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
b.CurrencyCode as CurrencyCodeCredit,
b.CurRate as ExchangeRateCredit,
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
            sql &= " FROM Job_InvoiceHeader a INNER JOIN (SELECT h.*,d.InvNo FROM Job_BillAcceptHeader h INNER JOIN Job_BillAcceptDetail d ON h.BranchCode=d.BranchCode AND h.BillAcceptNo=d.BillAcceptNo WHERE NOT ISNULL(h.CancelProve,'')<>'') b "
            sql &= " ON a.BranchCode=b.BranchCode AND a.DocNo=b.InvNo WHERE a.BranchCode='{0}' AND b.BillAcceptNo='{1}' "
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
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND DutyDate IS NULL
        AND JobStatus<>1 AND NOT ISNULL(CancelReson,'')<>''
        UNION
        SELECT BranchCode,JNo,1 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND NOT DutyDate<=GETDATE()
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
              SELECT b.BranchCode,b.JobNo as JNo,SUM(b.BNet-ISNULL(r.TotalRcv,0)-ISNULL(c.CreditNet,0)-ISNULL(r.AmtCredit,0)-ISNULL(r.AmtDiscount,0)) as Balance
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              LEFT JOIN (
                SELECT rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,Sum(rd.Net) as TotalRcv,id.AmtCredit,id.AmtDiscount
                FROM Job_ReceiptHeader rh INNER JOIN Job_ReceiptDetail rd
                ON rh.BranchCode=rd.BranchCode AND rh.ReceiptNo=rd.ReceiptNo
                INNER JOIN Job_InvoiceHeader ih
                ON rd.BranchCode=ih.BranchCode AND rd.InvoiceNo=ih.DocNo
                INNER JOIN Job_InvoiceDetail id
                ON rd.BranchCode=id.BranchCode AND rd.InvoiceNo=id.DocNo AND rd.InvoiceItemNo=id.ItemNo
                WHERE ISNULL(rh.CancelProve,'')='' AND ISNULL(ih.CancelProve,'')='' 
                GROUP BY rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,id.AmtCredit,id.AmtDiscount
              ) r                
              ON b.BranchCode=r.BranchCode AND b.LinkBillNo=r.InvoiceNo AND b.LinkItem=r.InvoiceItemNo
              LEFT JOIN (
                " & SQLSelectCNDNByInvoice() & "
              ) c
              ON b.BranchCode=c.BranchCode AND b.LinkBillNo=c.BillingNo AND b.LinkItem=c.BillItemNo
              WHERE h.DocStatus<>99 AND b.BranchCode=a.BranchCode AND b.JobNo=a.JNo 
              AND b.LinkItem>0 AND ISNULL(b.LinkBillNo,'')<>'' 
              GROUP BY b.BranchCode,b.JobNo
              HAVING SUM(b.BNet-ISNULL(r.TotalRcv,0))<=0
        ) AND a.ConfirmDate IS NOT NULL AND a.CloseJobDate IS NOT NULL  
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'')<>''
        UNION
        SELECT BranchCode,JNo,98 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'')<>'' AND JobStatus<>99 AND ISNULL(CancelProve,'')=''
        UNION
        SELECT BranchCode,JNo,99 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'')<>'' AND ISNULL(CancelProve,'')<>''
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
    Function SQLSelectInvSummary(pSqlw As String) As String
        Dim sqlGroup As String = "
h.BranchCode,h.DocNo,h.Docdate,h.CustCode,h.CustBranch,h.CustTName,h.CustEName,
h.BillToCustCode,h.BillToCustBranch,h.BillTName,h.BillEName,h.ContactName,h.EmpCode,
h.RefNo,h.VATRate,h.TotalAdvance,h.TotalCharge,h.TotalIsTaxCharge,h.TotalIs50Tavi,
h.TotalVAT,h.Total50Tavi,h.TotalCustAdv,h.TotalNet,h.CurrencyCode,h.ExchangeRate,
h.ForeignNet,h.BillAcceptDate,h.BillIssueDate,h.BillAcceptNo,
h.Remark1,h.Remark2,h.Remark3,h.Remark4,h.Remark5,h.Remark6,h.Remark7,h.Remark8,h.Remark9,h.Remark10,
h.CancelReson,h.CancelProve,h.CancelDate,h.CancelTime,h.ShippingRemark,h.SumDiscount,
h.DiscountRate,h.DiscountCal,h.TotalDiscount
"

        Dim sql As String = SQLSelectInvReport(pSqlw)
        sql = "
SELECT " & sqlGroup & "
,sum(h.TotalNet) as TotalInv,sum(ISNULL(h.ReceivedNet,0)) as TotalReceive
,sum(ISNULL(h.CreditNet,0)) as TotalCredit
,sum(h.TotalNet-ISNULL(h.ReceivedNet,0)-ISNULL(h.CreditNet,0)) as TotalBalance
,max(h.ControlLink) as ControlLink
FROM (
" & sql & "
) as h
GROUP BY " & sqlGroup
        Return sql
    End Function
    Function SQLSelectInvReport(Optional psqlW As String = "") As String
        Dim sql As String = "
select ih.*,id.ItemNo,id.SICode,id.SDescription,id.ExpSlipNO,id.SRemark,
id.Amt,id.AmtDiscount,id.AmtCredit,
id.AmtCharge,id.AmtAdvance,id.AmtVat,id.Amt50Tavi,
id.TotalAmt,id.TotalAmt-id.AmtCredit as TotalNet,
r.ReceivedAmt,r.ReceivedVat,r.ReceivedWht,r.ReceivedNet,
r.ReceiptNo,
c.CreditAmt,c.CreditVat,c.CreditWht,c.CreditNet,
c.CreditNo,
r.ControlLink,v.PRVoucher,v.PRType,v.acType,v.ChqNo,v.ChqDate,
v.RecvBank,v.RecvBranch,v.BookCode,v.BankCode,v.BankBranch,
c1.NameThai as CustTName,c2.NameThai as BillTName,
c1.NameEng as CustEName,c2.NameEng as BillEName
from Job_InvoiceDetail id inner join Job_InvoiceHeader ih
on id.BranchCode=ih.BranchCode
and id.DocNo=ih.DocNo
left join (
	select rd.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,
    max(rd.ReceiptNo) as ReceiptNo,
    max(rd.ControlNo + '-' +Convert(varchar,rd.ControlItemNo)) as ControlLink,
	sum(rd.Amt) as ReceivedAmt,
	sum(rd.AmtVAT) as ReceivedVat,
	sum(rd.Amt50Tavi) as ReceivedWht,
	sum(rd.Net) as ReceivedNet
	from Job_ReceiptDetail rd inner join Job_ReceiptHeader rh
	on rd.BranchCode=rh.BranchCode AND rd.ReceiptNo=rh.ReceiptNo
	and ISNULL(rh.CancelProve,'')=''
	group by rd.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo
) r
on id.BranchCode=r.BranchCode AND id.DocNo=r.InvoiceNo AND id.ItemNo=r.InvoiceItemNo
left join (
	" & SQLSelectCNDNByInvoice() & "
) c
on id.BranchCode=c.BranchCode AND id.DocNo=c.BillingNo AND id.ItemNo=c.BillItemNo
left join Job_CashControlSub v ON r.BranchCode=v.BranchCode AND r.ControlLink=(v.ControlNo+'-'+Convert(varchar,v.ItemNo)) 
left join Mas_Company c1 on ih.CustCode=c1.CustCode AND ih.CustBranch=c1.Branch
left join Mas_Company c2 on ih.BillToCustCode=c2.CustCode AND ih.BillToCustBranch=c2.Branch
where ISNULL(ih.CancelProve,'')='' {0}
"
        Return String.Format(sql, psqlW)
    End Function
    Function SQLSelectInvForReceive(bHasVoucher As Boolean) As String
        Dim amtSQL As String = "(id.Amt-ISNULL(id.AmtDiscount,0)-ISNULL(id.AmtCredit,0)-ISNULL(r.ReceivedAmt,0)-ISNULL(c.CreditAmt,0))"
        Dim vatSQL As String = "(id.AmtVat-ISNULL(r.ReceivedVat,0)-ISNULL(c.CreditVat,0))"
        Dim whtSQL As String = "(id.Amt50Tavi-ISNULL(r.ReceivedWht,0)-ISNULL(c.CreditWht,0))"
        Dim netSQL As String = "(id.TotalAmt-ISNULL(id.AmtCredit,0)-ISNULL(c.CreditNet,0)-ISNULL(r.ReceivedNet,0))"
        Return "
select id.BranchCode,'' as ReceiptNo,
0 as ItemNo,0 as CreditAmount,
" & netSQL & " as TransferAmount,
0 as CashAmount,0 as ChequeAmount,'' as ControlNo,'' as VoucherNo,0 as ControlItemNo,
ih.DocNo as InvoiceNo,ih.DocDate as InvoiceDate,id.ItemNo as InvoiceItemNo,
id.SICode,id.SDescription,id.VATRate,id.Rate50Tavi,
" & amtSQL & " as Amt,
" & vatSQL & " as AmtVAT,
" & whtSQL & " as Amt50Tavi,
" & netSQL & " as Net,
id.CurrencyCode as DCurrencyCode,id.ExchangeRate as DExchangeRate,
" & amtSQL & "/id.ExchangeRate as FAmt,
" & vatSQL & "/id.ExchangeRate as FAmtVAT,
" & whtSQL & "/id.ExchangeRate as FAmt50Tavi,
" & netSQL & "/id.ExchangeRate as FNet,
ih.CustCode,ih.CustBranch,ih.BillToCustCode,ih.BillToCustBranch,ih.RefNo,
id.Amt As InvAmt,id.AmtVat as InvVat,id.Amt50Tavi as Inv50Tavi,id.TotalAmt as InvTotal,
id.AmtAdvance,id.AmtCharge,id.AmtDiscount,id.AmtCredit,
c.CreditNo,c.CreditAmt,c.CreditVat,c.CreditWht,c.CreditNet,
ih.BillAcceptNo,ih.BillIssueDate,ih.BillAcceptDate,
r.LastReceiptNo,r.LastControlNo,r.ReceivedAmt,r.ReceivedVat,r.ReceivedWht,r.ReceivedNet
from Job_InvoiceDetail id inner join Job_InvoiceHeader ih
on id.BranchCode=ih.BranchCode
and id.DocNo=ih.DocNo
left join (
	select rd.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,
	sum(rd.Amt) as ReceivedAmt,
	sum(rd.AmtVAT) as ReceivedVat,
	sum(rd.Amt50Tavi) as ReceivedWht,
	sum(rd.Net) as ReceivedNet,
    max(rh.ReceiptNo) as LastReceiptNo,
    max(rd.ControlNo) as LastControlNo,
    max(rh.ReceiptDate) as ReceiptDate
	from Job_ReceiptDetail rd inner join Job_ReceiptHeader rh
	on rd.BranchCode=rh.BranchCode AND rd.ReceiptNo=rh.ReceiptNo
	WHERE ISNULL(rh.CancelProve,'')='' 
    " & If(bHasVoucher, " AND ISNULL(rd.ControlNo,'')<>'' ", "") & "
	group by rd.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo
) r
on id.BranchCode=r.BranchCode AND id.DocNo=r.InvoiceNo AND id.ItemNo=r.InvoiceItemNo
left join (
    " & SQLSelectCNDNByInvoice() & "
) c
on id.BranchCode=c.BranchCode AND id.DocNo=c.BillingNo AND id.ItemNo=c.BillItemNo
"

    End Function
    Function SQLSelectInvByReceive(pRcpNo As String, pNoVoucher As Boolean) As String
        Return "
select id.BranchCode,r.ReceiptNo,
r.ReceiptItemNo as ItemNo,r.CreditAmount,
r.TransferAmount,
r.CashAmount,r.ChequeAmount,r.ControlNo,r.VoucherNo,r.ControlItemNo,
ih.DocNo as InvoiceNo,ih.DocDate as InvoiceDate,id.ItemNo as InvoiceItemNo,
id.SICode,id.SDescription,id.VATRate,id.Rate50Tavi,
ISNULL(r.ReceivedAmt,0) as Amt,
ISNULL(r.ReceivedVat,0) as AmtVAT,
ISNULL(r.ReceivedWht,0) as Amt50Tavi,
ISNULL(r.ReceivedNet,0) as Net,
id.CurrencyCode as DCurrencyCode,id.ExchangeRate as DExchangeRate,
ISNULL(r.ReceivedAmt,0)/id.ExchangeRate as FAmt,
ISNULL(r.ReceivedVat,0)/id.ExchangeRate as FAmtVAT,
ISNULL(r.ReceivedWht,0)/id.ExchangeRate as FAmt50Tavi,
ISNULL(r.ReceivedNet,0)/id.ExchangeRate as FNet,
ih.CustCode,ih.CustBranch,ih.BillToCustCode,ih.BillToCustBranch,ih.RefNo,
id.Amt As InvAmt,id.AmtVat as InvVat,id.Amt50Tavi as Inv50Tavi,id.TotalAmt as InvTotal,
id.AmtAdvance,id.AmtCharge,id.AmtDiscount,id.AmtCredit,
ih.BillAcceptNo,ih.BillIssueDate,ih.BillAcceptDate,r.ReceiptDate,bh.DuePaymentDate
from Job_InvoiceDetail id inner join Job_InvoiceHeader ih
on id.BranchCode=ih.BranchCode
and id.DocNo=ih.DocNo
left join Job_BillAcceptHeader bh ON ih.BranchCode=bh.BranchCode AND ih.BillAcceptNo=bh.BillAcceptNo
inner join (
	select rd.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,
	rd.Amt as ReceivedAmt,
	rd.AmtVAT as ReceivedVat,
	rd.Amt50Tavi as ReceivedWht,
	rd.Net as ReceivedNet,
    rd.CreditAmount,rd.CashAmount,rd.ChequeAmount,rd.TransferAmount,
    rd.ReceiptNo,rh.ReceiptDate,
    rd.ItemNo as ReceiptItemNo,rd.ControlNo,rd.ControlItemNo,rd.VoucherNo
	from Job_ReceiptDetail rd inner join Job_ReceiptHeader rh
	on rd.BranchCode=rh.BranchCode AND rd.ReceiptNo=rh.ReceiptNo
	WHERE ISNULL(rh.CancelProve,'')='' 
    " & If(pRcpNo <> "", " AND rh.ReceiptNo='" & pRcpNo & "' ", "") & "
    " & If(pNoVoucher, " AND ISNULL(rd.ControlNo,'')=''", "") & "
) r
on id.BranchCode=r.BranchCode AND id.DocNo=r.InvoiceNo AND id.ItemNo=r.InvoiceItemNo
where ISNULL(ih.CancelProve,'')='' 
"
    End Function
    Function SQLSelectDocumentByJob(branch As String, job As String) As String
        Dim sql As String = "
SELECT ISNULL(ah.PaymentDate,ah.AdvDate) as DocDate,ah.AdvNo as DocNo,'ADV' as DocType,ad.SDescription as Expense,ad.AdvNet as Amount,ah.DocStatus
FROM Job_AdvHeader ah INNER JOIN Job_AdvDetail ad ON ah.BranchCode=ad.BranchCode AND ah.AdvNo=ad.AdvNo 
WHERE ad.BranchCode='{0}' AND ad.ForJNo='{1}'
UNION 
SELECT ISNULL(ch.ApproveDate,ch.ClrDate) as DocDate,ch.ClrNo as DocNo,'CLR' as DocType,cd.SDescription as Expense,cd.BNet as Amount,ch.DocStatus
FROM Job_ClearHeader ch INNER JOIN Job_ClearDetail cd ON ch.BranchCode=cd.BranchCode AND ch.ClrNo=cd.ClrNo
WHERE cd.BranchCode='{0}' AND cd.JobNo='{1}'
UNION
SELECT ih.DocDate,ih.DocNo,'INV' as DocType,id.SDescription,cd.BNet as Amount,(CASE WHEN ih.BillIssueDate IS NULL THEN 0 ELSE 1 END) as DocStatus
FROM Job_InvoiceHeader ih INNER JOIN Job_InvoiceDetail id ON ih.BranchCode=id.BranchCode AND ih.DocNo=id.DocNo
INNER JOIN Job_ClearDetail cd ON id.BranchCode=cd.BranchCode AND id.DocNo=cd.LinkBillNo AND id.ItemNo=cd.LinkItem
WHERE cd.BranchCode='{0}' AND cd.JobNo='{1}'
UNION
select ch.ChqDate,ch.ChqNo,'CHQ' as DocType,Convert(varchar,ch.ChqAmount) +' REF# '+ch.PRVoucher as Descr,SUM(ISNULL(cd.PaidAmount,0)) as Amount,
(CASE WHEN ISNULL(vc.PostedBy,'')<>'' THEN 1 ELSE (CASE WHEN vc.CancelProve<>'' THEN 99 ELSE 0 END) END) as DocStatus
FROM Job_CashControlSub ch INNER JOIN Job_CashControl vc ON ch.BranchCode=vc.BranchCode AND ch.ControlNo=vc.ControlNo
LEFT JOIN Job_CashControlDoc cd ON ch.BranchCode=cd.BranchCode AND ch.ControlNo=cd.ControlNo AND ch.acType=cd.acType
WHERE ch.BranchCode='{0}' AND ch.ForJNo='{1}'
GROUP BY ch.ChqDate,ch.ChqNo,ch.ChqAmount,ch.PRVoucher,vc.PostedBy,vc.CancelProve
UNION
select rh.ReceiptDate,rh.ReceiptNo,'RCV' as DocType,rd.SDescription +' INV#' + rd.InvoiceNo as Descr,cd.BNet as Amount,
(CASE WHEN rh.CancelProve<>'' THEN 99 ELSE (CASE WHEN ISNULL(rd.ControlNo,'')<>'' THEN 1 ELSE 0 END) END) as DocStatus
FROM Job_ReceiptHeader rh INNER JOIN Job_ReceiptDetail rd ON rh.BranchCode=rd.BranchCode AND rh.ReceiptNo=rd.ReceiptNo
INNER JOIN Job_ClearDetail cd ON rd.InvoiceNo=cd.LinkBillNo AND rd.InvoiceItemNo=cd.LinkItem
WHERE cd.BranchCode='{0}' AND cd.JobNo='{1}'
"
        Return String.Format(sql, branch, job)
    End Function
    Function SQLSelectSumReceipt(sqlw As String) As String
        Dim sql As String = "
SELECT dbo.Job_Order.BranchCode, dbo.Job_Order.JNo, dbo.Job_Order.InvNo, dbo.Job_Order.CustCode, dbo.Job_Order.ManagerCode, dbo.Job_Order.CSCode, SUM(dbo.Job_ReceiptDetail.Net) AS SumReceipt,
dbo.Job_Order.Commission, dbo.Job_ReceiptDetail.InvoiceNo, dbo.Job_ReceiptDetail.ReceiptNo, SUM(dbo.Job_ReceiptDetail.Net) * (dbo.Job_Order.Commission * 0.01) AS TotalComm
FROM dbo.Job_ClearDetail INNER JOIN
 dbo.Job_ClearHeader ON dbo.Job_ClearDetail.BranchCode = dbo.Job_ClearHeader.BranchCode INNER JOIN
 dbo.Job_ReceiptDetail ON dbo.Job_ClearDetail.BranchCode = dbo.Job_ReceiptDetail.BranchCode AND 
 dbo.Job_ClearDetail.LinkItem = dbo.Job_ReceiptDetail.InvoiceItemNo AND dbo.Job_ClearDetail.LinkBillNo = dbo.Job_ReceiptDetail.InvoiceNo INNER JOIN
 dbo.Job_ReceiptHeader ON dbo.Job_ReceiptDetail.BranchCode = dbo.Job_ReceiptHeader.BranchCode AND 
 dbo.Job_ReceiptDetail.ReceiptNo = dbo.Job_ReceiptHeader.ReceiptNo INNER JOIN
 dbo.Job_Order ON dbo.Job_ClearDetail.BranchCode = dbo.Job_Order.BranchCode AND dbo.Job_ClearDetail.JobNo = dbo.Job_Order.JNo INNER JOIN
 dbo.Job_InvoiceHeader ON dbo.Job_ReceiptDetail.BranchCode = dbo.Job_InvoiceHeader.BranchCode AND 
 dbo.Job_ReceiptDetail.InvoiceNo = dbo.Job_InvoiceHeader.DocNo
WHERE (ISNULL(dbo.Job_InvoiceHeader.CancelProve, '') = '') AND (ISNULL(dbo.Job_ReceiptHeader.ReceiveRef, '') <> '') AND (dbo.Job_ClearHeader.DocStatus <> 99)  {0}
GROUP BY dbo.Job_Order.BranchCode, dbo.Job_Order.JNo, dbo.Job_Order.InvNo, dbo.Job_Order.CustCode, dbo.Job_Order.ManagerCode, dbo.Job_Order.CSCode, dbo.Job_Order.Commission, 
 dbo.Job_ReceiptDetail.InvoiceNo, dbo.Job_ReceiptDetail.ReceiptNo
"
        Return String.Format(sql, sqlw)
    End Function
    Function SQLSelectReceiptReport() As String
        Dim sql As String = "
SELECT rh.*,
c1.NameThai as CustTName,c1.NameEng as CustEName,c1.TAddress1+' '+c1.TAddress2 as CustTAddr,c1.EAddress1+' '+c1.EAddress2 as CustEAddr,c1.Phone as CustPhone,c1.TaxNumber as CustTaxID,
c2.NameThai as BillTName,c2.NameEng as BillEName,c2.TAddress1+' '+c2.TAddress2 as BillTAddr,c2.EAddress1+' '+c2.EAddress2 as BillEAddr,c2.Phone as BillPhone,c2.TaxNumber as BillTaxID,
rd.ItemNo,rd.InvoiceNo,rd.InvoiceItemNo,ih.DocDate as InvoiceDate,ih.BillAcceptNo,ih.BillIssueDate,ih.BillAcceptDate,ih.RefNo,
id.ExpSlipNO,id.AmtCharge,id.AmtAdvance,id.Amt-id.AmtDiscount as InvAmt,id.AmtVat as InvVAT,id.Amt50Tavi as Inv50Tavi,id.TotalAmt as InvTotal,
(SELECT STUFF((
    SELECT DISTINCT ',' + JobNo
    FROM Job_ClearDetail WHERE BranchCode=id.BranchCode
    AND LinkBillNo=id.DocNo AND LinkItem=id.ItemNo
FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
)) as JobNo,
(SELECT STUFF((
    SELECT DISTINCT ',' + ClrNo
    FROM Job_ClearDetail WHERE BranchCode=id.BranchCode
    AND LinkBillNo=id.DocNo AND LinkItem=id.ItemNo
FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
)) as ClrNo,
(SELECT STUFF((
    SELECT DISTINCT ',' + AdvNO
    FROM Job_ClearDetail WHERE BranchCode=id.BranchCode
    AND LinkBillNo=id.DocNo AND LinkItem=id.ItemNo
FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
)) as AdvNo,
rd.SICode,rd.SDescription,rd.Amt,rd.FAmt,rd.AmtVAT,rd.FAmtVAT,rd.Amt50Tavi,rd.FAmt50Tavi,rd.Net,rd.FNet,
rd.DCurrencyCode,rd.DExchangeRate,rd.ControlNo,rd.ControlItemNo,vd.ChqNo,vd.ChqDate,vd.PRVoucher
FROM Job_ReceiptHeader rh INNER JOIN Job_ReceiptDetail rd ON rh.BranchCode=rd.BranchCode AND rh.ReceiptNo=rd.ReceiptNo
INNER JOIN Job_InvoiceDetail id ON rd.BranchCode=id.BranchCode AND rd.InvoiceNo=id.DocNo AND rd.InvoiceItemNo=id.ItemNo
LEFT JOIN Mas_Company c1 ON rh.CustCode=c1.CustCode AND rh.CustBranch=c1.Branch
LEFT JOIN Mas_Company c2 ON rh.BillToCustCode=c2.CustCode AND rh.BillToCustBranch=c2.Branch
INNER JOIN Job_InvoiceHeader ih ON rd.BranchCode=ih.BranchCode AND rd.InvoiceNo=ih.DocNo 
LEFT JOIN Job_CashControlSub vd ON rd.BranchCode=vd.BranchCode AND rd.ControlNo=vd.ControlNo AND rd.ControlItemNo=vd.ItemNo
"
        Return sql
    End Function
    Function SQLSelectServiceBudget() As String
        Return "
SELECT a.*,b.ID,b.TRemark,b.MaxAdvance,b.MaxCost,b.MinCharge,b.MinProfit,b.Active,b.LastUpdate,b.UpdateBy
FROM Job_SrvSingle a LEFT JOIN Job_BudgetPolicy b
ON a.SICode=b.SICode 
"
    End Function
    Function SQLSelectQuotation() As String
        Return "
SELECT dbo.Job_QuotationHeader.BranchCode, dbo.Job_QuotationHeader.QNo, dbo.Job_QuotationHeader.ReferQNo, dbo.Job_QuotationHeader.CustCode, 
    dbo.Job_QuotationHeader.CustBranch, dbo.Job_QuotationHeader.BillToCustCode, dbo.Job_QuotationHeader.BillToCustBranch, 
    dbo.Job_QuotationHeader.ContactName, dbo.Job_QuotationHeader.DocDate, dbo.Job_QuotationHeader.ManagerCode, dbo.Job_QuotationHeader.DescriptionH, 
    dbo.Job_QuotationHeader.DescriptionF, dbo.Job_QuotationHeader.TRemark, dbo.Job_QuotationHeader.DocStatus, dbo.Job_QuotationHeader.ApproveBy, 
    dbo.Job_QuotationHeader.ApproveDate, dbo.Job_QuotationHeader.ApproveTime, dbo.Job_QuotationHeader.CancelBy, dbo.Job_QuotationHeader.CancelDate, 
    dbo.Job_QuotationHeader.CancelReason, dbo.Job_QuotationDetail.JobType, dbo.Job_QuotationDetail.ShipBy, dbo.Job_QuotationDetail.Description, 
    dbo.Job_QuotationDetail.SeqNo, dbo.Job_QuotationItem.ItemNo, dbo.Job_QuotationItem.IsRequired, dbo.Job_QuotationItem.NetProfit, dbo.Job_QuotationItem.CommissionAmt, 
    dbo.Job_QuotationItem.CommissionPerc, dbo.Job_QuotationItem.BaseProfit, dbo.Job_QuotationItem.VenderCost, dbo.Job_QuotationItem.VenderCode, 
    dbo.Job_QuotationItem.UnitDiscntAmt, dbo.Job_QuotationItem.UnitDiscntPerc, dbo.Job_QuotationItem.TotalCharge, dbo.Job_QuotationItem.TotalAmt, 
    dbo.Job_QuotationItem.TaxAmt, dbo.Job_QuotationItem.TaxRate, dbo.Job_QuotationItem.IsTax, dbo.Job_QuotationItem.VatAmt, dbo.Job_QuotationItem.VatRate, 
    dbo.Job_QuotationItem.Isvat, dbo.Job_QuotationItem.ChargeAmt, dbo.Job_QuotationItem.CurrencyRate, dbo.Job_QuotationItem.CurrencyCode, 
    dbo.Job_QuotationItem.UnitCheck, dbo.Job_QuotationItem.QtyEnd, dbo.Job_QuotationItem.QtyBegin, dbo.Job_QuotationItem.CalculateType, 
    dbo.Job_QuotationItem.DescriptionThai, dbo.Job_QuotationItem.SICode
FROM dbo.Job_QuotationHeader INNER JOIN
    dbo.Job_QuotationDetail ON dbo.Job_QuotationHeader.BranchCode = dbo.Job_QuotationDetail.BranchCode AND 
    dbo.Job_QuotationHeader.QNo = dbo.Job_QuotationDetail.QNo INNER JOIN
    dbo.Job_QuotationItem ON dbo.Job_QuotationDetail.BranchCode = dbo.Job_QuotationItem.BranchCode AND 
    dbo.Job_QuotationDetail.QNo = dbo.Job_QuotationItem.QNo AND dbo.Job_QuotationDetail.SeqNo = dbo.Job_QuotationItem.SeqNo
"
    End Function
    Function SQLSelectPaymentReport() As String
        Return "
SELECT h.BranchCode, h.DocNo, h.DocDate, h.VenCode, v.TaxNumber, v.TName, v.English, v.TAddress1, v.TAddress2, v.EAddress1, v.EAddress2, v.Phone, v.FaxNumber, 
v.GLAccountCode, v.ContactAcc, v.ContactSale, v.ContactSupport1, v.ContactSupport2, v.ContactSupport3, v.WEB_SITE, h.ContactName, h.EmpCode, h.PoNo, 
h.VATRate, h.TaxRate, h.TotalExpense, h.TotalTax, h.TotalVAT, h.TotalDiscount, h.TotalNet, h.Remark, h.CancelReson, h.CancelProve, h.CancelDate, h.CancelTime, 
h.CurrencyCode, h.ExchangeRate, h.ForeignAmt, h.RefNo, h.PayType, d.ItemNo, d.SICode, d.SDescription, d.SRemark, d.Qty, d.QtyUnit, d.UnitPrice, d.IsTaxCharge, 
d.Is50Tavi, d.DiscountPerc, d.Amt, d.AmtDisc, d.AmtVAT, d.AmtWHT, d.Total, d.FTotal, d.ForJNo
FROM dbo.Job_PaymentHeader AS h LEFT OUTER JOIN
dbo.Mas_Vender AS v ON h.VenCode = v.VenCode LEFT OUTER JOIN
dbo.Job_PaymentDetail AS d ON h.BranchCode = d.BranchCode AND h.DocNo = d.DocNo
"
    End Function
    Function GetJobPrefix(data As CJobOrder) As String
        Dim formatStr As String = GetValueConfig("RUNNING_FORMAT", "JOBNO")
        If formatStr = "" Then formatStr = jobPrefix
        Dim jobType As String = GetValueConfig("JOB_TYPE", data.JobType.ToString("00"))
        Dim shipBy As String = GetValueConfig("SHIP_BY", data.ShipBy.ToString("00"))
        Dim Customer As String = data.CustCode
        If jobType <> "" Then formatStr = formatStr.Replace("[J]", jobType.Substring(0, 1))
        If shipBy <> "" Then formatStr = formatStr.Replace("[S]", shipBy.Substring(0, 1))
        If Customer <> "" Then formatStr = formatStr.Replace("[C]", Customer.Substring(0, 3))
        Return formatStr
    End Function
    Function SaveLog(cust As String, app As String, modl As String, action As String, msg As String) As String
        Try
            Dim clientIP = HttpContext.Current.Request.UserHostAddress
            Dim cnMas = ConfigurationManager.ConnectionStrings("TawanConnectionString").ConnectionString
            Dim oLog As New CLog(cnMas)
            oLog.AppID = app
            oLog.CustID = cust & "(" & clientIP & ")"
            oLog.ModuleName = modl
            oLog.LogAction = action
            oLog.Message = msg
            Return oLog.SaveData(" WHERE LogID=0 ")
        Catch ex As Exception
            Dim str = "[ERROR] : " & ex.Message
            Return str
        End Try
    End Function
    Function SaveLogFromObject(cust As String, app As String, modl As String, action As String, obj As Object) As String
        Dim clientIP = HttpContext.Current.Request.UserHostAddress
        Try
            Dim cnMas = ConfigurationManager.ConnectionStrings("TawanConnectionString").ConnectionString
            Dim oLog As New CLog(cnMas)
            oLog.AppID = app
            oLog.CustID = cust & "(" & clientIP & ")"
            oLog.ModuleName = modl
            oLog.LogAction = action
            oLog.Message = JsonConvert.SerializeObject(obj)
            Return oLog.SaveData(" WHERE LogID=0 ")
        Catch ex As Exception
            Main.SaveLog(cust, app, modl, "SaveLogFromObject", ex.Message)
            Dim str = "[ERROR] : " & ex.Message
            Return str
        End Try
    End Function
    Function GetDatabaseList(pCustomer As String, pApp As String) As List(Of String)
        Dim db = New List(Of String)
        Dim cnMas = ConfigurationManager.ConnectionStrings("TawanConnectionString").ConnectionString
        Try
            Dim tb = New CUtil(cnMas).GetTableFromSQL(String.Format("SELECT * FROM TWTCustomerApp WHERE CustID='{0}' AND AppID='{1}' ", pCustomer, pApp))
            If tb.Rows.Count > 0 Then
                For Each dr As DataRow In tb.Rows
                    db.Add(dr("WebTranDB").ToString())
                Next
            End If
        Catch ex As Exception

        End Try
        Return db
    End Function
    Function GetDatabaseProfile(pCustomer As String) As DataTable
        Dim cnMas = ConfigurationManager.ConnectionStrings("TawanConnectionString").ConnectionString
        Dim tb = New CUtil(cnMas).GetTableFromSQL(String.Format("SELECT * FROM TWTCustomer WHERE CustID='{0}' ", pCustomer))
        Return tb
    End Function
    Function GetApplicationProfile(pCustomer As String) As DataTable
        Dim cnMas = ConfigurationManager.ConnectionStrings("TawanConnectionString").ConnectionString
        Dim tb = New CUtil(cnMas).GetTableFromSQL(String.Format("SELECT a.*,b.SubscriptionName,b.Edition,b.BeginDate,b.ExpireDate,b.LoginCount FROM TWTCustomerApp a INNER JOIN TWTSubscription b ON a.SubscriptionID=b.SubScriptionID WHERE a.CustID='{0}' AND a.AppID='JOBSHIPPING' ", pCustomer))
        Return tb
    End Function
    Function GetDatabaseConnection(pCustomer As String, pApp As String, pSeq As String) As String()
        Dim db = New String() {ConfigurationManager.ConnectionStrings("JobWebConnectionString").ConnectionString.ToString, ConfigurationManager.ConnectionStrings("JobMasConnectionString").ConnectionString.ToString}
        Try
            Dim cnMas = ConfigurationManager.ConnectionStrings("TawanConnectionString").ConnectionString
            Using tb As DataTable = New CUtil(cnMas).GetTableFromSQL(String.Format("SELECT * FROM TWTCustomerApp WHERE CustID='{0}' AND AppID='{1}' AND Seq='{2}'", pCustomer, pApp, pSeq))
                If tb.Rows.Count > 0 Then
                    db = New String() {tb.Rows(0)("WebTranConnect").ToString, tb.Rows(0)("WebMasConnect").ToString}
                End If
            End Using
        Catch ex As Exception

        End Try
        Return db
    End Function
    Function SetDatabaseMaster(pDBName As String) As Boolean
        Try
            Dim bChk As Boolean = False
            Using cn As New SqlConnection(pDBName)
                cn.Open()
                bChk = (cn.State = ConnectionState.Open)
                If bChk Then
                    jobMasConn = pDBName
                End If
                cn.Close()
                Return bChk
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function SetDatabaseJob(pDBName As String) As Boolean
        Try
            Dim bChk As Boolean = False
            Using cn As New SqlConnection(pDBName)
                cn.Open()
                bChk = (cn.State = ConnectionState.Open)
                If bChk Then
                    jobWebConn = pDBName
                End If
                cn.Close()
                Return bChk
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function SQLSelectJobCount(tsqlW As String, tGroup As String) As String
        Dim oCfg = Main.GetDataConfig("JOB_STATUS")
        Dim sqlCheckStatus As String = ""
        For Each cfg In oCfg
            sqlCheckStatus &= ",SUM("
            sqlCheckStatus &= "CASE WHEN j.JobStatus=" & Convert.ToInt16(cfg.ConfigKey) & " THEN 1 ELSE 0 END"
            sqlCheckStatus &= ") as '" & cfg.ConfigValue & "'"
        Next
        If sqlCheckStatus = "" Then
            sqlCheckStatus = ",COUNT(*) as TotalJob"
        End If
        Dim sql = "
SELECT " & tGroup & "
" & sqlCheckStatus & "
FROM Job_Order j {0}
GROUP BY " & tGroup
        sql = String.Format(sql, tsqlW)
        Return sql

    End Function
    Public Function SQLDashboard3(tSqlW As String) As String
        Dim oCfg = Main.GetDataConfig("JOB_STATUS")
        Dim sqlCheckStatus As String = ""
        For Each cfg In oCfg
            sqlCheckStatus &= ",SUM("
            sqlCheckStatus &= "CASE WHEN j.JobStatus=" & Convert.ToInt16(cfg.ConfigKey) & " THEN 1 ELSE 0 END"
            sqlCheckStatus &= ") as '" & cfg.ConfigValue & "'"
        Next
        If sqlCheckStatus = "" Then
            sqlCheckStatus = ",COUNT(*) as TotalJob"
        End If
        Dim sql = "
SELECT j.CustCode
" & sqlCheckStatus & "
FROM Job_Order j {0}
GROUP BY j.CustCode
"
        sql = String.Format(sql, tSqlW)
        Return sql
    End Function
    Public Function SQLDashboard2(tSqlW As String) As String
        Dim oCfg = Main.GetDataConfig("JOB_STATUS")
        Dim sqlCheckStatus As String = ""
        For Each cfg In oCfg
            sqlCheckStatus &= ",SUM("
            sqlCheckStatus &= "CASE WHEN j.JobStatus=" & Convert.ToInt16(cfg.ConfigKey) & " THEN 1 ELSE 0 END"
            sqlCheckStatus &= ") as '" & cfg.ConfigValue & "'"
        Next
        If sqlCheckStatus = "" Then
            sqlCheckStatus = ",COUNT(*) as TotalJob"
        End If
        Dim sql = "
SELECT j.JobType
" & sqlCheckStatus & "
FROM Job_Order j {0}
GROUP BY j.JobType
"
        sql = String.Format(sql, tSqlW)
        Return sql
    End Function
    Public Function SQLDashboard1(tSqlW As String) As String
        Dim sql = "
SELECT j.JobStatus,
COUNT(*) as TotalJob
FROM Job_Order j {0}
GROUP BY j.JobStatus
"
        sql = String.Format(sql, tSqlW)
        Return sql
    End Function
    Public Function SQLSelectClearExp() As String
        Dim sql = "
SELECT a.BranchCode,a.JNo,a.SICode,a.SDescription,a.TRemark,a.AmountCharge,a.Status,b.ClrNo
FROM dbo.Job_ClearExp a
LEFT JOIN (
SELECT BranchCode,JobNo,SICode,Max(ClrNo) as ClrNo
FROM dbo.Job_ClearDetail
GROUP BY BranchCode,JobNo,SICode
) b
ON a.BranchCode=b.BranchCode AND a.JNo=b.JobNo AND a.SICode=b.SICode
"
        Return sql
    End Function
    Public Function SQLSelectTrackingCount(tSqlW As String) As String
        Dim sql As String = "
SELECT t.JobStatus,COUNT(DISTINCT t.JNo) AS TotalJob FROM (" & SQLSelectTracking(tSqlW) & ") as t GROUP BY t.JobStatus 
"
        Return sql
    End Function
    Public Function SQLSelectTrackingDay(useDay As String, onDate As Date, cutoffDay As Integer, tSQLW As String) As String
        Dim oCfg = Main.GetDataConfig("JOB_TYPE")
        Dim sqlCheckStatus As String = ""
        For Each cfg In oCfg
            sqlCheckStatus &= ",SUM(CASE WHEN JobType=" & CInt(cfg.ConfigKey) & " THEN 1 ELSE 0 END)"
            sqlCheckStatus &= " as '" & cfg.ConfigValue & "'"
        Next
        Dim sqlGroup As String = "
(CASE WHEN Day(" & useDay & ") <=Day(DATEADD(d,-" & cutoffDay & ",'" & onDate.ToString("yyyy-MM-dd") & "')) THEN '00' ELSE 
(CASE WHEN Day(" & useDay & ") >=Day(DATEADD(d," & cutoffDay & ",'" & onDate.ToString("yyyy-MM-dd") & "')) THEN '99' ELSE FORMAT(" & useDay & ",'dd/MM/yy') END)
END)
"
        Dim sql As String = "
SELECT 
" & sqlGroup & " as JobDay
" & sqlCheckStatus & "
FROM Job_Order WHERE JobStatus<90 AND " & useDay & " IS NOT NULL
" & tSQLW & "
GROUP BY " & sqlGroup & "
ORDER BY 1
"
        Return sql
    End Function
    Public Function SQLSelectTracking(tsqlW As String) As String
        Dim sql = "
SELECT dbo.Job_Order.BranchCode, dbo.Job_Order.JNo, dbo.Job_LoadInfo.VenderCode, dbo.Job_LoadInfo.ContactName, dbo.Job_LoadInfo.BookingNo, 
dbo.Job_LoadInfo.LoadDate, dbo.Job_LoadInfo.Remark, dbo.Job_LoadInfo.PackingPlace, dbo.Job_LoadInfo.CYPlace, dbo.Job_LoadInfo.FactoryPlace, 
dbo.Job_LoadInfo.ReturnPlace, dbo.Job_LoadInfo.PackingDate, dbo.Job_LoadInfo.CYDate, dbo.Job_LoadInfo.FactoryDate, dbo.Job_LoadInfo.ReturnDate, 
dbo.Job_LoadInfo.PackingTime, dbo.Job_LoadInfo.CYTime, dbo.Job_LoadInfo.FactoryTime, dbo.Job_LoadInfo.ReturnTime, dbo.Job_LoadInfo.NotifyCode, 
dbo.Job_LoadInfo.TransMode, dbo.Job_LoadInfo.PaymentCondition, dbo.Job_LoadInfo.PaymentBy, dbo.Job_LoadInfoDetail.ItemNo, 
dbo.Job_LoadInfoDetail.CTN_NO, dbo.Job_LoadInfoDetail.SealNumber, dbo.Job_LoadInfoDetail.TruckNO, dbo.Job_LoadInfoDetail.TruckIN, 
dbo.Job_LoadInfoDetail.Start, dbo.Job_LoadInfoDetail.Finish, dbo.Job_LoadInfoDetail.TimeUsed, dbo.Job_LoadInfoDetail.CauseCode, 
dbo.Job_LoadInfoDetail.Comment, dbo.Job_LoadInfoDetail.TruckType, dbo.Job_LoadInfoDetail.Driver, dbo.Job_LoadInfoDetail.TargetYardDate, 
dbo.Job_LoadInfoDetail.TargetYardTime, dbo.Job_LoadInfoDetail.ActualYardDate, dbo.Job_LoadInfoDetail.ActualYardTime, 
dbo.Job_LoadInfoDetail.UnloadFinishDate, dbo.Job_LoadInfoDetail.UnloadFinishTime, dbo.Job_LoadInfoDetail.UnloadDate, dbo.Job_LoadInfoDetail.UnloadTime, 
dbo.Job_LoadInfoDetail.Location, dbo.Job_LoadInfoDetail.ReturnDate AS TruckReturnDate, dbo.Job_LoadInfoDetail.ShippingMark, 
dbo.Job_LoadInfoDetail.ProductDesc, dbo.Job_LoadInfoDetail.CTN_SIZE, dbo.Job_LoadInfoDetail.ProductQty, dbo.Job_LoadInfoDetail.ProductUnit, 
dbo.Job_LoadInfoDetail.GrossWeight, dbo.Job_LoadInfoDetail.Measurement, dbo.Job_Order.DocDate, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, 
dbo.Job_Order.CustContactName, dbo.Job_Order.QNo, dbo.Job_Order.Revise, dbo.Job_Order.ManagerCode, dbo.Job_Order.CSCode, dbo.Job_Order.Description, 
dbo.Job_Order.TRemark, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.InvNo, dbo.Job_Order.InvTotal, 
dbo.Job_Order.InvProduct, dbo.Job_Order.InvCountry, dbo.Job_Order.InvFCountry, dbo.Job_Order.InvInterPort, dbo.Job_Order.InvProductQty, 
dbo.Job_Order.InvProductUnit, dbo.Job_Order.InvCurUnit, dbo.Job_Order.InvCurRate, dbo.Job_Order.ImExDate, dbo.Job_Order.BLNo, dbo.Job_Order.ClearPort, 
dbo.Job_Order.ClearPortNo, dbo.Job_Order.ClearDate, dbo.Job_Order.ForwarderCode, dbo.Job_Order.AgentCode, dbo.Job_Order.VesselName, 
dbo.Job_Order.ETDDate, dbo.Job_Order.ETADate, dbo.Job_Order.FNetPrice, dbo.Job_Order.BNetPrice, dbo.Job_Order.CloseJobDate, dbo.Job_Order.CloseJobTime, 
dbo.Job_Order.CloseJobBy, dbo.Job_Order.DeclareType, dbo.Job_Order.DeclareNumber, dbo.Job_Order.DeclareStatus, dbo.Job_Order.EstDeliverDate, 
dbo.Job_Order.EstDeliverTime, dbo.Job_Order.DutyDate, dbo.Job_Order.DutyAmount, dbo.Job_Order.ConfirmChqDate, dbo.Job_Order.ShippingEmp, 
dbo.Job_Order.TotalGW, dbo.Job_Order.GWUnit, dbo.Job_Order.ReadyToClearDate, dbo.Job_Order.Commission, dbo.Job_Order.CommPayTo, 
dbo.Job_Order.MVesselName, dbo.Job_Order.ProjectName, dbo.Job_Order.TotalNW, dbo.Job_Order.CustRefNO, dbo.Job_Order.TotalQty, dbo.Job_Order.HAWB, 
dbo.Job_Order.MAWB, dbo.Job_Order.consigneecode, dbo.Job_Order.privilegests, dbo.Job_LoadInfoDetail.DeliveryNo, dbo.Job_Order.DeliveryTo, 
dbo.Job_Order.DeliveryAddr, dbo.Job_Order.ShippingCmd, dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, dbo.Mas_Company.TAddress1, 
dbo.Mas_Company.TAddress2, dbo.Mas_Company.EAddress1, dbo.Mas_Company.EAddress2, dbo.Mas_Company.Phone, dbo.Mas_Company.FaxNumber, 
dbo.Mas_Company.GLAccountCode, dbo.Mas_Company.BillToCustCode, dbo.Mas_Company.BillToBranch, dbo.Mas_Company.TaxNumber
FROM  dbo.Mas_Company RIGHT OUTER JOIN
dbo.Job_Order LEFT OUTER JOIN
dbo.Mas_Vender RIGHT OUTER JOIN
dbo.Job_LoadInfo RIGHT OUTER JOIN
dbo.Job_LoadInfoDetail ON dbo.Job_LoadInfo.BranchCode = dbo.Job_LoadInfoDetail.BranchCode AND 
dbo.Job_LoadInfo.BookingNo = dbo.Job_LoadInfoDetail.BookingNo
ON dbo.Mas_Vender.BranchCode = dbo.Job_LoadInfo.BranchCode ON 
dbo.Job_Order.JNo = dbo.Job_LoadInfoDetail.JNo AND dbo.Job_Order.BranchCode = dbo.Job_LoadInfoDetail.BranchCode ON 
dbo.Mas_Company.Branch = dbo.Job_Order.CustBranch AND dbo.Mas_Company.CustCode = dbo.Job_Order.CustCode
WHERE (dbo.Job_Order.JobStatus < '90') {0}
"
        Return String.Format(sql, tsqlW)
    End Function
    Public Function SQLSelectTransport(tsqlW As String) As String
        Dim sql = "
SELECT dbo.Job_LoadInfo.BranchCode, dbo.Job_LoadInfo.JNo, dbo.Job_LoadInfo.VenderCode, dbo.Job_LoadInfo.ContactName, dbo.Job_LoadInfo.BookingNo, 
dbo.Job_LoadInfo.LoadDate, dbo.Job_LoadInfo.Remark, dbo.Job_LoadInfo.PackingPlace, dbo.Job_LoadInfo.CYPlace, dbo.Job_LoadInfo.FactoryPlace, 
dbo.Job_LoadInfo.ReturnPlace, dbo.Job_LoadInfo.PackingDate, dbo.Job_LoadInfo.CYDate, dbo.Job_LoadInfo.FactoryDate, dbo.Job_LoadInfo.ReturnDate, 
dbo.Job_LoadInfo.PackingTime, dbo.Job_LoadInfo.CYTime, dbo.Job_LoadInfo.FactoryTime, dbo.Job_LoadInfo.ReturnTime, dbo.Job_LoadInfo.NotifyCode, 
dbo.Job_LoadInfo.TransMode, dbo.Job_LoadInfo.PaymentCondition, dbo.Job_LoadInfo.PaymentBy, dbo.Job_LoadInfoDetail.ItemNo, 
dbo.Job_LoadInfoDetail.CTN_NO, dbo.Job_LoadInfoDetail.SealNumber, dbo.Job_LoadInfoDetail.TruckNO, dbo.Job_LoadInfoDetail.TruckIN, 
dbo.Job_LoadInfoDetail.Start, dbo.Job_LoadInfoDetail.Finish, dbo.Job_LoadInfoDetail.TimeUsed, dbo.Job_LoadInfoDetail.CauseCode, 
dbo.Job_LoadInfoDetail.Comment, dbo.Job_LoadInfoDetail.TruckType, dbo.Job_LoadInfoDetail.Driver, dbo.Job_LoadInfoDetail.TargetYardDate, 
dbo.Job_LoadInfoDetail.TargetYardTime, dbo.Job_LoadInfoDetail.ActualYardDate, dbo.Job_LoadInfoDetail.ActualYardTime, 
dbo.Job_LoadInfoDetail.UnloadFinishDate, dbo.Job_LoadInfoDetail.UnloadFinishTime, dbo.Job_LoadInfoDetail.UnloadDate, dbo.Job_LoadInfoDetail.UnloadTime, 
dbo.Job_LoadInfoDetail.Location, dbo.Job_LoadInfoDetail.ReturnDate AS TruckReturnDate, dbo.Job_LoadInfoDetail.ShippingMark, 
dbo.Job_LoadInfoDetail.ProductDesc, dbo.Job_LoadInfoDetail.CTN_SIZE, dbo.Job_LoadInfoDetail.ProductQty, dbo.Job_LoadInfoDetail.ProductUnit, 
dbo.Job_LoadInfoDetail.GrossWeight, dbo.Job_LoadInfoDetail.Measurement, dbo.Job_Order.DocDate, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, 
dbo.Job_Order.CustContactName, dbo.Job_Order.QNo, dbo.Job_Order.Revise, dbo.Job_Order.ManagerCode, dbo.Job_Order.CSCode, dbo.Job_Order.Description, 
dbo.Job_Order.TRemark, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.InvNo, dbo.Job_Order.InvTotal, 
dbo.Job_Order.InvProduct, dbo.Job_Order.InvCountry, dbo.Job_Order.InvFCountry, dbo.Job_Order.InvInterPort, dbo.Job_Order.InvProductQty, 
dbo.Job_Order.InvProductUnit, dbo.Job_Order.InvCurUnit, dbo.Job_Order.InvCurRate, dbo.Job_Order.ImExDate, dbo.Job_Order.BLNo, dbo.Job_Order.ClearPort, 
dbo.Job_Order.ClearPortNo, dbo.Job_Order.ClearDate, dbo.Job_Order.ForwarderCode, dbo.Job_Order.AgentCode, dbo.Job_Order.VesselName, 
dbo.Job_Order.ETDDate, dbo.Job_Order.ETADate, dbo.Job_Order.FNetPrice, dbo.Job_Order.BNetPrice, dbo.Job_Order.CloseJobDate, dbo.Job_Order.CloseJobTime, 
dbo.Job_Order.CloseJobBy, dbo.Job_Order.DeclareType, dbo.Job_Order.DeclareNumber, dbo.Job_Order.DeclareStatus, dbo.Job_Order.EstDeliverDate, 
dbo.Job_Order.EstDeliverTime, dbo.Job_Order.DutyDate, dbo.Job_Order.DutyAmount, dbo.Job_Order.ConfirmChqDate, dbo.Job_Order.ShippingEmp, 
dbo.Job_Order.TotalGW, dbo.Job_Order.GWUnit, dbo.Job_Order.ReadyToClearDate, dbo.Job_Order.Commission, dbo.Job_Order.CommPayTo, 
dbo.Job_Order.MVesselName, dbo.Job_Order.ProjectName, dbo.Job_Order.TotalNW, dbo.Job_Order.CustRefNO, dbo.Job_Order.TotalQty, dbo.Job_Order.HAWB, 
dbo.Job_Order.MAWB, dbo.Job_Order.consigneecode, dbo.Job_Order.privilegests, dbo.Job_LoadInfoDetail.DeliveryNo, dbo.Job_Order.DeliveryTo, 
dbo.Job_Order.DeliveryAddr,dbo.Job_Order.ShippingCmd, dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, dbo.Mas_Company.TAddress1, dbo.Mas_Company.TAddress2, 
dbo.Mas_Company.EAddress1, dbo.Mas_Company.EAddress2, dbo.Mas_Company.Phone, dbo.Mas_Company.FaxNumber, dbo.Mas_Company.GLAccountCode, 
dbo.Mas_Company.BillToCustCode, dbo.Mas_Company.BillToBranch,dbo.Mas_Company.TaxNumber 
FROM dbo.Mas_Company RIGHT OUTER JOIN
dbo.Job_Order RIGHT OUTER JOIN
dbo.Job_LoadInfoDetail ON dbo.Job_Order.JNo = dbo.Job_LoadInfoDetail.JNo AND 
dbo.Job_Order.BranchCode = dbo.Job_LoadInfoDetail.BranchCode RIGHT OUTER JOIN
dbo.Mas_Vender RIGHT OUTER JOIN
dbo.Job_LoadInfo ON dbo.Mas_Vender.BranchCode = dbo.Job_LoadInfo.BranchCode ON dbo.Job_LoadInfoDetail.BranchCode = dbo.Job_LoadInfo.BranchCode AND 
dbo.Job_LoadInfoDetail.BookingNo = dbo.Job_LoadInfo.BookingNo ON dbo.Mas_Company.Branch = dbo.Job_Order.CustBranch AND 
dbo.Mas_Company.CustCode = dbo.Job_Order.CustCode
WHERE (dbo.Job_LoadInfo.BookingNo <> '') {0}
"
        Return String.Format(sql, tsqlW)
    End Function
    Function SQLUpdateGLHeader() As String
        Dim sql As String = "
UPDATE a
SET a.TotalDebit=ISNULL(b.SumDebit,0),
a.TotalCredit=ISNULL(b.SumCredit,0)
FROM Job_GLHeader a LEFT JOIN (
    SELECT BranchCode,GLRefNo,SUM(DebitAmt) as SumDebit,SUM(CreditAmt) as SumCredit
    FROM Job_GLDetail GROUP BY BranchCode,GLRefNo
) b
ON a.BranchCode=b.BranchCode AND a.GLRefNo=b.GLRefNo
"
        Return sql
    End Function
    Function SQLSelectRoleAll() As String
        Return "
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
    End Function
    Function SQLSelectBillReport() As String
        Dim sql = "
SELECT h.BranchCode, h.BillAcceptNo, h.BillDate, h.CustCode, h.CustBranch, h.BillRecvBy, h.BillRecvDate, h.DuePaymentDate, h.BillRemark, h.CancelReson, 
h.CancelProve, h.CancelDate, h.CancelTime, h.EmpCode, h.RecDateTime, h.TotalCustAdv, h.TotalAdvance, h.TotalChargeVAT, h.TotalChargeNonVAT, h.TotalVAT, 
h.TotalWH, h.TotalDiscount, h.TotalNet, d.ItemNo, d.InvNo, d.AmtAdvance, d.AmtChargeNonVAT, d.AmtChargeVAT, d.AmtWH, d.AmtVAT, d.AmtTotal, d.CurrencyCode, 
d.ExchangeRate, d.AmtCustAdvance, d.AmtForeign, d.InvDate, d.RefNo, d.AmtVATRate, d.AmtWHRate, d.AmtDiscount, d.AmtDiscRate
FROM dbo.Job_BillAcceptHeader AS h INNER JOIN
dbo.Job_BillAcceptDetail AS d ON h.BranchCode = d.BranchCode
"
        Return sql
    End Function
End Module
