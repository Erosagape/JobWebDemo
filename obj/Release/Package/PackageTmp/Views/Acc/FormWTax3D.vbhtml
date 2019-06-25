@Code
    Layout = "~/Views/Shared/_ReportNoHeadLandscape.vbhtml"
End Code
<style>
    * {
        font-family: Tahoma;
        font-size: 12px;
    }

    .circle {
        width: 100px; /* ความกว้าง */
        height:100px; /* ความสูง */
        -moz-border-radius: 70px;
        -webkit-border-radius: 70px;
        border: 1px solid #000000;
        border-radius: 50%;
        text-align: center;
    }

    .flex-container {
        display: flex;
        flex-wrap: nowrap;
    }

        .flex-container > div {
            background-color: #f1f1f1;
            width: 15px;
            margin: 1px;
            text-align: center;
            line-height: 20px;
            font-size: 7px;
        }
</style>

<div class="flex-container">
    <p>
        ใบแนบ ภ.ง.ด.3 เลขที่ประจำตัวผู้เสียภาษีอากร (ของผู้มีหน้าที่หักภาษี ณ ที่จ่าย)
    </p>
    <div>1</div>
    <div>2</div>
    <div>3</div>
    <div>4</div>
    <div>5</div>
    <div>6</div>
    <div>7</div>
    <div>8</div>
    <div>9</div>
    <div>10</div>
    <div>11</div>
    <div>12</div>
    <div>13</div>

    <p>
        สาขา
        <div>1</div>
        <div>2</div>
        <div>3</div>
        <div>4</div>
        <div>5</div>
    </p>



</div>

<div class="text-right">
    <p>
        แผ่นที่...............ในจำนวน..................แผ่น
    </p>
</div>
<div id="report" class="text-center" style="width:100%">
    <table border="1" style="border-style:solid;border-width:thin;border-collapse:collapse;">
        <tr>
            <td rowspan="3">
                <p>ลำดับที่</p>
            </td>

            <td>
                <p>เลขประจำตัวผู้เสียภาษีอากร (ของผู้มีเงินได้)</p>
            </td>

            <td>
                <p>สาขา</p>
            </td>
            <td colspan="4">
                <p>รายละเอียดเกี่ยวกับการจ่ายเงิน</p>
            </td>
            <td colspan="3">
                <p>รวมเงินภาษีที่หักและนำส่งในครั้งนี้</p>
            </td>

        </tr>

        <tr>
            <td colspan="2">
                ชื่อผู้มีเงินได้
                <p>
                    (ให้ระบุให้ชัดเจนว่าเป็น นาย นาง นางสาวหรือยศ)
                </p>
            </td>

            <td rowspan="2">
                <p>
                    วัน เดือน ปี<br> ที่จ่าย
                </p>

            </td>

            <td rowspan="2">
                <p>
                    1 ประเภทเงินได้<br>(ถ้ามากกว่าหนึ่งประเภทให้กรอกเรียงลงไป)
                </p>

            </td>

            <td rowspan="2">
                <p>
                    อัตราภาษีร้อยละ
                </p>

            </td>
            <td rowspan="2">
                <p>
                    จำนวนเงินที่จ่ายแต่ละประเภท<br>เฉพาะคนหนึ่งๆ ในครั้งนี้
                </p>

            </td>
            <td rowspan="2">
                <p>
                    จำนวนเงิน
                </p>
            </td>
            <td rowspan="2">
                <p>2 เงื่อนไข</p>
            </td>

        </tr>

        <tr>

            <td colspan="2">
                ที่อยู่ของผู้มีเงินได้ (ให้ระบุเลขที่ ตรอก/ซอย ถนน ตำบล/แขวง อำเภอ/เขต จังหวัด)
            </td>




        </tr>


        <tr>
            <td></td>
            <td colspan="2">
                <div class="flex-container">
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>
                    <div>6</div>
                    <div>7</div>
                    <div>9</div>
                    <div>10</div>
                    <div>11</div>
                    <div>12</div>
                    <div>13</div>
                    <div>สาขา</div>
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>

                </div>

                <p class="text-left">
                    ชื่อ
                <br />
                    ที่อยู่
                </p>
                
            </td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>


        </tr>

        <tr>
            <td></td>
            <td colspan="2">
                <div class="flex-container">
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>
                    <div>6</div>
                    <div>7</div>
                    <div>9</div>
                    <div>10</div>
                    <div>11</div>
                    <div>12</div>
                    <div>13</div>
                    <div>สาขา</div>
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>

                </div>
                <p class="text-left">
                    ชื่อ
                    <br />
                    ที่อยู่
                </p>

            </td>



            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>


        </tr>

        <tr>
            <td></td>
            <td colspan="2">
                <div class="flex-container">
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>
                    <div>6</div>
                    <div>7</div>
                    <div>9</div>
                    <div>10</div>
                    <div>11</div>
                    <div>12</div>
                    <div>13</div>
                    <div>สาขา</div>
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>

                </div>

                <p class="text-left">
                    ชื่อ
                    <br />
                    ที่อยู่
                </p>

            </td>



            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>


        </tr>

        <tr>
            <td></td>
            <td colspan="2">
                <div class="flex-container">
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>
                    <div>6</div>
                    <div>7</div>
                    <div>9</div>
                    <div>10</div>
                    <div>11</div>
                    <div>12</div>
                    <div>13</div>
                    <div>สาขา</div>
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>

                </div>
                <p class="text-left">
                    ชื่อ
                    <br />
                    ที่อยู่
                </p>

            </td>



            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>


        </tr>

        <tr>
            <td></td>
            <td colspan="2">
                <div class="flex-container">
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>
                    <div>6</div>
                    <div>7</div>
                    <div>9</div>
                    <div>10</div>
                    <div>11</div>
                    <div>12</div>
                    <div>13</div>
                    <div>สาขา</div>
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>

                </div>
                <p class="text-left">
                    ชื่อ
                    <br />
                    ที่อยู่
                </p>

            </td>



            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>


        </tr>


        <tr>
            <td colspan="6">
                <p>รวมยอดเงินได้และภาษีที่นำส่ง (นำไปรวมกับ <b>ใบแนบ ภ.ง.ด.3 </b>แผ่นอื่น(ถ้ามี))</p>

            </td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td class="text-left" colspan="4">
                (ให้กรอกลำดับที่ต่อเนื่องกันไปทุกแผ่น)
                <br>
                    <b>หมายเหตุ</b> 1 ให้ระบุว่าจ่ายเป็นค่าอะไร เช่น ค่าเช่าอาคาร ค่าสอบบัญชี ค่าทนายความ ค่าวิชาชีพของแพทย์<br>
                    ค่าก่อสร้าง รางวัล ส่วนลดหรือประโยชน์ใดๆ เนื่องจากการส่งเสริมการขาย รางวัลในการประกวด การแข่งขัน การชิงโชค ค่าจ้างแสดงภาพยนต์ ร้องเพลงดนตรี ค่าจ้างทำของ ค่าโฆษณา ค่าขนส่งสินค้า ฯลฯ
                <br>
                    2 เงื่อนไขการหักภาษี ณ ที่จ่ายให้กรอกดังนี้<br>
                    หัก ณ ที่จ่าย กรอก 1<br>
                    ออกภาษีให้ กรอก 2<br>
                    ออกให้ครั้งเดียว กรอก 3
            </td>
            <td colspan="3">
                <br>
                    ลงชื่อ.....................................................ผู้จ่ายเงิน<br>
                    (.......................................................)<br>
                    ตำแหน่ง........................................................<br>
                    ยื่นวันที่.........เดือน........................พ.ศ. ............
            </td>
            <td colspan="2">
                <div class="circle"><br /><br />ตราประทับ นิติบุคคล (ถ้ามี)</div>
            </td>

        </tr>

    </table>
</div>





