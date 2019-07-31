@Code

End Code
<div class="container-fluid">
    <table id="tbTest" class="table table-responsive" style="width:100%">
        <thead>
            <tr>
                <th>App-ID</th>
                <th>Application Name</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
    <button id="btnAdd" class="btn btn-warning">Add</button>
    <input type="button" id="btnDel" class="btn btn-danger" value="Delete" />
</div>
<div id="dvEditor" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Edit/Add Data
            </div>
            <div class="modal-body">
                <div id="dvForm">
                    <div class="row">
                        <div class="col-sm-2">AppID :<br /><input type="text" id="txtAppID" class="form-control"></div>
                        <div class="col-sm-3">AppNameTH :<br /><input type="text" id="txtAppNameTH" class="form-control"></div>
                        <div class="col-sm-3">AppNameEN :<br /><input type="text" id="txtAppNameEN" class="form-control"></div>
                        <div class="col-sm-4">AppMainURL :<br /><input type="text" id="txtAppMainURL" class="form-control"></div>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <div id="dvCommand" style="float:left">
                    <button id="btnSave" class="btn btn-success">Save</button>
                </div>
                <input type="button" class="btn btn-danger" data-dismiss="modal" value="Close" />
            </div>
        </div>
    </div>
</div>
<script src="~/Scripts/Home/Apps.js"></script>