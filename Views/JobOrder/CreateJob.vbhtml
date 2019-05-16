@code
    ViewBag.Title = "Create Job"
End Code
<div Class="panel-body">
    <table>
        <tr>
            <td>
                Job Type :
                <select id="cboJobType" class="form-control dropdown" style="width:230px" tabindex="0"></select>
            </td>
            <td>
                Ship By :
                <select id="cboShipBy" class="form-control dropdown" style="width:230px" tabindex="1"></select>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                Branch<br />
                <input type="text" style="width:120px" id="txtBranchCode" tabindex="2" />
            </td>
            <td>
                <br />
                <input type="button" id="btnBrowseBranch" value="..." onclick="SearchData('branch')" />
            </td>
            <td>
                <br />
                <input type="text" style="width:300px" id="txtBranchName" disabled />
            </td>
        </tr>
        <tr>
            <td>
                พนักงาน CS<br />
                <input type="text" id="txtCSCode" style="width:120px" tabindex="3" />
            </td>
            <td>
                <br />
                <input type="button" id="btnBrowseCS" value="..." onclick="SearchData('user')" />
            </td>
            <td>
                ชื่อพนักงาน<br />
                <input type="text" id="txtCSName" style="width:300px" disabled />
            </td>
        </tr>
        <tr>
            <td>
                <a href="/Master/Customers">รหัสลูกค้า</a><br />
                <input type="text" style="width:80px" id="txtCustCode" tabindex="4" />
                <input type="text" style="width:40px" id="txtCustBranch" tabindex="5" />
            </td>
            <td>
                <br />
                <input type="button" id="btnCust" value="..." onclick="SearchData('customer')" />
            </td>
            <td>
                ชื่อลูกค้า<br />
                <input type="text" style="width:300px" id="txtCustName" disabled />
            </td>
        </tr>
        <tr>
            <td>
                สถานที่วางบิล<br />
                <input type="text" id="txtConsignee" style="width:120px" tabindex="6" />
            </td>
            <td>
                <br />
                <input type="button" id="btnBrowseCons" value="..." onclick="SearchData('consignee')" />
            </td>
            <td>
                ชื่อสถานที่วางบิล<br />
                <input type="text" id="txtConsignName" style="width:300px" disabled />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                ผู้ติดต่อ<br />
                <input type="text" id="txtContactPerson" style="width:200px" tabindex="7" />
            </td>
            <td>
                <br />
                <input type="button" id="btnBrowseContact" value="..." onclick="SearchData('contact')" />
            </td>
            <td>
                ใบเสนอราคาเลขที่้<br />
                <input type="text" style="width:150px" id="txtQNo" tabindex="8" />
                <input type="text" style="width:50px" id="txtRevise" tabindex="9" />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                Customer Invoice<br />
                <input type="text" id="txtCustInv" style="width:230px" tabindex="10" />
            </td>
            <td>
                Customer PO No<br />
                <input type="text" style="width:230px" id="txtCustPO" tabindex="11" />
            </td>
        </tr>
        <tr>
            <td>
                HAWB or H B/L <br />
                <input type="text" id="txtHAWB" style="width:230px" tabindex="12" />
            </td>
            <td>
                MAWB or M B/L<br />
                <input type="text" style="width:230px" id="txtMAWB" tabindex="13" />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                Copy ข้อมูลจาก Job<br />
                <input type="text" id="txtCopyFromJob" style="width:200px" disabled />
                <input type="button" id="btnBrowseJob" value="..." onclick="SearchData('job')" />
            </td>
            <td>
                วันที่เปิดงาน<br />
                <input type="date" style="width:200px" id="txtJobDate" tabindex="14" />
            </td>
        </tr>
        <tr>
            <td>
                <input id="chkTransferCost" type="checkbox" />
                โอนข้อมูลค่าบริการและค่าใช้จ่ายมาด้วย
            </td>
            <td>
                <input type="button" class="btn btn-success" id="btnCreateJob" onclick="CreateJob()" tabindex="15" value="สร้างหมายเลขงานใหม่" />
            </td>
        </tr>
    </table>
</div>
<div id="frmShowJob" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div id="dvResp" class="modal-header">
                Save Complete!
            </div>
            <div class="modal-body" style="text-align:center">
                <input id="txtJNo" type="text" style="position:center;font-size:20px;text-align:center" disabled />
            </div>
            <div class="modal-footer">
                <button class="btn btn-primary" id="btnViewJob" onclick="OpenJob()">View Job</button>
                <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>
<div id="dvLOVs"></div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    //define letiables
    const path = '@Url.Content("~")';
    //$(document).ready(function () {
        CheckParam();
        SetLOVs();
        SetEvents();
        SetEnterToTab();
    //});
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
    function SetEvents() {
        $('#txtBranchCode').focusout(function () {
            ShowBranch(path,$('#txtBranchCode').val(), '#txtBranchName');
        });
        $('#txtCSCode').focusout(function () {
            ShowUser(path,$('#txtCSCode').val(), '#txtCSName');
        });
        $('#txtCustBranch').focusout(function () {
            ShowCustomer(path,$('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
        });
        $('#txtConsignee').focusout(function () {
            ShowCustomer(path,$('#txtConsignee').val(), $('#txtCustBranch').val(), '#txtConsignName');
        });
    }
    function CheckParam() {
        //read query string parameters
        let br = getQueryString('Branch');
        let jt = getQueryString('JType');
        let sb = getQueryString('SBy');        
        if (br !== undefined) {
            $('#txtBranchCode').val(br);
        } else {
            $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        }
        ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
        if (jt == undefined) jt = "01";
        if (sb == undefined) sb = "01";
        //Combos
        let lists = 'JOB_TYPE=#cboJobType|'+jt+',SHIP_BY=#cboShipBy|' +sb;
        loadCombos(path, lists);

        $('#cboJobType').val(jt);
        $('#cboShipBy').val(sb);
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
            CreateLOV(dv,'#frmSearchContact','#tbContact','Contact Person',response,1);
        });
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
        ShowCustomer(path,dt.CustCode, dt.Branch, '#txtCustName');
        $('#txtCustCode').focus();
    }
    function ReadConsignee(dt) {
        $('#txtConsignee').val(dt.CustCode);
        $('#txtConsBranch').val(dt.Branch);
        ShowCustomer(path,dt.CustCode, dt.Branch, '#txtConsignName');
        $('#txtConsignee').focus();
    }
    function ReadContactName(dt) {
        $('#txtContactPerson').val(dt.val);
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
                SetGridCompany(path, '#tbCust', '#frmSearchCust', ReadCustomer);
                break;
            case 'consignee':
                SetGridCompany(path, '#tbCons', '#frmSearchCons', ReadConsignee);
                break;
            case 'contact':
                SetGridContactName(path, '#tbContact', '#frmSearchContact', ReadContactName);
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
    function CreateJob() {
        if ($('#txtBranchName').val() === '') {
            alert('Please select branch before create job');
            $('#txtBranchCode').focus();
            return;
        }
        if ($('#cboJobType').val() === '') {
            alert('Please select job type before create job');
            $('#cboJobType').focus();
            return;
        }
        if ($('#cboShipBy').val() === '') {
            alert('Please select ship by before create job');
            $('#cboShipBy').focus();
            return;
        }
        if ($('#txtCSName').val() === '') {
            alert('Please select CS before create job');
            $('#txtCSCode').focus();
            return;
        }
        if ($('#txtCustName').val() === '') {
            alert('Please select customer before create job');
            $('#txtCustCode').focus();
            return;
        }
        if ($('#txtCustInv').val() === '') {
            alert('Please select customer invoice before create job');
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
                    alert(strParam);
                    return;
                }
                if (r.job.status == "Y") {
                    let data = r.job.data;

                    data.CustCode = $('#txtCustCode').val();
                    data.CustBranch = $('#txtCustBranch').val();
                    data.CSCode = $('#txtCSCode').val();
                    data.DocDate = CDateTH($('#txtJobDate').val());
                    data.consigneecode = $('#txtConsignee').val();
                    data.CustContactName = $('#txtContactPerson').val();
                    data.QNo = $('#txtQNo').val();
                    data.Revise = $('#txtRevise').val();
                    data.InvNo = $('#txtCustInv').val();
                    data.CustRefNO = $('#txtCustPO').val();
                    data.HAWB = $('#txtHAWB').val();
                    data.MAWB = $('#txtMAWB').val();

                    PostData(data);
                } else {
                    alert(r.job.result);
                }
                return;
                //alert(r.job.result + '=>' + data.JNo);
            });
    }
    function OpenJob() {
        window.location.href='ShowJob?BranchCode=' + $('#txtBranchCode').val() + '&JNo=' + $('#txtJNo').val();
    }
    function PostData(obj) {
        let jsonString = JSON.stringify({ data: obj });
        //alert(jsonString);
        $.ajax({
            url: "@Url.Action("SaveJobData", "JobOrder")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {                
                //alert(response);
                $('#txtJNo').val(obj.JNo);
                $('#dvResp').html(response);
                $('#frmShowJob').modal('show');
            }
        });
    }
</script>

