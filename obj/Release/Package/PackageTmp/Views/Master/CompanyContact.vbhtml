@Code
    ViewBag.Title = "CompanyContact"
End Code
<div class="panel-body">
    <div id="dvForm" class="container">
        <div class="row">
            <div class="col-sm-12">
                Customer :<br />
                <input type="text" id="txtCustCode" style="width:120px" disabled />
                <input type="text" id="txtBranch" style="width:50px" disabled />
                <button id="btnBrowseCust" onclick="SearchData('customer')">...</button>
                <input type="text" id="txtCustName" style="width:100%" disabled />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-2">
                No :<br /><input type="text" id="txtItemNo" class="form-control" value="0" disabled>
                <input type="button" id="btnAdd" value="Add" class="btn btn-default" onclick="ClearData()" />
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
            <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save</button>
            <button id="btnDel" class="btn btn-danger" onclick="DeleteData()">Delete</button>
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
                if (isAlert==true) alert('data not found');
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
        }
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
        });
    }
    //CRUD Functions used in HTML Java Scripts
    function DeleteData() {
        let branch = $('#txtBranch').val();
        let code = $('#txtCustCode').val();
        let item = $('#txtItemNo').val();
        let ask = confirm("Do you need to Delete " + item + "?");
        if (ask == false) return;
        $.get(path + 'master/delcompanycontact?branch=' + branch + '&code=' + code + '&item=' + item, function (r) {
                alert(r.companycontact.result);
                ClearData();
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
		let obj={			
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
            alert('Please select customer');
            return;
        }
        if (obj.ItemNo != "") {
            let ask = confirm("Do you need to Save " + obj.ItemNo + "?");
            if (ask == false) return;
            let jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
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
                    alert(response.result.msg);
                },
                error: function (e) {
                    alert(e);
                }
            });
        } else {
            alert('No data to save');
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