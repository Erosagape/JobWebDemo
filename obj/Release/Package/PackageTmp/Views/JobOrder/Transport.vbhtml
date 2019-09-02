
@Code
    ViewBag.Title = "Transport & Loading Information"
End Code
<ul class="nav nav-tabs">
    <li class="active">
        <a data-toggle="tab" href="#tabLoading">Loading Information</a>
    </li>
    <li>
        <a data-toggle="tab" href="#tabContainer">Container Information</a>
    </li>
    <li>
        <a data-toggle="tab" href="#tabTruckOrder">Vehicles Information</a>
    </li>
</ul>
<div class="tab-content">
    <div class="tab-pane fade in active" id="tabLoading">
        <div id="dvForm">
            <div class="row">
                <div class="col-sm-3">
                    Branch
                    <br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" class="form-control" id="txtBranchCode" style="width:20%" disabled />
                        <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                        <input type="text" class="form-control" id="txtBranchName" style="width:100%" disabled />
                    </div>
                </div>
                <div class="col-sm-3">
                    Job Number
                    <br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtJNo" class="form-control" style="width:100%" />
                        <input type="button" class="btn btn-default" value="..." onclick="SearchData('job');" />
                    </div>
                </div>
                <div class="col-sm-3">
                    Booking No
                    <br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtBookingNo" class="form-control" style="width:100%"/>
                        <input type="button" class="btn btn-default" value="..." onclick="SearchData('booking');" />
                    </div>
                </div>
                <div class="col-sm-3">
                    Transport Term
                    <br />
                    <div style="display:flex;flex-direction:row">
                        <select id="txtTransMode" class="form-control dropdown">
                            <option value="EXP">EX-Works</option>
                            <option value="FCA">Free Carrier</option>
                            <option value="FAS">Free Alongside Ship</option>
                            <option value="FOB">Free On Board</option>
                            <option value="CPT">Carriage Paid To</option>
                            <option value="CFR">Cost and Freight</option>
                            <option value="CIF">Carriage Paid To</option>
                            <option value="CIP">Carriage and Insurance Paid</option>
                            <option value="DAT">Delivered at Terminal</option>
                            <option value="DAP">Delivered at Place</option>
                            <option value="DDP">Delivered Duty Paid</option>
                        </select>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    Notify Party :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtNotifyCode" class="form-control" style="width:20%" />
                        <button id="btnBrowseCust" class="btn btn-default" onclick="SearchData('customer')">...</button>
                        <input type="text" id="txtNotifyName" class="form-control" style="width:100%" disabled />
                    </div>
                </div>
                <div class="col-sm-6">
                    Vender Code :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtVenderCode" class="form-control" style="width:20%">
                        <button id="btnBrowseCust" class="btn btn-default" onclick="SearchData('vender')">...</button>
                        <input type="text" id="txtVenderName" class="form-control" style="width:100%" disabled />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-3">
                    Load Date :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="date" id="txtLoadDate" class="form-control">
                    </div>
                </div>
                <div class="col-sm-3">
                    Contact Name :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtContactName" class="form-control">
                    </div>
                </div>
                <div class="col-sm-6">
                    Remark :<br />
                    <div style="display:flex;flex-direction:row">
                        <textarea id="txtRemark" class="form-control"></textarea>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    CY Place :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtCYPlace" class="form-control">
                    </div>
                </div>
                <div class="col-sm-3">
                    At CY Date :<br />
                    <div style="display:flex;flex-direction:row"><input type="date" id="txtCYDate" class="form-control"></div>
                </div>
                <div class="col-sm-3">
                    At CY Time :<br />
                    <div style="display:flex;flex-direction:row"><input type="text" id="txtCYTime" class="form-control"></div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    Factory Place :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtFactoryPlace" class="form-control">
                    </div>
                </div>
                <div class="col-sm-3">
                    At Factory Date :<br />
                    <div style="display:flex;flex-direction:row"><input type="date" id="txtFactoryDate" class="form-control"></div>
                </div>
                <div class="col-sm-3">
                    At Factory Time :<br />
                    <div style="display:flex;flex-direction:row"><input type="text" id="txtFactoryTime" class="form-control"></div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    Packing Place :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtPackingPlace" class="form-control">
                    </div>
                </div>
                <div class="col-sm-3">
                    Packing Date :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="date" id="txtPackingDate" class="form-control">
                    </div>
                </div>
                <div class="col-sm-3">
                    Packing Time :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtPackingTime" class="form-control">
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    Return Place :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtReturnPlace" class="form-control">
                    </div>
                </div>
                <div class="col-sm-3">
                    Return Date :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="date" id="txtReturnDate" class="form-control">
                    </div>
                </div>
                <div class="col-sm-3">
                    Return Time :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtReturnTime" class="form-control">
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    Payment Condition :<br /><div style="display:flex;flex-direction:row"><input type="text" id="txtPaymentCondition" class="form-control"></div>
                </div>
                <div class="col-sm-6">
                    Payment By :<br /><div style="display:flex;flex-direction:row"><input type="text" id="txtPaymentBy" class="form-control"></div>
                </div>
            </div>
        </div>
    </div>
    <div class="tab-pane fade" id="tabContainer">

    </div>
    <div class="tab-pane fade" id="tabTruckOrder">

    </div>
</div>
<div id="dvLOVs"></div>
<script type="text/javascript">
    //define letiables
    const path = '@Url.Content("~")';
    const user = '@ViewBag.User';
    const userRights = '@ViewBag.UserRights';
    SetLOVs();
    SetEvents();
    function SetEvents() {
        let branch = getQueryString("BranchCode");
        let job = getQueryString("JNo");
        if (branch !== '') {
            $('#txtBranchCode').val(branch);
            ShowBranch(path, branch, '#txtBranchName');
        } else {
            $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
            $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');
        }
        if (job !== '') {
            $('#txtJNo').val(job);
        }
    }
    function SetLOVs() {
        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name,desc1,desc2', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv,'#frmSearchCust', '#tbCust','Customers',response,3);
            //Agent
            CreateLOV(dv, '#frmSearchVend', '#tbVend', 'Venders', response, 2);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
            //Job
            CreateLOV(dv, '#frmSearchJob', '#tbJob', 'Job', response, 3);
            //Booking
            CreateLOV(dv, '#frmSearchBook', '#tbBook', 'Booking', response, 3);
        });
    }
    function SetGridBooking() {

    }
    function SearchData(type) {
        switch (type) {
            case 'vender':
                SetGridVender(path, '#tbVend', '#frmSearchVend', ReadVender);
                break;
            case 'customer':
                SetGridCompanyByGroup(path, '#tbCust', 'NOTIFY_PARTY', '#frmSearchCust', ReadCustomer);
                break;
            case 'branch':
                SetGridBranch(path, '#tbBranch','#frmSearchBranch', ReadBranch);
                break;
            case 'job':
                SetGridJob(path, '#tbJob', '#frmSearchJob', '?branch=' + $('#txtBranchCode').val(), ReadJob);
                break;
            case 'booking':
                SetGridBooking();
                break;
        }
    }
    function ReadVender(dt) {
        $('#txtVenderCode').val(dt.VenCode);
        $('#txtVenderName').val(dt.TName);
    }
    function ReadCustomer(dt) {
        $('#txtNotifyCode').val(dt.CustCode);
        ShowCustomer(path, dt.CustCode, dt.Branch, '#txtNotifyName');
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
    }
    function ReadJob(dt) {
        $('#txtJNo').val(dt.JNo);
    }
    function ReadBooking(dt) {

    }
</script>