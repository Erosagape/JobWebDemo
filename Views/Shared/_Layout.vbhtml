<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="~/Content/Site.css" />
    <link rel="stylesheet" href="~/Content/bootstrap.min.css">
    <link rel="stylesheet" href="~/Content/bootstrap-select.min.css">
    <link rel="stylesheet" href="~/Content/jquery.datatables.min.css">
    <link rel="stylesheet" href="~/Content/responsive.dataTables.min.css">
    <script src="~/Scripts/jquery-3.3.1.min.js"></script>
    <script src="~/Scripts/DataTables/jquery.dataTables.min.js"></script>
    <script src="~/Scripts/DataTables/dataTables.responsive.min.js"></script>
    <script src="~/Scripts/bootstrap.js"></script>
    <script src="~/Scripts/bootstrap-select.js"></script>
    <script src="~/Scripts/Func/util.js"></script>
    <script src="~/Scripts/Func/popup.js"></script>
    <script src="~/Scripts/Func/combo.js"></script>
    <title>@ViewBag.Title</title>
</head>
<body>
    <div Class="panel-primary">
        <div Class="panel-heading">
            <div Class="panel-title" style="display:flex">
                <div>
                    <img src="~/Resource/logo-tawan.jpg" style="width:100px" />
                </div>   
                <div style="margin-left:10px">
                    <h4>@ViewBag.Title</h4>
                </div>
            </div>
        </div>
        <div class="panel-body">
            @RenderBody()
        </div>
        <div class="panel-footer">
            <p>&copy; @DateTime.Now.Year - Tawan Technology Co.,ltd</p> 
        </div>
    </div>
</body>
</html>
