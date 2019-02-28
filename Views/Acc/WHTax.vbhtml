
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
            <li class="active"><a data-toggle="tab" href="#tabHeader">Headers</a></li>
            <li><a data-toggle="tab" href="#tabDetail">Details</a></li>
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
                        <div class="col-sm-10" style="display:flex;flex-direction:column">
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
                    <button id="btnAdd" class="btn btn-default" onclick="ClearForm()">Clear Data</button>
                    <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save Data</button>
                    <button id="btnPrint" class="btn btn-info" onclick="PrintData()">Print Data</button>
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
                        <button id="btnAddDoc" class="btn btn-default" onclick="AddDocument()">Add</button>
                    </div>
                </p>
            </div>

        </div>
    </div>
</div>