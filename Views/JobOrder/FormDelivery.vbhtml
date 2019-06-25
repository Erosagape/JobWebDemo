
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.ReportName = "DELIVERY NOTE"
    ViewBag.Title = "Delivery Form"
End Code

<style>

    td {
        font-size: 11px;
    }

    table {
        border-width: thin;
        border-collapse: collapse;
    }
    div {
        padding:4px 4px 4px 4px;
    }
    div.div3 {
        border: 1px solid black;
        margin-bottom: 15px;
        width: 100%;
    }
</style>
<div style="margin-bottom:15px;">
    <div style="text-align:right;position:relative;float:right;">
        วันที่ส่งสินค้า (Delivery Date) ________________________
    </div>
    <div style="text-align:left;position:relative;float:left;">
        เลขที่เอกสาร (Document No) ________________________
    </div>
</div>
<br/>
<div style="display:flex;flex-direction:column;align-items:center;width:100%;">
    <div class="div3">
        <div>            
            Importer Name(ชื่อผู้นำเข้า) _____________________________________TAX No:___________________<br />
            ______________________________________________________________________________________<br />
            Invoice no.(เลขที่อินวอยซ์)______________________________________P.O. no.__________________<br />
            Name of Delivery(ชื่อผู้รับสินค้า)___________________________________________________________<br />
            Place of Delivery(สถานที่ส่งสินค้า)_________________________________________________________<br />
            Description of Goods(รายละเอียดสินค้า)_____________________________________________________<br />
            Quantity(ปริมาณหีบห่อ)_______________________________Gross Weight(น้ำหนักรวม)_______________KGS<br />
            Vessel/Fight(เรือ/เที่ยวบิน)___________________________ETA(วันเรือเข้า)____________________________<br />
            House B/L_________________________________Master B/L_____________________________________<br />
            Remark from CS(ข้อพึงระวัง)________________________________________________________________<br /><br />
        </div>
    </div>
    <div class="div3">
        <div>
            2.Record pf Cargo and Document Receipt(บันทึกการตรวจรับสินค้าเเละเอกสาร)<br /><br />
            I have received the above mentioned cargo completely in good condition and acceptance.<br />
            In case od damage or unacceptance. please kindy identify clearly the apparent condition and inform us within 3 days after receiving cargo<br />
            ข้าเจ้าได้รับสินค้าตามรายการที่ระบุข้างต้นในสภาพที่สมบูรณ์เป็นที่เรียบร้อยเเล้ว เเละยอมรับได้<br />
            ในกรณีที่สินค้าเสียหายหรือไม่สามารถยอมรับได้ กรุณาระบุสภาพสินค้าตามความเป็นจริงอย่างชัดเจนเเละเเจ้งกลับภายใน 3 วันหลังจากรับสินค้า<br />
            2.1 ตรวจสภาพสินค้า
            <div style="display:flex;">
                <input type="checkbox" />&nbsp;&nbsp;เรียบร้อย
                <input type="checkbox" />&nbsp;&nbsp;ไม่เรียบร้อย  เนื่องจาก_____________________________
            </div><br />
            2.2 ตรวจเอกสารเเนบส่งสินค้า
            <div style="display:flex;">
                <input type="checkbox" />&nbsp;&nbsp;Packing List
                <input type="checkbox" />&nbsp;&nbsp;ใบส่งของของบริษัท
                <input type="checkbox" />&nbsp;&nbsp;ใบส่งของของผู้ว่าจ้าง
            </div><br />
            <br /><br />
            <div style="display:flex;">
                <div class="text-left">
                    ลงชื่อ ______________________ ผู้รับสินค้า(ตัวบรรจง)<br />
                    วันที่ _______________________<br />
                </div>
            </div>
            <br />
        </div>
    </div>
    <div class="div3">
        <div>
            3.รายละเอียดรถบรรทุก<br />
            เบอร์ตู้__________________________________________________________________________________<br />
            ประเภทรถบรรทุก
            <div style="display:flex">
                <input type="checkbox" />&nbsp;&nbsp;4ล้อ
                <input type="checkbox" />&nbsp;&nbsp;6ล้อ
                <input type="checkbox" />&nbsp;&nbsp;10ล้อ
                <input type="checkbox" />&nbsp;&nbsp;ตู้20ฟุต
                <input type="checkbox" />&nbsp;&nbsp;ตู้40ฟุต
            </div><br />
            ชื่อพนักงานขับรถบรรทุก(ตัวยรรจง) ______________________________ทะเบียนรถเลขที่_____________________
            <br /><br />
        </div>
    </div>
    <div class="div3">
        <div>
            4.อุปกรณ์ Safety ของพนักงานขับรถ ตรวจสอบโดยผู้ตรวจปล่อยสินค้า<br />
            <div style="display:flex;">
                <input type="checkbox" />&nbsp;&nbsp;การเเต่งกาย_________
                <input type="checkbox" />&nbsp;&nbsp;สภาพรถ________
                <input type="checkbox" />&nbsp;&nbsp;สภาพตู็________
            </div><br />
        </div>
    </div>

</div>