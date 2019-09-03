
@Code
    ViewBag.Title = "Transport Tracking"
End Code
<table id="tbDetail" class="table table-responsive">
    <thead>
        <tr>
            <th>CTN_NO</th>
            <th class="desktop">InvNo</th>
            <th class="all">TruckNO</th>
            <th class="desktop">Location</th>
            <th class="desktop">ProductDesc</th>
            <th class="desktop">ProductQty</th>
            <th class="desktop">LoadDate</th>
            <th class="desktop">FactoryDate</th>
            <th class="all">UnloadFinishDate</th>
            <th class="desktop">Comment</th>
        </tr>
    </thead>
    <tbody></tbody>
</table>
<script type="text/javascript">
    let branch = '@ViewBag.PROFILE_DEFAULT_BRANCH';
    $('#tbDetail').DataTable({
        ajax: {
            url: '/joborder/gettransportreport?Branch='+ branch, //web service ที่จะ call ไปดึงข้อมูลมา
            dataSrc: 'transport.data'
        },
        selected: true, //ให้สามารถเลือกแถวได้
        columns: [ //กำหนด property ของ header column
            { data: "CTN_NO", title: "Container No" },
            { data: "InvNo", title: "Inv.No" },
            { data: "TruckNO", title: "Truck" },
            { data: "Location", title: "Delivery" },
            { data: "ProductDesc", title: "Product" },
            { data: "ProductQty", title: "Qty" },
            {
                data: null, title: "Load Date", render: function (data) {
                    return CDateEN(data.LoadDate);
                }
            },
            {
                data: null, title: "Factory Date", render: function (data) {
                    return CDateEN(data.FactoryDate);
                }
            },
            {
                data: null, title: "Unload Date", render: function (data) {
                    return CDateEN(data.UnloadFinishDate);
                }
            },
            { data: "Comment", title: "Remark" }
        ],
        destroy: true, //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        responsive:true
    });
</script>