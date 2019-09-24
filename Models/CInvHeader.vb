'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CInvHeader
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_BranchCode As String
    Public Property BranchCode As String
        Get
            Return m_BranchCode
        End Get
        Set(value As String)
            m_BranchCode = value
        End Set
    End Property
    Private m_DocType As String
    Public Property DocType As String
        Get
            Return m_DocType
        End Get
        Set(value As String)
            m_DocType = value
        End Set
    End Property
    Private m_DocNo As String
    Public Property DocNo As String
        Get
            Return m_DocNo
        End Get
        Set(value As String)
            m_DocNo = value
        End Set
    End Property
    Private m_DocDate As Date
    Public Property DocDate As Date
        Get
            Return m_DocDate
        End Get
        Set(value As Date)
            m_DocDate = value
        End Set
    End Property
    Private m_CustCode As String
    Public Property CustCode As String
        Get
            Return m_CustCode
        End Get
        Set(value As String)
            m_CustCode = value
        End Set
    End Property
    Private m_CustBranch As String
    Public Property CustBranch As String
        Get
            Return m_CustBranch
        End Get
        Set(value As String)
            m_CustBranch = value
        End Set
    End Property
    Private m_BillToCustCode As String
    Public Property BillToCustCode As String
        Get
            Return m_BillToCustCode
        End Get
        Set(value As String)
            m_BillToCustCode = value
        End Set
    End Property
    Private m_BillToCustBranch As String
    Public Property BillToCustBranch As String
        Get
            Return m_BillToCustBranch
        End Get
        Set(value As String)
            m_BillToCustBranch = value
        End Set
    End Property
    Private m_ContactName As String
    Public Property ContactName As String
        Get
            Return m_ContactName
        End Get
        Set(value As String)
            m_ContactName = value
        End Set
    End Property
    Private m_EmpCode As String
    Public Property EmpCode As String
        Get
            Return m_EmpCode
        End Get
        Set(value As String)
            m_EmpCode = value
        End Set
    End Property
    Private m_PrintedBy As String
    Public Property PrintedBy As String
        Get
            Return m_PrintedBy
        End Get
        Set(value As String)
            m_PrintedBy = value
        End Set
    End Property
    Private m_PrintedDate As Date
    Public Property PrintedDate As Date
        Get
            Return m_PrintedDate
        End Get
        Set(value As Date)
            m_PrintedDate = value
        End Set
    End Property
    Private m_PrintedTime As Date
    Public Property PrintedTime As Date
        Get
            Return m_PrintedTime
        End Get
        Set(value As Date)
            m_PrintedTime = value
        End Set
    End Property
    Private m_RefNo As String
    Public Property RefNo As String
        Get
            Return m_RefNo
        End Get
        Set(value As String)
            m_RefNo = value
        End Set
    End Property
    Private m_VATRate As Double
    Public Property VATRate As Double
        Get
            Return m_VATRate
        End Get
        Set(value As Double)
            m_VATRate = value
        End Set
    End Property
    Private m_TotalAdvance As Double
    Public Property TotalAdvance As Double
        Get
            Return m_TotalAdvance
        End Get
        Set(value As Double)
            m_TotalAdvance = value
        End Set
    End Property
    Private Property m_TotalDiscount As Double
    Public Property TotalDiscount As Double
        Get
            Return m_TotalDiscount
        End Get
        Set(value As Double)
            m_TotalDiscount = value
        End Set
    End Property
    Private m_TotalCharge As Double
    Public Property TotalCharge As Double
        Get
            Return m_TotalCharge
        End Get
        Set(value As Double)
            m_TotalCharge = value
        End Set
    End Property
    Private m_TotalIsTaxCharge As Double
    Public Property TotalIsTaxCharge As Double
        Get
            Return m_TotalIsTaxCharge
        End Get
        Set(value As Double)
            m_TotalIsTaxCharge = value
        End Set
    End Property
    Private m_TotalIs50Tavi As Double
    Public Property TotalIs50Tavi As Double
        Get
            Return m_TotalIs50Tavi
        End Get
        Set(value As Double)
            m_TotalIs50Tavi = value
        End Set
    End Property
    Private m_TotalVAT As Double
    Public Property TotalVAT As Double
        Get
            Return m_TotalVAT
        End Get
        Set(value As Double)
            m_TotalVAT = value
        End Set
    End Property
    Private m_Total50Tavi As Double
    Public Property Total50Tavi As Double
        Get
            Return m_Total50Tavi
        End Get
        Set(value As Double)
            m_Total50Tavi = value
        End Set
    End Property
    Private m_TotalCustAdv As Double
    Public Property TotalCustAdv As Double
        Get
            Return m_TotalCustAdv
        End Get
        Set(value As Double)
            m_TotalCustAdv = value
        End Set
    End Property
    Private m_TotalNet As Double
    Public Property TotalNet As Double
        Get
            Return m_TotalNet
        End Get
        Set(value As Double)
            m_TotalNet = value
        End Set
    End Property
    Private m_CurrencyCode As String
    Public Property CurrencyCode As String
        Get
            Return m_CurrencyCode
        End Get
        Set(value As String)
            m_CurrencyCode = value
        End Set
    End Property
    Private m_ExchangeRate As Double
    Public Property ExchangeRate As Double
        Get
            Return m_ExchangeRate
        End Get
        Set(value As Double)
            m_ExchangeRate = value
        End Set
    End Property
    Private m_ForeignNet As Double
    Public Property ForeignNet As Double
        Get
            Return m_ForeignNet
        End Get
        Set(value As Double)
            m_ForeignNet = value
        End Set
    End Property
    Private m_BillAcceptDate As Date
    Public Property BillAcceptDate As Date
        Get
            Return m_BillAcceptDate
        End Get
        Set(value As Date)
            m_BillAcceptDate = value
        End Set
    End Property
    Private m_BillIssueDate As Date
    Public Property BillIssueDate As Date
        Get
            Return m_BillIssueDate
        End Get
        Set(value As Date)
            m_BillIssueDate = value
        End Set
    End Property
    Private m_BillAcceptNo As String
    Public Property BillAcceptNo As String
        Get
            Return m_BillAcceptNo
        End Get
        Set(value As String)
            m_BillAcceptNo = value
        End Set
    End Property
    Private m_Remark1 As String
    Public Property Remark1 As String
        Get
            Return m_Remark1
        End Get
        Set(value As String)
            m_Remark1 = value
        End Set
    End Property
    Private m_Remark2 As String
    Public Property Remark2 As String
        Get
            Return m_Remark2
        End Get
        Set(value As String)
            m_Remark2 = value
        End Set
    End Property
    Private m_Remark3 As String
    Public Property Remark3 As String
        Get
            Return m_Remark3
        End Get
        Set(value As String)
            m_Remark3 = value
        End Set
    End Property
    Private m_Remark4 As String
    Public Property Remark4 As String
        Get
            Return m_Remark4
        End Get
        Set(value As String)
            m_Remark4 = value
        End Set
    End Property
    Private m_Remark5 As String
    Public Property Remark5 As String
        Get
            Return m_Remark5
        End Get
        Set(value As String)
            m_Remark5 = value
        End Set
    End Property
    Private m_Remark6 As String
    Public Property Remark6 As String
        Get
            Return m_Remark6
        End Get
        Set(value As String)
            m_Remark6 = value
        End Set
    End Property
    Private m_Remark7 As String
    Public Property Remark7 As String
        Get
            Return m_Remark7
        End Get
        Set(value As String)
            m_Remark7 = value
        End Set
    End Property
    Private m_Remark8 As String
    Public Property Remark8 As String
        Get
            Return m_Remark8
        End Get
        Set(value As String)
            m_Remark8 = value
        End Set
    End Property
    Private m_Remark9 As String
    Public Property Remark9 As String
        Get
            Return m_Remark9
        End Get
        Set(value As String)
            m_Remark9 = value
        End Set
    End Property
    Private m_Remark10 As String
    Public Property Remark10 As String
        Get
            Return m_Remark10
        End Get
        Set(value As String)
            m_Remark10 = value
        End Set
    End Property
    Private m_CancelReson As String
    Public Property CancelReson As String
        Get
            Return m_CancelReson
        End Get
        Set(value As String)
            m_CancelReson = value
        End Set
    End Property
    Private m_CancelProve As String
    Public Property CancelProve As String
        Get
            Return m_CancelProve
        End Get
        Set(value As String)
            m_CancelProve = value
        End Set
    End Property
    Private m_CancelDate As Date
    Public Property CancelDate As Date
        Get
            Return m_CancelDate
        End Get
        Set(value As Date)
            m_CancelDate = value
        End Set
    End Property
    Private m_CancelTime As Date
    Public Property CancelTime As Date
        Get
            Return m_CancelTime
        End Get
        Set(value As Date)
            m_CancelTime = value
        End Set
    End Property
    Private m_ShippingRemark As String
    Public Property ShippingRemark As String
        Get
            Return m_ShippingRemark
        End Get
        Set(value As String)
            m_ShippingRemark = value
        End Set
    End Property
    Private m_SumDiscount As Double
    Public Property SumDiscount As Double
        Get
            Return m_SumDiscount
        End Get
        Set(value As Double)
            m_SumDiscount = value
        End Set
    End Property
    Private m_DiscountRate As Double
    Public Property DiscountRate As Double
        Get
            Return m_DiscountRate
        End Get
        Set(value As Double)
            m_DiscountRate = value
        End Set
    End Property
    Private m_DiscountCal As Double
    Public Property DiscountCal As Double
        Get
            Return m_DiscountCal
        End Get
        Set(value As Double)
            m_DiscountCal = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_InvoiceHeader" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("DocNo") = Me.DocNo
                            dr("DocDate") = Main.GetDBDate(Me.DocDate)
                            dr("CustCode") = Me.CustCode
                            dr("CustBranch") = Me.CustBranch
                            dr("BillToCustCode") = Me.BillToCustCode
                            dr("BillToCustBranch") = Me.BillToCustBranch
                            dr("ContactName") = Me.ContactName
                            dr("EmpCode") = Me.EmpCode
                            dr("PrintedBy") = Me.PrintedBy
                            dr("PrintedDate") = Main.GetDBDate(Me.PrintedDate)
                            dr("PrintedTime") = Main.GetDBTime(Me.PrintedTime)
                            dr("RefNo") = Me.RefNo
                            dr("VATRate") = Me.VATRate
                            dr("TotalAdvance") = Me.TotalAdvance
                            dr("TotalDiscount") = Me.TotalDiscount
                            dr("TotalCharge") = Me.TotalCharge
                            dr("TotalIsTaxCharge") = Me.TotalIsTaxCharge
                            dr("TotalIs50Tavi") = Me.TotalIs50Tavi
                            dr("TotalVAT") = Me.TotalVAT
                            dr("Total50Tavi") = Me.Total50Tavi
                            dr("TotalCustAdv") = Me.TotalCustAdv
                            dr("TotalNet") = Me.TotalNet
                            dr("CurrencyCode") = Me.CurrencyCode
                            dr("ExchangeRate") = Me.ExchangeRate
                            dr("ForeignNet") = Me.ForeignNet
                            dr("BillAcceptDate") = Main.GetDBDate(Me.BillAcceptDate)
                            dr("BillIssueDate") = Main.GetDBDate(Me.BillIssueDate)
                            dr("BillAcceptNo") = Me.BillAcceptNo
                            dr("Remark1") = Me.Remark1
                            dr("Remark2") = Me.Remark2
                            dr("Remark3") = Me.Remark3
                            dr("Remark4") = Me.Remark4
                            dr("Remark5") = Me.Remark5
                            dr("Remark6") = Me.Remark6
                            dr("Remark7") = Me.Remark7
                            dr("Remark8") = Me.Remark8
                            dr("Remark9") = Me.Remark9
                            dr("Remark10") = Me.Remark10
                            dr("CancelReson") = Me.CancelReson
                            dr("CancelProve") = Me.CancelProve
                            dr("CancelDate") = Main.GetDBDate(Me.CancelDate)
                            dr("CancelTime") = Main.GetDBTime(Me.CancelTime)
                            dr("ShippingRemark") = Me.ShippingRemark
                            dr("SumDiscount") = Me.SumDiscount
                            dr("DiscountRate") = Me.DiscountRate
                            dr("DiscountCal") = Me.DiscountCal
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInvHeader", "SaveData", Me)
                            If Me.CancelProve <> "" Then
                                CancelData(cn)
                            End If

                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInvHeader", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew(pFormatSQL As String)
        If pFormatSQL = "" Then
            m_DocNo = ""
        Else
            Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(DocNo) as t FROM Job_InvoiceHeader WHERE BranchCode='{0}' And DocNo Like '%{1}' ", m_BranchCode, pFormatSQL), pFormatSQL)
            m_DocNo = retStr
        End If
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CInvHeader)
        Dim lst As New List(Of CInvHeader)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CInvHeader
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_InvoiceHeader" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CInvHeader(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocNo"))) = False Then
                        row.DocNo = rd.GetString(rd.GetOrdinal("DocNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocDate"))) = False Then
                        row.DocDate = rd.GetValue(rd.GetOrdinal("DocDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustCode"))) = False Then
                        row.CustCode = rd.GetString(rd.GetOrdinal("CustCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustBranch"))) = False Then
                        row.CustBranch = rd.GetString(rd.GetOrdinal("CustBranch")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillToCustCode"))) = False Then
                        row.BillToCustCode = rd.GetString(rd.GetOrdinal("BillToCustCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillToCustBranch"))) = False Then
                        row.BillToCustBranch = rd.GetString(rd.GetOrdinal("BillToCustBranch")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ContactName"))) = False Then
                        row.ContactName = rd.GetString(rd.GetOrdinal("ContactName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EmpCode"))) = False Then
                        row.EmpCode = rd.GetString(rd.GetOrdinal("EmpCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PrintedBy"))) = False Then
                        row.PrintedBy = rd.GetString(rd.GetOrdinal("PrintedBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PrintedDate"))) = False Then
                        row.PrintedDate = rd.GetValue(rd.GetOrdinal("PrintedDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PrintedTime"))) = False Then
                        row.PrintedTime = rd.GetValue(rd.GetOrdinal("PrintedTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("RefNo"))) = False Then
                        row.RefNo = rd.GetString(rd.GetOrdinal("RefNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VATRate"))) = False Then
                        row.VATRate = rd.GetDouble(rd.GetOrdinal("VATRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalAdvance"))) = False Then
                        row.TotalAdvance = rd.GetDouble(rd.GetOrdinal("TotalAdvance"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalDiscount"))) = False Then
                        row.TotalDiscount = rd.GetDouble(rd.GetOrdinal("TotalDiscount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalCharge"))) = False Then
                        row.TotalCharge = rd.GetDouble(rd.GetOrdinal("TotalCharge"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalIsTaxCharge"))) = False Then
                        row.TotalIsTaxCharge = rd.GetDouble(rd.GetOrdinal("TotalIsTaxCharge"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalIs50Tavi"))) = False Then
                        row.TotalIs50Tavi = rd.GetDouble(rd.GetOrdinal("TotalIs50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalVAT"))) = False Then
                        row.TotalVAT = rd.GetDouble(rd.GetOrdinal("TotalVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Total50Tavi"))) = False Then
                        row.Total50Tavi = rd.GetDouble(rd.GetOrdinal("Total50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalCustAdv"))) = False Then
                        row.TotalCustAdv = rd.GetDouble(rd.GetOrdinal("TotalCustAdv"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalNet"))) = False Then
                        row.TotalNet = rd.GetDouble(rd.GetOrdinal("TotalNet"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CurrencyCode"))) = False Then
                        row.CurrencyCode = rd.GetString(rd.GetOrdinal("CurrencyCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ExchangeRate"))) = False Then
                        row.ExchangeRate = rd.GetDouble(rd.GetOrdinal("ExchangeRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ForeignNet"))) = False Then
                        row.ForeignNet = rd.GetDouble(rd.GetOrdinal("ForeignNet"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillAcceptDate"))) = False Then
                        row.BillAcceptDate = rd.GetValue(rd.GetOrdinal("BillAcceptDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillIssueDate"))) = False Then
                        row.BillIssueDate = rd.GetValue(rd.GetOrdinal("BillIssueDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillAcceptNo"))) = False Then
                        row.BillAcceptNo = rd.GetString(rd.GetOrdinal("BillAcceptNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Remark1"))) = False Then
                        row.Remark1 = rd.GetString(rd.GetOrdinal("Remark1")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Remark2"))) = False Then
                        row.Remark2 = rd.GetString(rd.GetOrdinal("Remark2")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Remark3"))) = False Then
                        row.Remark3 = rd.GetString(rd.GetOrdinal("Remark3")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Remark4"))) = False Then
                        row.Remark4 = rd.GetString(rd.GetOrdinal("Remark4")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Remark5"))) = False Then
                        row.Remark5 = rd.GetString(rd.GetOrdinal("Remark5")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Remark6"))) = False Then
                        row.Remark6 = rd.GetString(rd.GetOrdinal("Remark6")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Remark7"))) = False Then
                        row.Remark7 = rd.GetString(rd.GetOrdinal("Remark7")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Remark8"))) = False Then
                        row.Remark8 = rd.GetString(rd.GetOrdinal("Remark8")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Remark9"))) = False Then
                        row.Remark9 = rd.GetString(rd.GetOrdinal("Remark9")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Remark10"))) = False Then
                        row.Remark10 = rd.GetString(rd.GetOrdinal("Remark10")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelReson"))) = False Then
                        row.CancelReson = rd.GetString(rd.GetOrdinal("CancelReson")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelProve"))) = False Then
                        row.CancelProve = rd.GetString(rd.GetOrdinal("CancelProve")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelDate"))) = False Then
                        row.CancelDate = rd.GetValue(rd.GetOrdinal("CancelDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelTime"))) = False Then
                        row.CancelTime = rd.GetValue(rd.GetOrdinal("CancelTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ShippingRemark"))) = False Then
                        row.ShippingRemark = rd.GetString(rd.GetOrdinal("ShippingRemark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SumDiscount"))) = False Then
                        row.SumDiscount = rd.GetDouble(rd.GetOrdinal("SumDiscount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DiscountRate"))) = False Then
                        row.DiscountRate = rd.GetDouble(rd.GetOrdinal("DiscountRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DiscountCal"))) = False Then
                        row.DiscountCal = rd.GetDouble(rd.GetOrdinal("DiscountCal"))
                    End If
                    lst.Add(row)
                End While
            Catch ex As Exception
            End Try
        End Using
        Return lst
    End Function
    Public Function CancelData(cn As SqlConnection) As String
        Dim msg As String = ""
        Try
            Using cm As New SqlCommand()
                cm.Connection = cn
                cm.CommandTimeout = 0
                If Me.DocNo <> "" Then
                    Dim Sql = "UPDATE Job_ClearDetail SET LinkBillNo=null,LinkItem=0"
                    Sql &= String.Format(" WHERE BranchCode ='{0}' AND LinkBillNo='{1}' ", Me.BranchCode, Me.DocNo)

                    cm.CommandText = Sql
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInvHeader", "UpdateClrDetail", cm.CommandText)
                End If
            End Using

            msg = "Cancel Complete"
        Catch ex As Exception
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInvHeader", "CancelData", ex.Message)
            msg = ex.Message
        End Try
        Return msg
    End Function
    Public Function DeleteData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using cm As New SqlCommand("DELETE FROM Job_InvoiceHeader" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInvHeader", "DeleteData", cm.CommandText)
                End Using
                If Me.DocNo <> "" Then
                    msg = CancelData(cn)
                Else
                    msg = "Delete Complete"
                End If
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInvHeader", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
