Imports System.Data.SqlClient
Public Class CQuoHeader
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
    Private m_QNo As String
    Public Property QNo As String
        Get
            Return m_QNo
        End Get
        Set(value As String)
            m_QNo = value
        End Set
    End Property
    Private m_ReferQNo As String
    Public Property ReferQNo As String
        Get
            Return m_ReferQNo
        End Get
        Set(value As String)
            m_ReferQNo = value
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
    Private m_ContactName As String
    Public Property ContactName As String
        Get
            Return m_ContactName
        End Get
        Set(value As String)
            m_ContactName = value
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
    Private m_ManagerCode As String
    Public Property ManagerCode As String
        Get
            Return m_ManagerCode
        End Get
        Set(value As String)
            m_ManagerCode = value
        End Set
    End Property
    Private m_DescriptionH As String
    Public Property DescriptionH As String
        Get
            Return m_DescriptionH
        End Get
        Set(value As String)
            m_DescriptionH = value
        End Set
    End Property
    Private m_DescriptionF As String
    Public Property DescriptionF As String
        Get
            Return m_DescriptionF
        End Get
        Set(value As String)
            m_DescriptionF = value
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
    Private m_DocStatus As Integer
    Public Property DocStatus As Integer
        Get
            Return m_DocStatus
        End Get
        Set(value As Integer)
            m_DocStatus = value
        End Set
    End Property
    Private m_ApproveBy As String
    Public Property ApproveBy As String
        Get
            Return m_ApproveBy
        End Get
        Set(value As String)
            m_ApproveBy = value
        End Set
    End Property
    Private m_ApproveDate As Date
    Public Property ApproveDate As Date
        Get
            Return m_ApproveDate
        End Get
        Set(value As Date)
            m_ApproveDate = value
        End Set
    End Property
    Private m_ApproveTime As Date
    Public Property ApproveTime As Date
        Get
            Return m_ApproveTime
        End Get
        Set(value As Date)
            m_ApproveTime = value
        End Set
    End Property
    Private m_CancelBy As String
    Public Property CancelBy As String
        Get
            Return m_CancelBy
        End Get
        Set(value As String)
            m_CancelBy = value
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
    Private m_CancelReason As String
    Public Property CancelReason As String
        Get
            Return m_CancelReason
        End Get
        Set(value As String)
            m_CancelReason = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_QuotationHeader" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("QNo") = Me.QNo
                            dr("ReferQNo") = Me.ReferQNo
                            dr("CustCode") = Me.CustCode
                            dr("CustBranch") = Me.CustBranch
                            dr("BillToCustCode") = Me.BillToCustCode
                            dr("BillToCustBranch") = Me.BillToCustBranch
                            dr("ContactName") = Me.ContactName
                            dr("DocDate") = Main.GetDBDate(Me.DocDate)
                            dr("ManagerCode") = Me.ManagerCode
                            dr("DescriptionH") = Me.DescriptionH
                            dr("DescriptionF") = Me.DescriptionF
                            dr("TRemark") = Me.TRemark
                            dr("DocStatus") = Me.DocStatus
                            dr("ApproveBy") = Me.ApproveBy
                            dr("ApproveDate") = Main.GetDBDate(Me.ApproveDate)
                            dr("ApproveTime") = Main.GetDBTime(Me.ApproveTime)
                            dr("CancelBy") = Me.CancelBy
                            dr("CancelDate") = Main.GetDBDate(Me.CancelDate)
                            dr("CancelReason") = Me.CancelReason
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CQuoHeader", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CQuoHeader", "SaveData", ex.Message)
                msg = "[ERROR]" & ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew(pFormatSQL As String)
        If pFormatSQL = "" Then
            m_QNo = ""
        Else
            Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(QNo) as t FROM Job_QuotationHeader WHERE BranchCode='{0}' And QNo Like '%{1}' ", m_BranchCode, pFormatSQL), pFormatSQL)
            m_QNo = retStr
        End If
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CQuoHeader)
        Dim lst As New List(Of CQuoHeader)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CQuoHeader
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_QuotationHeader" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CQuoHeader(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetString(rd.GetOrdinal("QNo"))) = False Then
                        row.QNo = rd.GetString(rd.GetOrdinal("QNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReferQNo"))) = False Then
                        row.ReferQNo = rd.GetString(rd.GetOrdinal("ReferQNo")).ToString()
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
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ContactName"))) = False Then
                        row.ContactName = rd.GetString(rd.GetOrdinal("ContactName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocDate"))) = False Then
                        row.DocDate = rd.GetValue(rd.GetOrdinal("DocDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ManagerCode"))) = False Then
                        row.ManagerCode = rd.GetString(rd.GetOrdinal("ManagerCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DescriptionH"))) = False Then
                        row.DescriptionH = rd.GetString(rd.GetOrdinal("DescriptionH")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DescriptionF"))) = False Then
                        row.DescriptionF = rd.GetString(rd.GetOrdinal("DescriptionF")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TRemark"))) = False Then
                        row.TRemark = rd.GetString(rd.GetOrdinal("TRemark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocStatus"))) = False Then
                        row.DocStatus = rd.GetInt32(rd.GetOrdinal("DocStatus"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ApproveBy"))) = False Then
                        row.ApproveBy = rd.GetString(rd.GetOrdinal("ApproveBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ApproveDate"))) = False Then
                        row.ApproveDate = rd.GetValue(rd.GetOrdinal("ApproveDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ApproveTime"))) = False Then
                        row.ApproveTime = rd.GetValue(rd.GetOrdinal("ApproveTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelBy"))) = False Then
                        row.CancelBy = rd.GetString(rd.GetOrdinal("CancelBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelDate"))) = False Then
                        row.CancelDate = rd.GetValue(rd.GetOrdinal("CancelDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelReason"))) = False Then
                        row.CancelReason = rd.GetString(rd.GetOrdinal("CancelReason")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Job_QuotationHeader" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CQuoHeader", "DeleteData", cm.CommandText)
                End Using
                cn.Close()
                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CQuoHeader", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class