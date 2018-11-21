<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="~/Content/bootstrap.min.css">
    <link rel="stylesheet" href="~/Content/bootstrap-select.min.css">
    <link rel="stylesheet" href="~/Content/jquery.datatables.min.css">
    <script src="~/Scripts/jquery-3.3.1.min.js"></script>
    <script src="~/Scripts/DataTables/jquery.dataTables.min.js"></script>
    <script src="~/Scripts/bootstrap.js"></script>
    <script src="~/Scripts/bootstrap-select.js"></script>
    <script src="~/Scripts/Func/Util.js"></script>
    <script src="~/Scripts/Func/popup.js"></script>
    <title>@ViewBag.Title</title>
    <script type="text/javascript">
        function BackToMenu() {
            var c = confirm('Do you want to back to main menu?');
            if (c == true) {
                window.location.href = 'Menu/Index';
            }
        }
    </script>
</head>
<body>
    <div Class="panel-primary">
        <div Class="panel-heading">
            <div Class="panel-title">
                <table width="100%">
                    <tr>
                        <td>
                            <h5>@ViewBag.Title (@ViewBag.User)</h5>
                        </td>
                        <td align="right">
                            <img src="~/Resource/logo-tawan.jpg" style="width:100px" onclick="BackToMenu();" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        @RenderBody()
        <div class="panel-footer">
            <p>&copy; @DateTime.Now.Year - Tawan Technology Co.,ltd</p>
        </div>
    </div>
</body>
</html>
