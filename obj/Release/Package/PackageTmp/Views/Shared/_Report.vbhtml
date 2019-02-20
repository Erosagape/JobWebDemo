<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>@ViewBag.Title</title>
    <link rel="stylesheet" type="text/css" href="~/Content/sheets-of-paper-a4.css">
    <script src="~/Scripts/jquery-3.2.1.min.js"></script>
    <script src="~/Scripts/Func/util.js"></script>
    <script src="~/Scripts/Func/reports.js"></script>
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
                    <h3>@ViewBag.ReportName</h3>
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
