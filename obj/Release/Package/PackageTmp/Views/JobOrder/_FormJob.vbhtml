
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Job Acknowledgement"
End Code
<div class="page" contenteditable="false">
    <table id="tblHeader" width="100%">
        <tr>
            <td>
                <img id="imgLogo" src="~/Resource/logo-idl.jpg" width="80%" />
            </td>
            <td>
                <div id="divCompany" style="text-align:left;color:darkblue;"></div>
            </td>
        </tr>
    </table>
    <hr />
    <div id="divReportName" style="text-align:center;color:black;">
        <b>JOB ACKNOWLEDGEMENT</b>
    </div>
    <br />
    <table id="divJobInfo" width="100%">
        <tr>
            <td colspan="2">
                <b>Job No : </b><input type="text" style="border:groove;text-align:center" id="txtJNo" value="" />
            </td>
            <td align="right">
                <b>Job Type : <label id="lblJobType"></label></b>
            </td>
            <td align="right">
                <b>Ship By : <label id="lblShipBy"></label></b>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <b>  Quotation : </b><label id="lblQuotation"></label>
            </td>
            <td align="right">
                <b>Confirm Date : </b><label id="lblConfirmDate"></label>
            </td>
            <td align="right">
                <b>Open Date : </b><label id="lblOpenDate"></label>
            </td>
        </tr>
    </table>
    <hr />
    <div id="divCustomer">
        <b>Customer : </b><label id="lblCustCode"></label> / <label id="lblCustName"></label>
        <div id="dvAddr"></div>
        <b>Tel : </b><label id="lblTel"></label>
        <b>  Fax : </b><label id="lblFax"></label>
        <b>  Contact : </b><label id="lblContact"></label>
    </div>
    <hr />
    <div id="divBillingPlace">
        <b>Billing Place : </b><label id="lblBillToCustCode"></label> / <label id="lblBillToCustName"></label>
        <div id="dvBillAddr"></div>
    </div>
    <hr />
    <table id="tbInvoiceInfo" width="100%">
        <tr>
            <td colspan="3">
                <b>INVOICE NO : </b><label id="lblInvNo"></label>
            </td>
            <td align="right">
                <b>RATE :</b>1 <label id="lblCurrency"></label>=<label id="lblExcRate"></label> THB
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <b>COMMODITY : </b><label id="lblInvProduct"></label>
            </td>
            <td>
                <b> QTY : </b><label id="lblInvQty"></label> <label id="lblInvUnit"></label>
            </td>
            <td align="right">
                <b>TOTAL : </b><label id="lblInvTotal"></label>
            </td>
        </tr>
        <tr>
            <td>
                <b> PACKAGE : </b><label id="lblPackQty"></label> <label id="lblPackUnit"></label>
            </td>
            <td>
                <b> GROSS WT : </b><label id="lblTotalGW"></label> <label id="lblGWUnit"></label>
            </td>
            <td>
                <b> NET WT : </b><label id="lblTotalNW"></label> <label id="lblNWUnit"></label>
            </td>
            <td align="right">
                <b> M3 : </b><label id="lblMeasurement"></label>
            </td>
        </tr>
        <tr>
            <td>
                <b> BOOKING : </b><label id="lblBookingNo"></label>
            </td>
            <td>
                <b> H.BL/AWB : </b><label id="lblHAWBNo"></label>
            </td>
            <td>
                <b> M.BL/AWB : </b><label id="lblMAWBNo"></label>
            </td>
            <td align="right">
                <b> DECLARE NO : </b><label id="lblDeclareNo"></label>
            </td>
        </tr>
        <tr>
            <td>
                <b> DUTY.AMT : </b><label id="lblDutyAmt"></label>
            </td>
            <td>
                <b> T/X RULES : </b><label id="lblTaxPrivilege"></label>
            </td>
            <td colspan="2" align="right">
                <b> DECL.TYPE : </b><label id="lblDeclareType"></label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <b> SHIPPING NOTE : </b><label id="lblShippingCmd"></label>
            </td>
            <td colspan="2" align="right">
                <b> SHIPPING : </b><label id="lblShippingName"></label>
            </td>
        </tr>
    </table>
    <hr />
    <table id="tbShipmentInfo" width="100%">
        <tr>
            <td colspan="2">
                <b>FROM : </b><label id="lblFromCountry"></label>
            </td>
            <td align="right" colspan="2">
                <b>PORT : </b><label id="lblFromPort"></label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <b>TO : </b><label id="lblToCountry"></label>
            </td>
            <td align="right" colspan="2">
                <b>PORT : </b><label id="lblToPort"></label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <b>VESSEL : </b><label id="lblVesselName"></label>
            </td>
            <td colspan="2" align="right">
                <b>AGENT : </b><label id="lblAgentName"></label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <b>LOADING / CTN : </b><label id="lblTotalContainer"></label>
            </td>
            <td colspan="2" align="right">
                <b>TRANSPORTER : </b><label id="lblTransportName"></label>
            </td>
        </tr>
        <tr>
            <td>
                <b> ETD : </b><label id="lblETDDate"></label>
            </td>
            <td>
                <b> ETA : </b><label id="lblETADate"></label>
            </td>
            <td>
                <b> LOAD : </b><label id="lblLoadDate"></label>
            </td>
            <td align="right">
                <b> DELIVERY : </b><label id="lblDeliveryDate"></label>
            </td>
        </tr>
    </table>
    <hr />
    <div id="divRemark"></div>
    <hr />
    <table id="tblFooter">
        <tr>
            <td colspan="2" width="60%" align="left" valign="top">
                <b>NOTE:</b>
            </td>
            <td colspan="2" align="center" width="40%">
                <b>PREPARED BY:</b>
                <br />
                <br />
                <br />
                <br />
                -------------------------------------
                <br />
                <b>(<label id="lblCSName"></label>)</b>
                <br />
                <label id="lblPosition"></label>
            </td>
        </tr>
    </table>
    <p style="text-align:right">Printed By : @ViewBag.User Printed Date : @DateTime.Now &copy; @DateTime.Now.Year - Tawan Technology Co.,ltd</p>
</div>
<div class="page" contenteditable="false">
    <b>Expenses List</b>
    <table width="100%" style="border-collapse:collapse;">
        <tr>
            <td style="border-style:solid;border-width:thin">
                Duty Advance
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
            <td style="border-style:solid;border-width:thin">
                Tariff Analysis
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
        </tr>
        <tr>
            <td style="border-style:solid;border-width:thin">
                Penalty/Added Tax
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
            <td style="border-style:solid;border-width:thin">
                Officer Service
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
        </tr>
        <tr>
            <td style="border-style:solid;border-width:thin">
                Storage
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
            <td style="border-style:solid;border-width:thin">
                Document Copied
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
        </tr>
        <tr>
            <td style="border-style:solid;border-width:thin">
                D/O Checking
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
            <td style="border-style:solid;border-width:thin">
                Clearance Status
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
        </tr>
        <tr>
            <td style="border-style:solid;border-width:thin">
                Open Container
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
            <td style="border-style:solid;border-width:thin">
                Clearance Exception
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
        </tr>
        <tr>
            <td style="border-style:solid;border-width:thin">
                Freights
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
            <td style="border-style:solid;border-width:thin">
                Staff Control
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
        </tr>
        <tr>
            <td style="border-style:solid;border-width:thin">
                Insurance
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
            <td style="border-style:solid;border-width:thin">
                Inventory Arrangement
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
        </tr>
        <tr>
            <td style="border-style:solid;border-width:thin">
                Internal Transport
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
            <td style="border-style:solid;border-width:thin">
                Internal Labour
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
        </tr>
        <tr>
            <td style="border-style:solid;border-width:thin">
                BL/AWB Clearance
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
            <td style="border-style:solid;border-width:thin">
                Transport Labour
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
        </tr>
        <tr>
            <td style="border-style:solid;border-width:thin">
                Stock Checking
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
            <td style="border-style:solid;border-width:thin">
                Trailer Service
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
        </tr>
        <tr>
            <td style="border-style:solid;border-width:thin">
                Inspector Name
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
            <td style="border-style:solid;border-width:thin">
                Haulage
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
        </tr>
        <tr>
            <td style="border-style:solid;border-width:thin">
                Sampler
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
            <td style="border-style:solid;border-width:thin">
                Others
            </td>
            <td style="border-style:solid;border-width:thin" width="100px"></td>
        </tr>
    </table>
    <p style="text-align:right">Printed By : @ViewBag.User Printed Date : @DateTime.Now &copy; @DateTime.Now.Year - Tawan Technology Co.,ltd</p>
</div>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    //$(document).ready(function () {
        ShowCompany('#divCompany');
        var br = getQueryString('BranchCode');
        var jno = getQueryString('JNo');
        if (br != "" && jno != "") {
            GetJob(br, jno);
        }
    //});
    function GetJob(Branch, Job) {
        $.get(path+'joborder/getjobsql?branch=' + Branch + '&jno=' + Job)
            .done(function (r) {
                if (r.job.data.length > 0) {
                    var rec = r.job.data[0];
                    DisplayData(rec);
                    return;
                }
        });

    }
    function ShowCustomer(Code, Branch, isCons) {
        if (isCons == true) {
            $('#lblBillToCustName').text('-');
            $('#dvBillAddr').html('<b>Address : </b>-');
        }
        if (isCons == false) {
            $('#lblCustName').text('-');
            $('#dvAddr').html('<b>Address : </b>-');
            $('#lblTel').text('-');
            $('#lblFax').text('-');
        }
        if ((Code + Branch).length > 0) {
            $.get(path +'Master/GetCompany?Code=' + Code + '&Branch=' + Branch)
                .done(function (r) {
                    if (r.company.data.length > 0) {
                        var c = r.company.data[0];
                        if (isCons == true) {
                            $('#lblBillToCustName').text(c.NameThai + ' Tax Reference :' + c.TaxNumber);
                            $('#dvBillAddr').html('<b>Address : </b>'
                                + (c.TAddress1 + ' ' + c.TAddress2).trim());
                        }
                        if (isCons == false) {
                            $('#lblCustName').text(c.NameThai);
                            $('#dvAddr').html('<b>Address : </b>'
                                + (c.TAddress1 + ' ' + c.TAddress2).trim());
                            $('#lblTel').text(c.Phone);
                            $('#lblFax').text(c.FaxNumber);
                        }
                    }
                });
        }
    }
    function DisplayData(j) {
        $('#txtJNo').val(j.JNo);
        $('#lblOpenDate').text(ShowDate(j.DocDate));
        $('#lblConfirmDate').text(ShowDate(j.ConfirmDate));
        $('#lblETDDate').text(ShowDate(j.ETDDate));
        $('#lblETADate').text(ShowDate(j.ETADate));
        $('#lblLoadDate').text(ShowDate(j.LoadDate));
        $('#lblDeliveryDate').text(ShowDate(j.EstDeliverDate));
        $('#lblQuotation').text(j.QNo);
        $('#lblInvNo').text(j.InvNo);
        $('#lblCurrency').text(j.InvCurUnit);
        $('#lblExcRate').text(j.InvCurRate);
        $('#lblInvProduct').text(j.InvProduct);
        $('#lblInvTotal').text(j.InvTotal + ' ' + j.InvCurUnit);
        $('#lblInvQty').text(j.InvProductQty);
        $('#lblInvUnit').text(j.InvProductUnit);
        $('#lblPackQty').text(j.TotalQty);
        $('#lblPackUnit').text('UNIT');
        $('#lblTotalGW').text(j.TotalGW);
        $('#lblGWUnit').text(j.GWUnit);
        $('#lblTotalNW').text(j.TotalNW);
        $('#lblNWUnit').text(j.GWUnit);
        $('#lblMeasurement').text(j.Measurement);
        $('#lblBookingNo').text(j.BLNo);
        $('#lblHAWBNo').text(j.HAWB);
        $('#lblMAWBNo').text(j.MAWB);
        $('#lblVesselName').text(j.VesselName);
        $('#lblTotalContainer').text(j.TotalContainer);
        $('#lblDeclareNo').text(j.DeclareNumber);
        $('#lblContact').text(j.CustContactName);
        $('#lblDutyAmt').text(j.DutyAmount);
        $('#lblTaxPrivilege').text(j.Description);
        $('#lblShippingCmd').text(j.ShippingCmd);
        $('#divRemark').html('<b>REMARKS:</b>' + j.TRemark);

        var jt = j.JobType;
        var sb = j.ShipBy;
        if (jt < 10) jt = '0' + jt;
        if (sb < 10) sb = '0' + sb;
        ShowConfig(path, 'JOB_TYPE', jt, '#lblJobType');
        ShowConfig(path, 'SHIP_BY', sb, '#lblShipBy');

        $('#lblCustCode').text(j.CustCode);
        ShowCustomer(j.CustCode, j.CustBranch, false);

        $('#lblBillToCustCode').text(j.consigneecode);
        ShowCustomer(j.consigneecode, j.CustBranch, true);

        if (j.JobType == '1') {
            ShowCountry(path,j.InvFCountry, '#lblFromCountry');
            ShowCountry(path,j.InvCountry, '#lblToCountry');
            ShowInterPort(path,j.InvFCountry, j.InvInterPort, '#lblFromPort');
            ShowReleasePort(path,j.ClearPort, '#lblToPort');
        } else {
            ShowCountry(path,j.InvFCountry, '#lblToCountry');
            ShowCountry(path,j.InvCountry, '#lblFromCountry');
            ShowInterPort(path,j.InvCountry, j.InvInterPort, '#lblToPort');
            ShowReleasePort(path,j.ClearPort, '#lblFromPort');
        }
        ShowVender(path,j.ForwarderCode, '#lblAgentName');
        ShowVender(path,j.AgentCode, '#lblTransportName');

        ShowDeclareType(path,j.DeclareType,'#lblDeclareType');
        ShowUser(path,j.CSCode, '#lblCSName');
        ShowUser(path,j.ShippingEmp, '#lblShippingName');

        $('#lblPosition').text('Customer Services');
    }

</script>