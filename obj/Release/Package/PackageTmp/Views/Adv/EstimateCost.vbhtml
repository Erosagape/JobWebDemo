
@Code
    ViewBag.Title = "Estimate Cost"
End Code
<!-- HTML CONTROLS -->
<div class="row">
    <div class="col-sm-4">
        BranchCode :<br /><div style="display:flex"><input type="text" id="txtBranchCode" class="form-control"></div>
    </div>
    <div class="col-sm-4">
        JNo :<br /><div style="display:flex"><input type="text" id="txtJNo" class="form-control"></div>
    </div>
    <div class="col-sm-4">
        SICode :<br /><div style="display:flex"><input type="text" id="txtSICode" class="form-control"></div>
    </div>
</div>
<div class="row">
    <div class="col-sm-6">
        SDescription :<br /><div style="display:flex"><input type="text" id="txtSDescription" class="form-control"></div>
    </div>
    <div class="col-sm-3">
        TRemark :<br /><div style="display:flex"><input type="text" id="txtTRemark" class="form-control"></div>
    </div>
    <div class="col-sm-2">
        AmountCharge :<br /><div style="display:flex"><input type="number" id="txtAmountCharge" class="form-control" value="0.00"></div>
    </div>
    <div class="col-sm-1">
        Status :<br /><div style="display:flex"><input type="text" id="txtStatus" class="form-control"></div>
    </div>
</div>
<div id="dvCommand">
    <button id="btnAdd" class="btn btn-default" onclick="ClearData()">Add</button>
    <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save</button>
    <button id="btnDel" class="btn btn-danger" onclick="DeleteData()">Delete</button>
</div>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    SetEvents();
    function CallBackQueryClearExp(p,branch,code,job,ev) {
        $.get(p + 'master/getclearexp?Branch=' + branch + '&Job=' + job + '&Code=' + code).done(function (r) {
            let dr = r.estimate.data;
            if (dr.length > 0) {
                ev(dr[0]);
            }
        });
    }
    function SetEvents(){
        $('#txtSICode').keydown(function (event) {
            if (event.which == 13) {
                let branch = $('#txtBranchCode').val();
                let code = $('#txtSICode').val();
                let job = $('#txtJNo').val();
                ClearData();
                $('#txtSICode').val(code);
                CallBackQueryClearExp(path, branch, code, job, ReadData);
            }
        });
    }
    //CRUD Functions used in HTML Java Scripts
    function DeleteData() {
        let branch = $('#txtBranchCode').val();
        let code = $('#txtSICode').val();
        let job = $('#txtJNo').val();
        let ask = confirm("Do you need to Delete " + code + "?");
        if (ask == false) return;
        $.get(path + 'adv/delclearexp?branch=' + branch + '&code=' + code + '&job=' + job, function (r) {
                alert(r.estimate.result);
                ClearData();
            });
    }
    function ReadData(dr) {
        $('#txtBranchCode').val(dr.BranchCode);
        $('#txtJNo').val(dr.JNo);
        $('#txtSICode').val(dr.SICode);
        $('#txtSDescription').val(dr.SDescription);
        $('#txtTRemark').val(dr.TRemark);
        $('#txtAmountCharge').val(dr.AmountCharge);
        $('#txtStatus').val(dr.Status);
    }
    function SaveData() {
        let obj = {
            BranchCode: $('#txtBranchCode').val(),
            JNo:$('#txtJNo').val(),
            SICode:$('#txtSICode').val(),
            SDescription:$('#txtSDescription').val(),
            TRemark:$('#txtTRemark').val(),
            AmountCharge:CNum($('#txtAmountCharge').val()),
            Status:$('#txtStatus').val()
        };
        if (obj.SICode != "") {
            let ask = confirm("Do you need to Save " + obj.SICode + "?");
            if (ask == false) return;
            let jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetClearExp", "Adv")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data != null) {
                        $('#txtSICode').val(response.result.data);
                        $('#txtSICode').focus();
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
    function ClearData() {
        $('#txtBranchCode').val('');
        $('#txtJNo').val('');
        $('#txtSICode').val('');
        $('#txtSDescription').val('');
        $('#txtTRemark').val('');
        $('#txtAmountCharge').val('0.00');
        $('#txtStatus').val('');
    }
</script>