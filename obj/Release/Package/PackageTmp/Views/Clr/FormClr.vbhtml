
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Clearing Slip"
    ViewBag.ReportName = "CLEARING SLIP"
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
    <div style="flex:1" class="text-left">
        EXPENSE CLEARING &nbsp;&nbsp;&nbsp; <label id="txtJobType"></label>
    </div>

    <div style="flex:1;text-align:right">
        <label id="txtBranchName"></label>
    </div>
</div>

<div style="display:flex">
    <div style="flex:1" class="text-left">
        OPERATION DATE : <label id="txtClearanceDate"></label>
    </div>

    <div style="flex:1;text-align:right">
        <label id="txtDocStatus"></label>
    </div>
</div>

<div style="display:flex">
    <div style="flex:2">
        CTN NO : <label id="txtContainerNo"></label>
    </div>
    <div style="flex:1">
        CLEAR DATE : <label id="txtDocDate"></label>
    </div>
    <div style="flex:1">
        DOC NO : <label id="txtClrNo"></label>
    </div>
</div>

<div style="display:flex;flex-wrap:wrap;">
    <div style="flex:1">
        CO-PERSON : <label id="txtCopersonCode"></label>
    </div>
</div>

<div style="display:flex">
    <div style="flex:1">
        REMARK : <label id="txtRemark"></label>
    </div>
</div>

<div style="display:flex">
    <div style="flex:1">
        ADV REF : <label id="txtAdvNo"></label>
    </div>
    <div style="flex:1">
        CUST NANE : <label id="txtCustName"></label>
    </div>
</div>

<table id="tbDetail" border="1" width="100%">
    <tr class="text-center">
        <th width="10%">CODE.</th>
        <th width="50%">DESCRIPTION</th>
        <th width="20%">JOBNO</th>
        <th width="10%">WHTAK</th>
        <th width="10%">PAID</th>
    </tr>
    <tr>
        <td colspan = "4" >
            <div style="display:flex">
                <div style="flex:1" class="text-left">
                    CLEARING TYPE : <label id="txtClrType"></label>
                    <br/>
                    CLEARING FROM :  <label id="txtClrFrom"></label>
                </div>
                <div style="flex:1 ;text-align:right">
                    AMOUNT (VAT)
                    <br/>
                    AMOUNT (NON-VAT)
                    <br/>
                    VAT
                    <br/>
                    AMOUNT (WHT)
                    <br/>
                    WITH-HOLDING TAX
                    <br/>
                    CLEARING TOTAL
                </div>
            </div>                                                                                        
        </td>
        <td style = "text-align:right" >
            <div style="display:flex">
                <div style="flex:1">
                    <label id="txtAmtVat"></label>
                    <br/>
                    <label id="txtAmtNonVat"></label>
                    <br/>
                    <label id="txtVat"></label>
                    <br/>
                    <label id="txtAmtWht"></label>
                    <br/>
                    <label id="txtWht"></label>
                    <br/>
                    <label id="txtTotal"></label>
                </div>
            </div>                                                                                        
        </td>
    </tr>
</table>
<div style = "display:flex" >
    <div style="flex:1">
        Total Advance : <label id="txtTotalAdv"></label>
    </div>
    <div style = "flex:1" >
        Total Clear : <label id="txtTotalClear"></label>                                                                                    
    </div>
    <div style = "flex:1" >
        Total Return : <label id="txtTotalReturn"></label>                                                                                    
    </div>
</div>
<table border = "1" width="100%" style="margin-top:50px">
    <tr Class="text-center">
        <th> CLEARING BY</th>
        <th> APPROVED BY</th>
        <th> FINANCIAL</th>
        <th> ACCOUNTING</th>
        <th> PAYEE</th>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr Class="text-center">
        <td>
            <label id="txtClrBy"></label>
                <br />
            <br />
            <label id = "txtPrintDate"></label>                                                                                                          
        </td>
        <td>
            <label id="txtApproveBy"></label>
                <br />
            <br />
            <label id="txtApproveDate"></label>                                                                                                            
        </td>
        <td>
            <label id="txtReceiveBy"></label>
                <br />
            <br />
            <label id="txtReceiveDate"></label>                                                                                                            
        </td>
        <td>
                <br />
            <br />
            ________/_______/_______
        </td>
        <td>
                <br />
            <br />
            ________/_______/_______
        </td>
    </tr>
</table>
