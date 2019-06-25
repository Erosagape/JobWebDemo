<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <link rel="stylesheet" type="text/css" href="~/Content/sheets-of-paper-a4.css" media="all">
    <script src="~/Scripts/jquery-3.2.1.min.js"></script>
    <script src="~/Scripts/Func/util.js"></script>
    <script src="~/Scripts/Func/reports.js"></script>
</head>
<body class="document">
    <div class="page" contenteditable="false">
        @RenderBody()
        <p style="text-align:right">Printed By : @ViewBag.User Printed Date : @DateTime.Now &copy; @DateTime.Now.Year - Tawan Technology Co.,ltd</p>
    </div>
</body>
</html>
