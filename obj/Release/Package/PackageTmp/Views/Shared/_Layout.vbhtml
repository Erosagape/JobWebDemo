<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title</title>
    @Styles.Render("~/Content/css")
</head>
<body>
    <div Class="panel-primary">
        <div Class="panel-heading">
            <h4 Class="panel-title">
                @ViewBag.Title
            </h4>
        </div>
        <div class="panel-body">
            @RenderBody()
        </div>
        <div class="panel-footer">
            <p>&copy; @DateTime.Now.Year - Tawan Technology Co.,ltd</p>
        </div>
    </div>
</body>
</html>
