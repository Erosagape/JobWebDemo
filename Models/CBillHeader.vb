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
    Private m_TotalCustAdv As Double
    Public Property TotalCustAdv As Double
        Get
            Return m_TotalCustAdv
        End Get
        Set(value As Double)
            m_TotalCustAdv = value
        End Set
    End Property
    Private m_TotalAdvance As Double
    Public Property TotalAdvance As Double
        Get
            Return m_TotalAdvance
        End Get
        Set(value As Double)
            m_TotalAdvance = value
        End Set
    End Property
    Private m_TotalChargeVAT As Double
    Public Property TotalChargeVAT As Double
        Get
            Return m_TotalChargeVAT
        End Get
        Set(value As Double)
            m_TotalChargeVAT = value
        End Set
    End Property
    Private m_TotalChargeNonVAT As Double
    Public Property TotalChargeNonVAT As Double
        Get
            Return m_TotalChargeNonVAT
        End Get
        Set(value As Double)
            m_TotalChargeNonVAT = value
        End Set
    End Property
    Private m_TotalVAT As Double
    Public Property TotalVAT As Double
        Get
            Return m_TotalVAT
        End Get
        Set(value As Double)
            m_TotalVAT = value
        End Set
    End Property
    Private m_TotalWH As Double
    Public Property TotalWH As Double
        Get
            Return m_TotalWH
        End Get
        Set(value As Double)
            m_TotalWH = value
        End Set
    End Property
    Private m_TotalDiscount As Double
    Public Property TotalDiscount As Double
        Get
            Return m_TotalDiscount
        End Get
        Set(value As Double)
            m_TotalDiscount = value
        End Set
    End Property
    Private m_TotalNet As Double
    Public Property TotalNet As Double
        Get
            Return m_TotalNet
        End Get
        Set(value As Double)
            m_TotalNet = value
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
                            dr("TotalCustAdv") = Me.TotalCustAdv
                            dr("TotalAdvance") = Me.TotalAdvance
                            dr("TotalChargeVAT") = Me.TotalChargeVAT
                            dr("TotalChargeNonVAT") = Me.TotalChargeNonVAT
                            dr("TotalVAT") = Me.TotalVAT
                            dr("TotalWH") = Me.TotalWH
                            dr("TotalDiscount") = Me.TotalDiscount
                            dr("TotalNet") = Me.TotalNet

                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBillHeader", "SaveData", Me)
                            If Me.CancelProve <> "" Then
                                Dim o As New CBillDetail(jobWebConn)
                                o.BranchCode = Me.BranchCode
                                o.BillAcceptNo = Me.BillAcceptNo
                                o.CancelDocument(cn)
                            Else
                                Me.UpdateData()
                            End If
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBillHeader", "SaveData", ex.Message)
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
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalCustAdv"))) = False Then
                        row.TotalCustAdv = rd.GetDouble(rd.GetOrdinal("TotalCustAdv"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalAdvance"))) = False Then
                        row.TotalAdvance = rd.GetDouble(rd.GetOrdinal("TotalAdvance"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalVAT"))) = False Then
                        row.TotalVAT = rd.GetDouble(rd.GetOrdinal("TotalVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalWH"))) = False Then
                        row.TotalWH = rd.GetDouble(rd.GetOrdinal("TotalWH"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalChargeVAT"))) = False Then
                        row.TotalChargeVAT = rd.GetDouble(rd.GetOrdinal("TotalChargeVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalChargeNonVAT"))) = False Then
                        row.TotalChargeNonVAT = rd.GetDouble(rd.GetOrdinal("TotalChargeNonVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalDiscount"))) = False Then
                        row.TotalDiscount = rd.GetDouble(rd.GetOrdinal("TotalDiscount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalNet"))) = False Then
                        row.TotalNet = rd.GetDouble(rd.GetOrdinal("TotalNet"))
                    End If
                    lst.Add(row)
                End While
            Catch ex As Exception
            End Try
        End Using
        Return lst
    End Function
    Public Sub UpdateData()
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()
                Using cm As New SqlCommand()
                    cm.Connection = cn
                    cm.CommandType = CommandType.Text
                    If Me.BillAcceptNo <> "" Then
                        cm.CommandText = SQLUpdateBillToInv(Me.BranchCode, Me.BillAcceptNo, False)
                        cm.ExecuteNonQuery()
                        Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBillHeader", "UpdateBillToInv", cm.CommandText)
                    End If
                End Using
                msg = "Update Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBillHeader", "UpdateBillToInv", ex.Message)
                msg = ex.Message
            End Try
        End Using
    End Sub
    Public Function DeleteData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using cm As New SqlCommand("DELETE FROM Job_BillAcceptHeader" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBillHeader", "DeleteData", cm.CommandText)
                    If Me.BillAcceptNo <> "" Then
                        cm.CommandText = SQLUpdateBillToInv(Me.BranchCode, Me.BillAcceptNo, True)
                        cm.ExecuteNonQuery()
                        Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBillHeader", "UpdateBillToInv", cm.CommandText)
                    End If
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBillHeader", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
