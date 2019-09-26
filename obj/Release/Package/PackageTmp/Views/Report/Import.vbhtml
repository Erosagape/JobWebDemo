@Code
    ViewData("Title") = "Import"
End Code
<div>
    Import Data Name : <input type="text" id="txtClassName" value="" />
    <input type="button" id="btnImport" value="Import Data" />
    <br />
    <textarea id="txtContents" style="width:100%;height:100%;"></textarea>
</div>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    $('#btnImport').on('click', ProcessFile);
    function ProcessFile() {
        let cname = $('#txtClassName').val();
        if (cname !== null) {
            var o= {
                source: cname,
                data: JSON.parse($('#txtContents').val())
            }
            var obj = JSON.stringify(o);
            $.ajax({
                url: "@Url.Action("ImportData", "Config")",
                type: "POST",
                contentType: "application/json",
                data: JSON.stringify({ data: obj }),
                success: function (response) {
                    ShowMessage(response.result);
                }
            });
        }
    }

</script>