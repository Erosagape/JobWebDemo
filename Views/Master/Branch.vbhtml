@Code
    ViewBag.Title = "Branch"
End Code
<div class="panel-body">
    <div class="container">
        <div id="dvForm">
            <a href="#" onclick="SearchData('branch')">Branch Code</a> :<br /><input type="text" id="txtCode" class="form-control" tabIndex="1">
            Branch Name :<br /><input type="text" id="txtBrName" class="form-control" tabIndex="2">
        </div>
        <div id="dvCommand">
            <button id="btnAdd" class="btn btn-default" onclick="ClearData()">Add</button>
            <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save</button>
            <button id="btnDel" class="btn btn-danger" onclick="DeleteData()">Delete</button>
        </div>
    </div>
    <div id="dvLOVs"></div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    $(document).ready(function () {
        SetEvents();
        SetEnterToTab();
        ClearData();
    });
    function SetEvents() {
        $('#txtCode').keydown(function (event) {
            if (event.which == 13) {
                ShowBranch(path, $('#txtCode').val(),'#txtBrName');
            }
        });
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
        });
    }
    function SetEnterToTab() {
        //Set enter to tab
        $("input[tabindex], select[tabindex], textarea[tabindex]").each(function () {
            $(this).on("keypress", function (e) {
                if (e.keyCode === 13) {
                    var idx = (this.tabIndex + 1);
                    var nextElement = $('[tabindex="' + idx + '"]');
                    while (nextElement.length) {
                        if (nextElement.prop('disabled') == false) {
                            $('[tabindex="' + idx + '"]').focus();
                            e.preventDefault();
                            return;
                        } else {
                            idx = idx + 1;
                            nextElement = $('[tabindex="' + idx + '"]');
                        }
                    }
                    $('[tabindex="1"]').focus();
                }
            });
        });
    }
    function ReadData(dr) {
        $('#txtCode').val(dr.Code);
        $('#txtBrName').val(dr.BrName);
        $('[tabindex="1"]').focus();
    }
    function ClearData() {
        $('#txtCode').val('');
        $('#txtBrName').val('');
        $('[tabindex="1"]').focus();
    }
    function DeleteData() {
        var code = $('#txtCode').val();
        var ask = confirm("Do you need to Delete " + code + "?");
        if (ask == false) return;

        $.get(path + 'master/delbranch?code=' + code, function (r) {
            alert(r.branch.result);
            ClearData();
        });
    }
    function SaveData() {
        var obj = {

            Code: $('#txtCode').val(),
            BrName: $('#txtBrName').val(),
        };
        if (obj.Code != "") {
            if (obj.BrName == '') {
                alert('Please enter branch name');
                return;
            }
            var ask = confirm("Do you need to Save " + obj.Code + "/" + obj.BrName +"?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetBranch", "Master")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data != null) {
                        $('#txtCode').val(response.result.data);
                        $('#txtCode').focus();
                    }
                    alert(response.result.msg);
                },
                error: function (e) {
                    alert(e);
                }
            });
        } else {
            alert('No data to save');
        }
    }
    function SearchData(type) {
        switch (type) {
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadData);
                break;
        }
    }
</script>
