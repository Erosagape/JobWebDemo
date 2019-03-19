
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.ReportName = "QUOTATION"
    ViewBag.Title = "Quotation Form"
End Code
<style>
    * {
        font-family: Tahoma;
        font-size: 11px;
    }

    td {
        font-size: 11px;
    }

    th {
        text-align: center;
    }

    .number {
        text-align: right;
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
    <div style="flex:1">
        CUSTOMER : NIPPO MECHATRONICS (THAILAND) CO., LTD.
    </div>
    <div style="flex:1">
        <div style="flex:1;text-align:right">
            REF : ______________________________
        </div>
    </div>
</div>

<div style="display:flex">
    <div style="flex:1">
        A : XXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    </div>
    <div style="flex:1">
        <div style="flex:1;text-align:right">
            DATE : ______________________________
        </div>
    </div>
</div>

<div style="display:flex">
    <div style="flex:1">
        B : TTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
    </div>
    <div style="flex:1">
        <div style="flex:1;text-align:right">
            OFFERED TO : ______________________________
        </div>
    </div>
</div>

<div style="display:flex">
    <div style="flex:1">
        K : KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK
    </div>
    <div style="flex:1">
        <div style="flex:1;text-align:right">
            EXPIRY DATE : ______________________________
        </div>
    </div>
</div>

<div style="display:flex">
    <div style="flex:1">
        h : uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu
    </div>
    <div style="flex:1">
        <div style="flex:1;text-align:right">
            EXCHANGE RATE JPY : ______________________________
        </div>
    </div>
</div>


<table style="" border="1" width="100%">
    <tr>
        <th width="5%">NO.</th>
        <th width="45%">DESCRIPTION</th>
        <th width="5%">UNIT</th>
        <th width="5%">QTY</th>
        <th width="15%">UNIT PRICE</th>
        <th width="5%">XRT</th>
        <th width="10%">AMOUNT<br />(FC)</th>
        <th width="10%">AMOUNT<br />(THB)</th>
    </tr>
    <tr>
        <td>
            1
        </td>
        <td colspan="7">
            CU JPY
        </td>
    </tr>
    <tr>
        <td>1</td>
        <td>WAREHOUSE IN CHARGE</td>
        <td>SHP</td>
        <td>1</td>
        <td class="number">7000,000.00</td>
        <td class="number">0.34</td>
        <td class="number">700,000.00</td>
        <td class="number">238,000.00</td>
    </tr>
    <tr>
        <td>2</td>
        <td>OSR - UNLOADING/LAODING FEE FROM TRUCK</td>
        <td>SHP</td>
        <td>3</td>
        <td class="number">5,900.00</td>
        <td class="number">0.34</td>
        <td class="number">17,700.00</td>
        <td class="number">6,018.00</td>
    </tr>
    <tr>
        <td>3</td>
        <td>OSR - TRANSPORTATION FEE / TRUCK(6 WHEEL)</td>
        <td>TRK6</td>
        <td>4</td>
        <td class="number">1,000.00</td>
        <td class="number">0.34</td>
        <td class="number">4,000.00</td>
        <td class="number">1,360.00</td>
    </tr>
    <tr>
        <td>4</td>
        <td>OSR - </td>
        <td>SHP</td>
        <td>1</td>
        <td class="number">7000,000.00</td>
        <td class="number">0.34</td>
        <td class="number">700,000.00</td>
        <td class="number">238,000.00</td>
    </tr>
    <tr>
        <td>5</td>
        <td>WAREHOUSE IN CHARGE</td>
        <td>SHP</td>
        <td>1</td>
        <td class="number">7000,000.00</td>
        <td class="number">0.34</td>
        <td class="number">700,000.00</td>
        <td class="number">238,000.00</td>
    </tr>
    <tr>
        <td>6</td>
        <td>WAREHOUSE IN CHARGE</td>
        <td>SHP</td>
        <td>1</td>
        <td class="number">7000,000.00</td>
        <td class="number">0.34</td>
        <td class="number">700,000.00</td>
        <td class="number">238,000.00</td>
    </tr>
    <tr>
        <td colspan="6" class="number">
            SUB TOTAL
        </td>
        <td class="number">
            725,950.00
        </td>
        <td class="number">
            246,823.00
        </td>

    </tr>
    <tr>
        <td>2</td>
        <td colspan="7">CU THAI</td>

    </tr>
    <tr>
        <td>1</td>
        <td>OSR - UNLOADING/LAODING FEE FROM TRUCK</td>
        <td>SHP</td>
        <td>3</td>
        <td class="number">5,900.00</td>
        <td class="number">0.34</td>
        <td class="number">17,700.00</td>
        <td class="number">6,018.00</td>
    </tr>
    <tr>
        <td>2</td>
        <td>OSR - TRANSPORTATION FEE / TRUCK(6 WHEEL)</td>
        <td>TRK6</td>
        <td>4</td>
        <td class="number">1,000.00</td>
        <td class="number">0.34</td>
        <td class="number">4,000.00</td>
        <td class="number">1,360.00</td>
    </tr>
    <tr>
        <td>3</td>
        <td>OSR - </td>
        <td>SHP</td>
        <td>1</td>
        <td class="number">7000,000.00</td>
        <td class="number">0.34</td>
        <td class="number">700,000.00</td>
        <td class="number">238,000.00</td>
    </tr>

    <tr>
        <td colspan="6" class="number">
            SUB TOTAL
        </td>
        <td class="number">
            64,300.00
        </td>
        <td class="number">
            64,300.00
        </td>


    </tr>
    <tr>
        <td colspan="6" class="number">GRAND TOTAL(THB)</td>
        <td colspan="2" style="text-align:right">311,123.00</td>
    </tr>




</table>

<p>REMARK LIST : H8090-KKKJIJUHIIUIYF</p>
<p>H : POIYUHVKBDJDKHJD</p>
<p>J : KOUFJHGNKMFINBBF</p>

<p>SUBJECT TO IMPORT DUTY &IMPORT VAT</p>
<p>SUBJECT TO CUSTOMER OVERTIME . SUNDAY/HOLIDAY/OVER TIME WORK/THUCK DEMURANG. IMPORT LICENSE</p>