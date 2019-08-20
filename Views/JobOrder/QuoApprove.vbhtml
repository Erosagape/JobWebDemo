@Code
    ViewBag.Title = "อนุมัติใบเสนอราคา"
End Code
<div class="panel-body">
    <div class="container">
        <div class="row">
            <div class="col-sm-6">
                Branch
                <br />
                <div style="display:flex;flex-direction:row">
                    <input type="text" class="form-control" id="txtBranchCode" style="width:15%" disabled />
                    <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                    <input type="text" class="form-control" id="txtBranchName" style="width:65%" disabled />
                </div>
            </div>
            <div class="col-sm-3">
                Date From:<br />
                <input type="date" class="form-control" id="txtAdvDateF" />
            </div>
            <div class="col-sm-3">
                Date To:<br />
                <input type="date" class="form-control" id="txtAdvDateT" />
            </div>            
        </div>
        <div class="row">
            <div class="col-sm-6">
                Manager By :<br />
                <div style="display:flex;flex-direction:row">
                    <input type="text" class="form-control" id="txtReqBy" style="width:100px" />
                    <button id="btnBrowseEmp2" class="btn btn-default" onclick="SearchData('reqby')">...</button>
                    <input type="text" id="txtReqName" class="form-control" style="width:100%" disabled />
                </div>
            </div>
            <div class="col-sm-6">
                Customer :<br />
                <div style="display:flex;flex-direction:row">
                    <input type="text" id="txtCustCode" class="form-control" style="width:130px" />
                    <input type="text" id="txtCustBranch" class="form-control" style="width:70px" />
                    <button id="btnBrowseCust" class="btn btn-default" onclick="SearchData('customer')">...</button>
                    <input type="text" id="txtCustName" class="form-control" style="width:100%" disabled />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-2">
                <a href="#" class="btn btn-primary" id="btnSearch" onclick="SetGridAdv(true)">
                    <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Search</b>
                </a>
            </div>
            <div class="col-sm-10">
                Approve Document : <input type="text" id="txtListApprove" class="form-control" value="" disabled />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <table id="tbHeader" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>QNo</th>
                            <th class="all">DocDate</th>
                            <th class="all">ManagerCode</th>
                            <th class="desktop">TRemark</th>
                            <th class="all">ContactName</th>
                            <th class="desktop">BillToCustCode</th>
                            <th class="desktop">ReferQNo</th>
                        </tr>
                    </thead>
                </table>
                <br />
                <a href="#" class="btn btn-success" id="btnSave" onclick="ApproveData()">
                    <i class="fa fa-lg fa-save"></i>&nbsp;<b>Approve</b>
                </a>
            </div>
        </div>
    </div>
    <div id="dvLOVs"></div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    const path = '@Url.Content("~")';
    const user = '@ViewBag.User';
    let arr = [];
    //$(document).ready(function () {
        SetEvents();
    //});
    function SetEvents() {
        //Combos
        let lists = 'JOB_TYPE=#cboJobType';
        lists += ',SHIP_BY=#cboShipBy';
        loadCombos(path, lists);
        //Events
        $('#txtBranchCode').keydown(function (event) {
            if (event.which == 13) {
                $('#txtBranchName').val('');
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            }
        });
        $('#txtReqBy').keydown(function (event) {
            if (event.which == 13) {
                $('#txtReqName').val('');
                ShowUser(path, $('#txtReqBy').val(), '#txtReqName');
            }
        });
        $('#txtCustBranch').keydown(function (event) {
            if (event.which == 13) {
                $('#txtCustName').val('');
                ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
            }
        });

        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
            CreateLOV(dv, '#frmSearchReq', '#tbReq', 'Request By', response, 2);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
        });
        $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');
    }
    function SetGridAdv(isAlert) {
        arr = [];
        ShowSummary();

        let w = '';
        if ($('#txtReqBy').val() !== "") {
            w = w + '&Sales=' + $('#txtReqBy').val();
        }
        if ($('#txtCustCode').val() !== "") {
            w = w + '&Cust=' + $('#txtCustCode').val();
        }
        if ($('#txtAdvDateF').val() !== "") {
            w = w + '&DateFrom=' + CDateEN($('#txtAdvDateF').val());
        }
        if ($('#txtAdvDateT').val() !== "") {
            w = w + '&DateTo=' + CDateEN($('#txtAdvDateT').val());
        }
        w = w + '&Show=ACTIVE&Status=0';
        $.get(path + 'joborder/getquotation?branch=' + $('#txtBranchCode').val() + w, function (r) {
            if (r.quotation.header.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                if (isAlert==true) ShowMessage('data not found');
                return;
            }
            let h = r.quotation.header;
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "QNo", title: "Quotation No" },
                    {
                        data: "DocDate", title: "Quotation date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "ManagerCode", title: "Salesman" },
                    { data: "TRemark", title: "Remark" },
                    { data: "ContactName", title: "Contact" },
                    { data: "BillToCustCode", title: "Billing To" },
                    { data: "ReferQNo", title: "Refer Q.No" }
                ],
                responsive:true,
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                if ($(this).hasClass('selected') == true) {
                    $(this).removeClass('selected');
                    let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                    RemoveData(data); //callback function from caller
                    return;
                }
                $(this).addClass('selected');
                let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                AddData(data); //callback function from caller
            });
            $('#tbHeader tbody').on('dblclick', 'tr', function () {
                let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                window.open(path + 'joborder/formquotation?Branch=' + data.BranchCode + '&DocNo=' + data.QNo,'','');
            });
        });
    }
    function AddData(o) {
        arr.push(o);
        ShowSummary();
    }
    function RemoveData(o) {
        let idx = arr.indexOf(o);
        if (idx < 0) {
            return;
        }
        arr.splice(idx, 1);
        ShowSummary();
    }
    function ShowSummary() {
        let doc = '';
        for (let i = 0; i < arr.length; i++) {
            let o = arr[i];
            doc += (doc != '' ? ',' : '') + o.QNo;
        }
        $('#txtListApprove').val(doc);
    }
    function ApproveData() {
        if (arr.length < 0) {
            ShowMessage('no data to approve');
            return;
        }
        let dataApp = [];
        dataApp.push(user);
        for (let i = 0; i < arr.length; i++) {
            dataApp.push(arr[i].BranchCode + '|' + arr[i].QNo);
        }
        let jsonString = JSON.stringify({ data: dataApp });
        $.ajax({
            url: "@Url.Action("ApproveQuotation", "JobOrder")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                SetGridAdv(false);
                response ? ShowMessage("Approve Completed!") : ShowMessage("Cannot Approve");
            },
            error: function (e) {
                ShowMessage(e);
            }
        });
        return;
    }
    function SearchData(type) {
        switch (type) {
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'reqby':
                SetGridUser(path, '#tbReq', '#frmSearchReq', ReadReqBy);
                break;
            case 'customer':
                SetGridCompany(path, '#tbCust', '#frmSearchCust', ReadCustomer);
                break;
        }
    }
    function ReadReqBy(dt) {
        $('#txtReqBy').val(dt.UserID);
        $('#txtReqName').val(dt.TName);
        $('#txtReqBy').focus();
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
    }
    function ReadCustomer(dt) {
        $('#txtCustCode').val(dt.CustCode);
        $('#txtCustBranch').val(dt.Branch);
        ShowCustomer(path, dt.CustCode, dt.Branch, '#txtCustName');
        $('#txtCustCode').focus();
    }
</script>