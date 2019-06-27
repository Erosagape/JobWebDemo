@Code
    ViewBag.Title = "Tax-Invoice"
End Code
    <div>
        <br />
        Branch : <input type="text" id="txtBranchCode" />
        <select id="cboType" class="dropdown">
            <option value="TAX" selected>Tax-Invoice (Vatable+Advance)</option>
            <option value="REC">Receipt (Non-Vat only)</option>
            <option value="RCV">Receipt (Non-Vat+Advance)</option>
        </select>
        <input type="button" value="Show" id="btnShow" />
        <a href="/Acc/GenerateTaxInv">Create Tax-Invoice</a>

        <table id="tbHeader" class="table table-responsive">
            <thead>
                <tr>
                    <th>DocNo</th>
                    <th>DocDate</th>
                    <th>CustCode</th>
                    <th>Reference</th>
                    <th>Remark</th>
                    <th>Service</th>
                    <th>Vat</th>
                    <th>Wht</th>
                    <th>Net</th>
                </tr>
            </thead>
        </table>
    </div>
<script type="text/javascript">
    const path = '@Url.Content("~")';
    const user = '@ViewBag.User';
    $('#btnShow').on('click', function () {
        let type = $('#cboType').val();

        $.get(path + 'acc/getReceipt?type='+ type +'&branch=' + $('#txtBranchCode').val(), function (r) {
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
                    { data: "TotalCharge", title: "Amount" },
                    { data: "TotalVAT", title: "Vat" },
                    { data: "Total50Tavi", title: "Wh-tax" },
                    { data: "TotalNet", title: "Net" }
                ],
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('dblclick', 'tr', function () {
                let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                let code = data.ReceiptNo;
                if (code !== '') {
                    let branch = $('#txtBranchCode').val();
                    window.open(path + 'Acc/FormTaxInv?Branch=' + branch + '&Code=' + code);
                }
            });
        });
    });

</script>
