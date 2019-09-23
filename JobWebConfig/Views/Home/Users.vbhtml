@Code

End Code
<div class="container-fluid">
    <table id="tbTest" class="table table-responsive" style="width:100%">
        <thead>
            <tr>
                <th>UserID</th>
                <th>UserName</th>
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
                        <div class="col-sm-4">User :<br /><input type="text" id="txtTWTUserID" class="form-control"></div>
                        <div class="col-sm-4">Password:<br /><input type="password" id="txtTWTUserPassword" class="form-control"></div>
                        <div class="col-sm-4">Name :<br /><input type="text" id="txtTWTUserName" class="form-control"></div>
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
<script src="~/Scripts/Home/Users.js"></script>
