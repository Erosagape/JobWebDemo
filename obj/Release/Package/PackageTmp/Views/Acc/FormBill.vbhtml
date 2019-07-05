
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Billing Slip"
    ViewBag.ReportName = "BILLING COVER SHEET"
End Code
<style>
    td {
        font-size: 11px;
    }

    table {
        border-width: thin;
        border-collapse: collapse;
    }
</style>
        <div style="display:flex;">
            <div style="flex:1;" class="text-left">
                <p>
                  TAX-ID : <label id="lblTaxNumber"></label>
                </p>
            </div>
            <div style="flex:1;" class="text-right">
                DOC NO : <label id="lblBillAcceptNo"></label>
                <br />DATE : <label id="lblBillDate"></label>
            </div>
        </div>
        <div style="display:flex;">
            <div class="text-left">
                <p>
                    NAME : <label id="lblCustName"></label>
                </p>
            </div>
        </div>
        <div style="display:flex;flex-direction:column">
            <div style="flex:1" class="text-left">
                <label id="lblCustAddress"></label>
            </div>
            <div style="flex:1"  class="text-left">
                <br/>
                PLEASE APPROVE BEFORE PAYMENT             
            </div>                
        </div>
        <table border="1" style="border-style:solid;width:100%;margin-top:5px ">
            <thead>
                <tr>
                    <th class="text-center" width="100" rowspan="2">ITEMS</th>
                    <th class="text-center" width="100" rowspan="2">ISSUE DATE</th>
                    <th class="text-center" width="130" rowspan="2">INVOICE NO.</th>
                    <th class="text-center" width="130" rowspan="2">JOB NO.</th>
                    <th class="text-center" colspan="2">AMOUNT</th>
                    <th class="text-center" width="60" rowspan="2">VAT</th>
                    <th class="text-center" colspan="2">W/H</th>
                    <th class="text-center" width="100" rowspan="2">TOTAL</th>
                </tr>
                <tr>
                    <th class="text-center" width="130">REIMBURSEMENT</th>
                    <th class="text-center" width="90">SERVICE</th>
                    <th class="text-center" width="50">1%</th>
                    <th class="text-center" width="50">3%</th>
                </tr>
            </thead>
            <tbody id="tbDetail">

            </tbody>
            <tfoot>
                <tr>
                    <td style="text-align:right" colspan="4">TOTAL</td>
                    <td style="text-align:right"><label id="lblSumAdv"></label></td>
                    <td style="text-align:right"><label id="lblSumService"></label></td>
                    <td style="text-align:right"><label id="lblSumVat"></label></td>
                    <td style="text-align:right"><label id="lblSumWh1"></label></td>
                    <td style="text-align:right"><label id="lblSumWh3"></label></td>
                    <td style="text-align:right"><label id="lblBillTotal"></label></td>
                </tr>
                <tr style="background-color:lightblue">
                    <th class="text-center" colspan="10"><label id="lblBillTotalEng"></label></th>
                </tr>
            </tfoot>
        </table>

        <div style="margin-top:60px">
            <p>PAYMENT TERMS... @ViewBag.PROFILE_PAYMENT_CREDIT_DAYS... DAYS (FROM BILLING DATE) ________/________/____________</p>
            <p>PLEASE PAY CHEQUE IN NAME @ViewBag.PROFILE_COMPANY_NAME</p>
            <p>PAYMENT SHOULD BE PAID BY CROSS CHEQUE IN FAVOR OF  @ViewBag.PROFILE_COMPANY_NAME</p>
            <p>SIGN ON RECEIVER AND ASSIGNED PAYMENT DATE AND SEND THIS PAPER TO @ViewBag.PROFILE_COMPANY_NAME FAX. @ViewBag.PROFILE_COMPANY_FAX</p>
        </div>

        <div style="display:flex">
            <div style="flex:1;border:1px solid black ;border-radius:5px;text-align:center">
                FOR THE CUSTOMER<br/>
                <br/><br /><br /><br />
                __________________________________________<br/>
                .........................................<br />
                _____/______/______
            </div>
            <div style="flex:1;border:1px solid black ;border-radius:5px;text-align:center">
                FOR @ViewBag.PROFILE_COMPANY_NAME<br />
                <br /><br /><br /><br />
                __________________________________________<br />
                .........................................<br />
                _____/______/______
            </div>
        </div>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    
    let branch = getQueryString('branch');
    let billno = getQueryString('code');
    $.get(path + 'acc/getbilling?branch=' + branch + '&code=' + billno, function (r) {
        if (r.billing.header !== null) {
            ShowData(r.billing);
        }
    });
    function ShowData(data) {
        if (data.header.length > 0) {
            $('#lblBillAcceptNo').text(data.header[0][0].BillAcceptNo);
            $('#lblBillDate').text(ShowDate(CDateTH(data.header[0][0].BillDate)));
        }
        if (data.customer.length > 0) {
            $('#lblTaxNumber').text(data.customer[0][0].TaxNumber);
            $('#lblCustName').text(data.customer[0][0].NameThai);
            $('#lblCustAddress').text(data.customer[0][0].TAddress1 + '\n' + data.customer[0][0].TAddress2);
        }
        if (data.detail.length > 0) {
            let total = 0;
            let serv = 0;
            let adv = 0;
            let vat = 0;
            let wh1 = 0;
            let wh3 = 0;
            
            let dv = $('#tbDetail');
            let html = '';
            for (let dr of data.detail[0]) {
                html += '<tr>';
                html += '<td>' + dr.ItemNo + '</td>';
                html += '<td>' + ShowDate(CDateTH(dr.InvDate)) + '</td>';
                html += '<td>' + dr.InvNo + '</td>';
                html += '<td>' + dr.RefNo + '</td>';
                html += '<td style="text-align:right">' + ShowNumber(dr.AmtAdvance, 2) + '</td>';
                html += '<td style="text-align:right">' + ShowNumber(dr.AmtChargeNonVAT, 2) + '</td>';
                html += '<td style="text-align:right">' + ShowNumber(dr.AmtVAT, 2) + '</td>';
                html += '<td style="text-align:right">' + (dr.AmtWHRate==1 ? ShowNumber(dr.AmtWH, 2) : 0) + '</td>';
                html += '<td style="text-align:right">' + (dr.AmtWHRate!==1 ? ShowNumber(dr.AmtWH, 2) : 0) + '</td>';
                html += '<td style="text-align:right">' + ShowNumber(dr.AmtTotal, 2) + '</td>';
                html += '</tr>';

                total += Number(dr.AmtTotal);
                serv += Number(dr.AmtChargeNonVAT);
                adv += Number(dr.AmtAdvance);
                vat += Number(dr.AmtVAT);
                wh1 += Number(dr.AmtWHRate == 1 ? ShowNumber(dr.AmtWH, 2) : 0);
                wh3 += Number(dr.AmtWHRate !== 1 ? ShowNumber(dr.AmtWH, 2) : 0);
            }
            dv.html(html);
            $('#lblSumAdv').text(ShowNumber(adv, 2));
            $('#lblSumService').text(ShowNumber(serv, 2));
            $('#lblSumVat').text(ShowNumber(vat, 2));
            $('#lblSumWh1').text(ShowNumber(wh1, 2));
            $('#lblSumWh3').text(ShowNumber(wh3, 2));

            $('#lblBillTotal').text(ShowNumber(total,2));
            $('#lblBillTotalEng').text(CNumEng(total));
        }
    }
</script>