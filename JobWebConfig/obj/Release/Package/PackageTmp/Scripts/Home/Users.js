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
    $.get('/Home/GetUser')
        .done(function (r) {
            if (r !== null) {
                $('#tbTest').DataTable({
                    data: r.user.data,
                    columns: [
                        { data: "TWTUserID", title: "UserID" },
                        { data: "TWTUserName", title: "Password" }
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
    $('#txtTWTUserID').val(dr.TWTUserID);
    $('#txtTWTUserPassword').val(dr.TWTUserPassword);
    $('#txtTWTUserName').val(dr.TWTUserName);
}
function SaveData() {
    var obj = {
        TWTUserID: $('#txtTWTUserID').val(),
        TWTUserPassword: $('#txtTWTUserPassword').val(),
        TWTUserName: $('#txtTWTUserName').val()
    };
    if (obj.TWTUserID != "") {
        var ask = confirm("Do you need to Save " + obj.TWTUserID + "?");
        if (ask == false) return;
        var jsonText = JSON.stringify({ data: obj });
        //alert(jsonText);
        $.ajax({
            url: "/home/setuser",
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
    var code = row.TWTUserID;
    if (code !== undefined) {
        var ask = confirm("Do you need to Delete " + code + "?");
        if (ask == false) return;
        $.get('/home/deluser?id=' + code, function (r) {
            alert(r);
            ShowData();
        });
    } else {
        alert('no data selected');
    }
}
function ClearData() {
    row = {};
    $('#txtTWTUserID').val('');
    $('#txtTWTUserPassword').val('');
    $('#txtTWTUserName').val('');
    $('#dvEditor').modal('show');
}