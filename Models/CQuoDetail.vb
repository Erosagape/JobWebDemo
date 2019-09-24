Imports System.Data.SqlClient
Public Class CQuoDetail
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
    Private m_SeqNo As Integer
    Public Property SeqNo As Integer
        Get
            Return m_SeqNo
        End Get
        Set(value As Integer)
            m_SeqNo = value
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
    Public ReadOnly Property JobTypeName As String
        Get
            Return GetValueConfig("JOB_TYPE", m_JobType.ToString("00"))
        End Get
    End Property
    Public ReadOnly Property ShipByName As String
        Get
            Return GetValueConfig("SHIP_BY", m_ShipBy.ToString("00"))
        End Get
    End Property
    Private m_Description As String
    Public Property Description As String
        Get
            Return m_Description
        End Get
        Set(value As String)
            m_Description = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_QuotationDetail" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("QNo") = Me.QNo
                            If Me.SeqNo = 0 Then Me.AddNew()
                            dr("SeqNo") = Me.SeqNo
                            dr("JobType") = Me.JobType
                            dr("ShipBy") = Me.ShipBy
                            dr("Description") = Me.Description
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CQuoDetail", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CQuoDetail", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()
        Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(SeqNo) as t FROM Job_QuotationDetail WHERE BranchCode='{0}' And QNo ='{1}' ", m_BranchCode, m_QNo), "____")
        m_SeqNo = Convert.ToInt32("0" & retStr)
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CQuoDetail)
        Dim lst As New List(Of CQuoDetail)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CQuoDetail
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_QuotationDetail" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CQuoDetail(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetString(rd.GetOrdinal("QNo"))) = False Then
                        row.QNo = rd.GetString(rd.GetOrdinal("QNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SeqNo"))) = False Then
                        row.SeqNo = rd.GetInt16(rd.GetOrdinal("SeqNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JobType"))) = False Then
                        row.JobType = rd.GetInt16(rd.GetOrdinal("JobType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ShipBy"))) = False Then
                        row.ShipBy = rd.GetInt16(rd.GetOrdinal("ShipBy"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Description"))) = False Then
                        row.Description = rd.GetString(rd.GetOrdinal("Description")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Job_QuotationDetail" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CQuoDetail", "DeleteData", cm.CommandText)
                End Using
                cn.Close()
                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CQuoDetail", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
