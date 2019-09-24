'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CInvDetail
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
    Private m_ClrNoList As String
    Public Property ClrNoList As String
        Get
            Return m_ClrNoList
        End Get
        Set(value As String)
            m_ClrNoList = value
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
    Private m_ItemNo As Integer
    Public Property ItemNo As Integer
        Get
            Return m_ItemNo
        End Get
        Set(value As Integer)
            m_ItemNo = value
        End Set
    End Property
    Private m_SICode As String
    Public Property SICode As String
        Get
            Return m_SICode
        End Get
        Set(value As String)
            m_SICode = value
        End Set
    End Property
    Private m_SDescription As String
    Public Property SDescription As String
        Get
            Return m_SDescription
        End Get
        Set(value As String)
            m_SDescription = value
        End Set
    End Property
    Private m_ExpSlipNO As String
    Public Property ExpSlipNO As String
        Get
            Return m_ExpSlipNO
        End Get
        Set(value As String)
            m_ExpSlipNO = value
        End Set
    End Property
    Private m_SRemark As String
    Public Property SRemark As String
        Get
            Return m_SRemark
        End Get
        Set(value As String)
            m_SRemark = value
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
    Private m_Qty As Integer
    Public Property Qty As Integer
        Get
            Return m_Qty
        End Get
        Set(value As Integer)
            m_Qty = value
        End Set
    End Property
    Private m_QtyUnit As String
    Public Property QtyUnit As String
        Get
            Return m_QtyUnit
        End Get
        Set(value As String)
            m_QtyUnit = value
        End Set
    End Property
    Private m_UnitPrice As Double
    Public Property UnitPrice As Double
        Get
            Return m_UnitPrice
        End Get
        Set(value As Double)
            m_UnitPrice = value
        End Set
    End Property
    Private m_FUnitPrice As Double
    Public Property FUnitPrice As Double
        Get
            Return m_FUnitPrice
        End Get
        Set(value As Double)
            m_FUnitPrice = value
        End Set
    End Property
    Private m_Amt As Double
    Public Property Amt As Double
        Get
            Return m_Amt
        End Get
        Set(value As Double)
            m_Amt = value
        End Set
    End Property
    Private m_FAmt As Double
    Public Property FAmt As Double
        Get
            Return m_FAmt
        End Get
        Set(value As Double)
            m_FAmt = value
        End Set
    End Property
    Private m_DiscountType As Integer
    Public Property DiscountType As Integer
        Get
            Return m_DiscountType
        End Get
        Set(value As Integer)
            m_DiscountType = value
        End Set
    End Property
    Private m_DiscountPerc As Double
    Public Property DiscountPerc As Double
        Get
            Return m_DiscountPerc
        End Get
        Set(value As Double)
            m_DiscountPerc = value
        End Set
    End Property
    Private m_AmtDiscount As Double
    Public Property AmtDiscount As Double
        Get
            Return m_AmtDiscount
        End Get
        Set(value As Double)
            m_AmtDiscount = value
        End Set
    End Property
    Private m_FAmtDiscount As Double
    Public Property FAmtDiscount As Double
        Get
            Return m_FAmtDiscount
        End Get
        Set(value As Double)
            m_FAmtDiscount = value
        End Set
    End Property
    Private m_Is50Tavi As Integer
    Public Property Is50Tavi As Integer
        Get
            Return m_Is50Tavi
        End Get
        Set(value As Integer)
            m_Is50Tavi = value
        End Set
    End Property
    Private m_Rate50Tavi As Double
    Public Property Rate50Tavi As Double
        Get
            Return m_Rate50Tavi
        End Get
        Set(value As Double)
            m_Rate50Tavi = value
        End Set
    End Property
    Private m_Amt50Tavi As Double
    Public Property Amt50Tavi As Double
        Get
            Return m_Amt50Tavi
        End Get
        Set(value As Double)
            m_Amt50Tavi = value
        End Set
    End Property
    Private m_IsTaxCharge As Integer
    Public Property IsTaxCharge As Integer
        Get
            Return m_IsTaxCharge
        End Get
        Set(value As Integer)
            m_IsTaxCharge = value
        End Set
    End Property
    Private m_AmtVat As Double
    Public Property AmtVat As Double
        Get
            Return m_AmtVat
        End Get
        Set(value As Double)
            m_AmtVat = value
        End Set
    End Property
    Private m_TotalAmt As Double
    Public Property TotalAmt As Double
        Get
            Return m_TotalAmt
        End Get
        Set(value As Double)
            m_TotalAmt = value
        End Set
    End Property
    Private m_FTotalAmt As Double
    Public Property FTotalAmt As Double
        Get
            Return m_FTotalAmt
        End Get
        Set(value As Double)
            m_FTotalAmt = value
        End Set
    End Property
    Private m_AmtAdvance As Double
    Public Property AmtAdvance As Double
        Get
            Return m_AmtAdvance
        End Get
        Set(value As Double)
            m_AmtAdvance = value
        End Set
    End Property
    Private m_AmtCharge As Double
    Public Property AmtCharge As Double
        Get
            Return m_AmtCharge
        End Get
        Set(value As Double)
            m_AmtCharge = value
        End Set
    End Property
    Private m_CurrencyCodeCredit As String
    Public Property CurrencyCodeCredit As String
        Get
            Return m_CurrencyCodeCredit
        End Get
        Set(value As String)
            m_CurrencyCodeCredit = value
        End Set
    End Property
    Private m_ExchangeRateCredit As Double
    Public Property ExchangeRateCredit As Double
        Get
            Return m_ExchangeRateCredit
        End Get
        Set(value As Double)
            m_ExchangeRateCredit = value
        End Set
    End Property
    Private m_AmtCredit As Double
    Public Property AmtCredit As Double
        Get
            Return m_AmtCredit
        End Get
        Set(value As Double)
            m_AmtCredit = value
        End Set
    End Property
    Private m_FAmtCredit As Double
    Public Property FAmtCredit As Double
        Get
            Return m_FAmtCredit
        End Get
        Set(value As Double)
            m_FAmtCredit = value
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
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_InvoiceDetail" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("DocNo") = Me.DocNo
                            If Me.ItemNo = 0 Then Me.AddNew()
                            dr("ItemNo") = Me.ItemNo
                            dr("SICode") = Me.SICode
                            dr("SDescription") = Me.SDescription
                            dr("ExpSlipNO") = Me.ExpSlipNO
                            dr("SRemark") = Me.SRemark
                            dr("CurrencyCode") = Me.CurrencyCode
                            dr("ExchangeRate") = Me.ExchangeRate
                            dr("Qty") = Me.Qty
                            dr("QtyUnit") = Me.QtyUnit
                            dr("UnitPrice") = Me.UnitPrice
                            dr("FUnitPrice") = Me.FUnitPrice
                            dr("Amt") = Me.Amt
                            dr("FAmt") = Me.FAmt
                            dr("DiscountType") = Me.DiscountType
                            dr("DiscountPerc") = Me.DiscountPerc
                            dr("AmtDiscount") = Me.AmtDiscount
                            dr("FAmtDiscount") = Me.FAmtDiscount
                            dr("Is50Tavi") = Me.Is50Tavi
                            dr("Rate50Tavi") = Me.Rate50Tavi
                            dr("Amt50Tavi") = Me.Amt50Tavi
                            dr("IsTaxCharge") = Me.IsTaxCharge
                            dr("AmtVat") = Me.AmtVat
                            dr("TotalAmt") = Me.TotalAmt
                            dr("FTotalAmt") = Me.FTotalAmt
                            dr("AmtAdvance") = Me.AmtAdvance
                            dr("AmtCharge") = Me.AmtCharge
                            dr("VATRate") = Me.VATRate
                            dr("CurrencyCodeCredit") = Me.CurrencyCodeCredit
                            dr("ExchangeRateCredit") = Me.ExchangeRateCredit
                            dr("AmtCredit") = Me.AmtCredit
                            dr("FAmtCredit") = Me.FAmtCredit
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            If da.Update(dt) > 0 Then
                                UpdateTotal(cn)
                            End If
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInvDetail", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInvDetail", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub UpdateTotal(cn As SqlConnection)
        Dim sql As String = SQLUpdateInvoiceHeader()
        Using cm As New SqlCommand(sql, cn)
            cm.CommandText = sql + " WHERE h.BranchCode='" + Me.BranchCode + "' and h.DocNo='" + Me.DocNo + "'"
            cm.CommandType = CommandType.Text
            cm.ExecuteNonQuery()
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInvDetail", "UpdateInvHeader", cm.CommandText)
            If Me.ClrNoList <> "" Then
                If Me.DocNo <> "" And Me.ItemNo <> 0 Then
                    sql = String.Format("UPDATE Job_ClearDetail SET LinkBillNo='{0}',LinkItem={1}", Me.DocNo, Me.ItemNo)
                    sql &= String.Format(" WHERE ClrNo+'/'+Convert(varchar,ItemNo) IN('{0}')", Me.ClrNoList.Replace(",", "','"))
                    cm.CommandText = sql
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInvDetail", "UpdateClrDetail", cm.CommandText)
                End If
            End If
        End Using
    End Sub
    Public Sub AddNew()
        Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(ItemNo) as t FROM Job_InvoiceDetail WHERE BranchCode='{0}' And DocNo ='{1}' ", m_BranchCode, m_DocNo), "____")
        m_ItemNo = Convert.ToInt32("0" & retStr)
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CInvDetail)
        Dim lst As New List(Of CInvDetail)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CInvDetail
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_InvoiceDetail" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CInvDetail(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocNo"))) = False Then
                        row.DocNo = rd.GetString(rd.GetOrdinal("DocNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ItemNo"))) = False Then
                        row.ItemNo = rd.GetInt16(rd.GetOrdinal("ItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SICode"))) = False Then
                        row.SICode = rd.GetString(rd.GetOrdinal("SICode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SDescription"))) = False Then
                        row.SDescription = rd.GetString(rd.GetOrdinal("SDescription")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ExpSlipNO"))) = False Then
                        row.ExpSlipNO = rd.GetString(rd.GetOrdinal("ExpSlipNO")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SRemark"))) = False Then
                        row.SRemark = rd.GetString(rd.GetOrdinal("SRemark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CurrencyCode"))) = False Then
                        row.CurrencyCode = rd.GetString(rd.GetOrdinal("CurrencyCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ExchangeRate"))) = False Then
                        row.ExchangeRate = rd.GetDouble(rd.GetOrdinal("ExchangeRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Qty"))) = False Then
                        row.Qty = rd.GetValue(rd.GetOrdinal("Qty"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("QtyUnit"))) = False Then
                        row.QtyUnit = rd.GetString(rd.GetOrdinal("QtyUnit")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UnitPrice"))) = False Then
                        row.UnitPrice = rd.GetDouble(rd.GetOrdinal("UnitPrice"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FUnitPrice"))) = False Then
                        row.FUnitPrice = rd.GetDouble(rd.GetOrdinal("FUnitPrice"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Amt"))) = False Then
                        row.Amt = rd.GetValue(rd.GetOrdinal("Amt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FAmt"))) = False Then
                        row.FAmt = rd.GetDouble(rd.GetOrdinal("FAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DiscountType"))) = False Then
                        row.DiscountType = rd.GetInt32(rd.GetOrdinal("DiscountType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DiscountPerc"))) = False Then
                        row.DiscountPerc = rd.GetDouble(rd.GetOrdinal("DiscountPerc"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AmtDiscount"))) = False Then
                        row.AmtDiscount = rd.GetDouble(rd.GetOrdinal("AmtDiscount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FAmtDiscount"))) = False Then
                        row.FAmtDiscount = rd.GetDouble(rd.GetOrdinal("FAmtDiscount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Is50Tavi"))) = False Then
                        row.Is50Tavi = rd.GetByte(rd.GetOrdinal("Is50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Rate50Tavi"))) = False Then
                        row.Rate50Tavi = rd.GetDouble(rd.GetOrdinal("Rate50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Amt50Tavi"))) = False Then
                        row.Amt50Tavi = rd.GetDouble(rd.GetOrdinal("Amt50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsTaxCharge"))) = False Then
                        row.IsTaxCharge = rd.GetByte(rd.GetOrdinal("IsTaxCharge"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AmtVat"))) = False Then
                        row.AmtVat = rd.GetDouble(rd.GetOrdinal("AmtVat"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalAmt"))) = False Then
                        row.TotalAmt = rd.GetDouble(rd.GetOrdinal("TotalAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FTotalAmt"))) = False Then
                        row.FTotalAmt = rd.GetDouble(rd.GetOrdinal("FTotalAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AmtAdvance"))) = False Then
                        row.AmtAdvance = rd.GetDouble(rd.GetOrdinal("AmtAdvance"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AmtCharge"))) = False Then
                        row.AmtCharge = rd.GetDouble(rd.GetOrdinal("AmtCharge"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CurrencyCodeCredit"))) = False Then
                        row.CurrencyCodeCredit = rd.GetString(rd.GetOrdinal("CurrencyCodeCredit")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ExchangeRateCredit"))) = False Then
                        row.ExchangeRateCredit = rd.GetDouble(rd.GetOrdinal("ExchangeRateCredit"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AmtCredit"))) = False Then
                        row.AmtCredit = rd.GetDouble(rd.GetOrdinal("AmtCredit"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FAmtCredit"))) = False Then
                        row.FAmtCredit = rd.GetDouble(rd.GetOrdinal("FAmtCredit"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VATRate"))) = False Then
                        row.VATRate = rd.GetDouble(rd.GetOrdinal("VATRate"))
                    End If
                    lst.Add(row)
                End While
            Catch ex As Exception
            End Try
        End Using
        Return lst
    End Function
    Public Function DeleteData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using cm As New SqlCommand("DELETE FROM Job_InvoiceDetail" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInvDetail", "DeleteInvDetail", cm.CommandText)
                    If Me.DocNo <> "" And Me.ItemNo <> 0 Then
                        Dim Sql = "UPDATE Job_ClearDetail SET LinkBillNo=null,LinkItem=0"
                        Sql &= String.Format(" WHERE BranchCode='{0}' AND LinkBillNo='{1}' And LinkItem={2}", Me.BranchCode, Me.DocNo, Me.ItemNo)

                        cm.CommandText = Sql
                        cm.CommandType = CommandType.Text
                        cm.ExecuteNonQuery()
                        Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInvDetail", "UpdateClrDetail", cm.CommandText)
                    End If
                End Using
                UpdateTotal(cn)

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CInvDetail", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
