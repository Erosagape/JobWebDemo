
@Code
    ViewBag.Title = "File Manager"
End Code
<div id="dvMain" class="container">
    <form id="frmUpLoad" enctype="multipart/form-data">
        <label id="lblMsg" for="chooseFiles">Add Some Images</label>
        <input type="file" id="chooseFiles" multiple="multiple" />
    </form>
    <hr/>
    <div id="dvList"></div>
</div>
<style>
    div.rounded {
        width: 90%;
        border-style: solid;
        border-width: 1px;
        border-radius: 5px;
    }
</style>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let imgpath = 'Resource/uploads';
    //$(document).ready(function () {
        ShowAllPic();
    //});
    function ShowAllPic() {
        $.get(path + 'Config/GetFileList?Path=' + imgpath, function (r) {
            var html = '';
            for (var i = 0; i < r.length; i++) {
                html += '<div class="rounded">';
                html += '<input type="button" value="Delete" onclick="RemoveFile(' + "'" + r[i] + "'" +')" />' + r[i] + '';
                html += '<br/><img src="' + path + imgpath + '/' + r[i] + '" style="width:100%">';
                html += '</div><br/>'
            }
            $('#dvList').html(html);
            $('#lblMsg').text('Total ' + r.length + ' Files');
        });
    }
    function RemoveFile(fname) {
        $.get(path + 'Config/RemovePicture?Path=' + imgpath + '&Name=' + fname, function (r) {
            ShowAllPic();
            ShowMessage(r);
        });
    }
    //Used for upload image automatically
    (function (global) {
        var chooseFiles;
        function PreviewImages() {
            Array.prototype.forEach.call(chooseFiles.files, function (file, index) {
                var oFReader = new FileReader();
                oFReader.addEventListener("load", function assignImageSrc(evt) {
                    var data = new FormData();
                    data.append(file.name, file);

                    var xhr = new XMLHttpRequest();
                    xhr.open('POST', path + 'Config/UploadPicture');
                    xhr.send(data);
                    xhr.onreadystatechange = function () {
                        if (xhr.readyState == 4 && xhr.status == 200) {
                            $('#lblMsg').text(xhr.responseText);
                            ShowAllPic();
                        }
                    }
                    this.removeEventListener("load", assignImageSrc);
                }, false);
                oFReader.readAsDataURL(file);
            });
        }

        global.addEventListener("load", function windowLoadHandler() {
            global.removeEventListener("load", windowLoadHandler);

            chooseFiles = document.getElementById("chooseFiles");
            chooseFiles.addEventListener("change", PreviewImages, false);
        }, false);
    }(window));
</script>