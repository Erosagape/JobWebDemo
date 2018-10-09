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
        var dt = GetSelect(t, this); //read current row selected
        ev(dt); //callback function from caller 
        $(d).modal('hide');
    });
    $(t + ' tbody').on('click', 'tr', function () {
        $(t + ' tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
        $(this).addClass('selected'); //select row ใหม่
    });
    $(d).modal('show');
}
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
                    var html = "<button class='btn btn-warning'>Select</button>";
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
            url: p + 'Config/GetConfig?Code=' + t, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'config.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: null, title: "#" },
            { data: "ConfigKey", title: "Key" },
            { data: "ConfigValue", title: "Value" }
        ],
        "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    var html = "<button class='btn btn-warning'>Select</button>";
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
                    var html = "<button class='btn btn-warning'>Select</button>";
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
                    var html = "<button class='btn btn-warning'>Select</button>";
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
                    var html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridUnit(p, g ,d ,ev) {
    $.get(p + 'joborder/getjobdatadistinct?field=InvProductUnit')
        .done(function (r) {
            var dr = r[0].Table;
            if (dr.length > 0) {
                $(g).DataTable({
                    data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "val", title: "ชื่อหน่วย" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<button class='btn btn-warning'>Select</button>";
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
                    var html = "<button class='btn btn-warning'>Select</button>";
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
                    var html = "<button class='btn btn-warning'>Select</button>";
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
                    var html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}
function SetGridContactName(p, g, d, ev) {
    $.get(p + 'joborder/getjobdatadistinct?field=CustContactName')
        .done(function (r) {
            var dr = r[0].Table;
            if (dr.length > 0) {
                $(g).DataTable({
                    data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "val", title: "ชื่อผู้ติดต่อ" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<button class='btn btn-warning'>Select</button>";
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
                    var html = "<button class='btn btn-warning'>Select</button>";
                    return html;
                }
            }
        ],
        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
    });
    BindEvent(g, d, ev);
}