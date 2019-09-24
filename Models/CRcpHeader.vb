'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CRcpHeader
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
    Private m_ReceiptNo As String
    Public Property ReceiptNo As String
        Get
            Return m_ReceiptNo
        End Get
        Set(value As String)
            m_ReceiptNo = value
        End Set
    End Property
    Private m_ReceiptDate As Date
    Public Property ReceiptDate As Date
        Get
            Return m_ReceiptDate
        End Get
        Set(value As Date)
            m_ReceiptDate = value
        End Set
    End Property
    Private m_ReceiptType As String
    Public Property ReceiptType As String
        Get
            Return m_ReceiptType
        End Get
        Set(value As String)
            m_ReceiptType = value
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
    Private m_BillToCustCode As String
    Public Property BillToCustCode As String
        Get
            Return m_BillToCustCode
        End Get
        Set(value As String)
            m_BillToCustCode = value
        End Set
    End Property
    Private m_BillToCustBranch As String
    Public Property BillToCustBranch As String
        Get
            Return m_BillToCustBranch
        End Get
        Set(value As String)
            m_BillToCustBranch = value
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
    Private m_EmpCode As String
    Public Property EmpCode As String
        Get
            Return m_EmpCode
        End Get
        Set(value As String)
            m_EmpCode = value
        End Set
    End Property
    Private m_PrintedBy As String
    Public Property PrintedBy As String
        Get
            Return m_PrintedBy
        End Get
        Set(value As String)
            m_PrintedBy = value
        End Set
    End Property
    Private m_PrintedDate As Date
    Public Property PrintedDate As Date
        Get
            Return m_PrintedDate
        End Get
        Set(value As Date)
            m_PrintedDate = value
        End Set
    End Property
    Private m_PrintedTime As Date
    Public Property PrintedTime As Date
        Get
            Return m_PrintedTime
        End Get
        Set(value As Date)
            m_PrintedTime = value
        End Set
    End Property
    Private m_ReceiveBy As String
    Public Property ReceiveBy As String
        Get
            Return m_ReceiveBy
        End Get
        Set(value As String)
            m_ReceiveBy = value
        End Set
    End Property
    Private m_ReceiveDate As Date
    Public Property ReceiveDate As Date
        Get
            Return m_ReceiveDate
        End Get
        Set(value As Date)
            m_ReceiveDate = value
        End Set
    End Property
    Private m_ReceiveTime As Date
    Public Property ReceiveTime As Date
        Get
            Return m_ReceiveTime
        End Get
        Set(value As Date)
            m_ReceiveTime = value
        End Set
    End Property
    Private m_ReceiveRef As String
    Public Property ReceiveRef As String
        Get
            Return m_ReceiveRef
        End Get
        Set(value As String)
            m_ReceiveRef = value
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
    Private m_TotalCharge As Double
    Public Property TotalCharge As Double
        Get
            Return m_TotalCharge
        End Get
        Set(value As Double)
            m_TotalCharge = value
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
    Private m_Total50Tavi As Double
    Public Property Total50Tavi As Double
        Get
            Return m_Total50Tavi
        End Get
        Set(value As Double)
            m_Total50Tavi = value
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
    Private m_FTotalNet As Double
    Public Property FTotalNet As Double
        Get
            Return m_FTotalNet
        End Get
        Set(value As Double)
            m_FTotalNet = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_ReceiptHeader" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("ReceiptNo") = Me.ReceiptNo
                            dr("ReceiptDate") = Main.GetDBDate(Me.ReceiptDate)
                            dr("ReceiptType") = Me.ReceiptType
                            dr("CustCode") = Me.CustCode
                            dr("CustBranch") = Me.CustBranch
                            dr("BillToCustCode") = Me.BillToCustCode
                            dr("BillToCustBranch") = Me.BillToCustBranch
                            dr("TRemark") = Me.TRemark
                            dr("EmpCode") = Me.EmpCode
                            dr("PrintedBy") = Me.PrintedBy
                            dr("PrintedDate") = Main.GetDBDate(Me.PrintedDate)
                            dr("PrintedTime") = Main.GetDBTime(Me.PrintedTime)
                            dr("ReceiveBy") = Me.ReceiveBy
                            dr("ReceiveDate") = Main.GetDBDate(Me.ReceiveDate)
                            dr("ReceiveTime") = Main.GetDBTime(Me.ReceiveTime)
                            dr("ReceiveRef") = Me.ReceiveRef
                            dr("CancelReson") = Me.CancelReson
                            dr("CancelProve") = Me.CancelProve
                            dr("CancelDate") = Main.GetDBDate(Me.CancelDate)
                            dr("CancelTime") = Main.GetDBTime(Me.CancelTime)
                            dr("CurrencyCode") = Me.CurrencyCode
                            dr("ExchangeRate") = Me.ExchangeRate
                            dr("TotalCharge") = Me.TotalCharge
                            dr("TotalVAT") = Me.TotalVAT
                            dr("Total50Tavi") = Me.Total50Tavi
                            dr("TotalNet") = Me.TotalNet
                            dr("FTotalNet") = Me.FTotalNet
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CRcpHeader", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CRcpHeader", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew(pFormatSQL As String)
        If pFormatSQL = "" Then
            m_ReceiptNo = ""
        Else
            Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(ReceiptNo) as t FROM Job_ReceiptHeader WHERE BranchCode='{0}' And ReceiptNo Like '%{1}' ", m_BranchCode, pFormatSQL), pFormatSQL)
            m_ReceiptNo = retStr
        End If
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CRcpHeader)
        Dim lst As New List(Of CRcpHeader)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CRcpHeader
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_ReceiptHeader" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CRcpHeader(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReceiptNo"))) = False Then
                        row.ReceiptNo = rd.GetString(rd.GetOrdinal("ReceiptNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReceiptDate"))) = False Then
                        row.ReceiptDate = rd.GetValue(rd.GetOrdinal("ReceiptDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReceiptType"))) = False Then
                        row.ReceiptType = rd.GetString(rd.GetOrdinal("ReceiptType")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustCode"))) = False Then
                        row.CustCode = rd.GetString(rd.GetOrdinal("CustCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustBranch"))) = False Then
                        row.CustBranch = rd.GetString(rd.GetOrdinal("CustBranch")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillToCustCode"))) = False Then
                        row.BillToCustCode = rd.GetString(rd.GetOrdinal("BillToCustCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BillToCustBranch"))) = False Then
                        row.BillToCustBranch = rd.GetString(rd.GetOrdinal("BillToCustBranch")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TRemark"))) = False Then
                        row.TRemark = rd.GetString(rd.GetOrdinal("TRemark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EmpCode"))) = False Then
                        row.EmpCode = rd.GetString(rd.GetOrdinal("EmpCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PrintedBy"))) = False Then
                        row.PrintedBy = rd.GetString(rd.GetOrdinal("PrintedBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PrintedDate"))) = False Then
                        row.PrintedDate = rd.GetValue(rd.GetOrdinal("PrintedDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PrintedTime"))) = False Then
                        row.PrintedTime = rd.GetValue(rd.GetOrdinal("PrintedTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReceiveBy"))) = False Then
                        row.ReceiveBy = rd.GetString(rd.GetOrdinal("ReceiveBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReceiveDate"))) = False Then
                        row.ReceiveDate = rd.GetValue(rd.GetOrdinal("ReceiveDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReceiveTime"))) = False Then
                        row.ReceiveTime = rd.GetValue(rd.GetOrdinal("ReceiveTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReceiveRef"))) = False Then
                        row.ReceiveRef = rd.GetString(rd.GetOrdinal("ReceiveRef")).ToString()
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
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CurrencyCode"))) = False Then
                        row.CurrencyCode = rd.GetString(rd.GetOrdinal("CurrencyCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ExchangeRate"))) = False Then
                        row.ExchangeRate = rd.GetDouble(rd.GetOrdinal("ExchangeRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalCharge"))) = False Then
                        row.TotalCharge = rd.GetDouble(rd.GetOrdinal("TotalCharge"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalVAT"))) = False Then
                        row.TotalVAT = rd.GetDouble(rd.GetOrdinal("TotalVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Total50Tavi"))) = False Then
                        row.Total50Tavi = rd.GetDouble(rd.GetOrdinal("Total50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalNet"))) = False Then
                        row.TotalNet = rd.GetDouble(rd.GetOrdinal("TotalNet"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FTotalNet"))) = False Then
                        row.FTotalNet = rd.GetDouble(rd.GetOrdinal("FTotalNet"))
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

                Using cm As New SqlCommand("DELETE FROM Job_ReceiptHeader" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CRcpHeader", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CRcpHeader", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
