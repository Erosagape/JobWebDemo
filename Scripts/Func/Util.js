﻿function GetSelect(tb, e) {
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
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, ' '));
}
function JSDate(sqlDateString) {
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
function JSTime(jsonDateString) {
    try {
        var jsDate = new Date(parseInt(jsonDateString.replace('/Date(', '')));
        var hour = jsDate.getHours();
        var min = jsDate.getMinutes();
        var sec = jsDate.getSeconds();
        if (hour <= 9) hour = '0' + hour;
        if (min <= 9) min = '0' + min;
        if (sec <= 9) sec = '0' + sec;
        var date = hour + ":" + min + ":" + sec;
        return date;
    }
    catch (e) {
        return '';
    }
}
function CDate(sqlDateString) {
    try {
        var jsDate = sqlDateString.substr(0, 10);
        var month = jsDate.substr(5,2);
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
function SQLDate(sqldateString) {
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
function GetToday() {
    var d = new Date(),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2) month = '0' + month;
    if (day.length < 2) day = '0' + day;

    return [year, month, day].join('-');
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