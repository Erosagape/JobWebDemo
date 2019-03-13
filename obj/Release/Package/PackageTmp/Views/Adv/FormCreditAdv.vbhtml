
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Credit Advance Slip"
    ViewBag.ReportName = "CREDIT ADVANCE SLIP"
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
    <div style="flex:1;text-align:left">
        เลขที่ : _______________________<br />
        วันที่ : _______________________
    </div>

    <div style="flex:2">
        <div style="display:flex;flex-direction:column;text-align:right;">
            <div style="flex:1">
                ผู้ขอเบิก _____________________________________________________________________
            </div>
            <div style="flex:1">
                ถึงบริษัท  ___________________________________________________________________
            </div>
        </div>
    </div>

</div>
<div style="margin-top:20px;">
    <p>
        &nbsp;&nbsp;&nbsp;ขอเบิกเงินทดรองค่าใช้จ่ายออกสินค้าสำหรับออกสินค้า <input type="checkbox"> อินวอยเลขที่ <input type="checkbox">A.W.B เลขที่ <input type="checkbox">______________________________________
        <br/>เลขที่ : _______________________ เรือ / เที่ยวบิน : : _________________________ E.T.A __________________________
    </p>
</div>    
<div style="margin-bottom:20px;">
    <br/>
    รายการสินค้า : ____________________________________________________________________
</div>

<table border="1" width="100%">
    <tr style="text-align:center;">
        <td width="5%">No</td>
        <td colspan="2" class="text-left">Description</td>
        <td width="25%" class="text-right">Expense Amount</td>
    </tr>
    <tr>
        <td width="5%">
            1
        </td>
        <td width="10%">
            SNG-007
        </td>
        <td class="text-left" width="60%">
            DSR - CARD PERMIT FEE
        </td>
        <td width="25%" style="text-align:right">
            3,000.00
        </td>

    </tr>
    <tr class="text-center">
        <td width="5%">
            2
        </td>
        <td width="10%">
            SNG-008
        </td>
        <td class="text-left" width="60%">
            DSR - STORAGE FEE
        </td>
        <td width="25"  style="text-align:right">
            6,000.00
        </td>

    </tr>

    <tr class="text-center">

        <td colspan="3">
            รวมจำนวนเงินทั้งหมด (_____________________________________________________________________)
        </td>

        <td width="25%" style="text-align:right">
            9,000.00
        </td>

    </tr>
</table>

<table border="1" width="100%">
    <tr style="text-align:center">
        <td width="30%" >
            <br><br>
            _______________________________<br>
            ผู้เบิก<br>
            ______________________________<br>
            <p class="text-left">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  DATE :
            </p>
        </td>
        <td width="30%" >
            <br><br>
            _______________________________<br>
            ผู้ตรวจ<br>
            ______________________________<br>
            <p class="text-left">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  DATE :
            </p>
        </td>
        <td width="40%">
            ข้อมูลการับชำระ <input type="checkbox">เงินโอน <input type="checkbox"> เช็ค <br>
            ธนาคาร ________________________________________<br>
            สาขา _________________________<input type="checkbox">ต่างจังหวัด<br>
            ผู้อนุมัติ _____________________ DATE :________________
        </td>
    </tr>
    <tr>
        <td colspan="3"  style="text-align:center">
            ***โปรดเขียนเช็คสังไนนาม บริษัท เคเอสเค (ไทยแลนด์) จำกัด ***
        </td>
    </tr>
</table>
