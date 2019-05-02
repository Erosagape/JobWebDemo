
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Credit Advance Slip"
    ViewBag.ReportName = "CREDIT ADVANCE SLIP"
End Code
<style>
    * {
        font-family: Tahoma;
        font-size: 11px;
    }

    td {
        font-size: 11px;
    }

    table {
        border-width: thin;
        border-collapse: collapse;
    }
</style>
<div style="display:flex">
    <div style="flex:1;text-align:left">
        เลขที่ : <label id="lblControlNo"></label><br />
        วันที่ : <label id="lblVoucherDate"></label>
    </div>

    <div style="flex:2">
        <div style="display:flex;flex-direction:column;text-align:right;">
            <div style="flex:1">
                ผู้ขอเบิก <label id="lblRecByName"></label>
            </div>
            <div style="flex:1">
                ถึงบริษัท <label id="lblCustName"></label>
            </div>
        </div>
    </div>

</div>
<div style="margin-bottom:20px;">
    <br/>
    คำอธิบาย : <label id="lblTRemark"></label>
</div>

<table id="tbData" border="1" width="100%">
    <tr style="text-align:center;">
        <td width="5%">No</td>
        <td colspan="2" class="text-left">Description</td>
        <td width="25%" class="text-right">Expense Amount</td>
    </tr>
    <tbody>
        <tr class="text-center">
            <td width="5%">
                2
            </td>
            <td width="10%">
                SNG-008
            </td>
            <td class="text-left" width="60%">
                DSR - STORAGE FEE
            </td>
            <td width="25"  style="text-align:right">
                6,000.00
            </td>
        </tr>
    </tbody>

    <tr class="text-center">

        <td colspan="3">
            รวมจำนวนเงินทั้งหมด ( <label id="lblTotalText"></label> )
        </td>

        <td width="25%" style="text-align:right">
            <label id="lblTotalNet"></label>
        </td>

    </tr>
</table>

<table border="1" width="100%">
    <tr style="text-align:center">
        <td width="30%" >
            <br><br>
            _______________________________<br>
            ผู้เบิก<br>
            ______________________________<br>
            <p class="text-left">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  DATE :
            </p>
        </td>
        <td width="30%" >
            <br><br>
            _______________________________<br>
            ผู้ตรวจ<br>
            ______________________________<br>
            <p class="text-left">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  DATE :
            </p>
        </td>
        <td width="40%">
            ข้อมูลการรับชำระ <input type="checkbox">เงินโอน <input type="checkbox"> เช็ค <br>
            ธนาคาร ________________________________________<br>
            สาขา _________________________<input type="checkbox">ต่างจังหวัด<br>
            ผู้อนุมัติ _____________________ DATE :________________
        </td>
    </tr>
</table>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    $(document).ready(function () {
        ShowCompany('#divCompany');
        let branch = getQueryString('branch');
        let controlno = getQueryString('code');
        $.get(path + 'acc/getvoucher?branch=' + branch + '&code=' + controlno, function (r) {
            if (r.voucher.header !== null) {
                ShowData(r.voucher);
            }
        });
    });
    function ShowData(data) {
        let div = $('#tbData tbody');
        if (data.payment !== null) {
            let totalnet = 0;
            for(let obj of data.payment) {
                let acType=obj.acType;
                let acTypeName = GetPaymentType(acType);
                let payType = '';
                let desc = '';
                let desc0 = '';

                totalnet += obj.TotalNet;
                switch (acType) {
                    case 'CA':
                        payType = 'เงินสดย่อย';
                        if (obj.RecvBank !== null) {
                            payType = 'เงินฝากธนาคารหมุนเวียน';
                        }
                        desc0 += obj.PayChqTo !== null ? '<br/>ออกให้กับ ' + obj.PayChqTo : '';
                        desc0 += obj.RecvBank != null ? '<br/>โอนไปยังบัญชีธนาคาร ' + obj.RecvBank + ' สาขา ' + obj.RecvBranch + ' เลขที่บัญชี ' + obj.DocNo : '';
                        desc0 += obj.BookCode != null ? '<br/>จากเลขที่บัญชี ' + obj.BookCode : '';
                        desc0 += obj.TRemark != null ? '<br/>วันเวลาที่ทำรายการ : ' + obj.TRemark : '';
                        break;
                    case 'CH':
                        payType = 'เช็คเงินสด';
                    case 'CU':
                        payType = 'เช็ครับล่วงหน้า';
                        desc0 += obj.ChqNo !== null ? '<br/>เช็คเลขที่ ' + obj.ChqNo + ' ลงวันที่ ' + ShowDate(CDateTH(obj.ChqDate)) : '';
                        desc0 += obj.BankCode != null ? '<br/>เช็คธนาคาร ' + obj.BankCode + ' สาขา ' + obj.BankBranch : '';
                        desc0 += obj.PayChqTo !== null ? '<br/>ออกให้กับ ' + obj.PayChqTo : '';
                        desc0 += obj.TRemark != null ? '<br/>หมายเหตุ : ' + obj.TRemark : '';
                        desc0 += obj.RecvBank != null ? '<br/>นำฝากไปยังบัญชีธนาคาร ' + obj.RecvBank + ' สาขา ' + obj.RecvBranch : '';
                        break;
                    case 'CR':
                        payType = 'ลูกหนี้';
                        desc0 += obj.DocNo !== null ? '<br/>ตามเอกสารเลขที่ ' + obj.DocNo + ' ลงวันที่ ' + ShowDate(CDateTH(obj.ChqDate)) : '';
                        desc0 += obj.PayChqTo !== null ? '<br/>ออกให้กับ ' + obj.PayChqTo : '';
                        break;
                }
                desc = '<tr class="text-center">';
                desc += '<td width="5%">'+obj.SICode+'</td>';
                desc += '<td width="10%">'+obj.ForJNo+'</td>';
                desc += '<td class="text-left" width="60%">'+desc0+'</td>';
                desc += '<td width="25"  style="text-align:right">'+CCurrency(CDbl(obj.TotalNet,2))+'</td>';
                desc += '</tr>';

                //summary section    
                $('#lblTotalNet').text(CCurrency(CDbl(totalnet, 2)));
                $('#lblTotalText').text(CNumThai(totalnet));
            }
        }
        if (data.header !== null) {
            $('#lblControlNo').text(data.header[0].ControlNo);
            $('#lblVoucherDate').text(ShowDate(CDateTH(data.header[0].VoucherDate)));
            $('#lblTRemark').text(data.header[0].TRemark);
            ShowUser(path, data.header[0].RecUser, '#lblRecByName');
            ShowCustomer(path, data.header[0].CustCode, data.header[0].CustBranch, '#lblCustName');
        }
    }    

</script>