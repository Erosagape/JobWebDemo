﻿Imports System.Web.Mvc

Namespace Controllers
    Public Class MenuController
        Inherits CController
        ' GET: Menu
        Function Index() As ActionResult
            Return GetView("Index")
        End Function
        Function AuthError() As ActionResult
            Return GetView("AuthError")
        End Function
    End Class
End Namespace