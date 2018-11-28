@Code
    Layout = Nothing
End Code
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="~/Content/bootstrap.min.css">
    <link rel="stylesheet" href="~/Content/jquery.datatables.min.css">
    <script src="~/Scripts/jquery-3.3.1.min.js"></script>
    <script src="~/Scripts/DataTables/jquery.dataTables.min.js"></script>
    <script src="~/Scripts/bootstrap.js"></script>
    <script src="~/Scripts/Func/Util.js"></script>
    <script src="~/Scripts/Func/popup.js"></script>
    <title>Main Menu</title>
</head>
<body>
    <div class="panel-primary">
        <div class="panel-heading">
            <div class="panel-title">
                <table style="width:100%">
                    <tr>
                        <td>
                            <img src="~/Resource/logo-tawan.jpg" style="width:100px" onclick="CheckLogin()" />
                        </td>
                        <td align="right">
                            <h5><label id="lblCompanyName" style="text-align:right" onclick="CheckLogin()">Shipping Control System</label></h5>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="panel-body">
            <div class="row" style="background-color:white">
                <div class="col-sm-3" style="text-align:center">
                    <label id="lblUserID" style="color:black" onclick="CheckLogin()">Please Login</label>
                    <div id="navbar" class="navbar navbar-collapse;text" style="text-align:left">
                        <div class="panel-group" id="accordion">
                            <div class="panel panel-primary">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#mnuMkt">
                                            Marketing Works
                                        </a>
                                    </h4>
                                </div>
                                <div id="mnuMkt" class="panel-collapse collapse">
                                    <div class="panel-body">
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuMkt" onclick="OpenMenu('Quotation')">จัดการใบเสนอราคา</a>
                                    </div>
                                </div>
                            </div>
                            <div class="panel panel-primary">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#mnuCS">
                                            CS Works
                                        </a>
                                    </h4>
                                </div>
                                <div id="mnuCS" class="panel-collapse collapse">
                                    <div class="panel-body">
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuCS" onclick="OpenMenu('CreateJob');">เปิดงานใหม่</a>
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuCS" onclick="OpenMenu('SearchJob');">ค้นหางาน</a>
                                    </div>
                                </div>
                            </div>
                            <div class="panel panel-primary">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#mnuShp">
                                            Shipping Works
                                        </a>
                                    </h4>
                                </div>
                                <div id="mnuShp" class="panel-collapse collapse">
                                    <div class="panel-body">
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuShp" onclick="OpenMenu('Advance');">ใบเบิกค่าใช้จ่าย</a>
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuShp" onclick="openMenu('Clearing')">ใบปิดค่าใช้จ่าย</a>
                                    </div>
                                </div>
                            </div>
                            <div class="panel panel-primary">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#mnuFin">
                                            Finance & Accounting Works
                                        </a>
                                    </h4>
                                </div>
                                <div id="mnuFin" class="panel-collapse collapse">
                                    <div class="panel-body">
                                        <a href="#mnuSubFin" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuFin">งานการเงิน</a>
                                        <div class="collapse" id="mnuSubFin">
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('PayAdvance')">จ่ายเงินตามใบเบิก</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('RecvClear')">รับเคลียร์เงินตามใบปิด</a>
                                        </div>
                                        <a href="#mnuSubAcc" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuFin">งานบัญชี</a>
                                        <div class="collapse" id="mnuSubAcc">
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Invoices')">ใบแจ้งหนี้</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Receipts')">ใบเสร็จรับเงิน</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('TaxInvoices')">ใบกำกับภาษี</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="panel panel-primary">
                                <div class="panel-heading">
                                    <div class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#mnuAppr">
                                            Approving Documents
                                        </a>
                                    </div>
                                </div>
                                <div id="mnuAppr" class="panel-collapse collapse">
                                    <div class="panel-body">
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuAppr" onclick="OpenMenu('AppAdvance')">อนุมัติใบเบิก</a>
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuAppr" onclick="OpenMenu('AppClearing')">อนุมัติใบปิด</a>
                                    </div>
                                </div>
                            </div>
                            <div class="panel panel-primary">
                                <div class="panel-heading">
                                    <div class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#mnuTrack">
                                            Tracking Information
                                        </a>
                                    </div>
                                </div>
                                <div id="mnuTrack" class="panel-collapse collapse">
                                    <div class="panel-body">
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuTrack" onclick="OpenMenu('Reports')">รายงานต่างๆ</a>
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuTrack" onclick="OpenMenu('Tracking')">ตรวจสอบการทำงาน</a>
                                    </div>
                                </div>
                            </div>
                            <div class="panel panel-primary">
                                <div class="panel-heading">
                                    <div class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#mnuMas">
                                            Master Files
                                        </a>
                                    </div>
                                </div>
                                <div id="mnuMas" class="panel-collapse collapse">
                                    <div class="panel-body">
                                        <a href="#mnuSubMas1" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuMas">ข้อมูลระบบ</a>
                                        <div class="collapse" id="mnuSubMas1">
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Constant')">ค่าคงที่ระบบ</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Branch')">สาขา</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('users');">ผู้ใช้งาน</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('UserAuth');">กำหนดสิทธิ์ผู้ใช้งาน</a>
                                        </div>
                                        <a href="#mnuSubMas2" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuMas">ข้อมูลทั่วไป</a>
                                        <div class="collapse" id="mnuSubMas2">
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Currency')">สกุลเงิน</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Country')">ประเทศ</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('DeclareType')">ประเภทใบขน</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('CustomsPort')">ท่าตรวจปล่อย</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('InterPort')">ท่าต่างประเทศ</a>
                                        </div>
                                        <a href="#mnuSubMas3" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuMas">ข้อมูลบัญชี</a>
                                        <div class="collapse" id="mnuSubMas3">
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('customers')">ผู้นำเข้าส่งออก</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('ServiceCode')">รหัสค่าบริการ</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('venders')">ผู้ให้บริการ</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('ServUnit')">หน่วยบริการ</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-sm-9">
                    <img src="~/Resource/jobtawan_bg.jpg" style="width:100%" onclick="CheckLogin()" />
                </div>
            </div>
        </div>
        <div class="panel-footer">
            <p>&copy; @DateTime.Now.Year - Tawan Technology Co.,ltd</p>
        </div>
    </div>
    <div id="dvLogin" class="modal" style="width:100%">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header" style="background-color:black">
                    <div class="modal-title" style="color:white;text-align:center">
                        Logon Information
                    </div>
                </div>
                <div class="modal-body">
                    Company ID : <input type="text" class="form-control" id="txtCompanyID" value="jobdemo" disabled />
                    User ID : <input type="text" class="form-control" id="txtUserID" />
                    Password : <input type="password" class="form-control" id="txtPassword" />
                </div>
                <div class="modal-footer">
                    <button class="btn btn-primary" id="btnLogin" onclick="Login()">Log in</button>
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
    var path = '@Url.Content("~")';
    var userID = '';
    $(document).ready(function () {
        SetEvents();
        CheckLogin();
    });
    function SetEvents() {
        $('#dvLogin').on('shown.bs.modal', function () {
            $('#txtUserID').focus();
        });
        $('#txtUserID').keydown(function (event) {
            if (event.which === 13) {
                $('#txtPassword').focus();
            }
        });
        $('#txtPassword').keydown(function (event) {
            if (event.which === 13) {
                Login();
            }
        });
    }
    function ShowLogin(r) {
        userID = r.UserID;
        $('#lblUserID').text(r.TName);
        var compID = $('#txtCompanyID').val();
        if (compID !== '') {
            $('#lblCompanyName').text(compID);
        }
    }
    function CheckLogin() {
        if (userID === '') {
            $.get(path+'Config/GetLogin')
                .done(function (r) {
                    if (r.user.data.UserID !== null) {
                        ShowLogin(r.user.data);
                    } else {
                        userID = '';
                        $('#dvLogin').modal('show');
                    }
                });
        } else {
            var c = confirm('Do you need to log out?');
            if (c == true) {
                $.get(path+'Config/SetLogOut')
                    .done(function (r) {
                        if (r == 'Y') {
                            alert('Log out successfully');
                            userID = '';
                            $('#lblUserID').text('Please Login');
                            $('#lblCompanyName').text('Shipping Control System');
                        }
                    });
            }
        }
    }
    function Login() {
        userID = $('#txtUserID').val();
        if (userID !== '') {
            var Password = $('#txtPassword').val();
            $.get(path+'Config/SetLogin?Code=' + userID + '&Pass=' + Password)
                .done(function (r) {
                    if (r.user.data.length > 0) {
                        var b = r.user.data[0];
                        ShowLogin(b);
                    } else {
                        userID = '';
                        $('#lblUserID').text('Please Login');

                        alert('User ID or Password Incorrect');
                    }
                    $('#dvLogin').modal('hide');
                });
        } else {
            userID = '';
            $('#lblUserID').text('Please Login');
            $('#lblCompanyName').text('Shipping Control System');
        }
    }
    function CheckRights(mnuID) {
        //if (userID.toUpperCase() == 'ADMIN') {
        //    return 'Y';
        //}
        return 'Y';
    }
    function OpenMenu(mnuID) {
        if (userID !== '') {
            if (CheckRights(mnuID) == 'N') {
                alert('You are not authorized');
                return;
            }
            switch (mnuID) {
                case 'Advance':
                    window.location.href = path+'Adv/Index';
                    break;
                case 'Branch':
                    window.location.href = path + 'Master/Branch';
                    break;
                case 'Constant':
                    window.location.href = path +'Config/Index';
                    break;
                case 'CreateJob':
                    window.location.href = path +'JobOrder/CreateJob';
                    break;
                case 'SearchJob':
                    window.location.href = path +'JobOrder/Index';
                    break;
                case 'Country':
                    window.location.href = path + 'Master/Country';
                    break;
                case 'Currency':
                    window.location.href = path + 'Master/Currency';
                    break;
                case 'DeclareType':
                    window.location.href = path + 'Master/DeclareType';
                    break;
                case 'CustomsPort':
                    window.location.href = path + 'Master/CustomsPort';
                    break;
                case 'InterPort':
                    window.location.href = path + 'Master/InterPort';
                    break;
                case 'ServiceCode':
                    window.location.href = path + 'Master/ServiceCode';
                    break;
                case 'ServUnit':
                    window.location.href = path + 'Master/ServUnit';
                    break;
                case 'users':
                    window.location.href = path +'Master/Users';
                    break;
                case 'UserAuth':
                    window.location.href = path + 'Config/UserAuth';
                    break;
                case 'venders':
                    window.location.href = path +'Master/Venders';
                    break;
                case 'customers':
                    window.location.href = path +'Master/Customers';
                    break;
                default:
                    alert('Under Development, Coming soon!');
                    break;
            }
        } else {
            alert('Please login first');
            window.location.href = path + 'index.html';
        }
    }
    </script>
</body>
</html>