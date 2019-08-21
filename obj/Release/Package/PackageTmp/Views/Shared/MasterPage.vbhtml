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
    <script src="~/Scripts/Func/menu.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
</head>
<body style="background:#e6e6e6;color:black;">
    <!-- Sidebar -->
    <div class="w3-sidebar w3-bar-block w3-animate-left" style="display:none;z-index:5" id="mySidebar">
        <div class="w3-sidebar w3-bar-block w3-indigo w3-card" style="width:250px;">
            <div style="width:100%;text-align:center;background-color:white">
                <img src="~/Resource/logo-tawan.jpg" onclick="SetLogout()" style="width:150px;padding:5px 5px 5px 5px;" />
            </div>
            <div style="width:100%;text-align:center;background-color:white;color:black">
                <a href="#" onclick="SetLogin()"><label id="lblUserID">Please Login</label></a>
            </div>
            <div id="mainBoard" class="w3-bar-item w3-button" onclick="OpenMenu('Dashboard')">
                Dashboard
            </div>
            <div id="mainMkt" class="w3-bar-item w3-button" onclick="w3_accordion('mnuMkt')">
                Marketing Works
            </div>
            <div id="mnuMkt" class="w3-hide w3-pale-green w3-card-4">
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Quotation')">- Quotation</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('AppQuo')">- Approve Quotation</a>
            </div>
            <div id="mainCS" class="w3-bar-item w3-button" onclick="w3_accordion('mnuCS')">
                CS Works
            </div>
            <div id="mnuCS" class="w3-hide w3-light-grey w3-card-4">
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('CreateJob')">- Create Job</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('SearchJob')">- List Job</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Transport')">- Delivery Order</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('WHTax')">- Withholding Tax</a>
            </div>
            <div id="mainApp" class="w3-bar-item w3-button" onclick="w3_accordion('mnuShp')">
                Shipping Works
            </div>
            <div id="mnuShp" class="w3-hide w3-khaki w3-card-4">
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Advance')">- Advance</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Clearing')">- Clearing</a>
            </div>
            <div id="mainApp" class="w3-bar-item w3-button" onclick="w3_accordion('mnuApp')">
                Approving
            </div>
            <div id="mnuApp" class="w3-hide w3-pale-yellow w3-card-4">
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('AppAdvance')">- Approve Advance</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('AppClearing')">- Approve Clearing</a>
            </div>
            <div id="mainFin" class="w3-bar-item w3-button" onclick="w3_accordion('mnuFin')">
                Finance Works
            </div>
            <div id="mnuFin" class="w3-hide w3-pale-blue w3-card-4">
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('PayAdvance')">- Payment Advance</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Payment')">- Payment Bill</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('RecvClear')">- Receive Clearing</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('RecvInv')">- Receive Invoice</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Cheque')">- Cheque Management</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('CreditAdv')">- Credit Advance</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('PettyCash')">- Petty Cash</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Earnest')">- Earnest Clearing</a>
            </div>
            <div id="mainAcc" class="w3-bar-item w3-button" onclick="w3_accordion('mnuAcc')">
                Account Works
            </div>
            <div id="mnuAcc" class="w3-hide w3-pale-red w3-card-4">
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Voucher')">- Vouchers</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Invoice')">- Invoice</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Billing')">- Billing</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Receipt')">- Receipts</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('TaxInvoice')">- Tax-invoice</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Expense')">- Payments Bill</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('CreditNote')">- Credit/Debit Note</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('GLNote')">- Journal Entry</a>
            </div>
            <div id="mainRpt" class="w3-bar-item w3-button" onclick="w3_accordion('mnuRpt')">
                Report & Tracking
            </div>
            <div id="mnuRpt" class="w3-hide w3-amber w3-card-4">
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Report')">- Reports</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('Tracking')">- Tracking</a>
            </div>
            <div id="mainMas" class="w3-bar-item w3-button" onclick="w3_accordion('mnuMas')">
                Master Files
            </div>
            <div id="mnuMas" class="w3-hide w3-sand w3-card-4">
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('MasG')">- Customs File</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('MasA')">- Accounts File</a>
                <a href="#" class="w3-bar-item w3-button" onclick="OpenMenu('MasS')">- System Files</a>
            </div>
        </div>
    </div>
    <div class="w3-overlay w3-animate-opacity" onclick="w3_close()" style="cursor:pointer" id="myOverlay"></div>
    <div style="display:flex;flex-direction:column;margin-bottom:100px;">
        <div class="w3-container" style="margin-bottom:10px">
            <!-- Page Content -->
            <div Class="panel-primary">
                <div Class="panel-heading w3-indigo">
                    <div Class="panel-title" style="display:flex">
                        <div>
                            <img src="~/Resource/logo-tawan.jpg" style="width:100px" onclick="w3_open();" />
                        </div>
                        <div style="margin-left:10px">
                            <h4>@ViewBag.Title</h4>
                        </div>
                    </div>
                </div>
                <div class="panel-body">
                    @RenderBody()
                </div>
            </div>
        </div>

    </div>
    <div id="dvMasA" class="modal" style="width:100%">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header" style="background-color:black">
                    <div class="modal-title" style="color:white;text-align:center">
                        Account Master Files
                    </div>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-sm-6">
                            <button class="btn btn-default btn-block" onclick="OpenMenu('customers')">ผู้นำเข้าส่งออก</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('venders')">ผู้ให้บริการ</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('ServUnit')">หน่วยบริการ</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('Bank')">ธนาคาร</button>
                        </div>
                        <div class="col-sm-6">
                            <button class="btn btn-default btn-block" onclick="OpenMenu('BookAccount')">สมุดบัญชีธนาคาร</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('ServiceGroup')">กลุ่มค่าบริการ</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('ServiceCode')">รหัสค่าบริการ</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('BudgetPolicy')">มาตรฐานค่าบริการ</button>
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
                    <div class="modal-title" style="color:white;text-align:center">
                        System Master Files
                    </div>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-sm-6">
                            <button class="btn btn-default btn-block" onclick="OpenMenu('Constant')">ค่าคงที่ระบบ</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('users');">ผู้ใช้งาน</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('UserAuth');">กำหนดสิทธิ์ผู้ใช้งาน</button>
                        </div>
                        <div class="col-sm-6">
                            <button class="btn btn-default btn-block" onclick="OpenMenu('Branch')">สาขา</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('Role')">กลุ่มผู้ใช้งาน</button>
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
                    <div class="modal-title" style="color:white;text-align:center">
                        General Master Files
                    </div>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-sm-6">
                            <button class="btn btn-default btn-block" onclick="OpenMenu('Currency')">สกุลเงิน</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('Country')">ประเทศ</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('InterPort')">ท่าต่างประเทศ</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('vessel')">ชื่อพาหนะ</button>
                        </div>
                        <div class="col-sm-6">
                            <button class="btn btn-default btn-block" onclick="OpenMenu('DeclareType')">ประเภทใบขน</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('CustomsPort')">ท่าตรวจปล่อย</button>
                            <button class="btn btn-default btn-block" onclick="OpenMenu('CustomsUnit')">หน่วยสินค้า</button>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>
    <div id="dvCommands" class="w3-indigo" style="text-align:center;bottom:0;position:fixed;line-height:50px;width:100%;padding-left:5px">
        <div style="float:left">
            <label id="lblCompanyName">Tawan Technology Co.,ltd &copy;@DateTime.Today.Year</label>
        </div>
        <div style="float:right">
            <label id="lblLicenseName" onclick="CheckDatabase()">@ViewBag.LICENSE_NAME</label>
        </div>
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
    <script type="text/javascript">
    let userID = '@ViewBag.User';
    let dbID = '@ViewBag.LICENSE_NAME'.split('/')[1].trim();
    CheckLogin();
    function SetLogin() {
        CheckPassword(dbID, userID, function () {
            ShowMessage('Welcome ' + userID + '!');
        });
    }
    function CheckLogin() {
        if (userID === '') {
            window.location.href='/index.html';
        } else {
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
    function CheckDatabase() {
        ShowMessage('MAS=@ViewBag.CONNECTION_MAS\nJOB=@ViewBag.CONNECTION_JOB');
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