let mainLanguage = 'EN';
function SetLanguage(lang) {
    for (let id in lang) {
        let obj = $('#' + id);
        if (obj !== null) {
            let str = '';
            if (id.substr(0, 3) == 'mnu') {
                str += '- ';
            }
            switch (mainLanguage) {
                case 'EN':
                    str += lang[id].split('|')[0].trim();
                    obj.text(str);
                    break;
                case 'TH':
                    str += lang[id].split('|')[1].trim();
                    obj.text(str);
                    break;
            }
        }
    }
}
function ChangeLanguage(code, module) {
    ShowWait();
    mainLanguage = code;
    $.get('/Config/SetLanguage?data=' + mainLanguage)
        .done(function () {
            let lang = {
                mainBoard: 'Dashboard|ภาพรวมสถานะงาน',
                mainMkt: 'Marketing Works|แผนกการตลาด',
                mnuMkt1: 'Quotation|ใบเสนอราคา',
                mnuMkt2: 'Approve Quotation|อนุมัติใบเสนอราคา',
                mainCS: 'CS Works|แผนกบริการลูกค้า',
                mnuCS1: 'CreateJob|สร้างงานใหม่',
                mnuCS2: 'List Job|ค้นหางาน',
                mnuCS3: 'Delivery Order|ใบส่งของ',
                mnuCS4: 'Witholding-Tax|ออกหนังสือหักณที่จ่าย',
                mainShp: 'Shipping Works|แผนกชิปปิ้ง',
                mnuShp1: 'Advance|ใบเบิกค่าใช้จ่าย',
                mnuShp2: 'Clearing|ใบปิดค่าใช้จ่าย',
                mainApp: 'Approving|อนุมัติเอกสาร',
                mnuApp1: 'Approve Advance|อนุมัติใบเบิก',
                mnuApp2: 'Approve Clearing|อนุมัติใบปิด',
                mainFin: 'Finance Works|แผนกการเงิน',
                mnuFin1: 'Payment Advance|จ่ายเงินตามใบเบิก',
                mnuFin2: 'Payment Bill|จ่ายเงินตามบิลค่าใช้จ่าย',
                mnuFin3: 'Receive Clearing|รับเงินตามใบเบิก',
                mnuFin4: 'Receive Invoice|รับชำระใบแจ้งหนี้',
                mnuFin5: 'Cheque Management|บันทึกรับ/จ่ายเช็ค',
                mnuFin6: 'Credit Advance|เบิกเงินทดรองจ่าย',
                mnuFin7: 'Petty Cash|จัดการเงินสดย่อย',
                mnuFin8: 'Earnest Clearing|เคลียร์เงินมัดจำ',
                mainAcc: 'Accounting Works|งานบัญชี',
                mnuAcc1: 'Vouchers|บันทึกการรับจ่ายเงิน',
                mnuAcc2: 'Invoice|ใบแจ้งหนี้',
                mnuAcc3: 'Billing|ใบวางบิล',
                mnuAcc4: 'Receipts|ใบเสร็จรับเงิน',
                mnuAcc5: 'Tax-Invoice|ใบกำกับภาษี',
                mnuAcc6: 'Payment Bill|บิลค่าใช้จ่าย',
                mnuAcc7: 'Credit/DebitNote|ใบเพิ่มหนี้/ลดหนี้',
                mnuAcc8: 'JournalEntry|สมุดรายวัน',
                mainRpt: 'Reports/Tracking|รายงานและการติดตามงาน',
                mnuRpt1: 'Reports|รายงานต่างๆ',
                mnuRpt2: 'Tracking|การติดตามงาน',
                mainMas: 'Master Files|ข้อมูลมาตรฐาน',
                mnuMas1: 'Customs File|ข้อมูลทางศุลกากร',
                mnuMas2: 'Account File|ข้อมูลทางบัญชี',
                mnuMas3: 'System File|ข้อมูลพื้นฐานระบบ',
                mainMasA: 'Account Files|ข้อมูลมาตรฐานบัญชี',
                mnuMasA1: 'Customers|ผู้นำเข้าส่งออก',
                mnuMasA2: 'Venders|ผู้ให้บริการ',
                mnuMasA3: 'Service Units|หน่วยบริการ',
                mnuMasA4: 'Bank|ธนาคาร',
                mnuMasA5: 'Bank Accounts|บัญชีธนาคาร',
                mnuMasA6: 'Service Groups|กลุ่มค่าบริการ',
                mnuMasA7: 'Service Code|รหัสค่าบริการ',
                mnuMasA8: 'Service Policy|มาตรฐานค่าบริการ',
                mainMasS: 'System Files|ข้อมูลพื้นฐานระบบ',
                mnuMasS1: 'System Variables|ค่าคงที่ระบบ',
                mnuMasS2: 'System User|ผู้ใช้งานระบบ',
                mnuMasS3: 'User Authorize|กำหนดสิทธิผู้ใช้',
                mnuMasS4: 'Branch|สาขา',
                mnuMasS5: 'User Role|กำหนดบทบาทผู้ใช้งาน',
                mainMasG: 'General Files|ข้อมูลพื้นฐานทั่วไป',
                mnuMasG1: 'Currency|สกุลเงิน',
                mnuMasG2: 'Country|ประเทศ',
                mnuMasG3: 'Inter Ports|ท่าต่างประเทศ',
                mnuMasG4: 'Vessels/Vehicles/Flight|ชื่อพาหนะ',
                mnuMasG5: 'Declare Type|ประเภทใบขน',
                mnuMasG6: 'Customs Port|ท่าตรวจปล่อย',
                mnuMasG7: 'Product Unit|หน่วยสินค้า',
                mainLang: 'Change Language|เปลี่ยนภาษา',
                mnuLang1: 'English|ภาษาอังกฤษ',
                mnuLang2: 'Thai|ภาษาไทย'
            };
            SetLanguage(lang);
            ChangeLanguageForm(module);
            CloseWait();
        });
}
function ChangeLanguageForm(fname) {
    switch (fname) {
        case 'MODULE_CS/CreateJob':
            let lang = {
                lblTitle: 'Create Job|สร้างหมายเลขงานใหม่',
                lblJobType: 'Job Type|ประเภทงาน',
                lblShipBy: 'Ship By|ลักษณะงานขนส่ง',
                lblBranch: 'Branch|สาขา',
                lblCSCode: 'Support By|พนักงานผู้รับผิดชอบ',
                lblCustCode: 'Customer|ลูกค้า',
                lblBillingPlace: 'Billing To|สถานที่วางบิล',
                lblContactName: 'Contact|ผู้ติดต่อ',
                lblQuotation: 'Quotation|ใบเสนอราคา',
                lblCustInv: 'Commercial Invoice|อินวอยลูกค้า',
                lblPoNo: 'PO No/RefNo|ใบสั่งซื้อของลูกค้า',
                lblHAWB: 'House AWB/BL|House AWB/BL',
                lblMAWB: 'Master AWB/BL|Master AWB/BL',
                lblCopyFrom: 'Copy from|สร้างโดยดึงข้อมูลจาก',
                lblJobDate: 'Job Date|วันที่เปิดงาน',
                lblCreateJob: 'Create Job|สร้างหมายเลขงาน',
                lblSaveComplete: 'Create Job Complete|สร้างหมายเลขงานเรียบร้อย',
                btnViewJob: 'View/Edit Job|ดู/แก่ไชข้อมูล'
            };
            SetLanguage(lang);
            break;
    }    
}

