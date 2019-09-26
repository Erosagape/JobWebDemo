@Code
    ViewBag.Title = "Main Dashboard"
End Code
Job Type : <select id="cboJobType" onchange="drawChart()"></select>
Transport By : <select id="cboShipBy" onchange="drawChart()"></select>
Last Update : <label id="lblLastUpdate">@DateTime.Now().ToString("dd/MM/yyyy HH:mm:ss")</label>
<div class="row">
    <div class="col-md-6">
        <b>Volume By Status:</b>
        <div id="chartVol"></div>
    </div>
    <div class="col-md-6">
        <b>Status By Shipment Type:</b>
        <div id="chartStatus"></div>
    </div>
</div>
<br />
<div class="row">
    <div class="col-md-12">
        <b>Status By Customer:</b>
        <div id="chartCust"></div>
    </div>
</div>
<script type="text/javascript" src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    window.onload = function () {
        loadCombos(path, 'SHIP_BY=#cboShipBy,JOB_TYPE=#cboJobType');
    }
    google.charts.load("current", { packages: ["corechart"] });
    google.charts.setOnLoadCallback(drawChart);

    window.onresize = () => {
        drawChart();
    }
    setInterval(function () {
        drawChart();
    }, 30000);
    function drawChart() {
        let w = '';
        if ($('#cboJobType').val() > '') {
            if (w == '') w += '?';
            w += 'JobType=' + $('#cboJobType').val();
        }
        if ($('#cboShipBy').val() > '') {
            w += (w !== '' ? '&' : '?');
            w += 'ShipBy=' + $('#cboShipBy').val();
        }
        ShowWait();
        $.get(path + 'JobOrder/GetDashBoard' + w, function (r) {
            if (r.result.length > 0) {
                var dataVol = google.visualization.arrayToDataTable(getDataTable(r.result[0].data1));
                var volOptions = {
                    title: 'Total Job By Status',
                    pieHole: 0.4,
                };
                var chartVol = new google.visualization.PieChart(document.getElementById('chartVol'));
                chartVol.draw(dataVol, volOptions);

                var statusView = getDataView(r.result[0].data2);
                var statusOptions = {
                    legend: { position: 'top', maxLines: 3 },
                    isStacked: 'percent',
                    hAxis: {
                        minValue: 0,
                        ticks: [0, .25, .5, .75, 1]
                    }
                };
                var chartStatus = new google.visualization.ColumnChart(document.getElementById('chartStatus'));
                chartStatus.draw(statusView, statusOptions);

                var custView = getDataView(r.result[0].data3);
                var custOptions = {
                    legend: { position: 'top', maxLines: 3 },
                    isStacked: 'percent',
                    hAxis: {
                        minValue: 0,
                        ticks: [0, .3, .6, .9, 1]
                    }
                };
                var chartCust = new google.visualization.BarChart(document.getElementById('chartCust'));
                chartCust.draw(custView, custOptions);

            }
            CloseWait();
            $('#lblLastUpdate').text(new Date().toTimeString());
        });
    }
    function getDataTable(dt) {
        if (dt.length > 0) {
            return dt;
        }
        dt = [["Status", "Volume"], ["ALL", 0]];
        return dt;
    }
    function getDataView(tb) {
        let dt = getDataTable(tb);
        let totalColumns = dt[0].length - 1;
        let data = google.visualization.arrayToDataTable(dt);
        let view = new google.visualization.DataView(data);
        let columns = [];
        for (let i = 0; i <= totalColumns; i++) {
            if (i > 0) {
                columns.push(i);
                columns.push({
                    calc: function (dataTable, rowIndex) {
                        return getAnnotation(dataTable, rowIndex, i);
                    },
                    type: "string",
                    role: "annotation"
                });
            } else {
                columns.push(i);
            }
        }
        view.setColumns(columns);
        return view;
    }
    function getAnnotation(dataTable, rowIndex, columnIndex) {
        return dataTable.getFormattedValue(rowIndex, columnIndex) == "0" ? null : dataTable.getFormattedValue(rowIndex, columnIndex);
    }
</script>