@Code
    ViewBag.Title = "Book Account"
End Code
    <div class="panel-body">
        <div class="container">
            <!-- HTML BOOTSTRAP CONTROLS -->
            <div id="dvForm">
                Branch:
                <div class="row">
                    <div class="col-sm-4" style="display:flex;flex-direction:row;">
                        <input type="text" class="form-control" id="txtBranchCode" style="width:15%" />
                        <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                        <input type="text" class="form-control" id="txtBranchName" style="width:60%" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3">
                        Book No:<br /><input type="text" id="txtBookCode" class="form-control" tabIndex="2">
                    </div>
                    <div class="col-sm-6">
                        Account Name :<br /><input type="text" id="txtBookName" class="form-control" tabIndex="3">
                    </div>
                    <div class="col-sm-3">
                        Account Type :<br />
                        <select id="txtACType" class="form-control dropdown" tabIndex="4">
                            <option value="C">Current</option>
                            <option value="S">Saving</option>
                        </select>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-2">
                        <a onclick="SearchData('bank')">Bank Code :</a><br />
                        <input type="text" id="txtBankCode" class="form-control" tabIndex="5">
                    </div>
                    <div class="col-sm-4">
                        Bank Name:<br />
                        <input type="text" id="txtBankName" class="form-control" disabled>
                    </div>
                    <div class="col-sm-4">
                        Bank Branch :<br /><input type="text" id="txtBankBranch" class="form-control" tabIndex="6" />
                    </div>
                    <div class="col-sm-2">
                        <br />
                        <input type="checkbox" id="chkIsLocal" tabIndex="7">
                        <label for="chkIsLocal">Is Local Bank?</label>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-5">
                        Address (TH) :<br /><input type="text" id="txtTAddress1" class="form-control" tabIndex="8">
                        <br /><input type="text" id="txtTAddress2" class="form-control" tabIndex="9">
                    </div>
                    <div class="col-sm-5">
                        Address (EN) :<br /><input type="text" id="txtEAddress1" class="form-control" tabIndex="10">
                        <br /><input type="text" id="txtEAddress2" class="form-control" tabIndex="11">
                    </div>
                    <div class="col-sm-2">
                        GL Code : <br/>
                        <div style="display:flex">
                            <input type="text" id="txtGLAccountCode" class="form-control" />
                            <input type="button" class="btn btn-default" value="..." onclick="SearchData('acccode')" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        Phone :<br /><input type="text" id="txtPhone" class="form-control" tabIndex="12">
                    </div>
                    <div class="col-sm-4">
                        Fax :<br /><input type="text" id="txtFaxNumber" class="form-control" tabIndex="13">
                    </div>
                    <div class="col-sm-4">
                        Minimum Balance :<br /><input type="number" id="txtLimitBalance" class="form-control" tabIndex="14">
                    </div>
                </div>
            </div>
            <br />
            <div id="dvCommand" class="col-sm-12">
                <a href="#" class="btn btn-default w3-purple" id="btnAdd" onclick="ClearData()">
                    <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>New</b>
                </a>
                <a href="#" class="btn btn-success" id="btnSave" onclick="SaveData()">
                    <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save</b>
                </a>
                <a href="#" class="btn btn-danger" id="btnDel" onclick="DeleteData()">
                    <i class="fa fa-lg fa-trash"></i>&nbsp;<b>Delete</b>
                </a>
                <a href="#" class="btn btn-primary" id="btnSearch" onclick="SearchData('book')">
                    <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Search</b>
                </a>
            </div>
            <br/>
            <table id="tbBalance" class="table table-responsive">
                <thead>
                    <tr>
                        <th>Cash on hand</th>
                        <th class="all">Cash avaiable</th>
                        <th class="desktop">Chq on hand</th>
                        <th class="desktop">Chq return</th>
                        <th class="desktop">Credit</th>
                        <th class="desktop">Balance</th>
                    </tr>
                </thead>
                <tbody></tbody>
            </table>
        </div>
        <div id="dvLOVs"></div>
    </div>

<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    //$(document).ready(function () {
        SetEvents();
        SetEnterToTab();
        ClearData();
    //});
    function SetEvents() {
        $('#txtBranchCode').keydown(function (event) {
            if (event.which == 13) {
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            }
        });
        $('#txtBankCode').keydown(function (event) {
            if (event.which == 13) {
                ShowBank(path, $('#txtBankCode').val(), '#txtBankName');
            }
        });
        $('#txtBookCode').keydown(function (event) {
            if (event.which == 13) {
                var branch = $('#txtBranchCode').val();
                var code = $('#txtBookCode').val();
                ClearData();
                $('#txtBranchCode').val(branch);
                $('#txtBookCode').val(code);
                CallBackQueryBookAccount(path, branch,code, ReadData);
            }
        });
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
            CreateLOV(dv, '#frmSearchBank', '#tbBank', 'Bank', response, 2);
            CreateLOV(dv, '#frmSearchBook', '#tbBook', 'Book Account', response, 2);
            CreateLOV(dv, '#frmSearchAcc', '#tbAcc', 'Account Code', response, 2);
        });
    }
    function SetEnterToTab() {
        //Set enter to tab
        $("input[tabindex], select[tabindex], textarea[tabindex]").each(function () {
            $(this).on("keypress", function (e) {
                if (e.keyCode === 13) {
                    var idx = (this.tabIndex + 1);
                    var nextElement = $('[tabindex="' + idx + '"]');
                    while (nextElement.length) {
                        if (nextElement.prop('disabled') == false) {
                            $('[tabindex="' + idx + '"]').focus();
                            e.preventDefault();
                            return;
                        } else {
                            idx = idx + 1;
                            nextElement = $('[tabindex="' + idx + '"]');
                        }
                    }
                    $('[tabindex="1"]').focus();
                }
            });
        });
    }
    function SearchData(type) {
        switch (type) {
            case 'acccode':
                SetGridAccountCode(path, '#tbAcc', '#frmSearchAcc', '', ReadAccount);
                break;
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'bank':
                SetGridBank(path, '#tbBank', '#frmSearchBank', ReadBank);
                break;
            case 'book':
                SetGridBookAccount(path, '#tbBook', '#frmSearchBook', ReadData);
                break;

        }
    }
    function ReadAccount(dr) {
        $('#txtGLAccountCode').val(dr.AccCode);
    }
    function ReadBank(dr) {
        $('#txtBankCode').val(dr.Code);
        $('#txtBankName').val(dr.BName);
        $('#txtBankCode').focus();
    }
    function ReadBranch(dr) {
        $('#txtBranchCode').val(dr.Code);
        $('#txtBranchName').val(dr.BrName);
        $('#txtBranchCode').focus();
    }

//CRUD Functions used in HTML Java Scripts
    function DeleteData() {
        var branch = $('#txtBranchCode').val();
        var code = $('#txtBookCode').val();
        ShowConfirm("Do you need to Delete " + code + "?", function (ask) {
            if (ask == false) return;
            $.get(path + 'master/delbookaccount?branch='+branch+'&code=' + code, function (r) {
                ShowMessage(r.bookaccount.result);
                ClearData();
            });
        });
    }
    function ReadData(dr) {
        $('#txtBranchCode').val(dr.BranchCode);
        ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
        $('#txtBookCode').val(dr.BookCode);
        $('#txtGLAccountCode').val(dr.GLAccountCode);
        $('#txtBookName').val(dr.BookName);
        $('#txtBankCode').val(dr.BankCode);
        ShowBank(path, $('#txtBankCode').val(), '#txtBankName');
        $('#txtBankBranch').val(dr.BankBranch);
        $('#chkIsLocal').prop('checked', dr.IsLocal = 1 ? true : false);
        $('#txtACType').val(dr.ACType);
        $('#txtTAddress1').val(dr.TAddress1);
        $('#txtTAddress2').val(dr.TAddress2);
        $('#txtEAddress1').val(dr.EAddress1);
        $('#txtEAddress2').val(dr.EAddress2);
        $('#txtPhone').val(dr.Phone);
        $('#txtFaxNumber').val(dr.FaxNumber);        
        $('#txtLimitBalance').val(dr.LimitBalance);   
        ShowBalance();
    }
    function ShowBalance() {
        $('#tbBalance').DataTable().clear().draw();
        $.get(path + 'Master/GetBookBalance?code=' + $('#txtBookCode').val(), function (r) {
            if (r.bookaccount.data.length > 0) {
                let tb = r.bookaccount.data[0].Table;
                $('#tbBalance').DataTable({
                    data: tb,
                    columns: [
                        { data: "SumCash" },
                        { data: "SumCashInBank" },
                        { data: "SumChqOnhand" },
                        { data: "SumChqReturn" },
                        { data: "SumCredit" },
                        { data: "SumBal" }
                    ],
                    responsive:true,
                    destroy:true
                });
            }
        });
    }
    function SaveData(){
        var obj={
            BranchCode: $('#txtBranchCode').val(),
            BookCode:$('#txtBookCode').val(),
            BookName:$('#txtBookName').val(),
            BankCode: $('#txtBankCode').val(),
            BankBranch:$('#txtBankBranch').val(),
            IsLocal: ($('#chkIsLocal').prop('checked') == true ? 1 : 0),
            ACType:$('#txtACType').val(),
            TAddress1:$('#txtTAddress1').val(),
            TAddress2:$('#txtTAddress2').val(),
            EAddress1:$('#txtEAddress1').val(),
            EAddress2:$('#txtEAddress2').val(),
            Phone:$('#txtPhone').val(),
            FaxNumber: $('#txtFaxNumber').val(),
            LimitBalance: $('#txtLimitBalance').val(),
            GLAccountCode: $('#txtGLAccountCode').val()
        };
        if (obj.BookCode != "") {
            ShowConfirm("Do you need to Save " + obj.BookCode + "?", function (ask) {
                if (ask == false) return;
                var jsonText = JSON.stringify({ data: obj });
                $.ajax({
                    url: "@Url.Action("SetBookAccount", "Master")",
                    type: "POST",
                    contentType: "application/json",
                    data: jsonText,
                    success: function (response) {
                        if (response.result.data != null) {
                            $('#txtBookCode').val(response.result.data);
                            $('#txtBookCode').focus();
                        }
                        ShowMessage(response.result.msg);
                    },
                    error: function (e) {
                        ShowMessage(e);
                    }
                });
            });
        } else {
            ShowMessage('No data to save');
        }
    }
    function ClearData(){
        //$('#txtBranchCode').val('');
        //$('#txtBranchName').val('');
        $('#txtBookCode').val('');
        $('#txtBookName').val('');
        $('#txtBankCode').val('');
        $('#txtBankName').val('');
        $('#txtBankBranch').val('');
        $('#chkIsLocal').prop('checked', false);
        $('#txtACType').val('');
        $('#txtTAddress1').val('');
        $('#txtTAddress2').val('');
        $('#txtEAddress1').val('');
        $('#txtEAddress2').val('');
        $('#txtPhone').val('');
        $('#txtFaxNumber').val('');
        $('#txtBookCode').focus();
        $('#txtLimitBalance').val(0);   
        $('#txtGLAccountCode').val('');
        $('#tbBalance').DataTable().clear().draw();
    }
</script>
