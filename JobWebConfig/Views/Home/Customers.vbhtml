@Code

End Code

    <div id="dvForm">
        <div style="display:flex;">

            <div style="flex:1">ID :<br /><input type="text" id="txtCustID" class="form-control"></div>
            <div style="flex:1">Name :<br /><input type="text" id="txtCustName" class="form-control"></div>
            <div style="flex:1">Tax ID :<br /><input type="text" id="txtCustTaxID" class="form-control"></div>
        </div>
        <div style="display:flex;">
            <div style="flex:1">Address :<br /><input type="text" id="txtCustAddress" class="form-control"></div>
            <div style="flex:1">Contact :<br /><input type="text" id="txtCustContact" class="form-control"></div>
            <div style="flex:1">Tel/Fax/Mobile :<br /><input type="text" id="txtCustTelFaxMobile" class="form-control"></div>
        </div>
        <div style="display:flex;">
            <div style="flex:1">Begin Date :<br /><input type="date" id="txtBeginDate" class="form-control"></div>
            <div style="flex:1">Expire Date :<br /><input type="date" id="txtExpireDate" class="form-control"></div>
            <div style="flex:1">
                Active :<br /><select id="txtActive" class="form-control dropdown">
                    <option value="-1">Active</option>
                    <option value="0">Stop</option>
                </select>
            </div>
        </div>
        <div style="display:flex;">
            <div style="flex:1">Support Remark :<br /><input type="text" id="txtCustRemark" class="form-control"></div>
            <div style="flex:1">Message :<br /><input type="text" id="txtCustMessage" class="form-control"></div>
        </div>        
    </div>
    <div id="dvCommand">
        <button id="btnAdd" class="btn btn-default">Add</button>
        <button id="btnSave" class="btn btn-success">Save</button>
        <button id="btnDel" class="btn btn-danger">Delete</button>
    </div>
    <script src="~/Scripts/Home/Customers.js"></script>
