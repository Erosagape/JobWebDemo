@Code
    ViewBag.Title = "Master Files"
End Code
<div class="panel-body">
    <div class="container">
        <input type="button" onclick="TestFunction()" value="Test Save Log" />
    </div>
    <div id="dvLOVs"></div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    const path = '@Url.Content("~")';
    function TestFunction() {
        $.post(path + 'Config/SetLog', { LogID: 0, CustID: 'TAWAN', AppID: 'JOBSHIPPING', ModuleName: 'TEST', LogAction: 'Test', Message: 'ทดสอบ' }).done(function (r) {
            alert(r.result.msg);
        });
    }
</script>
