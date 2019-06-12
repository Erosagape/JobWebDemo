
@Code
    ViewBag.Title = "Billing Ac"
End Code

<div>
    <br />
    Branch : <input type="text" id="txtBranchCode" />
    <input type="button" value="Show" id="btnShow" />
    <a href="/Acc/GenerateBilling">Create Billing</a>
    <table id="tbHeader" class="table table-responsive">
        <thead>
            <tr>
                <th>BillNo</th>
                <th>BillDate</th>
                <th>CustCode</th>
                <th>BillRemark</th>
                <th>BillRecvDate</th>
                <th>DuePayment</th>
                <th>Advance</th>
                <th>Charge</th>
                <th>VAT</th>
                <th>WHT</th>
                <th>Net</th>
            </tr>
        </thead>
    </table>
</div>
<script type="text/javascript">
        var path = '@Url.Content("~")';
        var user = '@ViewBag.User';
        $('#btnShow').on('click', function () {
            $.get(path + 'acc/getinvforbill?branch=' + $('#txtBranchCode').val(), function (r) {
                if (r.invdetail.data.length == 0) {
                    $('#tbHeader').DataTable().clear().draw();
                    if (isAlert==true) alert('data not found');
                    return;
                }
                let h = r.invdetail.data;
                $('#tbHeader').DataTable({
                    data: h,
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: "BillAcceptNo", title: "Inv No" },
                        {
                            data: "BillDate", title: "Inv date ",
                            render: function (data) {
                                return CDateEN(data);
                            }
                        },
                        { data: "CustCode", title: "Customer" },
                        { data: "BillRemark", title: "Reference Number" },
                        {
                            data: "BillRecvDate", title: "Inv date ",
                            render: function (data) {
                                return CDateEN(data);
                            }
                        },
                        {
                            data: "DuePaymentDate", title: "Inv date ",
                            render: function (data) {
                                return CDateEN(data);
                            }
                        },
                        { data: "TotalAdvance", title: "Advance" },
                        { data: "TotalCharge", title: "Charge" },
                        { data: "TotalVAT", title: "VAT" },
                        { data: "Total50Tavi", title: "WHT" },
                        { data: "TotalNet", title: "NET" }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbHeader tbody').on('dblclick', 'tr', function () {
                    let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                    let code = data.BillAcceptNo;
                    if (code !== '') {
                        let branch = $('#txtBranchCode').val();
                        window.open(path + 'Acc/FormBill?Branch=' + branch + '&Code=' + code);
                    }
                });
            });
        });

</script>

