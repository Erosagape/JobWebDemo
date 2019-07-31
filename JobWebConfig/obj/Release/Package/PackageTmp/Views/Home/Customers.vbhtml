@Code

End Code

<div id="dvForm">
    <div style="display:flex;flex-wrap:wrap;">

        <div style="flex:1">CustID :<br /><input type="text" id="txtCustID" class="form-control"></div>
        <div style="flex:1">CustName :<br /><input type="text" id="txtCustName" class="form-control"></div>
        <div style="flex:1">CustTaxID :<br /><input type="text" id="txtCustTaxID" class="form-control"></div>
        <div style="flex:1">CustAddress :<br /><input type="text" id="txtCustAddress" class="form-control"></div>
        <div style="flex:1">CustContact :<br /><input type="text" id="txtCustContact" class="form-control"></div>
        <div style="flex:1">CustTelFaxMobile :<br /><input type="text" id="txtCustTelFaxMobile" class="form-control"></div>
        <div style="flex:1">BeginDate :<br /><input type="date" id="txtBeginDate" class="form-control"></div>
        <div style="flex:1">ExpireDate :<br /><input type="date" id="txtExpireDate" class="form-control"></div>
        <div style="flex:1">Active :<br /><input type="text" id="txtActive" class="form-control" value="0"></div>
        <div style="flex:1">CustRemark :<br /><input type="text" id="txtCustRemark" class="form-control"></div>
        <div style="flex:1">CustMessage :<br /><input type="text" id="txtCustMessage" class="form-control"></div>
    </div>
</div>
<div id="dvCommand">
    <button id="btnAdd" class="btn btn-default">Add</button>
    <button id="btnSave" class="btn btn-success">Save</button>
    <button id="btnDel" class="btn btn-danger">Delete</button>
</div>
<script src="~/Scripts/Home/Customers.js"></script>