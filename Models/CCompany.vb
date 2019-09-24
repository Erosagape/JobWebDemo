Imports System.Data.SqlClient
Public Class CCompany
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_CustCode As String
    Public Property CustCode As String
        Get
            Return m_CustCode
        End Get
        Set(value As String)
            m_CustCode = value
        End Set
    End Property
    Private m_Branch As String
    Public Property Branch As String
        Get
            Return m_Branch
        End Get
        Set(value As String)
            m_Branch = value
        End Set
    End Property
    Private m_CustGroup As String
    Public Property CustGroup As String
        Get
            Return m_CustGroup
        End Get
        Set(value As String)
            m_CustGroup = value
        End Set
    End Property
    Private m_TaxNumber As String
    Public Property TaxNumber As String
        Get
            Return m_TaxNumber
        End Get
        Set(value As String)
            m_TaxNumber = value
        End Set
    End Property
    Private m_Title As String
    Public Property Title As String
        Get
            Return m_Title
        End Get
        Set(value As String)
            m_Title = value
        End Set
    End Property
    Private m_NameThai As String
    Public Property NameThai As String
        Get
            Return m_NameThai
        End Get
        Set(value As String)
            m_NameThai = value
        End Set
    End Property
    Private m_NameEng As String
    Public Property NameEng As String
        Get
            Return m_NameEng
        End Get
        Set(value As String)
            m_NameEng = value
        End Set
    End Property
    Private m_TAddress1 As String
    Public Property TAddress1 As String
        Get
            Return m_TAddress1
        End Get
        Set(value As String)
            m_TAddress1 = value
        End Set
    End Property
    Private m_TAddress2 As String
    Public Property TAddress2 As String
        Get
            Return m_TAddress2
        End Get
        Set(value As String)
            m_TAddress2 = value
        End Set
    End Property
    Private m_EAddress1 As String
    Public Property EAddress1 As String
        Get
            Return m_EAddress1
        End Get
        Set(value As String)
            m_EAddress1 = value
        End Set
    End Property
    Private m_EAddress2 As String
    Public Property EAddress2 As String
        Get
            Return m_EAddress2
        End Get
        Set(value As String)
            m_EAddress2 = value
        End Set
    End Property
    Private m_Phone As String
    Public Property Phone As String
        Get
            Return m_Phone
        End Get
        Set(value As String)
            m_Phone = value
        End Set
    End Property
    Private m_FaxNumber As String
    Public Property FaxNumber As String
        Get
            Return m_FaxNumber
        End Get
        Set(value As String)
            m_FaxNumber = value
        End Set
    End Property
    Private m_LoginName As String
    Public Property LoginName As String
        Get
            Return m_LoginName
        End Get
        Set(value As String)
            m_LoginName = value
        End Set
    End Property
    Private m_LoginPassword As String
    Public Property LoginPassword As String
        Get
            Return m_LoginPassword
        End Get
        Set(value As String)
            m_LoginPassword = value
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
    Private m_CSCodeIM As String
    Public Property CSCodeIM As String
        Get
            Return m_CSCodeIM
        End Get
        Set(value As String)
            m_CSCodeIM = value
        End Set
    End Property
    Private m_CSCodeEX As String
    Public Property CSCodeEX As String
        Get
            Return m_CSCodeEX
        End Get
        Set(value As String)
            m_CSCodeEX = value
        End Set
    End Property
    Private m_CSCodeOT As String
    Public Property CSCodeOT As String
        Get
            Return m_CSCodeOT
        End Get
        Set(value As String)
            m_CSCodeOT = value
        End Set
    End Property
    Private m_GLAccountCode As String
    Public Property GLAccountCode As String
        Get
            Return m_GLAccountCode
        End Get
        Set(value As String)
            m_GLAccountCode = value
        End Set
    End Property
    Private m_CustType As Integer
    Public Property CustType As Integer
        Get
            Return m_CustType
        End Get
        Set(value As Integer)
            m_CustType = value
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
    Private m_BillToBranch As String
    Public Property BillToBranch As String
        Get
            Return m_BillToBranch
        End Get
        Set(value As String)
            m_BillToBranch = value
        End Set
    End Property
    Private m_UsedLanguage As String
    Public Property UsedLanguage As String
        Get
            Return m_UsedLanguage
        End Get
        Set(value As String)
            m_UsedLanguage = value
        End Set
    End Property
    Private m_LevelGrade As String
    Public Property LevelGrade As String
        Get
            Return m_LevelGrade
        End Get
        Set(value As String)
            m_LevelGrade = value
        End Set
    End Property
    Private m_TermOfPayment As Integer
    Public Property TermOfPayment As Integer
        Get
            Return m_TermOfPayment
        End Get
        Set(value As Integer)
            m_TermOfPayment = value
        End Set
    End Property
    Private m_BillCondition As String
    Public Property BillCondition As String
        Get
            Return m_BillCondition
        End Get
        Set(value As String)
            m_BillCondition = value
        End Set
    End Property
    Private m_CreditLimit As Double
    Public Property CreditLimit As Double
        Get
            Return m_CreditLimit
        End Get
        Set(value As Double)
            m_CreditLimit = value
        End Set
    End Property
    Private m_MapText As String
    Public Property MapText As String
        Get
            Return m_MapText
        End Get
        Set(value As String)
            m_MapText = value
        End Set
    End Property
    Private m_MapFileName As String
    Public Property MapFileName As String
        Get
            Return m_MapFileName
        End Get
        Set(value As String)
            m_MapFileName = value
        End Set
    End Property
    Private m_CmpType As String
    Public Property CmpType As String
        Get
            Return m_CmpType
        End Get
        Set(value As String)
            m_CmpType = value
        End Set
    End Property
    Private m_CmpLevelExp As String
    Public Property CmpLevelExp As String
        Get
            Return m_CmpLevelExp
        End Get
        Set(value As String)
            m_CmpLevelExp = value
        End Set
    End Property
    Private m_CmpLevelImp As String
    Public Property CmpLevelImp As String
        Get
            Return m_CmpLevelImp
        End Get
        Set(value As String)
            m_CmpLevelImp = value
        End Set
    End Property
    Private m_Is19bis As Integer
    Public Property Is19bis As Integer
        Get
            Return m_Is19bis
        End Get
        Set(value As Integer)
            m_Is19bis = value
        End Set
    End Property
    Private m_MgrSeq As Integer
    Public Property MgrSeq As Integer
        Get
            Return m_MgrSeq
        End Get
        Set(value As Integer)
            m_MgrSeq = value
        End Set
    End Property
    Private m_LevelNoExp As Integer
    Public Property LevelNoExp As Integer
        Get
            Return m_LevelNoExp
        End Get
        Set(value As Integer)
            m_LevelNoExp = value
        End Set
    End Property
    Private m_LevelNoImp As Integer
    Public Property LevelNoImp As Integer
        Get
            Return m_LevelNoImp
        End Get
        Set(value As Integer)
            m_LevelNoImp = value
        End Set
    End Property
    Private m_LnNO As String
    Public Property LnNO As String
        Get
            Return m_LnNO
        End Get
        Set(value As String)
            m_LnNO = value
        End Set
    End Property
    Private m_AdjTaxCode As String
    Public Property AdjTaxCode As String
        Get
            Return m_AdjTaxCode
        End Get
        Set(value As String)
            m_AdjTaxCode = value
        End Set
    End Property
    Private m_BkAuthorNo As String
    Public Property BkAuthorNo As String
        Get
            Return m_BkAuthorNo
        End Get
        Set(value As String)
            m_BkAuthorNo = value
        End Set
    End Property
    Private m_BkAuthorCnn As String
    Public Property BkAuthorCnn As String
        Get
            Return m_BkAuthorCnn
        End Get
        Set(value As String)
            m_BkAuthorCnn = value
        End Set
    End Property
    Private m_LtdPsWkName As String
    Public Property LtdPsWkName As String
        Get
            Return m_LtdPsWkName
        End Get
        Set(value As String)
            m_LtdPsWkName = value
        End Set
    End Property
    Private m_ConsStatus As String
    Public Property ConsStatus As String
        Get
            Return m_ConsStatus
        End Get
        Set(value As String)
            m_ConsStatus = value
        End Set
    End Property
    Private m_CommLevel As String
    Public Property CommLevel As String
        Get
            Return m_CommLevel
        End Get
        Set(value As String)
            m_CommLevel = value
        End Set
    End Property
    Private m_DutyLimit As Double
    Public Property DutyLimit As Double
        Get
            Return m_DutyLimit
        End Get
        Set(value As Double)
            m_DutyLimit = value
        End Set
    End Property
    Private m_CommRate As Double
    Public Property CommRate As Double
        Get
            Return m_CommRate
        End Get
        Set(value As Double)
            m_CommRate = value
        End Set
    End Property
    Private m_TAddress As String
    Public Property TAddress As String
        Get
            Return m_TAddress
        End Get
        Set(value As String)
            m_TAddress = value
        End Set
    End Property
    Private m_TDistrict As String
    Public Property TDistrict As String
        Get
            Return m_TDistrict
        End Get
        Set(value As String)
            m_TDistrict = value
        End Set
    End Property
    Private m_TSubProvince As String
    Public Property TSubProvince As String
        Get
            Return m_TSubProvince
        End Get
        Set(value As String)
            m_TSubProvince = value
        End Set
    End Property
    Private m_TProvince As String
    Public Property TProvince As String
        Get
            Return m_TProvince
        End Get
        Set(value As String)
            m_TProvince = value
        End Set
    End Property
    Private m_TPostCode As String
    Public Property TPostCode As String
        Get
            Return m_TPostCode
        End Get
        Set(value As String)
            m_TPostCode = value
        End Set
    End Property
    Private m_DMailAddress As String
    Public Property DMailAddress As String
        Get
            Return m_DMailAddress
        End Get
        Set(value As String)
            m_DMailAddress = value
        End Set
    End Property
    Private m_PrivilegeOption As String
    Public Property PrivilegeOption As String
        Get
            Return m_PrivilegeOption
        End Get
        Set(value As String)
            m_PrivilegeOption = value
        End Set
    End Property
    Private m_GoldCardNO As Integer
    Public Property GoldCardNO As Integer
        Get
            Return m_GoldCardNO
        End Get
        Set(value As Integer)
            m_GoldCardNO = value
        End Set
    End Property
    Private m_CustomsBrokerSeq As Integer
    Public Property CustomsBrokerSeq As Integer
        Get
            Return m_CustomsBrokerSeq
        End Get
        Set(value As Integer)
            m_CustomsBrokerSeq = value
        End Set
    End Property
    Private m_ISCustomerSign As Integer
    Public Property ISCustomerSign As Integer
        Get
            Return m_ISCustomerSign
        End Get
        Set(value As Integer)
            m_ISCustomerSign = value
        End Set
    End Property
    Private m_ISCustomerSignInv As Integer
    Public Property ISCustomerSignInv As Integer
        Get
            Return m_ISCustomerSignInv
        End Get
        Set(value As Integer)
            m_ISCustomerSignInv = value
        End Set
    End Property
    Private m_ISCustomerSignDec As Integer
    Public Property ISCustomerSignDec As Integer
        Get
            Return m_ISCustomerSignDec
        End Get
        Set(value As Integer)
            m_ISCustomerSignDec = value
        End Set
    End Property
    Private m_ISCustomerSignECon As Integer
    Public Property ISCustomerSignECon As Integer
        Get
            Return m_ISCustomerSignECon
        End Get
        Set(value As Integer)
            m_ISCustomerSignECon = value
        End Set
    End Property
    Private m_IsShippingCannotSign As Integer
    Public Property IsShippingCannotSign As Integer
        Get
            Return m_IsShippingCannotSign
        End Get
        Set(value As Integer)
            m_IsShippingCannotSign = value
        End Set
    End Property
    Private m_ExportCode As String
    Public Property ExportCode As String
        Get
            Return m_ExportCode
        End Get
        Set(value As String)
            m_ExportCode = value
        End Set
    End Property
    Private m_Code19BIS As String
    Public Property Code19BIS As String
        Get
            Return m_Code19BIS
        End Get
        Set(value As String)
            m_Code19BIS = value
        End Set
    End Property
    Private m_WEB_SITE As String
    Public Property WEB_SITE As String
        Get
            Return m_WEB_SITE
        End Get
        Set(value As String)
            m_WEB_SITE = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_Company" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("CustCode") = Me.CustCode
                            dr("Branch") = Me.Branch
                            dr("CustGroup") = Me.CustGroup
                            dr("TaxNumber") = Me.TaxNumber
                            dr("Title") = Me.Title
                            dr("NameThai") = Me.NameThai
                            dr("NameEng") = Me.NameEng
                            dr("TAddress1") = Me.TAddress1
                            dr("TAddress2") = Me.TAddress2
                            dr("EAddress1") = Me.EAddress1
                            dr("EAddress2") = Me.EAddress2
                            dr("Phone") = Me.Phone
                            dr("FaxNumber") = Me.FaxNumber
                            dr("LoginName") = Me.LoginName
                            dr("LoginPassword") = Me.LoginPassword
                            dr("ManagerCode") = Me.ManagerCode
                            dr("CSCodeIM") = Me.CSCodeIM
                            dr("CSCodeEX") = Me.CSCodeEX
                            dr("CSCodeOT") = Me.CSCodeOT
                            dr("GLAccountCode") = Me.GLAccountCode
                            dr("CustType") = Me.CustType
                            dr("BillToCustCode") = Me.BillToCustCode
                            dr("BillToBranch") = Me.BillToBranch
                            dr("UsedLanguage") = Me.UsedLanguage
                            dr("LevelGrade") = Me.LevelGrade
                            dr("TermOfPayment") = Me.TermOfPayment
                            dr("BillCondition") = Me.BillCondition
                            dr("CreditLimit") = Me.CreditLimit
                            dr("MapText") = Me.MapText
                            dr("MapFileName") = Me.MapFileName
                            dr("CmpType") = Me.CmpType
                            dr("CmpLevelExp") = Me.CmpLevelExp
                            dr("CmpLevelImp") = Me.CmpLevelImp
                            dr("Is19bis") = Me.Is19bis
                            dr("MgrSeq") = Me.MgrSeq
                            dr("LevelNoExp") = Me.LevelNoExp
                            dr("LevelNoImp") = Me.LevelNoImp
                            dr("LnNO") = Me.LnNO
                            dr("AdjTaxCode") = Me.AdjTaxCode
                            dr("BkAuthorNo") = Me.BkAuthorNo
                            dr("BkAuthorCnn") = Me.BkAuthorCnn
                            dr("LtdPsWkName") = Me.LtdPsWkName
                            dr("ConsStatus") = Me.ConsStatus
                            dr("CommLevel") = Me.CommLevel
                            dr("DutyLimit") = Me.DutyLimit
                            dr("CommRate") = Me.CommRate
                            dr("TAddress") = Me.TAddress
                            dr("TDistrict") = Me.TDistrict
                            dr("TSubProvince") = Me.TSubProvince
                            dr("TProvince") = Me.TProvince
                            dr("TPostCode") = Me.TPostCode
                            dr("DMailAddress") = Me.DMailAddress
                            dr("PrivilegeOption") = Me.PrivilegeOption
                            dr("GoldCardNO") = Me.GoldCardNO
                            dr("CustomsBrokerSeq") = Me.CustomsBrokerSeq
                            dr("ISCustomerSign") = Me.ISCustomerSign
                            dr("ISCustomerSignInv") = Me.ISCustomerSignInv
                            dr("ISCustomerSignDec") = Me.ISCustomerSignDec
                            dr("ISCustomerSignECon") = Me.ISCustomerSignECon
                            dr("IsShippingCannotSign") = Me.IsShippingCannotSign
                            dr("ExportCode") = Me.ExportCode
                            dr("Code19BIS") = Me.Code19BIS
                            dr("WEB_SITE") = Me.WEB_SITE
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCompany", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCompany", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_CustCode = ""
        m_Branch = ""
        m_CustGroup = ""
        m_TaxNumber = ""
        m_Title = ""
        m_NameThai = ""
        m_NameEng = ""
        m_TAddress1 = ""
        m_TAddress2 = ""
        m_EAddress1 = ""
        m_EAddress2 = ""
        m_Phone = ""
        m_FaxNumber = ""
        m_LoginName = ""
        m_LoginPassword = ""
        m_ManagerCode = ""
        m_CSCodeIM = ""
        m_CSCodeEX = ""
        m_CSCodeOT = ""
        m_GLAccountCode = ""
        m_CustType = 0
        m_BillToCustCode = ""
        m_BillToBranch = ""
        m_UsedLanguage = ""
        m_LevelGrade = ""
        m_TermOfPayment = 0
        m_BillCondition = ""
        m_CreditLimit = 0
        m_MapText = ""
        m_MapFileName = ""
        m_CmpType = ""
        m_CmpLevelExp = ""
        m_CmpLevelImp = ""
        m_Is19bis = 0
        m_MgrSeq = 0
        m_LevelNoExp = 0
        m_LevelNoImp = 0
        m_LnNO = ""
        m_AdjTaxCode = ""
        m_BkAuthorNo = ""
        m_BkAuthorCnn = ""
        m_LtdPsWkName = ""
        m_ConsStatus = ""
        m_CommLevel = ""
        m_DutyLimit = 0
        m_CommRate = 0
        m_TAddress = ""
        m_TDistrict = ""
        m_TSubProvince = ""
        m_TProvince = ""
        m_TPostCode = ""
        m_DMailAddress = ""
        m_PrivilegeOption = ""
        m_GoldCardNO = 0
        m_CustomsBrokerSeq = 0
        m_ISCustomerSign = 0
        m_ISCustomerSignInv = 0
        m_ISCustomerSignDec = 0
        m_ISCustomerSignECon = 0
        m_IsShippingCannotSign = 0
        m_ExportCode = ""
        m_Code19BIS = ""
        m_WEB_SITE = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CCompany)
        Dim lst As New List(Of CCompany)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CCompany
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_Company" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CCompany(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustCode"))) = False Then
                        row.CustCode = rd.GetString(rd.GetOrdinal("CustCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Branch"))) = False Then
                        row.Branch = rd.GetString(rd.GetOrdinal("Branch")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustGroup"))) = False Then
                        row.CustGroup = rd.GetString(rd.GetOrdinal("CustGroup")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TaxNumber"))) = False Then
                        row.TaxNumber = rd.GetString(rd.GetOrdinal("TaxNumber")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Title"))) = False Then
                        row.Title = rd.GetString(rd.GetOrdinal("Title")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("NameThai"))) = False Then
                        row.NameThai = rd.GetString(rd.GetOrdinal("NameThai")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("NameEng"))) = False Then
                        row.NameEng = rd.GetString(rd.GetOrdinal("NameEng")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TAddress1"))) = False Then
                        row.TAddress1 = rd.GetString(rd.GetOrdinal("TAddress1")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TAddress2"))) = False Then
                        row.TAddress2 = rd.GetString(rd.GetOrdinal("TAddress2")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EAddress1"))) = False Then
                        row.EAddress1 = rd.GetString(rd.GetOrdinal("EAddress1")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EAddress2"))) = False Then
                        row.EAddress2 = rd.GetString(rd.GetOrdinal("EAddress2")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Phone"))) = False Then
                        row.Phone = rd.GetString(rd.GetOrdinal("Phone")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FaxNumber"))) = False Then
                        row.FaxNumber = rd.GetString(rd.GetOrdinal("FaxNumber")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LoginName"))) = False Then
                        row.LoginName = rd.GetString(rd.GetOrdinal("LoginName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LoginPassword"))) = False Then
                        row.LoginPassword = rd.GetString(rd.GetOrdinal("LoginPassword")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ManagerCode"))) = False Then
                        row.ManagerCode = rd.GetString(rd.GetOrdinal("ManagerCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CSCodeIM"))) = False Then
                        row.CSCodeIM = rd.GetString(rd.GetOrdinal("CSCodeIM")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CSCodeEX"))) = False Then
                        row.CSCodeEX = rd.GetString(rd.GetOrdinal("CSCodeEX")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CSCodeOT"))) = False Then
                        row.CSCodeOT = rd.GetString(rd.GetOrdinal("CSCodeOT")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GLAccountCode"))) = False Then
                        row.GLAccountCode = rd.GetString(rd.GetOrdinal("GLAccountCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustType"))) = False Then
                        row.CustType = rd.GetByte(rd.GetOrdinal("CustType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillToCustCode"))) = False Then
                        row.BillToCustCode = rd.GetString(rd.GetOrdinal("BillToCustCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillToBranch"))) = False Then
                        row.BillToBranch = rd.GetString(rd.GetOrdinal("BillToBranch")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UsedLanguage"))) = False Then
                        row.UsedLanguage = rd.GetString(rd.GetOrdinal("UsedLanguage")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LevelGrade"))) = False Then
                        row.LevelGrade = rd.GetString(rd.GetOrdinal("LevelGrade")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TermOfPayment"))) = False Then
                        row.TermOfPayment = rd.GetByte(rd.GetOrdinal("TermOfPayment"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillCondition"))) = False Then
                        row.BillCondition = rd.GetString(rd.GetOrdinal("BillCondition")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CreditLimit"))) = False Then
                        row.CreditLimit = rd.GetDouble(rd.GetOrdinal("CreditLimit"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("MapText"))) = False Then
                        row.MapText = rd.GetString(rd.GetOrdinal("MapText")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("MapFileName"))) = False Then
                        row.MapFileName = rd.GetString(rd.GetOrdinal("MapFileName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CmpType"))) = False Then
                        row.CmpType = rd.GetString(rd.GetOrdinal("CmpType")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CmpLevelExp"))) = False Then
                        row.CmpLevelExp = rd.GetString(rd.GetOrdinal("CmpLevelExp")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CmpLevelImp"))) = False Then
                        row.CmpLevelImp = rd.GetString(rd.GetOrdinal("CmpLevelImp")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Is19bis"))) = False Then
                        row.Is19bis = rd.GetByte(rd.GetOrdinal("Is19bis"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("MgrSeq"))) = False Then
                        row.MgrSeq = rd.GetInt16(rd.GetOrdinal("MgrSeq"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LevelNoExp"))) = False Then
                        row.LevelNoExp = rd.GetInt32(rd.GetOrdinal("LevelNoExp"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LevelNoImp"))) = False Then
                        row.LevelNoImp = rd.GetInt32(rd.GetOrdinal("LevelNoImp"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LnNO"))) = False Then
                        row.LnNO = rd.GetString(rd.GetOrdinal("LnNO")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdjTaxCode"))) = False Then
                        row.AdjTaxCode = rd.GetString(rd.GetOrdinal("AdjTaxCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BkAuthorNo"))) = False Then
                        row.BkAuthorNo = rd.GetString(rd.GetOrdinal("BkAuthorNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BkAuthorCnn"))) = False Then
                        row.BkAuthorCnn = rd.GetString(rd.GetOrdinal("BkAuthorCnn")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LtdPsWkName"))) = False Then
                        row.LtdPsWkName = rd.GetString(rd.GetOrdinal("LtdPsWkName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ConsStatus"))) = False Then
                        row.ConsStatus = rd.GetString(rd.GetOrdinal("ConsStatus")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CommLevel"))) = False Then
                        row.CommLevel = rd.GetString(rd.GetOrdinal("CommLevel")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DutyLimit"))) = False Then
                        row.DutyLimit = rd.GetDouble(rd.GetOrdinal("DutyLimit"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CommRate"))) = False Then
                        row.CommRate = rd.GetDouble(rd.GetOrdinal("CommRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TAddress"))) = False Then
                        row.TAddress = rd.GetString(rd.GetOrdinal("TAddress")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TDistrict"))) = False Then
                        row.TDistrict = rd.GetString(rd.GetOrdinal("TDistrict")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TSubProvince"))) = False Then
                        row.TSubProvince = rd.GetString(rd.GetOrdinal("TSubProvince")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TProvince"))) = False Then
                        row.TProvince = rd.GetString(rd.GetOrdinal("TProvince")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TPostCode"))) = False Then
                        row.TPostCode = rd.GetString(rd.GetOrdinal("TPostCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DMailAddress"))) = False Then
                        row.DMailAddress = rd.GetString(rd.GetOrdinal("DMailAddress")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PrivilegeOption"))) = False Then
                        row.PrivilegeOption = rd.GetString(rd.GetOrdinal("PrivilegeOption")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GoldCardNO"))) = False Then
                        row.GoldCardNO = rd.GetInt16(rd.GetOrdinal("GoldCardNO"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustomsBrokerSeq"))) = False Then
                        row.CustomsBrokerSeq = rd.GetInt16(rd.GetOrdinal("CustomsBrokerSeq"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ISCustomerSign"))) = False Then
                        row.ISCustomerSign = rd.GetByte(rd.GetOrdinal("ISCustomerSign"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ISCustomerSignInv"))) = False Then
                        row.ISCustomerSignInv = rd.GetByte(rd.GetOrdinal("ISCustomerSignInv"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ISCustomerSignDec"))) = False Then
                        row.ISCustomerSignDec = rd.GetByte(rd.GetOrdinal("ISCustomerSignDec"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ISCustomerSignECon"))) = False Then
                        row.ISCustomerSignECon = rd.GetByte(rd.GetOrdinal("ISCustomerSignECon"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsShippingCannotSign"))) = False Then
                        row.IsShippingCannotSign = rd.GetByte(rd.GetOrdinal("IsShippingCannotSign"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ExportCode"))) = False Then
                        row.ExportCode = rd.GetString(rd.GetOrdinal("ExportCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Code19BIS"))) = False Then
                        row.Code19BIS = rd.GetString(rd.GetOrdinal("Code19BIS")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("WEB_SITE"))) = False Then
                        row.WEB_SITE = rd.GetString(rd.GetOrdinal("WEB_SITE")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Mas_Company" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CCompany", "DeleteData", cm.CommandText)
                End Using
                msg = "Delete Complete"
            Catch ex As Exception
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class