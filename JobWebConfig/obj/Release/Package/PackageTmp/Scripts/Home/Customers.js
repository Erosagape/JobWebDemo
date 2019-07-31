let row = {};
SetEvents();
function SetEvents() {
    $('#btnAdd').on('click', ClearData);
    $('#btnDel').on('click', DeleteData);
    $('#btnSave').on('click', SaveData);
    $('#txtCustID').keydown(function (event) {
        if (event.which == 13) {
            var code = $('#txtCustID').val();
            ClearData();
            $('#txtCustID').val(code);
            SearchCustomer(code, ReadData);
        }
    });
}
function SearchCustomer(code, ev) {
    $.get('/home/getcustomer?Code=' + code).done(function (r) {
        var dr = r.customer.data;
        if (dr.length > 0) {
            ev(dr[0]);
        }
    });
}
//CRUD Functions used in HTML Java Scripts
function DeleteData() {
    var code = $('#txtCustID').val();
    var ask = confirm("Do you need to Delete " + code + "?");
    if (ask == false) return;
    $.get('/home/delcustomer?code=' + code, function (r) {
        alert(r.customer.result);
        ClearData();
    });
}
function ReadData(dr) {
    $('#txtCustID').val(dr.CustID);
    $('#txtCustName').val(dr.CustName);
    $('#txtCustTaxID').val(dr.CustTaxID);
    $('#txtCustAddress').val(dr.CustAddress);
    $('#txtCustContact').val(dr.CustContact);
    $('#txtCustTelFaxMobile').val(dr.CustTelFaxMobile);
    $('#txtBeginDate').val(CDateEN(dr.BeginDate));
    $('#txtExpireDate').val(CDateEN(dr.ExpireDate));
    $('#txtActive').val(dr.Active);
    $('#txtCustRemark').val(dr.CustRemark);
    $('#txtCustMessage').val(dr.CustMessage);
}
function SaveData() {
    var obj = {
        CustID: $('#txtCustID').val(),
        CustName: $('#txtCustName').val(),
        CustTaxID: $('#txtCustTaxID').val(),
        CustAddress: $('#txtCustAddress').val(),
        CustContact: $('#txtCustContact').val(),
        CustTelFaxMobile: $('#txtCustTelFaxMobile').val(),
        BeginDate: CDateTH($('#txtBeginDate').val()),
        ExpireDate: CDateTH($('#txtExpireDate').val()),
        Active: $('#txtActive').val(),
        CustRemark: $('#txtCustRemark').val(),
        CustMessage: $('#txtCustMessage').val(),
    };
    if (obj.CustID != "") {
        var ask = confirm("Do you need to Save " + obj.CustID + "?");
        if (ask == false) return;
        var jsonText = JSON.stringify({ data: obj });
        //alert(jsonText);
        $.ajax({
            url: "/Home/SetCustomer",
            type: "POST",
            contentType: "application/json",
            data: jsonText,
            success: function (response) {
                if (response.result.data != null) {
                    $('#txtCustID').val(response.result.data);
                    $('#txtCustID').focus();
                }
                alert(response.result.msg);
            },
            error: function (e) {
                alert(e);
            }
        });
    } else {
        alert('No data to save');
    }
}
function ClearData() {
    $('#txtCustID').val('');
    $('#txtCustName').val('');
    $('#txtCustTaxID').val('');
    $('#txtCustAddress').val('');
    $('#txtCustContact').val('');
    $('#txtCustTelFaxMobile').val('');
    $('#txtBeginDate').val('');
    $('#txtExpireDate').val('');
    $('#txtActive').val('');
    $('#txtCustRemark').val('');
    $('#txtCustMessage').val('');
}