@Code
    ViewBag.Title = "ค่าคงที่ต่างๆ (System Variable)"
End Code
<div class="panel-body">
    <div id="divInputs">
        <button id="btnNew" class="btn btn-default" onclick="ClearData()">New</button>
        <table id="frmConfig">
            <tr>
                <td>
                    Config Code :
                </td>
                <td>
                    <input type="text" class="form-control" id="txtCode" />
                </td>
                <td>
                    <input type="button" id="btnBrowse" value="..." onclick="SearchData()" />
                </td>
            </tr>
            <tr>
                <td>
                    Config Key :
                </td>
                <td>
                    <input type="text" class="form-control" id="txtKey" />
                </td>
                <td></td>
            </tr>
            <tr>
                <td>
                    Config Value :
                </td>
                <td>
                    <textarea class="form-control" id="txtValue"></textarea>
                </td>
                <td></td>
            </tr>
        </table>
        <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save</button>
    </div>
    <div id="frmSearch" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal"></button>
                    <h4 class="modal-title"><label id="lblHeader">Search Config</label></h4>
                </div>
                <div class="modal-body">
                    <table id="tbLOV" class="table table-responsive">
                        <thead>
                            <tr>
                                <th>
                                <th>code</th>
                                <th>name</th>
                            </tr>
                        </thead>
                    </table>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>
    <hr />
    <div id="divGrid">
        <table id="tblData" class="table table-responsive">
            <thead>
                <tr>
                    <th>Code</th>
                    <th>Key</th>
                    <th>Value</th>
                </tr>
            </thead>
            <tbody />
        </table>
    </div>
    <div id="dvMsg"></div>
</div>
<script type="text/javascript">
    //define variables
    var path = '@Url.Content("~")';
    $(document).ready(function () {
        //listening events
        $("#txtCode").keydown(function (event) {
            if (event.which == 13) {
                ShowData($('#txtCode').val(), "");
            }
        });
        $("#txtKey").keydown(function (event) {
            if (event.which == 13) {
                GetData();
            }
        });
        $('#frmSearch').on('shown.bs.modal', function () {
            $('#tbLOV_filter input').focus();
        });
        ShowData("", "");
    });
    function SearchData() {
        //popup for search data
        $('#tbLOV').DataTable({
            ajax: {
                url: path + 'Config/GetList', //web service ที่จะ call ไปดึงข้อมูลมา
                dataSrc: 'config.data'
            },
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: null, title: "#" },
                { data: "ConfigCode", title: "ประเภท" }
            ],
            "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                {
                    "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                    "data": null,
                    "render": function (data, type, full, meta) {
                        var html = "<button class='btn btn-warning'>Select</button>";
                        return html;
                    }
                }
            ],
            destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        });
        $('#tbLOV tbody').on('click', 'tr', function () {
            $('#tbLOV tbody tr.selected').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
            $(this).addClass('selected'); //select row ใหม่
        });
        $('#tbLOV tbody').on('click', 'button', function () {
            var dt = GetSelect('#tbLOV', this);
            $('#txtCode').val(dt.ConfigCode);
            ShowData($('#txtCode').val(), "");
            $('#frmSearch').modal('hide');
        });
        $('#frmSearch').modal('show');

    }
    function ClearData() {
        //clear input form and set default values
        $('#txtCode').val('');
        $('#txtKey').val('');
        $('#txtValue').val('');
    }
function GetData() {
//get data from input cliteria
$.get(path + 'Config/getConfig' + GetParam($('#txtCode').val(), $('#txtKey').val()))
    .done(function (response) {
        if (response.config.data.length == 0) {
            $('#txtValue').val('');
            return;
        }
        $('#txtValue').val(response.config.data[0].ConfigValue);
    });
}
function GetInput() {
//read input data and generated class for post
    var obj = {
        ConfigCode: $('#txtCode').val(),
        ConfigKey: $('#txtKey').val(),
        ConfigValue: $('#txtValue').val()
    };
    return obj;
}
function SaveData() {
//post data input to web API
    var obj = GetInput();
    $.ajax({
        url: "@Url.Action("SetConfig", "Config")",
        type: "POST",
        contentType: "application/json",
        data: JSON.stringify({ data: obj }),
        success: function (response) {
            response ? alert("Save Completed!") : alert("Cannot Save data");
            ShowData($('#txtCode').val(), "")
        }
    });
}
function GetParam(Code, Key) {
    //create query string from user input
    var strParam = "";
    if (Code != "") {
        strParam += "Code=" + Code;
    }
    if (Key != "") {
        if (strParam != "") strParam += "&"
        strParam += "Key=" + Key;
    }
    if (strParam != "") strParam = "?" + strParam;
    return strParam;
}
function ShowData(Code, Key) {
//function for show grid data
    var table = $('#tblData').DataTable({
        ajax: {
            url: path + "Config/getConfig" + GetParam(Code, Key),
            dataSrc: "config.data"
        },
        destroy: true,
        columns: [
            { data: "ConfigCode" },
            { data: "ConfigKey" },
            { data: "ConfigValue" },
        ]
    });
    //on click load current row select to form
    $('#tblData tbody').on('click', 'tr', function () {
        $('#tblData tbody > tr').removeClass('selected');
        $(this).addClass('selected');

        var data = $('#tblData').DataTable().row(this).data();
        $('#txtCode').val(data.ConfigCode);
        $('#txtKey').val(data.ConfigKey);
        $('#txtValue').val(data.ConfigValue);
    });
}
</script>
