<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>@ViewBag.Title</title>
    <link rel="stylesheet" href="~/Content/bootstrap.min.css" media="all">
    <link rel="stylesheet" href="~/Content/bootstrap-select.min.css" media="all">
    <link rel="stylesheet" href="~/Content/jquery.datatables.min.css" media="all">
    <link rel="stylesheet" type="text/css" href="~/Content/sheets-of-paper-a4-landscape.css" media="all">
    <script src="~/Scripts/jquery-3.3.1.min.js"></script>
    <script src="~/Scripts/DataTables/jquery.dataTables.min.js"></script>
    <script src="~/Scripts/bootstrap.js"></script>
    <script src="~/Scripts/bootstrap-select.js"></script>
    <script src="~/Scripts/Func/Util.js"></script>
    <script src="~/Scripts/Func/popup.js"></script>
    <style>
        table,
        table tr td,
        table tr th {
            page-break-inside: avoid;
        }
    </style>
</head>
<body class="document">
    <div class="page" contenteditable="false">
        <table id="tblHeader" width="100%">
            <tr>
                <td width="20%">
                    <img id="imgLogo" src="~/Resource/@ViewBag.PROFILE_LOGO" width="60%" />
                </td>
                <td width="80%">
                    <div id="divCompany" style="text-align:left;color:darkblue;">
                        <b>@ViewBag.PROFILE_COMPANY_NAME</b>
                        <br />@ViewBag.PROFILE_COMPANY_ADDR1
                        <br />@ViewBag.PROFILE_COMPANY_ADDR2
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan="2" width="100%" style="text-align:center">
                    <h2>@ViewBag.ReportName</h2>
                </td>
            </tr>
            <tr>
                <td colspan="2" width="100%">
                    @RenderBody()
                </td>
            </tr>
            <tr>
                <td colspan="2" width="100%">
                    <p style="text-align:right">Printed By : @ViewBag.User Printed Date : @DateTime.Now &copy; @DateTime.Now.Year - Tawan Technology Co.,ltd</p>
                </td>
            </tr>
        </table>
    </div>
</body>
</html>
