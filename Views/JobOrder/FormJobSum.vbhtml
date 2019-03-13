
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
        JOB TYPE : 01/IMPORT
    </div>
    <div style="flex:1">
        JOB DATE : 05/02/2018
    </div>
</div>

<div style="display:flex">
    <div style="flex:2">
        CUST NAME : YUSEN
    </div>
    <div style="flex:1">
        SHIP BY : 02/SEA
    </div>
</div>

<div style="display:flex">
    <div style="flex:1">
        INVOICE : TEST990505218
    </div>
    <div style="flex:1">
        DECLARE NO : -
    </div>
    <div style="flex:1" ">
        VESSEL :
    </div>
</div>

<div style="display:flex">
    <div style="flex:2">
        PRODUCT NAME :
    </div>
    <div style="flex:1">
        WEIGHT : 0.00 KGM
    </div>
</div>

<div style="display:flex">
    <div style="flex:1">
        CONTAINER :
    </div>
    <div style="flex:1">
        SERVICE BY :
    </div>
    <div style="flex:1">
        QUANTITY : 0.00
    </div>
</div>

<div style="display:flex">
    <div style="flex:2">
        <table width="98%" border="1">
            <tr class="text-center">
                <th width="5%">NO.</th>
                <th width="15%">ADV DATE</th>
                <th width="25%">ADV NO</th>
                <th width="35%">PRE ADVANCE</th>
                <th width="15%">AMOUNT</th>
            </tr>
            <tr>
                <td class="text-center">1<br />2<br />3<br />4<br />5<br />6<br />7<br />8<br />9<br /></td>
                <td class="text-center">08/02/2561<br />08/02/2561<br />08/02/2561<br />08/02/2561<br />08/02/2561<br />08/02/2561<br /></td>
                <td class="text-center">ADV-1802-0014<br />ADV-1802-0014<br />ADV-1802-0014<br />ADV-1802-0014<br />ADV-1802-0014<br />ADV-1802-0014<br /></td>
                <td>DSR-RE-LOCATION<br />DSR-RE-LOCATION<br />DSR-RE-LOCATION<br />DSR-RE-LOCATION<br />DSR-RE-LOCATION<br />DSR-RE-LOCATION<br /></td>
                <td style="text-align:right">1000.00<br />1000.00<br />1000.00<br />1000.00<br />1000.00<br />1000.00<br />1000.00<br />1000.00<br /></td>
            </tr>
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
                            680.40<br />
                            22,700.40
                        </div>

                        <div style="flex:1">
                            TOTAL AMOUNT<br />
                            TAX AMOUNT<br />
                            GRAND TOTAL
                        </div>
                    </div>
                </td>
                <td style="text-align:right">
                    22,020.00<br />
                    0.00<br />
                    22,700.40
                </td>
            </tr>
        </table>
    </div>

    <div style="flex:1">
        <table width="100%" border="1">
            <tr>
                <th>CUST ADVANCE</th>
                <th>AMOUNT</th>
            </tr>
            <tr>
                <td>
                    DSR-CARGO PERMIT FEE <br />DSR-CARGO PERMIT FEE <br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;

                </td>
                <td style="text-align:right">
                    3,000.00<br />
                    6,000.00
                </td>
            </tr>
            <tr>
                <th style="text-align:right">TOTAL ADVANCE</th>
                <td style="text-align:right">9,000.00</td>
            </tr>
        </table>
    </div>
</div>

<br />

<div style="display:flex">
    <div style="flex:1">
        <table width="100%" border="1">
            <tr class="text-center">
                <th width="5%">NO.</th>
                <th width="40%">DESCRIPTION</th>
                <th width="20%">CHEQUE/CREDIT</th>
                <th width="10%">TAX</th>
                <th width="15%">COST</th>
                <th width="15%">PROFIT</th>
            </tr>
            <tr>
                <td>4<br />5<br />6<br />7<br />8<br />9<br /></td>
                <td>DS-BILL OF LADING (B/L) FEE <br />DS-BILL OF LADING (B/L) FEE <br />DS-BILL OF LADING (B/L) FEE <br />DS-BILL OF LADING (B/L) FEE <br />DS-BILL OF LADING (B/L) FEE <br />DS-BILL OF LADING (B/L) FEE <br />DS-BILL OF LADING (B/L) FEE <br /></td>
                <td style="text-align:right">1,500.00<br />1,500.00<br />1,500.00<br />1,500.00<br />1,500.00<br />1,500.00<br /></td>
                <td style="text-align:right">0.00<br />1,500.00<br />1,500.00<br />1,500.00<br /></td>
                <td style="text-align:right">0.00<br />1,500.00<br />1,500.00<br />1,500.00<br />1,500.00<br /></td>
                <td style="text-align:right">1,500.00<br />1,500.00<br />1,500.00<br />1,500.00<br />1,500.00<br /></td>
            </tr>
            <tr>
                <td colspan="2" height="50PX">
                    <div style="display:flex">
                        <div style="flex:1">
                            ADV CHEQUE
                        </div>

                        <div style="flex:1">
                            0.00 BAHT
                        </div>

                        <div style="flex:1" style="text-align:right">
                            TOTAL
                        </div>

                    </div>
                </td>
                <td style="text-align:right">24,500.40</td>
                <td style="text-align:right">0.00</td>
                <td style="text-align:right">26,500.00</td>
                <td style="text-align:right">-2,500.60</td>
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
                <td>0.00</td>
            </tr>
            <tr style="text-align:right">
                <th width="40%">NET PROFIT</th>
                <td>-2,119.60</td>
            </tr>
        </table>
    </div>
</div>

<br />
<table width="100%" border="1">
    <tr class="text-center">
        <th>CHEQUE NO.</th>
        <th>BANK</th>
        <th>CHEQUE DATE</th>
        <th>CHEQUE AMT</th>
        <th>USED</th>
        <th>REMARK</th>
    </tr>
    <tr>
        <td>&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br /></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
</table>
