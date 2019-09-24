'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CServiceGroup
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_GroupCode As String
    Public Property GroupCode As String
        Get
            Return m_GroupCode
        End Get
        Set(value As String)
            m_GroupCode = value
        End Set
    End Property
    Private m_GroupName As String
    Public Property GroupName As String
        Get
            Return m_GroupName
        End Get
        Set(value As String)
            m_GroupName = value
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
    Private m_IsApplyPolicy As Integer
    Public Property IsApplyPolicy As Integer
        Get
            Return m_IsApplyPolicy
        End Get
        Set(value As Integer)
            m_IsApplyPolicy = value
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
    Private m_IsHaveSlip As Integer
    Public Property IsHaveSlip As Integer
        Get
            Return m_IsHaveSlip
        End Get
        Set(value As Integer)
            m_IsHaveSlip = value
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
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_SrvGroup" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("GroupCode") = Me.GroupCode
                            dr("GroupName") = Me.GroupName
                            dr("GLAccountCode") = Me.GLAccountCode
                            dr("IsApplyPolicy") = Me.IsApplyPolicy
                            dr("IsTaxCharge") = Me.IsTaxCharge
                            dr("Is50Tavi") = Me.Is50Tavi
                            dr("Rate50Tavi") = Me.Rate50Tavi
                            dr("IsCredit") = Me.IsCredit
                            dr("IsExpense") = Me.IsExpense
                            dr("IsHaveSlip") = Me.IsHaveSlip
                            dr("IsLtdAdv50Tavi") = Me.IsLtdAdv50Tavi
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CServiceGroup", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CServiceGroup", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()
        m_GroupCode = ""
        m_GroupName = ""
        m_GLAccountCode = ""
        m_IsApplyPolicy = 0
        m_IsTaxCharge = 0
        m_Is50Tavi = 0
        m_Rate50Tavi = 0
        m_IsCredit = 0
        m_IsExpense = 0
        m_IsHaveSlip = 0
        m_IsLtdAdv50Tavi = 0
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CServiceGroup)
        Dim lst As New List(Of CServiceGroup)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CServiceGroup
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_SrvGroup" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CServiceGroup(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GroupCode"))) = False Then
                        row.GroupCode = rd.GetString(rd.GetOrdinal("GroupCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GroupName"))) = False Then
                        row.GroupName = rd.GetString(rd.GetOrdinal("GroupName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GLAccountCode"))) = False Then
                        row.GLAccountCode = rd.GetString(rd.GetOrdinal("GLAccountCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsApplyPolicy"))) = False Then
                        row.IsApplyPolicy = rd.GetInt32(rd.GetOrdinal("IsApplyPolicy"))
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
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsHaveSlip"))) = False Then
                        row.IsHaveSlip = rd.GetByte(rd.GetOrdinal("IsHaveSlip"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsLtdAdv50Tavi"))) = False Then
                        row.IsLtdAdv50Tavi = rd.GetByte(rd.GetOrdinal("IsLtdAdv50Tavi"))
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

                Using cm As New SqlCommand("DELETE FROM Job_SrvGroup" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CServiceGroup", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CServiceGroup", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
