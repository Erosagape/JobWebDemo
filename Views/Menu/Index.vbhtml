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
    <style>
a.list-group-item:hover{
background:aqua;
color:blue;
}
    </style>
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
                            <h5><label id="lblCompanyName" style="text-align:right" onclick="CheckDatabase()">Shipping Control System</label></h5>
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
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuMkt" onclick="OpenMenu('AppQuo')">อนุมัติใบเสนอราคา</a>
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
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuCS" onclick="OpenMenu('Transport');">ใบจองรถ</a>
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuCS" onclick="OpenMenu('WHTax')">บันทึกหัก ณ ที่จ่าย</a>
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
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuShp" onclick="OpenMenu('Clearing')">ใบปิดค่าใช้จ่าย</a>
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
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Cheque')">บันทึกรับเช็ค</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('PettyCash')">บันทึกเงินสดย่อย</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('CreditAdv')">บันทึกเงินทดรองจ่าย</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('PayAdvance')">จ่ายเงินตามใบเบิก</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('RecvClear')">รับเคลียร์เงินจากใบเบิก</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Earnest')">รับเคลียร์เงินมัดจำ</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('RecvInv')">รับชำระจากใบเสร็จ/ใบกำกับ</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Payment')">จ่ายเงินตามบิลค่าใช้จ่าย</a>
                                        </div>
                                        <a href="#mnuSubAcc" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuFin">งานบัญชี</a>
                                        <div class="collapse" id="mnuSubAcc">
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Voucher')">บันทึกบัญชีรับ/จ่าย</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('GLNote')">บันทึกสมุดรายวัน</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('WHTax')">บันทึกหัก ณ ที่จ่าย</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Expense')">บิลค่าใช้จ่าย</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Invoice')">ใบแจ้งหนี้</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Billing')">ใบวางบิล</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('Receipt')">ใบเสร็จรับเงิน</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('TaxInvoice')">ใบกำกับภาษี</a>
                                            <a href="#" class="list-group-item glyphicon-minus" onclick="OpenMenu('CreditNote')">ใบเพิ่มหนี้/ลดหนี้</a>
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
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuTrack" onclick="OpenMenu('Report')">รายงานต่างๆ</a>
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
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuMas" onclick="OpenMenu('MasG')">ข้อมูลพื้นฐาน</a>
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuMas" onclick="OpenMenu('MasA')">ข้อมูลทางบัญชี</a>
                                        <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuMas" onclick="OpenMenu('MasS')">ข้อมูลระบบ</a>
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
    <script type="text/javascript">
    let path = '@Url.Content("~")';
    let userID = '';
    let compID = '';
    //$(document).ready(function () {
        CheckLogin();
    //});
    function ShowLogin(r) {
        userID = r.UserID;
        $('#lblUserID').text(r.TName);
        if (compID !== '') {
            $('#lblCompanyName').text(compID);
        }
    }
    function CheckLogin() {
        if (userID === '') {
            $.get(path+'Config/GetLogin')
                .done(function (r) {
                    if (r.user.data.UserID !== null) {
                        compID = '@ViewBag.LICENSE_NAME';
                        ShowLogin(r.user.data);
                    } else {
                        userID = '';
                        window.Open('/index.html', '', '');
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
    function OpenMenu(mnuID) {
        let mnuPath = '';
        switch (mnuID) {
            case 'Advance':
                mnuPath = path+'Adv/Index';
                break;
            case 'AppQuo':
                mnuPath = path + 'JobOrder/QuoApprove';
                break;
            case 'AppAdvance':
                mnuPath = path + 'Adv/Approve';
                break;
            case 'PayAdvance':
                mnuPath = path + 'Adv/Payment';
                break;
            case 'Bank':
                mnuPath = path + 'Master/Bank';
                break;
            case 'BookAccount':
                mnuPath = path + 'Master/BookAccount';
                break;
            case 'Branch':
                mnuPath = path + 'Master/Branch';
                break;
            case 'Clearing':
                mnuPath = path + 'Clr/Index';
                break;
            case 'AppClearing':
                mnuPath = path + 'Clr/Approve';
                break;
            case 'RecvClear':
                mnuPath = path + 'Clr/Receive';
                break;
            case 'Constant':
                mnuPath = path +'Config/Index';
                break;
            case 'CreateJob':
                mnuPath = path +'JobOrder/CreateJob';
                break;
            case 'SearchJob':
                mnuPath = path +'JobOrder/Index';
                break;
            case 'Country':
                mnuPath = path + 'Master/Country';
                break;
            case 'Currency':
                mnuPath = path + 'Master/Currency';
                break;
            case 'DeclareType':
                mnuPath = path + 'Master/DeclareType';
                break;
            case 'CustomsPort':
                mnuPath = path + 'Master/CustomsPort';
                break;
            case 'CustomsUnit':
                mnuPath = path + 'Master/CustomsUnit';
                break;
            case 'InterPort':
                mnuPath = path + 'Master/InterPort';
                break;
            case 'ServiceCode':
                mnuPath = path + 'Master/ServiceCode';
                break;
            case 'ServiceGroup':
                mnuPath = path + 'Master/ServiceGroup';
                break;
            case 'ServUnit':
                mnuPath = path + 'Master/ServUnit';
                break;
            case 'users':
                mnuPath = path +'Master/Users';
                break;
            case 'UserAuth':
                mnuPath = path + 'Config/UserAuth';
                break;
            case 'venders':
                mnuPath = path +'Master/Venders';
                break;
            case 'customers':
                mnuPath = path +'Master/Customers';
                break;
            case 'GLNote':
                mnuPath = path + 'Acc/GLNote';
                break;
            case 'Voucher':
                mnuPath = path + 'Acc/Voucher';
                break;
            case 'WHTax':
                mnuPath = path + 'Acc/WHTax';
                break;
            case 'Invoice':
                mnuPath = path + 'Acc/Invoice';
                break;
            case 'Receipt':
                mnuPath = path + 'Acc/Receipt';
                break;
            case 'Billing':
                mnuPath = path + 'Acc/Billing';
                break;
            case 'Expense':
                mnuPath = path + 'Acc/Expense';
                break;
            case 'TaxInvoice':
                mnuPath = path + 'Acc/TaxInvoice';
                break;
            case 'CreditNote':
                mnuPath = path + 'Acc/CreditNote';
                break;
            case 'CreditAdv':
                mnuPath = path + 'Adv/CreditAdv';
                break;
            case 'Report':
                mnuPath = path + 'Report/Index';
                break;
            case 'Tracking':
                mnuPath = path + 'Tracking/Index';
                break;
            case 'Transport':
                mnuPath = path + 'JobOrder/Transport';
                break;
            case 'Quotation':
                mnuPath = path + 'JobOrder/Quotation';
                break;
            case 'Cheque':
                mnuPath = path + 'Acc/Cheque';
                break;
            case 'RecvInv':
                mnuPath = path + 'Acc/RecvInv';
                break;
            case 'Payment':
                mnuPath = path + 'Acc/Payment';
                break;
            case 'PettyCash':
                mnuPath = path + 'Acc/PettyCash';
                break;
            case 'Earnest':
                mnuPath = path + 'Clr/Earnest';
                break;
            case 'MasS':
                $('#dvMasS').modal('show');
                break;
            case 'MasG':
                $('#dvMasG').modal('show');
                break;
            case 'MasA':
                $('#dvMasA').modal('show');
                break;
            case 'Role':
                mnuPath = path + 'Config/Role';
                break;
            case 'BudgetPolicy':
                mnuPath = path + 'Master/BudgetPolicy';
                break;
            case 'vessel':
                mnuPath = path + 'Master/Vessel';
                break;
            default:
                alert('Under Development, Coming soon!');
                break;
        }
        if (userID !== '') {
            if (mnuPath !== '') {
                window.location.href = mnuPath;
            }
        } else {
            alert('Please login first');
            window.location.href = path + 'index.html?redirect='+ mnuPath;
        }
    }
    function CheckDatabase() {
        alert('MAS=@ViewBag.CONNECTION_MAS\nJOB=@ViewBag.CONNECTION_JOB');
    }
    </script>
</body>
</html>