@Code
    ViewBag.Title = "CompanyContact"
End Code
<div class="panel-body">
    <div id="dvForm" class="container">
        <div class="row">
            <div class="col-sm-4">
                Customer :<br />
                <table>
                    <tr>
                        <td style="width:60%">
                            <input type="text" id="txtCustCode" class="form-control" disabled />                            
                        </td>
                        <td style="width:30%">
                            <input type="text" id="txtBranch" class="form-control" disabled />
                        </td>
                        <td style="width:10%">
                            <button id="btnBrowseCust" onclick="SearchData('customer')" class="btn btn-default">...</button>
                        </td>
                    </tr>
                </table>                
            </div>
            <div class="col-sm-6">
                <br/>
                <input type="text" id="txtCustName" class="form-control" disabled />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-2">
                No :<br />
                    <div style="display:flex">
                        <div style="flex:60%">
                            <input type="text" id="txtItemNo" class="form-control" value="0" disabled>
                        </div>
                        <div style="flex:40%">
                            <input type="button" id="btnAdd" value="Add" class="btn btn-default w3-purple" onclick="ClearData()" />
                        </div>
                    </div>                                
            </div>
            <div class="col-sm-5">
                Department :<br /><input type="text" id="txtDepartment" class="form-control">
            </div>
            <div class="col-sm-5">
                Position :<br /><input type="text" id="txtPosition" class="form-control">
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                Name :<br /><input type="text" id="txtContactName" class="form-control">
            </div>
            <div class="col-sm-3">
                E-Mail :<br /><input type="text" id="txtEMail" class="form-control">
            </div>
            <div class="col-sm-3">
                Phone :<br /><input type="text" id="txtPhone" class="form-control">
            </div>
        </div>
        <div id="dvCommand">
            <a href="#" class="btn btn-success" id="btnSave" onclick="SaveData()">
                <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save</b>
            </a>
            <a href="#" class="btn btn-danger" id="btnDel" onclick="DeleteData()">
                <i class="fa fa-lg fa-trash"></i>&nbsp;<b>Delete</b>
            </a>
        </div>
        <table id="tbHeader" class="table table-responsive">
            <thead>
                <tr>
                    <th>No</th>
                    <th>Name</th>
                    <th>Department</th>
                    <th>Position</th>
                    <th>Email</th>
                    <th>Phone</th>
                </tr>
            </thead>
        </table>
    </div>
</div>
<div id="dvLOVs"></div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let custcode = getQueryString("custcode");
    let custbranch = getQueryString("custbranch");
    //$(document).ready(function () {
    SetEvents();
    //});
    function SearchData(type) {
        switch (type) {
            case 'customer':
                SetGridCompany(path, '#tbCust', '#frmSearchCust', ReadCustomer);
                break;
        }
    }
    function ShowData() {
        $.get(path + 'master/getcompanycontact?branch=' + $('#txtBranch').val() + '&code=' + $('#txtCustCode').val(), function (r) {
            if (r.companycontact.data.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                if (isAlert==true) ShowMessage('data not found');
                return;
            }
            let h = r.companycontact.data;
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "ItemNo", title: "No" },                    
                    { data: "ContactName", title: "Name" },
                    { data: "Department", title: "Department" },
                    { data: "Position", title: "Position" },
                    { data: "EMail", title: "E-Mail" },
                    { data: "Phone", title: "Phone" }                    
                ],
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                $('#tbHeader tbody > tr').removeClass('selected');
                $(this).addClass('selected');  
                let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                ReadData(data);
            });
        });        
    }
    function ReadCustomer(dt) {
        $('#txtCustCode').val(dt.CustCode);
        $('#txtBranch').val(dt.Branch);
        ShowCustomer(path, dt.CustCode, dt.Branch, '#txtCustName');
        ShowData();
    }
    function SetEvents() {
        if (custcode !== '') {
            $('#txtCustCode').val(custcode);
            $('#txtBranch').val(custbranch);
            ShowCustomer(path, custcode, custbranch, '#txtCustName');
            ShowData();
        }
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
        });
    }
    //CRUD Functions used in HTML Java Scripts
    function DeleteData() {
        var branch = $('#txtBranch').val();
        var code = $('#txtCustCode').val();
        var item = $('#txtItemNo').val();
        ShowConfirm("Do you need to Delete " + $('#txtItemNo').val() + "?", function (ask) {
            if (ask == false) return;
            $.get(path + 'master/delcompanycontact?branch=' + branch + '&code=' + code + '&item=' + item, function (r) {
                ShowMessage(r.companycontact.result);
                ShowData();
                ClearData();
            });
        });        
    }
	function ReadData(dr){		
        $('#txtItemNo').val(dr.ItemNo);
        $('#txtDepartment').val(dr.Department);
        $('#txtPosition').val(dr.Position);
        $('#txtContactName').val(dr.ContactName);
        $('#txtEMail').val(dr.EMail);
        $('#txtPhone').val(dr.Phone);
	}
	function SaveData(){
		var obj={			
            CustCode: $('#txtCustCode').val(),
            Branch:$('#txtBranch').val(),
            ItemNo:$('#txtItemNo').val(),
            Department:$('#txtDepartment').val(),
            Position:$('#txtPosition').val(),
            ContactName:$('#txtContactName').val(),
            EMail:$('#txtEMail').val(),
            Phone:$('#txtPhone').val(),
        };
        if (obj.CustCode == '' || obj.Branch == '') {
            ShowMessage('Please select customer');
            return;
        }
        if (obj.ItemNo != "") {
            ShowConfirm("Do you need to Save " + obj.ItemNo + "?", function (ask) {
                if (ask == false) return;
                let jsonText = JSON.stringify({ data: obj });
                //ShowMessage(jsonText);
                $.ajax({
                    url: "@Url.Action("SetCompanyContact", "Master")",
                    type: "POST",
                    contentType: "application/json",
                    data: jsonText,
                    success: function (response) {
                        if (response.result.data != null) {
                            ShowData();
                            ClearData();
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
        $('#txtItemNo').val('0');
        $('#txtDepartment').val('');
        $('#txtPosition').val('');
        $('#txtContactName').val('');
        $('#txtEMail').val('');
        $('#txtPhone').val('');
	}
</script>