@Code
    ViewData("Title") = "Export"
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
        <div id="dvDownload"></div>
    </div>
</div>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let table = "";
    $('#cboDBType').on('click', LoadTables);
    LoadTables();
    function LoadTables() {
        var ul = $('#lstTables');
        ul.empty();
        $.get('/Config/GetTable?DB=' + $('#cboDBType').val(),function (r) {
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
        let jsonText = JSON.stringify({ data: obj });

        let func= $.ajax({
            url: "@Url.Action("GetJSONResult", "Config")",
            type: "POST",
            contentType: "application/json",
            data: jsonText,
        });
        func.done(function (response) {
            if (response.result.data !== "") {
                LoadData(response.result.data);
            }
            ShowMessage(response.result.msg);
        });
        func.catch(function (e) {
            let err = JSON.parse(e.responseText);
            ShowMessage(err.result.msg);
        });
    }
    function LoadData(fname) {
         if (table != "") {
            table.destroy();
            $('#tbResult').empty();
        }
        $.get('/' + fname,function (r) {
            var tb = r.data[0].Table;
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
            $('#dvDownload').html('<input type="button" value="Download" onclick="Download(' + "'" + fname + "'" + ')"/><a href="/'+ fname +'" target="_blank">View Contents</a>');
        });
    }
    function Download(fname) {
        fetch('/'+ fname)
            .then(resp => resp.blob())
            .then(blob => {
                const url = window.URL.createObjectURL(blob);
                const a = document.createElement('a');
                a.style.display = 'none';
                a.href = url;
    // the filename you want
                a.download = fname;
                document.body.appendChild(a);
                a.click();
                window.URL.revokeObjectURL(url);
                ShowMessage(fname +' has downloaded!'); // or you know, something with better UX...
            })
            .catch(() => ShowMessage('oh no!'));
    }
</script>