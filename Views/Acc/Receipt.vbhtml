@Code
    ViewBag.Title = "Receipt"
End Code
<div>
    <br />
    Branch : <input type="text" id="txtBranchCode" />
    <input type="button" value="Show" id="btnShow" />
    <a href="/Acc/GenerateReceipt">Create Receipt</a>
    <table id="tbHeader" class="table table-responsive">
        <thead>
            <tr>
                <th>DocNo</th>
                <th>DocDate</th>
                <th>CustCode</th>
                <th>Reference</th>
                <th>Remark</th>
                <th>Advance</th>
            </tr>
        </thead>
    </table>
</div>
<script type="text/javascript">
        var path = '@Url.Content("~")';
        var user = '@ViewBag.User';
        $('#btnShow').on('click', function () {
            $.get(path + 'acc/getReceipt?type=ADV&branch=' + $('#txtBranchCode').val(), function (r) {
                if (r.receipt.header.length == 0) {
                    $('#tbHeader').DataTable().clear().draw();
                    if (isAlert==true) alert('data not found');
                    return;
                }
                let h = r.receipt.header[0];
                $('#tbHeader').DataTable({
                    data: h,
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: "ReceiptNo", title: "Receive No" },
                        {
                            data: "ReceiptDate", title: "Issue date ",
                            render: function (data) {
                                return CDateEN(data);
                            }
                        },
                        { data: "CustCode", title: "Customer" },
                        { data: "ReceiveRef", title: "Reference Number" },
                        { data: "TRemark", title: "Remark" },
                        { data: "TotalNet", title: "Total" }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbHeader tbody').on('dblclick', 'tr', function () {
                    let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                    let code = data.ReceiptNo;
                    if (code !== '') {
                        let branch = $('#txtBranchCode').val();
                        window.open(path + 'Acc/FormRcp?Branch=' + branch + '&Code=' + code);
                    }
                });
            });
        });

</script>
