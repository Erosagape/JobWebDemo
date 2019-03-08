
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Billing Slip"
End Code
        <h1 class="text-center" style="margin-bottom:50px">BILLING NOTE</h1>
        <div style="display:flex;">
            <div style="flex:1;" class="text-left">
                <p>
                  TAX-ID : 0105512002448 HEAD OFFICE
                </p>
            </div>
            <div style="flex:1;" class="text-right">
                DOC NO : BN-1802-0001
                <br />DATE : 08/02/2018
            </div>
        </div>
        <div style="display:flex;">
            <div class="text-left">
                <p>
                    NAME : YUSEN LOGISTICS (THAILAND) CO.,LTD
                </p>
            </div>
        </div>
        <div style="display:flex;flex-direction:column">
            <div style="flex:1" class="text-left">
                2525, ONE,TWO, FYI CENTER,2ND,6TH,7TH FLOOR,RAMA 4 ROAD KLONGTOEY,<br />
                KLONGTOEY,BANGKOK 10110 THAILAND
            </div>
            <div style="flex:1"  class="text-left">
                <br/>
                PLEASE APPROVE BEFORE PAYMENT             
            </div>                
        </div>
        <table border="3" style="border-style:solid black ;width:100%;  margin-top:5px ">
            <tr>
                <th class="text-center" width="100" rowspan="2">ITEMS</th>
                <th class="text-center" width="100" rowspan="2">ISSUE DATE</th>
                <th class="text-center" width="130" rowspan="2">INVOICE NO.</th>
                <th class="text-center" width="130" rowspan="2">JOB NO.</th>
                <th class="text-center" colspan="2">AMOUNT</th>

                <th class="text-center" width="60" rowspan="2">VAT</th>
                <th class="text-center" colspan="2">W/H</th>
                <th class="text-center" width="100" rowspan="2">TOTAL</th>


            </tr>
            <tr>




                <th class="text-center"  width="130">REIMBURSEMENT</th>
                <th class="text-center"  width="90">SERVICE</th>
                <th class="text-center"  width="50">1%</th>
                <th class="text-center"  width="50">3%</th>
            </tr>
            <tr>
                <td>1</td>
                <td>08/02/2018</td>
                <td>INV-1802-00021</td>
                <td>IS1802-00014</td>
                <td>12,000.00</td>

                <td>1500.00</td>
                <td>105.00</td>
                <td>0.00</td>
                <td>0.00</td>
                <td>13,605.00</td>
            </tr>
            <tr>
                <td colspan="4">&nbsp;</td>
                <td colspan="5" class="text-right" >TOTAL</td>
                <td colspan="1">13,605.00</td>



            </tr>
            <tr style="background-color:lightblue">
                <th class="text-center"  colspan="10">THIRTEEN THOUSAND SIX HUNDRED AND FIVE ONLY</th>

            </tr>
        </table>

        <div style="margin-top:60px">
            <p>PAYMENT TERMS... 30... DAYS (FROM BILLING DATE) ________/________/____________</p>
            <p>PLEASE PAY CHEQUE IN NAME KSA (THAILAND)CO.,LTD.</p>
            <p>PAYMENT SHOULD BE PAID BY CROSS CHEQUE IN FAVOR OF KSA (THAILAND) CO.,LTD.</p>
            <p>SIGN ON RECEIVER AND ASSIGNED PAYMENT DATE AND SEND THIS PAPER TO KSA (THAILAND)CO.,LTD. FAX.0-22583689</p>
        </div>

        <div style="display:flex">
            <div class="text-center" style="flex:1;border:1px solid black ;border-radius:5px">
                FOR THE CUSTOMER<br/>
                <br/><br /><br /><br />
                __________________________________________<br/>
                .........................................<br />
                _____/______/______
            </div>
            <div class="text-center" style="flex:1;border:1px solid black ;border-radius:5px">
                FOR KSA (THAILAND) CO.,LTD.<br />
                <br /><br /><br /><br />
                __________________________________________<br />
                .........................................<br />
                _____/______/______
            </div>
        </div>