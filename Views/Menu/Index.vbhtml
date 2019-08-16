@Code
    ViewBag.Title = "Main Dashboard"
End Code
<div class="row">
    <div class="col-md-6">
        Volume By Status:
        <div id="chartVol"></div>
    </div>
    <div class="col-md-6">
        Volume By Month:
        <div id="chartStatus"></div>
    </div>
</div>
<br/>
<div class="row">
    <div class="col-md-12">
        Volume By Customer:
        <div id="chartCust"></div>
    </div>
</div>
<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
<script type="text/javascript">
    var path = '/';
    google.charts.load("current", { packages: ["corechart"] });
    google.charts.setOnLoadCallback(drawChart);

    window.onresize = () => {
        drawChart();
    }
    function drawChart() {
        $.get(path + 'JobOrder/GetDashBoard', function (r) {
            if (r.result.length > 0) {
                var rowsVol = r.result[0].data1;
                var dataVol = new google.visualization.DataTable();

                dataVol.addColumn('string', 'Type');
                dataVol.addColumn('number', 'Volume');

                var rows = [];
                for (let row of rowsVol) {
                    rows.push([row.JobStatusName, row.TotalJob]);
                }
                dataVol.addRows(rows);

                var volOptions = {
                    title: 'Total Job By Status',
                    pieHole: 0.4,
                };

                var chartVol = new google.visualization.PieChart(document.getElementById('chartVol'));
                chartVol.draw(dataVol, volOptions);

                var rowsStatus = Object.values(r.result[0].data2);
                var dataStatus = new google.visualization.DataTable();

                let i = 0;
                let cols = [];
                for (let col of Object.keys(r.result[0].data2[0])) {
                    if (i == 10) {
                        dataStatus.addColumn('string', col);
                    } else {
                        dataStatus.addColumn('number', col);
                    }
                    cols.push(col);
                    i += 1;
                }

                rows = [];
                for (let row of rowsStatus) {
                    let dr = [];
                    for (let col of cols) {
                        dr.push(row[col]);
                    }           
                    rows.push(dr);
                }
                dataStatus.addRows(rows);

                var statusOptions = {
                    legend: { position: 'top', maxLines: 3 },
                    isStacked: 'percent',
                    hAxis: {
                        minValue: 0,
                        ticks: [0, .25, .5, .75, 1]
                    }
                };

                var chartStatus = new google.visualization.ColumnChart(document.getElementById('chartStatus'));
                chartStatus.draw(dataStatus, statusOptions);

                var rowsCust = Object.values(r.result[0].data3);
                var dataCust = new google.visualization.DataTable();

                i = 0;
                cols = [];
                for (let col of Object.keys(r.result[0].data3[0])) {
                    if (i == 0) {
                        dataCust.addColumn('string', col);
                    } else {
                        dataCust.addColumn('number', col);
                    }
                    cols.push(col);
                    i += 1;
                }

                rows = [];
                for (let row of rowsCust) {
                    let dr = [];
                    for (let col of cols) {
                        dr.push(row[col]);
                    }           
                    rows.push(dr);
                }
                dataCust.addRows(rows);

                var custOptions = {
                    legend: { position: 'top', maxLines: 3 },
                    isStacked: true,
                };

                var chartCust = new google.visualization.BarChart(document.getElementById('chartCust'));
                chartCust.draw(dataCust, custOptions);

            }
        });


    }
</script>