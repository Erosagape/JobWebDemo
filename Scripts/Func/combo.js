//Function for loading combo / drop down selector
function loadCombos(path, params) {
    var arr = params.split(',');
    var qry = '';
    var ctls = '';
    for (var i = 0; i < arr.length; i++) {
        var obj = arr[i].split('=');
        if (qry != '') qry += ',';
        if (ctls != '') ctls += ',';
        qry += obj[0];
        ctls += obj[1];
    }
    loadConfigMultiple(path, qry, ctls);
}
function loadConfigMultiple(path, list, controls) {
    var query = list.split(",").join("','");
    $.get(path + 'Config/getConfig?Code=' + query).done(function (r) {
        var arr = r.config.data;
        var ctl = controls.split(',');
        var cfg = list.split(',');
        if (arr.length > 0) {
            for (var i = 0; i < cfg.length; i++) {
                var dr = $.grep(arr, function (data) {
                    return data.ConfigCode === cfg[i];
                });
                loadComboArray(ctl[i], dr, '');
            }
        }
    });
}
function loadComboArray(e, dr, def) {
    $(e).empty();
    $(e).append($('<option>', { value: '' })
        .text('N/A'));
    if (dr.length > 0) {
        for (var i = 0; i < dr.length; i++) {
            $(e).append($('<option>', { value: dr[i].ConfigKey.trim() })
                .text(dr[i].ConfigKey.trim() + ' / ' + dr[i].ConfigValue.trim()));
        }
        $(e).val(def);
    }
}
function loadConfig(e, code, path, def) {
    $(e).empty();
    $(e).append($('<option>', { value: '' })
        .text('N/A'));
    $.get(path +'Config/getConfig?Code=' + code).done(function (r) {
        var dr = r.config.data;
        if (dr.length > 0) {
            for (var i = 0; i < dr.length; i++) {
                    $(e).append($('<option>', { value: dr[i].ConfigKey.trim() })
                        .text(dr[i].ConfigKey.trim() + ' / ' + dr[i].ConfigValue.trim()));
            }
            $(e).val(def);
        }
    });
}
function loadBank(cb, path) {
    $.get(path + 'Master/GetBank').done(function (r) {
        var dr = r.bank.data;
        for (var j = 0; j < cb.length; j++) {
            var e = cb[j];
            $(e).empty();
            $(e).append($('<option>', { value: '' })
                .text('N/A'));
            if (dr.length > 0) {
                for (var i = 0; i < dr.length; i++) {
                    $(e).append($('<option>', { value: dr[i].Code.trim() })
                        .text(dr[i].BName.trim()));
                }
            }
        }
    });
}
function loadBranch(path) {
    $('#cboBranch').empty();
    $.get(path + 'Config/getBranch').done(function (r) {
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
function loadServiceGroup(path,e,foradv) {
    $(e).empty();
    if (foradv !== undefined) {
        if (foradv == true) {
            $(e)
                .append($('<option>', { value: "" })
                    .text("N/A"));
        }
    }
    $.get(path + 'Master/GetServiceGroup').done(function (r) {
        var dr = r.servicegroup.data;
        if (dr.length > 0) {
            for (var i = 0; i < dr.length; i++) {
                $(e)
                    .append($('<option>', { value: dr[i].GroupCode })
                        .text(dr[i].GroupCode + ' / ' + dr[i].GroupName));
            }
        }
    });
}
function loadMonth(e) {
    $(e).empty();
    $(e).append($('<option>', { value: '' })
        .text('ALL'));
    for (var i = 1; i <= 12; i++) {
        $(e)
            .append($('<option>', { value: i })
                .text(i.toString()));
    }
}
function loadLang(e) {
    $(e).empty();
    $(e).append($('<option>', { value: 'TH' })
        .text('ไทย'));
    $(e).append($('<option>', { value: 'EN' })
        .text('English'));
}
function loadYear(path) {
    $('#cboYear').empty();
    $('#cboYear').append($('<option>', { value: '' })
        .text('ALL'));
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
function ShowInvNo(path, Branch, Code, ControlID) {
    $(ControlID).val('');
    if ((Code + Branch).length > 0) {
        $.get(path + 'JobOrder/GetJobSql?Branch=' + Branch + '&JNo=' + Code)
            .done(function (r) {
                if (r.job.data.length > 0) {
                    var c = r.job.data[0];
                    $(ControlID).val(c.InvNo);
                }
            });
    }
}
function ShowCustomer(path, Code, Branch, ControlID) {
    $(ControlID).val('');
    if ((Code + Branch).length > 0) {
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
    if ((Code + Branch).length > 0) {
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
function ShowCurrency(path, Code, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Master/GetCurrency?Code=' + Code)
        .done(function (r) {
            if (r.currency.data.length > 0) {
                var b = r.currency.data[0];
                $(ControlID).val(b.TName);
            }
        });
}
function ShowBank(path, Code, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Master/GetBank?Code=' + Code)
        .done(function (r) {
            if (r.bank.data.length > 0) {
                var b = r.bank.data[0];
                $(ControlID).val(b.BName);
            }
        });
}
function ShowBookAccount(path, Code, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Master/GetBookAccount?Code=' + Code)
        .done(function (r) {
            if (r.bookaccount.data.length > 0) {
                var b = r.bookaccount.data[0];
                $(ControlID).val(b.BookName);
            }
        });
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