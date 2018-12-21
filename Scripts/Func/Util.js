//function for javascripts usage
function GetSelect(tb, e) {
    //get selected value from LOV
    var indexRow = $(e).parents('tr');
    return $(tb).DataTable().row(indexRow).data();
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
function getQueryString(name, url) {
    if (!url) url = window.location.href;
    url = url.toLowerCase();
    name = name.replace(/[\[\]]/g, '\\$&').toLowerCase();
    var regex = new RegExp('[?&]' + name + '(=([^&#]*)|&|#|$)'),
        results = regex.exec(url);
    if (!results) return '';
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, ' '));
}
//convertion utility function
function CDateTH(sqlDateString) {
    try {
        var jsDate = sqlDateString.substr(0, 10);
        var month = jsDate.substr(5, 2);
        var day = jsDate.substr(8, 2);
        var year = jsDate.substr(0, 4);
        if (year < '2000') {
            return '';
        }
        var yy = Number(year);
        if (yy < 2500) {
            yy = Number(year) + 543;
        }
        var date = yy + "-" + month + "-" + day;
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
    if ((''+data).length==0) {
        return 0;
    } else {
        return Number(data);
    }
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
function CCurrency(data) {
    return data.replace(/\d(?=(\d{3})+\.)/g, '$&,');
}
function CCode(data) {
    var st = data;

    if (st < 10) st = "0" + st;
    return st;
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
function ShowTime(sqlDateString) {
    try {
        var jsDate = sqlDateString.substr(11, 8);
        return jsDate;
    }
    catch (e) {
        return '-';
    }
}
//Dummy Data For Testing
function DummyCompanyData() {
    var o = {
        CompanyName: 'IDEAL CONSOLIDATORS CO.,LTD',
        CompanyAddress1: 'เลขที่ 65/122-123 อาคารชำนาญเพ็ญชาติ บิสเนส เซ็นเตอร์ ชั้น 14 ถนนพระราม 9',
        CompanyAddress2: 'แขวงห้วยขวาง เขตห้วยขวาง กรุงเทพมหานคร 10310'
    };
    return o;
}
//public query functions
function CallBackQueryBank(p, code, ev) {
    $.get(p + 'master/getbank?Code=' + code).done(function (r) {
        var dr = r.bank.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryBookAccount(p,br, code, ev) {
    $.get(p + 'master/getbookaccount?Branch='+br+'&Code=' + code).done(function (r) {
        var dr = r.bank.data;
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
        var dr = r.interport.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryService(p, code, ev) {
    $.get(p + 'master/getservicecode?code=' + code).done(function (r) {
        var dr = r.servicecode.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryCustomer(p, cno, br, ev) {
    $.get(p + 'master/getcompany?Code=' + cno + '&Branch' + br).done(function (r) {
        var dr = r.company.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryCountry(p, code, ev) {
    $.get(p + 'master/getcountry?Code=' + code).done(function (r) {
        var dr = r.country.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryCurrency(p, cno, ev) {
    $.get(p + 'master/getcurrency?Code=' + cno).done(function (r) {
        var dr = r.currency.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryJob(p, br, jno, ev) {
    $.get(p + 'joborder/getjobsql?Branch=' + br + '&JNo=' + jno).done(function (r) {
        var dr = r.job.data;
        if (dr.length > 0) {
            ev(dr);
        }
    });
}
function CallBackQueryUser(p, UserID, ev) {
    $.get(p + 'Master/GetUser?Code=' + UserID)
        .done(function (r) {
            if (r.user.data.length > 0) {
                var b = r.user.data[0];
                ev(b);
            }
        });
}
function CallBackQueryVender(p, VenCode, ev) {
    $.get(p + 'Master/GetVender?Code=' + VenCode)
        .done(function (r) {
            if (r.vender.data.length > 0) {
                var b = r.vender.data[0];
                ev(b);
            }
        });
}
function CallBackQueryServUnit(p, code, ev) {
    $.get(p + 'master/getservunit?Code=' + code).done(function (r) {
        var dr = r.servunit.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryDeclareType(p, code, ev) {
    $.get(p + 'master/getdeclaretype?Code=' + code).done(function (r) {
        var dr = r.RFDCT.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryCustomsPort(p, code, ev) {
    $.get(p + 'master/getcustomsport?Code=' + code).done(function (r) {
        var dr = r.RFARS.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryUserAuth(p, code,app,menu, ev) {
    $.get(p + 'config/getuserauth?Code=' + code+'&App='+app+'&Menu='+menu).done(function (r) {
        var dr = r.userauth.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
function CallBackQueryVoucher(p, branch,code, ev) {
    $.get(p + 'acc/getvoucher?Branch='+branch+'&Code=' + code).done(function (r) {
        var dr = r.voucher;
        if (dr.length > 0) {
            ev(dr);
        }
    });
}
function ShowConfigValue(path, Code, Key, ControlID) {
    var strParam = "";
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
