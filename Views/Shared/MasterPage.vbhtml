<!DOCTYPE html>
<html>
<head>
    <title>@ViewBag.Title</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="~/Content/Site.css">
    <link rel="stylesheet" href="~/Content/bootstrap.min.css">
    <link rel="stylesheet" href="~/Content/bootstrap-select.min.css">
    <link rel="stylesheet" href="~/Content/jquery.datatables.min.css">
    <link rel="stylesheet" href="~/Content/responsive.dataTables.min.css">
    <script src="~/Scripts/jquery-3.3.1.min.js"></script>
    <script src="~/Scripts/DataTables/jquery.dataTables.min.js"></script>
    <script src="~/Scripts/DataTables/dataTables.responsive.min.js"></script>
    <script src="~/Scripts/bootstrap.js"></script>
    <script src="~/Scripts/bootbox.js"></script>
    <script src="~/Scripts/bootstrap-select.js"></script>
    <script src="~/Scripts/Func/util.js"></script>
    <script src="~/Scripts/Func/popup.js"></script>
    <script src="~/Scripts/Func/combo.js"></script>
    <script src="~/Scripts/Func/menu.js"></script>
    <script src="~/Scripts/Func/lang.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
</head>
<body style="background:#e6e6e6;color:black;">
    <!-- Sidebar -->
    <div class="w3-sidebar w3-bar-block w3-animate-left" style="display:none;z-index:5" id="mySidebar">
        <div class="w3-sidebar w3-bar-block w3-indigo w3-card" style="width:250px;">
            <div style="width:100%;text-align:center;background-color:white">
                <img id="imgMenu" src="~/Resource/logo-tawan.jpg" onclick="SetLogout()" style="width:150px;padding:5px 5px 5px 5px;" />
            </div>
            <div style="width:100%;text-align:center;background-color:white;color:black">
                <a href="#" onclick="SetLogin()"><label id="lblUserID">Please Login</label></a>
                <select id="cboLanguage" onchange="ChangeLanguage($(this).val(),'@ViewBag.Module')" data-width="fit">
                    <option value="EN">EN</option>
                    <option value="TH">ไทย</option>
                </select>
            </div>
            <div id="mainMkt" class="w3-bar-item w3-button" onclick="w3_accordion('mnuMkt')">
                Marketing Works
            </div>
            <div id="mnuMkt" class="w3-hide w3-pale-green w3-card-4">
                <a href="#" id="mnuMkt1" class="w3-bar-item w3-button" onclick="OpenMenu('Quotation')">- Quotation</a>
                <a href="#" id="mnuMkt3" class="w3-bar-item w3-button" onclick="OpenMenu('EstimateCost')">- Estimate Costing</a>
            </div>
            <div id="mainCS" class="w3-bar-item w3-button" onclick="w3_accordion('mnuCS')">
                CS Works
            </div>
            <div id="mnuCS" class="w3-hide w3-light-grey w3-card-4">
                <a href="#" id="mnuCS1" class="w3-bar-item w3-button" onclick="OpenMenu('CreateJob')">- Create Job</a>
                <a href="#" id="mnuCS2" class="w3-bar-item w3-button" onclick="OpenMenu('SearchJob')">- List Job</a>
                <a href="#" id="mnuCS3" class="w3-bar-item w3-button" onclick="OpenMenu('Transport')">- Loading Info</a>
                <a href="#" id="mnuCS4" class="w3-bar-item w3-button" onclick="OpenMenu('WHTax')">- Withholding Tax</a>
            </div>
            <div id="mainShp" class="w3-bar-item w3-button" onclick="w3_accordion('mnuShp')">
                Shipping Works
            </div>
            <div id="mnuShp" class="w3-hide w3-khaki w3-card-4">
                <a href="#" id="mnuShp1" class="w3-bar-item w3-button" onclick="OpenMenu('Advance')">- Advance</a>
                <a href="#" id="mnuShp2" class="w3-bar-item w3-button" onclick="OpenMenu('Clearing')">- Clearing</a>
            </div>
            <div id="mainApp" class="w3-bar-item w3-button" onclick="w3_accordion('mnuApp')">
                Approving
            </div>
            <div id="mnuApp" class="w3-hide w3-pale-yellow w3-card-4">
                <a href="#" id="mnuApp1" class="w3-bar-item w3-button" onclick="OpenMenu('AppAdvance')">- Approve Advance</a>
                <a href="#" id="mnuApp2" class="w3-bar-item w3-button" onclick="OpenMenu('AppClearing')">- Approve Clearing</a>
                <a href="#" id="mnuMkt2" class="w3-bar-item w3-button" onclick="OpenMenu('AppQuo')">- Approve Quotation</a>
            </div>
            <div id="mainFin" class="w3-bar-item w3-button" onclick="w3_accordion('mnuFin')">
                Finance Works
            </div>
            <div id="mnuFin" class="w3-hide w3-pale-blue w3-card-4">
                <a href="#" id="mnuFin1" class="w3-bar-item w3-button" onclick="OpenMenu('PayAdvance')">- Payment Advance</a>
                <a href="#" id="mnuFin2" class="w3-bar-item w3-button" onclick="OpenMenu('Payment')">- Payment Bill</a>
                <a href="#" id="mnuFin3" class="w3-bar-item w3-button" onclick="OpenMenu('RecvClear')">- Receive Clearing</a>
                <a href="#" id="mnuFin4" class="w3-bar-item w3-button" onclick="OpenMenu('RecvInv')">- Receive Invoice</a>
                <a href="#" id="mnuFin5" class="w3-bar-item w3-button" onclick="OpenMenu('Cheque')">- Cheque Management</a>
                <a href="#" id="mnuFin6" class="w3-bar-item w3-button" onclick="OpenMenu('CreditAdv')">- Credit Advance</a>
                <a href="#" id="mnuFin7" class="w3-bar-item w3-button" onclick="OpenMenu('PettyCash')">- Petty Cash</a>
                <a href="#" id="mnuFin8" class="w3-bar-item w3-button" onclick="OpenMenu('Earnest')">- Earnest Clearing</a>
            </div>
            <div id="mainAcc" class="w3-bar-item w3-button" onclick="w3_accordion('mnuAcc')">
                Account Works
            </div>
            <div id="mnuAcc" class="w3-hide w3-pale-red w3-card-4">
                <a href="#" id="mnuAcc1" class="w3-bar-item w3-button" onclick="OpenMenu('Voucher')">- Vouchers</a>
                <a href="#" id="mnuAcc2" class="w3-bar-item w3-button" onclick="OpenMenu('Invoice')">- Invoice</a>
                <a href="#" id="mnuAcc3" class="w3-bar-item w3-button" onclick="OpenMenu('Billing')">- Billing</a>
                <a href="#" id="mnuAcc4" class="w3-bar-item w3-button" onclick="OpenMenu('Receipt')">- Receipts</a>
                <a href="#" id="mnuAcc5" class="w3-bar-item w3-button" onclick="OpenMenu('TaxInvoice')">- Tax-invoice</a>
                <a href="#" id="mnuAcc6" class="w3-bar-item w3-button" onclick="OpenMenu('Expense')">- Payments Bill</a>
                <a href="#" id="mnuAcc7" class="w3-bar-item w3-button" onclick="OpenMenu('CreditNote')">- Credit/Debit Note</a>
                <a href="#" id="mnuAcc8" class="w3-bar-item w3-button" onclick="OpenMenu('GLNote')">- Journal Entry</a>
            </div>
            <div id="mainRpt" class="w3-bar-item w3-button" onclick="w3_accordion('mnuRpt')">
                Report & Tracking
            </div>
            <div id="mnuRpt" class="w3-hide w3-amber w3-card-4">
                <a href="#" id="mnuRpt1" class="w3-bar-item w3-button" onclick="OpenMenu('Report')">- Reports</a>
                <a href="#" id="mnuRpt2" class="w3-bar-item w3-button" onclick="OpenMenu('Tracking1')">- Transport Tracking</a>
                <a href="#" id="mnuRpt4" class="w3-bar-item w3-button" onclick="OpenMenu('Tracking2')">- Customer Tracking</a>
                <a href="#" id="mnuRpt3" class="w3-bar-item w3-button" onclick="OpenMenu('Dashboard')">-Job Dashboard</a>
            </div>
            <div id="mainMas" class="w3-bar-item w3-button" onclick="w3_accordion('mnuMas')">
                Master Files
            </div>
            <div id="mnuMas" class="w3-hide w3-sand w3-card-4">
                <a href="#" id="mnuMas3" class="w3-bar-item w3-button" onclick="OpenMenu('MasS')">- System Files</a>
                <a href="#" id="mnuMas1" class="w3-bar-item w3-button" onclick="OpenMenu('MasG')">- Customs File</a>
                <a href="#" id="mnuMas2" class="w3-bar-item w3-button" onclick="OpenMenu('MasA')">- Accounts File</a>
            </div>
            <div id="mainUtil" class="w3-bar-item w3-button" onclick="w3_accordion('mnuUtil')">
                Utility
            </div>
            <div id="mnuUtil" class="w3-hide w3-sand w3-card-4">
                <a href="#" id="mnuUtil1" class="w3-bar-item w3-button" onclick="OpenMenu('Import')">- Import data</a>
                <a href="#" id="mnuUtil2" class="w3-bar-item w3-button" onclick="OpenMenu('Export')">- Export data</a>
            </div>
        </div>
    </div>
    <div class="w3-overlay w3-animate-opacity" onclick="w3_close()" style="cursor:pointer" id="myOverlay"></div>
    <div id="dvMasA" class="modal" style="width:100%">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header" style="background-color:black">
                    <div id="mainMasA" class="modal-title" style="color:white;text-align:center">
                        Account Master Files
                    </div>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-sm-6">
                            <button id="mnuMasA1" class="btn btn-default btn-block" onclick="OpenMenu('customers')">ผู้นำเข้าส่งออก</button>
                            <button id="mnuMasA2" class="btn btn-default btn-block" onclick="OpenMenu('venders')">ผู้ให้บริการ</button>
                            <button id="mnuMasA3" class="btn btn-default btn-block" onclick="OpenMenu('ServUnit')">หน่วยบริการ</button>
                            <button id="mnuMasA4" class="btn btn-default btn-block" onclick="OpenMenu('Bank')">ธนาคาร</button>
                        </div>
                        <div class="col-sm-6">
                            <button id="mnuMasA5" class="btn btn-default btn-block" onclick="OpenMenu('BookAccount')">สมุดบัญชีธนาคาร</button>
                            <button id="mnuMasA6" class="btn btn-default btn-block" onclick="OpenMenu('ServiceGroup')">กลุ่มค่าบริการ</button>
                            <button id="mnuMasA7" class="btn btn-default btn-block" onclick="OpenMenu('ServiceCode')">รหัสค่าบริการ</button>
                            <button id="mnuMasA8" class="btn btn-default btn-block" onclick="OpenMenu('BudgetPolicy')">มาตรฐานค่าบริการ</button>
                            <button id="mnuMasA9" class="btn btn-default btn-block" onclick="OpenMenu('AccountCode')">รหัสบัญชี</button>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>
    <div id="dvMasS" class="modal" style="width:100%">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header" style="background-color:black">
                    <div id="mainMasS" class="modal-title" style="color:white;text-align:center">
                        System Master Files
                    </div>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-sm-6">
                            <button id="mnuMasS1" class="btn btn-default btn-block" onclick="OpenMenu('Constant')">ค่าคงที่ระบบ</button>
                            <button id="mnuMasS2" class="btn btn-default btn-block" onclick="OpenMenu('users');">ผู้ใช้งาน</button>
                            <button id="mnuMasS3" class="btn btn-default btn-block" onclick="OpenMenu('UserAuth');">กำหนดสิทธิ์ผู้ใช้งาน</button>
                        </div>
                        <div class="col-sm-6">
                            <button id="mnuMasS4" class="btn btn-default btn-block" onclick="OpenMenu('Branch')">สาขา</button>
                            <button id="mnuMasS5" class="btn btn-default btn-block" onclick="OpenMenu('Role')">กลุ่มผู้ใช้งาน</button>
                        </div>
                    </div>

                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>
    <div id="dvMasG" class="modal" style="width:100%">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header" style="background-color:black">
                    <div id="mainMasG" class="modal-title" style="color:white;text-align:center">
                        General Master Files
                    </div>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-sm-6">
                            <button id="mnuMasG1" class="btn btn-default btn-block" onclick="OpenMenu('Currency')">สกุลเงิน</button>
                            <button id="mnuMasG2" class="btn btn-default btn-block" onclick="OpenMenu('Country')">ประเทศ</button>
                            <button id="mnuMasG3" class="btn btn-default btn-block" onclick="OpenMenu('InterPort')">ท่าต่างประเทศ</button>
                            <button id="mnuMasG4" class="btn btn-default btn-block" onclick="OpenMenu('vessel')">ชื่อพาหนะ</button>
                        </div>
                        <div class="col-sm-6">
                            <button id="mnuMasG8" class="btn btn-default btn-block" onclick="OpenMenu('Province')">จังหวัด/ตำบล/อำเภอ</button>
                            <button id="mnuMasG5" class="btn btn-default btn-block" onclick="OpenMenu('DeclareType')">ประเภทใบขน</button>
                            <button id="mnuMasG6" class="btn btn-default btn-block" onclick="OpenMenu('CustomsPort')">ท่าตรวจปล่อย</button>
                            <button id="mnuMasG7" class="btn btn-default btn-block" onclick="OpenMenu('CustomsUnit')">หน่วยสินค้า</button>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>
    <div style="display:flex;flex-direction:column;margin-bottom:100px;">
        <div class="w3-container" style="margin-bottom:10px">
            <!-- Page Content -->
            <div Class="panel-primary">
                <div Class="panel-heading w3-indigo">
                    <div Class="panel-title" style="display:flex">
                        <div>
                            <img id="imgCompany" src="~/Resource/logo-tawan.jpg" style="width:100px" onclick="w3_open();" />
                        </div>
                        <div style="margin-left:10px">
                            <h4><label id="lblTitle" onclick="OpenContact()">@ViewBag.Title</label></h4>
                            <label style="display:none" id="lblModule">@ViewBag.Module</label>
                        </div>
                    </div>
                </div>
                <div class="panel-body">
                    @RenderBody()
                </div>
            </div>
        </div>
    </div>
    <div id="dvCommands" class="w3-indigo" style="text-align:center;bottom:0;position:fixed;line-height:50px;width:100%;padding-left:5px">
        <label id="lblLicenseName" onclick="CheckDatabase()">@ViewBag.LICENSE_NAME</label>
    </div>
    <div id="dvWaiting" class="modal fade" data-backdrop="static" data-keyboard="false" tabindex="-1">
        <div class="vertical-alignment-helper">
            <div class="modal-dialog vertical-align-center">
                <div class="modal-content">
                    <div class="modal-body">Please wait...</div>
                </div>
            </div>
        </div>
    </div>
    <div id="dvLogin" class="modal fade" data-backdrop="static" data-keyboard="false" tabindex="-1">
        <div class="vertical-alignment-helper">
            <div class="modal-dialog vertical-align-center">
                <div class="modal-content">
                    <div class="modal-header" style="background-color:black">
                        <div class="modal-title" style="color:white;text-align:center">
                            Log in
                        </div>
                    </div>
                    <div class="modal-body">
                        Database : <select class="form-control dropdown" id="cboDatabase"></select>
                        User ID : <input type="text" class="form-control" id="txtUserLogin" />
                        Password : <input type="password" class="form-control" id="txtUserPassword" />
                    </div>
                    <div class="modal-footer">
                        <button class="btn btn-primary" id="btnLogin" onclick="SetVariable()">Log in</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
    let userID = '@ViewBag.User';
    let dbID = GetDatabaseID();
    let sessionID = '@ViewBag.SESSION_ID';
    let dbMas = '@ViewBag.CONNECTION_MAS';
    let dbJob = '@ViewBag.CONNECTION_JOB';
    let userLang = '@ViewBag.PROFILE_DEFAULT_LANG';

    if (userLang !== 'EN' && userLang !== '') {
        $('#cboLanguage').val(userLang);
        ChangeLanguage(userLang, $('#lblModule').text());
    }
    SetEvents();

    function SetEvents() {
        $('#dvLogin').on('shown.bs.modal', function () {
            $('#txtUserLogin').focus();
        });
        $('#txtUserLogin').keydown(function (event) {
            if (event.which === 13) {
                $('#txtUserPassword').focus();
            }
        });
        $('#txtUserPassword').keydown(function (event) {
            if (event.which === 13) {
                SetVariable();
            }
        });
        CheckLogin();
    }
    function GetDatabaseID() {
        let dbName = '@ViewBag.LICENSE_NAME';
        if (dbName.indexOf('/') > 0) {
            return dbName.split('/')[1].trim();
        } else {
            return '1';
        }
    }
    function SetVariable() {
        userID = $('#txtUserLogin').val();
        dbID = $('#cboDatabase').val();
        let Password = $('#txtUserPassword').val();
        $.get('/Config/SetLogin?Code=' + userID + '&Pass=' + Password + '&Database=' + dbID)
            .done(function (r) {
                if (r.user.data.length > 0) {
                    location.reload();
                } else {
                    ShowMessage(r.user.message);
                }
            });
    }
    function SetLogin() {
        CheckPassword(dbID, userID, function () {
            ShowMessage('Welcome ' + userID + '!');
        });
    }

    function CheckLogin() {
        if (userID === '') {
            CheckSession();
        } else {
            $('#imgMenu').attr('src','/Resource/@ViewBag.PROFILE_LOGO');
            $('#imgCompany').attr('src','/Resource/@ViewBag.PROFILE_LOGO');
            $('#lblUserID').text('@ViewBag.UserName');
            $('#lblLicenseName').text('@ViewBag.LICENSE_NAME');
        }
    }
    function SetLogout() {
        ShowConfirm('Do you need to log out?', function (c) {
            if (c == true) {
                ShowWait();
                $.get('/Config/SetLogOut')
                    .done(function (r) {
                        CloseWait();
                        if (r == 'Y') {
                            window.location.href='/index.html';
                        }
                    });
            }
        });
    }
    function OpenContact() {
        window.open('/Menu/About', '', '');
    }
    function CheckDatabase() {
        ShowMessage('MAS='+dbMas+'\nJOB='+dbJob+'\nSESSION-ID='+sessionID);
    }
    function w3_open() {
        document.getElementById("mySidebar").style.display = "block";
        document.getElementById("myOverlay").style.display = "block";
    }
    function w3_close() {
        document.getElementById("mySidebar").style.display = "none";
        document.getElementById("myOverlay").style.display = "none";
    }
    function w3_accordion(id) {
        var x = document.getElementById(id);
        if (x.className.indexOf("w3-show") == -1) {
            x.className += " w3-show";
        } else {
            x.className = x.className.replace(" w3-show", "");
        }
    }
    </script>
</body>
</html> 