@code
    ViewBag.Title = "Create Job"
End Code
<div Class="panel-group">
    <div Class="panel-primary">
        <div Class="panel-heading">
            <h4 Class="panel-title">
                @ViewBag.Title
            </h4>
        </div>
        <div Class="panel-body">
            <table>
                <tr>
                    <td>
                        รหัสลูกค้า<br />
                        <input type="text" style="width:60px" id="txtCustCode" />
                    </td>
                    <td>
                        <br />
                        <input type="button" id="btnCust" value="..." />
                    </td>
                    <td>
                        ชื่อลูกค้า<br />
                        <input type="text" style="width:auto" id="txtCustName" />

                    </td>
                </tr>
            </table>
        </div>
    </div>
</div>
