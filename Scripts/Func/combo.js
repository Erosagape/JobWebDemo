function loadBranch(path) {
    $('#cboBranch').empty();
    $.get(path+'Config/getBranch').done(function (r) {
        var dr = r.branch.data;
        if (dr.length > 0) {
            for (var i = 0; i < dr.length; i++) {
                $('#cboBranch')
                    .append($('<option>', { value: dr[i].Code })
                        .text(dr[i].Code + ' / ' + dr[i].BrName));
            }
        }
    });
}
function loadConfig(e, code, path, def) {
    $(e).empty();
    $.get(path +'Config/getConfig?Code=' + code).done(function (r) {
        var dr = r.config.data;
        if (dr.length > 0) {
            for (var i = 0; i < dr.length; i++) {
                if (def == dr[i].ConfigKey.trim()) {
                    $(e).append($('<option selected>', { value: dr[i].ConfigKey.trim() })
                        .text(dr[i].ConfigKey.trim() + ' / ' + dr[i].ConfigValue.trim()));
                } else {
                    $(e).append($('<option>', { value: dr[i].ConfigKey.trim() })
                        .text(dr[i].ConfigKey.trim() + ' / ' + dr[i].ConfigValue.trim()));
                }
            }
        }
    });
}
function loadYear(path) {
    $('#cboYear').empty();
    $.get(path +'joborder/getjobyear').done(function (r) {
        var dr = r[0].Table;
        if (dr.length > 0) {
            for (var i = 0; i < dr.length; i++) {
                $('#cboYear')
                    .append($('<option>', { value: dr[i].JobYear })
                        .text(dr[i].JobYear));
            }
        }
    });
}
function ShowCustomer(Code, Branch, ControlID) {
    if ((Code + Branch).length > 0) {
        $(ControlID).val('');
        $.get(path + 'Master/GetCompany?Code=' + Code + '&Branch=' + Branch)
            .done(function (r) {
                if (r.company.data.length > 0) {
                    var c = r.company.data[0];
                    $(ControlID).val(c.NameThai);
                }
            });
    }
}
function ShowUser(UserID, ControlID) {
    $(ControlID).val('');
    if (UserID != "") {
        $.get(path + 'Master/GetUser?Code=' + UserID)
            .done(function (r) {
                if (r.user.data.length > 0) {
                    var b = r.user.data[0];
                    $(ControlID).val(b.TName);
                }
            });
    }
}
function ShowBranch(Branch, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Config/GetBranch?Code=' + Branch)
        .done(function (r) {
            if (r.branch.data.length > 0) {
                var b = r.branch.data[0];
                $(ControlID).val(b.BrName);
            }
        });
}