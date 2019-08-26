
@Code
    ViewBag.Title = "SQL Admin"
End Code
<div class="panel-body">
    <div class="container">
        <select id="cboDBType">
            <option value="MAS">Master DB</option>
            <option value="JOB">Transaction DB</option>
        </select>
        <br/>
        <textarea id="txtSQLCommand"></textarea>
        <br/>
        <button id="cmdExecute" class="btn btn-success" onclick="SendData()">Execute</button>
        <table id="tbResult" class="table table-responsive"></table>
        <textarea id="txtJsonResult"></textarea>
    </div>
</div>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    var table = "";
    function SendData() {
        var obj = {
            Source: $('#txtSQLCommand').val(),
            Param: $('#cboDBType').val(),
            Result: ($('#txtSQLCommand').val().trim().toUpperCase().indexOf('SELECT') == 0 ? 'Y' : 'N')
        };
        var jsonText = JSON.stringify({ data: obj });
        if (table != "") {
            table.destroy();
            $('#tbResult').empty();
        }
        $.ajax({
            url: "@Url.Action("GetSQLResult", "CONFIG")",
            type: "POST",
            contentType: "application/json",
            data: jsonText,
            success: function (response) {
                if (response.result.data != null) {
                    var tb = response.result.data[0].Table;
                    var cols = [];
                    $.each(tb[0], function (key, value) {
                        var item = {};
                        item.data = key;
                        item.title = key;
                        cols.push(item);
                    });
                    table=$('#tbResult').DataTable(
                        {
                            "columns": cols,
                            data: tb
                        }
                    );
                }
                var json = JSON.stringify(tb);
                $('#txtJsonResult').val(json);
                ShowMessage(response.result.msg);
            },
            error: function (e) {
                ShowMessage(e);
            }
        });
    }
</script>