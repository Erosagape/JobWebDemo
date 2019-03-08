
@Code
    ViewBag.Title = "With-holding Tax"
End Code
<div class="panel-body">
    <div class="container">
        <div class="row">
            <div class="col-sm-4" style="display:flex;flex-direction:row;">
                <label style="display:block;width:20%">Branch:</label>
                <input type="text" class="form-control" id="txtBranchCode" style="width:15%" />
                <input type="button" class="btn btn-default" value="..." />
                <input type="text" class="form-control" id="txtBranchName" style="width:60%" disabled />
            </div>
            <div class="col-sm-3" style="display:flex;flex-direction:row;">
                <label style="display:block;width:20%">Job No:</label>
                <input type="text" class="form-control" id="txtJNo" style="width:80%" />
            </div>
            <div class="col-sm-3" style="display:flex;flex-direction:row;">
                <label style="display:block;width:20%">Doc No:</label>
                <input type="text" class="form-control" id="txtDocNo" style="width:75%" />
                <input type="button" class="btn btn-default" value="..." />
            </div>
            <div class="col-sm-2" style="display:flex;flex-direction:row;">
                <label style="display:block;width:20%">Date:</label>
                <input type="date" class="form-control" id="txtDocDate" style="width:80%" />
            </div>
        </div>
        <ul class="nav nav-tabs">
            <li class="active">
                <a data-toggle="tab" href="#tabHeader">Headers</a>
            </li>
            <li>
                <a data-toggle="tab" href="#tabDetail">Details</a>
            </li>
        </ul>
        <div class="tab-content">
            <div class="tab-pane fade in active" id="tabHeader">
                <p>
                    <div class="row">
                        <div class="col-sm-7" style="display:flex;flex-direction:row;">
                            <label style="display:block;width:20%">Tax Issuer</label>
                            <input type="text" id="txtTName1" class="form-control" style="width:75%" />
                            <input type="button" class="btn btn-default" value="..." />
                        </div>
                        <div class="col-sm-5" style="display:flex;flex-direction:row;">
                            <label style="display:block;width:20%">Tax Number</label>
                            <input type="text" id="txtTaxNumber1" class="form-control" style="width:60%" />
                            <input type="button" class="btn btn-default" value="DN" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-7" style="display:flex;flex-direction:row;">
                            <label style="display:block;width:20%">Address</label>
                            <input type="text" id="txtTAddress1" class="form-control" style="width:80%" />
                        </div>
                        <div class="col-sm-5" style="display:flex;flex-direction:row;">
                            <label style="display:block;width:20%">Branch</label>
                            <input type="text" id="txtBranch1" class="form-control" style="width:60%" />
                            <label style="display:block;width:20%"><input type="checkbox" /> Venders</label>
                        </div>
                    </div>
                </p>
                <p>
                    <div class="row">
                        <div class="col-sm-7" style="display:flex;flex-direction:row;">
                            <label style="display:block;width:20%">Tax Agent</label>
                            <input type="text" id="txtTName2" class="form-control" style="width:75%" />
                            <input type="button" class="btn btn-default" value="..." />
                        </div>
                        <div class="col-sm-5" style="display:flex;flex-direction:row;">
                            <label style="display:block;width:20%">Tax Number</label>
                            <input type="text" id="txtTaxNumber2" class="form-control" style="width:60%" />
                            <input type="button" class="btn btn-default" value="DN" />
                            <input type="button" class="btn btn-default" value="UP" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-7" style="display:flex;flex-direction:row;">
                            <label style="display:block;width:20%">Address</label>
                            <input type="text" id="txtTAddress2" class="form-control" style="width:80%" />
                        </div>
                        <div class="col-sm-5" style="display:flex;flex-direction:row;">
                            <label style="display:block;width:20%">Branch</label>
                            <input type="text" id="txtBranch2" class="form-control" style="width:60%" />
                        </div>
                    </div>
                </p>
                <p>
                    <div class="row">
                        <div class="col-sm-7" style="display:flex;flex-direction:row;">
                            <label style="display:block;width:20%">Tax Payer</label>
                            <input type="text" id="txtTName3" class="form-control" style="width:75%" />
                            <input type="button" class="btn btn-default" value="..." />
                        </div>
                        <div class="col-sm-5" style="display:flex;flex-direction:row;">
                            <label style="display:block;width:20%">Tax Number</label>
                            <input type="text" id="txtTaxNumber3" class="form-control" style="width:60%" />
                            <input type="button" class="btn btn-default" value="UP" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-7" style="display:flex;flex-direction:row;">
                            <label style="display:block;width:20%">Address</label>
                            <input type="text" id="txtTAddress3" class="form-control" style="width:80%" />
                        </div>
                        <div class="col-sm-5" style="display:flex;flex-direction:row;">
                            <label style="display:block;width:20%">Branch</label>
                            <input type="text" id="txtBranch3" class="form-control" style="width:60%" />
                        </div>
                    </div>
                </p>
                <p>
                    <div class="row">
                        <div class="col-sm-2">
                            Number
                            <input type="text" id="txtSeqInForm" class="form-control" />
                        </div>
                        <div class="col-sm-7" style="display:flex;flex-direction:column">
                            Type of :
                            <div style="display:flex;flex-direction:row;flex-grow:4">
                                <label style="display:block;width:20%"><input type="radio" name="FormType" value="1" /> (1) ภ.ง.ด.1ก.</label>
                                <label style="display:block;width:20%"><input type="radio" name="FormType" value="2" /> (2) ภ.ง.ด.1ก. พิเศษ</label>
                                <label style="display:block;width:20%"><input type="radio" name="FormType" value="3" /> (3) ภ.ง.ด.2.</label>
                                <label style="display:block;width:20%"><input type="radio" name="FormType" value="4" /> (4) ภ.ง.ด.3.</label>
                                <label style="display:block;width:20%"><input type="radio" name="FormType" value="5" /> (5) ภ.ง.ด.2ก.</label>
                                <label style="display:block;width:20%"><input type="radio" name="FormType" value="6" /> (6) ภ.ง.ด.3ก.</label>
                                <label style="display:block;width:20%"><input type="radio" name="FormType" value="7" /> (7) ภ.ง.ด.53.</label>
                            </div>
                        </div>
                        <div class="col-sm-3" style="display:flex;flex-direction:column">
                            Tax Code:
                            <select class="form-control dropdown" id="txtTaxLawNo">
                                <option value="1">3 เตรส</option>
                                <option value="2">65 จัดวา</option>
                                <option value="3">69 ทวิ</option>
                                <option value="4">48 ทวิ</option>
                                <option value="5">50 ทวิ</option>
                            </select>
                        </div>
                    </div>
                </p>
                <p>
                    <div class="row">
                        <div class="col-sm-2" style="display:flex;flex-direction:column">
                            Tax Condition:
                            <select class="form-control dropdown" id="txtPayTaxType">
                                <option value="1">หัก ณ ที่จ่าย</option>
                                <option value="2">ออกภาษีให้ครั้งเดียว</option>
                                <option value="3">ออกภาษีให้ตลอดไป</option>
                                <option value="4">อื่นๆ (ระบุ)</option>
                            </select>
                        </div>
                        <div class="col-sm-3" style="display:flex;flex-direction:column">
                            Condition Note:
                            <input type="text" id="txtPayTaxOther" class="form-control" />
                        </div>
                        <div class="col-sm-7" style="display:flex;flex-direction:row">
                            <div style="margin-right:5px;flex:40%;">
                                Social Security No.
                                <input type="text" id="txtSoLicenseNo" class="form-control" />
                            </div>
                            <div style="margin-right:5px;flex:40%;">
                                Social Payer No.
                                <input type="text" id="txtSoTaxNo" class="form-control" />
                            </div>
                            <div style="margin-right:5px;flex:20%;">
                                Amount.
                                <input type="text" id="txtSoLicenseAmount" class="form-control" />
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6" style="display:flex;flex-direction:row">
                            <div style="margin-right:5px;flex:50%">
                                Provident Fund Payer.
                                <input type="text" id="txtPayeeAccNo" class="form-control" />
                            </div>
                            <div style="margin-right:5px;flex:25%">
                                Provident Fund Amount.
                                <input type="text" id="txtSoAccAmount" class="form-control" />
                            </div>
                            <div style="margin-right:5px;flex:25%">
                                Teacher Fund Amt.
                                <input type="text" id="txtTeacherAmt" class="form-control" />
                            </div>
                        </div>
                    </div>
                </p>
                <div id="dvCommand">
                    <button id="btnAdd" class="btn btn-default">Clear Data</button>
                    <button id="btnSave" class="btn btn-success">Save Data</button>
                </div>
            </div>
            <div class="tab-pane fade" id="tabDetail">
                <p>
                    <table id="tbDetail" class="table table-bordered">
                        <thead>
                            <tr>
                                <th>ItemNo</th>
                                <th>IncType</th>
                                <th>PayDate</th>
                                <th>PayAmount</th>
                                <th>IncRate</th>
                                <th>PayTax</th>
                                <th>PayTaxDesc</th>
                                <th>JNo</th>
                            </tr>
                        </thead>
                    </table>
                    <div>
                        <button id="btnAddDoc" class="btn btn-default">Add Detail</button>
                    </div>
                </p>
            </div>
        </div>
        <div class="modal fade" id="frmDetail">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal"></button>
                        <h4 class="modal-title">
                            <label id="lblHeader">Tax Detail</label>
                        </h4>
                    </div>
                    <div class="modal-body">
                        <div style="display:flex;flex-wrap:wrap">
                            <div>
                                No :
                                <br />
                                <input type="text" id="txtItemNo" class="form-control" value="0" disabled>
                            </div>
                            <div>
                                Doc.Type :
                                <br />
                                <select id="cboDocRefType" class="form-control dropdown">
                                    <option value="1">ADV</option>
                                    <option value="2">CLR</option>
                                    <option value="3">PAY</option>
                                    <option value="4">TAX</option>
                                </select>
                            </div>
                            <div>
                                RefNo :
                                <br />
                                <input type="text" id="txtDocRefNo" class="form-control">
                            </div>
                            <div>
                                <br />
                                <input type="button" class="btn btn-default" value="..." />
                            </div>
                        </div>
                        <div style="display:flex;flex-wrap:wrap">
                            <div>
                                Job No :
                                <br />
                                <input type="text" id="txtJNo" class="form-control">
                            </div>
                            <div>
                                <br />
                                <input type="button" class="btn btn-default" value="..." />
                            </div>
                            <div>
                                Pay.Date :
                                <br />
                                <input type="date" id="txtPayDate" class="form-control">
                            </div>
                        </div>
                        <div style="display:flex;flex-wrap:wrap">
                            <div>
                                Revenue Type :
                                <br />
                                <select id="cboIncType" class="form-control dropdown">
                                    <option value="1">
                                        1.เงินเดือน ค่าจ้าง เบี้ยเลี้ยง โบนัส ฯลฯ ตามมาตรา 40(1)
                                    </option>
                                    <option value="2">
                                        2.ค่าธรรมเนียม ค่านายหน้า ฯลฯ ตามมาตรา 40(2)
                                    </option>
                                    <option value="3">
                                        3.ค่าแห่งลิขสิทธิ์ ฯลฯ ตามมาตรา 40(1)
                                    </option>
                                    <option value="4">
                                        4.(ก)ค่าดอกเบี้ย ฯลฯ ตามมาตรา 40(4)(ก)
                                    </option>
                                    <option value="5">
                                        4.(ข)(1)เงินปันผลเงินส่วนแบ่งกำไร (1.1) ร้อยละ 30
                                    </option>
                                    <option value="6">
                                        4.(ข)(1)เงินปันผลเงินส่วนแบ่งกำไร (1.2) ร้อยละ 25
                                    </option>
                                    <option value="7">
                                        4.(ข)(1)เงินปันผลเงินส่วนแบ่งกำไร (1.3) ร้อยละ 20
                                    </option>
                                    <option value="8">
                                        4.(ข)(1)เงินปันผลเงินส่วนแบ่งกำไร (1.4) อัตราอื่นๆ
                                    </option>
                                    <option value="9">
                                        4.(ข)(2)กรณีผู้รับเงินปันผลไม่ได้รับเครดิตภาษีเพราะกิจการได้รับยกเว้น
                                    </option>
                                    <option value="10">
                                        4.(ข)(3)เงินปันผลหรือส่วนแบ่งกำไรที่ได้รับยกเว้นไม่ต้องนำรวมมาคำนวณ
                                    </option>
                                    <option value="11">
                                        4.(ข)(4)กำไรที่รับรู้ทางบัญชีโดยวิธีส่วนได้เสีย
                                    </option>
                                    <option value="12">
                                        4.(ข)(5)อื่นๆ (ระบุ)
                                    </option>
                                    <option value="13">
                                        5.การจ่ายเงินได้ที่ต้องหักภาษี ณ ที่จ่ายตามคำสั่งกรมสรรพากรที่ออกตาม มาตรา 3 เตรส
                                    </option>
                                    <option value="14">
                                        6.อื่นๆ (ระบุ)
                                    </option>
                                </select>
                            </div>
                        </div>
                        <div style="display:flex;flex-wrap:wrap;">
                            <div style="flex:1">
                                Description :
                                <br />
                                <input type="text" id="txtPayTaxDesc" class="form-control">
                            </div>
                        </div>
                        <div style="display:flex;flex-wrap:wrap">
                            <div style="flex:1">
                                Rate :
                                <br />
                                <input type="number" id="txtPayRate" class="form-control" value="0.00">
                            </div>
                            <div style="flex:1">
                                Amount :
                                <br />
                                <input type="number" id="txtPayAmount" class="form-control" value="0.00">
                            </div>
                            <div style="flex:1">
                                Tax :
                                <br />
                                <input type="number" id="txtPayTax" class="form-control" value="0.00">
                            </div>
                        </div>

                    </div>
                    <div class="modal-footer">
                        <button id="btnUpdateDoc" class="btn btn-primary">Save</button>
                        <button id="btnDelDoc" class="btn btn-warning">Delete</button>
                        <button id="btnHide" class="btn btn-danger" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    $('#btnAddDoc').on('click', function () {
        $('#frmDetail').modal('show');
    });
</script>