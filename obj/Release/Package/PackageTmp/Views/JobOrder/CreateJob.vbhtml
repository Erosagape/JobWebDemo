@code
    ViewBag.Title = "Create Job"
End Code
<div Class="panel-body">
    <table>
        <tr>
            <td>
                พนักงาน CS<br />
                <input type="text" id="txtCSCode" style="width:120px" />
            </td>
            <td>
                <br />
                <input type="button" id="btnBrowseCS" value="..." onclick="SearchData('user')" />
            </td>
            <td>
                ชื่อพนักงาน<br />
                <input type="text" id="txtCSName" style="width:300px" disabled />
            </td>
        </tr>
        <tr>
            <td>
                รหัสลูกค้า<br />
                <input type="text" style="width:80px" id="txtCustCode" />
                <input type="text" style="width:40px" id="txtCustBranch" />
            </td>
            <td>
                <br />
                <input type="button" id="btnCust" value="..." />
            </td>
            <td>
                ชื่อลูกค้า<br />
                <input type="text" style="width:300px" id="txtCustName" disabled/>
            </td>
        </tr>
        <tr>
            <td>
                สถานที่วางบิล<br />
                <input type="text" id="txtConsignee" style="width:120px" />
            </td>
            <td>
                <br />
                <input type="button" id="btnBrowseCons" value="..." onclick="SearchData('consignee')" />
            </td>
            <td>
                ชื่อสถานที่วางบิล<br />
                <input type="text" id="txtConsName" style="width:300px" disabled />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                ผู้ติดต่อ<br />
                <input type="text" id="txtContactPerson" style="width:200px" />
            </td>
            <td>
                <br />
                <input type="button" id="btnBrowseContact" value="..." onclick="SearchData('contact')" />
            </td>
            <td>
                ใบเสนอราคาเลขที่้<br />
                <input type="text" style="width:150px" id="txtQNo" />
                <input type="text" style="width:50px" id="txtRevise" />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                Customer Invoice<br />
                <input type="text" id="txtCustInv" style="width:230px" />
            </td>
            <td>
                Customer PO No<br />
                <input type="text" style="width:230px" id="txtCustPO" />
            </td>
        </tr>
        <tr>
            <td>
                HAWB or H B/L <br />
                <input type="text" id="txtHAWB" style="width:230px" />
            </td>
            <td>
                MAWB or M B/L<br />
                <input type="text" style="width:230px" id="txtMAWB" />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                Copy ข้อมูลจาก Job<br />
                <input type="text" id="txtCopyFromJob" style="width:200px" />
                <input type="button" id="btnBrowseJob" value="..." onclick="SearchData('job')" />
            </td>
            <td>
                วันที่เปิดงาน<br />
                <input type="date" style="width:200px" id="txtJobDate" />
            </td>
        </tr>
        <tr>
            <td>
                <input id="chkTransferCost" type="checkbox" />
                โอนข้อมูลค่าบริการและค่าใช้จ่ายมาด้วย
            </td>
            <td>
                <button class="btn btn-success" id="btnCreateJob">สร้างหมายเลขงานใหม่</button>
            </td>
        </tr>
    </table>
</div>


