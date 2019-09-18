//function for javascripts usage
function QuickCallback(ev,db) {
    $.get('/Config/GetLogin')
        .done(function (r) {
            if (r.user.data.length > 0) {
                ev();
            } else {
                SetTempLogin(ev,db);
            }
        });
}
function SetTempLogin(ev,db) {    
    $.get('/Config/SetLogin?Type=Guest&Database='+ db)
        .done(function (r) {
            if (r.user.data.length > 0) {
                ev();
                CallLogout();
            }
        });
}
function CallLogout() {
    $.get('/Config/SetLogout')
        .done(function (r) {
            //alert('Process Complete');
        });
}
function sortData(obj, key, order) {
    obj.sort(compareValues(key, order));
}
function compareValues(key, order = 'asc') {
    return function (a, b) {
        if (!a.hasOwnProperty(key) ||
            !b.hasOwnProperty(key)) {
            return 0;
        }

        const varA = (typeof a[key] === 'string') ?
            a[key].toUpperCase() : a[key];
        const varB = (typeof b[key] === 'string') ?
            b[key].toUpperCase() : b[key];

        let comparison = 0;
        if (varA > varB) {
            comparison = 1;
        } else if (varA < varB) {
            comparison = -1;
        }
        return (
            (order == 'desc') ?
                (comparison * -1) : comparison
        );
    };
}
function GetSelect(tb, e) {
    //get selected value from LOV
    let indexRow = $(e).parents('tr');
    return $(tb).DataTable().row(indexRow).data();
}
function SetSelect(tb, that) {
    $(tb+' tbody > tr').removeClass('selected');
    $(that).addClass('selected');
}
function GetToday() {
    let d = new Date(),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2) month = '0' + month;
    if (day.length < 2) day = '0' + day;

    return [year, month, day].join('-');
}
function GetTime() {
    let d = new Date(),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear(),
        hour = d.getHours(),
        min = d.getMinutes(),
        sec = d.getSeconds();
    if (hour <= 9) hour = '0' + hour;
    if (min <= 9) min = '0' + min;
    if (sec <= 9) sec = '0' + sec;
    let time = hour + ":" + min + ":" + sec;

    if (month.length < 2) month = '0' + month;
    if (day.length < 2) day = '0' + day;

    return [year+543, month, day].join('-') + ' ' + time;
}
function getQueryString(name, url) {
    if (!url) url = window.location.href;
    url = url.toLowerCase();
    name = name.replace(/[\[\]]/g, '\\$&').toLowerCase();
    let regex = new RegExp('[?&]' + name + '(=([^&#]*)|&|#|$)'),
        results = regex.exec(url);
    if (!results) return '';
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, ' ')).toUpperCase();
}
//convertion utility function
function CDateTH(sqlDateString) {
    try {
        let jsDate = sqlDateString.substr(0, 10);
        let month = jsDate.substr(5, 2);
        let day = jsDate.substr(8, 2);
        let year = jsDate.substr(0, 4);
        if (year < '1901') {
            return '';
        }
        let yy = Number(year);
        if (yy < 2500) {
            yy = Number(year) + 543;
        }
        let date = yy + "-" + month + "-" + day;
        return date;
    }
    catch (e) {
        return '';
    }
}
function CDateEN(sqldateString) {
    try {
        let jsDate = sqldateString.substr(0, 10);
        let month = jsDate.substr(5, 2);
        let day = jsDate.substr(8, 2);
        let year = jsDate.substr(0, 4);
        if (year < '1901') {
            return '';
        }
        let date = year + "-" + month + "-" + day;
        return date;
    }
    catch (e) {
        return '';
    }
}
function CStr(data, length) {
    if (data == null) {
        return '';
    } else {
        return data.substr(0,length);
    }
}
function CDbl(data, dec) {
    try {
        return parseFloat(CNum(data)).toFixed(dec);
    }
    catch(e) {
        return CNum(data);
    }
}
function CNum(data) {
    if (data == undefined || data == NaN) {
        return 0;
    }
    if ((''+data).length==0) {
        return 0;
    } else {
        let num = data.toString().replace(',', '');
        return Number(num);
    }
}
function CNumThai(Number) {
    var Number = CheckNumber(Number);
    var NumberArray = new Array("ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ");
    var DigitArray = new Array("", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน");
    var BahtText = "";
    if (isNaN(Number)) {
        return "ข้อมูลนำเข้าไม่ถูกต้อง";
    } else {
        if ((Number - 0) > 9999999.9999) {
            return "ข้อมูลนำเข้าเกินขอบเขตที่ตั้งไว้";
        } else {
            Number = Number.split(".");
            if (Number[1].length > 0) {
                Number[1] = Number[1].substring(0, 2);
            }
            var NumberLen = Number[0].length - 0;
            for (var i = 0; i < NumberLen; i++) {
                var tmp = Number[0].substring(i, i + 1) - 0;
                if (tmp != 0) {
                    if ((i == (NumberLen - 1)) && (tmp == 1)) {
                        BahtText += "เอ็ด";
                    } else
                        if ((i == (NumberLen - 2)) && (tmp == 2)) {
                            BahtText += "ยี่";
                        } else
                            if ((i == (NumberLen - 2)) && (tmp == 1)) {
                                BahtText += "";
                            } else {
                                BahtText += NumberArray[tmp];
                            }
                    BahtText += DigitArray[NumberLen - i - 1];
                }
            }
            BahtText += "บาท";
            if ((Number[1] == "0") || (Number[1] == "00")) {
                BahtText += "ถ้วน";
            } else {
                DecimalLen = Number[1].length - 0;
                for (var i = 0; i < DecimalLen; i++) {
                    var tmp = Number[1].substring(i, i + 1) - 0;
                    if (tmp != 0) {
                        if ((i == (DecimalLen - 1)) && (tmp == 1)) {
                            BahtText += "เอ็ด";
                        } else
                            if ((i == (DecimalLen - 2)) && (tmp == 2)) {
                                BahtText += "ยี่";
                            } else
                                if ((i == (DecimalLen - 2)) && (tmp == 1)) {
                                    BahtText += "";
                                } else {
                                    BahtText += NumberArray[tmp];
                                }
                        BahtText += DigitArray[DecimalLen - i - 1];
                    }
                }
                BahtText += "สตางค์";
            }
            return BahtText;
        }
    }
}

function CheckNumber(Number) {
    var decimal = false;
    Number = Number.toString();
    Number = Number.replace(/ |,|บาท|฿/gi, '');
    for (var i = 0; i < Number.length; i++) {
        if (Number[i] == '.') {
            decimal = true;
        }
    }
    if (decimal == false) {
        Number = Number + '.00';
    }
    return Number
}
function CNumEng(s) {
    // Convert numbers to words
    // copyright 25th July 2006, by Stephen Chapman http://javascript.about.com
    // permission to use this Javascript on your web page is granted
    // provided that all of the code (including this copyright notice) is
    // used exactly as shown (you can change the numbering system if you wish)

    // American Numbering System
    let th = ['', 'thousand', 'million', 'billion', 'trillion'];
    // uncomment this line for English Number System
    // let th = ['','thousand','million', 'milliard','billion'];

    let dg = ['zero', 'one', 'two', 'three', 'four',
        'five', 'six', 'seven', 'eight', 'nine'];
    let tn = ['ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen',
        'seventeen', 'eighteen', 'nineteen'];
    let tw = ['twenty', 'thirty', 'forty', 'fifty',
        'sixty', 'seventy', 'eighty', 'ninety'];

    s = s.toString();
    s = s.replace(/[\, ]/g, '');
    if (s != parseFloat(s))
        return 'not a number';
    let x = s.indexOf('.');
    if (x == -1) x = s.length;
    if (x > 15)
        return 'too big';
    let n = s.split('');
    let str = '';
    let sk = 0;
    for (let i = 0; i < x; i++) {
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
        let y = s.length;
        let strp = 'point ';
        for (let i = x + 1; i < y; i++) {
            if (n[i] > 0) {
                strp += dg[n[i]] + ' ';
            }
        }
        if (strp == 'point ') strp = '';
        str += strp + ' only';
    }
    return str.replace(/\s+/g, ' ').toUpperCase();
}
function CCurrency(data) {
    return data.replace(/\d(?=(\d{3})+\.)/g, '$&,');
}
function ShowNumber(data, dec) {
    let numstr = CDbl(data,dec);
    return CCurrency(numstr);
}
function CCode(data) {
    let st = data;

    if (st < 10) st = "0" + st;
    return st;
}
function ShowDate(sqlDateString) {
    try {
        let jsDate = sqlDateString.substr(0, 10);
        let month = jsDate.substr(5, 2);
        let day = jsDate.substr(8, 2);
        let year = jsDate.substr(0, 4);
        if (year < '1901') {
            return '-';
        }
        let date = day + "/" + month + "/" + year;
        return date;
    }
    catch (e) {
        return '-';
    }
}
function ShowTime(sqlDateString) {
    try {
        let jsDate = sqlDateString.substr(11, 8);
        return jsDate;
    }
    catch (e) {
        return '-';
    }
}
//Dummy Data For Testing
function DummyCompanyData() {
    let o = {
        CompanyName: 'IDEAL CONSOLIDATORS CO.,LTD',
        CompanyAddress1: 'เลขที่ 65/122-123 อาคารชำนาญเพ็ญชาติ บิสเนส เซ็นเตอร์ ชั้น 14 ถนนพระราม 9',
        CompanyAddress2: 'แขวงห้วยขวาง เขตห้วยขวาง กรุงเทพมหานคร 10310'
    };
    return o;
}
//public query functions
function CallBackQueryProvince(p, code, ev) {
    $.get(p + 'master/getprovince?Code=' + code).done(function (r) {
        let dr = r.province.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryProvinceSub(p, code, ev) {
    $.get(p + 'master/getprovincesub?Code=' + code).done(function (r) {
        let dr = r.province.detail;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryClearExp(p, branch, code, job, ev) {
    $.get(p + 'adv/getclearexp?Branch=' + branch + '&Job=' + job + '&Code=' + code).done(function (r) {
        let dr = r.estimate.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryWHTax(p, branch,code, ev) {
    $.get(p + 'acc/getwhtax?branch=' + branch + '&code=' + code).done(function (r) {
        let dr = r.whtax.header;
        if (dr.length > 0) {
            ev(r.whtax.header[0],r.whtax.detail);
        }
    });
}
function CallBackQueryUserRole(p, code, ev) {
    $.get(p + 'config/getuserrole?Code=' + code).done(function (r) {
        let dr = r.userrole;
        if (dr.data.length > 0) {
            ev(dr);
        }
    });
}
function CallBackQueryBank(p, code, ev) {
    $.get(p + 'master/getbank?Code=' + code).done(function (r) {
        let dr = r.bank.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryBookAccount(p,br, code, ev) {
    $.get(p + 'master/getbookaccount?Branch='+br+'&Code=' + code).done(function (r) {
        let dr = r.bookaccount.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackAuthorize(p, app, mnu, chk ,ev) {
    $.get(p + 'config/checkmenuauth?app=' + app+'&menu='+mnu).done(function (r) {
        if (r.indexOf(chk) >= 0) {
            ev(true);
        } else {
            ev(false);
        }
    });
}
function CallBackQueryInterPort(p, code,key, ev) {
    $.get(p + 'master/getinterport?Code=' + code + '&Key='+key).done(function (r) {
        let dr = r.interport.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryService(p, code, ev) {
    $.get(p + 'master/getservicecode?code=' + code).done(function (r) {
        let dr = r.servicecode.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryCustomer(p, cno, br, ev) {
    $.get(p + 'master/getcompany?Code=' + cno + '&Branch=' + br).done(function (r) {
        let dr = r.company.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryCustomerSingle(p, cno, ev) {
    $.get(p + 'master/getcompany?Code=' + cno).done(function (r) {
        let dr = r.company.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryCountry(p, code, ev) {
    $.get(p + 'master/getcountry?Code=' + code).done(function (r) {
        let dr = r.country.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryCustomsUnit(p, code, ev) {
    $.get(p + 'master/getcustomsunit?Code=' + code).done(function (r) {
        var dr = r.customsunit.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryCurrency(p, cno, ev) {
    $.get(p + 'master/getcurrency?Code=' + cno).done(function (r) {
        let dr = r.currency.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryJob(p, br, jno, ev) {
    $.get(p + 'joborder/getjobsql?Branch=' + br + '&JNo=' + jno).done(function (r) {
        let dr = r.job.data;
        if (dr.length > 0) {
            ev(dr);
        }
    });
}
function CallBackQueryUser(p, UserID, ev) {
    $.get(p + 'Master/GetUser?Code=' + UserID)
        .done(function (r) {
            if (r.user.data.length > 0) {
                let b = r.user.data[0];
                ev(b);
            }
        });
}
function CallBackQueryVessel(p, code, ev) {
    $.get(p + 'master/getvessel?Code=' + code).done(function (r) {
        var dr = r.vessel.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryVender(p, VenCode, ev) {
    $.get(p + 'Master/GetVender?Code=' + VenCode)
        .done(function (r) {
            if (r.vender.data.length > 0) {
                let b = r.vender.data[0];
                ev(b);
            }
        });
}
function CallBackQueryServUnit(p, code, ev) {
    $.get(p + 'master/getservunit?Code=' + code).done(function (r) {
        let dr = r.servunit.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryDeclareType(p, code, ev) {
    $.get(p + 'master/getdeclaretype?Code=' + code).done(function (r) {
        let dr = r.RFDCT.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryCustomsPort(p, code, ev) {
    $.get(p + 'master/getcustomsport?Code=' + code).done(function (r) {
        let dr = r.RFARS.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryUserAuth(p, code,app,menu, ev) {
    $.get(p + 'config/getuserauth?Code=' + code+'&App='+app+'&Menu='+menu).done(function (r) {
        let dr = r.userauth.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryVoucher(p, branch,code, ev) {
    $.get(p + 'acc/getvoucher?Branch='+branch+'&Code=' + code).done(function (r) {
        let dr = r.voucher;
        if (dr!=null) {
            ev(dr);
        }
    });
}
function CallBackQueryServiceGroup(p, code, ev) {
    $.get(p + 'master/getservicegroup?Code=' + code).done(function (r) {
        let dr = r.servicegroup.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryBudgetPolicy(p, code, ev) {
    $.get(p + 'master/getbudgetpolicy?Code=' + code).done(function (r) {
        let dr = r.budgetpolicy.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryPayment(p, br, no, ev) {
    $.get(p + 'acc/getpayment?Branch=' + br + '&Code=' + no).done(function (r) {
        let dr = r.payment;
        if (dr.header.length > 0) {
            ev(dr);
        }
    });
}
function CallBackQueryGLHeader(p, branch, code, ev) {
    $.get(p + 'acc/getjournalentry?Branch=' + branch + '&Code=' + code).done(function (r) {
        let dr = r.journal.header;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryAccountCode(p, code, ev) {
    $.get(p + 'master/getaccountcode?Code=' + code).done(function (r) {
        let dr = r.accountcode.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function ShowConfigValue(path, Code, Key, ControlID) {
    let strParam = "";
    if (Code != "") {
        strParam += "Code=" + Code;
    }
    if (Key != "") {
        if (strParam != "") strParam += "&";
        strParam += "Key=" + Key;
    }
    if (strParam != "") strParam = "?" + strParam;
    $.get(path + 'Config/getConfig' + strParam)
        .done(function (response) {
            if (response.config.data.length == 0) {
                $(ControlID).val('');
                return;
            }
            $(ControlID).val(response.config.data[0].ConfigValue);
        });
}

//call linked page function
function CallOpenJob(p, br, jno) {
    window.open(p + 'joborder/showjob?BranchCode=' + br + '&JNo=' + jno);
}
function CallPrintJob(p, br, jno) {
    window.open(p + 'joborder/formjob?BranchCode=' + br + '&JNo=' + jno);
}

