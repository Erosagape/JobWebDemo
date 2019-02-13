'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CClrDetail
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
    Private m_ClrNo As String
    Public Property ClrNo As String
        Get
            Return m_ClrNo
        End Get
        Set(value As String)
            m_ClrNo = value
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
    Private m_LinkItem As Integer
    Public Property LinkItem As Integer
        Get
            Return m_LinkItem
        End Get
        Set(value As Integer)
            m_LinkItem = value
        End Set
    End Property
    Private m_STCode As String
    Public Property STCode As String
        Get
            Return m_STCode
        End Get
        Set(value As String)
            m_STCode = value
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
    Private m_VenderCode As String
    Public Property VenderCode As String
        Get
            Return m_VenderCode
        End Get
        Set(value As String)
            m_VenderCode = value
        End Set
    End Property
    Private m_Qty As Date
    Public Property Qty As Date
        Get
            Return m_Qty
        End Get
        Set(value As Date)
            m_Qty = value
        End Set
    End Property
    Private m_UnitCode As String
    Public Property UnitCode As String
        Get
            Return m_UnitCode
        End Get
        Set(value As String)
            m_UnitCode = value
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
    Private m_CurRate As Double
    Public Property CurRate As Double
        Get
            Return m_CurRate
        End Get
        Set(value As Double)
            m_CurRate = value
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
    Private m_FPrice As Double
    Public Property FPrice As Double
        Get
            Return m_FPrice
        End Get
        Set(value As Double)
            m_FPrice = value
        End Set
    End Property
    Private m_BPrice As Double
    Public Property BPrice As Double
        Get
            Return m_BPrice
        End Get
        Set(value As Double)
            m_BPrice = value
        End Set
    End Property
    Private m_QUnitPrice As Double
    Public Property QUnitPrice As Double
        Get
            Return m_QUnitPrice
        End Get
        Set(value As Double)
            m_QUnitPrice = value
        End Set
    End Property
    Private m_QFPrice As Double
    Public Property QFPrice As Double
        Get
            Return m_QFPrice
        End Get
        Set(value As Double)
            m_QFPrice = value
        End Set
    End Property
    Private m_QBPrice As Double
    Public Property QBPrice As Double
        Get
            Return m_QBPrice
        End Get
        Set(value As Double)
            m_QBPrice = value
        End Set
    End Property
    Private m_UnitCost As Double
    Public Property UnitCost As Double
        Get
            Return m_UnitCost
        End Get
        Set(value As Double)
            m_UnitCost = value
        End Set
    End Property
    Private m_FCost As Double
    Public Property FCost As Double
        Get
            Return m_FCost
        End Get
        Set(value As Double)
            m_FCost = value
        End Set
    End Property
    Private m_BCost As Double
    Public Property BCost As Double
        Get
            Return m_BCost
        End Get
        Set(value As Double)
            m_BCost = value
        End Set
    End Property
    Private m_ChargeVAT As Double
    Public Property ChargeVAT As Double
        Get
            Return m_ChargeVAT
        End Get
        Set(value As Double)
            m_ChargeVAT = value
        End Set
    End Property
    Private m_Tax50Tavi As Double
    Public Property Tax50Tavi As Double
        Get
            Return m_Tax50Tavi
        End Get
        Set(value As Double)
            m_Tax50Tavi = value
        End Set
    End Property
    Private m_AdvNO As String
    Public Property AdvNO As String
        Get
            Return m_AdvNO
        End Get
        Set(value As String)
            m_AdvNO = value
        End Set
    End Property
    Private m_AdvAmount As Double
    Public Property AdvAmount As Double
        Get
            Return m_AdvAmount
        End Get
        Set(value As Double)
            m_AdvAmount = value
        End Set
    End Property
    Private m_UsedAmount As Double
    Public Property UsedAmount As Double
        Get
            Return m_UsedAmount
        End Get
        Set(value As Double)
            m_UsedAmount = value
        End Set
    End Property
    Private m_IsQuoItem As Integer
    Public Property IsQuoItem As Integer
        Get
            Return m_IsQuoItem
        End Get
        Set(value As Integer)
            m_IsQuoItem = value
        End Set
    End Property
    Private m_SlipNO As String
    Public Property SlipNO As String
        Get
            Return m_SlipNO
        End Get
        Set(value As String)
            m_SlipNO = value
        End Set
    End Property
    Private m_Remark As String
    Public Property Remark As String
        Get
            Return m_Remark
        End Get
        Set(value As String)
            m_Remark = value
        End Set
    End Property
    Private m_IsDuplicate As Integer
    Public Property IsDuplicate As Integer
        Get
            Return m_IsDuplicate
        End Get
        Set(value As Integer)
            m_IsDuplicate = value
        End Set
    End Property
    Private m_IsLtdAdv50Tavi As Integer
    Public Property IsLtdAdv50Tavi As Integer
        Get
            Return m_IsLtdAdv50Tavi
        End Get
        Set(value As Integer)
            m_IsLtdAdv50Tavi = value
        End Set
    End Property
    Private m_Pay50TaviTo As String
    Public Property Pay50TaviTo As String
        Get
            Return m_Pay50TaviTo
        End Get
        Set(value As String)
            m_Pay50TaviTo = value
        End Set
    End Property
    Private m_NO50Tavi As String
    Public Property NO50Tavi As String
        Get
            Return m_NO50Tavi
        End Get
        Set(value As String)
            m_NO50Tavi = value
        End Set
    End Property
    Private m_Date50Tavi As Date
    Public Property Date50Tavi As Date
        Get
            Return m_Date50Tavi
        End Get
        Set(value As Date)
            m_Date50Tavi = value
        End Set
    End Property
    Private m_VenderBillingNo As String
    Public Property VenderBillingNo As String
        Get
            Return m_VenderBillingNo
        End Get
        Set(value As String)
            m_VenderBillingNo = value
        End Set
    End Property
    Private m_AirQtyStep As String
    Public Property AirQtyStep As String
        Get
            Return m_AirQtyStep
        End Get
        Set(value As String)
            m_AirQtyStep = value
        End Set
    End Property
    Private m_StepSub As String
    Public Property StepSub As String
        Get
            Return m_StepSub
        End Get
        Set(value As String)
            m_StepSub = value
        End Set
    End Property
    Private m_JobNo As String
    Public Property JobNo As String
        Get
            Return m_JobNo
        End Get
        Set(value As String)
            m_JobNo = value
        End Set
    End Property
    Private m_AdvItemNo As Integer
    Public Property AdvItemNo As Integer
        Get
            Return m_AdvItemNo
        End Get
        Set(value As Integer)
            m_AdvItemNo = value
        End Set
    End Property
    Private m_LinkBillNo As String
    Public Property LinkBillNo As String
        Get
            Return m_LinkBillNo
        End Get
        Set(value As String)
            m_LinkBillNo = value
        End Set
    End Property
    Private m_VATType As Integer
    Public Property VATType As Integer
        Get
            Return m_VATType
        End Get
        Set(value As Integer)
            m_VATType = value
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
    Private m_Tax50TaviRate As Double
    Public Property Tax50TaviRate As Double
        Get
            Return m_Tax50TaviRate
        End Get
        Set(value As Double)
            m_Tax50TaviRate = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_ClearDetail" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("ClrNo") = Me.ClrNo
                            dr("ItemNo") = Me.ItemNo
                            dr("LinkItem") = Me.LinkItem
                            dr("STCode") = Me.STCode
                            dr("SICode") = Me.SICode
                            dr("SDescription") = Me.SDescription
                            dr("VenderCode") = Me.VenderCode
                            dr("Qty") = Main.GetDBDate(Me.Qty)
                            dr("UnitCode") = Me.UnitCode
                            dr("CurrencyCode") = Me.CurrencyCode
                            dr("CurRate") = Me.CurRate
                            dr("UnitPrice") = Me.UnitPrice
                            dr("FPrice") = Me.FPrice
                            dr("BPrice") = Me.BPrice
                            dr("QUnitPrice") = Me.QUnitPrice
                            dr("QFPrice") = Me.QFPrice
                            dr("QBPrice") = Me.QBPrice
                            dr("UnitCost") = Me.UnitCost
                            dr("FCost") = Me.FCost
                            dr("BCost") = Me.BCost
                            dr("ChargeVAT") = Me.ChargeVAT
                            dr("Tax50Tavi") = Me.Tax50Tavi
                            dr("AdvNO") = Me.AdvNO
                            dr("AdvAmount") = Me.AdvAmount
                            dr("UsedAmount") = Me.UsedAmount
                            dr("IsQuoItem") = Me.IsQuoItem
                            dr("SlipNO") = Me.SlipNO
                            dr("Remark") = Me.Remark
                            dr("IsDuplicate") = Me.IsDuplicate
                            dr("IsLtdAdv50Tavi") = Me.IsLtdAdv50Tavi
                            dr("Pay50TaviTo") = Me.Pay50TaviTo
                            dr("NO50Tavi") = Me.NO50Tavi
                            dr("Date50Tavi") = Main.GetDBDate(Me.Date50Tavi)
                            dr("VenderBillingNo") = Me.VenderBillingNo
                            dr("AirQtyStep") = Me.AirQtyStep
                            dr("StepSub") = Me.StepSub
                            dr("JobNo") = Me.JobNo
                            dr("AdvItemNo") = Me.AdvItemNo
                            dr("LinkBillNo") = Me.LinkBillNo
                            dr("VATType") = Me.VATType
                            dr("VATRate") = Me.VATRate
                            dr("Tax50TaviRate") = Me.Tax50TaviRate
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_BranchCode = ""
        m_ClrNo = ""
        m_ItemNo = 0
        m_LinkItem = 0
        m_STCode = ""
        m_SICode = ""
        m_SDescription = ""
        m_VenderCode = ""
        m_Qty = DateTime.MinValue
        m_UnitCode = ""
        m_CurrencyCode = ""
        m_CurRate = 0
        m_UnitPrice = 0
        m_FPrice = 0
        m_BPrice = 0
        m_QUnitPrice = 0
        m_QFPrice = 0
        m_QBPrice = 0
        m_UnitCost = 0
        m_FCost = 0
        m_BCost = 0
        m_ChargeVAT = 0
        m_Tax50Tavi = 0
        m_AdvNO = ""
        m_AdvAmount = 0
        m_UsedAmount = 0
        m_IsQuoItem = 0
        m_SlipNO = ""
        m_Remark = ""
        m_IsDuplicate = 0
        m_IsLtdAdv50Tavi = 0
        m_Pay50TaviTo = ""
        m_NO50Tavi = ""
        m_Date50Tavi = DateTime.MinValue
        m_VenderBillingNo = ""
        m_AirQtyStep = ""
        m_StepSub = ""
        m_JobNo = ""
        m_AdvItemNo = 0
        m_LinkBillNo = ""
        m_VATType = 0
        m_VATRate = 0
        m_Tax50TaviRate = 0
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CClrDetail)
        Dim lst As New List(Of CClrDetail)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CClrDetail
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_ClearDetail" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CClrDetail(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ClrNo"))) = False Then
                        row.ClrNo = rd.GetString(rd.GetOrdinal("ClrNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ItemNo"))) = False Then
                        row.ItemNo = rd.GetInt16(rd.GetOrdinal("ItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LinkItem"))) = False Then
                        row.LinkItem = rd.GetInt16(rd.GetOrdinal("LinkItem"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("STCode"))) = False Then
                        row.STCode = rd.GetString(rd.GetOrdinal("STCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SICode"))) = False Then
                        row.SICode = rd.GetString(rd.GetOrdinal("SICode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SDescription"))) = False Then
                        row.SDescription = rd.GetString(rd.GetOrdinal("SDescription")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VenderCode"))) = False Then
                        row.VenderCode = rd.GetString(rd.GetOrdinal("VenderCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Qty"))) = False Then
                        row.Qty = rd.GetValue(rd.GetOrdinal("Qty"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UnitCode"))) = False Then
                        row.UnitCode = rd.GetString(rd.GetOrdinal("UnitCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CurrencyCode"))) = False Then
                        row.CurrencyCode = rd.GetString(rd.GetOrdinal("CurrencyCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CurRate"))) = False Then
                        row.CurRate = rd.GetDouble(rd.GetOrdinal("CurRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UnitPrice"))) = False Then
                        row.UnitPrice = rd.GetDouble(rd.GetOrdinal("UnitPrice"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FPrice"))) = False Then
                        row.FPrice = rd.GetDouble(rd.GetOrdinal("FPrice"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BPrice"))) = False Then
                        row.BPrice = rd.GetDouble(rd.GetOrdinal("BPrice"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("QUnitPrice"))) = False Then
                        row.QUnitPrice = rd.GetDouble(rd.GetOrdinal("QUnitPrice"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("QFPrice"))) = False Then
                        row.QFPrice = rd.GetDouble(rd.GetOrdinal("QFPrice"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("QBPrice"))) = False Then
                        row.QBPrice = rd.GetDouble(rd.GetOrdinal("QBPrice"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UnitCost"))) = False Then
                        row.UnitCost = rd.GetDouble(rd.GetOrdinal("UnitCost"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FCost"))) = False Then
                        row.FCost = rd.GetDouble(rd.GetOrdinal("FCost"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BCost"))) = False Then
                        row.BCost = rd.GetDouble(rd.GetOrdinal("BCost"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ChargeVAT"))) = False Then
                        row.ChargeVAT = rd.GetDouble(rd.GetOrdinal("ChargeVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Tax50Tavi"))) = False Then
                        row.Tax50Tavi = rd.GetDouble(rd.GetOrdinal("Tax50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvNO"))) = False Then
                        row.AdvNO = rd.GetString(rd.GetOrdinal("AdvNO")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvAmount"))) = False Then
                        row.AdvAmount = rd.GetDouble(rd.GetOrdinal("AdvAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UsedAmount"))) = False Then
                        row.UsedAmount = rd.GetDouble(rd.GetOrdinal("UsedAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsQuoItem"))) = False Then
                        row.IsQuoItem = rd.GetByte(rd.GetOrdinal("IsQuoItem"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SlipNO"))) = False Then
                        row.SlipNO = rd.GetString(rd.GetOrdinal("SlipNO")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Remark"))) = False Then
                        row.Remark = rd.GetString(rd.GetOrdinal("Remark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsDuplicate"))) = False Then
                        row.IsDuplicate = rd.GetByte(rd.GetOrdinal("IsDuplicate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsLtdAdv50Tavi"))) = False Then
                        row.IsLtdAdv50Tavi = rd.GetByte(rd.GetOrdinal("IsLtdAdv50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Pay50TaviTo"))) = False Then
                        row.Pay50TaviTo = rd.GetString(rd.GetOrdinal("Pay50TaviTo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("NO50Tavi"))) = False Then
                        row.NO50Tavi = rd.GetString(rd.GetOrdinal("NO50Tavi")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Date50Tavi"))) = False Then
                        row.Date50Tavi = rd.GetValue(rd.GetOrdinal("Date50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VenderBillingNo"))) = False Then
                        row.VenderBillingNo = rd.GetString(rd.GetOrdinal("VenderBillingNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AirQtyStep"))) = False Then
                        row.AirQtyStep = rd.GetString(rd.GetOrdinal("AirQtyStep")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("StepSub"))) = False Then
                        row.StepSub = rd.GetString(rd.GetOrdinal("StepSub")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JobNo"))) = False Then
                        row.JobNo = rd.GetString(rd.GetOrdinal("JobNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvItemNo"))) = False Then
                        row.AdvItemNo = rd.GetInt16(rd.GetOrdinal("AdvItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LinkBillNo"))) = False Then
                        row.LinkBillNo = rd.GetString(rd.GetOrdinal("LinkBillNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VATType"))) = False Then
                        row.VATType = rd.GetInt16(rd.GetOrdinal("VATType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VATRate"))) = False Then
                        row.VATRate = rd.GetDouble(rd.GetOrdinal("VATRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Tax50TaviRate"))) = False Then
                        row.Tax50TaviRate = rd.GetDouble(rd.GetOrdinal("Tax50TaviRate"))
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

                Using cm As New SqlCommand("DELETE FROM Job_ClearDetail" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                End Using
                cn.Close()
                msg = "Delete Complete"
            Catch ex As Exception
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
