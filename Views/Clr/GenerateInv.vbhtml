﻿@Code
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
                    <input type="text" id="txtJobNo" class="form-control" disabled />
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
                    <input type="button" class="btn btn-default" value="Reset Data" onclick="ResetData()" />
                </div>
            </div>
        </div>
        <div id="dvCreate" class="modal modal-lg fade">
            <div class="modal-dialog-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <table>
                            <tr>
                                <td>
                                    Invoice Date :<br />
                                    <input type="date" id="txtDocDate" value="@DateTime.Today.ToString("yyyy-MM-dd")" />
                                </td>
                                <td>
                                    Invoice Type :<br />
                                    <select id="cboDocType">
                                        <option value="IVS-">Service</option>
                                        <option value="IVT-">Transport</option>
                                        <option value="IVF-">Freight</option>
                                    </select>

                                </td>
                                <td>
                                    <a href="#" onclick="SearchData('invoice')"> Replace Invoice No :</a><br />
                                    <input type="text" id="txtDocNo" disabled />
                                </td>
                                <td>
                                    <br />
                                    <input type="button" onclick="PrintInvoice()" class="btn btn-success" value="Print Invoice" />
                                </td>
                            </tr>
                        </table>
                        <button id="btnHide" class="btn btn-danger" data-dismiss="modal">Close</button>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-sm-4">
                                <table>
                                    <tr>
                                        <td>
                                            <a href="#" onclick="SearchData('chequecust')">Customer Cheque Used</a> <br />
                                            <input type="text" id="txtChqNo" class="form-control" disabled />
                                        </td>
                                        <td>
                                            Cheque Amount<br />
                                            <input type="number" id="txtChqAmount" class="form-control" />
                                        </td>
                                        <td>
                                            <br />
                                            <input type="button" id="btnAddCheque" value="Add" class="btn" onclick="AddCheque()" />
                                        </td>
                                    </tr>
                                </table>
                                <b>Cheque Used</b><br />
                                <table id="tbCheque" class="table table-responsive">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>Cheque No</th>
                                            <th>Amount</th>
                                        </tr>
                                    </thead>
                                    <tbody></tbody>
                                </table>
                            </div>
                            <div class="col-sm-6">
                                <b>Costing of Invoice:</b><br />
                                <table id="tbCost" style="width:100%;">
                                    <thead>
                                        <tr>
                                            <th>Job No</th>
                                            <th>Description</th>
                                            <th>SlipNo</th>
                                            <th>Expense</th>
                                            <th>VAT</th>
                                            <th>WH-Tax</th>
                                            <th>Net</th>
                                        </tr>
                                    </thead>
                                    <tbody></tbody>
                                </table>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-4">
                                <b>Invoice Summary:</b><br />
                                <table style="width:100%">
                                    <tr><td>Advance </td><td><input type="text" id="txtTotalAdvance" disabled /></td></tr>
                                    <tr><td>Charge</td><td><input type="text" id="txtTotalCharge" disabled /></td></tr>
                                    <tr><td>Vatable</td><td><input type="text" id="txtTotalIsTaxCharge" disabled /></td></tr>
                                    <tr><td>Taxable</td><td><input type="text" id="txtTotalIs50Tavi" disabled /></td></tr>
                                    <tr><td>VAT</td><td><input type="text" id="txtTotalVat" disabled /></td></tr>
                                    <tr><td>After VAT</td><td><input type="text" id="txtTotalAfter" disabled /></td></tr>
                                    <tr><td>WHT</td><td><input type="text" id="txtTotal50Tavi" disabled /></td></tr>
                                    <tr><td>After WHT</td><td><input type="text" id="txtTotalService" disabled /></td></tr>
                                    <tr><td>Cust.Advance</td><td><input type="text" id="txtTotalCustAdv" onchange="CalTotal()" /></td></tr>
                                    <tr><td>NET</td><td><input type="text" id="txtTotalNet" disabled /></td></tr>
                                    <tr><td>Currency</td><td><input type="text" id="txtCurrencyCode" disabled /></td></tr>
                                    <tr><td>Exc.Rate</td><td><input type="text" id="txtExchangeRate" onchange="CalForeign()" /></td></tr>
                                    <tr><td>Invoiced</td><td><input type="text" id="txtForeignNet" disabled /></td></tr>
                                    <tr><td>Cost</td><td><input type="text" id="txtTotalCost" disabled /></td></tr>
                                    <tr><td>Profit</td><td><input type="text" id="txtTotalProfit" disabled /></td></tr>
                                </table>
                                <button id="btnGen" class="btn btn-success" onclick="ApproveData()">Save Invoice</button>
                            </div>
                            <div class="col-sm-6">
                                <b>Invoice Detail:</b>
                                <button id="btnMerge" class="btn btn-default" onclick="MergeData()">Group Same Expenses</button>
                                <br />
                                <table id="tbDetail" style="width:100%;">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>JobNo</th>
                                            <th>Description</th>
                                            <th>SlipNo</th>
                                            <th>Advance</th>
                                            <th>Charge</th>
                                            <th>VAT</th>
                                            <th>WH-Tax</th>
                                        </tr>
                                    </thead>
                                    <tbody></tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div id="dvLOVs"></div>
        <div>
            <div id="dvEditor" class="modal fade" role="dialog">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            Clearing No : <label id="lblClrNo"></label>
                            Job No : <label id="lblJobNo"></label>
                            <br/>
                            Code : <label id="lblSICode"></label>
                            Description : <label id="lblSDescription"></label>
                        </div>
                        <div class="modal-body">
                            <table>
                                <tr style="width:100%">
                                    <td style="width:20%">
                                        Advance :<br />
                                        <input type="text" class="form-control" id="txtAmtAdvance" />
                                    </td>
                                    <td style="width:20%">
                                        Charges :<br />
                                        <input type="text" class="form-control" id="txtAmtCharge" />
                                    </td>
                                    <td style="width:15%">
                                        VAT :<br />
                                        <input type="text" class="form-control" id="txtAmtVAT" />
                                    </td>
                                    <td style="width:15%">
                                        W/T :<br />
                                        <input type="text" class="form-control" id="txtAmtWHT" />
                                    </td>
                                    <td style="width:20%">
                                        NET :<br />
                                        <input type="text" class="form-control" id="txtAmtNET" />
                                    </td>
                                    <td style="width:10%">
                                        <br />
                                        <input type="button" class="btn btn-default" value="Update" onclick="UpdateData()" id="btnSplit" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div class="modal-footer">
                            <button class="btn btn-danger" data-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    const path = '@Url.Content("~")';
    const user = '@ViewBag.User';
    let arr = [];
    let arr_split = {};
    let arr_clr = [];
    let chq = [];
    //$(document).ready(function () {
        SetEvents();
        //Load params
        let branch = getQueryString("branch");
        let code = getQueryString("code");
        if (branch !== null && code !== null) {
            $('#txtBranchCode').val(branch);
            ShowBranch(path, branch, '#txtBranchName');
            $('#txtJobNo').val(code.toUpperCase());
            $.get(path + 'JobOrder/GetJobSQL?Branch=' + branch + '&JNo=' + code.toUpperCase(), function (dr) {
                if (dr.job.data.length > 0) {
                    ReadJob(dr.job.data[0]);
                }
            });
        }
    //});
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
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name,desc1,desc2', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
            CreateLOV(dv, '#frmSearchJob', '#tbJob', 'Job', response, 3);
            CreateLOV(dv, '#frmSearchInv', '#tbInv', 'Cancelled Invoice', response, 3);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
            //Cheque
            CreateLOV(dv, '#frmSearchChq', '#tbChq', 'Customer Cheque', response, 5);
        });

    }
    function SetGridAdv(isAlert) {
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
                            return data.SICode + '-' + data.SDescription + (data.ExpSlipNO == null ? '' : ' #' + data.ExpSlipNO);
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
            $('#tbHeader tbody').on('dblclick', 'tr', function () {            
                let clearno = $(this).find('td:eq(1)').text();
                //alert('you click ' + clearno);
                window.open(path + 'Clr/Index?BranchCode=' + $('#txtBranchCode').val() + '&ClrNo=' + clearno);
            });
        });
    }
    function CalSummary() {
        let totaladv = 0;
        let totalcharge = 0;
        let totalistaxcharge = 0;
        let totalis50tavi = 0;
        let totalvat = 0;
        let total50tavi = 0;
        let totalcustadv = 0;
        let totalnet = 0;
        let totalcost = 0;

        for (let obj of arr) {
            totaladv += Number(obj.AmtAdvance);
            totalcharge += Number(obj.AmtCharge);
            totalcost += Number(obj.AmtCost);
            if (Number(obj.AmtCharge) > 0) {
                totalistaxcharge += (obj.AmtVat > 0 ? Number(obj.AmtCharge) : 0);
                totalis50tavi += (obj.Amt50Tavi > 0 ? Number(obj.AmtCharge) : 0);
                totalvat += Number(obj.AmtVat);
                total50tavi += Number(obj.Amt50Tavi);
            }
            totalnet += Number(obj.AmtNet);
        }
        for (let c of chq) {
            totalcustadv += Number(c.ChqAmount);
        }
        $('#txtTotalAdvance').val(CDbl(totaladv, 2));
        $('#txtTotalCharge').val(CDbl(totalcharge, 2));
        $('#txtTotalIsTaxCharge').val(CDbl(totalistaxcharge, 2));
        $('#txtTotalIs50Tavi').val(CDbl(totalis50tavi, 2));
        $('#txtTotalVat').val(CDbl(totalvat, 2));
        $('#txtTotalAfter').val(CDbl(totalcharge+totalvat, 2));
        $('#txtTotal50Tavi').val(CDbl(total50tavi, 2));
        $('#txtTotalService').val(CDbl(totalcharge+totalvat-total50tavi, 2));
        $('#txtTotalNet').val(CDbl(totalnet-totalcustadv, 2));
        $('#txtTotalCustAdv').val(CDbl(totalcustadv, 2));

        $('#txtCurrencyCode').val('@ViewBag.PROFILE_CURRENCY');
        $('#txtExchangeRate').val(1);
        $('#txtTotalCost').val(CDbl(totalcost, 2));
        $('#txtTotalProfit').val(CDbl(totalnet - totalcustadv - totalcost, 2));

        CalTotal();

        ShowDetail();
    }
    function ShowSummary() {
        if ($('#txtCustCode').val() == '') {
            alert('Please Select Customer Before');
            return;
        }
        if (arr.length == 0) {
            alert('No data selected');
            return;
        }
        
        CalSummary();

        $('#txtDocNo').val('');
        $('#btnGen').show();
        $('#dvCreate').modal('show');
    }
    function ShowDetail() {
        arr_split = {};
        let arr_sel = arr.filter(function (d) {
            return d.AmtCharge > 0 || d.AmtAdvance > 0;
        });
        $('#tbDetail').DataTable({
            data: arr_sel,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: null, title: "#" },
                { data: "JobNo", title: "Job No" },
                {
                    data: null, title: "Description",
                    render: function (data) {
                        return data.SICode + '-' + data.SDescription + (data.ExpSlipNO == null ? '' : ' #' + data.ExpSlipNO);
                    }
                },
                { data: "ExpSlipNO", title: "Slip No" },
                { data: "AmtAdvance", title: "Advance" },
                { data: "AmtCharge", title: "Charge" },
                { data: "AmtVat", title: "VAT" },
                { data: "Amt50Tavi", title: "WHT" }
            ],
            destroy: true, //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            columnDefs: [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-warning'>Edit</button>";
                    return html;
                }
            }
            ],
        });
        $('#tbDetail tbody').on('click','button', function () {
            let data = GetSelect('#tbDetail',this); //read current row selected
            if (data.ClrNo !== '') {
                LoadClearDetail(data);
            }
        });
        let arr_cost = arr.filter(function (d) {
            return d.AmtCost > 0;
        });
        $('#tbCost').DataTable({
            data: arr_cost,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: "JobNo", title: "Job No" },
                {
                    data: null, title: "Description",
                    render: function (data) {
                        return data.SICode + '-' + data.SDescription + (data.ExpSlipNO == null ? '' : ' #' + data.ExpSlipNO);
                    }
                },
                { data: "ExpSlipNO", title: "Slip No" },
                { data: "AmtCost", title: "Advance" },
                { data: "AmtVat", title: "VAT" },
                { data: "Amt50Tavi", title: "WHT" },
                { data: "AmtNet", title: "NET" }
            ],
            destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        });
    }

    function UpdateData() {
        let arr_new = JSON.parse(JSON.stringify(arr_split));

        arr_new.ClrItemNo = 0;
        arr_new.AmtAdvance = Number($('#txtAmtAdvance').val());
        arr_new.AmtCharge = Number($('#txtAmtCharge').val());
        arr_new.AmtVat = Number($('#txtAmtVAT').val());
        arr_new.Amt50Tavi = Number($('#txtAmtWHT').val());

        SaveClearDetail(arr_new);
    }
    function SaveClearDetail(dr) {
        //process old clear data
        if (dr.AmtAdvance > 0) {
            arr_clr[0].BNet -= Number(dr.AmtAdvance);
            arr_clr[0].FNet -= CDbl((dr.AmtAdvance / dr.ExchangeRate),4);
            arr_clr[0].UsedAmount -= CDbl((dr.AmtAdvance * (100 / (100 + dr.VATRate - dr.Rate50Tavi))),4);
            if (dr.IsTaxCharge > 0) {
                arr_clr[0].ChargeVAT = CDbl((arr_clr[0].UsedAmount * (dr.VATRate*0.01)),4);
            } else {
                arr_clr[0].ChargeVAT = 0;
            }
            if (dr.Is50Tavi > 0) {
                arr_clr[0].Tax50Tavi= CDbl((arr_clr[0].UsedAmount * (dr.Rate50Tavi*0.01)),4);
            } else {
                arr_clr[0].Tax50Tavi = 0;
            }
        } else {
            arr_clr[0].UsedAmount -= Number(dr.AmtCharge);
            arr_clr[0].ChargeVAT -= Number(dr.AmtVat);
            arr_clr[0].Tax50Tavi -= Number(dr.Amt50Tavi);
            arr_clr[0].BNet -= CDbl((Number(dr.AmtCharge) + Number(dr.AmtVat) - Number(dr.Amt50Tavi)),4);
            arr_clr[0].FNet = CDbl((arr_clr[0].BNet / dr.ExchangeRate),4);
        }
        //create new clear data
        let cl = JSON.parse(JSON.stringify(arr_clr[0]));
        cl.ItemNo = 0;
        if (dr.AmtAdvance > 0) {
            cl.BNet = Number(dr.AmtAdvance);
            cl.FNet = CDbl((dr.AmtAdvance / dr.ExchangeRate),4);
            cl.UsedAmount = CDbl((cl.BNet * (100 / (100 + Number(dr.VATRate)-Number(dr.Rate50Tavi)))),4);
            if (dr.IsTaxCharge > 0) {
                cl.ChargeVAT = CDbl((Number(cl.UsedAmount) * (dr.VATRate*0.01)),4);
            } else {
                cl.ChargeVAT = 0;
            }
            if (dr.Is50Tavi > 0) {
                cl.Tax50Tavi= CDbl((Number(cl.UsedAmount) * (dr.Rate50Tavi*0.01)),4);
            } else {
                cl.Tax50Tavi = 0;
            }
        } else {
            cl.UsedAmount = Number(dr.AmtCharge);
            cl.ChargeVAT = Number(dr.AmtVat);
            cl.Tax50Tavi = Number(dr.Amt50Tavi);
            cl.BNet = CDbl((Number(dr.AmtCharge) + Number(dr.AmtVat) - Number(dr.Amt50Tavi)),4);
            cl.FNet = CDbl((cl.BNet / dr.ExchangeRate),4);
        }
        arr_clr.push(cl);

        arr.push(dr);

        let jsonString = JSON.stringify({ data: arr_clr });
        //alert(jsonString);
        $.ajax({
            url: "@Url.Action("SaveClearDetail", "Clr")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data !== null) {
                    alert(response.result.msg);                    
                    arr.splice(arr.indexOf(arr_split), 1);
                    CalSummary();
                    $('#dvEditor').modal('hide');
                }
            },
            error: function (e) {
                alert(e);
            }
        });
    }
    function LoadClearDetail(dr) {
        arr_split = dr;
        arr_clr = [];
        if (dr.ClrNo !== '') {
            $('#lblClrNo').text(dr.ClrNoList);
            $('#lblJobNo').text(dr.JobNo);
            $('#lblSICode').text(dr.SICode);
            $('#lblSDescription').text(dr.SDescription);
            if (dr.AmtAdvance > 0) {
                $('#txtAmtCharge').attr('disabled', 'disabled');
                $('#txtAmtAdvance').removeAttr('disabled');
                $('#txtAmtVAT').attr('disabled', 'disabled');
                $('#txtAmtWHT').attr('disabled', 'disabled');
            } else {
                $('#txtAmtAdvance').attr('disabled', 'disabled');
                $('#txtAmtCharge').removeAttr('disabled');
                $('#txtAmtVAT').removeAttr('disabled');
                $('#txtAmtWHT').removeAttr('disabled');
            }
            $('#txtAmtAdvance').val(dr.AmtAdvance);
            $('#txtAmtCharge').val(dr.AmtCharge);
            $('#txtAmtVAT').val(dr.AmtVat);
            $('#txtAmtWHT').val(dr.Amt50Tavi);
            $('#txtAmtNET').val(dr.AmtNet);
            $('#btnSplit').attr('disabled', 'disabled');
            $.get(path + 'Clr/GetClrDetail?Branch=' + dr.BranchCode + '&Code=' + dr.ClrNo + '&Item=' + dr.ClrItemNo, function (res) {
                if (res.clr.detail.length > 0) {
                    let row = res.clr.detail[0];
                    arr_clr = [];
                    arr_clr.push(row);
                    $('#btnSplit').removeAttr('disabled');
                    $('#dvEditor').modal('show');
                }
            });           
        }
    }
    function CalTotal() {
        let totalnet = CNum($('#txtTotalAdvance').val()) + CNum($('#txtTotalCharge').val()) + CNum($('#txtTotalVat').val()) - CNum($('#txtTotal50Tavi').val()) - CNum($('#txtTotalCustAdv').val());
        $('#txtTotalNet').val(totalnet);
        $('#txtTotalProfit').val(CDbl(totalnet - CNum($('#txtTotalCost').val()), 2));

        CalForeign();
    }
    function CalForeign() {
        let totalforeign = CDbl(CNum($('#txtTotalNet').val()) / CNum($('#txtExchangeRate').val()), 2);
        $('#txtForeignNet').val(totalforeign);
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
        if (Number($('#txtTotalNet').val()) == 0) {
            alert('no data to approve');
            return;
        }
        if ($('#txtCustCode').val() == '') {
            alert('Please select Customer first!');
            return;
        }
        let dataInv = {
            BranchCode:$('#txtBranchCode').val(),
            DocNo: $('#txtDocNo').val(),
            DocType:$('#cboDocType').val(),
            DocDate: CDateTH($('#txtDocDate').val()),
            CustCode:$('#txtCustCode').val(),
            CustBranch:$('#txtCustBranch').val(),
            BillToCustCode:null,
            BillToCustBranch: null,
            ContactName:'',
            EmpCode:user,
            PrintedBy:'',
            PrintedDate:null,
            PrintedTime:null,
            RefNo: GetRefNo(),
            VATRate:CNum(Number(@ViewBag.PROFILE_VATRATE)*100),
            TotalAdvance:CNum($('#txtTotalAdvance').val()),
            TotalCharge:CNum($('#txtTotalCharge').val()),
            TotalIsTaxCharge:CNum($('#txtTotalIsTaxCharge').val()),
            TotalIs50Tavi:CNum($('#txtTotalIs50Tavi').val()),
            TotalVAT:CNum($('#txtTotalVat').val()),
            Total50Tavi:CNum($('#txtTotal50Tavi').val()),
            TotalCustAdv:CNum($('#txtTotalCustAdv').val()),
            TotalNet:CNum($('#txtTotalNet').val()),
            CurrencyCode:$('#txtCurrencyCode').val(),
            ExchangeRate:CNum($('#txtExchangeRate').val()),
            ForeignNet: CNum($('#txtForeignNet').val()),
            TotalDiscount: 0,
            SumDiscount: 0,
            DiscountRate: 0,
            CalDiscount:0,
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
        let jsonString = JSON.stringify({ data: dataInv });
        $.ajax({
            url: "@Url.Action("SetInvHeader", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data !== null) {
                    SaveDetail(response.result.data);
                    PrintInvoice();
                    ResetData();
                    $('#dvCreate').modal('hide');
                    alert(response.result.data);
                    return;
                }
                alert(response.result.msg);
            },
            error: function (e) {
                alert(e);
            }
        });
        return;
    }
    function GetRefNo() {
        let joblist = [];
        let retstr = '';
        for (let obj of arr) {
            if (joblist.indexOf(obj.JobNo) < 0) {
                joblist.push(obj.JobNo);
                if (retstr !== '') retstr += ',';
                retstr += obj.JobNo;
            }
        }
        return retstr;
    }
    function SaveDetail(docno) {
        $('#txtDocNo').val(docno);
        let list = GetDataDetail(arr,docno);
        let jsonText = JSON.stringify({ data: list });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SaveInvDetail", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data !== null) {
                        alert(response.result.msg + '\n=>' + response.result.data);
                        SetGridAdv(false);
                        $('#btnGen').hide();
                        arr = [];
                        return;
                    }
                    alert(response.result.msg);
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
            case 'chequecust':
                SetGridCheque(path, '#tbChq', '#frmSearchChq', '?type=CU&Cancel=N&Branch=' + $('#txtBranchCode').val(), ReadCheque);
                break;
        }
    }
    function ReadInv(dt) {
        $('#txtDocNo').val(dt.DocNo);
    }
    function ReadJob(dt) {
        $('#txtJobNo').val(dt.JNo);
        $('#txtCustCode').val(dt.CustCode);
        $('#txtCustBranch').val(dt.CustBranch);
        $('#cboJobType').val(CCode(dt.JobType));
        $('#cboShipBy').val(CCode(dt.ShipBy));
        ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
    }
    function ReadCheque(dt) {
        if (dt.AmountRemain > 0) {
            $('#txtChqNo').val(dt.ChqNo);
            if (dt.AmountRemain <= Number($('#txtTotalNet').val())) {
                $('#txtChqAmount').val(dt.AmountRemain);
            } else {
                $('#txtChqAmount').val($('#txtTotalNet').val());
            }
            return;
        } else {
            alert('Cheque amount is zero');
        }        
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
    }
    function ReadCustomer(dt) {
        $('#txtCustCode').val(dt.CustCode);
        $('#txtCustBranch').val(dt.Branch);
        //ShowCustomer(path, dt.CustCode, dt.Branch, '#txtCustName');
        $('#txtCustName').val(dt.NameThai);
        $('#txtCustCode').focus();
    }
    function GetDataDetail(o, no) {
        let data = [];
        let i = 0;
        for (let obj of o) {
            if (obj.AmtCharge > 0 || obj.AmtAdvance > 0) {

                i = i + 1;
                data.push({
                    BranchCode: obj.BranchCode,
                    ClrNoList: obj.ClrNoList,
                    DocNo: no,
                    ItemNo: i,
                    SICode: obj.SICode,
                    SDescription: obj.SDescription,
                    ExpSlipNO: obj.ExpSlipNO,
                    SRemark: obj.SRemark,
                    CurrencyCode: $('#txtCurrencyCode').val(),
                    ExchangeRate: $('#txtExchangeRate').val(),
                    Qty: CNum(obj.Qty),
                    QtyUnit: obj.QtyUnit,
                    UnitPrice: obj.UnitPrice,
                    FUnitPrice: CDbl(obj.UnitPrice / CNum($('#txtExchangeRate').val()), 2),
                    Amt: obj.Amt,
                    FAmt: CDbl(obj.Amt / CNum($('#txtExchangeRate').val()), 2),
                    DiscountType: obj.DiscountType,
                    DiscountPerc: obj.DiscountPerc,
                    AmtDiscount: obj.AmtDiscount,
                    FAmtDiscount: CDbl(obj.AmtDiscount / CNum($('#txtExchangeRate').val()), 2),
                    Is50Tavi: obj.Is50Tavi,
                    Rate50Tavi: obj.Rate50Tavi,
                    Amt50Tavi: obj.Amt50Tavi,
                    IsTaxCharge: obj.IsTaxCharge,
                    AmtVat: obj.AmtVat,
                    TotalAmt: obj.TotalAmt,
                    FTotalAmt: CDbl(obj.TotalAmt / CNum($('#txtExchangeRate').val()), 2),
                    AmtAdvance: obj.AmtAdvance,
                    AmtCharge: obj.AmtCharge,
                    CurrencyCodeCredit: obj.CurrencyCodeCredit,
                    ExchangeRateCredit: obj.ExchangeRateCredit,
                    AmtCredit: obj.AmtCredit,
                    FAmtCredit: CDbl(obj.FAmtCredit / CNum($('#txtExchangeRate').val()), 2),
                    VATRate: obj.VATRate
                });
            } else {
                data.push({
                    BranchCode: obj.BranchCode,
                    ClrNoList: obj.ClrNoList,
                    DocNo: no,
                    ItemNo: 0,
                    SICode: obj.SICode,
                    SDescription: obj.SDescription,
                    ExpSlipNO: obj.ExpSlipNO,
                    SRemark: obj.SRemark,
                    CurrencyCode: $('#txtCurrencyCode').val(),
                    ExchangeRate: $('#txtExchangeRate').val(),
                    Qty: obj.Qty,
                    QtyUnit: obj.QtyUnit,
                    UnitPrice: obj.UnitPrice,
                    FUnitPrice: CDbl(obj.UnitPrice / CNum($('#txtExchangeRate').val()), 2),
                    Amt: obj.Amt,
                    FAmt: CDbl(obj.Amt / CNum($('#txtExchangeRate').val()), 2),
                    DiscountType: obj.DiscountType,
                    DiscountPerc: obj.DiscountPerc,
                    AmtDiscount: obj.AmtDiscount,
                    FAmtDiscount: CDbl(obj.AmtDiscount / CNum($('#txtExchangeRate').val()), 2),
                    Is50Tavi: obj.Is50Tavi,
                    Rate50Tavi: obj.Rate50Tavi,
                    Amt50Tavi: obj.Amt50Tavi,
                    IsTaxCharge: obj.IsTaxCharge,
                    AmtVat: obj.AmtVat,
                    TotalAmt: obj.TotalAmt,
                    FTotalAmt: CDbl(obj.TotalAmt / CNum($('#txtExchangeRate').val()), 2),
                    AmtAdvance: obj.AmtAdvance,
                    AmtCharge: obj.AmtCharge,
                    CurrencyCodeCredit: obj.CurrencyCodeCredit,
                    ExchangeRateCredit: obj.ExchangeRateCredit,
                    AmtCredit: obj.AmtCredit,
                    FAmtCredit: CDbl(obj.FAmtCredit / CNum($('#txtExchangeRate').val()), 2),
                    VATRate: obj.VATRate
                });
            }
        }
        return data;
    }
    function PrintInvoice() {
        let code = $('#txtDocNo').val();
        if (code !== '') {
            let branch = $('#txtBranchCode').val();
            window.open(path + 'Acc/FormInv?Branch=' + branch + '&Code=' + code,'_blank');
        }
    }
    function MergeData() {
        let arr_cost = arr.filter(function (d) {
            return d.AmtCost > 0;
        });
        let arr_new = [];
        if (arr_cost.length > 0) {
            arr_new.push(arr_cost);
        }

        let arr_sel = arr.filter(function (d) {
            return d.AmtCharge > 0 || d.AmtAdvance > 0;
        });
        sortData(arr_sel, 'SICode', 'asc');

        let slipList = '';
        let clearList = '';
        let currCode = '';
        let key = {};
        let itemNo = 0;
        let rowProcess = 0;
        for (obj of arr_sel) {
            rowProcess +=1;
            if (currCode !== obj.SICode) {
                if (currCode !== '') {
                    key.ClrNo = '';
                    key.ClrItemNo = 0;
                    key.ClrNoList = clearList;
                    key.ExpSlipNO = slipList;
                    key.UnitPrice = Number(key.Amt) / Number(key.Qty);
                    key.FUnitPrice = CDbl(Number(key.UnitPrice) / Number(obj.ExchangeRate), 2);
                    arr_new.push(key);
                }
                currCode = obj.SICode;
                itemNo += 1;
                key = obj;
                key.ItemNo = itemNo;
                slipList = '';
                clearList = '';
            } else {
                key.Qty+= Number(obj.Qty);
                key.Amt+= Number(obj.Amt);
                key.FAmt= Number(key.Amt) / Number(obj.ExchangeRate);
                key.AmtDiscount+= Number(obj.AmtDiscount);
                key.FAmtDiscount+= Number(key.AmtDiscount) / Number(obj.ExchangeRate);
                key.Amt50Tavi += Number(obj.Amt50Tavi);
                key.AmtVat+= Number(obj.AmtVat);
                key.TotalAmt+= Number(obj.TotalAmt);
                key.FTotalAmt= CDbl(Number(key.TotalAmt) / Number(obj.ExchangeRate), 2);
                key.AmtAdvance+= Number(obj.AmtAdvance);
                key.AmtCharge+= Number(obj.AmtCharge);
                key.AmtCredit+= Number(obj.AmtCredit);
                key.FAmtCredit= CDbl(Number(key.FAmtCredit) / Number(obj.ExchangeRate), 2);
            }
            if (clearList.indexOf((obj.ClrNo + '/' + obj.ClrItemNo)) < 0) {
                clearList += (clearList !== '' ? ',' : '') + (obj.ClrNo + '/' + obj.ClrItemNo);
            }
            if (obj.ExpSlipNO !== null) {
                if (slipList.indexOf(obj.ExpSlipNO) < 0) {
                    slipList += (slipList !== '' ? ',' : '') + obj.ExpSlipNO;
                }
            }
            if (rowProcess==arr_sel.length) {
                key.ClrNo = '';
                key.ClrItemNo = 0;
                key.ClrNoList = clearList;
                key.ExpSlipNO = slipList;
                key.UnitPrice = Number(key.Amt) / Number(key.Qty);
                key.FUnitPrice = CDbl(Number(key.UnitPrice) / Number(obj.ExchangeRate), 2);
                arr_new.push(key);
            }
        }
        arr = arr_new;
        CalSummary();
    }
    function ResetData() {
        arr = [];
        arr_split = {};
        arr_clr = [];
        chq = [];
        SetGridAdv(true);
    }
    function AddCheque() {
        let c = {
            ChqNo: $('#txtChqNo').val(),
            ChqAmount: $('#txtChqAmount').val()
        };
        if (c.ChqAmount <= Number($('#txtTotalNet').val())) {
            $('#txtChqAmount').val(c.ChqAmount);
        } else {
            alert('Cheque Amount is more than total invoices');
            return;
        }
        if (chq.indexOf(c) < 0) {
            chq.push(c);
        } else {
            alert('This amount has been added');
            return;
        }
        $('#txtChqNo').val('');
        $('#txtChqAmount').val(0);
        ShowCheque();
        ShowSummary();
    }
    function ShowCheque() {
        $('#tbCheque').DataTable({
            data: chq,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: null, title: "#" },
                { data: "ChqNo", title: "Cheque No" },
                { data: "ChqAmount", title: "Amount" }
            ],
            columnDefs: [ //กำหนด control เพิ่มเติมในแต่ละแถว
            {
                "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                "data": null,
                "render": function (data, type, full, meta) {
                    let html = "<button class='btn btn-danger'>Delete</button>";
                    return html;
                }
            }
            ],
            destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        });
        $('#tbCheque tbody').on('click', 'button', function () {
            let dt = GetSelect('#tbCheque', this); //read current row selected
            if (chq.indexOf(dt) >= 0) {
                chq.splice(chq.indexOf(dt));
                ShowCheque();
                ShowSummary();
            }
        });
    }
</script>