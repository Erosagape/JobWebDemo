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
                var dataVol = google.visualization.arrayToDataTable(r.result[0].data1);

                var volOptions = {
                    title: 'Total Job By Status',
                    pieHole: 0.4,
                };

                var chartVol = new google.visualization.PieChart(document.getElementById('chartVol'));
                chartVol.draw(dataVol, volOptions);

                var dataStatus = google.visualization.arrayToDataTable(r.result[0].data2);

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

                var dataCust = google.visualization.arrayToDataTable(r.result[0].data3);

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