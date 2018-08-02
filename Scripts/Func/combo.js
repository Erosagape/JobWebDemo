function loadBranch() {
    $('#cboBranch').empty();
    $.get('Config/getBranch').done(function (r) {
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
function loadConfig(e, code) {
    $(e).empty();
    $.get('Config/getConfig?Code=' + code).done(function (r) {
        var dr = r.config.data;
        if (dr.length > 0) {
            for (var i = 0; i < dr.length; i++) {
                $(e).append($('<option>', { value: dr[i].ConfigKey })
                    .text(dr[i].ConfigKey + ' / ' + dr[i].ConfigValue));
            }
        }
    });
}
function loadYear() {
    $('#cboYear').empty();
    $.get('joborder/getjobyear').done(function (r) {
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