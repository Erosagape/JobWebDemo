@Code
    ViewBag.Title = "สร้างใบแจ้งหนี้"
End Code
<div class="panel-body">
    <div class="container">
        <div class="row">
            <div class="col-sm-4">
                <a href="#" onclick="SearchData('branch')"> Branch :</a><br />
                <input type="text" id="txtBranchCode" style="width:50px" />
                <input type="text" id="txtBranchName" style="width:200px" disabled />
            </div>
            <div class="col-sm-3">
                Job Type: <br />
                <select id="cboJobType" class="form-control dropdown"></select>
            </div>
            <div class="col-sm-3">
                Ship By:<br />
                <select id="cboShipBy" class="form-control dropdown"></select>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <a href="#" onclick="SearchData('customer')"> Customer :</a><br />
                <input type="text" id="txtCustCode" style="width:120px" />
                <input type="text" id="txtCustBranch" style="width:50px" />
                <input type="text" id="txtCustName" style="width:300px" disabled />
            </div>
            <div class="col-sm-3">
                <a href="#" onclick="SearchData('job')">Job No :</a><br />
                <input type="text" id="txtJobNo" class="form-control" />
            </div>
            <div class="col-sm-3">
                <br />
                <button class="btn btn-warning" id="btnRefresh" onclick="SetGridAdv(true)">Show</button>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <table id="tbHeader" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>JobNo</th>
                            <th>ClrNo</th>
                            <th>CustCode</th>
                            <th>Description</th>
                            <th>Cost</th>
                            <th>Advance</th>
                            <th>Charge</th>
                            <th>VAT</th>
                            <th>WHT</th>
                            <th>Net</th>
                        </tr>
                    </thead>
                </table>
                <br />
                <input type="button" class="btn btn-success" value="Create Invoice" onclick="ShowSummary()" />
            </div>
        </div>
    </div>
    <div id="dvCreate" class="modal modal-lg fade" role="dialog">
        <div class="modal-dialog-lg">
            <div class="modal-content">
                <div class="modal-header">
                    Invoice Date :
                    <input type="date" id="txtDocDate" value="@DateTime.Today.ToString("yyyy-MM-dd")" />
                    Invoice Type : 
                    <select id="cboDocType">
    <option value="IVS-">Service</option>
    <option value="IVT-">Transport</option>
    <option value="IVF-">Freight</option>
</select>
                    <a href="#" onclick="SearchData('invoice')"> Replace Invoice No :</a>
                    <input type="text" id="txtDocNo" disabled />
                    <button id="btnGen" class="btn btn-primary" onclick="ApproveData()">Save</button>
                </div>
                <div class="modal-body">

                </div>
                <div class="modal-footer">
                    <button id="btnHide" class="btn btn-danger" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>

    </div>
    <div id="dvLOVs"></div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    var user = '@ViewBag.User';
    var arr = [];
    $(document).ready(function () {
        SetEvents();
    });
    function SetEvents() {
        //Combos
        let lists = 'JOB_TYPE=#cboJobType';
        lists += ',SHIP_BY=#cboShipBy';
        loadCombos(path, lists);
        //Events
        $('#txtBranchCode').keydown(function (event) {
            if (event.which == 13) {
                $('#txtBranchName').val('');
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            }
        });
        $('#txtCustBranch').keydown(function (event) {
            if (event.which == 13) {
                $('#txtCustName').val('');
                ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
            }
        });

        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
            CreateLOV(dv, '#frmSearchJob', '#tbJob', 'Job', response, 3);
            CreateLOV(dv, '#frmSearchInv', '#tbInv', 'Cancelled Invoice', response, 3);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
        });
    }
    function SetGridAdv(isAlert) {
        arr = [];

        let w = '';
        if ($('#txtJobNo').val() !== "") {
            w = w + '&job=' + $('#txtJobNo').val();
        }
        if ($('#txtCustCode').val() !== "") {
            w = w + '&cust=' + $('#txtCustCode').val();
        }
        if ($('#cboJobType').val() !== "") {
            w = w + '&jtype=' + $('#cboJobType').val();
        }
        if ($('#cboShipBy').val() !== "") {
            w = w + '&sby=' + $('#cboShipBy').val();
        }
        $.get(path + 'acc/getclearforinv?branch=' + $('#txtBranchCode').val() + w, function (r) {
            if (r.invdetail.data.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                if (isAlert==true) alert('data not found');
                return;
            }
            let h = r.invdetail.data;
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "JobNo", title: "Job No" },
                    { data: "ClrNo", title: "Clr No" },
                    { data: "CustCode", title: "Customer" },
                    {
                        data: null, title: "Description",
                        render: function (data) {
                            return data.SICode + '-' + data.SDescription;
                        }
                    },
                    { data: "AmtCost", title: "Cost" },
                    { data: "AmtAdvance", title: "Advance" },
                    { data: "AmtCharge", title: "Charge" },
                    { data: "AmtVat", title: "VAT" },
                    { data: "Amt50Tavi", title: "WHT" },
                    { data: "AmtNet", title: "NET" }
                ],
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                if ($(this).hasClass('selected') == true) {
                    $(this).removeClass('selected');
                    let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                    RemoveData(data); //callback function from caller
                    return;
                }
                $(this).addClass('selected');
                let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                AddData(data); //callback function from caller
            });
        });
    }
    function AddData(o) {
        arr.push(o);
    }
    function RemoveData(o) {
        let idx = arr.indexOf(o);
        if (idx < 0) {
            return;
        }
        arr.splice(idx, 1);
    }
    function ApproveData() {
        if (arr.length < 0) {
            alert('no data to approve');
            return;
        }
        let dataInv = {
            BranchCode:$('#txtBranchCode').val(),
            DocNo: $('#txtDocNo').val(),
            DocType:$('#cboDocType').val(),
            DocDate: CDateTH($('#txtDocDate').val()),
            CustCode:$('#txtCustCode').val(),
            CustBranch:$('#txtCustBranch').val(),
            BillToCustCode:$('#txtCustCode').val(),
            BillToCustBranch:$('#txtCustBranch').val(),
            ContactName:'',
            EmpCode:user,
            PrintedBy:'',
            PrintedDate:null,
            PrintedTime:null,
            RefNo:'',
            VATRate:CNum(@ViewBag.PROFILE_VATRATE),
            TotalAdvance:CNum($('#txtTotalAdvance').val()),
            TotalCharge:CNum($('#txtTotalCharge').val()),
            TotalIsTaxCharge:CNum($('#txtTotalIsTaxCharge').val()),
            TotalIs50Tavi:CNum($('#txtTotalIs50Tavi').val()),
            TotalVAT:CNum($('#txtTotalVAT').val()),
            Total50Tavi:CNum($('#txtTotal50Tavi').val()),
            TotalCustAdv:CNum($('#txtTotalCustAdv').val()),
            TotalNet:CNum($('#txtTotalNet').val()),
            CurrencyCode:$('#txtCurrencyCode').val(),
            ExchangeRate:CNum($('#txtExchangeRate').val()),
            ForeignNet:CNum($('#txtForeignNet').val()),
            BillAcceptDate:null,
            BillIssueDate:null,
            BillAcceptNo:'',
            Remark1:'',
            Remark2:'',
            Remark3:'',
            Remark4:'',
            Remark5:'',
            Remark6:'',
            Remark7:'',
            Remark8:'',
            Remark9:'',
            Remark10:'',
            CancelReson:'',
            CancelProve:'',
            CancelDate:null,
            CancelTime:null,
            ShippingRemark:''
        };
        let jsonString = JSON.stringify({ data: dataApp });
        $.ajax({
            url: "@Url.Action("SetInvHeader", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data !== null) {
                    SaveDetail(response.result.data);
                }
            },
            error: function (e) {
                alert(e);
            }
        });
        return;
    }
    function SaveDetail(docno) {
        let jsonText = JSON.stringify({ data:[ arr ]});
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SaveInvDetail", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    alert(response.result.data);
                    alert(response.result.msg);
                    SetGridAdv(false);
                },
                error: function (e) {
                    alert(e);
                }
            });
    }
    function SearchData(type) {
        switch (type) {
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'job':
                SetGridJob(path, '#tbJob', '#frmSearchJob', '?branch=' + $('#txtBranchCode').val() + '&custcode=' + $('#txtCustCode').val(), ReadJob);
                break;
            case 'invoice':
                SetGridInv(path, '#tbInv', '#frmSearchInv', '?cancel=Y' ,ReadInv);
                break;
            case 'customer':
                SetGridCompany(path, '#tbCust', '#frmSearchCust', ReadCustomer);
                break;
        }
    }
    function ReadInv(dt) {
        $('#txtDocNo').val(dt.DocNo);
    }
    function ReadJob(dt) {
        $('#txtJobNo').val(dt.JNo);
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
    }
    function ReadCustomer(dt) {
        $('#txtCustCode').val(dt.CustCode);
        $('#txtCustBranch').val(dt.Branch);
        ShowCustomer(path, dt.CustCode, dt.Branch, '#txtCustName');
        $('#txtCustCode').focus();
    }
</script>