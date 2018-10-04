function GetSelect(tb, e) {
    //get selected value from LOV
    var indexRow = $(e).parents('tr');
    return $(tb).DataTable().row(indexRow).data();
}
//utility function
function getQueryString(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, '\\$&');
    var regex = new RegExp('[?&]' + name + '(=([^&#]*)|&|#|$)'),
        results = regex.exec(url);
    if (!results) return '';
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, ' '));
}
function CDateTH(sqlDateString) {
    try {
        var jsDate = sqlDateString.substr(0, 10);
        var month = jsDate.substr(5, 2);
        var day = jsDate.substr(8, 2);
        var year = jsDate.substr(0, 4);
        if (year < '2000') {
            return '';
        }
        var date = Number(year)+543 + "-" + month + "-" + day;
        return date;
    }
    catch (e) {
        return '';
    }
}
function CDateEN(sqldateString) {
    try {
        var jsDate = sqldateString.substr(0, 10);
        var month = jsDate.substr(5, 2);
        var day = jsDate.substr(8, 2);
        var year = jsDate.substr(0, 4);
        if (year < '2000') {
            return '';
        }
        var date = year + "-" + month + "-" + day;
        return date;
    }
    catch (e) {
        return '';
    }
}
function CNum(data) {
    if (data == '') {
        return 0;
    } else {
        return data;
    }
}
function CCurrency(data) {
    return data.replace(/\d(?=(\d{3})+\.)/g, '$&,');
}
function ShowDate(sqlDateString) {
    try {
        var jsDate = sqlDateString.substr(0, 10);
        var month = jsDate.substr(5, 2);
        var day = jsDate.substr(8, 2);
        var year = jsDate.substr(0, 4);
        if (year < '2000') {
            return '-';
        }
        var date = day + "/" + month + "/" + year;
        return date;
    }
    catch (e) {
        return '-';
    }
}
function GetToday() {
    var d = new Date(),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2) month = '0' + month;
    if (day.length < 2) day = '0' + day;

    return [year, month, day].join('-');
}
function GetTime() {
    var d = new Date(),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear(),
        hour = d.getHours(),
        min = d.getMinutes(),
        sec = d.getSeconds();
    if (hour <= 9) hour = '0' + hour;
    if (min <= 9) min = '0' + min;
    if (sec <= 9) sec = '0' + sec;
    var time = hour + ":" + min + ":" + sec;

    if (month.length < 2) month = '0' + month;
    if (day.length < 2) day = '0' + day;

    return [year+543, month, day].join('-') + ' ' + time;
}
function CNumEng(s) {
    // Convert numbers to words
    // copyright 25th July 2006, by Stephen Chapman http://javascript.about.com
    // permission to use this Javascript on your web page is granted
    // provided that all of the code (including this copyright notice) is
    // used exactly as shown (you can change the numbering system if you wish)

    // American Numbering System
    var th = ['', 'thousand', 'million', 'billion', 'trillion'];
    // uncomment this line for English Number System
    // var th = ['','thousand','million', 'milliard','billion'];

    var dg = ['zero', 'one', 'two', 'three', 'four',
        'five', 'six', 'seven', 'eight', 'nine'];
    var tn = ['ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen',
        'seventeen', 'eighteen', 'nineteen'];
    var tw = ['twenty', 'thirty', 'forty', 'fifty',
        'sixty', 'seventy', 'eighty', 'ninety'];

    s = s.toString();
    s = s.replace(/[\, ]/g, '');
    if (s != parseFloat(s))
        return 'not a number';
    var x = s.indexOf('.');
    if (x == -1) x = s.length;
    if (x > 15)
        return 'too big';
    var n = s.split('');
    var str = '';
    var sk = 0;
    for (var i = 0; i < x; i++) {
        if ((x - i) % 3 == 2) {
            if (n[i] == '1') {
                str += tn[Number(n[i + 1])] + ' '; i++; sk = 1;
            } else if (n[i] != 0) {
                str += tw[n[i] - 2] + ' '; sk = 1;
            }
        } else if (n[i] != 0) {
            str += dg[n[i]] + ' ';
            if ((x - i) % 3 == 0)
                str += 'hundred ';
            sk = 1;
        }
        if ((x - i) % 3 == 1) {
            if (sk) str += th[(x - i - 1) / 3] + ' ';
            sk = 0;
        }

    }
    if (x != s.length) {
        var y = s.length;
        var strp = 'point ';
        for (var i = x + 1; i < y; i++) {
            if (n[i] > 0) {
                strp += dg[n[i]] + ' ';
            }
        }
        if (strp == 'point ') strp = '';
        str += strp + ' only';
    }
    return str.replace(/\s+/g, ' ').toUpperCase();
}
function DummyCompanyData() {
    var o = {
        CompanyName: 'IDEAL CONSOLIDATORS CO.,LTD',
        CompanyAddress1: 'เลขที่ 65/122-123 อาคารชำนาญเพ็ญชาติ บิสเนส เซ็นเตอร์ ชั้น 14 ถนนพระราม 9',
        CompanyAddress2: 'แขวงห้วยขวาง เขตห้วยขวาง กรุงเทพมหานคร 10310'
    };
    return o;
}
function DummyJobData() {
    var j = {
        BranchCode: '00',
        JNo: 'DIS1806-00162',
        JobType: 1,
        ShipBy: 2,
        JobStatus: 3,
        CSCode: 'ADMIN',
        CustCode: 'ECCO',
        CustBranch: '0000',
        JRevised: 0,
        DocDate: '2018-09-06',
        QNo: 'QUO1807-0001',
        Revised: 1,
        InvNo: '9001122154',
        DeclareNumber: 'A171011259901',
        Commission: 0,
        CustContactName: 'Khun Too',
        ConfirmDate: '2018-09-04',

        TRemark: 'ererererere erererererererererer erererererere ererererer ererererere ererererere erererer erereerere',

        CloseJobDate: '2018-09-08',

        CustRefNO: '-',
        Description: 'adfsdfdf หกดกด  ำพำพำพำพำ ำำำพะ้่ั่',

        CancelReson: '',

        consigneecode: 'ABB',

        CancelDate: null,

        ProjectName: 'TEST PROJECTS',
        InvProduct: 'TEST PRODUCTS',
        InvProductQty: 10,
        InvProductUnit: 'C62',
        TotalQty: 2,
        InvTotal: 56248.75,
        Measurement: 1.2315,
        TotalNW: 50,
        TotalGW: 49,
        GWUnit: 'KGM',
        InvCurUnit: 'USD',
        InvCurRate: 32.0199,
        InvCountry: 'US',
        InvFCountry: 'TH',

        BookingNo: 'BK000001',
        BLNo: 'BL0000001',
        HAWB: 'HAWB000001',
        MAWB: 'MAWB000001',
        ForwarderCode: 'WW025',

        VesselName: 'YANTRA BHUM V.0256E',
        MVesselName: '-',
        InvInterPort: 'JFK',
        AgentCode: 'WW030',

        TotalContainer: '1xLCL 1xTRK6 CY',

        ETDDate: '2018-06-01',
        ETADate: '2018-06-02',
        LoadDate: '2018-06-03',
        EstDeliverDate: '2018-06-04',
        ImExDate: '2018-06-05',
        ReadyToClearDate: '2018-06-06',
        DutyDate: '2018-06-05',
        ClearDate: '2018-06-06',

        DeclareType: 100,
        ClearPort: 2801,

        DutyAmount: 500,
        ShippingEmp: 'ADISAK',

        ShippingCmd: 'ลานบางนา กม.8 ก่อน 8.00',

        DutyLtdPayChqAmt: 0,
        DutyLtdPayCashAmt: 0,
        DutyLtdPayEPAYAmt: 0,
        DutyLtdPayOtherAmt: 0,
        DutyLtdPayOther: 0,

        DutyCustPayChqAmt: 0,
        DutyCustPayCashAmt: 0,
        DutyCustPayCardAmt: 0,
        DutyCustPayBankAmt: 0,
        DutyCustPayEPAYAmt: 500,
        DutyCustPayOtherAmt: 0,
        DutyCustPayOther: 0
    };
    return j;
}
function DummyAdvanceData() {
    var data = {
        "adv":
            {
                "header":
                    [{
                        "BranchCode": "00",
                        "AdvNo": "DAV-1808-0003",
                        "CustCode": "MPENS",
                        "CustBranch": "0000",
                        "JobType": 1,
                        "ShipBy": 7,
                        "AdvDate": "2018-08-01T00:08:00",
                        "AdvType": 1,
                        "EmpCode": "JIRAKUL",
                        "JNo": "DIF1808-00002",
                        "InvNo": "",
                        "DocStatus": 4,
                        "VATRate": 7,
                        "TotalAdvance": 2294.8,
                        "TotalVAT": 159.24,
                        "Total50Tavi": 22.75,
                        "TRemark": "TESTESTESTESTESTESTESTEST",
                        "ApproveBy": "JIRAKUL",
                        "ApproveDate": "2018-08-01T00:08:00",
                        "ApproveTime": "1900-01-01T08:49:48",
                        "PaymentBy": "MANASANOK",
                        "PaymentDate": "2018-08-01T00:08:00",
                        "PaymentTime": "1900-01-01T08:54:51",
                        "PaymentRef": "PV-D1808-0003",
                        "CancelReson": "",
                        "CancelProve": "",
                        "CancelDate": "0001-01-01T00:00:00",
                        "CancelTime": "1900-01-01T00:00:00",
                        "AdvCash": 0.0,
                        "AdvChqCash": 2431.29,
                        "AdvChq": 0.0,
                        "AdvCred": 0.0,
                        "PayChqTo": "PENANSHIN SHIPPING (THAILAND) LTD.",
                        "PayChqDate": "0001-01-01T00:00:00",
                        "Doc50Tavi": "DWT-1808-0042"
                    }],
                "detail":
                    [{
                        "BranchCode": "00", "AdvNo": "DAV-1808-0003", "ItemNo": 1, "STCode": "STD", "SICode": "SNG-112", "AdvAmount": 1000.0, "IsChargeVAT": 1, "ChargeVAT": 70.0, "Rate50Tavi": 1.0, "Charge50Tavi": 10.0, "TRemark": "", "IsDuplicate": 0, "PayChqTo": null, "Doc50Tavi": null, "ForJNo": "DIF1808-00002"
                    }, { "BranchCode": "00", "AdvNo": "DAV-1808-0003", "ItemNo": 2, "STCode": "STD", "SICode": "SNG-065", "AdvAmount": 216.0, "IsChargeVAT": 1, "ChargeVAT": 15.12, "Rate50Tavi": 1.0, "Charge50Tavi": 2.16, "TRemark": "", "IsDuplicate": 0, "PayChqTo": null, "Doc50Tavi": null, "ForJNo": "DIF1808-00002" }, { "BranchCode": "00", "AdvNo": "DAV-1808-0003", "ItemNo": 3, "STCode": "STD", "SICode": "SNG-064", "AdvAmount": 216.0, "IsChargeVAT": 1, "ChargeVAT": 15.12, "Rate50Tavi": 1.0, "Charge50Tavi": 2.16, "TRemark": "", "IsDuplicate": 0, "PayChqTo": null, "Doc50Tavi": null, "ForJNo": "DIF1808-00002" }, { "BranchCode": "00", "AdvNo": "DAV-1808-0003", "ItemNo": 4, "STCode": "STD", "SICode": "SNG-113", "AdvAmount": 200.0, "IsChargeVAT": 1, "ChargeVAT": 14.0, "Rate50Tavi": 1.0, "Charge50Tavi": 2.0, "TRemark": "", "IsDuplicate": 0, "PayChqTo": null, "Doc50Tavi": null, "ForJNo": "DIF1808-00002" }, { "BranchCode": "00", "AdvNo": "DAV-1808-0003", "ItemNo": 5, "STCode": "STD", "SICode": "SNG-118", "AdvAmount": 64.8, "IsChargeVAT": 1, "ChargeVAT": 4.54, "Rate50Tavi": 1.0, "Charge50Tavi": 0.65, "TRemark": "", "IsDuplicate": 0, "PayChqTo": null, "Doc50Tavi": null, "ForJNo": "DIF1808-00002" }, { "BranchCode": "00", "AdvNo": "DAV-1808-0003", "ItemNo": 6, "STCode": "STD", "SICode": "SNG-117", "AdvAmount": 108.0, "IsChargeVAT": 1, "ChargeVAT": 7.56, "Rate50Tavi": 1.0, "Charge50Tavi": 1.08, "TRemark": "", "IsDuplicate": 0, "PayChqTo": null, "Doc50Tavi": null, "ForJNo": "DIF1808-00002" }, { "BranchCode": "00", "AdvNo": "DAV-1808-0003", "ItemNo": 7, "STCode": "STD", "SICode": "SNG-067", "AdvAmount": 200.0, "IsChargeVAT": 1, "ChargeVAT": 14.0, "Rate50Tavi": 1.0, "Charge50Tavi": 2.0, "TRemark": "", "IsDuplicate": 0, "PayChqTo": null, "Doc50Tavi": null, "ForJNo": "DIF1808-00002" }, { "BranchCode": "00", "AdvNo": "DAV-1808-0003", "ItemNo": 8, "STCode": "STD", "SICode": "SNG-116", "AdvAmount": 270.0, "IsChargeVAT": 1, "ChargeVAT": 18.9, "Rate50Tavi": 1.0, "Charge50Tavi": 2.7, "TRemark": "", "IsDuplicate": 0, "PayChqTo": null, "Doc50Tavi": null, "ForJNo": "DIF1808-00002" }, {
                        "BranchCode": "00", "AdvNo": "DAV-1808-0003", "ItemNo": 9, "STCode": "STD", "SICode": "SNG-029", "AdvAmount": 20.0, "IsChargeVAT": 0, "ChargeVAT": 0.0, "Rate50Tavi": 0.0, "Charge50Tavi": 0.0, "TRemark": "", "IsDuplicate": 0, "PayChqTo": null, "Doc50Tavi": null, "ForJNo": "DIF1808-00002"
                    }]
            }
    };
    return data;
}