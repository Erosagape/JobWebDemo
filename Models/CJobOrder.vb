Imports System.Data
Imports System.Data.SqlClient
Public Class CJobOrder
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
    Private m_JNo As String
    Public Property JNo As String
        Get
            Return m_JNo
        End Get
        Set(value As String)
            m_JNo = value
        End Set
    End Property
    Private m_JRevise As Integer
    Public Property JRevise As Integer
        Get
            Return m_JRevise
        End Get
        Set(value As Integer)
            m_JRevise = value
        End Set
    End Property
    Private m_ConfirmDate As Date
    Public Property ConfirmDate As Date
        Get
            Return m_ConfirmDate
        End Get
        Set(value As Date)
            m_ConfirmDate = value
        End Set
    End Property
    Private m_CPolicyCode As String
    Public Property CPolicyCode As String
        Get
            Return m_CPolicyCode
        End Get
        Set(value As String)
            m_CPolicyCode = value
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
    Private m_CustContactName As String
    Public Property CustContactName As String
        Get
            Return m_CustContactName
        End Get
        Set(value As String)
            m_CustContactName = value
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
    Private m_Revise As Integer
    Public Property Revise As Integer
        Get
            Return m_Revise
        End Get
        Set(value As Integer)
            m_Revise = value
        End Set
    End Property
    Private m_ManagerCode As String
    Public Property ManagerCode As String
        Get
            Return m_ManagerCode
        End Get
        Set(value As String)
            m_ManagerCode = value
        End Set
    End Property
    Private m_CSCode As String
    Public Property CSCode As String
        Get
            Return m_CSCode
        End Get
        Set(value As String)
            m_CSCode = value
        End Set
    End Property
    Private m_Description As String
    Public Property Description As String
        Get
            Return m_Description
        End Get
        Set(value As String)
            m_Description = value
        End Set
    End Property
    Private m_TRemark As String
    Public Property TRemark As String
        Get
            Return m_TRemark
        End Get
        Set(value As String)
            m_TRemark = value
        End Set
    End Property
    Private m_JobStatus As Integer
    Public Property JobStatus As Integer
        Get
            Return m_JobStatus
        End Get
        Set(value As Integer)
            m_JobStatus = value
        End Set
    End Property
    Private m_JobType As Integer
    Public Property JobType As Integer
        Get
            Return m_JobType
        End Get
        Set(value As Integer)
            m_JobType = value
        End Set
    End Property
    Private m_ShipBy As Integer
    Public Property ShipBy As Integer
        Get
            Return m_ShipBy
        End Get
        Set(value As Integer)
            m_ShipBy = value
        End Set
    End Property
    Private m_InvNo As String
    Public Property InvNo As String
        Get
            Return m_InvNo
        End Get
        Set(value As String)
            m_InvNo = value
        End Set
    End Property
    Private m_InvTotal As Double
    Public Property InvTotal As Double
        Get
            Return m_InvTotal
        End Get
        Set(value As Double)
            m_InvTotal = value
        End Set
    End Property
    Private m_InvProduct As String
    Public Property InvProduct As String
        Get
            Return m_InvProduct
        End Get
        Set(value As String)
            m_InvProduct = value
        End Set
    End Property
    Private m_InvCountry As String
    Public Property InvCountry As String
        Get
            Return m_InvCountry
        End Get
        Set(value As String)
            m_InvCountry = value
        End Set
    End Property
    Private m_InvFCountry As String
    Public Property InvFCountry As String
        Get
            Return m_InvFCountry
        End Get
        Set(value As String)
            m_InvFCountry = value
        End Set
    End Property
    Private m_InvInterPort As String
    Public Property InvInterPort As String
        Get
            Return m_InvInterPort
        End Get
        Set(value As String)
            m_InvInterPort = value
        End Set
    End Property
    Private m_InvProductQty As Double
    Public Property InvProductQty As Double
        Get
            Return m_InvProductQty
        End Get
        Set(value As Double)
            m_InvProductQty = value
        End Set
    End Property
    Private m_InvProductUnit As String
    Public Property InvProductUnit As String
        Get
            Return m_InvProductUnit
        End Get
        Set(value As String)
            m_InvProductUnit = value
        End Set
    End Property
    Private m_InvCurUnit As String
    Public Property InvCurUnit As String
        Get
            Return m_InvCurUnit
        End Get
        Set(value As String)
            m_InvCurUnit = value
        End Set
    End Property
    Private m_InvCurRate As Double
    Public Property InvCurRate As Double
        Get
            Return m_InvCurRate
        End Get
        Set(value As Double)
            m_InvCurRate = value
        End Set
    End Property
    Private m_ImExDate As Date
    Public Property ImExDate As Date
        Get
            Return m_ImExDate
        End Get
        Set(value As Date)
            m_ImExDate = value
        End Set
    End Property
    Private m_BLNo As String
    Public Property BLNo As String
        Get
            Return m_BLNo
        End Get
        Set(value As String)
            m_BLNo = value
        End Set
    End Property
    Private m_BookingNo As String
    Public Property BookingNo As String
        Get
            Return m_BookingNo
        End Get
        Set(value As String)
            m_BookingNo = value
        End Set
    End Property
    Private m_ClearPort As String
    Public Property ClearPort As String
        Get
            Return m_ClearPort
        End Get
        Set(value As String)
            m_ClearPort = value
        End Set
    End Property
    Private m_ClearPortNo As String
    Public Property ClearPortNo As String
        Get
            Return m_ClearPortNo
        End Get
        Set(value As String)
            m_ClearPortNo = value
        End Set
    End Property
    Private m_ClearDate As Date
    Public Property ClearDate As Date
        Get
            Return m_ClearDate
        End Get
        Set(value As Date)
            m_ClearDate = value
        End Set
    End Property
    Private m_LoadDate As Date
    Public Property LoadDate As Date
        Get
            Return m_LoadDate
        End Get
        Set(value As Date)
            m_LoadDate = value
        End Set
    End Property
    Private m_ForwarderCode As String
    Public Property ForwarderCode As String
        Get
            Return m_ForwarderCode
        End Get
        Set(value As String)
            m_ForwarderCode = value
        End Set
    End Property
    Private m_AgentCode As String
    Public Property AgentCode As String
        Get
            Return m_AgentCode
        End Get
        Set(value As String)
            m_AgentCode = value
        End Set
    End Property
    Private m_VesselName As String
    Public Property VesselName As String
        Get
            Return m_VesselName
        End Get
        Set(value As String)
            m_VesselName = value
        End Set
    End Property
    Private m_ETDDate As Date
    Public Property ETDDate As Date
        Get
            Return m_ETDDate
        End Get
        Set(value As Date)
            m_ETDDate = value
        End Set
    End Property
    Private m_ETADate As Date
    Public Property ETADate As Date
        Get
            Return m_ETADate
        End Get
        Set(value As Date)
            m_ETADate = value
        End Set
    End Property
    Private m_ETTime As Date
    Public Property ETTime As Date
        Get
            Return m_ETTime
        End Get
        Set(value As Date)
            m_ETTime = value
        End Set
    End Property
    Private m_FNetPrice As String
    Public Property FNetPrice As String
        Get
            Return m_FNetPrice
        End Get
        Set(value As String)
            m_FNetPrice = value
        End Set
    End Property
    Private m_BNetPrice As Double
    Public Property BNetPrice As Double
        Get
            Return m_BNetPrice
        End Get
        Set(value As Double)
            m_BNetPrice = value
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
    Private m_CancelProve As String
    Public Property CancelProve As String
        Get
            Return m_CancelProve
        End Get
        Set(value As String)
            m_CancelProve = value
        End Set
    End Property
    Private m_CancelProveDate As Date
    Public Property CancelProveDate As Date
        Get
            Return m_CancelProveDate
        End Get
        Set(value As Date)
            m_CancelProveDate = value
        End Set
    End Property
    Private m_CancelProveTime As Date
    Public Property CancelProveTime As Date
        Get
            Return m_CancelProveTime
        End Get
        Set(value As Date)
            m_CancelProveTime = value
        End Set
    End Property
    Private m_CloseJobDate As Date
    Public Property CloseJobDate As Date
        Get
            Return m_CloseJobDate
        End Get
        Set(value As Date)
            m_CloseJobDate = value
        End Set
    End Property
    Private m_CloseJobTime As Date
    Public Property CloseJobTime As Date
        Get
            Return m_CloseJobTime
        End Get
        Set(value As Date)
            m_CloseJobTime = value
        End Set
    End Property
    Private m_CloseJobBy As String
    Public Property CloseJobBy As String
        Get
            Return m_CloseJobBy
        End Get
        Set(value As String)
            m_CloseJobBy = value
        End Set
    End Property
    Private m_DeclareType As String
    Public Property DeclareType As String
        Get
            Return m_DeclareType
        End Get
        Set(value As String)
            m_DeclareType = value
        End Set
    End Property
    Private m_DeclareNumber As String
    Public Property DeclareNumber As String
        Get
            Return m_DeclareNumber
        End Get
        Set(value As String)
            m_DeclareNumber = value
        End Set
    End Property
    Private m_DeclareStatus As String
    Public Property DeclareStatus As String
        Get
            Return m_DeclareStatus
        End Get
        Set(value As String)
            m_DeclareStatus = value
        End Set
    End Property
    Private m_TyAuthorSp As String
    Public Property TyAuthorSp As String
        Get
            Return m_TyAuthorSp
        End Get
        Set(value As String)
            m_TyAuthorSp = value
        End Set
    End Property
    Private m_Ty19BIS As String
    Public Property Ty19BIS As String
        Get
            Return m_Ty19BIS
        End Get
        Set(value As String)
            m_Ty19BIS = value
        End Set
    End Property
    Private m_TyClearTax As String
    Public Property TyClearTax As String
        Get
            Return m_TyClearTax
        End Get
        Set(value As String)
            m_TyClearTax = value
        End Set
    End Property
    Private m_TyClearTaxReson As String
    Public Property TyClearTaxReson As String
        Get
            Return m_TyClearTaxReson
        End Get
        Set(value As String)
            m_TyClearTaxReson = value
        End Set
    End Property
    Private m_EstDeliverDate As Date
    Public Property EstDeliverDate As Date
        Get
            Return m_EstDeliverDate
        End Get
        Set(value As Date)
            m_EstDeliverDate = value
        End Set
    End Property
    Private m_EstDeliverTime As Date
    Public Property EstDeliverTime As Date
        Get
            Return m_EstDeliverTime
        End Get
        Set(value As Date)
            m_EstDeliverTime = value
        End Set
    End Property
    Private m_TotalContainer As String
    Public Property TotalContainer As String
        Get
            Return m_TotalContainer
        End Get
        Set(value As String)
            m_TotalContainer = value
        End Set
    End Property
    Private m_DutyDate As Date
    Public Property DutyDate As Date
        Get
            Return m_DutyDate
        End Get
        Set(value As Date)
            m_DutyDate = value
        End Set
    End Property
    Private m_DutyAmount As Double
    Public Property DutyAmount As Double
        Get
            Return m_DutyAmount
        End Get
        Set(value As Double)
            m_DutyAmount = value
        End Set
    End Property
    Private m_DutyCustPayOther As String
    Public Property DutyCustPayOther As String
        Get
            Return m_DutyCustPayOther
        End Get
        Set(value As String)
            m_DutyCustPayOther = value
        End Set
    End Property
    Private m_DutyCustPayChqAmt As Double
    Public Property DutyCustPayChqAmt As Double
        Get
            Return m_DutyCustPayChqAmt
        End Get
        Set(value As Double)
            m_DutyCustPayChqAmt = value
        End Set
    End Property
    Private m_DutyCustPayBankAmt As Double
    Public Property DutyCustPayBankAmt As Double
        Get
            Return m_DutyCustPayBankAmt
        End Get
        Set(value As Double)
            m_DutyCustPayBankAmt = value
        End Set
    End Property
    Private m_DutyCustPayEPAYAmt As Double
    Public Property DutyCustPayEPAYAmt As Double
        Get
            Return m_DutyCustPayEPAYAmt
        End Get
        Set(value As Double)
            m_DutyCustPayEPAYAmt = value
        End Set
    End Property
    Private m_DutyCustPayCardAmt As Double
    Public Property DutyCustPayCardAmt As Double
        Get
            Return m_DutyCustPayCardAmt
        End Get
        Set(value As Double)
            m_DutyCustPayCardAmt = value
        End Set
    End Property
    Private m_DutyCustPayCashAmt As Double
    Public Property DutyCustPayCashAmt As Double
        Get
            Return m_DutyCustPayCashAmt
        End Get
        Set(value As Double)
            m_DutyCustPayCashAmt = value
        End Set
    End Property
    Private m_DutyCustPayOtherAmt As Double
    Public Property DutyCustPayOtherAmt As Double
        Get
            Return m_DutyCustPayOtherAmt
        End Get
        Set(value As Double)
            m_DutyCustPayOtherAmt = value
        End Set
    End Property
    Private m_DutyLtdPayOther As String
    Public Property DutyLtdPayOther As String
        Get
            Return m_DutyLtdPayOther
        End Get
        Set(value As String)
            m_DutyLtdPayOther = value
        End Set
    End Property
    Private m_DutyLtdPayChqAmt As Double
    Public Property DutyLtdPayChqAmt As Double
        Get
            Return m_DutyLtdPayChqAmt
        End Get
        Set(value As Double)
            m_DutyLtdPayChqAmt = value
        End Set
    End Property
    Private m_DutyLtdPayEPAYAmt As Double
    Public Property DutyLtdPayEPAYAmt As Double
        Get
            Return m_DutyLtdPayEPAYAmt
        End Get
        Set(value As Double)
            m_DutyLtdPayEPAYAmt = value
        End Set
    End Property
    Private m_DutyLtdPayCashAmt As Double
    Public Property DutyLtdPayCashAmt As Double
        Get
            Return m_DutyLtdPayCashAmt
        End Get
        Set(value As Double)
            m_DutyLtdPayCashAmt = value
        End Set
    End Property
    Private m_DutyLtdPayOtherAmt As Double
    Public Property DutyLtdPayOtherAmt As Double
        Get
            Return m_DutyLtdPayOtherAmt
        End Get
        Set(value As Double)
            m_DutyLtdPayOtherAmt = value
        End Set
    End Property
    Private m_ConfirmChqDate As Date
    Public Property ConfirmChqDate As Date
        Get
            Return m_ConfirmChqDate
        End Get
        Set(value As Date)
            m_ConfirmChqDate = value
        End Set
    End Property
    Private m_ShippingEmp As String
    Public Property ShippingEmp As String
        Get
            Return m_ShippingEmp
        End Get
        Set(value As String)
            m_ShippingEmp = value
        End Set
    End Property
    Private m_ShippingCmd As String
    Public Property ShippingCmd As String
        Get
            Return m_ShippingCmd
        End Get
        Set(value As String)
            m_ShippingCmd = value
        End Set
    End Property
    Private m_TotalGW As Double
    Public Property TotalGW As Double
        Get
            Return m_TotalGW
        End Get
        Set(value As Double)
            m_TotalGW = value
        End Set
    End Property
    Private m_GWUnit As String
    Public Property GWUnit As String
        Get
            Return m_GWUnit
        End Get
        Set(value As String)
            m_GWUnit = value
        End Set
    End Property
    Private m_TSRequest As Integer
    Public Property TSRequest As Integer
        Get
            Return m_TSRequest
        End Get
        Set(value As Integer)
            m_TSRequest = value
        End Set
    End Property
    Private m_ShipmentType As Integer
    Public Property ShipmentType As Integer
        Get
            Return m_ShipmentType
        End Get
        Set(value As Integer)
            m_ShipmentType = value
        End Set
    End Property
    Private m_ReadyToClearDate As Date
    Public Property ReadyToClearDate As Date
        Get
            Return m_ReadyToClearDate
        End Get
        Set(value As Date)
            m_ReadyToClearDate = value
        End Set
    End Property
    Private m_Commission As Integer
    Public Property Commission As Integer
        Get
            Return m_Commission
        End Get
        Set(value As Integer)
            m_Commission = value
        End Set
    End Property
    Private m_CommPayTo As String
    Public Property CommPayTo As String
        Get
            Return m_CommPayTo
        End Get
        Set(value As String)
            m_CommPayTo = value
        End Set
    End Property
    Private m_ProjectName As String
    Public Property ProjectName As String
        Get
            Return m_ProjectName
        End Get
        Set(value As String)
            m_ProjectName = value
        End Set
    End Property
    Private m_MVesselName As String
    Public Property MVesselName As String
        Get
            Return m_MVesselName
        End Get
        Set(value As String)
            m_MVesselName = value
        End Set
    End Property
    Private m_TotalNW As Double
    Public Property TotalNW As Double
        Get
            Return m_TotalNW
        End Get
        Set(value As Double)
            m_TotalNW = value
        End Set
    End Property
    Private m_Measurement As String
    Public Property Measurement As String
        Get
            Return m_Measurement
        End Get
        Set(value As String)
            m_Measurement = value
        End Set
    End Property
    Private m_CustRefNO As String
    Public Property CustRefNO As String
        Get
            Return m_CustRefNO
        End Get
        Set(value As String)
            m_CustRefNO = value
        End Set
    End Property
    Private m_TotalQty As String
    Public Property TotalQty As String
        Get
            Return m_TotalQty
        End Get
        Set(value As String)
            m_TotalQty = value
        End Set
    End Property
    Private m_HAWB As String
    Public Property HAWB As String
        Get
            Return m_HAWB
        End Get
        Set(value As String)
            m_HAWB = value
        End Set
    End Property
    Private m_MAWB As String
    Public Property MAWB As String
        Get
            Return m_MAWB
        End Get
        Set(value As String)
            m_MAWB = value
        End Set
    End Property
    Private m_consigneecode As String
    Public Property Consigneecode As String
        Get
            Return m_consigneecode
        End Get
        Set(value As String)
            m_consigneecode = value
        End Set
    End Property
    Private m_privilegests As String
    Public Property Privilegests As String
        Get
            Return m_privilegests
        End Get
        Set(value As String)
            m_privilegests = value
        End Set
    End Property
    Private m_DeliveryNo As String
    Public Property DeliveryNo As String
        Get
            Return m_DeliveryNo
        End Get
        Set(value As String)
            m_DeliveryNo = value
        End Set
    End Property
    Private m_DeliveryTo As String
    Public Property DeliveryTo As String
        Get
            Return m_DeliveryTo
        End Get
        Set(value As String)
            m_DeliveryTo = value
        End Set
    End Property
    Private m_DeliveryAddr As String
    Public Property DeliveryAddr As String
        Get
            Return m_DeliveryAddr
        End Get
        Set(value As String)
            m_DeliveryAddr = value
        End Set
    End Property
    Public Sub AddNew(pFormatSQL As String, Optional pClearAll As Boolean = True)
        If pFormatSQL = "" Then
            m_JNo = ""
        Else
            Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(JNo) as Ret FROM Job_Order WHERE JNo Like '{0}'", pFormatSQL), pFormatSQL)
            m_JNo = retStr
        End If
        If pClearAll Then
            m_CancelDate = SqlTypes.SqlDateTime.MinValue
            m_CancelProveDate = SqlTypes.SqlDateTime.MinValue
            m_DocDate = SqlTypes.SqlDateTime.MinValue
            m_ClearDate = SqlTypes.SqlDateTime.MinValue
            m_CloseJobDate = SqlTypes.SqlDateTime.MinValue
            m_ConfirmChqDate = SqlTypes.SqlDateTime.MinValue
            m_ConfirmDate = SqlTypes.SqlDateTime.MinValue
            m_DutyDate = SqlTypes.SqlDateTime.MinValue
            m_EstDeliverDate = SqlTypes.SqlDateTime.MinValue
            m_EstDeliverTime = SqlTypes.SqlDateTime.MinValue
            m_ETADate = SqlTypes.SqlDateTime.MinValue
            m_ETDDate = SqlTypes.SqlDateTime.MinValue
            m_ImExDate = SqlTypes.SqlDateTime.MinValue
            m_LoadDate = SqlTypes.SqlDateTime.MinValue
            m_ReadyToClearDate = SqlTypes.SqlDateTime.MinValue

            m_CancelProveTime = SqlTypes.SqlDateTime.MinValue
            m_CancelTime = SqlTypes.SqlDateTime.MinValue
            m_CloseJobTime = SqlTypes.SqlDateTime.MinValue
            m_ETTime = SqlTypes.SqlDateTime.MinValue
        End If
    End Sub
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Try
            Using cn As New SqlConnection(m_ConnStr)
                cn.Open()
                Using da As New SqlDataAdapter("SELECT * FROM Job_Order" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("JNo") = Me.JNo
                            dr("JRevise") = Me.JRevise
                            dr("ConfirmDate") = Main.GetDBDate(Me.ConfirmDate)
                            dr("CPolicyCode") = Me.CPolicyCode
                            dr("DocDate") = Main.GetDBDate(Me.DocDate, True)
                            dr("CustCode") = Me.CustCode
                            dr("CustBranch") = Me.CustBranch
                            dr("CustContactName") = Me.CustContactName
                            dr("QNo") = Me.QNo
                            dr("Revise") = Me.Revise
                            dr("ManagerCode") = Me.ManagerCode
                            dr("CSCode") = Me.CSCode
                            dr("Description") = Me.Description
                            dr("TRemark") = Me.TRemark
                            dr("JobStatus") = Me.JobStatus
                            dr("JobType") = Me.JobType
                            dr("ShipBy") = Me.ShipBy
                            dr("InvNo") = Me.InvNo
                            dr("InvTotal") = Me.InvTotal
                            dr("InvProduct") = Me.InvProduct
                            dr("InvCountry") = Me.InvCountry
                            dr("InvFCountry") = Me.InvFCountry
                            dr("InvInterPort") = Me.InvInterPort
                            dr("InvProductQty") = Me.InvProductQty
                            dr("InvProductUnit") = Me.InvProductUnit
                            dr("InvCurUnit") = Me.InvCurUnit
                            dr("InvCurRate") = Me.InvCurRate
                            dr("ImExDate") = Main.GetDBDate(Me.ImExDate)

                            dr("BLNo") = Me.BLNo
                            dr("BookingNo") = Me.BookingNo
                            dr("ClearPort") = Me.ClearPort
                            dr("ClearPortNo") = Me.ClearPortNo
                            dr("ClearDate") = Main.GetDBDate(Me.ClearDate)
                            dr("LoadDate") = Main.GetDBDate(Me.LoadDate)

                            dr("ForwarderCode") = Me.ForwarderCode
                            dr("AgentCode") = Me.AgentCode
                            dr("VesselName") = Me.VesselName
                            dr("ETDDate") = Main.GetDBDate(Me.ETDDate)
                            dr("ETADate") = Main.GetDBDate(Me.ETADate)

                            dr("ETTime") = Me.ETTime
                            dr("FNetPrice") = Me.FNetPrice
                            dr("BNetPrice") = Me.BNetPrice
                            dr("CancelReson") = Me.CancelReson
                            dr("CancelDate") = Main.GetDBDate(Me.CancelDate)

                            dr("CancelProve") = Me.CancelProve
                            dr("CancelProveDate") = Main.GetDBDate(Me.CancelProveDate)
                            dr("CloseJobDate") = Main.GetDBDate(Me.CloseJobDate)

                            dr("CloseJobBy") = Me.CloseJobBy
                            dr("DeclareType") = Me.DeclareType
                            dr("DeclareNumber") = Me.DeclareNumber
                            dr("DeclareStatus") = Me.DeclareStatus
                            dr("TyAuthorSp") = Me.TyAuthorSp
                            dr("Ty19BIS") = Me.Ty19BIS
                            dr("TyClearTax") = Me.TyClearTax
                            dr("TyClearTaxReson") = Me.TyClearTaxReson
                            dr("EstDeliverDate") = Main.GetDBDate(Me.EstDeliverDate)

                            dr("TotalContainer") = Me.TotalContainer
                            dr("DutyDate") = Main.GetDBDate(Me.DutyDate)

                            dr("DutyAmount") = Me.DutyAmount
                            dr("DutyCustPayOther") = Me.DutyCustPayOther
                            dr("DutyCustPayChqAmt") = Me.DutyCustPayChqAmt
                            dr("DutyCustPayBankAmt") = Me.DutyCustPayBankAmt
                            dr("DutyCustPayEPAYAmt") = Me.DutyCustPayEPAYAmt
                            dr("DutyCustPayCardAmt") = Me.DutyCustPayCardAmt
                            dr("DutyCustPayCashAmt") = Me.DutyCustPayCashAmt
                            dr("DutyCustPayOtherAmt") = Me.DutyCustPayOtherAmt
                            dr("DutyLtdPayOther") = Me.DutyLtdPayOther
                            dr("DutyLtdPayChqAmt") = Me.DutyLtdPayChqAmt
                            dr("DutyLtdPayEPAYAmt") = Me.DutyLtdPayEPAYAmt
                            dr("DutyLtdPayCashAmt") = Me.DutyLtdPayCashAmt
                            dr("DutyLtdPayOtherAmt") = Me.DutyLtdPayOtherAmt
                            dr("ConfirmChqDate") = Main.GetDBDate(Me.ConfirmChqDate)

                            dr("CancelProveTime") = Main.GetDBTime(Me.CancelProveTime)
                            dr("CancelTime") = Main.GetDBTime(Me.CancelTime)
                            dr("CloseJobTime") = Main.GetDBTime(Me.CloseJobTime)
                            dr("ETTime") = Main.GetDBTime(Me.ETTime)

                            dr("ShippingEmp") = Me.ShippingEmp
                            dr("ShippingCmd") = Me.ShippingCmd
                            dr("TotalGW") = Me.TotalGW
                            dr("GWUnit") = Me.GWUnit
                            dr("TSRequest") = Me.TSRequest
                            dr("ShipmentType") = Me.ShipmentType
                            dr("ReadyToClearDate") = Main.GetDBDate(Me.ReadyToClearDate)

                            dr("Commission") = Me.Commission
                            dr("CommPayTo") = Me.CommPayTo
                            dr("ProjectName") = Me.ProjectName
                            dr("MVesselName") = Me.MVesselName
                            dr("TotalNW") = Me.TotalNW
                            dr("Measurement") = Me.Measurement
                            dr("CustRefNO") = Me.CustRefNO
                            dr("TotalQty") = Me.TotalQty
                            dr("HAWB") = Me.HAWB
                            dr("MAWB") = Me.MAWB
                            dr("consigneecode") = Me.Consigneecode
                            dr("privilegests") = Me.Privilegests
                            dr("DeliveryTo") = Me.DeliveryTo
                            dr("DeliveryNo") = Me.DeliveryNo
                            dr("DeliveryAddr") = Me.DeliveryAddr
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CJobOrder", "SaveData", Me)
                            msg = "Save " & Me.JNo & " Complete"
                        End Using
                    End Using

                End Using
            End Using
        Catch e As Exception
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CJobOrder", "SaveData", e.Message)
            msg = "[error]" & e.Message
        End Try
        Return msg
    End Function
    Public Function GetData(Optional pSQLWhere As String = "") As List(Of CJobOrder)
        Dim lst As New List(Of CJobOrder)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CJobOrder
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_Order" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CJobOrder(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JNo"))) = False Then
                        row.JNo = rd.GetString(rd.GetOrdinal("JNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JRevise"))) = False Then
                        row.JRevise = rd.GetByte(rd.GetOrdinal("JRevise"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ConfirmDate"))) = False Then
                        row.ConfirmDate = rd.GetValue(rd.GetOrdinal("ConfirmDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CPolicyCode"))) = False Then
                        row.CPolicyCode = rd.GetString(rd.GetOrdinal("CPolicyCode")).ToString()
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
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustContactName"))) = False Then
                        row.CustContactName = rd.GetString(rd.GetOrdinal("CustContactName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("QNo"))) = False Then
                        row.QNo = rd.GetString(rd.GetOrdinal("QNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Revise"))) = False Then
                        row.Revise = rd.GetInt16(rd.GetOrdinal("Revise"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ManagerCode"))) = False Then
                        row.ManagerCode = rd.GetString(rd.GetOrdinal("ManagerCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CSCode"))) = False Then
                        row.CSCode = rd.GetString(rd.GetOrdinal("CSCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Description"))) = False Then
                        row.Description = rd.GetString(rd.GetOrdinal("Description")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TRemark"))) = False Then
                        row.TRemark = rd.GetString(rd.GetOrdinal("TRemark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JobStatus"))) = False Then
                        row.JobStatus = rd.GetByte(rd.GetOrdinal("JobStatus"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JobType"))) = False Then
                        row.JobType = rd.GetByte(rd.GetOrdinal("JobType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ShipBy"))) = False Then
                        row.ShipBy = rd.GetByte(rd.GetOrdinal("ShipBy"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvNo"))) = False Then
                        row.InvNo = rd.GetString(rd.GetOrdinal("InvNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvTotal"))) = False Then
                        row.InvTotal = rd.GetDouble(rd.GetOrdinal("InvTotal"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvProduct"))) = False Then
                        row.InvProduct = rd.GetString(rd.GetOrdinal("InvProduct")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvCountry"))) = False Then
                        row.InvCountry = rd.GetString(rd.GetOrdinal("InvCountry")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvFCountry"))) = False Then
                        row.InvFCountry = rd.GetString(rd.GetOrdinal("InvFCountry")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvInterPort"))) = False Then
                        row.InvInterPort = rd.GetString(rd.GetOrdinal("InvInterPort")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvProductQty"))) = False Then
                        row.InvProductQty = rd.GetDouble(rd.GetOrdinal("InvProductQty"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvProductUnit"))) = False Then
                        row.InvProductUnit = rd.GetString(rd.GetOrdinal("InvProductUnit")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvCurUnit"))) = False Then
                        row.InvCurUnit = rd.GetString(rd.GetOrdinal("InvCurUnit")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvCurRate"))) = False Then
                        row.InvCurRate = rd.GetDouble(rd.GetOrdinal("InvCurRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ImExDate"))) = False Then
                        row.ImExDate = rd.GetValue(rd.GetOrdinal("ImExDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BLNo"))) = False Then
                        row.BLNo = rd.GetString(rd.GetOrdinal("BLNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BookingNo"))) = False Then
                        row.BookingNo = rd.GetString(rd.GetOrdinal("BookingNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ClearPort"))) = False Then
                        row.ClearPort = rd.GetString(rd.GetOrdinal("ClearPort")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ClearPortNo"))) = False Then
                        row.ClearPortNo = rd.GetString(rd.GetOrdinal("ClearPortNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ClearDate"))) = False Then
                        row.ClearDate = rd.GetValue(rd.GetOrdinal("ClearDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LoadDate"))) = False Then
                        row.LoadDate = rd.GetValue(rd.GetOrdinal("LoadDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ForwarderCode"))) = False Then
                        row.ForwarderCode = rd.GetString(rd.GetOrdinal("ForwarderCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AgentCode"))) = False Then
                        row.AgentCode = rd.GetString(rd.GetOrdinal("AgentCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VesselName"))) = False Then
                        row.VesselName = rd.GetString(rd.GetOrdinal("VesselName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ETDDate"))) = False Then
                        row.ETDDate = rd.GetValue(rd.GetOrdinal("ETDDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ETADate"))) = False Then
                        row.ETADate = rd.GetValue(rd.GetOrdinal("ETADate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ETTime"))) = False Then
                        row.ETTime = rd.GetValue(rd.GetOrdinal("ETTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FNetPrice"))) = False Then
                        row.FNetPrice = rd.GetString(rd.GetOrdinal("FNetPrice")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BNetPrice"))) = False Then
                        row.BNetPrice = rd.GetDouble(rd.GetOrdinal("BNetPrice"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelReson"))) = False Then
                        row.CancelReson = rd.GetString(rd.GetOrdinal("CancelReson")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelDate"))) = False Then
                        row.CancelDate = rd.GetValue(rd.GetOrdinal("CancelDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelTime"))) = False Then
                        row.CancelTime = rd.GetValue(rd.GetOrdinal("CancelTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelProve"))) = False Then
                        row.CancelProve = rd.GetString(rd.GetOrdinal("CancelProve")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelProveDate"))) = False Then
                        row.CancelProveDate = rd.GetValue(rd.GetOrdinal("CancelProveDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelProveTime"))) = False Then
                        row.CancelProveTime = rd.GetValue(rd.GetOrdinal("CancelProveTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CloseJobDate"))) = False Then
                        row.CloseJobDate = rd.GetValue(rd.GetOrdinal("CloseJobDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CloseJobTime"))) = False Then
                        row.CloseJobTime = rd.GetValue(rd.GetOrdinal("CloseJobTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CloseJobBy"))) = False Then
                        row.CloseJobBy = rd.GetString(rd.GetOrdinal("CloseJobBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DeclareType"))) = False Then
                        row.DeclareType = rd.GetString(rd.GetOrdinal("DeclareType")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DeclareNumber"))) = False Then
                        row.DeclareNumber = rd.GetString(rd.GetOrdinal("DeclareNumber")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DeclareStatus"))) = False Then
                        row.DeclareStatus = rd.GetString(rd.GetOrdinal("DeclareStatus")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TyAuthorSp"))) = False Then
                        row.TyAuthorSp = rd.GetString(rd.GetOrdinal("TyAuthorSp")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Ty19BIS"))) = False Then
                        row.Ty19BIS = rd.GetString(rd.GetOrdinal("Ty19BIS")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TyClearTax"))) = False Then
                        row.TyClearTax = rd.GetString(rd.GetOrdinal("TyClearTax")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TyClearTaxReson"))) = False Then
                        row.TyClearTaxReson = rd.GetString(rd.GetOrdinal("TyClearTaxReson")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EstDeliverDate"))) = False Then
                        row.EstDeliverDate = rd.GetValue(rd.GetOrdinal("EstDeliverDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EstDeliverTime"))) = False Then
                        row.EstDeliverTime = rd.GetValue(rd.GetOrdinal("EstDeliverTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalContainer"))) = False Then
                        row.TotalContainer = rd.GetString(rd.GetOrdinal("TotalContainer")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyDate"))) = False Then
                        row.DutyDate = rd.GetValue(rd.GetOrdinal("DutyDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyAmount"))) = False Then
                        row.DutyAmount = rd.GetDouble(rd.GetOrdinal("DutyAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyCustPayOther"))) = False Then
                        row.DutyCustPayOther = rd.GetString(rd.GetOrdinal("DutyCustPayOther")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyCustPayChqAmt"))) = False Then
                        row.DutyCustPayChqAmt = rd.GetDouble(rd.GetOrdinal("DutyCustPayChqAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyCustPayBankAmt"))) = False Then
                        row.DutyCustPayBankAmt = rd.GetDouble(rd.GetOrdinal("DutyCustPayBankAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyCustPayEPAYAmt"))) = False Then
                        row.DutyCustPayEPAYAmt = rd.GetDouble(rd.GetOrdinal("DutyCustPayEPAYAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyCustPayCardAmt"))) = False Then
                        row.DutyCustPayCardAmt = rd.GetDouble(rd.GetOrdinal("DutyCustPayCardAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyCustPayCashAmt"))) = False Then
                        row.DutyCustPayCashAmt = rd.GetDouble(rd.GetOrdinal("DutyCustPayCashAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyCustPayOtherAmt"))) = False Then
                        row.DutyCustPayOtherAmt = rd.GetDouble(rd.GetOrdinal("DutyCustPayOtherAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyLtdPayOther"))) = False Then
                        row.DutyLtdPayOther = rd.GetString(rd.GetOrdinal("DutyLtdPayOther")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyLtdPayChqAmt"))) = False Then
                        row.DutyLtdPayChqAmt = rd.GetDouble(rd.GetOrdinal("DutyLtdPayChqAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyLtdPayEPAYAmt"))) = False Then
                        row.DutyLtdPayEPAYAmt = rd.GetDouble(rd.GetOrdinal("DutyLtdPayEPAYAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyLtdPayCashAmt"))) = False Then
                        row.DutyLtdPayCashAmt = rd.GetDouble(rd.GetOrdinal("DutyLtdPayCashAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyLtdPayOtherAmt"))) = False Then
                        row.DutyLtdPayOtherAmt = rd.GetDouble(rd.GetOrdinal("DutyLtdPayOtherAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ConfirmChqDate"))) = False Then
                        row.ConfirmChqDate = rd.GetValue(rd.GetOrdinal("ConfirmChqDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ShippingEmp"))) = False Then
                        row.ShippingEmp = rd.GetString(rd.GetOrdinal("ShippingEmp")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ShippingCmd"))) = False Then
                        row.ShippingCmd = rd.GetString(rd.GetOrdinal("ShippingCmd")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalGW"))) = False Then
                        row.TotalGW = rd.GetDouble(rd.GetOrdinal("TotalGW"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GWUnit"))) = False Then
                        row.GWUnit = rd.GetString(rd.GetOrdinal("GWUnit")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TSRequest"))) = False Then
                        row.TSRequest = rd.GetByte(rd.GetOrdinal("TSRequest"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ShipmentType"))) = False Then
                        row.ShipmentType = rd.GetByte(rd.GetOrdinal("ShipmentType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReadyToClearDate"))) = False Then
                        row.ReadyToClearDate = rd.GetValue(rd.GetOrdinal("ReadyToClearDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Commission"))) = False Then
                        row.Commission = rd.GetInt32(rd.GetOrdinal("Commission"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CommPayTo"))) = False Then
                        row.CommPayTo = rd.GetString(rd.GetOrdinal("CommPayTo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ProjectName"))) = False Then
                        row.ProjectName = rd.GetString(rd.GetOrdinal("ProjectName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("MVesselName"))) = False Then
                        row.MVesselName = rd.GetString(rd.GetOrdinal("MVesselName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalNW"))) = False Then
                        row.TotalNW = rd.GetDouble(rd.GetOrdinal("TotalNW"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Measurement"))) = False Then
                        row.Measurement = rd.GetString(rd.GetOrdinal("Measurement")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustRefNO"))) = False Then
                        row.CustRefNO = rd.GetString(rd.GetOrdinal("CustRefNO")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalQty"))) = False Then
                        row.TotalQty = rd.GetString(rd.GetOrdinal("TotalQty")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("HAWB"))) = False Then
                        row.HAWB = rd.GetString(rd.GetOrdinal("HAWB")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("MAWB"))) = False Then
                        row.MAWB = rd.GetString(rd.GetOrdinal("MAWB")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("consigneecode"))) = False Then
                        row.Consigneecode = rd.GetString(rd.GetOrdinal("consigneecode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("privilegests"))) = False Then
                        row.Privilegests = rd.GetString(rd.GetOrdinal("privilegests")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DeliveryNo"))) = False Then
                        row.DeliveryNo = rd.GetString(rd.GetOrdinal("DeliveryNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DeliveryTo"))) = False Then
                        row.DeliveryTo = rd.GetString(rd.GetOrdinal("DeliveryTo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DeliveryAddr"))) = False Then
                        row.DeliveryAddr = rd.GetString(rd.GetOrdinal("DeliveryAddr")).ToString()
                    End If
                    lst.Add(row)
                End While
            Catch ex As Exception
            End Try
        End Using
        Return lst
    End Function
End Class