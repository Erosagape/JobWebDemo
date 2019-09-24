Imports System.Data.SqlClient
Public Class CServiceCode
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub AddNew(pformatSQL As String)
        If pformatSQL = "" Then
            m_SICode = ""
            Exit Sub
        End If
        Dim retStr As String = Main.GetMaxByMask(m_ConnStr, "SELECT MAX(SICode) as t FROM Job_SrvSingle WHERE SICode Like '%" + pformatSQL + "'", pformatSQL)
        m_SICode = retStr
    End Sub
    Private m_SICode As String
    Public Property SICode As String
        Get
            Return m_SICode
        End Get
        Set(value As String)
            m_SICode = value
        End Set
    End Property
    Private m_GroupCode As String
    Public Property GroupCode As String
        Get
            Return m_GroupCode
        End Get
        Set(value As String)
            m_GroupCode = value
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
    Private m_StdPrice As Double
    Public Property StdPrice As Double
        Get
            Return m_StdPrice
        End Get
        Set(value As Double)
            m_StdPrice = value
        End Set
    End Property
    Private m_UnitCharge As String
    Public Property UnitCharge As String
        Get
            Return m_UnitCharge
        End Get
        Set(value As String)
            m_UnitCharge = value
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
    Private m_DefaultVender As String
    Public Property DefaultVender As String
        Get
            Return m_DefaultVender
        End Get
        Set(value As String)
            m_DefaultVender = value
        End Set
    End Property
    Private m_ProcessDesc As String
    Public Property ProcessDesc As String
        Get
            Return m_ProcessDesc
        End Get
        Set(value As String)
            m_ProcessDesc = value
        End Set
    End Property
    Private m_GLAccountCodeSales As String
    Public Property GLAccountCodeSales As String
        Get
            Return m_GLAccountCodeSales
        End Get
        Set(value As String)
            m_GLAccountCodeSales = value
        End Set
    End Property
    Private m_GLAccountCodeCost As String
    Public Property GLAccountCodeCost As String
        Get
            Return m_GLAccountCodeCost
        End Get
        Set(value As String)
            m_GLAccountCodeCost = value
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
    Private m_IsCredit As Integer
    Public Property IsCredit As Integer
        Get
            Return m_IsCredit
        End Get
        Set(value As Integer)
            m_IsCredit = value
        End Set
    End Property
    Private m_IsExpense As Integer
    Public Property IsExpense As Integer
        Get
            Return m_IsExpense
        End Get
        Set(value As Integer)
            m_IsExpense = value
        End Set
    End Property
    Private m_IsShowPrice As Integer
    Public Property IsShowPrice As Integer
        Get
            Return m_IsShowPrice
        End Get
        Set(value As Integer)
            m_IsShowPrice = value
        End Set
    End Property
    Private m_IsHaveSlip As Integer
    Public Property IsHaveSlip As Integer
        Get
            Return m_IsHaveSlip
        End Get
        Set(value As Integer)
            m_IsHaveSlip = value
        End Set
    End Property
    Private m_IsPay50TaviTo As Integer
    Public Property IsPay50TaviTo As Integer
        Get
            Return m_IsPay50TaviTo
        End Get
        Set(value As Integer)
            m_IsPay50TaviTo = value
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
    Private m_IsUsedCoSlip As Integer
    Public Property IsUsedCoSlip As Integer
        Get
            Return m_IsUsedCoSlip
        End Get
        Set(value As Integer)
            m_IsUsedCoSlip = value
        End Set
    End Property
    Public Function DeleteData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()
                Using cm As New SqlCommand("DELETE FROM Job_SrvSingle " + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CServiceCode", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CServiceCode", "DeleteData", ex.Message)
                msg = "[exception] " + ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_SrvSingle" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("SICode") = Me.SICode
                            dr("GroupCode") = Me.GroupCode
                            dr("NameThai") = Me.NameThai
                            dr("NameEng") = Me.NameEng
                            dr("StdPrice") = Me.StdPrice
                            dr("UnitCharge") = Me.UnitCharge
                            dr("CurrencyCode") = Me.CurrencyCode
                            dr("DefaultVender") = Me.DefaultVender
                            dr("ProcessDesc") = Me.ProcessDesc
                            dr("GLAccountCodeSales") = Me.GLAccountCodeSales
                            dr("GLAccountCodeCost") = Me.GLAccountCodeCost
                            dr("IsTaxCharge") = Me.IsTaxCharge
                            dr("Is50Tavi") = Me.Is50Tavi
                            dr("Rate50Tavi") = Me.Rate50Tavi
                            dr("IsCredit") = Me.IsCredit
                            dr("IsExpense") = Me.IsExpense
                            dr("IsShowPrice") = Me.IsShowPrice
                            dr("IsHaveSlip") = Me.IsHaveSlip
                            dr("IsPay50TaviTo") = Me.IsPay50TaviTo
                            dr("IsLtdAdv50Tavi") = Me.IsLtdAdv50Tavi
                            dr("IsUsedCoSlip") = Me.IsUsedCoSlip
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            If da.Update(dt) > 0 Then
                                Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CServiceCode", "SaveData", Me)
                                msg = "Save " & Me.SICode & " Complete"
                            Else
                                msg = "Save Failed"
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CServiceCode", "SaveData", ex.Message)
                msg = "[exception] " + ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Function GetData(pSQLWhere As String) As List(Of CServiceCode)
        Dim lst As New List(Of CServiceCode)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CServiceCode
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_SrvSingle" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CServiceCode(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SICode"))) = False Then
                        row.SICode = rd.GetString(rd.GetOrdinal("SICode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GroupCode"))) = False Then
                        row.GroupCode = rd.GetString(rd.GetOrdinal("GroupCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("NameThai"))) = False Then
                        row.NameThai = rd.GetString(rd.GetOrdinal("NameThai")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("NameEng"))) = False Then
                        row.NameEng = rd.GetString(rd.GetOrdinal("NameEng")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("StdPrice"))) = False Then
                        row.StdPrice = rd.GetDouble(rd.GetOrdinal("StdPrice"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UnitCharge"))) = False Then
                        row.UnitCharge = rd.GetString(rd.GetOrdinal("UnitCharge")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CurrencyCode"))) = False Then
                        row.CurrencyCode = rd.GetString(rd.GetOrdinal("CurrencyCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DefaultVender"))) = False Then
                        row.DefaultVender = rd.GetString(rd.GetOrdinal("DefaultVender")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ProcessDesc"))) = False Then
                        row.ProcessDesc = rd.GetString(rd.GetOrdinal("ProcessDesc")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GLAccountCodeSales"))) = False Then
                        row.GLAccountCodeSales = rd.GetString(rd.GetOrdinal("GLAccountCodeSales")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GLAccountCodeCost"))) = False Then
                        row.GLAccountCodeCost = rd.GetString(rd.GetOrdinal("GLAccountCodeCost")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsTaxCharge"))) = False Then
                        row.IsTaxCharge = rd.GetByte(rd.GetOrdinal("IsTaxCharge"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Is50Tavi"))) = False Then
                        row.Is50Tavi = rd.GetByte(rd.GetOrdinal("Is50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Rate50Tavi"))) = False Then
                        row.Rate50Tavi = rd.GetDouble(rd.GetOrdinal("Rate50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsCredit"))) = False Then
                        row.IsCredit = rd.GetByte(rd.GetOrdinal("IsCredit"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsExpense"))) = False Then
                        row.IsExpense = rd.GetByte(rd.GetOrdinal("IsExpense"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsShowPrice"))) = False Then
                        row.IsShowPrice = rd.GetByte(rd.GetOrdinal("IsShowPrice"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsHaveSlip"))) = False Then
                        row.IsHaveSlip = rd.GetByte(rd.GetOrdinal("IsHaveSlip"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsPay50TaviTo"))) = False Then
                        row.IsPay50TaviTo = rd.GetByte(rd.GetOrdinal("IsPay50TaviTo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsLtdAdv50Tavi"))) = False Then
                        row.IsLtdAdv50Tavi = rd.GetByte(rd.GetOrdinal("IsLtdAdv50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsUsedCoSlip"))) = False Then
                        row.IsUsedCoSlip = rd.GetInt32(rd.GetOrdinal("IsUsedCoSlip"))
                    End If
                    lst.Add(row)
                End While
            Catch ex As Exception
            End Try
        End Using
        Return lst
    End Function
End Class