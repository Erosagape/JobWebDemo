
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        @If ViewBag.User = "" Then
            Html.Label("You are not authorized")
        Else
            Html.Label("WelCome " + ViewBag.User)
        End If
    </div>
</body>
</html>
