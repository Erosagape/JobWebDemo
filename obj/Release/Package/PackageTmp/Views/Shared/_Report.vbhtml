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
        <div style="display:flex">
            <div style="flex:4;padding:5px;">
                <div id="divCompany" style="text-align:left;color:darkblue;font-size:14px">
                    <b>@ViewBag.PROFILE_COMPANY_NAME</b>
                    <br />@ViewBag.PROFILE_COMPANY_ADDR1 @ViewBag.PROFILE_COMPANY_ADDR2
                    <br />Tel @ViewBag.PROFILE_COMPANY_TEL Fax @ViewBag.PROFILE_COMPANY_FAX E-mail/Website @ViewBag.PROFILE_COMPANY_EMAIL
                    <br />Tax-Reference ID : @ViewBag.PROFILE_TAXNUMBER Branch @ViewBag.PROFILE_TAXBRANCH
                </div>
            </div>
            <div style="flex:1;vertical-align:middle">
                <img id="imgLogo" src="~/Resource/@ViewBag.PROFILE_LOGO" style="width:100%" />
            </div>
        </div>
        <table id="tblHeader" width="100%">
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
