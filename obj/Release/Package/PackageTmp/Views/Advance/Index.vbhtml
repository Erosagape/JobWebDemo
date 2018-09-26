
@Code
    ViewBag.Title = "Advance"
End Code
<div>
    @Code
        If ViewBag.User = "" Then
            Html.Label("You are not authorized")
        Else
            Html.Label("WelCome " + ViewBag.User)
        End If
    End Code
</div>
