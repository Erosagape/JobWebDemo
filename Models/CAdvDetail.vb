Imports System.Data
Imports System.Data.SqlClient
Public Class CAdvDetail
    Private m_ConnStr As String
    Public Sub New(pConnStr As String)
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
    Private m_AdvNo As String
    Public Property AdvNo As String
        Get
            Return m_AdvNo
        End Get
        Set(value As String)
            m_AdvNo = value
        End Set
    End Property
    Private m_ForJNo As String
    Public Property ForJNo As String
        Get
            Return m_ForJNo
        End Get
        Set(value As String)
            m_ForJNo = value
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
    Private m_AdvAmount As Double
    Public Property AdvAmount As Double
        Get
            Return m_AdvAmount
        End Get
        Set(value As Double)
            m_AdvAmount = value
        End Set
    End Property
    Private m_IsChargeVAT As Integer
    Public Property IsChargeVAT As Integer
        Get
            Return m_IsChargeVAT
        End Get
        Set(value As Integer)
            m_IsChargeVAT = value
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
    Private m_Rate50Tavi As Double
    Public Property Rate50Tavi As Double
        Get
            Return m_Rate50Tavi
        End Get
        Set(value As Double)
            m_Rate50Tavi = value
        End Set
    End Property
    Private m_Charge50Tavi As Double
    Public Property Charge50Tavi As Double
        Get
            Return m_Charge50Tavi
        End Get
        Set(value As Double)
            m_Charge50Tavi = value
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
    Private m_IsDuplicate As Integer
    Public Property IsDuplicate As Integer
        Get
            Return m_IsDuplicate
        End Get
        Set(value As Integer)
            m_IsDuplicate = value
        End Set
    End Property
    Private m_PayChqTo As String
    Public Property PayChqTo As String
        Get
            Return m_PayChqTo
        End Get
        Set(value As String)
            m_PayChqTo = value
        End Set
    End Property
    Private m_Doc50Tavi As String
    Public Property Doc50Tavi As String
        Get
            Return m_Doc50Tavi
        End Get
        Set(value As String)
            m_Doc50Tavi = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As Boolean
        Dim bComplete As Boolean = False
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_AdvDetail" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("AdvNo") = Me.AdvNo
                            dr("ItemNo") = Me.ItemNo
                            dr("ForJNo") = Me.ForJNo
                            dr("STCode") = Me.STCode
                            dr("SICode") = Me.SICode
                            dr("AdvAmount") = Me.AdvAmount
                            dr("IsChargeVAT") = Me.IsChargeVAT
                            dr("ChargeVAT") = Me.ChargeVAT
                            dr("Rate50Tavi") = Me.Rate50Tavi
                            dr("Charge50Tavi") = Me.Charge50Tavi
                            dr("TRemark") = Me.TRemark
                            dr("IsDuplicate") = Me.IsDuplicate
                            dr("PayChqTo") = Me.PayChqTo
                            dr("Doc50Tavi") = Me.Doc50Tavi
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            bComplete = True
                        End Using
                    End Using
                End Using
            Catch ex As Exception
            End Try
        End Using
        Return bComplete
    End Function
    Public Function GetData(pSQLWhere As String) As List(Of CAdvDetail)
        Dim lst As New List(Of CAdvDetail)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CAdvDetail
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_AdvDetail" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CAdvDetail(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvNo"))) = False Then
                        row.AdvNo = rd.GetString(rd.GetOrdinal("AdvNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ForJNo"))) = False Then
                        row.ForJNo = rd.GetString(rd.GetOrdinal("ForJNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ItemNo"))) = False Then
                        row.ItemNo = rd.GetByte(rd.GetOrdinal("ItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("STCode"))) = False Then
                        row.STCode = rd.GetString(rd.GetOrdinal("STCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SICode"))) = False Then
                        row.SICode = rd.GetString(rd.GetOrdinal("SICode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvAmount"))) = False Then
                        row.AdvAmount = rd.GetDouble(rd.GetOrdinal("AdvAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsChargeVAT"))) = False Then
                        row.IsChargeVAT = rd.GetByte(rd.GetOrdinal("IsChargeVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ChargeVAT"))) = False Then
                        row.ChargeVAT = rd.GetDouble(rd.GetOrdinal("ChargeVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Rate50Tavi"))) = False Then
                        row.Rate50Tavi = rd.GetDouble(rd.GetOrdinal("Rate50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Charge50Tavi"))) = False Then
                        row.Charge50Tavi = rd.GetDouble(rd.GetOrdinal("Charge50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TRemark"))) = False Then
                        row.TRemark = rd.GetString(rd.GetOrdinal("TRemark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsDuplicate"))) = False Then
                        row.IsDuplicate = rd.GetByte(rd.GetOrdinal("IsDuplicate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PayChqTo"))) = False Then
                        row.PayChqTo = rd.GetString(rd.GetOrdinal("PayChqTo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Doc50Tavi"))) = False Then
                        row.Doc50Tavi = rd.GetString(rd.GetOrdinal("Doc50Tavi")).ToString()
                    End If
                    lst.Add(row)
                End While
            Catch ex As Exception
            End Try
        End Using
        Return lst
    End Function
End Class