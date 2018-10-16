//Function for loading combo / drop down selector
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
//Show Data Related from Combo or Text After Input
function ShowCustomer(path, Code, Branch, ControlID) {
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
function ShowCustomerFull(path, Code, Branch, CustNameID,NameThaiID,NameEngID,PhoneFaxID) {
    if ((Code + Branch).length > 0) {
        if (PhoneFaxID == '') {
            $(CustNameID).val('');
            $(NameEngID).val('');
            $(NameThaiID).val('');
        } else {
            $(CustNameID).val('');
            $(NameEngID).val('');
            $(NameThaiID).val('');
            $(PhoneFaxID).val('');
        }
        $.get(path + 'Master/GetCompany?Code=' + Code + '&Branch=' + Branch)
            .done(function (r) {
                if (r.company.data.length > 0) {
                    var c = r.company.data[0];
                    if (PhoneFaxID == '') {
                        $(CustNameID).val(c.NameThai);
                        $(NameEngID).val((c.EAddress1 + ' ' + c.EAddress2).trim());
                        $(NameThaiID).val((c.TAddress1 + ' ' + c.TAddress2).trim());
                    } else {
                        $(CustNameID).val(c.NameThai);
                        $(NameEngID).val((c.EAddress1 + ' ' + c.EAddress2).trim());
                        $(NameThaiID).val((c.TAddress1 + ' ' + c.TAddress2).trim());
                        $(PhoneFaxID).val(c.Phone);
                    }
                }
            });
    }
}
function ShowUser(path ,UserID, ControlID) {
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
function ShowBranch(path, Branch, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Config/GetBranch?Code=' + Branch)
        .done(function (r) {
            if (r.branch.data.length > 0) {
                var b = r.branch.data[0];
                $(ControlID).val(b.BrName);
            }
        });
}
function ShowVender(path, VenderID, ControlID) {
    $(ControlID).val('');
    if (VenderID != "") {
        $.get(path + 'Master/GetVender?Code=' + VenderID)
            .done(function (r) {
                if (r.vender.data.length > 0) {
                    var b = r.vender.data[0];
                    $(ControlID).val(b.TName);
                }
            });
    }
}
function ShowCountry(path, CountryID, ControlID) {
    $(ControlID).val('');
    if (CountryID != "") {
        $.get(path + 'Master/GetCountry?Code=' + CountryID)
            .done(function (r) {
                if (r.country.data.length > 0) {
                    var b = r.country.data[0];
                    $(ControlID).val(b.CTYName);
                }
            });
    }
}
function ShowInterPort(path, CountryID, PortCode, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Master/GetInterPort?Code=' + PortCode + '&Key=' + CountryID)
        .done(function (r) {
            if (r.interport.data.length > 0) {
                var b = r.interport.data[0];
                $(ControlID).val(b.PortName);
            }
        });
}
function ShowDeclareType(path, Code, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Master/GetDeclareType?Code=' + Code)
        .done(function (r) {
            if (r.RFDCT.data.length > 0) {
                var b = r.RFDCT.data[0];
                $(ControlID).val(b.Description);
            }
        });
}
function ShowReleasePort(path, Code, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Master/GetCustomsPort?Code=' + Code)
        .done(function (r) {
            if (r.RFARS.data.length > 0) {
                var b = r.RFARS.data[0];
                $(ControlID).val(b.AreaName);
            }
        });
}
function ShowServiceCode(path, Code, ControlID) {
    $(ControlID).val('');
    $.get(path + 'master/getservicecode?code=' + Code)
        .done(function (r) {
            if (r.servicecode.data.length > 0) {
                var b = r.servicecode.data[0];
                $(ControlID).val(b.NameThai);
            }
        });
}
function GetServiceCode(path, Code, ev) {
    $.get(path + 'master/getservicecode?code=' + Code)
        .done(function (r) {
            if (r.servicecode.data.length > 0) {
                var b = r.servicecode.data[0];
                ev(b);
            }
        });
}
function ShowJobTypeShipBy(path, jt, sb, js ,ControlJT,ControlSB,ControlST) {
    $(ControlJT).val('');
    $(ControlSB).val('');
    if (jt < 10) jt = '0' + jt;
    if (sb < 10) sb = '0' + sb;
    $.get(path + 'Config/GetConfig?Code=JOB_TYPE&Key=' + jt)
        .done(function (r) {
            var b = r.config.data;
            if (b.length > 0) {
                $(ControlJT).val(b[0].ConfigValue);
            }
        });
    $.get(path + 'Config/GetConfig?Code=SHIP_BY&Key=' + sb)
        .done(function (r) {
            var b = r.config.data;
            if (b.length > 0) {
                $(ControlSB).val(b[0].ConfigValue);
            }
        });
    if (ControlST != "") {
        $(ControlST).val('');
        if (js < 10) js = '0' + js;
        $.get(path + 'Config/GetConfig?Code=JOB_STATUS&Key=' + js)
            .done(function (r) {
                var b = r.config.data;
                if (b.length > 0) {
                    $(ControlST).val(b[0].ConfigValue);
                }
            });
    }
}
