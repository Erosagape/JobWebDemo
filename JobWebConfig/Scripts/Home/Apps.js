let row = {};
ShowData();
SetEvents();
function SetEvents() {
    $('#btnAdd').on('click', ClearData);
    $('#btnDel').on('click', DeleteData);
    $('#btnSave').on('click', SaveData);
}
function ShowData() {
    row = {};
    $.get('/Home/GetListApp')
        .done(function (r) {
            if (r !== null) {
                $('#tbTest').DataTable({
                    data: r,
                    columns: [
                        { data: "AppID", title: "ID" },
                        { data: "AppNameTH", title: "Name" }
                    ],
                    destroy: true,
                    selected: true
                });
                $('#tbTest tbody').on('click', 'tr', function () {
                    $('#tbTest tbody > tr').removeClass('selected');
                    $(this).addClass('selected');
                    row = $('#tbTest').DataTable().row(this).data();
                    ReadData(row);
                });
                $('#tbTest tbody').on('dblclick', 'tr', function () {
                    $('#dvEditor').modal('show');
                });
            }
        });
}
function ReadData(dr) {
    $('#txtAppID').val(dr.AppID);
    $('#txtAppNameTH').val(dr.AppNameTH);
    $('#txtAppNameEN').val(dr.AppNameEN);
    $('#txtAppMainURL').val(dr.AppMainURL);
}
function SaveData() {
    var obj = {
        AppID: $('#txtAppID').val(),
        AppNameTH: $('#txtAppNameTH').val(),
        AppNameEN: $('#txtAppNameEN').val(),
        AppMainURL: $('#txtAppMainURL').val()
    };
    if (obj.AppID != "") {
        var ask = confirm("Do you need to Save " + obj.AppID + "?");
        if (ask == false) return;
        var jsonText = JSON.stringify({ data: obj });
        //alert(jsonText);
        $.ajax({
            url: "/home/setappdata",
            type: "post",
            contentType: "application/json",
            data: jsonText,
            success: function (response) {
                alert(response);
                ShowData();
            },
            error: function (e) {
                alert(e);
            }
        });
    } else {
        alert('No data to save');
    }
}
function DeleteData() {
    var code = row.AppID;
    if (code !== undefined) {
        var ask = confirm("Do you need to Delete " + code + "?");
        if (ask == false) return;
        $.get('/home/delappdata?id=' + code, function (r) {
            alert(r);
            ShowData();
        });
    } else {
        alert('no data selected');
    }
}
function ClearData() {
    row = {};
    $('#txtAppID').val('');
    $('#txtAppNameTH').val('');
    $('#txtAppNameEN').val('');
    $('#txtAppMainURL').val('');
    $('#dvEditor').modal('show');
}