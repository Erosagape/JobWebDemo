@Code
    ViewBag.Title = "Tracking Status"
    Layout = Nothing
End Code
<div style="display:flex;flex-direction:column;margin-bottom:100px;">
    <div class="w3-container" style="margin-bottom:10px">
        <!-- Page Content -->
        <div Class="panel-primary">
            <div Class="panel-heading w3-indigo">
                <div Class="panel-title" style="display:flex">
                    <div>
                        <img src="~/Resource/logo-tawan.jpg" style="width:100px" onclick="w3_open();" />
                    </div>
                    <div style="margin-left:10px">
                        <h4><label id="lblTitle">@ViewBag.Title</label></h4>
                    </div>
                </div>
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-sm-4">
                        Branch
                        <br />
                        <div style="display:flex;flex-direction:row">
                            <input type="text" class="form-control" id="txtBranchCode" style="width:15%" disabled />
                            <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                            <input type="text" class="form-control" id="txtBranchName" style="width:65%" disabled />
                        </div>
                    </div>
                    <div class="col-sm-6">
                        Customer Tax-ID:
                        <br />
                        <div style="display:flex;flex-direction:row">
                            <input type="text" class="form-control" id="txtTaxNumber" style="width:30%" />
                            <input type="text" class="form-control" id="txtCustName" style="width:70%" disabled />
                        </div>
                    </div>
                </div>
                <a href="#" class="btn btn-primary" id="btnShow" onclick="RefreshGrid()">
                    <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Show</b>
                </a>
                <table id="tbDetail" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>CTN_NO</th>
                            <th class="desktop">InvNo</th>
                            <th class="desktop">DeclareNumber</th>
                            <th class="all">TruckNO</th>
                            <th class="desktop">Location</th>
                            <th class="desktop">ProductDesc</th>
                            <th class="desktop">ProductQty</th>
                            <th class="desktop">LoadDate</th>
                            <th class="desktop">FactoryDate</th>
                            <th class="all">UnloadFinishDate</th>
                            <th class="desktop">Comment</th>
                            <th class="desktop">DeliveryNo</th>
                        </tr>
                    </thead>
                    <tbody></tbody>
                </table>
            </div>
        </div>
    </div>
</div>
<div id="dvLOVs"></div>
<script type="text/javascript">
    let path = '/';
    SetLOVs();
    $('#txtTaxNumber').focusout(function () {
        ShowCompanyByTax(path, $('#txtTaxNumber').val(), '#txtCustName');
    });
    function SetLOVs() {
        $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');
    }
    function SearchData(type) {
        switch (type) {
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
        }
    }
    function RefreshGrid() {
        let branch = $('#txtBranchCode').val();
        let taxno = $('#txtTaxNumber').val();
        $('#tbDetail').DataTable({
            ajax: {
                url: '/joborder/gettransportreport?Branch=' + branch + '&TaxNumber=' + taxno, //web service ที่จะ call ไปดึงข้อมูลมา
                dataSrc: 'transport.data'
            },
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: "CTN_NO", title: "Container No" },
                { data: "InvNo", title: "Inv.No" },
                { data: "DeclareNumber", title: "Declare No" },
                { data: "TruckNO", title: "Truck" },
                { data: "Location", title: "Delivery" },
                { data: "ProductDesc", title: "Product" },
                { data: "ProductQty", title: "Qty" },
                {
                    data: null, title: "Load Date", render: function (data) {
                        return CDateEN(data.LoadDate);
                    }
                },
                {
                    data: null, title: "Factory Date", render: function (data) {
                        return CDateEN(data.FactoryDate);
                    }
                },
                {
                    data: null, title: "Unload Date", render: function (data) {
                        return CDateEN(data.UnloadFinishDate);
                    }
                },
                { data: "Comment", title: "Remark" },
                { data: "DeliveryNo", title: "Delivery No" }
            ],
            destroy: true, //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            responsive:true
        });
        $('#tbDetail tbody').on('dblclick', 'tr', function () {
            SetSelect('#tbDetail', this);
            let row = $('#tbDetail').DataTable().row(this).data(); //read current row selected
            window.open(path + 'JobOrder/ShowJob?BranchCode=' + row.BranchCode + '&JNo=' + row.JNo,'','');
        });
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
    }
</script>