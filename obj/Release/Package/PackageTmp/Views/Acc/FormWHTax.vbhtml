﻿@Code
    Layout = "~/Views/Shared/_ReportNoHead.vbhtml"
End Code
<style>
    * {
        font-family: Tahoma;
        font-size: 12px;
        margin:0;
        padding:0;
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
    เลขที่ <label id="txtDocNo"></label>
</div>
<table border="1" style="border-style:solid;border-width:thin;border-collapse:collapse" width="100%">
    <tr>
        <td colspan="4" style="text-align:center;vertical-align:top">
            <b>หนังสือรับรองการหักภาษี ณ ที่จ่าย</b><br />
            ตามมาตรา ๕๐ ทวิ แห่งประมวลรัษฏากร
        </td>
    </tr>
    <tr>
        <td colspan="4" style="vertical-align:top">
            <div style="float:right">
                เลขประจำตัวผู้เสียภาษี <label id="txtTaxNumber1"></label>
            </div>
            <b>ผู้มีหน้าที่หักภาษี ณ ที่จ่าย</b>
            <p>ชื่อ <span><label id="txtTName1"></label></span></p>
            <i>(ให้ระบุว่าเป็น บุคคล นิติบุคคล บริษัท สมาคม หรือคณะบุคคล)</i>
            <p>ที่อยู่ <span><label id="txtTAddress1"></label></span></p>
            <i>(ให้ระบุ ชื่ออาคาร/หมู่บ้าน ห้องเลขที่ ชั้นที่ เลขที่ ตรอก/ซอย หมู่ที่ ถนน ตำบล/แขวง อำเภอ/เขต จังหวัด และโทรศัพท์)</i>
        </td>
    </tr>

    <tr>
        <td colspan="4" style="vertical-align:top">
            <div style="float:right">
                เลขประจำตัวผู้เสียภาษี <label id="txtTaxNumber2"></label>
            </div>
            <b>กระทำแทนโดย</b>
            <p>ชื่อ <span><label id="txtTName2"></label></span></p>
            <i>(ให้ระบุว่าเป็น บุคคล นิติบุคคล บริษัท สมาคม หรือคณะบุคคล)</i>
            <p>ที่อยู่ <span><label id="txtTAddress2"></label></span></p>
            <i>(ให้ระบุ ชื่ออาคาร/หมู่บ้าน ห้องเลขที่ ชั้นที่ เลขที่ ตรอก/ซอย หมู่ที่ ถนน ตำบล/แขวง อำเภอ/เขต จังหวัด และโทรศัพท์)</i>
        </td>
    </tr>

    <tr>
        <td colspan="4" style="vertical-align:top">
            <div style="float:right;">
                เลขประจำตัวผู้เสียภาษี <label id="txtTaxNumber3"></label>
            </div>
            <b>ผู้ถูกหักภาษี ณ ที่จ่าย</b>
            <p>ชื่อ <span><label id="txtTName3"></label></span></p>
            <i>(ให้ระบุว่าเป็น บุคคล นิติบุคคล บริษัท สมาคม หรือคณะบุคคล)</i>
            <p>ที่อยู่ <span><label id="txtTAddress3"></label></span></p>
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
                    <input type="hidden" id="txtFormType" />
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
        <td>
            <label>ประเภทเงินได้ที่จ่าย</label>
        </td>
        <td>
            <label>วัน เดือน <br />หรือ ปีภาษีที่จ่าย</label>
        </td>

        <td>
            <label>จำนวนเงินที่จ่าย</label>
        </td>
        <td>
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
        <td><input type="text" id="txtPayDate4" /></td>
        <td><input type="text" id="txtPayAmount4" class="amount" /></td>
        <td><input type="text" id="txtPayTax4" class="amount" /></td>
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
        <td><input type="text" id="txtPayDate5" /></td>
        <td><input type="text" id="txtPayAmount5" class="amount" /></td>
        <td><input type="text" id="txtPayTax5" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;  &nbsp;&nbsp;&nbsp;
            <input type="checkbox">(1.2) อัตราร้อยละ 25 ของกำไรสุทธิ
        </td>
        <td><input type="text" id="txtPayDate6" /></td>
        <td><input type="text" id="txtPayAmount6" class="amount" /></td>
        <td><input type="text" id="txtPayTax6" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;  &nbsp;&nbsp;&nbsp;
            <input type="checkbox">(1.3) อัตราร้อยละ 20 ของกำไรสุทธิ
        </td>
        <td><input type="text" id="txtPayDate7" /></td>
        <td><input type="text" id="txtPayAmount7" class="amount" /></td>
        <td><input type="text" id="txtPayTax7" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;  &nbsp;&nbsp;&nbsp;
            <input type="checkbox">(1.4) อัตราอื่นๆ (ระบุ)<label id="txtPayDesc8"></label>ของกำไรสุทธิ
        </td>
        <td><input type="text" id="txtPayDate8" /></td>
        <td><input type="text" id="txtPayAmount8" class="amount" /></td>
        <td><input type="text" id="txtPayTax8" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;
            (2) กรณีผู้รับเงินปันผลไม่ได้รับเครดิตภาษี เนื่องจากจ่ายจากกำไรสุทธิของกิจการที่ได้รับยกเว้นภาษีเงินได้นิติบุคคล
        </td>
        <td><input type="text" id="txtPayDate9" /></td>
        <td><input type="text" id="txtPayAmount9" class="amount" /></td>
        <td><input type="text" id="txtPayTax9" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;
            (3) เงินปันผลหรือส่วนแบ่งกำไรที่ได้รับยกเว้นไม่ต้องนำรวมมาคำนวณเป็นรายได้เพื่อคำนวณภาษีเงินได้นิติบุคคล
        </td>
        <td><input type="text" id="txtPayDate10" /></td>
        <td><input type="text" id="txtPayAmount10" class="amount" /></td>
        <td><input type="text" id="txtPayTax10" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;
            (4) กำไรที่รับรู้ทางบัญชีโดยวิธีส่วนได้เสีย
        </td>
        <td><input type="text" id="txtPayDate11" /></td>
        <td><input type="text" id="txtPayAmount11" class="amount" /></td>
        <td><input type="text" id="txtPayTax11" class="amount" /></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;
            (5) อื่นๆ (ระบุ)<label id="txtPayDesc12"></label>
        </td>
        <td><input type="text" id="txtPayDate12" /></td>
        <td><input type="text" id="txtPayAmount12" class="amount" /></td>
        <td><input type="text" id="txtPayTax12" class="amount" /></td>
    </tr>
    <tr>
        <td>
            5.การจ่ายเงินได้ที่ต้องหักภาษี ณ ที่จ่ายตามคำสั่งกรมสรรพากรที่ออกตาม มาตรา 3 เตรส เช่น รางวัล ส่วนลดหรือประโยชน์ใด เนื่องจากการ ส่งเสริมการขาย รางวัลในการประกวด การแข่งขัน
            การชิงโชค ค่าแสดง ของนักแสดงสาธารณะ ค่าจ้างทำของ ค่าโฆษณา ค่าเช่า ค่าขนส่ง ค่าบริการ ค่าเบี้ยประกันวินาศภัย ฯลฯ
        </td>
        <td><input type="text" id="txtPayDate13" /></td>
        <td><input type="text" id="txtPayAmount13" class="amount" /></td>
        <td><input type="text" id="txtPayTax13" class="amount" /></td>
    </tr>
    <tr>
        <td>
            6.อื่นๆ (ระบุ)<label id="txtPayDesc14"></label>
        </td>
        <td><input type="text" id="txtPayDate14" /></td>
        <td><input type="text" id="txtPayAmount14" class="amount" /></td>
        <td><input type="text" id="txtPayTax14" class="amount" /></td>
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
            <b>เงินที่จ่ายเข้า  </b>กองทุนสงเคราะห์ครูโรงเรียนเอกชน<input type="text" id="txtTeacherAmt" class="amount" value="" />บาท  กองทุนประกันสังคม<input type="text" id="txtSoLicenseAmt" class="amount" value="" />บาท กองทุนสำรองเลี้ยงชีพ<input type="text" id="txtSoAccAmount" class="amount" value="" />บาท
        </td>
    </tr>
</table>
<table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin" width="100%">

    <tr>
        <td>
            <p>ผู้จ่ายเงิน</p>
            <input type="hidden" id="txtPayTaxType" />
            <input type="checkbox" id="chkPayTaxType1" name="chkPayTaxType">(1) หักภาษี ณ ที่จ่าย<br>
            <input type="checkbox" id="chkPayTaxType2" name="chkPayTaxType">(2) ออกภาษีให้ตลอดไป<br>
            <input type="checkbox" id="chkPayTaxType3" name="chkPayTaxType">(3) ออกภาษีให้ครั้งเดียว<br>
            <input type="checkbox" id="chkPayTaxType4" name="chkPayTaxType">(4) อื่นๆ (ระบุ)<input type="text" id="txtPayTaxOther" value="" /><br>
        </td>

        <td>
            <p>ขอรับรองว่า ข้อความและตัวเลขดังกล่าวข้างต้นถูกต้องตรงกับความจริงทุกประการ</p><br /><br /><br />
            (ลงชื่อ)<label id="txtUpdateName"></label>  ผู้มีหน้าที่หักภาษี ณ ที่จ่าย<br>
            <label id="txtDocDate"></label> วัน เดือน ปี ที่ออกหนังสือรับรอง
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
<script type="text/javascript">
    let path = '@Url.Content("~")';
    $(document).ready(function () {
        let branch = getQueryString('branch');
        let code = getQueryString('code');
        if (branch != "" && code != "") {
            $.get(path + 'acc/getwhtaxgrid?branch=' + branch + '&code=' + code, function (r) {
                if (r.whtax.data[0].Table !== undefined) {
                    let h = r.whtax.data[0].Table[0];
                    $('#txtDocNo').text(h.DocNo);
                    $('#txtTaxNumber1').text(h.IDCard1);
                    if (h.TaxNumber1 !== null) {
                        $('#txtTaxNumber1').text(h.TaxNumber1);
                    }
                    $('#txtTName1').text(h.TName1);
                    $('#txtTAddress1').text(h.TAddress1);
                    $('#txtTaxNumber2').text(h.IDCard2);
                    if (h.TaxNumber2 !== null) {
                        $('#txtTaxNumber2').text(h.TaxNumber2);
                    }
                    $('#txtTName2').text(h.TName2);
                    $('#txtTAddress2').text(h.TAddress2);
                    $('#txtTaxNumber3').text(h.IDCard3);
                    if (h.TaxNumber3 !== null) {
                        $('#txtTaxNumber3').text(h.TaxNumber3);
                    }
                    $('#txtTName3').text(h.TName3);
                    $('#txtTAddress3').text(h.TAddress3);
                    $('#txtSeqInform').val(h.SeqInForm);
                    $('#txtFormType').val(h.FormType);
                    $('input:checkbox[name=chkFormType]:checked').prop('checked', false);
                    $('#chkFormType' + h.FormType).prop('checked',true);
                    $('#txtTeacherAmt').val(h.TeacherAmt);
                    $('#txtSoLicenseAmt').val(h.SoLicenseAmount);
                    $('#txtSoAccAmount').val(h.SoAccAmount);
                    $('#txtPayTaxType').val(h.PayTaxType);
                    $('input:checkbox[name=chkPayTaxType]:checked').prop('checked', false);
                    $('#chkPayTaxType' + h.PayTaxType).prop('checked',true);
                    $('#txtUpdateName').text(h.UpdateName);
                    $('#txtDocDate').text(CDateTH(h.DocDate));

                    let d = r.whtax.data[0].Table;
                    let totalamt = 0;
                    let totaltax = 0;
                    for (let i = 0; i < d.length; i++) {
                        let incType = CNum(d[i].IncType);
                        if (incType > 0 && incType <= 14) {
                            $('#txtPayDate'+incType).val(CDateTH(d[i].PayDate));

                            let amt=Number($('#txtPayAmount'+incType).val());
                            let tax=Number($('#txtPayTax'+incType).val());

                            amt += Number(d[i].PayAmount);
                            tax += Number(d[i].PayTax);

                            totalamt += Number(d[i].PayAmount);
                            totaltax += Number(d[i].PayTax);

                            $('#txtPayAmount' + incType).val(CDbl(amt,2));
                            $('#txtPayTax' + incType).val(CDbl(tax,2));

                            switch (incType) {
                                case 8:
                                case 12:
                                case 14:
                                    $('#txtPayDesc' + incType).text(d[0].PayTaxDesc);
                                    $('#txtPayDesc' + incType).text(d[0].PayTaxDesc);
                                    $('#txtPayDesc' + incType).text(d[0].PayTaxDesc);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    $('#txtSumPayAmount').val(totalamt);
                    $('#txtSumPayTax').val(totaltax);
                    $('#txtPayTaxMoney').val(CNumEng(totaltax));
                }
            });
        }
    });
</script>