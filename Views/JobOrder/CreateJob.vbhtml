@Code
    ViewBag.Title = "Create Job"
End Code
    <div Class="panel-body">
        <div class="row">
            <div class="col-sm-6" style="display:flex">
                <div style="width:30%">
                    <label id="lblJobType" style="display:block;width:100%;">Job Type</label>
                </div>
                <div style="width:70%">
                    <select id="cboJobType" class="form-control dropdown" style="width:100%" tabindex="0"></select>
                </div>                               
            </div>
            <div class="col-sm-6" style="display:flex">
                <div style="width:30%">
                    <label id="lblShipBy" style="display:block;width:100%;">Ship By</label>
                </div>
                <div style="width:70%">
                    <select id="cboShipBy" class="form-control dropdown" style="width:100%" tabindex="1"></select>
                </div>                                
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6" style="display:flex">
                <div style="width:30%">
                    <label id="lblBranch" style="display:block;width:100%;">Branch</label>
                </div>
                <div style="display:flex;width:70%">
                    <input type="text" class="form-control" style="width:60px" id="txtBranchCode" tabindex="2" />
                    <input type="button" class="btn btn-default" id="btnBrowseBranch" value="..." onclick="SearchData('branch')" />
                    <input type="text" class="form-control" style="width:100%" id="txtBranchName" disabled />
                </div>
            </div>
            <div class="col-sm-6" style="display:flex">
                <div style="width:30%">
                    <label id="lblCSCode" style="display:block;width:100%">CS Code:</label>
                </div>
                <div style="display:flex;width:70%">                    
                    <input type="text" class="form-control" id="txtCSCode" style="width:120px" tabindex="3" />
                    <input type="button" class="btn btn-default" id="btnBrowseCS" value="..." onclick="SearchData('user')" />
                    <input type="text" class="form-control" id="txtCSName" style="width:100%" disabled />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6" style="display:flex">                
                <div style="width:30%">
                    <a href="/Master/Customers"><label id="lblCustCode" style="display:block;width:100%;">Customer</label></a>
                </div>
                <div style="display:flex;width:70%">                    
                    <input type="text" class="form-control" style="width:80px" id="txtCustCode" tabindex="4" />
                    <input type="text" class="form-control" style="width:40px" id="txtCustBranch" tabindex="5" />
                    <input type="button" class="btn btn-default" id="btnCust" value="..." onclick="SearchData('customer')" />
                    <input type="text" class="form-control" style="width:100%" id="txtCustName" disabled />
                </div>
            </div>
            <div class="col-sm-6" style="display:flex">                
                <div style="width:30%">
                    <label id="lblBillingPlace" style="display:block;width:100%;">Billing Place</label>
                </div>
                <div style="display:flex;width:70%">                    
                    <input type="text" class="form-control" id="txtConsignee" style="width:120px" tabindex="6" />
                    <input type="button" class="btn btn-default" id="btnBrowseCons" value="..." onclick="SearchData('consignee')" />
                    <input type="text" class="form-control" id="txtConsignName" style="width:100%" disabled />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-6" style="display:flex">                
                <div style="width:30%">
                    <label id="lblContactName" style="display:block;width:100%;">Contact</label>
                </div>
                <div style="display:flex;width:70%">                    
                    <input type="text" class="form-control" id="txtContactPerson" style="width:100%" tabindex="7" />
                    <input type="button" class="btn btn-default" id="btnBrowseContact" value="..." onclick="SearchData('contact')" />
                </div>
            </div>
            <div class="col-sm-6" style="display:flex">                
                <div style="width:30%">
                    <label id="lblQuotation" style="display:block;width:100%;">Quotation</label>
                </div>
                <div style="display:flex;width:70%">                    
                    <input type="text" class="form-control" style="width:100%" id="txtQNo" tabindex="8" />
                    <input type="text" class="form-control" style="width:50px" id="txtRevise" tabindex="9" />
                    <input type="hidden" id="txtManagerCode" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6" style="display:flex">                
                <div style="width:30%">
                    <label id="lblCustInv" style="display:block;width:100%;color:red">Commercial Invoice</label>
                </div>
                <div style="display:flex;width:70%">                    
                    <input type="text" class="form-control" id="txtCustInv" style="width:100%" tabindex="10" />
                </div>
            </div>
            <div class="col-sm-6" style="display:flex">                
                <div style="width:30%">
                    <label id="lblPoNo" style="display:block;width:100%;">PO/Customer Reference</label>
                </div>
                <div style="display:flex;width:70%">
                    <input type="text" class="form-control" style="width:100%" id="txtCustPO" tabindex="11" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6" style="display:flex">                
                <div style="width:30%">
                    <label id="lblHAWB" style="display:block;width:100%;">House BL/AWB</label>
                </div>
                <div style="display:flex;width:70%">                    
                    <input type="text" class="form-control" id="txtHAWB" style="width:100%" tabindex="12" />
                </div>
            </div>
            <div class="col-sm-6" style="display:flex">                
                <div style="width:30%">
                    <label id="lblMAWB" style="display:block;width:100%;">Master BL/AWB</label>
                </div>
                <div style="display:flex;width:70%">                    
                    <input type="text" class="form-control" style="width:100%" id="txtMAWB" tabindex="13" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6" style="display:flex">                
                <div style="width:30%">
                    <label id="lblCopyFrom" style="display:block;width:100%;">Copy From</label>
                </div>
                <div style="display:flex;width:70%">                    
                    <input type="text" class="form-control" id="txtCopyFromJob" style="width:100%" disabled />
                    <input type="button" class="btn btn-default" id="btnBrowseJob" value="..." onclick="SearchData('job')" />
                </div>
            </div>
            <div class="col-sm-6" style="display:flex">                
                <div style="width:30%">
                    <label id="lblJobDate" style="display:block;width:100%;">Job Date</label>
                </div> 
                <div style="display:flex;width:40%">                    
                    <input type="date" class="form-control" style="width:100%" id="txtJobDate" tabindex="14" />
                </div>
            </div>
        </div>
        <p>
            <a href="#" class="btn btn-success" id="btnCreateJob" onclick="CreateJob()">
                <i class="fa fa-lg fa-save"></i>&nbsp;<b><label id="lblCreateJob">Create Job</label></b>
            </a>
        </p>
    </div>
    <div id="frmShowJob" class="modal fade" data-backdrop="static" data-keyboard="false">
        <div class="vertical-alignment-helper">
            <div class="modal-dialog vertical-align-center">
                <div class="modal-content">
                    <div id="dvResp" class="modal-header">
                        <label id="lblSaveComplete">Save Complete!</label>
                    </div>
                    <div class="modal-body" style="text-align:center">
                        <input id="txtJNo" type="text" style="position:center;font-size:20px;text-align:center;color:red" disabled />
                    </div>
                    <div class="modal-footer">
                        <button class="btn btn-primary" id="btnViewJob" onclick="OpenJob()">View</button>
                        <button type="button" class="btn btn-danger" data-dismiss="modal">X</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="dvLOVs"></div>
    <script src="~/Scripts/Func/combo.js"></script>
    <script type="text/javascript">
    //define letiables
    const path = '@Url.Content("~")';
    const user = '@ViewBag.User';
    //$(document).ready(function () {
        CheckParam();
        SetLOVs();
        SetEvents();
        SetEnterToTab();
    //});
    function CheckParam() {
        //read query string parameters
        let br = getQueryString('Branch');
        let jt = getQueryString('JType');
        let sb = getQueryString('SBy');
        if (br !== "") {
            $('#txtBranchCode').val(br);
            ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
        } else {
            $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
            $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');
        }
        if (jt == "") jt = "01";
        if (sb == "") sb = "01";
        //Combos
        let lists = 'JOB_TYPE=#cboJobType|'+jt+',SHIP_BY=#cboShipBy|' +sb;
        loadCombos(path, lists);

        $('#cboJobType').val(jt);
        $('#cboShipBy').val(sb);
        $('#txtCSCode').val(user);
        ShowUser(path, $('#txtCSCode').val(), '#txtCSName');
        $('#txtJobDate').val(GetToday());
    }
    function SetLOVs() {
        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv,'#frmSearchCust','#tbCust','Customers',response,3);
            //Consignee
            CreateLOV(dv,'#frmSearchCons','#tbCons','Consignees',response,3);
            //Job
            CreateLOV(dv,'#frmSearchJob','#tbJob','Job List',response,3);
            //2 Fields
            //Users
            CreateLOV(dv,'#frmSearchUser','#tbUser','Users',response,2);
            //Branch
            CreateLOV(dv,'#frmSearchBranch','#tbBranch','Branch',response,2);
            //1 Fields
            //Contact Name
            CreateLOV(dv,'#frmSearchContact','#tbContact','Contact Person',response,3);
        });
    }
    function SetEvents() {
        $('#txtBranchCode').focusout(function () {
            ShowBranch(path,$('#txtBranchCode').val(), '#txtBranchName');
        });
        $('#txtCSCode').focusout(function () {
            ShowUser(path,$('#txtCSCode').val(), '#txtCSName');
        });
        $('#txtCustCode').keydown(function (e) {
            if (e.which == 13) {
                $('#txtConsignee').val('');
                CallBackQueryCustomerSingle(path, $('#txtCustCode').val(), function (dr) {
                    $('#txtCustBranch').val(dr.Branch);
                    $('#txtCustName').val(dr.NameThai);
                    $('#txtConsignee').val(dr.BillToCustCode);
                    ReadCustRelateData();
                });
            }
        });
        $('#txtCustBranch').keydown(function (ev) {
            if (ev.which == 13) {
                ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
            }
        });
        $('#txtConsignee').focusout(function () {
            ShowCompany(path, $('#txtConsignee').val(), '#txtConsignName');
        });
    }
    function SetEnterToTab() {
        //Set enter to tab
        $("input[tabindex], select[tabindex], textarea[tabindex]").each(function () {
            $(this).on("keypress", function (e) {
                if (e.keyCode === 13) {
                    let idx = (this.tabIndex + 1);
                    let nextElement = $('[tabindex="' + idx + '"]');
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
        $('#txtBranchCode').focus();
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
    }
    function ReadUser(dt) {
        $('#txtCSCode').val(dt.UserID);
        $('#txtCSName').val(dt.TName);
        $('#txtCSCode').focus();
    }
    function ReadCustomer(dt) {
        $('#txtCustCode').val(dt.CustCode);
        $('#txtCustBranch').val(dt.Branch);
        ShowCustomer(path, dt.CustCode, dt.Branch, '#txtCustName');
        if (dt.BillToCustCode !== '') {
            $('#txtConsignee').val(dt.BillToCustCode);            
        } else {
            $('#txtConsignee').val(dt.CustCode);            
        }
        ReadCustRelateData();
        $('#txtCustInv').focus();
    }
    function ReadCustRelateData() {
        $('#txtContactPerson').val('');
        $('#txtQNo').val('');
        $('#txtRevise').val('');
        $('#txtManagerCode').val('');
        ShowCompany(path, $('#txtConsignee').val(), '#txtConsignName');        
        GetContact();
        GetQuotation();
    }
    function ReadConsignee(dt) {
        $('#txtConsignee').val(dt.CustCode);
        $('#txtConsBranch').val(dt.Branch);
        ShowCustomer(path,dt.CustCode, dt.Branch, '#txtConsignName');
        $('#txtConsignee').focus();
    }
    function ReadContactName(dt) {
        $('#txtContactPerson').val(dt.ContactName);
        $('#txtContactPerson').focus();
    }
    function ReadJob(dt) {
        $('#txtCopyFromJob').val(dt.JNo);
    }
    function SearchData(type) {
        switch (type) {
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'user':
                SetGridUser(path, '#tbUser', '#frmSearchUser', ReadUser);
                break;
            case 'customer':
                SetGridCompanyByGroup(path, '#tbCust','CUSTOMERS,INTERNAL,PERSON', '#frmSearchCust', ReadCustomer);
                break;
            case 'consignee':
                SetGridCompanyByGroup(path, '#tbCons','CONSIGNEE' ,'#frmSearchCons', ReadConsignee);
                break;
            case 'contact':
                let w = '?Branch=' + $('#txtCustBranch').val() + '&Code=' + $('#txtCustCode').val();
                SetGridCustContact(path, '#tbContact', w,'#frmSearchContact', ReadContactName);
                break;
            case 'job':
                SetGridJob(path, '#tbJob', '#frmSearchJob', GetParam() , ReadJob);
                break;
        }
    }
    function GetParam() {
        let strParam = '?';
        strParam += 'Branch=' + $('#txtBranchCode').val();
        strParam += '&JType=' + $('#cboJobType').val().substr(0, 2);
        strParam += '&SBy=' + $('#cboShipBy').val().substr(0, 2);
        strParam += '&CustCode=' + $('#txtCustCode').val();
        return strParam;
    }
    function GetContact() {
        let cust = $('#txtCustCode').val();
        $.get(path + 'Master/GetCompanyContact?code=' + cust)
            .done(function (r) {
                if (r.companycontact.data.length > 0) {
                    $('#txtContactPerson').val(r.companycontact.data[0].ContactName);
                }
            });
    }
    function GetQuotation() {
        let branch = $('#txtBranchCode').val();
        let cust = $('#txtCustCode').val();
        let jtype = $('#cboJobType').val();
        let sby = $('#cboShipBy').val();
        $.get(path + 'JobOrder/GetQuotationGrid?branch=' + branch + '&cust=' + cust + '&jtype=' + jtype + '&sby=' + sby + '&status=1')
            .done(function (r) {
                if (r.quotation.data.length > 0) {
                    $('#txtQNo').val(r.quotation.data[0].QNo);
                    $('#txtRevise').val(r.quotation.data[0].SeqNo);
                    $('#txtManagerCode').val(r.quotation.data[0].ManagerCode);
                }
            });
    }
    function CreateJob() {
        if ($('#txtBranchName').val() === '') {
            ShowMessage('Please select branch before create job');
            $('#txtBranchCode').focus();
            return;
        }
        if ($('#cboJobType').val() === '') {
            ShowMessage('Please select job type before create job');
            $('#cboJobType').focus();
            return;
        }
        if ($('#cboShipBy').val() === '') {
            ShowMessage('Please select ship by before create job');
            $('#cboShipBy').focus();
            return;
        }
        if ($('#txtCSName').val() === '') {
            ShowMessage('Please select CS before create job');
            $('#txtCSCode').focus();
            return;
        }
        if ($('#txtCustName').val() === '') {
            ShowMessage('Please select customer before create job');
            $('#txtCustCode').focus();
            return;
        }
        if ($('#txtCustInv').val() === '') {
            ShowMessage('Please select customer invoice before create job');
            $('#txtCustInv').focus();
            return;
        }
        //if pass every checked
        let strParam = path + 'JobOrder/GetNewJob?';
        strParam += 'Branch=' + $('#txtBranchCode').val();
        strParam += '&JType=' + $('#cboJobType').val().substr(0,2);
        strParam += '&SBy=' + $('#cboShipBy').val().substr(0, 2);
        if ($('#txtCopyFromJob').val() !== '') {
            strParam += '&CopyFrom=' + $('#txtCopyFromJob').val();
        }
        strParam += '&Cust=' + $('#txtCustCode').val() + '|' + $('#txtCustBranch').val();
        strParam += '&Inv=' + $('#txtCustInv').val();
        $.get(strParam)
            .done(function (r) {
                if (r.length == 0) {
                    ShowMessage(strParam);
                    return;
                }
                if (r.job.status == "Y") {
                    let data = r.job.data;
                    data.CustCode = $('#txtCustCode').val();
                    data.CustBranch = $('#txtCustBranch').val();
                    data.CSCode = $('#txtCSCode').val();
                    data.DocDate = CDateTH($('#txtJobDate').val());
                    data.Consigneecode = $('#txtConsignee').val();
                    data.CustContactName = $('#txtContactPerson').val();
                    data.QNo = $('#txtQNo').val();
                    data.Revise = CNum($('#txtRevise').val());
                    data.InvNo = $('#txtCustInv').val();
                    data.CustRefNO = $('#txtCustPO').val();
                    data.HAWB = $('#txtHAWB').val();
                    data.MAWB = $('#txtMAWB').val();
                    data.ManagerCode = $('#txtManagerCode').val();
                    PostData(data);
                } else {
                    ShowMessage(r.job.result);
                }
                return;
                //ShowMessage(r.job.result + '=>' + data.JNo);
            });
    }
    function OpenJob() {
        window.location.href='ShowJob?BranchCode=' + $('#txtBranchCode').val() + '&JNo=' + $('#txtJNo').val();
    }
    function PostData(obj) {
        let jsonString = JSON.stringify({ data: obj });
        //ShowMessage(jsonString);
        $.ajax({
            url: "@Url.Action("SetJobData", "JobOrder")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (r) {
                //ShowMessage(response);
                $('#txtJNo').val(obj.JNo);
                $('#dvResp').html(r.msg);
                $('#frmShowJob').modal('show');
            }
        });
    }
            </script>

