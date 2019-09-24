Imports System.Data.SqlClient
Public Class CQuoItem
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
    Private m_QNo As String
    Public Property QNo As String
        Get
            Return m_QNo
        End Get
        Set(value As String)
            m_QNo = value
        End Set
    End Property
    Private m_SeqNo As Integer
    Public Property SeqNo As Integer
        Get
            Return m_SeqNo
        End Get
        Set(value As Integer)
            m_SeqNo = value
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
    Private m_DescriptionThai As String
    Public Property DescriptionThai As String
        Get
            Return m_DescriptionThai
        End Get
        Set(value As String)
            m_DescriptionThai = value
        End Set
    End Property
    Private m_CalculateType As Integer
    Public Property CalculateType As Integer
        Get
            Return m_CalculateType
        End Get
        Set(value As Integer)
            m_CalculateType = value
        End Set
    End Property
    Private m_QtyBegin As Double
    Public Property QtyBegin As Double
        Get
            Return m_QtyBegin
        End Get
        Set(value As Double)
            m_QtyBegin = value
        End Set
    End Property
    Private m_QtyEnd As Double
    Public Property QtyEnd As Double
        Get
            Return m_QtyEnd
        End Get
        Set(value As Double)
            m_QtyEnd = value
        End Set
    End Property
    Private m_UnitCheck As String
    Public Property UnitCheck As String
        Get
            Return m_UnitCheck
        End Get
        Set(value As String)
            m_UnitCheck = value
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
    Private m_CurrencyRate As Double
    Public Property CurrencyRate As Double
        Get
            Return m_CurrencyRate
        End Get
        Set(value As Double)
            m_CurrencyRate = value
        End Set
    End Property
    Private m_ChargeAmt As Double
    Public Property ChargeAmt As Double
        Get
            Return m_ChargeAmt
        End Get
        Set(value As Double)
            m_ChargeAmt = value
        End Set
    End Property
    Private m_Isvat As Integer
    Public Property Isvat As Integer
        Get
            Return m_Isvat
        End Get
        Set(value As Integer)
            m_Isvat = value
        End Set
    End Property
    Private m_VatRate As Integer
    Public Property VatRate As Integer
        Get
            Return m_VatRate
        End Get
        Set(value As Integer)
            m_VatRate = value
        End Set
    End Property
    Private m_VatAmt As Double
    Public Property VatAmt As Double
        Get
            Return m_VatAmt
        End Get
        Set(value As Double)
            m_VatAmt = value
        End Set
    End Property
    Private m_IsTax As Integer
    Public Property IsTax As Integer
        Get
            Return m_IsTax
        End Get
        Set(value As Integer)
            m_IsTax = value
        End Set
    End Property
    Private m_TaxRate As Integer
    Public Property TaxRate As Integer
        Get
            Return m_TaxRate
        End Get
        Set(value As Integer)
            m_TaxRate = value
        End Set
    End Property
    Private m_TaxAmt As Double
    Public Property TaxAmt As Double
        Get
            Return m_TaxAmt
        End Get
        Set(value As Double)
            m_TaxAmt = value
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
    Private m_TotalCharge As Double
    Public Property TotalCharge As Double
        Get
            Return m_TotalCharge
        End Get
        Set(value As Double)
            m_TotalCharge = value
        End Set
    End Property
    Private m_UnitDiscntPerc As Double
    Public Property UnitDiscntPerc As Double
        Get
            Return m_UnitDiscntPerc
        End Get
        Set(value As Double)
            m_UnitDiscntPerc = value
        End Set
    End Property
    Private m_UnitDiscntAmt As Double
    Public Property UnitDiscntAmt As Double
        Get
            Return m_UnitDiscntAmt
        End Get
        Set(value As Double)
            m_UnitDiscntAmt = value
        End Set
    End Property
    Private m_VenderCode As String
    Public Property VenderCode As String
        Get
            Return m_VenderCode
        End Get
        Set(value As String)
            m_VenderCode = value
        End Set
    End Property
    Private m_VenderCost As Double
    Public Property VenderCost As Double
        Get
            Return m_VenderCost
        End Get
        Set(value As Double)
            m_VenderCost = value
        End Set
    End Property
    Private m_BaseProfit As Double
    Public Property BaseProfit As Double
        Get
            Return m_BaseProfit
        End Get
        Set(value As Double)
            m_BaseProfit = value
        End Set
    End Property
    Private m_CommissionPerc As Double
    Public Property CommissionPerc As Double
        Get
            Return m_CommissionPerc
        End Get
        Set(value As Double)
            m_CommissionPerc = value
        End Set
    End Property
    Private m_CommissionAmt As Double
    Public Property CommissionAmt As Double
        Get
            Return m_CommissionAmt
        End Get
        Set(value As Double)
            m_CommissionAmt = value
        End Set
    End Property
    Private m_NetProfit As Double
    Public Property NetProfit As Double
        Get
            Return m_NetProfit
        End Get
        Set(value As Double)
            m_NetProfit = value
        End Set
    End Property
    Private m_IsRequired As Integer
    Public Property IsRequired As Integer
        Get
            Return m_IsRequired
        End Get
        Set(value As Integer)
            m_IsRequired = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_QuotationItem" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("QNo") = Me.QNo
                            dr("SeqNo") = Me.SeqNo
                            If Me.ItemNo = 0 Then Me.AddNew()
                            dr("ItemNo") = Me.ItemNo
                            dr("SICode") = Me.SICode
                            dr("DescriptionThai") = Me.DescriptionThai
                            dr("CalculateType") = Me.CalculateType
                            dr("QtyBegin") = Me.QtyBegin
                            dr("QtyEnd") = Me.QtyEnd
                            dr("UnitCheck") = Me.UnitCheck
                            dr("CurrencyCode") = Me.CurrencyCode
                            dr("CurrencyRate") = Me.CurrencyRate
                            dr("ChargeAmt") = Me.ChargeAmt
                            dr("Isvat") = Me.Isvat
                            dr("VatRate") = Me.VatRate
                            dr("VatAmt") = Me.VatAmt
                            dr("IsTax") = Me.IsTax
                            dr("TaxRate") = Me.TaxRate
                            dr("TaxAmt") = Me.TaxAmt
                            dr("TotalAmt") = Me.TotalAmt
                            dr("TotalCharge") = Me.TotalCharge
                            dr("UnitDiscntPerc") = Me.UnitDiscntPerc
                            dr("UnitDiscntAmt") = Me.UnitDiscntAmt
                            dr("VenderCode") = Me.VenderCode
                            dr("VenderCost") = Me.VenderCost
                            dr("BaseProfit") = Me.BaseProfit
                            dr("CommissionPerc") = Me.CommissionPerc
                            dr("CommissionAmt") = Me.CommissionAmt
                            dr("NetProfit") = Me.NetProfit
                            dr("IsRequired") = Me.IsRequired
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CQuoItem", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CQuoItem", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()
        Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(ItemNo) as t FROM Job_QuotationItem WHERE BranchCode='{0}' And QNo ='{1}' And SeqNo={2} ", m_BranchCode, m_QNo, m_SeqNo), "____")
        m_ItemNo = Convert.ToInt32("0" & retStr)
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CQuoItem)
        Dim lst As New List(Of CQuoItem)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CQuoItem
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_QuotationItem" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CQuoItem(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetString(rd.GetOrdinal("QNo"))) = False Then
                        row.QNo = rd.GetString(rd.GetOrdinal("QNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SeqNo"))) = False Then
                        row.SeqNo = rd.GetInt16(rd.GetOrdinal("SeqNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ItemNo"))) = False Then
                        row.ItemNo = rd.GetInt16(rd.GetOrdinal("ItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SICode"))) = False Then
                        row.SICode = rd.GetString(rd.GetOrdinal("SICode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DescriptionThai"))) = False Then
                        row.DescriptionThai = rd.GetString(rd.GetOrdinal("DescriptionThai")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CalculateType"))) = False Then
                        row.CalculateType = rd.GetInt32(rd.GetOrdinal("CalculateType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("QtyBegin"))) = False Then
                        row.QtyBegin = rd.GetDouble(rd.GetOrdinal("QtyBegin"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("QtyEnd"))) = False Then
                        row.QtyEnd = rd.GetDouble(rd.GetOrdinal("QtyEnd"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UnitCheck"))) = False Then
                        row.UnitCheck = rd.GetString(rd.GetOrdinal("UnitCheck")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CurrencyCode"))) = False Then
                        row.CurrencyCode = rd.GetString(rd.GetOrdinal("CurrencyCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CurrencyRate"))) = False Then
                        row.CurrencyRate = rd.GetDouble(rd.GetOrdinal("CurrencyRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ChargeAmt"))) = False Then
                        row.ChargeAmt = rd.GetDouble(rd.GetOrdinal("ChargeAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Isvat"))) = False Then
                        row.Isvat = rd.GetInt32(rd.GetOrdinal("Isvat"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VatRate"))) = False Then
                        row.VatRate = rd.GetInt32(rd.GetOrdinal("VatRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VatAmt"))) = False Then
                        row.VatAmt = rd.GetDouble(rd.GetOrdinal("VatAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsTax"))) = False Then
                        row.IsTax = rd.GetInt32(rd.GetOrdinal("IsTax"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TaxRate"))) = False Then
                        row.TaxRate = rd.GetInt32(rd.GetOrdinal("TaxRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TaxAmt"))) = False Then
                        row.TaxAmt = rd.GetDouble(rd.GetOrdinal("TaxAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalAmt"))) = False Then
                        row.TotalAmt = rd.GetDouble(rd.GetOrdinal("TotalAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalCharge"))) = False Then
                        row.TotalCharge = rd.GetDouble(rd.GetOrdinal("TotalCharge"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UnitDiscntPerc"))) = False Then
                        row.UnitDiscntPerc = rd.GetDouble(rd.GetOrdinal("UnitDiscntPerc"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UnitDiscntAmt"))) = False Then
                        row.UnitDiscntAmt = rd.GetDouble(rd.GetOrdinal("UnitDiscntAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VenderCode"))) = False Then
                        row.VenderCode = rd.GetString(rd.GetOrdinal("VenderCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VenderCost"))) = False Then
                        row.VenderCost = rd.GetDouble(rd.GetOrdinal("VenderCost"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BaseProfit"))) = False Then
                        row.BaseProfit = rd.GetDouble(rd.GetOrdinal("BaseProfit"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CommissionPerc"))) = False Then
                        row.CommissionPerc = rd.GetDouble(rd.GetOrdinal("CommissionPerc"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CommissionAmt"))) = False Then
                        row.CommissionAmt = rd.GetDouble(rd.GetOrdinal("CommissionAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("NetProfit"))) = False Then
                        row.NetProfit = rd.GetDouble(rd.GetOrdinal("NetProfit"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsRequired"))) = False Then
                        row.IsRequired = rd.GetInt32(rd.GetOrdinal("IsRequired"))
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

                Using cm As New SqlCommand("DELETE FROM Job_QuotationItem" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CQuoItem", "DeleteData", cm.CommandText)
                End Using
                cn.Close()
                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CQuoItem", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class