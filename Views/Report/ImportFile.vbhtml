@Code
    ViewData("Title") = "Import"
End Code
    <input id="objFile" type="file" />
    <input id="btnUpload" type="button" value="Upload" />
<br/>
<div>
    <select id="selFiles"></select>
    <input type="button" id="btnShow" value="Show Content" />
    <br />
    <input type="button" id="btnRemove" value="Remove File" />
    <input type="button" id="btnImport" value="Import Data" />
    <br />
    <textarea id="txtContents" style="width:100%;height:100%;"></textarea>
</div>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let saveTo = 'Resource/Export';
    LoadFileList();
    $('#btnShow').on('click', ShowFiles);
    $('#btnUpload').on('click', UploadFile);
    $('#btnRemove').on('click', DeleteFile);
    $('#btnImport').on('click', ProcessFile);
    function ProcessFile() {
        let fname = saveTo+'/'+ $('#selFiles').val();
        if (fname !== null) {
            $.get('/Config/ImportFromFile?Path=' + fname,function (r) {
                if (r.result !== '') {
                    ShowMessage(r.result);
                }
            });
        }

    }
    function DeleteFile() {
        let fname = saveTo+'/'+ $('#selFiles').val();
        if (fname !== null) {
            $.get('/Config/RemovePicture?Name=' + fname,function (r) {
                if (r !== '') {
                    ShowMessage(r);
                    LoadFileList();
                }
            });
        }
    }
    function ShowFiles() {
        let fname =saveTo+'/'+  $('#selFiles').val();
        if (fname !== null) {
            $.get('/' + fname,function (r) {
                if (r !== null) {
                    let str = JSON.stringify(r, undefined, 4);
                    $('#txtContents').text(str);
                }
            });
        }
    }
    function LoadFileList() {
        $('#selFiles').empty();
        $.get('/Config/GetFileList?path=' + saveTo + '&ext=json',
            function (r) {
                let i = 0;
                if (r.length > 0) {
                    for (o of r) {
                        $('#selFiles').append('<option' + (i == 0 ? ' selected>' : '>') + o + '</option>');
                        i += 1;
                    }
                }
            });
    }
    function UploadFile() {
        let count = $('#objFile')[0].files.length;
        if (count == 0) {
            ShowMessage('no file selected');
            return;
        }
        for (let file of $('#objFile')[0].files) {
            let data = new FormData();
            data.append(file.name, file);
            var xhr = new XMLHttpRequest();
            xhr.open('POST','/Config/UploadJson?Path=' + saveTo);
            xhr.send(data);
            xhr.onreadystatechange = function () {
                if (xhr.readyState == 4 && xhr.status == 200) {
                    if (xhr.responseText.substr(0, 1) !== "[") {
                        let fname = xhr.responseText.split(' ')[1];
                        if (fname !== '') {
                            $('#objFile').val('');
                            LoadFileList();
                        }
                        ShowMessage(fname);
                        return;
                    }
                    ShowMessage(xhr.responseText);
                }
            }
        }
    }

</script>