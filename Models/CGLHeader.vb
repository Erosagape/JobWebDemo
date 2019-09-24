'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CGLHeader
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
    Private m_GLRefNo As String
    Public Property GLRefNo As String
        Get
            Return m_GLRefNo
        End Get
        Set(value As String)
            m_GLRefNo = value
        End Set
    End Property
    Private m_FiscalYear As String
    Public Property FiscalYear As String
        Get
            Return m_FiscalYear
        End Get
        Set(value As String)
            m_FiscalYear = value
        End Set
    End Property
    Private m_LastupDate As Date
    Public Property LastupDate As Date
        Get
            Return m_LastupDate
        End Get
        Set(value As Date)
            m_LastupDate = value
        End Set
    End Property
    Private m_UpdateBy As String
    Public Property UpdateBy As String
        Get
            Return m_UpdateBy
        End Get
        Set(value As String)
            m_UpdateBy = value
        End Set
    End Property
    Private m_GLType As String
    Public Property GLType As String
        Get
            Return m_GLType
        End Get
        Set(value As String)
            m_GLType = value
        End Set
    End Property
    Private m_Remark As String
    Public Property Remark As String
        Get
            Return m_Remark
        End Get
        Set(value As String)
            m_Remark = value
        End Set
    End Property
    Private m_TotalDebit As Double
    Public Property TotalDebit As Double
        Get
            Return m_TotalDebit
        End Get
        Set(value As Double)
            m_TotalDebit = value
        End Set
    End Property
    Private m_TotalCredit As Double
    Public Property TotalCredit As Double
        Get
            Return m_TotalCredit
        End Get
        Set(value As Double)
            m_TotalCredit = value
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
    Private m_ApproveBy As String
    Public Property ApproveBy As String
        Get
            Return m_ApproveBy
        End Get
        Set(value As String)
            m_ApproveBy = value
        End Set
    End Property
    Private m_PostDate As Date
    Public Property PostDate As Date
        Get
            Return m_PostDate
        End Get
        Set(value As Date)
            m_PostDate = value
        End Set
    End Property
    Private m_PostBy As String
    Public Property PostBy As String
        Get
            Return m_PostBy
        End Get
        Set(value As String)
            m_PostBy = value
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
    Private m_CancelBy As String
    Public Property CancelBy As String
        Get
            Return m_CancelBy
        End Get
        Set(value As String)
            m_CancelBy = value
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

                Using da As New SqlDataAdapter("SELECT * FROM Job_GLHeader" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("GLRefNo") = Me.GLRefNo
                            dr("FiscalYear") = Me.FiscalYear
                            dr("LastupDate") = Main.GetDBDate(Me.LastupDate)
                            dr("UpdateBy") = Me.UpdateBy
                            dr("GLType") = Me.GLType
                            dr("Remark") = Me.Remark
                            dr("TotalDebit") = Me.TotalDebit
                            dr("TotalCredit") = Me.TotalCredit
                            dr("ApproveDate") = Main.GetDBDate(Me.ApproveDate)
                            dr("ApproveBy") = Me.ApproveBy
                            dr("PostDate") = Main.GetDBDate(Me.PostDate)
                            dr("PostBy") = Me.PostBy
                            dr("CancelDate") = Main.GetDBDate(Me.CancelDate)
                            dr("CancelBy") = Me.CancelBy
                            dr("CancelReason") = Me.CancelReason
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CGLHeader", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CGLHeader", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew(Optional pformatSQL As String = "")
        If pformatSQL = "" Then
            pformatSQL = "GL" & DateTime.Today.ToString("yyMM") & "____"
        End If
        Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(GLRefNo) as t FROM Job_GLHeader WHERE BranchCode='{0}' And GLRefNo Like '%{1}' ", m_BranchCode, pformatSQL), pformatSQL)
        m_GLRefNo = retStr
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CGLHeader)
        Dim lst As New List(Of CGLHeader)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CGLHeader
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_GLHeader" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CGLHeader(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GLRefNo"))) = False Then
                        row.GLRefNo = rd.GetString(rd.GetOrdinal("GLRefNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FiscalYear"))) = False Then
                        row.FiscalYear = rd.GetString(rd.GetOrdinal("FiscalYear")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LastupDate"))) = False Then
                        row.LastupDate = rd.GetValue(rd.GetOrdinal("LastupDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UpdateBy"))) = False Then
                        row.UpdateBy = rd.GetString(rd.GetOrdinal("UpdateBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GLType"))) = False Then
                        row.GLType = rd.GetString(rd.GetOrdinal("GLType")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Remark"))) = False Then
                        row.Remark = rd.GetString(rd.GetOrdinal("Remark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalDebit"))) = False Then
                        row.TotalDebit = rd.GetDouble(rd.GetOrdinal("TotalDebit"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalCredit"))) = False Then
                        row.TotalCredit = rd.GetDouble(rd.GetOrdinal("TotalCredit"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ApproveDate"))) = False Then
                        row.ApproveDate = rd.GetValue(rd.GetOrdinal("ApproveDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ApproveBy"))) = False Then
                        row.ApproveBy = rd.GetString(rd.GetOrdinal("ApproveBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PostDate"))) = False Then
                        row.PostDate = rd.GetValue(rd.GetOrdinal("PostDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PostBy"))) = False Then
                        row.PostBy = rd.GetString(rd.GetOrdinal("PostBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelDate"))) = False Then
                        row.CancelDate = rd.GetValue(rd.GetOrdinal("CancelDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelBy"))) = False Then
                        row.CancelBy = rd.GetString(rd.GetOrdinal("CancelBy")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Job_GLHeader" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CGLHeader", "DeleteData", cm.CommandText)
                End Using
                cn.Close()
                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CGLHeader", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class