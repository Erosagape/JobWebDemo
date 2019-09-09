@Code
    ViewBag.Title = "Tracking Status"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
    <div class="row">
        <div class="col-sm-4">
            Branch
            <br />
            <div style="display:flex;flex-direction:row">
                <input type="text" class="form-control" id="txtBranchCode" style="width:15%" disabled />
                <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                <input type="text" class="form-control" id="txtBranchName" style="width:65%" disabled />
            </div>
        </div>
        <div class="col-sm-5">
            Customer Tax-ID:
            <br />
            <div style="display:flex;flex-direction:row">
                <input type="text" class="form-control" id="txtTaxNumber" style="width:30%" />
                <input type="text" class="form-control" id="txtCustName" style="width:70%" disabled />
            </div>
        </div>
        <div class="col-sm-3">
            Status:
            <br/>
            <select id="cboStatus" class="form-control dropdown"></select> 
        </div>
    </div>
    <a href="#" class="btn btn-primary" id="btnShow" onclick="RefreshGrid()">
        <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Show</b>
    </a>
    <table id="tbDetail" class="table table-responsive">
        <thead>
            <tr>
                <th>REFERENCE</th>
                <th class="all">JOB NO</th>
                <th class="desktop">PREPARING</th>
                <th class="desktop">AUTHORIZED</th>
                <th class="desktop">CUSTOMS READY</th>
                <th class="desktop">DEPARTURE</th>
                <th class="desktop">ARRIVAL</th>
                <th class="desktop">LOADING</th>
                <th class="desktop">DELIVERED</th>
                <th class="desktop">BILLED</th>
                <th class="desktop">STATUS</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
<div id="dvLOVs"></div>
<script type="text/javascript">
    let path = '/';
    ShowWait();
    QuickCallback(function () {
        CloseWait();
        SetLOVs();
    });
    $('#txtTaxNumber').focusout(function () {
        QuickCallback(function () {
            ShowCompanyByTax(path, $('#txtTaxNumber').val(), '#txtCustName');
        });
    });
    function SetLOVs() {
        $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response,4);
        });
        let lists = 'JOB_STATUS=#cboStatus';
        loadCombos(path, lists);
    }
    function SearchData(type) {
        switch (type) {
            case 'branch':
                QuickCallback(function () {
                    SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                });
                break;
        }
    }
    function RefreshGrid() {
        ShowWait();
        QuickCallback(function () {
            CloseWait();
            let branch = $('#txtBranchCode').val();
            let taxno = $('#txtTaxNumber').val();
            let status = $('#cboStatus').val();
            let opt = '';
            if (status !== '') {
                opt += '&Status=' + status;
            }
            $('#tbDetail').DataTable({
                ajax: {
                    url: '/joborder/gettrackingreport?Branch=' + branch + '&TaxNumber=' + taxno + opt, //web service ที่จะ call ไปดึงข้อมูลมา
                    dataSrc: 'transport.data'
                },
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "InvNo", title: "CUST.INV" },
                    {
                        data: null, title: "JOB",
                        render: function (data) {
                            let html = data.JNo;
                            html += '<br/>' + CDateEN(data.DocDate);
                            return html;
                        }
                    },
                    {
                        data: null, title: "PREPARING",
                        render: function (data) {
                            let html = '';
                            if (data.InvProduct !== null) data.InvProduct + '<br/>';
                            if (data.InvProductQty > 0) html += data.InvProductQty + ' ' + data.InvProductUnit + '<br/>';
                            if (data.TotalGW > 0) html += data.TotalGW + ' ' + data.GWUnit + '<br/>';
                            return html;
                        }
                    },
                    {
                        data: null, title: "AUTHORIZED",
                        render: function (data) {
                            let html = '';
                            if (data.DeclareNumber !== null) {
                                html += data.DeclareNumber;
                            } else {
                                if (data.ImExDate !== null) {
                                    html += 'EDI:' + CDateEN(data.ImExDate);
                                } else {
                                    html += 'WAIT EDI';
                                }
                            }
                            if (data.ClearDate !== null) {
                                if (html !== '') html += '<br/>';
                                html += CDateEN(data.ClearDate);
                            }
                            return html;
                        }
                    },
                    {
                        data: null, title: "CUSTOMS READY",
                        render: function (data) {
                            let html = '';
                            if (data.DutyAmount > 0) {
                                html += 'DUTY=' + data.DutyAmount + ' THB';
                            }
                            if (data.DutyDate !== null) {
                                if (html !== '') html += '<br/>';
                                html += CDateEN(data.DutyDate);
                            }
                            return html;
                        }
                    },
                    {
                        data: null, title: "DEPARTURE",
                        render: function (data) {
                            let html = '';
                            if (data.InvFCountry !== null) html += data.InvFCountry;
                            if (data.JobType == 1) {
                                if (data.InvInterPort !== null) html += '(' + data.InvInterPort + ')';
                                if (data.VesselName !== null) html += '<br/>' + data.VesselName;
                            } else {
                                if (data.ClearPort !== null) html += '(' + data.ClearPort + ')';
                            }
                            if (data.ETDDate !== null) {
                                if (html !== '') html += '<br/>';
                                html += CDateEN(data.ETDDate);
                            }
                            return html;
                        }
                    },
                    {
                        data: null, title: "ARRIVAL",
                        render: function (data) {
                            let html = '';
                            if (data.InvCountry !== null) html += data.InvCountry;
                            if (data.JobType !== 1) {
                                if (data.InvInterPort !== null) html += '(' + data.InvInterPort + ')';
                            } else {
                                if (data.ClearPort !== null) html += '(' + data.ClearPort + ')';
                                if (data.VesselName !== null) html += '<br/>' + data.VesselName;
                            }
                            if (data.ETADate !== null) {
                                if (html !== '') html += '<br/>';
                                html += CDateEN(data.ETADate);
                            }
                            return html;
                        }
                    },
                    {
                        data: null, title: "LOADING",
                        render: function (data) {
                            let html = ''
                            if (data.TruckNO !== null) html += 'TRK:' + data.TruckNO + ' ';
                            if (data.TruckType !== null) html += '(' + data.TruckType + ')<br/>';
                            if (data.CTN_SIZE !== null) html += data.CTN_SIZE + '<br/>';
                            if (data.CTN_NO !== null) html += 'CTN:' + data.CTN_NO + '';
                            if (data.SealNumber !== null) html += '#' + data.SealNumber + '';
                            if (data.LoadDate !== null) {
                                if (html !== '') html += '<br/>';
                                html += CDateEN(data.LoadDate);
                            }
                            return html;
                        }
                    },
                    {
                        data: null, title: "DELIVERED",
                        render: function (data) {
                            let html = '';
                            if (data.DeliveryNo !== null) html += 'DO:' + data.DeliveryNo + '<br/>';
                            if (data.ContactName !== null) html += 'TO:' + data.ContactName + '<br/>';
                            if (data.UnloadFinishDate !== null) {
                                html += CDateEN(data.UnloadFinishDate) + '<br/>';
                            } else {
                                if (data.EstDeliverDate !== null) {
                                    html += 'EST:' + CDateEN(data.EstDeliverDate) + '<br/>';
                                }
                            }
                            if (data.ProductQty > 0) html += 'QTY:' + data.ProductQty + ' ' + data.ProductUnit;
                            return html;
                        }
                    },
                    {
                        data: null, title: "BILLED",
                        render: function (data) {
                            let html = 'FROM:' + data.consigneecode + '<br/>';
                            if (data.BillToCustCode !== null) html += 'TO:' + data.BillToCustCode + '<br/>';
                            return html;
                        }
                    },
                    {
                        data: null, title: "STATUS",
                        render: function (data) {
                            let html = 'STATUS:' + CCode(data.JobStatus);
                            if (data.CloseJobDate !== null) {
                                html += '<br/>CLOSED:' + CDateEN(data.CloseJobDate);
                            }
                            return html;
                        }
                    }
                ],
                destroy: true, //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                responsive:true
            });
        });
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
    }
</script>