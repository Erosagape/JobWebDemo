
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Invoice Slip"
    ViewBag.ReportName = ""
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
    <table width="100%" border="1" class="text-center">
        <tr style="background-color :gainsboro;text-align:center;">
            <td width="100px" rowspan="2">No</td>
            <td width="400px" rowspan="2">DESCRIPTION</td>
            <td colspan="3" rowspan="1">ADVANCE RE-IMBERSEMENT</td>
            <td width="200px" rowspan="2">SERVICE CHARGE</td>
        </tr>
        <tr style="background-color :gainsboro;text-align:center;">
            <td width="120px">SERVICE</td>
            <td width="120px">VAT</td>
            <td width="120px">AMOUNT</td>
        </tr>
        <tr>
            <td width="100px">&nbsp;<br />&nbsp;<br />&nbsp;&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;</td>
            <td width="400px"></td>
            <td width="120px"></td>
            <td width="120px"></td>
            <td width="120px"></td>
            <td width="200px"></td>
        </tr>
        <tr>
            <td colspan="5">
                <div style="display:flex">
                    <div class="text-left div1" style="flex:3">
                        REMARKS :<br />
                        PLEASE REMIT TO:<br />
                        KSA THAILAND CO.,LTD.<br />
                        KASIKORN BANK PUBLIC LIMTED<br />
                        SUKUMVIT 33 BRANCH, CURRENT A/C NO. 003-1-20508-5
                    </div>
                    <div class="text-right" style="flex:1">
                        SUB TOTAL NON VAT <br />DISCOUNT<br />CUST. ADV<br />SUBTOTAL 7%<br />VAT 7%<br />TOTAL<br />ADVANCE RE-IMBERSEMENT<br />TOTAL<br />GRAND TOTAL
                    </div>
                </div>
            </td>
            <td style="background-color :gainsboro;text-align:right;" >
                0.00<br />0.00<br />0.00<br />0.00<br />0.00<br />0.00<br />0.00<br />0.00<br />0.00
            </td>
        </tr>
        <tr>
            <td>TOTAL (BAHT)</td>
            <td colspan="5">
                <div class="text-center">(หนึ่งล้านหนึ่งเเสนสองหมื่นสองพันเก้าร้อยสามสิบเอ็ดบาทถ้วน)</div>
            </td>
        </tr>
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
                    0.00<br />
                    0.00
                </div>
                <div class="text-center" style="flex:1">
                    0.00<br />
                    0.00
                </div>
            </div>
            <div style="display:flex;">
                <div style="flex:2">
                    NET AMOUNT
                </div>
                <div style="flex:1">
                    1,122,931.00
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
    });
</script>