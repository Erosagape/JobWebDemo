
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
            <th width="15%">Clear.No</th>
            <th width="8%">Exp.Code</th>
            <th width="30%">Description</th>
            <th width="10%">Advance</th>
            <th width="9%">Charges</th>
            <th width="9%">Cost</th>
            <th width="9%">Profit</th>
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
        Billed :<input type="text" id="txtSumBilled" class="form-control" disabled />
    </div>
    <div class="col-sm-3">
        Received :<input type="text" id="txtSumReceived" class="form-control" disabled />
    </div>
</div>
<button id="btnGenerateInv" class="btn btn-success">Generate Invoice</button>
<button id="btnPrintJobsum" class="btn btn-info">Print Summary</button>
<div id="dvDetail" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Clearing Detail
            </div>
            <div class="modal-body">
                <label for="txtSICode">Code :</label>
                <input type="text" id="txtSICode" style="width:80px" tabindex="12" />
                Description : <input type="text" id="txtSDescription" style="width:230px" tabindex="13" />
                <br />
                <label for="txtForJNo">Job No :</label>
                <input type="text" id="txtForJNo" style="width:120px" tabindex="14" />
                Cust.Inv : <input type="text" id="txtInvNo" style="width:230px" disabled />
                <br />
                <a onclick="SearchData('detcurrency')">Currency :</a>
                <input type="text" id="txtCurrencyCode" style="width:50px" tabindex="15" />
                <input type="text" id="txtCurrencyName" style="width:200px" disabled />
                <label for="txtCurRate">Rate :</label>
                <input type="text" id="txtCurRate" style="width:80px;text-align:right" tabindex="16" />
                <br />
                <label for="txtQty">Qty:</label>
                <input type="text" id="txtQty" style="width:100px;text-align:right" tabindex="17" />
                <label for="txtUnitcode">Unit:</label>
                <input type="text" id="txtUnitCode" style="width:50px" tabindex="18" />
                <label id="lblUnitPrice" for="txtUnitPrice">Price :</label>
                <input type="text" id="txtUnitPrice" style="width:100px;text-align:right" tabindex="19" />
                <br />
                <label id="lblAmount" for="txtAmount">Amount :</label>
                <input type="text" id="txtAMT" style="width:100px;text-align:right" tabindex="20" />
                <label id="lblVATRate" for="txtVATRate">VAT :</label>
                <input type="text" id="txtVATRate" style="width:50px;text-align:right" tabindex="21" />
                Type :
                <select id="txtVatType" class="dropdown" disabled>
                    <option value="0">NO</option>
                    <option value="1">EX</option>
                    <option value="2">IN</option>
                </select>
                <input type="text" id="txtVAT" style="width:100px;text-align:right" tabindex="22" />
                <br />
                <label id="lblWHTRate" for="txtWHTRate">WH-Tax :</label>
                <input type="text" id="txtWHTRate" style="width:50px;text-align:right" tabindex="23" />
                <input type="text" id="txtWHT" style="width:100px;text-align:right" tabindex="24" />
                <label id="lblNETAmount" for="txtNETAmount">Net Amount :</label>
                <input type="text" id="txtNET" style="width:100px;text-align:right" tabindex="25" />
                <br />
                Slip No :
                <input type="text" id="txtSlipNo" style="width:150px" tabindex="26" />
                WH-Tax No :
                <input type="text" id="txt50Tavi" style="width:150px" tabindex="27" />
                <br />
                Pay To Vender :
                <input type="text" id="txtVenCode" style="width:50px" tabindex="28" />
                <input type="button" id="btnBrowseVen" onclick="SearchData('vender')" value="..." />
                <input type="text" id="txtPayChqTo" style="width:200px" tabindex="29" />
                <br />
                Remark :
                <textarea id="txtRemark" style="width:100%;height:80px" tabindex="30"></textarea>
                <br />
                <input type="checkbox" id="chkIsCost" disabled />
                <label for="chkIscost">Is Company Cost (Cannot Charge)</label>
                <br />
                <label for="txtAdvItemNo">Clear From Adv Item.No :</label>
                <input type="text" id="txtAdvItemNo" style="width:40px" disabled />
                <label for="txtAdvNo">Adv.No :</label>
                <input type="text" id="txtAdvNo" style="width:150px" disabled />
                <br />
                <label for="txtLinkItem">Invoice Item.No :</label>
                <input type="text" id="txtLinkItem" style="width:40px" disabled />
                <label for="txtLinkBillNo">Invoice.No :</label>
                <input type="text" id="txtLinkBillNo" style="width:150px" disabled />
            </div>
            <div class="modal-footer">
                <button data-dismiss="modal" class="btn btn-danger">Close</button>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let user = '@ViewBag.User';
    $(document).ready(function () {
        let branch = getQueryString('branchcode');
        let code = getQueryString('jno');
        if (branch != "" && code != "") {
            $.get(path + 'clr/getclearingreport?branch=' + branch + '&job=' + code, function (r) {
                if (r.data[0].Table !== undefined) {
                    let h = r.data[0].Table[0];
                    $('#txtBranchCode').val(h.BranchCode);
                    $('#txtBranchName').val(h.BranchName);
                    $('#txtJNo').val(h.JobNo);
                    $('#txtCloseDate').val(CDateEN(h.CloseJobDate));
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
                    let amtbill = 0;
                    let amtrcv = 0;

                    let d = r.data[0].Table.filter(function (data) {
                        return data.BNet !== 0;
                    });
                    for (let i = 0; i < d.length; i++){
                        let amt = d[i].UsedAmount + d[i].ChargeVAT - (d[i].IsCredit == 1 ? d[i].Tax50Tavi : 0);
                        let adv = (d[i].IsCredit == 1 ? amt : 0);
                        let serv = (d[i].IsCredit == 0 && d[i].IsExpense == 0 ? amt : 0);
                        let cost = (d[i].IsExpense == 1 || d[i].IsCredit==1 ? amt : 0);
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
                        html += '<td><input type="checkbox" name="chkSelect" ' + (d[i].LinkBillNo == '' && d[i].IsExpense==0 ? '' : 'disabled') + '/></td>';
                        html += '<td>' + d[i].ClrNo + '#' + d[i].ItemNo + '</td>';
                        html += '<td>'+d[i].SICode+'</td>';
                        html += '<td>' + d[i].SDescription + '' + slipNo + '</td>';
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
                    $('#txtSumBilled').val(CDbl(amtbill, 2));
                    $('#txtSumReceived').val(CDbl(amtrcv,2));
                }
            });
        }
    });
    $('#tbDetail tbody').on('click', 'tr', function () {            
        let clearno = $(this).find('td:eq(1)').text();

        alert('you click ' + clearno);
        $('#dvDetail').modal('show');
    });
    $('#btnPrintJobsum').on('click', function () {
        window.open(path + 'JobOrder/FormJobSum?branch=' + $('#txtBranchCode').val() + '&code=' + $('#txtJNo').val(),'','');
    });
    $('#btnGenerateInv').on('click', function () {
        window.open(path + 'Clr/GenerateInv?branch=' + $('#txtBranchCode').val() + '&code=' + $('#txtJNo').val(),'','');
    });
</script>