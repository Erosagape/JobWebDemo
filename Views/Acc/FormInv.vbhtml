
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Invoice Slip"
End Code
<style>
    td {
        font-size: 11px;
    }
    table {
        border-width:thin;
        border-collapse:collapse;
    }    
</style>
<div style="text-align:center;width:100%">
    <h2>INVOICE</h2>
</div>
<div>
    <div style="display:flex;">
        <div style="flex:2;">
            <label>CUSTOMER:</label>
        </div>
        <div style="flex:1">
            <label>TAX REFERENCE ID:</label>
            <label id="lblTaxNumber"></label>
        </div>
        <div style="flex:1">
            <label>BRANCH:</label>
            <label id="lblTaxBranch"></label>
        </div>
    </div>
    <div style="display:flex;">
        <div style="flex:3;border:1px solid black;border-radius:5px;">
            NAME : <label id="lblCustName"></label><br />
            ADDRESS : <label id="lblCustAddress"></label><br />
            TEL : <label id="lblCustTel"></label><br />
        </div>
        <div style="flex:1;border:1px solid black;border-radius:5px;">
            INV NO. : <label id="lblDocNo"></label><br />
            INV DATE : <label id="lblDocDate"></label><br />
            CUST INV : <label id="lblCustInvNo"></label><br />
            JOB NO : <label id="lblJobNo"></label><br />
        </div>
    </div>
    <div style="display:flex;border:1px solid black;border-radius:5px;">
        <div style="flex:2">
            <div class="row">
                <p class="col-sm-12">
                    FROM :<label id="lblFromCountry"></label>
                </p>
            </div>
            <div class="row">
                <p class="col-sm-12">
                    FLIGHT/VISSEL :<label id="lblVesselName"></label>
                </p>
            </div>
            <div class="row">
                <p class="col-sm-12">
                    QUANTITY/GROSSWEIGHT :<label id="lblQtyGross"></label>
                </p>
            </div>
        </div>
        <div style="flex:2">
            <div class="row">
                <p class="col-sm-12">
                    ETD :<label id="lblETDDate"></label>
                </p>
            </div>
            <div class="row">
                <p class="col-sm-12">
                    HBL/HAWB :<label id="lblHAWB"></label>
                </p>
            </div>
            <div class="row">
                <p class="col-sm-12">
                    MEASUREMENT :<label id="lblMeasurement"></label>
                </p>
            </div>
        </div>
        <div style="flex:2">
            <div class="row">
                <p class="col-sm-12">
                    ETA :<label id="lblETADate"></label>
                </p>
            </div>
            <div class="row">
                <p class="col-sm-12">
                    MBL/MAWB :<label id="lblMAWB"></label>
                </p>
            </div>
        </div>
    </div>
    <table style="width:100%" border="1" class="text-center">
        <thead>
            <tr style="background-color :gainsboro;text-align:center;">
                <th width="100px" rowspan="2">No</th>
                <th width="400px" rowspan="2">DESCRIPTION</th>
                <th colspan="3" rowspan="1">ADVANCE RE-IMBERSEMENT</th>
                <th width="200px" rowspan="2">SERVICE CHARGE</th>
            </tr>
            <tr style="background-color :gainsboro;text-align:center;">
                <th width="120px">SERVICE</th>
                <th width="120px">VAT</th>
                <th width="120px">AMOUNT</th>
            </tr>
        </thead>
        <tbody id="tbDetail"></tbody>
        <tfoot>
            <tr>
                <td colspan="5">
                    <div style="display:flex">
                        <div class="text-left div1" style="flex:3">
                            REMARKS :<br />
                            <label id="lblDescription"></label>
                        </div>
                        <div class="text-right" style="flex:1">
                            SUB TOTAL <br />DISCOUNT<br />CUST. ADV<br />SUBTOTAL 7%<br />VAT 7%<br />TOTAL<br />ADVANCE RE-IMBERSEMENT<br />TOTAL<br />GRAND TOTAL
                        </div>
                    </div>
                </td>
                <td style="background-color :gainsboro;text-align:right;">
                    <label id="lblSumNonVat"></label><br /><label id="lblSumDiscount"></label><br /><label id="lblSumCustAdv"></label><br /><label id="lblSumBeforeVat"></label><br /><label id="lblSumVat"></label><br /><label id="lblSumAfterVat"></label><br /><label id="lblSumAdvance"></label><br /><label id="lblSumTotal"></label><br /><label id="lblSumGrandTotal"></label>
                </td>
            </tr>
            <tr>
                <td>TOTAL (BAHT)</td>
                <td colspan="5">
                    <div style="text-align:center"><label id="lblTotalBaht"></label></div>
                </td>
            </tr>
        </tfoot>
    </table>
    <div style="display:flex">
        <div class="text-left" style="border:1px solid black;border-radius:5px;flex:1">
            WITHHOLDING TAX DETAIL
            <div style="display:flex">
                <div class="text-center" style="flex:3">
                    1%:<br />
                    3%:
                </div>
                <div class="text-center" style="flex:1">
                    <label id="lblSumBaseWht1"></label><br />
                    <label id="lblSumBaseWht3"></label>
                </div>
                <div class="text-center" style="flex:1">
                    <label id="lblSumWht1"></label>
                    <br />
                    <label id="lblSumWht3"></label>
                </div>
            </div>
            <div style="display:flex;">
                <div style="flex:2">
                    NET AMOUNT
                </div>
                <div style="flex:1">
                    <label id="lblSumNetInvoice"></label>
                </div>
            </div>
        </div>
        <div style="border:1px solid black;border-radius:5px;flex:1;text-align:center;">
            FOR THE CUSTOMER <br /><br />
            ......................................................... <br />
            __________/_________/________ <br />
            AUTHORIZED SIGNATURE
        </div>
        <div style="border:1px solid black;border-radius:5px;flex:1;text-align:center;">
            FOR KSA(THAILAND)CO.,LTD. <br /><br />
            ......................................................... <br />
            __________/_________/________ <br />
            AUTHORIZED SIGNATURE
        </div>
    </div>
</div>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    $(document).ready(function () {
        ShowCompany('#divCompany');
        let branch = getQueryString('branch');
        let invno = getQueryString('code');
        $.get(path + 'acc/getinvoice?branch=' + branch + '&code=' + invno, function (r) {
            if (r.invoice.header !== null) {
                ShowData(r.invoice);
            }
        });
    });
    function ShowData(dr) {
        
        if (dr.header[0].length > 0) {
            let h = dr.header[0][0];
            $('#lblDocNo').text(h.DocNo);
            $('#lblDocDate').text(ShowDate(CDateTH(h.DocDate)));

            let c = dr.customer[0][0];            
            if (c !== null) {
                $('#lblTaxNumber').text(c.TaxNumber);
                $('#lblTaxBranch').text(c.Branch);
                $('#lblCustName').text(c.NameThai);
                $('#lblCustAddress').text(c.TAddress1 + '\n'+ c.TAddress2);
                $('#lblCustTel').text(c.Phone);
            }

            let j = dr.job[0][0];
            if (j !== null) {
                $('#lblCustInvNo').text(j.InvNo);
                $('#lblJobNo').text(j.JNo);

                $('#lblFromCountry').text(j.DeclareNumber);
                $('#lblVesselName').text(j.VesselName);
                $('#lblQtyGross').text(j.InvProductQty + ' ' + j.InvProductUnit + ' GW ' + j.TotalGW + ' '+ j.GWUnit);
                $('#lblETDDate').text(ShowDate(CDateTH(j.ETDDate)));
                $('#lblHAWB').text(j.HAWB);
                $('#lblMeasurement').text(j.Measurement);
                $('#lblETADate').text(ShowDate(CDateTH(j.ETADate)));
                $('#lblMAWB').text(j.MAWB);
                $('#lblDescription').text(j.Description);
            }

            $('#lblSumNonVat').text(ShowNumber(h.TotalCharge,2));
            $('#lblSumDiscount').text(ShowNumber(h.TotalDiscount,2));
            $('#lblSumCustAdv').text(ShowNumber(h.TotalCustAdv,2));
            $('#lblSumBeforeVat').text(ShowNumber(h.TotalIsTaxCharge,2));
            $('#lblSumVat').text(ShowNumber(h.TotalVAT,2));
            $('#lblSumAfterVat').text(ShowNumber(Number(h.TotalCharge)+Number(h.TotalVAT),2));
            $('#lblSumAdvance').text(ShowNumber(h.TotalAdvance,2));
            $('#lblSumTotal').text(ShowNumber(Number(h.TotalCharge)+Number(h.TotalAdvance)+Number(h.TotalVAT),2));
            $('#lblSumGrandTotal').text(ShowNumber(Number(h.TotalCharge)+Number(h.TotalAdvance)+Number(h.TotalVAT),2));
            $('#lblTotalBaht').text('(' + CNumThai(CDbl(Number(h.TotalCharge) + Number(h.TotalAdvance) + Number(h.TotalVAT), 2)) + ')');

            $('#lblSumNetInvoice').text(ShowNumber(Number(h.TotalNet),2));
        }
        let d = dr.detail[0];
        let sumbase1 = 0;
        let sumbase3 = 0;
        let sumtax1 = 0;
        let sumtax3 = 0;

        if (d.length > 0) {
            for (let o of d) {
                let html = '<tr>';
                html += '<td style="text-align:center">' + o.ItemNo + '</td>';
                html += '<td>' + o.SICode + '-' + o.SDescription + '</td>';
                html += '<td style="text-align:right">' + ShowNumber(o.AmtAdvance, 2) + '</td>';
                if (o.AmtAdvance > 0) {
                    html += '<td style="text-align:right">' + ShowNumber(o.AmtVat, 2) + '</td>';
                    html += '<td style="text-align:right">' + ShowNumber(o.AmtWht, 2) + '</td>';
                } else {
                    html += '<td style="text-align:right">0.00</td>';
                    html += '<td style="text-align:right">0.00</td>';
                }
                html += '<td style="text-align:right">' + ShowNumber(o.AmtCharge,2) + '</td>';
                html += '</tr>';

                $('#tbDetail').append(html);

                if (o.Amt50Tavi > 0) {
                    if (o.Rate50Tavi == 1) {
                        sumbase1 += o.Amt;
                        sumtax1 += o.Amt50Tavi;
                    } else {
                        sumbase3 += o.Amt;
                        sumtax3 += o.Amt50Tavi;
                    }
                }
            }
        }
        $('#lblSumBaseWht1').text(ShowNumber(sumbase1,2));
        $('#lblSumBaseWht3').text(ShowNumber(sumbase3,2));

        $('#lblSumWht1').text(ShowNumber(sumtax1,2));
        $('#lblSumWht3').text(ShowNumber(sumtax3,2));
    }
</script>