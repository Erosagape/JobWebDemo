
@Code
    ViewBag.Title = "WTax-3"
    Layout = "~/Views/Shared/_ReportNoHead.vbhtml"
End Code
<style>
    * {
        font-family: Tahoma;
        font-size: 12px;
        margin: 0;
        padding: 0;
    }

    #circle {
        width: 100px; /* ความกว้าง */
        height: 100px; /* ความสูง */
        -moz-border-radius: 70px;
        -webkit-border-radius: 70px;
        border: 1px solid #000000;
        border-radius: 50%;
    }

    .one {
        border-style: solid;
        border-width: 1px;
        width: 500px;
        margin-right: auto;
        float: right;
        padding: 1px;
    }

    p.pd1 {
        margin: 15px;
    }

    p.d1 {
        border: 1px solid black;
        margin: 25px;
        background-color: lightblue;
        border-radius: 8px;
    }

    h4.H4 {
        border: 1px solid black;
        margin-left: 1px;
        margin-bottom: 1px;
        margin-right: 1px;
        margin-top: 63px;
        background-color: lightblue;
        border-radius: 8px;
        font-size: 23px;
    }

    h1.H1 {
        border: 1px solid black;
        margin-left: 20px;
        margin-bottom: 10px;
        margin-right: 1px;
        margin-top: 50px;
        font-size: 90px;
        border-radius: 8px;
    }

    p.d2 {
        border: 1px solid black;
        margin: 25px;
        border-radius: 8px;
    }

    p.d3 {
        border: 1px solid black;
        border-radius: 5px;
        margin-left: 80px;
        margin-bottom: 1px;
        margin-right: -30px;
        margin-top: 5px;
    }
</style>



<div id="report" class="text-center row">

    <div class="col-md-7">
        <h4 class="H4">
            แบบยื่นรายการภาษีเงินได้หัก ณ ที่จ่าย<br />
            ตามมาตรา 3 เตรส และมาตรา 69 ทวิ<br />
            และการเสียภาษีตามมาตรา 69 จัตวา แห่งประมวลรัษฎากร
        </h4>

    </div>

    <div class="col-md-5">
        <h1 class="H1">
            ภ.ง.ด.53
        </h1>
    </div>



</div>

<table border="1" style="border-style:solid;width:100%">
    <tr>
        <td>
            <h4><p class="pd1">เลขประจำตัวผู้เสียภาษีอากร  ................................................................................</p></h4>
            <p class="pd1">(ของผู้มีหน้าที่หักภาษี ณ ที่จ่าย)</p>
            <p class="pd1">
                ชื่อผู้มีหน้าที่หักภาษี ณ ที่จ่าย (หน่วยงาน) : .................................................................
                สาขาที่ .......................
            </p>
            <p class="pd1">...............................................................................................................................................</p>
            <p class="pd1">ที่อยู่ : อาคาร .................................... ห้องเลขที่.............ชั้นที่...............หมู่บ้าน.....................................</p>
            <p class="pd1">เลขที่....................หมู่ที่.................ตรอก/ซอย.....................................แยก...........................................</p>
            <p class="pd1">ถนน..............................................................ตำบล/แขวง.................................................................</p>
            <p class="pd1">อำเภอ/เขต..................................................................................จังหวัด.........................................</p>
            <p class="pd1">รหัสไปรษณีย์ &#9744;&#9744;&#9744;&#9744;&#9744;............................................................................................................</p>
        </td>


        <td align="left" valign="top">

            <h4>
                <p class="d1 text-center">นำส่งภาษีตาม</p>
                <p class="pd1">&#9744; (1) มาตรา 3 เตรส แห่งประมวลรัษฎากร</p>
                <p class="pd1">&#9744; (2) มาตรา 65 จัตวา แห่งประมวลรัษฎากร</p>
                <p class="pd1">&#9744; (3) มาตรา 69 ทวิ แห่งประมวลรัษฎากร</p>
            </h4>

        </td>

    </tr>


    <tr>
        <td rowspan="2">
            <p class="pd1">เดือนที่จ่ายเงินได้พึงประเมิน</p>
            <p class="pd1">(ให้ทำเครื่องหมาย "&check;" ลงใน "&#9744;" หน้าชื่อเดือน) พ.ศ.&nbsp; .....................</p>
            <p class="pd1">
                &#9744;(1)&nbsp; มกราคม  &nbsp;&nbsp;&nbsp;&nbsp;&#9744;(4)&nbsp; เมษายน &nbsp;&nbsp;&#9744;(7)&nbsp; กรกฎาคม &#9744;(10)&nbsp; ตุลาคม
            </p>
            <p class="pd1">
                &#9744;(2)&nbsp; กุมภาพันธ์ &nbsp;&#9744;(5)&nbsp;พฤษภาคม &#9744;(8)&nbsp; สิงหาคม &nbsp;&#9744;(11)&nbsp; พฤศจิกายน
            </p>
            <p class="pd1">
                &#9744;(3)&nbsp; มีนาคม &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&#9744;(6) &nbsp;มิถุนายน &nbsp;&nbsp;&#9744;(9)&nbsp; กันยายน &nbsp;&#9744;(12)&nbsp; ธันวาคม
            </p>



        </td>
        <td align="left" valign="top">
            <h3><p class="pd1"> &#9744;(1)ยื่นปกติ &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  &#9744;(2)ยื่นเพิ่มเติมครั้งที่ &#9744;</p></h3>
        </td>

    </tr>
    <tr>


        <td class="text-center">
            สำหรับบันทึกข้อมูลจากระบบ TCL
        </td>
    </tr>

    <tr>
        <td colspan="2">

            <h3>
                <p class="pd1" align="right">


                    &#9744; ใบแนบ ภ.ง.ด.53 ที่แนบมาพร้อมนี้ : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;จำนวน..........ราย


                </p>
                <p class="pd1" align="right">จำนวน..........แผ่น</p>
                <p class="pd1" align="center">หรือ</p>
            </h3>

            <p class="pd1">มีรายละเอียดการหักเป็นรายผู้มีเงินได้ ปรากฎตาม</p>
            <p class="pd1">(ให้แสดงรายละเอียดในใบแนบ ภ.ง.ด.53 หรือในสื่อ</p>
            <p class="pd1">บันทึกในระบบคอมพิวเตอร์อย่างใดอย่างหนึ่งเท่านั้น)</p>

            <h3>
                <p class="pd1">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                    &#9744; สื่อบันทึกในระบบคอมพิวเตอร์ ที่แนบมาพร้อมนี้:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    จำนวน..........ราย


                </p>
                <p class="pd1" align="right">จำนวน..........แผ่น</p>
            </h3>
            <p class="pd1" align="right">
                (ตามหนังสือแสดงความประสงค์ ทะเบียนรับเลขที่................................................
            </p>
            <p class="pd1" align="right">
                หรือตามหนังสือข้อตกลงการใช้งานฯ เลขอ้างอิงการลงทะเบียน...........................)
            </p>

            <div class="row">
                <div class="col-md-8 text-center">
                    <h3>
                        <p class="d1">
                            สรุปรายการภาษีที่นำส่ง
                        </p>
                    </h3>
                    <div class="col-md-8 text-left">
                        <h4>
                            <p>
                                1.รวมยอดเงินได้ทั้งสิ้น
                            </p>
                            <p>
                                2.รวมยอดภาษีที่นำส่งทั้งสิ้น
                            </p>
                            <p>
                                3.เงินเพิ่ม(ถ้ามี)
                            </p>
                            <p>
                                4.รวมยอดภาษีที่นำส่งทั้งสิ้น และเงินเพิ่ม (2. + 3.)
                            </p>
                        </h4>
                    </div>


                </div>
                <div class="col-md-4 text-center">
                    <h3>
                        <p class="d2">
                            จำนวนเงิน
                        </p>
                        <div class="col-md-8">
                            <h4>
                                <p class="d3 text-center">&nbsp;</p>
                                <p class="d3">&nbsp;</p>
                                <p class="d3">&nbsp;</p>
                                <p class="d3">&nbsp;</p>
                            </h4>
                        </div>




                    </h3>
                </div>

            </div>




        </td>

    </tr>

    <tr>
        <td colspan="2" class="text-center">
            <h4>
                <p>
                    ข้าพเจ้าขอรับรองว่า รายงายที่ข้าพเจ้าแจ้งไว้ข้างต้นนี้ เป็นรายงานที่ถูกต้องและครบถ้วนทุกประการ
                </p>
                <p>
                    ลงชื่อ.................................................................ผู้จ่ายเงิน
                </p>
                <p>
                    (......................................................................)
                </p>
                <p>
                    ตำแหน่ง........................................................................
                </p>
                <p>
                    ยื่นวันที่...........เดือน.................................พ.ศ............................
                </p>
            </h4>
        </td>

    </tr>

</table>
<p align="right">(ก่อนกรอกรายงาน ดูคำชี้แจงด้านหลัง)</p>








