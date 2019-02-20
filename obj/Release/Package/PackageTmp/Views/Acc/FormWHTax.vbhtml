@Code
    Layout = "~/Views/Shared/_ReportNoHead.vbhtml"
End Code
<style>
    * {
        font-family: Tahoma;
        font-size: 12px;
    }

    .circle {
        width: 100px; /* ความกว้าง */
        height: 100px; /* ความสูง */
        -moz-border-radius: 70px;
        -webkit-border-radius: 70px;
        border: 1px solid #000000;
        border-radius: 50%;
        text-align: center;
    }

    .money_text {
        border-style: solid;
        border-width: 1px;
        width: 70%;
        float: right;
        text-align: center;
        padding: 1px;
    }

    .amount {
        text-align: right;
    }
</style>
<div style="float:left;">
    <b>ฉบับที่ 1</b><i>(สำหรับผู้ถูกหักภาษี ณ ที่จ่ายใช้แนบพร้อมกับแบบแสดงรายการภาษี)</i><br />
    <b>ฉบับที่ 2</b><i>(สำหรับผู้ถูกหักภาษี ณ ที่จ่ายเก็บไว้เป็นหลักฐาน)</i>
</div>
<div style="float:right;">
    เลขที่ <label id="txtDocNo">________________</label>
</div>
<table border="1" style="border-style:solid;border-width:thin;width:100%;border-collapse:collapse">
    <tr>
        <td colspan="4" style="text-align:center;vertical-align:top">
            <b>หนังสือรับรองการหักภาษี ณ ที่จ่าย</b><br />
            ตามมาตรา ๕๐ ทวิ แห่งประมวลรัษฏากร
        </td>
    </tr>
    <tr>
        <td colspan="4" style="vertical-align:top">
            <div style="float:right">
                เลขประจำตัวผู้เสียภาษี <label id="txtTaxNumber1">___________________________</label>
            </div>
            <b>ผู้มีหน้าที่หักภาษี ณ ที่จ่าย</b>
            <p>ชื่อ <span><label id="txtTName1">______________________________________________________________________________________________________</label></span></p>
            <i>(ให้ระบุว่าเป็น บุคคล นิติบุคคล บริษัท สมาคม หรือคณะบุคคล)</i>
            <p>ที่อยู่ <span><label id="txtTAddress1">_______________________________________________________________________________________________________</label></span></p>
            <i>(ให้ระบุ ชื่ออาคาร/หมู่บ้าน ห้องเลขที่ ชั้นที่ เลขที่ ตรอก/ซอย หมู่ที่ ถนน ตำบล/แขวง อำเภอ/เขต จังหวัด และโทรศัพท์)</i>
        </td>
    </tr>

    <tr>
        <td colspan="4" style="vertical-align:top">
            <div style="float:right">
                เลขประจำตัวผู้เสียภาษี <label id="txtTaxNumber2">___________________________</label>
            </div>
            <b>กระทำแทนโดย</b>
            <p>ชื่อ <span><label id="txtTName2">______________________________________________________________________________________________________</label></span></p>
            <i>(ให้ระบุว่าเป็น บุคคล นิติบุคคล บริษัท สมาคม หรือคณะบุคคล)</i>
            <p>ที่อยู่ <span><label id="txtTAddress2">_______________________________________________________________________________________________________</label></span></p>
            <i>(ให้ระบุ ชื่ออาคาร/หมู่บ้าน ห้องเลขที่ ชั้นที่ เลขที่ ตรอก/ซอย หมู่ที่ ถนน ตำบล/แขวง อำเภอ/เขต จังหวัด และโทรศัพท์)</i>
        </td>
    </tr>

    <tr>
        <td colspan="4" style="vertical-align:top">
            <div style="float:right;">
                เลขประจำตัวผู้เสียภาษี <label id="txtTaxNumber3">___________________________</label>
            </div>
            <b>ผู้ถูกหักภาษี ณ ที่จ่าย</b>
            <p>ชื่อ <span><label id="txtTName3">______________________________________________________________________________________________________</label></span></p>
            <i>(ให้ระบุว่าเป็น บุคคล นิติบุคคล บริษัท สมาคม หรือคณะบุคคล)</i>
            <p>ที่อยู่ <span><label id="txtTAddress3">_______________________________________________________________________________________________________</label></span></p>
            <i>(ให้ระบุ ชื่ออาคาร/หมู่บ้าน ห้องเลขที่ ชั้นที่ เลขที่ ตรอก/ซอย หมู่ที่ ถนน ตำบล/แขวง อำเภอ/เขต จังหวัด และโทรศัพท์)</i>
        </td>
    </tr>
    <tr>
        <td colspan="4" style="vertical-align:top">
            <div style="float:left">
                ลำดับที่ <input type="text" id="txtSeqInform" style="width:100px;border:solid;border-width:thin;"> ในแบบ
            </div>
            <div style="float:left">
                <div style="text-align:left">
                    <input type="checkbox" id="chkFormType1" name="chkFormType">(1) ภ.ง.ด.1ก.
                    <input type="checkbox" id="chkFormType2" name="chkFormType">(2) ภ.ง.ด.1ก. พิเศษ
                    <input type="checkbox" id="chkFormType3" name="chkFormType">(3) ภ.ง.ด.2
                    <input type="checkbox" id="chkFormType4" name="chkFormType">(4) ภ.ง.ด.3<br />
                    <input type="checkbox" id="chkFormType5" name="chkFormType">(5) ภ.ง.ด.2ก.
                    <input type="checkbox" id="chkFormType6" name="chkFormType">(6) ภ.ง.ด.3ก.
                    <input type="checkbox" id="chkFormType7" name="chkFormType">(7) ภ.ง.ด.53
                </div>
            </div>
        </td>
    </tr>
    <tr style="text-align:center;font-weight:bold">
        <td style="width:55%">
            <label>ประเภทเงินได้ที่จ่าย</label>
        </td>
        <td style="width:15%">
            <label>วัน เดือน <br />หรือ ปีภาษีที่จ่าย</label>
        </td>

        <td style="width:15%">
            <label>จำนวนเงินที่จ่าย</label>
        </td>
        <td style="width:15%">
            <label>ภาษีที่หักและนำส่งไว้</label>
        </td>
    </tr>


    <tr>
        <td>
            1.เงินเดือน ค่าจ้าง เบี้ยเลี้ยง โบนัส ฯลฯ ตามมาตรา 40(1)
        </td>
        <td><input type="text" id="txtPayDate1" /></td>
        <td><input type="text" id="txtPayAmount1" class="amount" /></td>
        <td><input type="text" id="txtPayTax1" class="amount" /></td>
    </tr>

    <tr>
        <td>
            2.ค่าธรรมเนียม ค่านายหน้า ฯลฯ ตามมาตรา 40(2)
        </td>
        <td><input type="text" id="txtPayDate2" /></td>
        <td><input type="text" id="txtPayAmount2" class="amount" /></td>
        <td><input type="text" id="txtPayTax2" class="amount" /></td>
    </tr>

    <tr>
        <td>
            3.ค่าแห่งลิขสิทธิ์ ฯลฯ ตามมาตรา 40(1)
        </td>
        <td><input type="text" id="txtPayDate3" /></td>
        <td><input type="text" id="txtPayAmount3" class="amount" /></td>
        <td><input type="text" id="txtPayTax3" class="amount" /></td>
    </tr>

    <tr>
        <td>
            4.(ก)ค่าดอกเบี้ย ฯลฯ ตามมาตรา 40(4)(ก)
        </td>
        <td><input type="text" id="txtPayDate40" /></td>
        <td><input type="text" id="txtPayAmount40" class="amount" /></td>
        <td><input type="text" id="txtPayTax40" class="amount" /></td>
    </tr>

    <tr>
        <td>
            &nbsp;  &nbsp;(ข)เงินปันผลเงินส่วนแบ่งกำไร ฯลฯ ตามมาตรา 40(4)(ข)
            <br />
            &nbsp;  &nbsp;  &nbsp;  &nbsp;(1)กรณีผู้ได้รับเงินปันผลได้รับเครดิตภาษี โดยจ่ายจากกำไรสุทธิของกิจการที่ต้องเสียภาษีเงินได้นิติบุคคลในอัตราดังนี้
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;  &nbsp;&nbsp;&nbsp;
            <input type="checkbox">(1.1) อัตราร้อยละ 30 ของกำไรสุทธิ
        </td>
        <td><input type="text" id="txtPayDate411" /></td>
        <td><input type="text" id="txtPayAmount411" class="amount" /></td>
        <td><input type="text" id="txtPayTax411" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;  &nbsp;&nbsp;&nbsp;
            <input type="checkbox">(1.2) อัตราร้อยละ 25 ของกำไรสุทธิ
        </td>
        <td><input type="text" id="txtPayDate412" /></td>
        <td><input type="text" id="txtPayAmount412" class="amount" /></td>
        <td><input type="text" id="txtPayTax412" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;  &nbsp;&nbsp;&nbsp;
            <input type="checkbox">(1.3) อัตราร้อยละ 20 ของกำไรสุทธิ
        </td>
        <td><input type="text" id="txtPayDate413" /></td>
        <td><input type="text" id="txtPayAmount413" class="amount" /></td>
        <td><input type="text" id="txtPayTax413" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;  &nbsp;&nbsp;&nbsp;
            <input type="checkbox">(1.4) อัตราอื่นๆ (ระบุ)___________ของกำไรสุทธิ
        </td>
        <td><input type="text" id="txtPayDate414" /></td>
        <td><input type="text" id="txtPayAmount414" class="amount" /></td>
        <td><input type="text" id="txtPayTax414" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;
            (2) กรณีผู้รับเงินปันผลไม่ได้รับเครดิตภาษี เนื่องจากจ่ายจากกำไรสุทธิของกิจการที่ได้รับยกเว้นภาษีเงินได้นิติบุคคล
        </td>
        <td><input type="text" id="txtPayDate420" /></td>
        <td><input type="text" id="txtPayAmount420" class="amount" /></td>
        <td><input type="text" id="txtPayTax420" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;
            (3) เงินปันผลหรือส่วนแบ่งกำไรที่ได้รับยกเว้นไม่ต้องนำรวมมาคำนวณเป็นรายได้เพื่อคำนวณภาษีเงินได้นิติบุคคล
        </td>
        <td><input type="text" id="txtPayDate430" /></td>
        <td><input type="text" id="txtPayAmount430" class="amount" /></td>
        <td><input type="text" id="txtPayTax430" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;
            (4) กำไรที่รับรู้ทางบัญชีโดยวิธีส่วนได้เสีย
        </td>
        <td><input type="text" id="txtPayDate440" /></td>
        <td><input type="text" id="txtPayAmount440" class="amount" /></td>
        <td><input type="text" id="txtPayTax440" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;
            (5) อื่นๆ (ระบุ)_____________________________
        </td>
        <td><input type="text" id="txtPayDate450" /></td>
        <td><input type="text" id="txtPayAmount450" class="amount" /></td>
        <td><input type="text" id="txtPayTax450" class="amount" /></td>
    </tr>
    <tr>
        <td>
            5.การจ่ายเงินได้ที่ต้องหักภาษี ณ ที่จ่ายตามคำสั่งกรมสรรพากรที่ออกตาม มาตรา 3 เตรส เช่น รางวัล ส่วนลดหรือประโยชน์ใด เนื่องจากการ ส่งเสริมการขาย รางวัลในการประกวด การแข่งขัน
            การชิงโชค ค่าแสดง ของนักแสดงสาธารณะ ค่าจ้างทำของ ค่าโฆษณา ค่าเช่า ค่าขนส่ง ค่าบริการ ค่าเบี้ยประกันวินาศภัย ฯลฯ
        </td>
        <td><input type="text" id="txtPayDate5" /></td>
        <td><input type="text" id="txtPayAmount5" class="amount" /></td>
        <td><input type="text" id="txtPayTax5" class="amount" /></td>
    </tr>
    <tr>
        <td>
            6.อื่นๆ (ระบุ)_____________________________
        </td>
        <td><input type="text" id="txtPayDate6" /></td>
        <td><input type="text" id="txtPayAmount6" class="amount" /></td>
        <td><input type="text" id="txtPayTax6" class="amount" /></td>
    </tr>
    <tr style="text-align:right">
        <td colspan="2"><b>รวมเงินที่จ่ายและภาษีที่หักนำส่ง</b></td>
        <td><input type="text" id="txtSumPayAmount" class="amount" /></td>
        <td><input type="text" id="txtSumPayTax" class="amount" /></td>
    </tr>
    <tr>
        <td colspan="4">
            รวมเงินที่จ่ายและภาษีที่หักนำส่ง (ตัวอักษร)
            <div class="money_text right">
                <input type="text" id="txtPayTaxMoney" />
            </div>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <b>เงินที่จ่ายเข้า  </b>กองทุนสงเคราะห์ครูโรงเรียนเอกชน<input type="text" id="txtTeacherAmt" class="amount" value="_____" />บาท  กองทุนประกันสังคม<input type="text" id="txtSoLicenseAmt" class="amount" value="_____" />บาท กองทุนสำรองเลี้ยงชีพ<input type="text" id="txtSoAccAmount" class="amount" value="_____" />บาท
        </td>
    </tr>
</table>
<table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;width:100%">

    <tr>
        <td>
            <p>ผู้จ่ายเงิน</p>
            <input type="hidden" id="txtPayTaxType" />
            <input type="checkbox" id="chkPayTaxType1" name="chkPayTaxType">(1) หักภาษี ณ ที่จ่าย<br>
            <input type="checkbox" id="chkPayTaxType2" name="chkPayTaxType">(2) ออกภาษีให้ตลอดไป<br>
            <input type="checkbox" id="chkPayTaxType3" name="chkPayTaxType">(3) ออกภาษีให้ครั้งเดียว<br>
            <input type="checkbox" id="chkPayTaxType4" name="chkPayTaxType">(4) อื่นๆ (ระบุ)<input type="text" id="txtPayTaxOther" value="______" /><br>
        </td>

        <td>
            <p>ขอรับรองว่า ข้อความและตัวเลขดังกล่าวข้างต้นถูกต้องตรงกับความจริงทุกประการ</p><br /><br /><br />
            (ลงชื่อ)<label id="txtUpdateName">________________</label>  ผู้มีหน้าที่หักภาษี ณ ที่จ่าย<br>
            <label id="txtDocDate">________________</label> วัน เดือน ปี ที่ออกหนังสือรับรอง
        </td>

        <td>
            <div class="circle"><br /><br /><br />ตราประทับนิติบุคคลถ้ามี</div>
        </td>
    </tr>
</table>
<div>
    <b>หมายเหตุ</b> ให้สามารถอ้างอิงหรือสอบยันกันได้ระหว่างลำดับที่ตามหนังสือรับรองฯ กับแบบยื่นรายการภาษีหัก ณ ที่จ่าย<br />
    <b>คำเตือน</b> ผู้มีหน้าที่ออกหนังสือรับรองหักภาษี ณ ที่จ่าย ฝ่าฝืนไม่ปฏิบัติตามมาตรา 50 ทวิ แห่งประมวลรัษฏากรต้องรับโทษทางอาญาตามมาตรา 35 แห่งประมวลรัษฏากร
</div>