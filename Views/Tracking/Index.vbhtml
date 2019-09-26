
@Code
    ViewBag.Title = "Transport Tracking"
End Code
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
        Customer:
        <br />
        <div style="display:flex;flex-direction:row">
            <input type="text" class="form-control" id="txtCustCode" style="width:20%" disabled />
            <input type="text" class="form-control" id="txtCustBranch" style="width:10%" disabled />
            <input type="button" class="btn btn-default" value="..." onclick="SearchData('customer');" />
            <input type="text" class="form-control" id="txtCustName" style="width:60%" disabled />
        </div>
    </div>
</div>
<a href="#" class="btn btn-primary" id="btnShow" onclick="RefreshGrid()">
    <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Show</b>
</a>
<div class="row">
    <div class="col-md-12">
        <b>Job Clearance By Later/Coming 3 Days</b>
        <div id="chartTimeLine"></div>
    </div>
</div>
<b>Transport Tracking</b>
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
<div id="dvLOVs"></div>
<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
<script type="text/javascript">
    let path = '@Url.Content("~")';

    google.charts.load("current", { packages: ["corechart"] });
    SetLOVs();
    window.onresize = () => {
        drawChart();
    }
    function getDataTable(dt) {
        if (dt.length > 0) {
            return dt;
        }
        dt = [["JobDay", "Volume"], ["ALL", 0]];
        return dt;
    }
    function drawChart() {
        let w = '?Branch='+ $('#txtBranchCode').val();
        if ($('#txtCustCode').val() !== '') {
            w += '&Cust=' + $('#txtCustCode').val();
        }
        $.get(path + 'JobOrder/GetTimelineReport' + w).done(function (r) {
            var dt = getDataTable(r.tracking.data);
            var data = new google.visualization.DataTable();
            let rows = [];
            let cols = dt[0];
            for (let i = 0; i < cols.length; i++){
                if (cols[i] == 'JobDay') {
                    data.addColumn('string', 'Date');
                } else {
                    data.addColumn('number', cols[i]);
                }
            }
            for (let i = 1; i < dt.length; i++) {
                rows.push(dt[i]);
            }
            data.addRows(rows);
            var options = {
                chart: {
                    title: 'Total Shipment By Duty Date',
                    subtitle: 'in past 7 and next 7 days',
                    chartArea: { width: '50%' }
                }
            };
            var chart = new google.visualization.LineChart(document.getElementById('chartTimeLine'));
            chart.draw(data, options);
        });
    }
    function SetLOVs() {
        $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response,4);
        });
    }
    function SearchData(type) {
        switch (type) {
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'customer':
                SetGridCompany(path, '#tbCust', '#frmSearchCust', ReadCustomer);
                break;
        }
    }
    function RefreshGrid() {
        let branch = $('#txtBranchCode').val();
        let cust = $('#txtCustCode').val();
        let w = '';
        if (cust !== '') {
            w += '&Cust=' + cust;
        }
        $('#tbDetail').DataTable({
            ajax: {
                url: '/joborder/gettransportreport?Branch=' + branch + w, //web service ที่จะ call ไปดึงข้อมูลมา
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

        drawChart();
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
    }
</script>
