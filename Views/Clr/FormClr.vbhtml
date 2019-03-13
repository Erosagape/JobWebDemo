
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Clearing Slip"
    ViewBag.ReportName = "CLEARING SLIP"
End Code
<style>
    * {
        font-family: Tahoma;
        font-size: 11px;
    }

    td {
        font-size: 11px;
    }

    table {
        border-width: thin;
        border-collapse: collapse;
    }
</style>
        <div style="display:flex">
            <div style="flex:1" class="text-left">
                KSA (THAILAND) CO.,LTD
            </div>

            <div style="flex:1;text-align:right">
                CS-02 [CLEAR]
            </div>
        </div>


        <div style="display:flex">
            <div style="flex:1" class="text-left">
                EXPENSE CLEARING &nbsp;&nbsp;&nbsp; 01 / IMPORT
            </div>

            <div style="flex:1;text-align:right">
                HEAD OFFICE
            </div>
        </div>

        <div style="display:flex">
            <div style="flex:2">
                JOB NO : ___________________________
            </div>
            <div style="flex:1">
                CLEAR DATE : _________________
            </div>
            <div style="flex:1">
                DOC NO : ____________________
            </div>
        </div>

        <div style="display:flex;flex-wrap:wrap;">
            <div style="flex:1">
                CUST NAME : ___________________________________________________________________
            </div>
        </div>

        <div style="display:flex">
            <div style="flex:1">
                ADV REF : ______________________________________________________________
            </div>
            <div style="flex:1">
                CUST INV : _____________________________________________________________
            </div>
        </div>
        <div style="display:flex">
            <div style="flex:1">
                REMARK : _______________________________________________________________
            </div>
        </div>

        <table  border="1" width="100%">
            <tr class="text-center">
                <th width="5%">NO.</th>
                <th width="70%">DESCRIPTION</th>
                <th width="10%">WHTAK</th>
                <th width="15%">AMOUNT</th>
            </tr>
            <tr>
                <td>
                    &nbsp;
                    <br />&nbsp;
                    <br />&nbsp;
                    <br />&nbsp;
                    <br />&nbsp;
                    <br />&nbsp;
                    <br />&nbsp;
                    <br />&nbsp;
                    <br />&nbsp;
                    <br />&nbsp;
                    <br />&nbsp;
                    <br />&nbsp;
                    <br />&nbsp;
                    <br />&nbsp;
                    <br />&nbsp;
                    <br />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td colspan="3">
                    <div style="display:flex">
                        <div style="flex:1" class="text-left">
                            CLEARING TYPE : 10 / Specific JOB
                            <br />
                            CLEARING FROM :  30 / Other
                        </div>
                        <div style="flex:1 ;text-align:right">
                            ADV AMOUNT
                            <br />
                            TOTAL AMOUNT
                            <br />
                            VAT 7.00 %
                            <br />
                            TOTAL AMOUNT (INCLUDED VAT)
                            <br />
                            WITH HOLDING TAX
                            <br />
                            CLEARING AMOUNT
                        </div>
                    </div>
                </td>
                <td style="text-align:right">
                    <div style="display:flex">
                        <div style="flex:1">
                            10,000.00
                            <br />
                            12,950.00
                            <br />
                            892.00
                            <br />
                            13,842.50
                            <br />
                            0.00
                            <br />
                            (3,842.50)
                        </div>
                    </div>
                </td>
            </tr>
        </table>

        <table border="1" width="100%" style="margin-top:50px">
            <tr class="text-center">
                <th>CLEARING BY</th>
                <th>APPROVED BY</th>
                <th>FINANCIAL</th>
                <th>ACCOUNTING</th>
                <th>PAYEE</th>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr class="text-center">
                <td>
                    นายเนื่อง ฉิวกระโทก
                    <br />
                    <br />
                    03/10/2018
                </td>
                <td>
                    นายเนื่อง ฉิวกระโทก
                    <br />
                    <br />
                    03/10/2018
                </td>
                <td>
                    นายเนื่อง ฉิวกระโทก
                    <br />
                    <br />
                    03/10/2018
                </td>
                <td>
                    <br />
                    <br />
                    ________/_______/_______
                </td>
                <td>
                    <br />
                    <br />
                    ________/_______/_______
                </td>
            </tr>
        </table>
