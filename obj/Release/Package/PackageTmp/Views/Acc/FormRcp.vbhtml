
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Receipt Slip"
    ViewBag.ReportName = ""
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
<div style="text-align:center;width:100%">
    <h2>RECEIPTS</h2>
</div>

<div style="display:flex;">
    <div style="flex:2;">
        <label>CUSTOMER:</label>
    </div>
    <div style="flex:1">
        <label>TAX REFERENCE ID:</label>0105545081444
    </div>
    <div style="flex:1">
        <label>BRANCH:</label>HEAD OFFICE
    </div>

</div>
<div style="display:flex;">
    <div style="flex:3;border:1px solid black;border-radius:5px;">
        NAME : KGK Engineering (THAI) CO.,LTD<br />
        ADDRESS : 376. SOI LADPRAO 94<br />
        TEL : +66(2)935-6784-5<br />
    </div>
    <div style="flex:1;border:1px solid black;border-radius:5px;">
        DOC NO. : R-1801-0003<br />
        INV NO. : INV-1081-00016<br />
        INV DATE : 09/01/2018<br />
        CUST INV : P171203<br />
        JOB NO : EA1801-00007<br />
    </div>
</div>

<div style="display:flex;border:1px solid black;border-radius:5px;">

    <div style="flex:2">
        <div class="row">
            <p class="col-sm-12">
                FROM :
            </p>
        </div>
        <div class="row">
            <p class="col-sm-12">
                FLIGTH/VISSEL :
            </p>
        </div>
        <div class="row">
            <p class="col-sm-12">
                QUANTITY/GROAAWEIGHT :
            </p>
        </div>
    </div>


    <div style="flex:2">
        <div class="row">
            <p class="col-sm-12">
                ETD :
            </p>
        </div>
        <div class="row">
            <p class="col-sm-12">
                hBL/HAWB :
            </p>
        </div>
        <div class="row">
            <p class="col-sm-12">
                MEASUREMENT :
            </p>
        </div>
    </div>


    <div style="flex:2">
        <div class="row">
            <p class="col-sm-12">
                ETA :
            </p>
        </div>
        <div class="row">
            <p class="col-sm-12">
                MBL/MAWB :
            </p>
        </div>


    </div>




</div>
<table border="1" style="border-style:solid;width:100%; margin-top:5px" class="text-center">
    <tr style="background-color:lightblue;">
        <th height="50" width="30">NO.</th>
        <th width="200">DESCRIPTION</th>
        <th width="50">QTY</th>
        <th width="90">&#64; AMOUNT</th>
        <th width="80">CURRENCY</th>
        <th width="60">RATE</th>
        <th width="90">THB AMOUNT</th>
    </tr>
    <tr>
        <td>&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br /></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr style="background-color:lightblue;text-align:center;">
        <td colspan="4">SEVEN THOUSAND EIGHT HUNDRED AND SIXTY SEVEN &(52/100)</td>
        <td colspan="2">TOTAL RECEIPT</td>
        <td colspan="1">7,867.52</td>
    </tr>
</table>
<p>
    PAY BY
</p>
<div style="display:flex;flex-direction:column">
    <div>
        <label><input type="checkbox" name="vehicle1" value=""> CASH</label>
        DATE_____________  AMOUNT______________BAHT
    </div>
    <div>
        <label><input type="checkbox" name="vehicle2" value=""> CHEQUE</label>
        DATE_____________  NO_______________  BANK_________________  AMOUNT______________BAHT
    </div>
    <div>
        <label><input type="checkbox" name="vehicle3" value=""> TRANSFER</label>
        DATE_____________  BANK_________________  AMOUNT______________BAHT
    </div>
</div>
<div style="display:flex;">
    <div class="text-left" style="border:1px solid black;flex:2">
        PLEASE REMIT TO:<br />
        FOR KSA (THAILAND) CO.,LTD.<br />
        KASIKORN BANK PUBLIC LIMITED<br />
        SUKHUMVIT 33 BRANCH, CERRENT A/C NO. 003-1-20508-5<br />
        SWIFT : KASITHBK
    </div>
    <div style="border:1px solid black ;border-radius:5px;flex:1;text-align:center;">

        FOR THE CUSTOMER
        <br /><br /><br />
        <p>_____________________</p>
        _____________________<br />
        ___/_______/___<br />
        AUTHORIZED SIGNATURE
    </div>
    <div style="border:1px solid black;border-radius:5px;flex:1;text-align:center">

        FOR KSA (THAILAND) CO.,LTD
        <br/><br /><br />
        <p>_____________________</p>
        _____________________<br />
        ___/_______/___<br />
    </div>
</div>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    $(document).ready(function () {
        ShowCompany('#divCompany');
    });
</script>