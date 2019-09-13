Imports System.Web.Http
Imports System.Web.Mvc
Imports Newtonsoft.Json

Namespace Controllers
    Public Class ReportController
        Inherits CController

        ' GET: Report
        Function Index() As ActionResult
            ViewBag.ReportName = "Reports"
            Return GetView("Index", "MODULE_REP")
        End Function
        Function Import() As ActionResult
            Return GetView("Import", "MODULE_REP")
        End Function
        Function Export() As ActionResult
            Return GetView("Export", "MODULE_REP")
        End Function
        Function Preview() As ActionResult
            Return GetView("Preview")
        End Function
        Function GetSQLCommand(cliteria As String, fldDate As String, fldCust As String, fldJob As String, fldEmp As String, fldVend As String, fldStatus As String, fldBranch As String) As String
            Dim sqlW As String = ""
            For Each str As String In cliteria.Split(",")
                If str <> "" Then
                    If sqlW <> "" Then
                        If str.Substring(0, 2) <> "OR" Then
                            sqlW &= " AND ("
                        Else
                            sqlW = "(" & sqlW & ")"
                            str = str.Replace("OR", " OR ((")
                        End If
                    Else
                        sqlW &= "("
                    End If
                    If fldBranch <> "" Then str = ProcessCliteria(str, "[BRANCH]", fldBranch)
                    If fldDate <> "" Then str = ProcessCliteria(str, "[DATE]", fldDate)
                    If fldCust <> "" Then str = ProcessCliteria(str, "[CUST]", fldCust)
                    If fldJob <> "" Then str = ProcessCliteria(str, "[JOB]", fldJob)
                    If fldEmp <> "" Then str = ProcessCliteria(str, "[EMP]", fldEmp)
                    If fldStatus <> "" Then str = ProcessCliteria(str, "[STATUS]", fldStatus)
                    If fldVend <> "" Then str = ProcessCliteria(str, "[VEND]", fldVend)
                    sqlW &= str
                    If sqlW <> "" Then
                        sqlW &= ")"
                    End If
                End If
            Next
            If sqlW.Substring(0, 2) = "((" Then
                sqlW &= ")"
            End If
            Return sqlW
        End Function
        Private Function ProcessCliteria(str As String, key As String, val As String) As String
            If str.Contains(key) Then
                Dim fld As String = str.Replace(key, " " & val & " ")
                fld = FindFieldCliteria(fld) & FindValueCliteria(str)
                Return fld
            Else
                Return str
            End If
        End Function
        Private Function FindFieldCliteria(str As String) As String
            If str.IndexOf(">=") > 0 Then
                Return str.Split(">=")(0)
            End If
            If str.IndexOf("<=") > 0 Then
                Return str.Split("<=")(0)
            End If
            If str.IndexOf("<>") > 0 Then
                Return str.Split("<>")(0)
            End If
            If str.IndexOf("LIKE%") > 0 Then
                Return str.Split("LIKE%")(0)
            End If
            If str.IndexOf("=") > 0 Then
                Return str.Split("=")(0)
            End If
            Return ""
        End Function

        Private Function FindValueCliteria(str As String) As String
            If str.IndexOf(">=") > 0 Then
                Return ">='" & str.Split(">=")(1).Substring(1) & "'"
            End If
            If str.IndexOf("<=") > 0 Then
                Return "<='" & str.Split("<=")(1).Substring(1) & "'"
            End If
            If str.IndexOf("<>") > 0 Then
                Return "<>'" & str.Split("<>")(1).Substring(1) & "'"
            End If
            If str.IndexOf("LIKE%") > 0 Then
                Return "Like '" & str.Split("LIKE%")(1).Substring(3) & "%'"
            End If
            If str.IndexOf("=") > 0 Then
                Return "='" & str.Split("=")(1) & "'"
            End If
            Return "''"
        End Function
        Function GetReport(<FromBody()> data As CReport) As ActionResult
            Dim sqlM As String = ""
            Dim sqlW As String = ""
            Dim cliteria As String = data.ReportCliteria
            Try
                Select Case data.ReportCode
                    Case "JOBDAILY"
                        sqlW = GetSQLCommand(cliteria, "j.DocDate", "j.CustCode", "j.JNo", "j.CSCode", "j.AgentCode", "j.JobStatus", "j.BranchCode")
                        If sqlW <> "" Then sqlW = " WHERE " & sqlW
                        sqlM = "SELECT j.JNo,j.InvNo,j.DocDate,j.DutyDate,j.ShippingEmp,j.InvProduct,j.InvProductQty,j.TotalGW,j.TotalContainer FROM (" & SQLSelectJobReport() & sqlW & ") j ORDER BY j.DutyDate DESC"
                    Case "JOBCS"
                        sqlW = GetSQLCommand(cliteria, "j.DocDate", "j.CustCode", "j.JNo", "j.CSCode", "j.AgentCode", "j.JobStatus", "j.BranchCode")
                        If sqlW <> "" Then sqlW = " WHERE " & sqlW
                        sqlM = "SELECT j.JNo,j.InvNo,j.DocDate,j.DutyDate,j.CSCode,j.InvProduct,j.InvProductQty,j.TotalGW,j.TotalContainer FROM (" & SQLSelectJobReport() & sqlW & ") j  ORDER BY j.CSCode DESC"
                    Case "JOBSHP"
                        sqlW = GetSQLCommand(cliteria, "j.DocDate", "j.CustCode", "j.JNo", "j.CSCode", "j.AgentCode", "j.JobStatus", "j.BranchCode")
                        If sqlW <> "" Then sqlW = " WHERE " & sqlW
                        sqlM = "SELECT j.JNo,j.InvNo,j.DocDate,j.DutyDate,j.ShippingEmp,j.InvProduct,j.InvProductQty,j.TotalGW,j.TotalContainer FROM (" & SQLSelectJobReport() & sqlW & ") j  ORDER BY j.ShippingEmp DESC"
                    Case "JOBTYPE"
                        sqlW = GetSQLCommand(cliteria, "j.DocDate", "j.CustCode", "j.JNo", "j.CSCode", "j.AgentCode", "j.JobStatus", "j.BranchCode")
                        If sqlW <> "" Then sqlW = " WHERE " & sqlW
                        sqlM = "SELECT j.JNo,j.InvNo,j.JobTypeName,j.ShipByName,j.DutyDate,j.InvProduct,j.InvProductQty,j.TotalGW,j.TotalContainer FROM (" & SQLSelectJobReport() & sqlW & ") j  ORDER BY j.JobType,j.CustCode,j.ShipBy,j.DocDate DESC"
                    Case "JOBSHIPBY"
                        sqlW = GetSQLCommand(cliteria, "j.DocDate", "j.CustCode", "j.JNo", "j.CSCode", "j.AgentCode", "j.JobStatus", "j.BranchCode")
                        If sqlW <> "" Then sqlW = " WHERE " & sqlW
                        sqlM = "SELECT j.JNo,j.InvNo,j.JobTypeName,j.ShipByName,j.DutyDate,j.InvProduct,j.InvProductQty,j.TotalGW,j.TotalContainer FROM (" & SQLSelectJobReport() & sqlW & ") j  ORDER BY j.ShipBy,j.CustCode,j.JobType,j.DocDate DESC"
                    Case "JOBCUST"
                        sqlW = GetSQLCommand(cliteria, "j.DocDate", "j.CustCode", "j.JNo", "j.CSCode", "j.AgentCode", "j.JobStatus", "j.BranchCode")
                        If sqlW <> "" Then sqlW = " WHERE " & sqlW
                        sqlM = "SELECT j.JNo,j.InvNo,j.DocDate,j.DutyDate,j.CustCode,j.InvProduct,j.InvProductQty,j.TotalGW,j.TotalContainer FROM (" & SQLSelectJobReport() & sqlW & ") j  ORDER BY j.CustCode,j.DutyDate DESC"
                    Case "JOBPORT"
                        sqlW = GetSQLCommand(cliteria, "j.DocDate", "j.CustCode", "j.JNo", "j.CSCode", "j.AgentCode", "j.JobStatus", "j.BranchCode")
                        If sqlW <> "" Then sqlW = " WHERE " & sqlW
                        sqlM = "SELECT j.JNo,j.InvNo,j.DocDate,j.DutyDate,j.ClearPort,j.InvProduct,j.InvProductQty,j.TotalGW,j.TotalContainer FROM (" & SQLSelectJobReport() & sqlW & ") j  ORDER BY j.ClearPort,j.CustCode,j.DutyDate DESC"
                    Case "JOBADV"
                        sqlW = GetSQLCommand(cliteria, "c.PaymentDate", "c.CustCode", "a.ForJNo", "c.ReqBy", "a.VenCode", "c.DocStatus", "a.BranchCode")
                        If sqlW <> "" Then sqlW = " WHERE " & sqlW
                        sqlM = "SELECT t.PaymentDate,t.AdvNo,t.JobNo,t.ReqBy,t.SDescription,t.VenderCode,t.AdvNet,t.UsedAmount,t.AdvBalance FROM (" & SQLSelectAdvForClear() & sqlW & ") t ORDER BY t.PaymentDate,t.AdvNo"
                    Case "JOBVOLUME"
                        sqlW = GetSQLCommand(cliteria, "j.DocDate", "j.CustCode", "j.JNo", "j.CSCode", "j.AgentCode", "j.JobStatus", "j.BranchCode")
                        If sqlW <> "" Then sqlW = " WHERE " & sqlW
                        sqlM = "SELECT j.*,c.NameThai FROM (" & SQLSelectJobCount(sqlW, "j.CustCode") & ") j INNER JOIN Mas_Company c ON j.CustCode=c.CustCode ORDER BY c.NameThai"
                    Case "JOBSTATUS"
                        sqlW = GetSQLCommand(cliteria, "j.DocDate", "j.CustCode", "j.JNo", "j.ManagerCode", "j.AgentCode", "j.JobStatus", "j.BranchCode")
                        If sqlW <> "" Then sqlW = " WHERE " & sqlW
                        sqlM = "SELECT j.*,c.TName FROM (" & SQLSelectJobCount(sqlW, "j.CSCode") & ") j INNER JOIN Mas_User c ON j.CSCode=c.UserID ORDER BY c.TName"
                    Case "JOBSALES"
                        sqlW = GetSQLCommand(cliteria, "j.DocDate", "j.CustCode", "j.JNo", "j.ManagerCode", "j.AgentCode", "j.JobStatus", "j.BranchCode")
                        If sqlW <> "" Then sqlW = " WHERE " & sqlW
                        sqlM = "SELECT j.*,c.TName FROM (" & SQLSelectJobCount(sqlW, "j.ManagerCode") & ") j INNER JOIN Mas_User c ON j.ManagerCode=c.UserID ORDER BY c.TName"
                    Case "JOBCOMM"

                    Case "ADVDAILY"

                    Case "EXPDAILY"

                    Case "RCPDAILY"

                    Case "TAXDAILY"

                    Case "CASHDAILY"

                    Case "CLRDAILY"

                    Case "INVDAILY"

                    Case "BILLDAILY"

                    Case "JOBCOST"

                    Case "BOOKBAL"

                    Case "VATSALES"

                    Case "VATBUY"

                    Case "WHTAX"

                    Case "ACCEXP"

                    Case "ACCINC"

                    Case "ARBAL"

                    Case "APBAL"

                    Case "CNDN"

                    Case "TRIALBAL"

                    Case "BALANCS"

                    Case "PROFITLOSS"

                    Case "CASHFLOW"

                    Case "JOURNAL"

                End Select
                Dim oData = New CUtil(jobWebConn).GetTableFromSQL(sqlM)
                Dim json As String = JsonConvert.SerializeObject(oData)
                Return Content("{""result"":" & json & ",""msg"":""OK"",""sql"":""" & sqlW & """}")
            Catch ex As Exception
                Return Content("{""result"":[],""msg"":""" & ex.Message & """,""sql"":""" & sqlW & """}")
            End Try
        End Function
    End Class
End Namespace