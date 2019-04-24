'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CBillDetail
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
    Private m_BillAcceptNo As String
    Public Property BillAcceptNo As String
        Get
            Return m_BillAcceptNo
        End Get
        Set(value As String)
            m_BillAcceptNo = value
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
    Private m_InvNo As String
    Public Property InvNo As String
        Get
            Return m_InvNo
        End Get
        Set(value As String)
            m_InvNo = value
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
    Private m_AmtChargeNonVAT As Double
    Public Property AmtChargeNonVAT As Double
        Get
            Return m_AmtChargeNonVAT
        End Get
        Set(value As Double)
            m_AmtChargeNonVAT = value
        End Set
    End Property
    Private m_AmtChargeVAT As Double
    Public Property AmtChargeVAT As Double
        Get
            Return m_AmtChargeVAT
        End Get
        Set(value As Double)
            m_AmtChargeVAT = value
        End Set
    End Property
    Private m_AmtWH As Double
    Public Property AmtWH As Double
        Get
            Return m_AmtWH
        End Get
        Set(value As Double)
            m_AmtWH = value
        End Set
    End Property
    Private m_AmtVAT As Double
    Public Property AmtVAT As Double
        Get
            Return m_AmtVAT
        End Get
        Set(value As Double)
            m_AmtVAT = value
        End Set
    End Property
    Private m_AmtTotal As Double
    Public Property AmtTotal As Double
        Get
            Return m_AmtTotal
        End Get
        Set(value As Double)
            m_AmtTotal = value
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
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_BillAcceptDetail" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("BillAcceptNo") = Me.BillAcceptNo
                            If Me.ItemNo = 0 Then Me.AddNew()
                            dr("ItemNo") = Me.ItemNo
                            dr("InvNo") = Me.InvNo
                            dr("AmtAdvance") = Me.AmtAdvance
                            dr("AmtChargeNonVAT") = Me.AmtChargeNonVAT
                            dr("AmtChargeVAT") = Me.AmtChargeVAT
                            dr("AmtWH") = Me.AmtWH
                            dr("AmtVAT") = Me.AmtVAT
                            dr("AmtTotal") = Me.AmtTotal
                            dr("CurrencyCode") = Me.CurrencyCode
                            dr("ExchangeRate") = Me.ExchangeRate
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
        Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(ItemNo) as t FROM Job_BillAcceptDetail WHERE BranchCode='{0}' And BillAcceptNo ='{1}' ", m_BranchCode, m_BillAcceptNo), "____")
        m_ItemNo = Convert.ToInt32("0" & retStr)
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CBillDetail)
        Dim lst As New List(Of CBillDetail)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CBillDetail
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_BillAcceptDetail" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CBillDetail(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillAcceptNo"))) = False Then
                        row.BillAcceptNo = rd.GetString(rd.GetOrdinal("BillAcceptNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ItemNo"))) = False Then
                        row.ItemNo = rd.GetInt16(rd.GetOrdinal("ItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvNo"))) = False Then
                        row.InvNo = rd.GetString(rd.GetOrdinal("InvNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AmtAdvance"))) = False Then
                        row.AmtAdvance = rd.GetDouble(rd.GetOrdinal("AmtAdvance"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AmtChargeNonVAT"))) = False Then
                        row.AmtChargeNonVAT = rd.GetDouble(rd.GetOrdinal("AmtChargeNonVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AmtChargeVAT"))) = False Then
                        row.AmtChargeVAT = rd.GetDouble(rd.GetOrdinal("AmtChargeVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AmtWH"))) = False Then
                        row.AmtWH = rd.GetDouble(rd.GetOrdinal("AmtWH"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AmtVAT"))) = False Then
                        row.AmtVAT = rd.GetDouble(rd.GetOrdinal("AmtVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AmtTotal"))) = False Then
                        row.AmtTotal = rd.GetDouble(rd.GetOrdinal("AmtTotal"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CurrencyCode"))) = False Then
                        row.CurrencyCode = rd.GetString(rd.GetOrdinal("CurrencyCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ExchangeRate"))) = False Then
                        row.ExchangeRate = rd.GetDouble(rd.GetOrdinal("ExchangeRate"))
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

                Using cm As New SqlCommand("DELETE FROM Job_BillAcceptDetail" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class

