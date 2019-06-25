@Code
    Layout = "~/Views/Shared/_ReportNoHeadLandscape.vbhtml"
End Code
<style>
    * {
        font-family: Tahoma;
        font-size: 12px;
    }

    #circle {
        width: 50px; /* ความกว้าง */
        height: 50px; /* ความสูง */
        -moz-border-radius: 70px;
        -webkit-border-radius: 70px;
        border: 1px solid #000000;
        border-radius: 50%;
    }

    .one {
        border-style: solid;
        border-width: 1px;
        width: 500px;
        margin-right: auto;
        float: right;
        padding: 1px;
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
        ใบแนบ ภ.ง.ด.53 เลขที่ประจำตัวผู้เสียภาษีอากร (ของผู้มีหน้าที่หักภาษี ณ ที่จ่าย)
    </p>
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
    <p>
        สาขา
    </p>
    <div>1</div>
    <div>2</div>
    <div>3</div>
    <div>4</div>
    <div>5</div>
</div>

<div class="text-right">
    <p>
        แผ่นที่...............ในจำนวน..................แผ่น
    </p>
</div>
<div id="report" class="text-center">
    <table border="1" style="border-style:solid;width:100%">
        <tr>
            <td rowspan="2" style="vertical-align:top">
                <p>ลำดับที่</p>
            </td>

            <td colspan="" style="vertical-align:top">
                <p>เลขประจำตัวผู้เสียภาษีอากร (ของผู้มีเงินได้)</p>
            </td>

            <td rowspan="2" style="vertical-align:top">
                <p>สาขาที่</p>
            </td>
            <td colspan="4" style="vertical-align:top">
                <p>รายละเอียดเกี่ยวกับการจ่ายเงิน</p>
            </td>
            <td rowspan="2" style="vertical-align:top">
                <p>จำนวนเงินภาษีที่หักและนำส่งในครั้งนี้</p>
            </td>
            <td rowspan="2" style="vertical-align:top">
                <p>2 เงื่อนไข</p>
            </td>
        </tr>

        <tr>
            <td style="vertical-align:top">
                ชื่อและที่อยู่ของผู้มีเงินได้
                <p>
                    (ให้ระบุให้ชัดเจนว่าเป็น บริษัทจำกัด ห้างหุ้นส่วนจำกัด หรือ ห้างหุ้นส่วนสามัญนิติบุคคลและให้ระบุเลขที่ ตรอก/ซอย ถนน ตำบล/แขวง อำเภอ/เขต จังหวัด)
                </p>
            </td>

            <td style="vertical-align:top">
                <p>
                    วันที่ เดือน ปี ที่จ่าย
                </p>

            </td>

            <td style="vertical-align:top">
                <p>
                    1 ประเภทเงินได้พึงประเมินที่จ่าย
                </p>

            </td>

            <td style="vertical-align:top">
                <p>
                    อัตราภาษีร้อยละ
                </p>

            </td>
            <td style="vertical-align:top">
                <p>
                    จำนวนเงินที่จ่ายในครั้งนี้
                </p>

            </td>



        </tr>

        <tr>
            <td></td>
            <td>
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
                </div>
                <p class="text-left">ชื่อ ...................................................................</p>
                <p class="text-left">ที่อยู่....................................................................</p>
            </td>

            <td>
                <div class="flex-container">
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>
                </div>

            </td>

            <td>........................</td>
            <td>.........................................</td>
            <td>.........</td>
            <td>........................</td>
            <td>........................</td>
            <td>........................</td>

        </tr>

        <tr>
            <td></td>
            <td>
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
                </div>
                <p class="text-left">ชื่อ ...................................................................</p>
                <p class="text-left">ที่อยู่....................................................................</p>
            </td>

            <td>
                <div class="flex-container">
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>
                </div>

            </td>

            <td>........................</td>
            <td>.........................................</td>
            <td>.........</td>
            <td>........................</td>
            <td>........................</td>
            <td>........................</td>

        </tr>

        <tr>
            <td></td>
            <td>
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
                </div>
                <p class="text-left">ชื่อ ...................................................................</p>
                <p class="text-left">ที่อยู่....................................................................</p>
            </td>

            <td>
                <div class="flex-container">
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>
                </div>

            </td>

            <td>........................</td>
            <td>.........................................</td>
            <td>.........</td>
            <td>........................</td>
            <td>........................</td>
            <td>........................</td>

        </tr>

        <tr>
            <td></td>
            <td>
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
                </div>
                <p class="text-left">ชื่อ ...................................................................</p>
                <p class="text-left">ที่อยู่....................................................................</p>
            </td>

            <td>
                <div class="flex-container">
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>
                </div>

            </td>

            <td>........................</td>
            <td>.........................................</td>
            <td>.........</td>
            <td>........................</td>
            <td>........................</td>
            <td>........................</td>

        </tr>

        <tr>
            <td></td>
            <td>
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
                </div>
                <p class="text-left">ชื่อ ...................................................................</p>
                <p class="text-left">ที่อยู่....................................................................</p>
            </td>

            <td>
                <div class="flex-container">
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>
                </div>

            </td>

            <td>........................</td>
            <td>.........................................</td>
            <td>.........</td>
            <td>........................</td>
            <td>........................</td>
            <td>........................</td>

        </tr>

        <tr>
            <td></td>
            <td>
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
                </div>
                <p class="text-left">ชื่อ ...................................................................</p>
                <p class="text-left">ที่อยู่....................................................................</p>
            </td>

            <td>
                <div class="flex-container">
                    <div>1</div>
                    <div>2</div>
                    <div>3</div>
                    <div>4</div>
                    <div>5</div>
                </div>

            </td>

            <td>........................</td>
            <td>.........................................</td>
            <td>.........</td>
            <td>........................</td>
            <td>........................</td>
            <td>........................</td>

        </tr>
        <tr>
            <td colspan="6">
                <p>รวมยอดเงินได้และภาษีที่นำส่ง (นำไปรวมกับ <b>ใบแนบ ภ.ง.ด.53 </b>แผ่นอื่น(ถ้ามี))</p>

            </td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td class="text-left" colspan="4">
                <p>(ให้กรอกลำดับที่ต่อเนื่องกันไปทุกแผ่น)</p>
                <p>
                    <b>หมายเหตุ</b> 1 ให้ระบุว่าจ่ายเป็นค่าอะไร เช่นค่านายหน้า ค่าแห่งกู๊ดวิลล์ ดอกเบี้ยเงินฝาก ดอกเบี้ยตั๋วเงิน เงินปันผล เงินส่วนแบ่งกำไร
                    ค่าเช่าอาคาร ค่าสอบบัญชี ค่าออกแบบ ค่าก่อสร้างโรงเรียน ค่าซื้อเครื่องพิมพ์ดีด ค่าซื้อพืชผลทางการเกษตร (ยางพารา
                    มันสำปะหลัง ปอ ข้าว ฯลฯ )ค่าจ้างทำของ ค่าจ้างโฆษณา รางวัล ส่วนลดหรือประโยชน์ใดๆ เนื่องจากกการส่งเสริมการขาย รางวัล ในการประกวด
                    การแข่งขัน การชิงโชค ค่าขนส่งสินค้า ค่าเบี้ยประกันวินาศภัย<br>
                </p><p>
                    2 เงื่อนไขการหักภาษี ณ ที่จ่ายให้กรอกดังนี้<br>
                    หัก ณ ที่จ่าย กรอก 1<br>
                    ออกภาษีให้ กรอก 2
                </p>


            </td>
            <td colspan="5">
                <div class="text-center " id="circle"><h6>ตราประทับนิติบุคคลถ้ามี</h6></div>
                <p>
                    ลงชื่อ.....................................................ผู้จ่ายเงิน<br>
                    (.......................................................)<br>
                    ตำแหน่ง........................................................<br>
                    ยื่น.........เดือน........................พ.ศ. ............
                </p>


            </td>


        </tr>

    </table>
    <p>สอบถามข้อมูลเพิ่มเติมได้ที่ศูนย์สารนิเทศสรรพากร RD Intelligence Center โทร. 1161</p>
</div>



