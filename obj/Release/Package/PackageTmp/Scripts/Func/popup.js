//basic function tools for binding
function CheckSession(ev) {
    $.get('/Config/GetLogin', function (r) {
        if (r.user.data.UserID == null) {
            $('#cboDatabase').empty();
            $('#cboDatabase').append($('<option>', { value: '' })
                .text('N/A'));
            $.get('/Config/GetDatabase').done(function (dr) {
                if (dr.database.length > 0) {
                    for (let i = 0; i < dr.database.length; i++) {
                        $('#cboDatabase').append($('<option>', { value: (i + 1) })
                            .text(dr.company + '->' + dr.database[i].trim()));
                    }
                    $('#cboDatabase').val(1);
                    $('#dvLogin').modal('show');
                }
            });
        } else {
            ev();
        }
    });
}
function CheckPassword(db, user, ev) {
    bootbox.prompt({
        title: "Please enter your password",
        inputType: 'password',
        buttons: {
            cancel: {
                label: 'Cancel',
                className: 'btn-danger'
            },
            confirm: {
                label: 'Confirm',
                className: 'btn-success'                
            }
        },
        callback: function (pass) {
            if (pass !== null) {
                $.get('/Config/SetLogin?Database=' + db + '&Code=' + user + '&Pass=' + pass, function (r) {
                    if (r.user.data.length > 0) {
                        ev();
                    } else {
                        ShowMessage(r.user.message);
                    }
                });
            }
        }
    });
}
function ShowMessage(str) {
    try
    {
        bootbox.alert(str);
    }
    catch
    {
        alert(str);
    }
}
function ShowConfirm(str,func) {
    bootbox.confirm(str, func);
}
function CreateLOV(dv, frm, tb, name, html, c) {
    if (c <= 4) html = html.replace('<th>desc2</th>', '');
    if (c <= 3) html = html.replace('<th>desc1</th>', '');
    if (c <= 2) html = html.replace('<th>name</th>', '');
    if (c == 1) html = html.replace('<th>key</th>', '');

    let lov = document.createElement("div");
    lov.className = "modal fade";
    lov.setAttribute("role", "dialog");
    lov.id = frm.replace("#", "");
    dv.appendChild(lov);

    let struct = html.replace('tbX', tb.replace("#", "")).replace('cpX', name);
    BindList(frm, tb, struct);
}
function BindList(d, t, l) {
    //use for set html of tables and set focus when showing
    $(d).html(l);
    $(d).on('shown.bs.modal', function () {
        $(t + '_filter input').focus();
    });
}
function BindEvent(t, d, ev) {
    //use for bind event of popup when click some row and selected data
    $(t + ' tbody').on('click', 'button', function () {
        let dt = GetSelect(t, this); //read current row selected
        ev(dt); //callback function from caller 
        $(d).modal('hide');
    });
    $(t + ' tbody').on('click', 'tr', function () {
        $(t + ' tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
        $(this).addClass('selected'); //select row ใหม่
    });
    $(d).modal('show');
}
function ShowWait() {
    if ($('#dvWaiting').is(':visible')) {
        return;
    }
    $('#dvWaiting').modal('show');
}
function CloseWait() {
    $('#dvWaiting').modal('hide');  
}
//Function for loading data to Grid for popup selection
function SetGridConfigList(p, g, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Config/GetList', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'config.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "ConfigCode", title: "Setting" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridConfigVal(p, g, t, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Config/GetConfig?Prefix=' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'config.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "ConfigCode", title: "Code" },
            { data: "ConfigKey", title: "Key" },
            { data: "ConfigValue", title: "Value" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridVender(p, g ,d ,ev) {
    $(g).DataTable({
        ajax: {
            url: p+'Master/GetVender', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'vender.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "VenCode", title: "รหัส" },
            { data: "TName", title: "ชื่อ" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridSICode(p, g, t, d, ev) {
    //popup for search data
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetServiceCode?Code=' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'servicecode.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "SICode", title: "Service Code" },
            { data: "NameThai", title: "Description" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridSICodeFilter(p, g, t, d, ev) {
    //popup for search data
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetServiceCode' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'servicecode.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "SICode", title: "Service Code" },
            { data: "NameThai", title: "Description" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridSICodeByGroup(p, g, t, d, ev) {
    //popup for search data
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetServiceCode?Group=' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'servicecode.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "SICode", title: "Service Code" },
            { data: "NameThai", title: "Description" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridDocument(p, g, d, t, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Acc/GetDocBalance' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'document.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "DocNo", title: "เลขที่" },
            {
                data: null, title: "วันที่เช็ค",
                render: function (data) {
                    return CDateTH(data.VoucherDate);
                }
            },
            { data: "CreditAmount", title: "ยอดเงินที่ตั้งไว้" },
            { data: "AmountUsed", title: "ยอดเงินที่ใช้" },
            { data: "AmountRemain", title: "ยอดเงินคงเหลือ" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridCheque(p, g, d, t, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Acc/GetCheque' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'cheque.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "ChqNo", title: "เลขที่" },
            {
                data: null, title: "วันที่เช็ค",
                render: function (data) {
                    return CDateTH(data.ChqDate);
                }
            },
            { data: "ChqAmount", title: "ยอดเงินหน้าเช็ค" },
            { data: "AmountUsed", title: "ยอดเงินที่ใช้" },
            { data: "AmountRemain", title: "ยอดเงินคงเหลือ" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridCustomsUnit(p, g, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetCustomsUnit', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'customsunit.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "Code", title: "รหัส" },
            { data: "TName", title: "คำอธิบาย" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridAccountCode(p, g, d, t, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetAccountCode'+ t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'accountcode.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "AccCode", title: "รหัส" },
            { data: "AccTName", title: "คำอธิบาย" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridCurrency(p, g , d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetCurrency', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'currency.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "Code", title: "รหัส" },
            { data: "TName", title: "คำอธิบาย" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridGroupCode(p, g, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetServiceGroup', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'servicegroup.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "GroupCode", title: "รหัส" },
            { data: "GroupName", title: "คำอธิบาย" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridUnit(p, g ,d ,ev) {
    $.get(p + 'master/getcustomsunit')
        .done(function (r) {
            let dr = r.customsunit.data;
            if (dr.length > 0) {
                $(g).DataTable({
                    data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "Code", title: "code" },
                        { data: "TName", title: "value" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                let html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                BindEvent(g, d, ev);
            }
        });

}
function SetGridBranch(p, g, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Config/GetBranch', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'branch.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "Code", title: "รหัส" },
            { data: "BrName", title: "ชื่อ" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridUser(p, g, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetUser', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'user.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "UserID", title: "รหัส" },
            { data: "TName", title: "ชื่อ" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridCompanyByGroup(p, g,t, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetCompany?Group=' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'company.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "CustCode", title: "รหัส" },
            { data: "Branch", title: "สาขา" },
            { data: "NameThai", title: "คำอธิบาย" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridCompany(p, g, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetCompany', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'company.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "CustCode", title: "รหัส" },
            { data: "Branch", title: "สาขา" },
            { data: "NameThai", title: "คำอธิบาย" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridCustContact(p, g, t, d, ev) {
    $.get(p + 'master/getcompanycontact' + t)
        .done(function (r) {
            let dr = r.companycontact.data;
            if (dr.length > 0) {
                $(g).DataTable({
                    data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "ContactName", title: "ชื่อผู้ติดต่อ" },
                        { data: "Department", title: "แผนก" },
                        { data: "Position", title: "ตำแหน่ง" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                let html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true, //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page,
                    responsive: true
                });
                BindEvent(g, d, ev);
            } else {
                ShowMessage('Not Found Contact Of This Company');
            }
        });
}
function SetGridDataDistinct(p, g, t, d, ev) {
    $.get(p + 'joborder/getdatadistinct' + t)
        .done(function (r) {
            let dr = r[0].Table;
            if (dr.length > 0) {
                $(g).DataTable({
                    data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "val", title: "Data List" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                let html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                BindEvent(g, d, ev);
            }
        });
}
function SetGridInv(p, g, d, t, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'acc/getinvheader' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'invheader.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "DocNo", title: "Invoice No" },
            { data: "CustCode", title: "Customer" },
            { data: "TotalNet", title: "Total" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridJob(p, g, d, t, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'joborder/getjobsql'+ t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'job.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "JNo", title: "Job No" },
            { data: "InvNo", title: "Cust Inv" },
            { data: "DeclareNumber", title: "Declare" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridTransport(p, g, d, t, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'joborder/gettransportreport' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'transport.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "JNo", title: "Job No" },
            { data: "BookingNo", title: "BookingNo" },
            { data: "CTN_NO", title: "Container" },
            { data: "TruckNO", title: "Truck" },
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridInterPort(p, g, d, t, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetInterPort?Key=' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'interport.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "PortCode", title: "รหัส" },
            { data: "CountryCode", title: "ประเทศ" },
            { data: "PortName", title: "ชื่อ" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridCountry(p, g, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetCountry', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'country.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "CTYCODE", title: "รหัส" },
            { data: "CTYName", title: "ชื่อประเทศ" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridWeightUnit(p, g, d, ev) {
    $.get(p + 'joborder/getjobdatadistinct?field=GWUnit')
        .done(function (r) {
            let dr = r[0].Table;
            if (dr.length > 0) {
                $(g).DataTable({
                    data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "val", title: "value" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                let html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                BindEvent(g, d, ev);
            }
        });

}
function SetGridVessel(p, g, d, t, ev) {
    $.get(p + 'master/getvessel?type='+ t )
        .done(function (r) {
            let dr = r.vessel.data;
            if (dr.length > 0) {
                $(g).DataTable({
                    data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "TName", title: "ชื่อยานพาหนะ" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                let html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                BindEvent(g, d, ev);
            }
        });
}
function SetGridDeclareType(p, g, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetDeclareType', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'RFDCT.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "Type", title: "รหัส" },
            { data: "Description", title: "คำอธิบาย" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridCustomsPort(p, g, d, ev) {
    //popup for search data
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetCustomsPort', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'RFARS.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "AreaCode", title: "รหัส" },
            { data: "AreaName", title: "คำอธิบาย" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridServUnit(p, g, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetServUnit', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'servunit.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "UnitType", title: "รหัส" },
            { data: "UName", title: "คำอธิบาย" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridServUnitFilter(p, g, t, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetServUnit' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'servunit.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "UnitType", title: "รหัส" },
            { data: "UName", title: "คำอธิบาย" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridProjectName(p, g, d, ev) {
    $.get(p + 'joborder/getjobdatadistinct?field=ProjectName')
        .done(function (r) {
            let dr = r[0].Table;
            if (dr.length > 0) {
                $(g).DataTable({
                    data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "val", title: "ชื่อโครงการ" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                let html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                BindEvent(g, d, ev);
            }
        });
}
function SetGridInvProduct(p, g, d, ev) {
    $.get(p + 'joborder/getjobdatadistinct?field=InvProduct')
        .done(function (r) {
            let dr = r[0].Table;
            if (dr.length > 0) {
                $(g).DataTable({
                    data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "val", title: "ชื่อสินค้า" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                let html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                BindEvent(g, d, ev);
            }
        });
}
function SetGridProvince(p, g, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetProvince', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'province.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "ProvinceCode", title: "รหัส" },
            { data: "ProvinceName", title: "คำอธิบาย" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridProvinceSub(p, g, d, t, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetProvinceSub'+ t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'province.detail'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "District", title: "อำเภอ" },
            { data: "SubProvince", title: "ตำบล" },
            { data: "PostCode", title: "รหัสไปรษณีย์" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridBank(p, g, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetBank', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'bank.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "Code", title: "รหัส" },
            { data: "BName", title: "คำอธิบาย" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridBookAccount(p, g, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Master/GetBookAccount', //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'bookaccount.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "BookCode", title: "รหัส" },
            { data: "BookName", title: "คำอธิบาย" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridPayment(p, g, t, d, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'Acc/GetPaymentGrid' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'payment.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "DocNo", title: "Doc.No" },
            { data: "VenCode", title: "Vender" },
            {
                data: "DocDate", title: "Due.Date",
                render: function (data) {
                    return CDateTH(data);
                }
            },
            { data: "SDescription", title: "Expense" },
            { data: "Total", title: "Total" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridQuotation(p, g, t, d, ev) {
    //popup for search data
    $(g).DataTable({
        ajax: {
            url: p + 'JobOrder/GetQuotationGrid' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'quotation.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "QNo", title: "Quotation No" },
            { data: "QtyBegin", title: "Qty Begin" },
            { data: "QtyEnd", title: "Qty End" },
            { data: "ChargeAmt", title: "Price" },
            { data: "VenderCode", title: "Vender" },
            { data: "VenderCost", title: "Cost" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridJournal(p, g, d, t, ev) {
    $(g).DataTable({
        ajax: {
            url: p + 'acc/getjournalentry' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'journal.header'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "GLRefNo", title: "Batch No" },
            { data: "Remark", title: "Remark" },
            { data: "TotalDebit", title: "Debit" },
            { data: "TotalCredit", title: "Credit" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}