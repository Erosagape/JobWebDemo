@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.ReportName = "JOB COSTING SUMMARY"
    ViewBag.Title = "Job Costing Summary"
End Code
<style>
    td {
        font-size: 11px;
    }
    tr {
        vertical-align: top;
    }

    table {
        border-width: thin;
        border-collapse: collapse;
    }
</style>
<div style="display:flex">
    <div style="flex:2">
        JOB TYPE : <label id="lblJobTypeName"></label>
    </div>
    <div style="flex:1">
        JOB DATE : <label id="lblJobDate"></label>
    </div>
</div>

<div style="display:flex">
    <div style="flex:2">
        CUST NAME : <label id="lblCustName"></label>
    </div>
    <div style="flex:1">
        SHIP BY : <label id="lblShipByName"></label>
    </div>
</div>

<div style="display:flex">
    <div style="flex:1">
        INVOICE : <label id="lblInvNo"></label>
    </div>
    <div style="flex:1">
        DECLARE NO : <label id="lblDeclareNo"></label>
    </div>
    <div style="flex:1">
        VESSEL : <label id="lblVesselName"></label>
    </div>
</div>

<div style="display:flex">
    <div style="flex:2">
        PRODUCT NAME : <label id="lblProductName"></label>
    </div>
    <div style="flex:1">
        WEIGHT : <label id="lblGrossWeight"></label>
    </div>
</div>

<div style="display:flex">
    <div style="flex:1">
        CONTAINER : <label id="lblContainer"></label>
    </div>
    <div style="flex:1">
        SERVICE BY : <label id="lblCSName"></label>
    </div>
    <div style="flex:1">
        QUANTITY : <label id="lblInvQty"></label>
    </div>
</div>

<div style="display:flex">
    <div style="flex:2">
        <table id="tbAdv" style="width:98%" border="1">
            <thead>
                <tr class="text-center">
                    <th width="5%">NO.</th>
                    <th width="15%">PAY DATE</th>
                    <th width="25%">ADV NO</th>
                    <th width="35%">PRE ADVANCE</th>
                    <th width="15%">AMOUNT</th>
                </tr>
            </thead>
            <tbody>
            </tbody>
            <tr>
                <td colspan="4">
                    <div style="display:flex">
                        <div style="flex:1">

                        </div>

                        <div style="flex:1">
                            <br />
                            VAT <br />
                            TOTAL VAT
                        </div>

                        <div style="flex:1">
                            <br />
                            <label id="lblTotalADVVAT"></label><br />
                            <label id="lblTotalADVAfterVAT"></label>
                        </div>

                        <div style="flex:1">
                            TOTAL AMOUNT<br />
                            TAX AMOUNT<br />
                            GRAND TOTAL
                        </div>
                    </div>
                </td>
                <td style="text-align:right">
                    <label id="lblTotalADVAmt"></label><br />
                    <label id="lblTotalADVWHT"></label><br />
                    <label id="lblTotalADV"></label>
                </td>
            </tr>
        </table>
    </div>

    <div style="flex:1">
        <table id="tbCustAdv" style="width:100%" border="1">
            <thead>
                <tr>
                    <th>CUST ADVANCE</th>
                    <th>AMOUNT</th>
                </tr>
            </thead>
            <tbody>
            </tbody>
            <tr>
                <th style="text-align:right">TOTAL ADVANCE</th>
                <td style="text-align:right"><label id="lblTotalCustAdv"></label></td>
            </tr>
        </table>
    </div>
</div>

<br />

<div style="display:flex">
    <div style="flex:1">
        <table id="tbClear" style="width:100%" border="1">
            <thead>
                <tr class="text-center">
                    <th width="10%">CL.NO</th>
                    <th width="35%">DESCRIPTION</th>
                    <th width="15%">CHARGEABLE</th>
                    <th width="10%">WH-TAX</th>
                    <th width="15%">COST</th>
                    <th width="15%">PROFIT</th>
                </tr>
            </thead>
            <tbody>
            </tbody>
            <tr>
                <td colspan="2" height="50PX">
                    <div style="display:flex">
                        <div style="flex:1">
                            TOTAL VAT
                        </div>

                        <div style="flex:1">
                            <label id="lblTotalVAT"></label>
                        </div>

                        <div style="flex:1;text-align:right">
                            PRE-INVOICED
                        </div>

                    </div>
                </td>
                <td style="text-align:right"><label id="lblSumCharge"></label></td>
                <td style="text-align:right"><label id="lblSumTax"></label></td>
                <td style="text-align:right"><label id="lblSumCost"></label></td>
                <td style="text-align:right"><label id="lblSumProfit"></label></td>
            </tr>
        </table>
    </div>
</div>

<div style="display:flex">
    <div style="flex:1">

    </div>
    <div style="flex:1">
        <table style="width:50%" border="1" align="right">
            <tr style="text-align:right">
                <td width="60%">COMMISSION</td>
                <td><label id="lblCommRate"></label></td>
            </tr>
            <tr style="text-align:right">
                <td width="40%">NET PROFIT</td>
                <td><label id="lblNetProfit"></label></td>
            </tr>
        </table>
    </div>
</div>

<br />
<table id="tbCheque" style="width:100%" border="1">
    <thead>
        <tr class="text-center">
            <th>CHEQUE NO.</th>
            <th>BANK</th>
            <th>CHEQUE DATE</th>
            <th>CHEQUE AMT</th>
            <th>USED</th>
            <th>REMARK</th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    $(document).ready(function () {
        ShowCompany('#divCompany');
        let br = getQueryString('BranchCode');
        let jno = getQueryString('JNo');
        if (br != "" && jno != "") {
            GetJob(br, jno);
        }
    });
    function GetJob(branch,code) {
        GetClearingInfo(branch, code);
        GetAdvanceInfo(branch, code);
        GetChequeInfo(branch, code);
    }
    function GetChequeInfo(branch, code) {
        $.get(path + 'acc/getvouchergrid?branch=' + branch + '&job=' + code + '&type=CHQR', function (r) {
            let html = '';
            if (r.voucher.length > 0) {
                for (o of r.voucher.data[0].Table) {
                    html += '<tr>';
                    html += '<td>'+o.ChqNo+'</td>';
                    html += '<td>'+o.BankCode+'</td>';
                    html += '<td>'+ShowDate(CDateTH(o.ChqDate))+'</td>';
                    html += '<td>'+o.ChqAmount+'</td>';
                    html += '<td>'+o.SumAmount+'</td>';
                    html += '<td>'+o.DRemark+'</td>';
                    html += '</tr>';
                }
            }
            let dv = $('#tbCheque tbody');
            dv.html(html);
        });
    }
    function GetAdvanceInfo(branch, code) {
        $.get(path + 'adv/getadvancereport?branchcode=' + branch + '&jobno=' + code +'&advtype=1,2,3,4,5', function (r) {
            let html1 = '';
            let html2 = '';
            let i = 0;
            let itotalvat = 0;
            let itotalpay = 0;
            let itotalwht = 0;
            let itotalamt = 0;
            let itotalnet = 0;
            let jtotaladv = 0;
            let j = 0;
            if (r.adv.data.length > 0) {
                let d = r.adv.data[0].Table;

                for (let i = 0; i < d.length; i++){
                    let o = d[i];
                    if (o.AdvType < 5) {
                        itotalamt += o.BaseAmount;
                        itotalvat += o.ChargeVAT;
                        itotalwht += o.Charge50Tavi;
                        itotalpay += o.AdvPayAmount;
                        itotalnet += o.AdvNet;

                        html1 += '<tr>';
                        html1 += '<td>' + i+1 + '</td>';
                        html1 += '<td>' + ShowDate(o.PaymentDate) + '</td>';
                        html1 += '<td>' + o.AdvNo + '#' + o.ItemNo + '</td>';
                        html1 += '<td>' + o.SICode + '-' + o.SDescription + '</td>';
                        html1 += '<td class="text-align:right">' + CCurrency(CDbl(o.AdvPayAmount, 2)) + '</td>';
                        html1 += '</tr>';
                    } else {
                        j += 1;
                        jtotaladv += o.AdvPayAmount;
                        html2 += '<tr>';
                        html2 += '<td>' + o.SICode + '-' + o.SDescription + ' #' + o.AdvNo + '</td>';
                        html2 += '<td class="text-align:right">' + CCurrency(CDbl(o.AdvPayAmount, 2)) + '</td>';
                        html2 += '</tr>';
                    }
                }
            }
            let d1 = $('#tbAdv tbody');
            d1.html(html1);

            let d2 = $('#tbCustAdv tbody');
            d2.html(html2);

            $('#lblTotalCustAdv').text(CCurrency(CDbl(jtotaladv, 2)));
            $('#lblTotalADVVAT').text(CCurrency(CDbl(itotalvat,2)));
            $('#lblTotalADVAfterVAT').text(CCurrency(CDbl(itotalpay,2)));
            $('#lblTotalADVAmt').text(CCurrency(CDbl(itotalamt,2)));
            $('#lblTotalADVWHT').text(CCurrency(CDbl(itotalwht,2)));
            $('#lblTotalADV').text(CCurrency(CDbl(itotalnet,2)));

        });
    }
    function GetClearingInfo(branch,code) {
        $.get(path + 'clr/getclearingreport?branch=' + branch + '&job=' + code, function (r) {
            let html = '';

            let amtvat = 0;
            let amtwht = 0;
            let amttotal = 0;
            let amtprofit = 0;
            let amtcost = 0;
            if (r.data.length > 0) {
                let h = r.data[0].Table[0];
                $('#lblJobTypeName').text(h.JobTypeName);
                $('#lblJobDate').text(ShowDate(CDateTH(h.JobDate)));
                $('#lblCustName').text(h.NameThai);
                $('#lblShipByName').text(h.ShipByName);
                $('#lblInvNo').text(h.InvNo);
                $('#lblDeclareNo').text(h.DeclareNumber);
                $('#lblVesselName').text(h.VesselName);
                $('#lblProductName').text(h.InvProduct);
                $('#lblGrossWeight').text(h.TotalGW);
                $('#lblContainer').text(h.TotalContainer);
                $('#lblCSName').text(h.ClrByName);
                $('#lblInvQty').text(h.InvProductQty);
                $('#lblCommRate').text(h.Commission);

                let d = r.data[0].Table.filter(function (data) {
                    return data.BNet !== 0;
                });
                for (let i = 0; i < d.length; i++){
                    let amt = d[i].UsedAmount + d[i].ChargeVAT - (d[i].IsCredit == 1 ? d[i].Tax50Tavi : 0);
                    let adv = (d[i].IsCredit == 1 ? amt : 0);
                    let serv = (d[i].IsCredit == 0 && d[i].IsExpense == 0 ? amt : 0);
                    let cost = (d[i].IsExpense == 1 || d[i].IsCredit==1 ? amt : 0);
                    let profit = (d[i].IsExpense == 1 ? amt*-1 : d[i].IsCredit==1 ? 0 : amt);

                    if (d[i].IsCredit == 0 && d[i].IsExpense == 0) {
                        if (d[i].IsTaxCharge > 0) {
                            amtvat += d[i].ChargeVAT;
                        }
                        if (d[i].Is50Tavi > 0) {
                            amtwht += d[i].Tax50Tavi;
                        }
                    }
                    html += '<tr>';
                    html += '<td>' + d[i].ClrNo + '#' + d[i].ItemNo + '</td>';
                    html += '<td>' + d[i].SICode + '-' + d[i].SDescription;
                    if (d[i].AdvNO !== null) html +=' จากใบเบิก '+ d[i].AdvNO;
                    if (d[i].SlipNO !== null) html += 'ใบเสริ็จเลขที่ ' + d[i].SlipNO;

                    html += '</td>';
                    html += '<td style="text-align:right">' + CCurrency(CDbl(adv + serv, 2)) + '</td>';
                    html += '<td style="text-align:right">' + CCurrency(CDbl(d[i].Tax50Tavi, 2)) + '</td>';
                    html += '<td style="text-align:right">' + CCurrency(CDbl(cost, 2)) + '</td>';
                    html += '<td style="text-align:right">' + CCurrency(CDbl(profit,2)) + '</td>';
                    html += '</tr>';

                    amtcost += cost;
                    amttotal += serv + adv;
                    amtprofit += profit;
                }
            }
            $('#tbClear tbody').html(html);

            $('#lblSumCharge').text(CCurrency(CDbl(amttotal,2)));
            $('#lblSumTax').text(CCurrency(CDbl(amtwht,2)));
            $('#lblSumCost').text(CCurrency(CDbl(amtcost,2)));
            $('#lblSumProfit').text(CCurrency(CDbl(amtprofit,2)));
            $('#lblTotalVAT').text(CCurrency(CDbl(amtvat,2)));
            $('#lblNetProfit').text(CCurrency(CDbl(amtprofit-(amtprofit*(h.Commission/100)),2)));

        });
    }
</script>