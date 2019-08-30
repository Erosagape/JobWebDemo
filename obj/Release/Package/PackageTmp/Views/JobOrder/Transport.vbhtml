
@Code
    ViewBag.Title = "Transport & Loading Information"
End Code
<ul class="nav nav-tabs">
    <li class="active">
        <a data-toggle="tab" id="tabHeader">Loading Information</a>
        <a data-toggle="tab" id="tabContainer">Container Information</a>
        <a data-toggle="tab" id="tabTruckOrder">Vehicles Information</a>
    </li>
</ul>
<div class="tab-content">
    <div class="tab-pane fade in active">
        <div id="dvForm">
            <div class="row">
                <div class="col-sm-3">
                    Branch <br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" class="form-control" id="txtBranchCode" style="width:15%" disabled />
                        <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                        <input type="text" class="form-control" id="txtBranchName" style="width:65%" disabled />
                    </div>
                </div>
                <div class="col-sm-3">
                    Job Number<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtJNo" class="form-control" />
                    </div>
                </div>
                <div class="col-sm-3">
                    Booking No<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtBookingNo" class="form-control" />
                    </div>
                </div>
                <div class="col-sm-3">
                    Transport Mode<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtTransMode" class="form-control">
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    Notify Party :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtNotifyCode" class="form-control" style="width:130px" />
                        <button id="btnBrowseCust" class="btn btn-default" onclick="SearchData('customer')">...</button>
                        <input type="text" id="txtNotifyName" class="form-control" style="width:100%" disabled />
                    </div>
                </div>
                <div class="col-sm-6">
                    Vender Code :<br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtVenderCode" class="form-control">
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
    <div class="tab-pane fade">

    </div>
    <div class="tab-pane fade">

    </div>
</div>