Imports System.Data
Imports System.Data.SqlClient
Public Class CAdvHeader
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
            m_AdvNo = ""
        Else
            Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(AdvNo) as t FROM Job_AdvHeader WHERE BranchCode='{0}' And AdvNo Like '%{1}' ", m_BranchCode, pformatSQL), pformatSQL)
            m_AdvNo = retStr
        End If
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
    Private m_AdvDate As Date
    Public Property AdvDate As Date
        Get
            Return m_AdvDate
        End Get
        Set(value As Date)
            m_AdvDate = value
        End Set
    End Property
    Private m_AdvType As Integer
    Public Property AdvType As Integer
        Get
            Return m_AdvType
        End Get
        Set(value As Integer)
            m_AdvType = value
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
    Private m_AdvBy As String
    Public Property AdvBy As String
        Get
            Return m_AdvBy
        End Get
        Set(value As String)
            m_AdvBy = value
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
    Private m_JNo As String
    Public Property JNo As String
        Get
            Return m_JNo
        End Get
        Set(value As String)
            m_JNo = value
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
    Private m_DocStatus As Integer
    Public Property DocStatus As Integer
        Get
            Return m_DocStatus
        End Get
        Set(value As Integer)
            m_DocStatus = value
        End Set
    End Property
    Private m_VATRate As Integer
    Public Property VATRate As Integer
        Get
            Return m_VATRate
        End Get
        Set(value As Integer)
            m_VATRate = value
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
    Private m_TRemark As String
    Public Property TRemark As String
        Get
            Return m_TRemark
        End Get
        Set(value As String)
            m_TRemark = value
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
    Private m_PaymentBy As String
    Public Property PaymentBy As String
        Get
            Return m_PaymentBy
        End Get
        Set(value As String)
            m_PaymentBy = value
        End Set
    End Property
    Private m_PaymentDate As Date
    Public Property PaymentDate As Date
        Get
            Return m_PaymentDate
        End Get
        Set(value As Date)
            m_PaymentDate = value
        End Set
    End Property
    Private m_PaymentTime As Date
    Public Property PaymentTime As Date
        Get
            Return m_PaymentTime
        End Get
        Set(value As Date)
            m_PaymentTime = value
        End Set
    End Property
    Private m_PaymentRef As String
    Public Property PaymentRef As String
        Get
            Return m_PaymentRef
        End Get
        Set(value As String)
            m_PaymentRef = value
        End Set
    End Property
    Private m_PaymentNo As String
    Public Property PaymentNo As String
        Get
            Return m_PaymentNo
        End Get
        Set(value As String)
            m_PaymentNo = value
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
    Private m_AdvCash As Double
    Public Property AdvCash As Double
        Get
            Return m_AdvCash
        End Get
        Set(value As Double)
            m_AdvCash = value
        End Set
    End Property
    Private m_AdvChqCash As Double
    Public Property AdvChqCash As Double
        Get
            Return m_AdvChqCash
        End Get
        Set(value As Double)
            m_AdvChqCash = value
        End Set
    End Property
    Private m_AdvChq As Double
    Public Property AdvChq As Double
        Get
            Return m_AdvChq
        End Get
        Set(value As Double)
            m_AdvChq = value
        End Set
    End Property
    Private m_AdvCred As Double
    Public Property AdvCred As Double
        Get
            Return m_AdvCred
        End Get
        Set(value As Double)
            m_AdvCred = value
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
    Private m_PayChqDate As Date
    Public Property PayChqDate As Date
        Get
            Return m_PayChqDate
        End Get
        Set(value As Date)
            m_PayChqDate = value
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
    Private m_MainCurrency As String
    Public Property MainCurrency As String
        Get
            Return m_MainCurrency
        End Get
        Set(value As String)
            m_MainCurrency = value
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
    Private m_SubCurrency As String
    Public Property SubCurrency As String
        Get
            Return m_SubCurrency
        End Get
        Set(value As String)
            m_SubCurrency = value
        End Set
    End Property
    Private Function GetDocStatus() As Integer
        If Me.CancelProve <> "" Then
            Return 99
        Else
            Dim clrStatus As Integer = GetStatusClear()
            If clrStatus = 0 Then
                If Me.PaymentBy <> "" Then
                    Return 3
                Else
                    If Me.ApproveBy <> "" Then
                        Return 2
                    Else
                        Return 1
                    End If
                End If
            Else
                Return clrStatus
            End If
        End If
    End Function
    Private Function GetStatusClear() As Integer
        Dim sts As Integer = 0
        Return sts
    End Function
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_AdvHeader" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("AdvNo") = Me.AdvNo
                            dr("CustCode") = Me.CustCode
                            dr("CustBranch") = Me.CustBranch
                            dr("JobType") = Me.JobType
                            dr("ShipBy") = Me.ShipBy
                            dr("AdvDate") = Main.GetDBDate(Me.AdvDate, True)
                            dr("AdvType") = Me.AdvType
                            dr("EmpCode") = Me.EmpCode
                            dr("AdvBy") = Me.AdvBy
                            dr("JNo") = Me.JNo
                            dr("InvNo") = Me.InvNo
                            dr("VATRate") = Me.VATRate
                            dr("TotalAdvance") = Me.TotalAdvance
                            dr("TotalVAT") = Me.TotalVAT
                            dr("Total50Tavi") = Me.Total50Tavi
                            dr("TRemark") = Me.TRemark
                            dr("ApproveBy") = Me.ApproveBy
                            dr("ApproveDate") = Main.GetDBDate(Me.ApproveDate)
                            dr("ApproveTime") = Main.GetDBTime(Me.ApproveTime)
                            dr("PaymentBy") = Me.PaymentBy
                            dr("PaymentDate") = Main.GetDBDate(Me.PaymentDate)
                            dr("PaymentTime") = Main.GetDBTime(Me.PaymentTime)
                            dr("PaymentRef") = Me.PaymentRef
                            dr("PaymentNo") = Me.PaymentNo
                            dr("CancelReson") = Me.CancelReson
                            dr("CancelProve") = Me.CancelProve
                            dr("CancelDate") = Main.GetDBDate(Me.CancelDate)
                            dr("CancelTime") = Main.GetDBTime(Me.CancelTime)
                            dr("DocStatus") = Me.GetDocStatus
                            dr("AdvCash") = Me.AdvCash
                            dr("AdvChqCash") = Me.AdvChqCash
                            dr("AdvChq") = Me.AdvChq
                            dr("AdvCred") = Me.AdvCred
                            dr("PayChqTo") = Me.PayChqTo
                            dr("PayChqDate") = Main.GetDBDate(Me.PayChqDate)
                            dr("Doc50Tavi") = Me.Doc50Tavi
                            dr("MainCurrency") = Me.MainCurrency
                            dr("ExchangeRate") = Me.ExchangeRate
                            dr("SubCurrency") = Me.SubCurrency
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            If da.Update(dt) > 0 Then
                                UpdateTotal(cn)
                            End If
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CAdvHeader", "SaveData", Me)
                            msg = String.Format("Save '{0}' Complete", Me.AdvNo)
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CAdvHeader", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub UpdateTotal(cn As SqlConnection)
        Dim sql As String = SQLUpdateAdvHeader()

        Using cm As New SqlCommand(sql, cn)
            cm.CommandText = sql & " WHERE b.BranchCode='" + Me.BranchCode + "' and b.AdvNo='" + Me.AdvNo + "'"
            cm.CommandType = CommandType.Text
            cm.ExecuteNonQuery()
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CAdvHeader", "UpdateTotal", cm.CommandText)
        End Using
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CAdvHeader)
        Dim lst As New List(Of CAdvHeader)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CAdvHeader
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_AdvHeader" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CAdvHeader(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvNo"))) = False Then
                        row.AdvNo = rd.GetString(rd.GetOrdinal("AdvNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustCode"))) = False Then
                        row.CustCode = rd.GetString(rd.GetOrdinal("CustCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustBranch"))) = False Then
                        row.CustBranch = rd.GetString(rd.GetOrdinal("CustBranch")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JobType"))) = False Then
                        row.JobType = rd.GetByte(rd.GetOrdinal("JobType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ShipBy"))) = False Then
                        row.ShipBy = rd.GetByte(rd.GetOrdinal("ShipBy"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvDate"))) = False Then
                        row.AdvDate = rd.GetValue(rd.GetOrdinal("AdvDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvType"))) = False Then
                        row.AdvType = rd.GetByte(rd.GetOrdinal("AdvType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EmpCode"))) = False Then
                        row.EmpCode = rd.GetString(rd.GetOrdinal("EmpCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvBy"))) = False Then
                        row.AdvBy = rd.GetString(rd.GetOrdinal("AdvBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JNo"))) = False Then
                        row.JNo = rd.GetString(rd.GetOrdinal("JNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvNo"))) = False Then
                        row.InvNo = rd.GetString(rd.GetOrdinal("InvNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocStatus"))) = False Then
                        row.DocStatus = rd.GetByte(rd.GetOrdinal("DocStatus"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VATRate"))) = False Then
                        row.VATRate = rd.GetInt32(rd.GetOrdinal("VATRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalAdvance"))) = False Then
                        row.TotalAdvance = rd.GetDouble(rd.GetOrdinal("TotalAdvance"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalVAT"))) = False Then
                        row.TotalVAT = rd.GetDouble(rd.GetOrdinal("TotalVAT"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Total50Tavi"))) = False Then
                        row.Total50Tavi = rd.GetDouble(rd.GetOrdinal("Total50Tavi"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TRemark"))) = False Then
                        row.TRemark = rd.GetString(rd.GetOrdinal("TRemark")).ToString()
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
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PaymentBy"))) = False Then
                        row.PaymentBy = rd.GetString(rd.GetOrdinal("PaymentBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PaymentDate"))) = False Then
                        row.PaymentDate = rd.GetValue(rd.GetOrdinal("PaymentDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PaymentTime"))) = False Then
                        row.PaymentTime = rd.GetValue(rd.GetOrdinal("PaymentTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PaymentRef"))) = False Then
                        row.PaymentRef = rd.GetString(rd.GetOrdinal("PaymentRef")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PaymentNo"))) = False Then
                        row.PaymentNo = rd.GetString(rd.GetOrdinal("PaymentNo")).ToString()
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
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvCash"))) = False Then
                        row.AdvCash = rd.GetDouble(rd.GetOrdinal("AdvCash"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvChqCash"))) = False Then
                        row.AdvChqCash = rd.GetDouble(rd.GetOrdinal("AdvChqCash"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvChq"))) = False Then
                        row.AdvChq = rd.GetDouble(rd.GetOrdinal("AdvChq"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvCred"))) = False Then
                        row.AdvCred = rd.GetDouble(rd.GetOrdinal("AdvCred"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PayChqTo"))) = False Then
                        row.PayChqTo = rd.GetString(rd.GetOrdinal("PayChqTo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PayChqDate"))) = False Then
                        row.PayChqDate = rd.GetValue(rd.GetOrdinal("PayChqDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Doc50Tavi"))) = False Then
                        row.Doc50Tavi = rd.GetString(rd.GetOrdinal("Doc50Tavi")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("MainCurrency"))) = False Then
                        row.MainCurrency = rd.GetString(rd.GetOrdinal("MainCurrency")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ExchangeRate"))) = False Then
                        row.ExchangeRate = rd.GetDouble(rd.GetOrdinal("ExchangeRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SubCurrency"))) = False Then
                        row.SubCurrency = rd.GetString(rd.GetOrdinal("SubCurrency")).ToString()
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
                Using cm As New SqlCommand("DELETE FROM Job_AdvHeader " + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CAdvHeader", "DeleteData", ex.Message)
                msg = "[exception] " + ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class