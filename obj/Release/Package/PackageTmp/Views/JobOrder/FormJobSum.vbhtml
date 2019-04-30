
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
    <div style="flex:1" ">
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
        <table id="tbAdv" width="98%" border="1">
            <tr class="text-center">
                <th width="5%">NO.</th>
                <th width="15%">ADV DATE</th>
                <th width="25%">ADV NO</th>
                <th width="35%">PRE ADVANCE</th>
                <th width="15%">AMOUNT</th>
            </tr>
            <tbody>
                <tr>
                    <td class="text-center">1<br />2<br />3<br />4<br />5<br />6<br />7<br />8<br />9<br /></td>
                    <td class="text-center">08/02/2561<br />08/02/2561<br />08/02/2561<br />08/02/2561<br />08/02/2561<br />08/02/2561<br /></td>
                    <td class="text-center">ADV-1802-0014<br />ADV-1802-0014<br />ADV-1802-0014<br />ADV-1802-0014<br />ADV-1802-0014<br />ADV-1802-0014<br /></td>
                    <td>DSR-RE-LOCATION<br />DSR-RE-LOCATION<br />DSR-RE-LOCATION<br />DSR-RE-LOCATION<br />DSR-RE-LOCATION<br />DSR-RE-LOCATION<br /></td>
                    <td style="text-align:right">1000.00<br />1000.00<br />1000.00<br />1000.00<br />1000.00<br />1000.00<br />1000.00<br />1000.00<br /></td>
                </tr>
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
        <table id="tbCustAdv" width="100%" border="1">
            <tr>
                <th>CUST ADVANCE</th>
                <th>AMOUNT</th>
            </tr>
            <tbody>
                <tr>
                    <td>
                        DSR-CARGO PERMIT FEE <br />DSR-CARGO PERMIT FEE <br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;

                    </td>
                    <td style="text-align:right">
                        3,000.00<br />
                        6,000.00
                    </td>
                </tr>
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
        <table id="tbClear" width="100%" border="1">
            <tr class="text-center">
                <th width="10%">CL.NO</th>
                <th width="35%">DESCRIPTION</th>
                <th width="15%">CHARGEABLE</th>
                <th width="10%">WH-TAX</th>
                <th width="15%">COST</th>
                <th width="15%">PROFIT</th>
            </tr>
            <tbody>
                <tr>
                    <td>4<br />5<br />6<br />7<br />8<br />9<br /></td>
                    <td>DS-BILL OF LADING (B/L) FEE <br />DS-BILL OF LADING (B/L) FEE <br />DS-BILL OF LADING (B/L) FEE <br />DS-BILL OF LADING (B/L) FEE <br />DS-BILL OF LADING (B/L) FEE <br />DS-BILL OF LADING (B/L) FEE <br />DS-BILL OF LADING (B/L) FEE <br /></td>
                    <td style="text-align:right">1,500.00<br />1,500.00<br />1,500.00<br />1,500.00<br />1,500.00<br />1,500.00<br /></td>
                    <td style="text-align:right">0.00<br />1,500.00<br />1,500.00<br />1,500.00<br /></td>
                    <td style="text-align:right">0.00<br />1,500.00<br />1,500.00<br />1,500.00<br />1,500.00<br /></td>
                    <td style="text-align:right">1,500.00<br />1,500.00<br />1,500.00<br />1,500.00<br />1,500.00<br /></td>
                </tr>
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

                        <div style="flex:1" style="text-align:right">
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
        <table width="50%" border="1" align="right">
            <tr style="text-align:right">
                <th width="60%">COMMISSION</th>
                <td><label id="lblCommRate"></label></td>
            </tr>
            <tr style="text-align:right">
                <th width="40%">NET PROFIT</th>
                <td><label id="lblNetProfit"></label></td>
            </tr>
        </table>
    </div>
</div>

<br />
<table id="tbCheque" width="100%" border="1">
    <tr class="text-center">
        <th>CHEQUE NO.</th>
        <th>BANK</th>
        <th>CHEQUE DATE</th>
        <th>CHEQUE AMT</th>
        <th>USED</th>
        <th>REMARK</th>
    </tr>
    <tbody>
        <tr>
            <td>&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br /></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </tbody>
</table>
