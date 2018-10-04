@code
    ViewBag.Title = "Create Job"
End Code
<div Class="panel-body">
    <table>
        <tr>
            <td>
                Job Type :
                <select id="cboJobType" class="form-control dropdown" style="width:230px"></select>
            </td>
            <td>
                Ship By :
                <select id="cboShipBy" class="form-control dropdown" style="width:230px"></select>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                Branch<br />
                <input type="text" style="width:120px" id="txtBranchCode" />
            </td>
            <td>
                <br />
                <input type="button" id="btnBrowseBranch" value="..." onclick="SearchData('branch')" />
            </td>
            <td>
                <br />
                <input type="text" style="width:300px" id="txtBranchName" disabled />
            </td>
        </tr>
        <tr>
            <td>
                พนักงาน CS<br />
                <input type="text" id="txtCSCode" style="width:120px" />
            </td>
            <td>
                <br />
                <input type="button" id="btnBrowseCS" value="..." onclick="SearchData('user')" />
            </td>
            <td>
                ชื่อพนักงาน<br />
                <input type="text" id="txtCSName" style="width:300px" disabled />
            </td>
        </tr>
        <tr>
            <td>
                รหัสลูกค้า<br />
                <input type="text" style="width:80px" id="txtCustCode" />
                <input type="text" style="width:40px" id="txtCustBranch" />
            </td>
            <td>
                <br />
                <input type="button" id="btnCust" value="..." onclick="SearchData('customer')" />
            </td>
            <td>
                ชื่อลูกค้า<br />
                <input type="text" style="width:300px" id="txtCustName" disabled />
            </td>
        </tr>
        <tr>
            <td>
                สถานที่วางบิล<br />
                <input type="text" id="txtConsignee" style="width:120px" />
            </td>
            <td>
                <br />
                <input type="button" id="btnBrowseCons" value="..." onclick="SearchData('consignee')" />
            </td>
            <td>
                ชื่อสถานที่วางบิล<br />
                <input type="text" id="txtConsignName" style="width:300px" disabled />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                ผู้ติดต่อ<br />
                <input type="text" id="txtContactPerson" style="width:200px" />
            </td>
            <td>
                <br />
                <input type="button" id="btnBrowseContact" value="..." onclick="SearchData('contact')" />
            </td>
            <td>
                ใบเสนอราคาเลขที่้<br />
                <input type="text" style="width:150px" id="txtQNo" />
                <input type="text" style="width:50px" id="txtRevise" />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                Customer Invoice<br />
                <input type="text" id="txtCustInv" style="width:230px" />
            </td>
            <td>
                Customer PO No<br />
                <input type="text" style="width:230px" id="txtCustPO" />
            </td>
        </tr>
        <tr>
            <td>
                HAWB or H B/L <br />
                <input type="text" id="txtHAWB" style="width:230px" />
            </td>
            <td>
                MAWB or M B/L<br />
                <input type="text" style="width:230px" id="txtMAWB" />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                Copy ข้อมูลจาก Job<br />
                <input type="text" id="txtCopyFromJob" style="width:200px" disabled />
                <input type="button" id="btnBrowseJob" value="..." onclick="SearchData('job')" disabled />
            </td>
            <td>
                วันที่เปิดงาน<br />
                <input type="date" style="width:200px" id="txtJobDate" />
            </td>
        </tr>
        <tr>
            <td>
                <input id="chkTransferCost" type="checkbox" disabled />
                โอนข้อมูลค่าบริการและค่าใช้จ่ายมาด้วย
            </td>
            <td>
                <button class="btn btn-success" id="btnCreateJob" onclick="CreateJob()">สร้างหมายเลขงานใหม่</button>
            </td>
        </tr>
    </table>
</div>
<div id="frmShowJob" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Save Complete!
            </div>
            <div class="modal-body">
                <input id="txtJNo" type="text" disabled />
                <button class="btn btn-primary" id="btnViewJob" onclick="OpenJob()">VIEW JOB</button>
                <div id="dvResp"></div>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>
<div id="frmSearchBranch" class="modal fade" role="dialog"></div>
<div id="frmSearchUser" class="modal fade" role="dialog"></div>
<div id="frmSearchCust" class="modal fade" role="dialog"></div>
<div id="frmSearchCons" class="modal fade" role="dialog"></div>
<div id="frmSearchContact" class="modal fade" role="dialog"></div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    //define variables
    var path = '@Url.Content("~")';
    $(document).ready(function () {
        SetLOVs();
        SetEvents();
    });
    function SetEvents() {
        $('#txtBranchCode').keydown(function (event) {
            if (event.which == 13) {
                ShowBranch($('#txtBranchCode').val());
            }
        });
        $('#txtCSCode').keydown(function (event) {
            if (event.which == 13) {
                ShowUser($('#txtCSCode').val(), '#txtCSName');
            }
        });
        $('#txtCustBranch').keydown(function (event) {
            if (event.which == 13) {
                ShowCustomer($('#txtCustCode').val(), $('#txtCustBranch').val(), false);
            }
        });
        $('#txtConsignee').keydown(function (event) {
            if (event.which == 13) {
                ShowCustomer($('#txtConsignee').val(), $('#txtCustBranch').val(), true);
            }
        });
    }
    function SetLOVs() {
        //read query string parameters
        var br = getQueryString('Branch');
        var jt = getQueryString('JType');
        var sb = getQueryString('SBy');
        if (br != null) {
            $('#txtBranchCode').val(br);
            ShowBranch($('#txtBranchCode').val());
        }
        if (jt == null) jt = "01"
        if (sb == null) sb = "01"
        //Combos
        loadConfig('#cboJobType', 'JOB_TYPE', path, jt);
        loadConfig('#cboShipBy', 'SHIP_BY', path, sb);
        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            //Customers
            var ListCust = response.replace('tbX', 'tbCust').replace('cpX', 'Customers');
            $('#frmSearchCust').html(ListCust);
            $('#frmSearchCust').on('shown.bs.modal', function () {
                $('#tbCust_filter input').focus();
            });
            //Consignee
            var ListCons = response.replace('tbX', 'tbCons').replace('cpX', 'Consignees');
            $('#frmSearchCons').html(ListCons);
            $('#frmSearchCons').on('shown.bs.modal', function () {
                $('#tbCons_filter input').focus();
            });
        });
        //2 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,name', function (response) {
            //Users
            var ListUser = response.replace('tbX', 'tbUser').replace('cpX', 'Users');
            $('#frmSearchUser').html(ListUser);
            $('#frmSearchUser').on('shown.bs.modal', function () {
                $('#tbUser_filter input').focus();
            });
            //Branch
            var ListBranch = response.replace('tbX', 'tbBranch').replace('cpX', 'Branch');
            $('#frmSearchBranch').html(ListBranch);
            $('#frmSearchBranch').on('shown.bs.modal', function () {
                $('#tbBranch_filter input').focus();
            });
        });
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=name', function (response) {
            //Contact Name
            var ListContact = response.replace('tbX', 'tbContact').replace('cpX', 'Contact Name');
            $('#frmSearchContact').html(ListContact);
            $('#frmSearchContact').on('shown.bs.modal', function () {
                $('#tbContact_filter input').focus();
            });
        });
    }
    function SearchData(type) {
        switch (type) {
            case 'branch':
                $('#tbBranch').DataTable({
                    ajax: {
                        url: path + 'Config/GetBranch', //web service ที่จะ call ไปดึงข้อมูลมา
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
                $('#tbBranch tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbBranch', this);
                    $('#txtBranchCode').val(dt.Code);
                    $('#txtBranchName').val(dt.BrName);
                    $('#frmSearchBranch').modal('hide');
                });
                $('#tbBranch tbody').on('click', 'tr', function () {
                    $('#tbBranch tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchBranch').modal('show');
                break;
            case 'user':
                $('#tbUser').DataTable({
                    ajax: {
                        url: path + 'Master/GetUser', //web service ที่จะ call ไปดึงข้อมูลมา
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
                $('#tbUser tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbUser', this);
                    $('#txtCSCode').val(dt.UserID);
                    $('#txtCSName').val(dt.TName);
                    $('#frmSearchUser').modal('hide');
                });
                $('#tbUser tbody').on('click', 'tr', function () {
                    $('#tbUser tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchUser').modal('show');
                break;
            case 'customer':
                //popup for search data
                $('#tbCust').DataTable({
                    ajax: {
                        url: path + 'Master/GetCompany', //web service ที่จะ call ไปดึงข้อมูลมา
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
                $('#tbCust tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbCust', this);
                    $('#txtCustCode').val(dt.CustCode);
                    $('#txtCustBranch').val(dt.Branch);
                    ShowCustomer(dt.CustCode, dt.Branch, false);
                    $('#frmSearchCust').modal('hide');
                });
                $('#tbCust tbody').on('click', 'tr', function () {
                    $('#tbCust tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchCust').modal('show');
                break;
            case 'consignee':
                //popup for search data
                $('#tbCons').DataTable({
                    ajax: {
                        url: path + 'Master/GetCompany', //web service ที่จะ call ไปดึงข้อมูลมา
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
                $('#tbCons tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbCons', this);
                    $('#txtConsignee').val(dt.CustCode);
                    $('#txtConsBranch').val(dt.Branch);
                    ShowCustomer(dt.CustCode, dt.Branch, true);
                    $('#frmSearchCons').modal('hide');
                });
                $('#tbCons tbody').on('click', 'tr', function () {
                    $('#tbCons tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchCons').modal('show');
                break;
            case 'contact':
                //popup for search data
                $.get(path + 'joborder/getjobdatadistinct?field=CustContactName')
                    .done(function (r) {
                        var dr = r[0].Table;
                        if (dr.length > 0) {
                            $('#tbContact').DataTable({
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
                            $('#tbContact tbody').on('click', 'button', function () {
                                var dt = GetSelect('#tbContact', this);
                                $('#txtContactPerson').val(dt.val);
                                $('#frmSearchContact').modal('hide');
                            });
                            $('#tbContact tbody').on('click', 'tr', function () {
                                $('#tbContact tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                                $(this).addClass('selected'); //select row ใหม่
                            });
                            $('#frmSearchContact').modal('show');
                        }
                    });
                break;
        }
    }
    function ShowCustomer(Code, Branch, isCons) {
        if ((Code + Branch).length > 0) {
            if (isCons == true) {
                $('#txtConsignName').val('');
            }
            if (isCons == false) {
                $('#txtCustName').val('');
            }
            $.get(path + 'Master/GetCompany?Code=' + Code + '&Branch=' + Branch)
                .done(function (r) {
                    if (r.company.data.length > 0) {
                        var c = r.company.data[0];
                        if (isCons == true) {
                            $('#txtConsignName').val(c.NameThai);
                        }
                        if (isCons == false) {
                            $('#txtCustName').val(c.NameThai);
                        }
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
    function ShowBranch(Branch) {
        $('#txtBranchName').val('');
        $.get(path + 'Config/GetBranch?Code=' + Branch)
            .done(function (r) {
                if (r.branch.data.length > 0) {
                    var b = r.branch.data[0];
                    $('#txtBranchName').val(b.BrName);
                }
            });
    }
    function CreateJob() {
        var strParam = path + 'JobOrder/GetNewJob?Prefix=JIDE';
        strParam += '&Branch=' + $('#txtBranchCode').val();
        strParam += '&JType=' + $('#cboJobType').val().substr(0,2);
        strParam += '&SBy=' + $('#cboShipBy').val().substr(0,2);
        $.get(strParam)
            .done(function (r) {
                if (r.length == 0) {
                    alert(strParam);
                    return;
                }
                if (r.job.status == "Y") {
                    var data = r.job.data;

                    data.CustCode = $('#txtCustCode').val();
                    data.CustBranch = $('#txtCustBranch').val();
                    data.CSCode = $('#txtCSCode').val();
                    data.DocDate = CDateTH($('#txtJobDate').val());
                    data.consigneecode = $('#txtConsignee').val();
                    data.CustContactName = $('#txtContactPerson').val();
                    data.QNo = $('#txtQNo').val();
                    data.Revise = $('#txtRevise').val();
                    data.InvNo = $('#txtCustInv').val();
                    data.CustRefNO = $('#txtCustPO').val();
                    data.HAWB = $('#txtHAWB').val();
                    data.MAWB = $('#txtMAWB').val();
                    $('#txtJNo').val(data.JNo);
                    PostData(data);
                } else {
                    alert(r.job.result);
                }
                //alert(r.job.result + '=>' + data.JNo);
            });
    }
    function PostData(obj) {
        var jsonString = JSON.stringify({ data: obj });
        //alert(jsonString);
        $.ajax({
            url: "@Url.Action("SaveJobData", "JobOrder")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {                
                //alert(response);
                $('#dvResp').html(response);
                $('#frmShowJob').modal('show');
            }
        });
    }
    function OpenJob() {
        window.open('ShowJob?BranchCode=' + $('#txtBranchCode').val() + '&JNo=' + $('#txtJNo').val());
    }

</script>

