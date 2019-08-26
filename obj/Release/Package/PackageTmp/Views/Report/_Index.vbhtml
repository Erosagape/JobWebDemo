@Code
    Layout = "~/Views/Shared/_ReportLandscape.vbhtml"
    ViewBag.Title = "Report"
End Code
<table width="100%">
        <tr>
            <td style="border:1px solid black;text-align:center">
                #No
            </td>
            <td style="border:1px solid black;text-align:left">
                Description
            </td>
            <td style="border:1px solid black;text-align:center">
                Units
            </td>
            <td style="border:1px solid black;text-align:center">
                Total
            </td>
        </tr>
        @For i As Integer = 1 To 100
            @<tr>
                <td style="border:1px solid black;text-align:center">
                    @i
                </td>
                <td style="border:1px solid black;text-align:left">
                    Test Data
                </td>
                <td style="border:1px solid black;text-align:center">
                    1xLCL
                </td>
                <td style="border:1px solid black;text-align:right">
                    300.0
                </td>
            </tr>
        Next
        <tr>
            <td colspan="3" style="border:1px solid black;text-align:right;background-color:aquamarine">
                Total
            </td>
            <td style="border:1px solid black;text-align:right;background-color:aquamarine">
                800.00
            </td>
        </tr>
    </table>    
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let serv = [];
    let user = '@ViewBag.User';
    $(document).ready(function () {

    });
</script>