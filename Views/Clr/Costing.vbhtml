
@Code
    ViewBag.Title = "Job Summary"
End Code
<div class="row">
    <div class="col-sm-3">
        Branch :
        <br/>
        <input type="text" id="txtBranchCode" style="width:50px" disabled />
        <input type="text" id="txtBranchName" style="width:200px" disabled />
    </div>
    <div class="col-sm-2">
        <label for="txtJNo">Job No :<input type="text" class="form-control" id="txtJNo" disabled /></label>
    </div>
    <div class="col-sm-3">
        <label for="txtCloseDate">Close Date :<input type="date" id="txtCloseDate" class="form-control" disabled /> </label>
    </div>
    <div class="col-sm-4">
        <label for="txtJobStatus">Job Status :<input type="text" class="form-control" id="txtJobStatus" disabled /></label>
    </div>
</div>
<table id="tbDetail" class="table table-responsive">
    <thead>
        <tr>
            <th width="5%">#</th>
            <th width="10%">Clear.No</th>
            <th width="8%">Exp.Code</th>            
            <th width="30%">Description</th>
            <th width="10%">Inv.No</th>
            <th width="8%">Advance</th>
            <th width="8%">Charges</th>
            <th width="8%">Cost</th>
            <th width="8%">Profit</th>
        </tr>
    </thead>
    <tbody></tbody>
</table>
<div class="row">
    <div class="col-sm-3">
        Service : <input type="text" id="txtSumService" class="form-control" disabled />
    </div>
    <div class="col-sm-3">
        Advance :<input type="text" id="txtSumAdvance" class="form-control" disabled />
    </div>
    <div class="col-sm-3">
        Cost :<input type="text" id="txtSumCost" class="form-control" disabled />
    </div>
    <div class="col-sm-3">
        Profit :<input type="text" id="txtSumProfit" class="form-control" disabled />
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        Vatable :<input type="text" id="txtSumBaseVAT" class="form-control" disabled />
    </div>
    <div class="col-sm-3">
        Non-vat :<input type="text" id="txtSumNonVAT" class="form-control" disabled />
    </div>
    <div class="col-sm-3">
        VAT :<input type="text" id="txtSumVAT" class="form-control" disabled />
    </div>
    <div class="col-sm-3">
        W/H-Tax :<input type="text" id="txtSumWHT" class="form-control" disabled />
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        Chargeable :<input type="text" id="txtSumCharge" class="form-control" disabled />
    </div>
    <div class="col-sm-3">
        Invoiced :<input type="text" id="txtSumInvoice" class="form-control" disabled />
    </div>
    <div class="col-sm-3">
        Cleared :<input type="text" id="txtSumClear" class="form-control" disabled />
    </div>
    <div class="col-sm-3">
        Pending :<input type="text" id="txtSumPending" class="form-control" disabled />
    </div>
</div>
<button id="btnGenerateInv" class="btn btn-success">Generate Invoice</button>
<button id="btnPrintJobsum" class="btn btn-info">Print Summary</button>
<div class="modal fade" id="dvEditor" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Set Invoice To <label id="lblClrNo"></label> # <label id="lblItemNo"></label>
            </div>
            <div class="modal-body">
                <input type="text" id="txtInvoiceNo" /><button id="btnUpdateInv" onclick="UpdateInvoice()">Update Invoice</button>
            </div>
            <div class="modal-footer">
                <button id="btnHide" class="btn btn-danger" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let user = '@ViewBag.User';
    let branch = getQueryString('branchcode');
    let code = getQueryString('jno');
    if (branch != "" && code != "") {
        $('#txtBranchCode').val(branch);
        $('#txtJNo').val(code);
        $.get(path + 'clr/getclearingreport?branch=' + branch + '&job=' + code, function (r) {
            if (r.data[0].Table !== undefined) {
                let h = r.data[0].Table[0];
                $('#txtBranchCode').val(h.BranchCode);
                $('#txtBranchName').val(h.BranchName);
                $('#txtJNo').val(h.JobNo);
                $('#txtCloseDate').val(CDateEN(h.CloseJobDate));
                if ($('#txtCloseDate').val() == '') {
                    $('#btnGenerateInv').attr('disabled', 'disabled');
                }
                $('#txtJobStatus').val(h.JobStatusName);

                let html = '';

                let amtforvat = 0;
                let amtnonvat = 0;
                let amtvat = 0;
                let amtwht = 0;
                let amtcharge = 0;
                let amtadvance = 0;
                let amttotal = 0;
                let amtprofit = 0;
                let amtcost = 0;
                let amtinv = 0;
                let amtclear = 0;
                let amtpending = 0;

                let d = r.data[0].Table.filter(function (data) {
                    return data.BNet !== 0;
                });
                for (let i = 0; i < d.length; i++){
                    let amt = d[i].UsedAmount + d[i].ChargeVAT - (d[i].IsCredit == 1 ? d[i].Tax50Tavi : 0);
                    let adv = (d[i].IsCredit == 1 && d[i].IsExpense == 0 ? amt : 0);
                    let serv = (d[i].IsCredit == 0 && d[i].IsExpense == 0 ? amt : 0);
                    let cost = (d[i].IsExpense == 1 ? amt : 0);
                    let profit = (d[i].IsExpense == 1 ? amt*-1 : d[i].IsCredit==1 ? 0 : amt);
                    let slipNo = (d[i].IsHaveSlip == 1 && d[i].IsCredit==1 ? ' #' + d[i].SlipNO : '');

                    if (d[i].IsCredit == 0 && d[i].IsExpense == 0) {
                        if (d[i].IsTaxCharge > 0) {
                            amtforvat += d[i].UsedAmount;
                            amtvat += d[i].ChargeVAT;
                            slipNo += '<br/>VAT ' + d[i].VATRate + '%=' + d[i].ChargeVAT;
                        } else {
                            amtnonvat += d[i].UsedAmount;
                        }
                        if (d[i].Is50Tavi > 0) {
                            amtwht += d[i].Tax50Tavi;
                            slipNo += '<br/>WH-Tax ' + d[i].Tax50TaviRate + '%=' + d[i].Tax50Tavi;
                        }
                    }
                        

                    html += '<tr>';
                    if ((d[i].LinkBillNo == null || d[i].LinkBillNo == '') && cost > 0) {
                        html += '<td><input type="button" value="Edit" onclick="OpenEditor(' + "'" + d[i].ClrNo + "'" + ',' + d[i].ItemNo + ')"/></td>';
                    } else {
                        html += '<td><input type="button" value="View" onclick="OpenInvoice(' + "'" + d[i].BranchCode + "'" + ',' + "'" + d[i].LinkBillNo + "'" + ')"/></td>';
                    }
                    html += '<td>' + d[i].ClrNo + '#' + d[i].ItemNo + '</td>';
                    html += '<td>'+d[i].SICode+'</td>';
                    html += '<td>' + d[i].SDescription + '' + slipNo + '</td>';
                    if (d[i].LinkBillNo == null || d[i].LinkBillNo == '') {
                        html += '<td></td>';
                        amtpending += amt;
                    } else {
                        html += '<td>' + d[i].LinkBillNo + '-' + d[i].LinkItem + '</td>';
                        if (cost > 0) {
                            amtclear += amt;
                        } else {
                            amtinv += amt;
                        }
                    }
                    html += '<td>'+ adv +'</td>';
                    html += '<td>'+ serv +'</td>';
                    html += '<td>' + cost + '</td>';
                    html += '<td>' + profit + '</td>';
                    html += '</tr>';

                    amtadvance += adv;
                    amtcharge += serv;
                    amtcost += cost;
                    amttotal += serv + adv;
                    amtprofit += profit;
                }
                $('#tbDetail tbody').html(html);

                $('#txtSumBaseVAT').val(CDbl(amtforvat,2));
                $('#txtSumNonVAT').val(CDbl(amtnonvat,2));
                $('#txtSumVAT').val(CDbl(amtvat,2));
                $('#txtSumWHT').val(CDbl(amtwht, 2));

                $('#txtSumService').val(CDbl(amtcharge,2));
                $('#txtSumAdvance').val(CDbl(amtadvance, 2));
                $('#txtSumCost').val(CDbl(amtcost, 2));
                $('#txtSumProfit').val(CDbl(amtprofit, 2));

                $('#txtSumCharge').val(CDbl(amttotal, 2));
                $('#txtSumInvoice').val(CDbl(amtinv, 2));
                $('#txtSumClear').val(CDbl(amtclear, 2));
                
                $('#txtSumPending').val(CDbl(amtpending, 2));

            }
        });
    }
    $('#tbDetail tbody').on('dblclick', 'tr', function () {            
        let clearno = $(this).find('td:eq(1)').text().split('#')[0];
        //alert('you click ' + clearno);
        window.open(path + 'Clr/Index?BranchCode=' + $('#txtBranchCode').val() + '&ClrNo=' + clearno);
    });
    $('#btnPrintJobsum').on('click', function () {
        window.open(path + 'JobOrder/FormJobSum?branchcode=' + $('#txtBranchCode').val() + '&JNo=' + $('#txtJNo').val(),'','');
    });
    $('#btnGenerateInv').on('click', function () {
        window.open(path + 'Clr/GenerateInv?branch=' + $('#txtBranchCode').val() + '&code=' + $('#txtJNo').val(),'','');
    });
    function OpenInvoice(branch,code) {
        window.open(path + 'Acc/FormInv?Branch=' + branch + '&Code=' + code,'_blank');
    }
    function OpenEditor(clrno, item) {
        //alert('you click ' + clrno + '/' + item);
        $('#lblClrNo').text(clrno);
        $('#lblItemNo').text(item);
        $('#dvEditor').modal('show');
    }
    function UpdateInvoice() {
        alert($('#txtInvoiceNo').val());
        $('#dvEditor').modal('hide');
    }

</script>