
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.ReportName = "Payments Note"
    ViewBag.Title = "Payment Note"
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

    p.normal {
        border: 2px solid;
    }

    .round1 {
        border: 1px solid;
        border-radius: 5px;
    }

    .center {
        text-align: center;
    }

    .left {
        text-align: left;
    }

    .right {
        text-align: right;
    }
</style>
<table width="100%">
    <tr>
        <td width="70%">
            <div style="display:flex">
                <div style="flex:1" class="left round1">
                    <b>เจ้าหน้าที่</b> นางสาว ลาวรรณ สุทา<br>
                    <b>ที่อยู่</b> 7 หมู่ ตำบลดงดำ อำเภอลี่ จังหวัดลำพูน
                </div>
            </div>

        </td>
        <td rowspan="3">

            <div style="display:flex">
                <div style="flex:1" class="left round1">
                    <b>AP No. :</b>ZYF19001<br>
                    <b>Date </b> 01/02/2019<br>
                    <b>JobNo </b> <br>
                    <b>วันนัดรับชำระ </b><br>
                    <b>ADV No. </b> AVD-1902-00034<br>
                    <b>CLR No.  </b> CLR-1902-00136<br>
                    <b>เลขที่รับชำระ </b> RV-6202-00370<br>
                    <b>วันที่ชำระ </b> 07/02/2019<br>

                </div>
            </div>


        </td>
    </tr>
    <tr>
        <td>
            <div style="display:flex">
                <div style="flex:1" class="left round1">
                    <b>สถานที่วางบิล</b> นางสาว ลาวรรณ สุทา<br>
                    <b>ที่อยู่</b> 7 หมู่ ตำบลดงดำ อำเภอลี่ จังหวัดลำพูน
                </div>
            </div>

        </td>

    </tr>

    <tr>
        <td>


            <div style="display:flex">
                <div style="flex:1" class="left round1">
                    <b>ลูกค้า</b> นางสาว ลาวรรณ สุทา<br>
                    <b>ที่อยู่</b> 7 หมู่ ตำบลดงดำ อำเภอลี่ จังหวัดลำพูน
                </div>
            </div>
        </td>
    </tr>

</table>
<div class="round1">
    <div style="display:flex">
        <div style="flex:1" class="left ">
            <p><b>Invoice :</b> ZYF19001</p>

        </div>

        <div style="flex:1" class="left ">
            <p><b>QUANTITY/GROSSWEIGHT:</b></p>

        </div>

        <div style="flex:1" class="left ">
            <p><b>Measurement[M3]:</b>3.500</p>

        </div>
    </div>

    <div style="display:flex">
        <div style="flex:1" class="left">
            <p><b>Product Name :</b> ZYF19001</p>

        </div>
    </div>

    <div style="display:flex">
        <div style="flex:1" class="left ">
            <p><b>AWB/ B/L No :</b> ZYF19001</p>

        </div>

        <div style="flex:1" class="left">
            <p><b>Flight/Vessel :</b></p>

        </div>
    </div>
</div>
<table border="1" width="100%">
    <tr>
        <td width="10%" class="center">
            ลำดับที่ (Item)
        </td>
        <td width="48%" class="center">
            รายการสินค้า / รายละเอียด Description
        </td>
        <td width="10%" class="center">
            จำนวนเงินรวม(บาท)Amount(Baht)
        </td>
    </tr>

    <tr>
        <td class="center">
            1
        </td>
        <td class="left">
            ค่าคอมมิชชั่น
        </td>
        <td class="right">
            350.00
        </td>
    </tr>
</table>

<table width="100%" border="1">
    <tr>
        <td width="859px" rowspan="9">
            <div class="row">

                <div style="display:flex" class="col-sm-8">
                    <div class="col-sm-8 right round1">
                        <p class="center"> Withholding Tax Detail</p>
                        <div style="display:flex">

                            <div style="flex:2" class="right ">
                                1% Transportation :

                            </div>

                            <div style="flex:1" class="right ">
                                0.00

                            </div>

                            <div style="flex:1" class="right ">
                                0.00

                            </div>
                        </div>

                        <div style="display:flex">

                            <div style="flex:2" class="right ">
                                3 % Service :

                            </div>

                            <div style="flex:1" class="right ">
                                0.00

                            </div>

                            <div style="flex:1" class="right ">
                                0.00

                            </div>
                        </div>

                        <div style="display:flex">

                            <div style="flex:2" class="right ">
                                5% :

                            </div>

                            <div style="flex:1" class="right ">
                                0.00

                            </div>

                            <div style="flex:1" class="right ">
                                0.00

                            </div>
                        </div>

                        <div style="display:flex">

                            <div style="flex:2" class="right ">
                                ยอดสุทธิ :

                            </div>

                            <div style="flex:1" class="right ">


                            </div>

                            <div style="flex:1" class="right ">
                                0.00

                            </div>
                        </div>
                    </div>
                </div>
                <div>

                </div>
                <div class="col-sm-4 right">
                    รวม / Total <br />Vat 7%<br />Total VAT<br />เงินล่วงหน้า<br />ส่วนลด<br />สุทธิ/ Net Total<br />
                </div>
            </div>
        </td>
        <td width="200px" style="background-color :gainsboro"></td>
    </tr>
    <tr style="background-color :gainsboro">
        <td></td>
    </tr>
    <tr style="background-color :gainsboro">
        <td></td>
    </tr>
    <tr style="background-color :gainsboro">
        <td></td>
    </tr>
    <tr style="background-color :gainsboro">
        <td></td>
    </tr>
    <tr style="background-color :gainsboro">
        <td></td>
    </tr>

</table>
<div style="display:flex">
    <div style="flex:1" class="left ">
        <p><b>Remark :</b> </p>

    </div>

    <div style="flex:1" class="right ">
        <p><b>จำนวนตัวอักษร :</b></p>

    </div>

    <div style="flex:2" class="left ">
        <p class="normal center"><b>(สามร้อยห้าสิบบาทถ้วน) :</b></p>

    </div>
</div>
<div style="height:300px"></div>

<div style="display:flex">
    <div style="flex:1" class=" round1 center">
        ผู้สั่งซื้อ<br><br>
        _______________________________
        <p>Authorized Signature</p>

    </div>

    <div style="flex:1" class=" round1 center">
        For The Customer<br><br>
        _______________________________
        <p>Authorized Signature</p>

    </div>

    <div style="flex:1" class="round1 center">
        For The C.S &N. SHIPPING Co., Ltd.<br><br>
        _______________________________
        <p>Authorized Signature</p>

    </div>
</div>
