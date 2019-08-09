﻿@Code
    ViewBag.Title = "Main Page"
End Code
<!--Div that will hold the dashboard-->
<div id="programmatic_dashboard_div" style="border: 1px solid #ccc">
    <table class="columns">
        <tr>
            <td>
                <div id="programmatic_control_div" style="padding-left: 2em; min-width: 250px"></div>
                <div>
                    <button style="margin: 1em 1em 1em 2em" onclick="changeRange();">
                        Select range [2, 5]
                    </button><br />
                    <button style="margin: 1em 1em 1em 2em" onclick="changeOptions();">
                        Make the pie chart 3D
                    </button>
                </div>
                <script type="text/javascript">

                </script>
            </td>
            <td>
                <div id="programmatic_chart_div"></div>
            </td>
        </tr>
    </table>
</div>
<!--Load the AJAX API-->
<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    google.charts.load('current', { 'packages': ['corechart', 'controls'] });
    google.charts.setOnLoadCallback(drawStuff);

    function drawStuff() {

        var dashboard = new google.visualization.Dashboard(
            document.getElementById('programmatic_dashboard_div'));

        // We omit "var" so that programmaticSlider is visible to changeRange.
        var programmaticSlider = new google.visualization.ControlWrapper({
            'controlType': 'NumberRangeFilter',
            'containerId': 'programmatic_control_div',
            'options': {
                'filterColumnLabel': 'Donuts eaten',
                'ui': { 'labelStacking': 'vertical' }
            }
        });

        var programmaticChart = new google.visualization.ChartWrapper({
            'chartType': 'PieChart',
            'containerId': 'programmatic_chart_div',
            'options': {
                'width': 300,
                'height': 300,
                'legend': 'none',
                'chartArea': { 'left': 15, 'top': 15, 'right': 0, 'bottom': 0 },
                'pieSliceText': 'value'
            }
        });

        var data = google.visualization.arrayToDataTable([
            ['Name', 'Donuts eaten'],
            ['Michael', 5],
            ['Elisa', 7],
            ['Robert', 3],
            ['John', 2],
            ['Jessica', 6],
            ['Aaron', 1],
            ['Margareth', 8]
        ]);

        dashboard.bind(programmaticSlider, programmaticChart);
        dashboard.draw(data);

        changeRange = function () {
            programmaticSlider.setState({ 'lowValue': 2, 'highValue': 5 });
            programmaticSlider.draw();
        };

        changeOptions = function () {
            programmaticChart.setOption('is3D', true);
            programmaticChart.draw();
        };
    }
    function changeRange() {
        programmaticSlider.setState({ 'lowValue': 2, 'highValue': 5 });
        programmaticSlider.draw();
    }

    function changeOptions() {
        programmaticChart.setOption('is3D', true);
        programmaticChart.draw();
    }
</script>

