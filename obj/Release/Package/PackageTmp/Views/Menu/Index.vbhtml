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
        var dataVol = google.visualization.arrayToDataTable([
            ['Type', 'Volume'],
            ['IMPORT/AIR', 11],
            ['IMPORT/SEA', 2],
            ['EXPORT/AIR', 2],
            ['EXPORT/SEA', 2],
            ['DOMESTIC/TRUCK', 7]
        ]);

        var volOptions = {
            title: 'Total Jobs This Month',
            pieHole: 0.4,
        };

        var chartVol = new google.visualization.PieChart(document.getElementById('chartVol'));
        chartVol.draw(dataVol, volOptions);

        var dataStatus = google.visualization.arrayToDataTable([
        ['Type', 'Wait Confirm', 'Wait Operation', 'Wait Clear', 'Wait Bill',
         'Wait Payment', 'Completed', { role: 'annotation' } ],
        ['IMPORT', 10, 24, 20, 32, 18, 5, ''],
        ['EXPORT', 16, 22, 23, 30, 16, 9, ''],
        ['DOMESTIC', 28, 19, 29, 30, 12, 13, '']
        ]);

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

        var dataCust = google.visualization.arrayToDataTable([
            ['Status', 'Wait Confirm', 'Wait Operation', 'Wait Clear', 'Wait Bill',
                'Wait Payment', 'Completed', { role: 'annotation' }],
            ['APL', 10, 24, 20, 32, 18, 5, ''],
            ['TAWAN', 16, 22, 23, 30, 16, 9, ''],
            ['BSAT', 28, 19, 29, 30, 12, 10, ''],
            ['KGM', 20, 15, 10, 15,21, 8, ''],
        ]);

        var custOptions = {
            legend: { position: 'top', maxLines: 3 },
            isStacked: true,
        };

        var chartCust = new google.visualization.BarChart(document.getElementById('chartCust'));
        chartCust.draw(dataCust, custOptions);
    }
</script>