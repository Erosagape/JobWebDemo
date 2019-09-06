//Function for loading combo / drop down selector
function loadCombos(path, params) {
    let arr = params.split(',');
    let qry = '';
    let ctls = '';
    for (let i = 0; i < arr.length; i++) {
        let obj = arr[i].split('=');
        if (qry != '') qry += ',';
        if (ctls != '') ctls += ',';
        qry += obj[0];
        ctls += obj[1];
    }
    loadConfigMultiple(path, qry, ctls);
}
function loadConfigMultiple(path, list, controls) {
    let query = list.split(",").join("','");
    $.get(path + 'Config/getConfig?Code=' + query).done(function (r) {
        let arr = r.config.data;
        let ctl = controls.split(',');
        let cfg = list.split(',');
        if (arr.length > 0) {
            for (let i = 0; i < cfg.length; i++) {
                let dr = $.grep(arr, function (data) {
                    return data.ConfigCode === cfg[i];
                });
                let d = '';
                let o = ctl[i];
                if (o.indexOf('|') > 0) {
                    d = o.substr(o.indexOf('|') + 1);
                    o = o.substr(0, o.indexOf('|'));
                }
                loadComboArray(o, dr, d);
            }
        }
    });
}
function loadComboArray(e, dr, def) {
    $(e).empty();
    $(e).append($('<option>', { value: '' })
        .text('N/A'));
    if (dr.length > 0) {
        for (let i = 0; i < dr.length; i++) {
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
        let dr = r.config.data;
        if (dr.length > 0) {
            for (let i = 0; i < dr.length; i++) {
                    $(e).append($('<option>', { value: dr[i].ConfigKey.trim() })
                        .text(dr[i].ConfigKey.trim() + ' / ' + dr[i].ConfigValue.trim()));
            }
            $(e).val(def);
        }
    });
}
function loadDatabase(e) {
    $(e).empty();
    $(e).append($('<option>', { value: '' })
        .text('N/A'));
    $.get('Config/GetDatabase').done(function (dr) {
        if (dr.database.length > 0) {
            for (let i = 0; i < dr.database.length; i++) {
                $(e).append($('<option>', { value: (i+ 1) })
                    .text(dr.company + '->' + dr.database[i].trim()));
            }            
            $(e).val(1);
        }
    });
}
function loadUnit(e, path, filter) {
    $.get(path + 'Master/GetServUnit' + filter).done(function (r) {
        let dr = r.servunit.data;
        $(e).empty();
        $(e).append($('<option>', { value: '' })
            .text('N/A'));
        if (dr.length > 0) {
            for (let i = 0; i < dr.length; i++) {
                $(e).append($('<option>', { value: dr[i].UnitType.trim() })
                    .text(dr[i].UName.trim()));
            }
        }
    });
}
function loadBank(cb, path) {
    $.get(path + 'Master/GetBank').done(function (r) {
        let dr = r.bank.data;
        for (let j = 0; j < cb.length; j++) {
            let e = cb[j];
            $(e).empty();
            $(e).append($('<option>', { value: '' })
                .text('N/A'));
            if (dr.length > 0) {
                for (let i = 0; i < dr.length; i++) {
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
        let dr = r.branch.data;
        if (dr.length > 0) {
            for (let i = 0; i < dr.length; i++) {
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
        let dr = r.servicegroup.data;
        if (dr.length > 0) {
            for (let i = 0; i < dr.length; i++) {
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
    for (let i = 1; i <= 12; i++) {
        $(e)
            .append($('<option>', { value: i })
                .text(i.toString()));
    }
    $(e).val(new Date().getMonth()+1);
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
        let dr = r[0].Table;
        if (dr.length > 0) {
            for (let i = 0; i < dr.length; i++) {
                $('#cboYear')
                    .append($('<option>', { value: dr[i].JobYear })
                        .text(dr[i].JobYear));
            }
            $('#cboYear').val(new Date().getFullYear());
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
                    let c = r.job.data[0];
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
                    let c = r.company.data[0];
                    $(ControlID).val(c.NameThai);
                }
            });
    }
}
function ShowCompanyByTax(path, Code, ControlID) {
    $(ControlID).val('');
    if (Code.length > 0) {
        $.get(path + 'Master/GetCompany?TaxNumber=' + Code)
            .done(function (r) {
                if (r.company.data.length > 0) {
                    let c = r.company.data[0];
                    $(ControlID).val(c.NameThai);
                }
            });
    }
}
function ShowCompany(path, Code, ControlID) {
    $(ControlID).val('');
    if (Code.length > 0) {
        $.get(path + 'Master/GetCompany?Code=' + Code)
            .done(function (r) {
                if (r.company.data.length > 0) {
                    let c = r.company.data[0];
                    $(ControlID).val(c.NameThai);
                }
            });
    }
}
function ShowCustomerAddress(path, Code, Branch, ControlIDName,ControlIDAddr) {
    $(ControlIDName).val('');
    $(ControlIDAddr).val('');
    if ((Code + Branch).length > 0) {
        $.get(path + 'Master/GetCompany?Code=' + Code + '&Branch=' + Branch)
            .done(function (r) {
                if (r.company.data.length > 0) {
                    let c = r.company.data[0];
                    $(ControlIDName).val(c.NameThai);
                    $(ControlIDAddr).val(c.TAddress1+ ' '+c.TAddress2);
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
                    let c = r.company.data[0];
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
                    let b = r.user.data[0];
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
                let b = r.currency.data[0];
                $(ControlID).val(b.TName);
            }
        });
}
function ShowAccount(path, Code, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Master/GetAccountCode?Code=' + Code)
        .done(function (r) {
            if (r.accountcode.data.length > 0) {
                let b = r.accountcode.data[0];
                $(ControlID).val(b.AccTName);
            }
        });
}
function ShowBank(path, Code, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Master/GetBank?Code=' + Code)
        .done(function (r) {
            if (r.bank.data.length > 0) {
                let b = r.bank.data[0];
                $(ControlID).val(b.BName);
            }
        });
}
function ShowBookAccount(path, Code, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Master/GetBookAccount?Code=' + Code)
        .done(function (r) {
            if (r.bookaccount.data.length > 0) {
                let b = r.bookaccount.data[0];
                $(ControlID).val(b.BookName);
            }
        });
}
function ShowBranch(path, Branch, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Config/GetBranch?Code=' + Branch)
        .done(function (r) {
            if (r.branch.data.length > 0) {
                let b = r.branch.data[0];
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
                    let b = r.vender.data[0];
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
                    let b = r.country.data[0];
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
                let b = r.interport.data[0];
                $(ControlID).val(b.PortName);
            }
        });
}
function ShowDeclareType(path, Code, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Master/GetDeclareType?Code=' + Code)
        .done(function (r) {
            if (r.RFDCT.data.length > 0) {
                let b = r.RFDCT.data[0];
                $(ControlID).val(b.Description);
            }
        });
}
function ShowReleasePort(path, Code, ControlID) {
    $(ControlID).val('');
    $.get(path + 'Master/GetCustomsPort?Code=' + Code)
        .done(function (r) {
            if (r.RFARS.data.length > 0) {
                let b = r.RFARS.data[0];
                $(ControlID).val(b.AreaName);
            }
        });
}
function ShowServiceCode(path, Code, ControlID) {
    $(ControlID).val('');
    $.get(path + 'master/getservicecode?code=' + Code)
        .done(function (r) {
            if (r.servicecode.data.length > 0) {
                let b = r.servicecode.data[0];
                $(ControlID).val(b.NameThai);
            }
        });
}
function GetServiceCode(path, Code, ev) {
    $.get(path + 'master/getservicecode?code=' + Code)
        .done(function (r) {
            if (r.servicecode.data.length > 0) {
                let b = r.servicecode.data[0];
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
            let b = r.config.data;
            if (b.length > 0) {
                $(ControlJT).val(b[0].ConfigValue);
            }
        });
    $.get(path + 'Config/GetConfig?Code=SHIP_BY&Key=' + sb)
        .done(function (r) {
            let b = r.config.data;
            if (b.length > 0) {
                $(ControlSB).val(b[0].ConfigValue);
            }
        });
    if (ControlST != "") {
        $(ControlST).val('');
        if (js < 10) js = '0' + js;
        $.get(path + 'Config/GetConfig?Code=JOB_STATUS&Key=' + js)
            .done(function (r) {
                let b = r.config.data;
                if (b.length > 0) {
                    $(ControlST).val(b[0].ConfigValue);
                }
            });
    }
}