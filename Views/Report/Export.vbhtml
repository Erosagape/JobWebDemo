@Code
    ViewData("Title") = "Export"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<p>
    SELECT DATABASE :
    <select id="cboDBType">
        <option value="MAS">Master DB</option>
        <option value="JOB">Transaction DB</option>
    </select>
</p>
<div class="row">
    <div class="col-sm-2">
        <ul id="lstTables"></ul>
    </div>
    <div class="col-sm-10">
        <table id="tbResult" class="table table-responsive">
        </table>
    </div>
</div>
<script type="text/javascript">
    let table = "";
    $('#cboDBType').on('click', LoadTables);
    LoadTables();
    function LoadTables() {
        var ul = $('#lstTables');
        ul.empty();
        $.get('/Config/GetTable?DB=' + $('#cboDBType').val())
            .done(function (r) {
                let html = '';
                if (r.data.length > 0) {
                    for (let row of r.data[0].Table) {
                        html += '<li><a style="display:block;" onclick="SaveData(' + "'" + row.TABLE_NAME + "'" + ')">' + row.TABLE_NAME + '</a></li>';
                    }
                }
                ul.html(html);
            });
    }
    function SaveData(tb) {
        let obj = {
            Source: "SELECT * FROM " + tb + "",
            Param: $('#cboDBType').val(),
            Result: 'Y'
        };
        var jsonText = JSON.stringify({ data: obj });

        $.ajax({
            url: "@Url.Action("GetJSONResult", "CONFIG")",
            type: "POST",
            contentType: "application/json",
            data: jsonText,
            success: function (response) {
                if (response.result.data !== "") {
                    LoadData(response.result.data);
                }
                alert(response.result.msg);
            },
            error: function (e) {
                alert(e);
            }
        });
    }
    function LoadData(fname) {
         if (table != "") {
            table.destroy();
            $('#tbResult').empty();
        }
        $.get('/' + fname).done(function (r) {
            var tb = r.data;
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
        });
    }
</script>