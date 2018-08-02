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
function JSDate(jsonDateString) {
    try {
        var jsDate = new Date(parseInt(jsonDateString.replace('/Date(', '')));
        var month = jsDate.getMonth() + 1;
        var day = jsDate.getDate();
        var year = jsDate.getFullYear();
        if (year < 2000) {
            return '';
        }
        if (month <= 9) month = '0' + month;
        if (day <= 9) day = '0' + day;
        var date = year + "-" + month + "-" + day;
        return date;
    }
    catch (e) {
        return '';
    }
}