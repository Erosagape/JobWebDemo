let mainLanguage = 'EN';
function GetReportLists() {
    return [
        { "ReportGroup": "CS", "ReportCode": "JOBDAILY", "ReportNameEN": "Job List Daily", "ReportNameTH": "รายงานการตรวจปล่อยตามวันที่" },
        { "ReportGroup": "CS", "ReportCode": "JOBCS", "ReportNameEN": "Job List By CS", "ReportNameTH": "รายงานการตรวจปล่อยตามพนักงานบริการลูกค้า" },
        { "ReportGroup": "CS", "ReportCode": "JOBSHP", "ReportNameEN": "Job List By Shipping", "ReportNameTH": "รายงานการตรวจปล่อยตามชิปปิ้ง" },
        { "ReportGroup": "CS", "ReportCode": "JOBTYPE", "ReportNameEN": "Job List By Type", "ReportNameTH": "รายงานการตรวจปล่อยตามประเภทงาน" },
        { "ReportGroup": "CS", "ReportCode": "JOBSHIPBY", "ReportNameEN": "Job List By Transport", "ReportNameTH": "รายงานการตรวจปล่อยตามลักษณะงานขนส่ง" },
        { "ReportGroup": "CS", "ReportCode": "JOBCUST", "ReportNameEN": "Job List By Customer", "ReportNameTH": "รายงานการตรวจปล่อยตามลูกค้า" },
        { "ReportGroup": "CS", "ReportCode": "JOBPORT", "ReportNameEN": "Job List By Port", "ReportNameTH": "รายงานการตรวจปล่อยตามสถานที่ตรวจปล่อย" },
        { "ReportGroup": "CS", "ReportCode": "JOBADV", "ReportNameEN": "Advance By Emp", "ReportNameTH": "รายงานการเบิกเงินตามพนักงาน" },
        { "ReportGroup": "SALES", "ReportCode": "JOBVOLUME", "ReportNameEN": "Job Volume By Cust", "ReportNameTH": "รายงานสรุปงานตามลูกค้า" },
        { "ReportGroup": "SALES", "ReportCode": "JOBSTATUS", "ReportNameEN": "Job Volume By Status", "ReportNameTH": "รายงานสรุปงานตามสถานะ" },
        { "ReportGroup": "SALES", "ReportCode": "JOBSALES", "ReportNameEN": "Job Sales By Emp", "ReportNameTH": "รายงานสรุปยอดขายตามพนักงาน" },
        { "ReportGroup": "SALES", "ReportCode": "JOBCOMM", "ReportNameEN": "Job Commission By Emp", "ReportNameTH": "รายงานสรุปค่าคอมมิชชั่น" },
        { "ReportGroup": "FIN", "ReportCode": "ADVDAILY", "ReportNameEN": "Advance Payment", "ReportNameTH": "รายงานการจ่ายเงินเบิกล่วงหน้า" },
        { "ReportGroup": "FIN", "ReportCode": "EXPDAILY", "ReportNameEN": "Expense Payment", "ReportNameTH": "รายงานการจ่ายเงินทดรองจ่าย" },
        { "ReportGroup": "FIN", "ReportCode": "RCPDAILY", "ReportNameEN": "Receipt Daily", "ReportNameTH": "รายงานใบเสร็จรับเงินประจำวัน" },
        { "ReportGroup": "FIN", "ReportCode": "TAXDAILY", "ReportNameEN": "Tax-invoice Daily", "ReportNameTH": "รายงานใบกำกับภาษีประจำวัน" },
        { "ReportGroup": "FIN", "ReportCode": "CASHDAILY", "ReportNameEN": "Transaction Daily", "ReportNameTH": "รายงานการรับจ่ายเงินประจำวัน" },
        { "ReportGroup": "BILL", "ReportCode": "CLRDAILY", "ReportNameEN": "Clearing Daily", "ReportNameTH": "รายงานการปิดค่าใช้จ่ายประจำวัน" },
        { "ReportGroup": "BILL", "ReportCode": "INVDAILY", "ReportNameEN": "Invoice Daily", "ReportNameTH": "รายงานใบแจ้งหนี้ประจำวัน" },
        { "ReportGroup": "BILL", "ReportCode": "BILLDAILY", "ReportNameEN": "Billing Daily", "ReportNameTH": "รายงานใบวางบิลประจำวัน" },
        { "ReportGroup": "ACC", "ReportCode": "JOBCOST", "ReportNameEN": "Job Costing And Profit", "ReportNameTH": "รายงานต้นทุนและกำไรขั้นต้น" },
        { "ReportGroup": "ACC", "ReportCode": "BOOKBAL", "ReportNameEN": "Book Accounts Balance", "ReportNameTH": "รายงานการใช้จ่ายเงินตามสมุดบัญชี" },
        { "ReportGroup": "ACC", "ReportCode": "VATSALES", "ReportNameEN": "Output VAT Report", "ReportNameTH": "รายงานภาษีขาย" },
        { "ReportGroup": "ACC", "ReportCode": "VATBUY", "ReportNameEN": "Input VAT Report", "ReportNameTH": "รายงานภาษีซื้อ" },
        { "ReportGroup": "ACC", "ReportCode": "WHTAX", "ReportNameEN": "Withholding-Tax Report", "ReportNameTH": "รายงานหัก ณ ที่จ่าย" },
        { "ReportGroup": "ACC", "ReportCode": "ACCEXP", "ReportNameEN": "Accrued Expenses Report", "ReportNameTH": "รายงานค่าใช้จ่ายค้างจ่าย" },
        { "ReportGroup": "ACC", "ReportCode": "ACCINC", "ReportNameEN": "Accrued Income Report", "ReportNameTH": "รายงานรายได้ค้างรับ" },
        { "ReportGroup": "ACC", "ReportCode": "ARBAL", "ReportNameEN": "Accounts Receivable Report", "ReportNameTH": "รายงานลูกหนี้" },
        { "ReportGroup": "ACC", "ReportCode": "APBAL", "ReportNameEN": "Accounts Payable Report", "ReportNameTH": "รายงานเจ้าหนี้" },
        { "ReportGroup": "ACC", "ReportCode": "CNDN", "ReportNameEN": "Credit/Debit Note Report", "ReportNameTH": "รายงานการปรับปรุงหนี้" },
        { "ReportGroup": "ACC", "ReportCode": "TRIALBAL", "ReportNameEN": "Trial Balance Report", "ReportNameTH": "รายงานงบทดลอง" },
        { "ReportGroup": "ACC", "ReportCode": "BALANCS", "ReportNameEN": "Balance Sheet", "ReportNameTH": "รายงานงบดุล" },
        { "ReportGroup": "ACC", "ReportCode": "PROFITLOSS", "ReportNameEN": "Profit And Loss", "ReportNameTH": "รายงานงบกำไรขาดทุน" },
        { "ReportGroup": "ACC", "ReportCode": "CASHFLOW", "ReportNameEN": "Cash Flow", "ReportNameTH": "รายงานงบกระแสเงินสด" },
        { "ReportGroup": "ACC", "ReportCode": "JOURNAL", "ReportNameEN": "Journal Entry Report", "ReportNameTH": "รายงานสมุดรายวัน" }
    ];
}
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
                mainMkt: 'Marketing Works|แผนกการตลาด',
                mnuMkt1: 'Quotation|ใบเสนอราคา',
                mnuMkt2: 'Approve Quotation|อนุมัติใบเสนอราคา',
                mnuMkt3: 'Estimate Cost|ประมาณการค่าใช้จ่าย',
                mainCS: 'CS Works|แผนกบริการลูกค้า',
                mnuCS1: 'CreateJob|สร้างงานใหม่',
                mnuCS2: 'List Job|ค้นหางาน',
                mnuCS3: 'Loading Info|ข้อมูลรับบรรทุก',
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
                mnuRpt2: 'Transport Tracking|การติดตามงานขนส่ง',
                mnuRpt4: 'Customer Tracking|การติดตามสถานะงาน',
                mnuRpt3: 'Job Dashboard|ภาพรวมสถานะงาน',
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
                mnuMasA9: 'Account Code|ผังบัญชี',
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
                mnuMasG8: 'Province|จังหวัด/อำเภอ/ตำบล',
                mainLang: 'Change Language|เปลี่ยนภาษา',
                mnuLang1: 'English|ภาษาอังกฤษ',
                mnuLang2: 'Thai|ภาษาไทย',
                mainUtil: 'Utility Tools|เครื่องมือต่างๆ',
                mnuUtil1: 'Import|นำเข้าข้อมูล',
                mnuUtil2: 'Export|ส่งออกข้อมูล'
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
        case 'MODULE_REP/Index':
            let reportLists = GetReportLists();            
            let group = $('#cboReportGroup').val();
            if (group == null) {
                group = 'CS';
                let reportGroups = [
                    { "ConfigKey": "ACC", "ConfigValue": "Account Reports|รายงานแผนกบัญชี" },
                    { "ConfigKey": "BILL", "ConfigValue": "Finance Reports|รายงานแผนกบิลลิ่ง" },
                    { "ConfigKey": "CS", "ConfigValue": "CS Reports|รายงานแผนกบริการลูกค้า" },
                    { "ConfigKey": "FIN", "ConfigValue": "Finance Reports|รายงานแผนกการเงิน" },
                    { "ConfigKey": "SALES", "ConfigValue": "Sales Reports|รายงานแผนกการตลาด" }
                ];
                loadComboArray('#cboReportGroup', reportGroups, 'CS');
            }
            let reports = reportLists.filter(function (data) {
                return data.ReportGroup == group;
            });
            $('#tbReportList').DataTable({
                data: reports,
                columns: [
                    { data: "ReportCode", title: "Report Code" },
                    { data: (mainLanguage == 'TH' ? "ReportNameTH" : "ReportNameEN"), title: "ReportName" }
                ],
                responsive: true,
                destroy:true
            });

            break;
    }    
}
/* old report list
 let _reportLists = [
                { "ReportGroup": "CS", "ReportCode": "JobKPI", "ReportNameEN": "Performance Summary", "ReportNameTH": "รายงานสรุปการปฏิบัติงานของพนักงานว่าทำได้ตามเป้าหรือไม่" },
                { "ReportGroup": "CS", "ReportCode": "JobOperComplete", "ReportNameEN": "Complete Operation", "ReportNameTH": "รายงานงานที่ดำเนินการตรวจปล่อยเสร็จแล้ว" },
                { "ReportGroup": "CS", "ReportCode": "JobOperDaily", "ReportNameEN": "Daily Operation by Date", "ReportNameTH": "รายงานงานประจำวันตามวันที่ที่ต้องทำ" },
                { "ReportGroup": "CS", "ReportCode": "JobOperEmp", "ReportNameEN": "Operation By Staff", "ReportNameTH": "รายงานงานตามพนักงานCS/Shipping/Sales" },
                { "ReportGroup": "CS", "ReportCode": "JobOperMonthly", "ReportNameEN": "Monthly Operation (Detail)", "ReportNameTH": "รายงานงานประจำเดือนแบบแสดงรายละเอียดงาน" },
                { "ReportGroup": "CS", "ReportCode": "JobOperSum", "ReportNameEN": "Operation Summary", "ReportNameTH": "รายงานสรุปจำนวนงานตามแผนก" },
                { "ReportGroup": "CS", "ReportCode": "JobOperWeekly", "ReportNameEN": "Weekly Operation", "ReportNameTH": "รายงานงานประจำสัปดาห์แบบแสดงรายละเอียดงานที่ต้องทำ" },
                { "ReportGroup": "CS", "ReportCode": "JobPending", "ReportNameEN": "Pending Operation", "ReportNameTH": "รายงานงานที่กำลังดำเนินการอยู่" },
                { "ReportGroup": "CS", "ReportCode": "JobStatusMonthly", "ReportNameEN": "Monthly Summary ", "ReportNameTH": "รายงานสรุปงานประจำเดือนว่างานไหนที่เสร็จแล้วหรือยังไม่เสร็จ" },
                { "ReportGroup": "CS", "ReportCode": "JobStatusWeekly", "ReportNameEN": "Weekly Summary", "ReportNameTH": "รายงานผลการติดตามงานประจำสัปดาห์ว่างานไหนเรียบร้อยหรือไม่" },
                { "ReportGroup": "SALES", "ReportCode": "JobTracking", "ReportNameEN": "Tracking Status", "ReportNameTH": "รายงานการติดตามสถานะงานว่าอยู่ในขั้นตอนไหน" },
                { "ReportGroup": "SALES", "ReportCode": "JobProfit", "ReportNameEN": "Costing And Profit Summary", "ReportNameTH": "รายงานสรุปกำไรขาดทุนจากการปิดค่าใช้จ่าย" },
                { "ReportGroup": "CS", "ReportCode": "AdvBalance", "ReportNameEN": "Advance Balance", "ReportNameTH": "รายงานสรุปการเบิกค่าใช้จ่ายในภาพรวม" },
                { "ReportGroup": "CS", "ReportCode": "AdvBilled", "ReportNameEN": "Advance Billed", "ReportNameTH": "รายงานสรุปเงินเบิกที่วางบิลแล้ว" },
                { "ReportGroup": "CS", "ReportCode": "AdvCleared", "ReportNameEN": "Advance Cleared", "ReportNameTH": "รายงานเงินเบิกที่ปิดค่าใช้จ่ายไปแล้ว" },
                { "ReportGroup": "FIN", "ReportCode": "RcpTaxOngoing", "ReportNameEN": "Daily Receipt/Tax Preparation", "ReportNameTH": "รายงานการเตรียมงานประจำวัน" },
                { "ReportGroup": "FIN", "ReportCode": "AdvDailyPay", "ReportNameEN": "Daily Advance Payment", "ReportNameTH": "รายงานการจ่ายเงินประจำวัน" },
                { "ReportGroup": "CS", "ReportCode": "AdvDailyReq", "ReportNameEN": "Daily Advance Request", "ReportNameTH": "รายงานการขอเบิกเงินประจำวัน" },
                { "ReportGroup": "CS", "ReportCode": "AdvFollow", "ReportNameEN": "Advance Followup", "ReportNameTH": "รายงานสรุปเงินเบิกที่ต้องติดตาม" },
                { "ReportGroup": "FIN", "ReportCode": "AdvMonthly", "ReportNameEN": "Advance Summary Monthly", "ReportNameTH": "รายงานเงินเบิกรายเดือน" },
                { "ReportGroup": "CS", "ReportCode": "AdvOnclear", "ReportNameEN": "Advance On-clear", "ReportNameTH": "รายงานเงินเบิกที่ใช้ค่าใช้จ่ายไปแล้ว" },
                { "ReportGroup": "CS", "ReportCode": "AdvOngoing", "ReportNameEN": "Advance On-hold", "ReportNameTH": "รายงานเงินเบิกที่รอเคลียร์" },
                { "ReportGroup": "FIN", "ReportCode": "AdvSumClear", "ReportNameEN": "Advance Summary Cleared", "ReportNameTH": "รายงานสรุปเงินเบิกที่ปิดค่าใช้จ่ายแล้ว" },
                { "ReportGroup": "FIN", "ReportCode": "AdvWeekly", "ReportNameEN": "Advance Summary Weekly", "ReportNameTH": "รายงานเงินเบิกรายสัปดาห์" },
                { "ReportGroup": "FIN", "ReportCode": "APDaily", "ReportNameEN": "Payment Preparation", "ReportNameTH": "รายงานการรับวางบิล" },
                { "ReportGroup": "BILL", "ReportCode": "BillDaily", "ReportNameEN": "Daily Billing Report", "ReportNameTH": "รายงานใบวางบิลรายวัน" },
                { "ReportGroup": "BILL", "ReportCode": "BillDue", "ReportNameEN": "Billing Due confirm", "ReportNameTH": "รายงานการติดตามวันนัดรับชำระเงิน" },
                { "ReportGroup": "FIN", "ReportCode": "CashPredict", "ReportNameEN": "Cash Prediction", "ReportNameTH": "รายงานประมาณการการรับ/จ่ายเงินล่วงหน้า" },
                { "ReportGroup": "FIN", "ReportCode": "ChqPayDaily", "ReportNameEN": "Cheque Issue", "ReportNameTH": "รายงานการออกเช็ค" },
                { "ReportGroup": "FIN", "ReportCode": "ChqRcvDaily", "ReportNameEN": "Cheque Receive", "ReportNameTH": "รายงานการรับเช็ค" },
                { "ReportGroup": "BILL", "ReportCode": "ClrBilled", "ReportNameEN": "Billing Clearance", "ReportNameTH": "รายงานค่าใช้จ่ายที่เรียกเก็บแล้ว" },
                { "ReportGroup": "BILL", "ReportCode": "ClrDaily", "ReportNameEN": "Daily Clearing Request", "ReportNameTH": "รายงานการปิดค่าใช้จ่ายรายวัน" },
                { "ReportGroup": "FIN", "ReportCode": "PayDaily", "ReportNameEN": "Cash Payment Daily", "ReportNameTH": "รายงานการจ่ายเงิน" },
                { "ReportGroup": "FIN", "ReportCode": "PettyCash", "ReportNameEN": "Petty Cash Movement", "ReportNameTH": "รายงานเงินสดย่อย" },
                { "ReportGroup": "FIN", "ReportCode": "RcpDaily", "ReportNameEN": "Daily Receipt", "ReportNameTH": "รายงานการออกใบเสร็จรับเงิน" },
                { "ReportGroup": "FIN", "ReportCode": "RcpTaxFollow", "ReportNameEN": "Receipt/Tax-invoice Pending", "ReportNameTH": "รายงานใบเสร็จ/ใบกำกับค้างชำระ" },
                { "ReportGroup": "FIN", "ReportCode": "RcpTaxPayment", "ReportNameEN": "Receipt/Tax-invoice Payment", "ReportNameTH": "รายงานการรับชำระตามใบเสร็จ/ใบกำกับ" },
                { "ReportGroup": "FIN", "ReportCode": "RcpTaxSum", "ReportNameEN": "Receipt Summary", "ReportNameTH": "รายงานสรุปการรับชำระเงินตามใบเสร็จ/ใบกำกับภาษี" },
                { "ReportGroup": "FIN", "ReportCode": "RcvDaily", "ReportNameEN": "Cash Receive Daily", "ReportNameTH": "รายงานการรับเงิน" },
                { "ReportGroup": "FIN", "ReportCode": "TaxDaily", "ReportNameEN": "Daily Tax-Invoice", "ReportNameTH": "รายงานการออกใบกำกับภาษี" },
                { "ReportGroup": "FIN", "ReportCode": "AccruedSum", "ReportNameEN": "Accrued Summary", "ReportNameTH": "รายงานรายได้ค้างรับ/ค่าใช้จ่ายค้างจ่าย" },
                { "ReportGroup": "FIN", "ReportCode": "CashFlow", "ReportNameEN": "Cash Flow", "ReportNameTH": "รายงานการรับจ่ายเงิน" },
                { "ReportGroup": "BILL", "ReportCode": "ClrOngoing", "ReportNameEN": "Billing Preparation", "ReportNameTH": "รายงานค่าใช้จ่ายที่รอวางบิล" },
                { "ReportGroup": "BILL", "ReportCode": "InvBilled", "ReportNameEN": "Invoice Billed", "ReportNameTH": "รายงานใบแจ้งหนี้ที่ส่งวางบิลแล้ว" },
                { "ReportGroup": "BILL", "ReportCode": "InvDaily", "ReportNameEN": "Daily Invoice", "ReportNameTH": "รายงานใบแจ้งหนี้ประจำวัน" },
                { "ReportGroup": "BILL", "ReportCode": "InvOnhold", "ReportNameEN": "Invoice Pending", "ReportNameTH": "รายงานใบแจ้งหนี้ที่รอวางบิล" },
                { "ReportGroup": "BILL", "ReportCode": "InvStatus", "ReportNameEN": "Invoice Status", "ReportNameTH": "รายงานสถานะใบแจ้งหนี้ว่าวางบิลหรือยัง" },
                { "ReportGroup": "BILL", "ReportCode": "InvSummary", "ReportNameEN": "Invoice Summary", "ReportNameTH": "รายงานสรุปใบแจ้งหนี้" },
                { "ReportGroup": "CS", "ReportCode": "JobClearing", "ReportNameEN": "Clearing Summary", "ReportNameTH": "รายงานสรุปการปิดค่าใช้จ่าย" },
                { "ReportGroup": "BILL", "ReportCode": "BillOverdue", "ReportNameEN": "Billing Overdue", "ReportNameTH": "รายงานใบวางบิลที่เลยกำหนดดิวชำระเงิน" },
                { "ReportGroup": "BILL", "ReportCode": "BillSummary", "ReportNameEN": "Billing Summary", "ReportNameTH": "รายงานสรุปการวางบิล" },
                { "ReportGroup": "ACC", "ReportCode": "Adjustment", "ReportNameEN": "Adjustment Report", "ReportNameTH": "รายงานการปรับปรุงบัญชี" },
                { "ReportGroup": "ACC", "ReportCode": "APDetail", "ReportNameEN": "Account Payables", "ReportNameTH": "รายงานเจ้าหนี้รายตัว" },
                { "ReportGroup": "ACC", "ReportCode": "ARDetail", "ReportNameEN": "Account Receivables", "ReportNameTH": "รายงานลูกหนี้รายตัว" },
                { "ReportGroup": "ACC", "ReportCode": "ARSummary", "ReportNameEN": "Followup Summary", "ReportNameTH": "รายงานสรุปลูกหนี้คงค้าง" },
                { "ReportGroup": "ACC", "ReportCode": "BalanceSheet", "ReportNameEN": "Balance Sheet", "ReportNameTH": "รายงานงบดุล" },
                { "ReportGroup": "FIN", "ReportCode": "BookFlow", "ReportNameEN": "Book Account Movement", "ReportNameTH": "รายงานการเคลื่อนไหวเงินฝากธนาคาร" },
                { "ReportGroup": "ACC", "ReportCode": "CNDNDaily", "ReportNameEN": "Credit/Debit Note", "ReportNameTH": "รายงานการออกใบเพิ่มหนี้ลดหนี้" },
                { "ReportGroup": "ACC", "ReportCode": "CostingDetail", "ReportNameEN": "Cost and Profit", "ReportNameTH": "รายงานกำไรขาดทุน" },
                { "ReportGroup": "ACC", "ReportCode": "GLBatch", "ReportNameEN": "G/L Batch", "ReportNameTH": "รายงานสมุดรายวันทั่วไป" },
                { "ReportGroup": "ACC", "ReportCode": "JobCosting", "ReportNameEN": "Costing By Job", "ReportNameTH": "รายงานต้นทุนขั้นต้น" },
                { "ReportGroup": "ACC", "ReportCode": "PODetail", "ReportNameEN": "Purchase Report", "ReportNameTH": "รายงานสมุดรายวันซื้อ" },
                { "ReportGroup": "ACC", "ReportCode": "ProfitLoss", "ReportNameEN": "Profit and loss", "ReportNameTH": "รายงานงบกำไรขาดทุน" },
                { "ReportGroup": "ACC", "ReportCode": "SalesTax", "ReportNameEN": "Sales Tax", "ReportNameTH": "รายงานภาษีขายตามใบกำกับภาษี" },
                { "ReportGroup": "ACC", "ReportCode": "SODetail", "ReportNameEN": "Sales Report", "ReportNameTH": "รายงานสมุดรายวันขาย" },
                { "ReportGroup": "ACC", "ReportCode": "TrialBalance", "ReportNameEN": "Trial Balance", "ReportNameTH": "รายงานงบทดลอง" },
                { "ReportGroup": "ACC", "ReportCode": "VATMonthly", "ReportNameEN": "VAT Report", "ReportNameTH": "รายงานภาษีมูลค่าเพิ่ม" },
                { "ReportGroup": "ACC", "ReportCode": "WHTMonthly", "ReportNameEN": "WHT Report", "ReportNameTH": "รายงานภาษี ณ ที่จ่าย" }
            ];
 */
