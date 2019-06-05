'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CBillHeader
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
    Private m_BillDate As Date
    Public Property BillDate As Date
        Get
            Return m_BillDate
        End Get
        Set(value As Date)
            m_BillDate = value
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
    Private m_BillRecvBy As String
    Public Property BillRecvBy As String
        Get
            Return m_BillRecvBy
        End Get
        Set(value As String)
            m_BillRecvBy = value
        End Set
    End Property
    Private m_BillRecvDate As Date
    Public Property BillRecvDate As Date
        Get
            Return m_BillRecvDate
        End Get
        Set(value As Date)
            m_BillRecvDate = value
        End Set
    End Property
    Private m_DuePaymentDate As Date
    Public Property DuePaymentDate As Date
        Get
            Return m_DuePaymentDate
        End Get
        Set(value As Date)
            m_DuePaymentDate = value
        End Set
    End Property
    Private m_BillRemark As String
    Public Property BillRemark As String
        Get
            Return m_BillRemark
        End Get
        Set(value As String)
            m_BillRemark = value
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
    Private m_EmpCode As String
    Public Property EmpCode As String
        Get
            Return m_EmpCode
        End Get
        Set(value As String)
            m_EmpCode = value
        End Set
    End Property
    Private m_RecDateTime As Date
    Public Property RecDateTime As Date
        Get
            Return m_RecDateTime
        End Get
        Set(value As Date)
            m_RecDateTime = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_BillAcceptHeader" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("BillAcceptNo") = Me.BillAcceptNo
                            dr("BillDate") = Main.GetDBDate(Me.BillDate)
                            dr("CustCode") = Me.CustCode
                            dr("CustBranch") = Me.CustBranch
                            dr("BillRecvBy") = Me.BillRecvBy
                            dr("BillRecvDate") = Main.GetDBDate(Me.BillRecvDate)
                            dr("DuePaymentDate") = Main.GetDBDate(Me.DuePaymentDate)
                            dr("BillRemark") = Me.BillRemark
                            dr("CancelReson") = Me.CancelReson
                            dr("CancelProve") = Me.CancelProve
                            dr("CancelDate") = Main.GetDBDate(Me.CancelDate)
                            dr("CancelTime") = Main.GetDBTime(Me.CancelTime)
                            dr("EmpCode") = Me.EmpCode
                            dr("RecDateTime") = Main.GetDBDate(Me.RecDateTime)

                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            If Me.CancelProve <> "" Then
                                Dim o As New CBillDetail(jobWebConn)
                                o.BranchCode = Me.BranchCode
                                o.BillAcceptNo = Me.BillAcceptNo
                                o.CancelDocument(cn)
                            End If
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
    Public Sub AddNew(pFormatSQL As String)
        If pFormatSQL = "" Then
            m_BillAcceptNo = ""
        Else
            Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(BillAcceptNo) as t FROM Job_BillAcceptHeader WHERE BranchCode='{0}' And BillAcceptNo Like '%{1}' ", m_BranchCode, pFormatSQL), pFormatSQL)
            m_BillAcceptNo = retStr
        End If
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CBillHeader)
        Dim lst As New List(Of CBillHeader)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CBillHeader
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_BillAcceptHeader" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CBillHeader(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillAcceptNo"))) = False Then
                        row.BillAcceptNo = rd.GetString(rd.GetOrdinal("BillAcceptNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillDate"))) = False Then
                        row.BillDate = rd.GetValue(rd.GetOrdinal("BillDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustCode"))) = False Then
                        row.CustCode = rd.GetString(rd.GetOrdinal("CustCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustBranch"))) = False Then
                        row.CustBranch = rd.GetString(rd.GetOrdinal("CustBranch")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillRecvBy"))) = False Then
                        row.BillRecvBy = rd.GetString(rd.GetOrdinal("BillRecvBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillRecvDate"))) = False Then
                        row.BillRecvDate = rd.GetValue(rd.GetOrdinal("BillRecvDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DuePaymentDate"))) = False Then
                        row.DuePaymentDate = rd.GetValue(rd.GetOrdinal("DuePaymentDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillRemark"))) = False Then
                        row.BillRemark = rd.GetString(rd.GetOrdinal("BillRemark")).ToString()
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
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EmpCode"))) = False Then
                        row.EmpCode = rd.GetString(rd.GetOrdinal("EmpCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("RecDateTime"))) = False Then
                        row.RecDateTime = rd.GetValue(rd.GetOrdinal("RecDateTime"))
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

                Using cm As New SqlCommand("DELETE FROM Job_BillAcceptHeader" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    If Me.BillAcceptNo <> "" Then
                        cm.CommandText = SQLUpdateBillToInv(Me.BranchCode, Me.BillAcceptNo, True)
                        cm.ExecuteNonQuery()
                    End If
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
