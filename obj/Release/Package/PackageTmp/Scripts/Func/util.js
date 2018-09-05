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
            return '';
        }
        var date = day + "/" + month + "/" + year;
        return date;
    }
    catch (e) {
        return '';
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
