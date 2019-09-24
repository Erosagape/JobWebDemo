'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CBudgetPolicy
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_ID As Integer
    Public Property ID As Integer
        Get
            Return m_ID
        End Get
        Set(value As Integer)
            m_ID = value
        End Set
    End Property
    Private m_BranchCode As String
    Public Property BranchCode As String
        Get
            Return m_BranchCode
        End Get
        Set(value As String)
            m_BranchCode = value
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
    Private m_SICode As String
    Public Property SICode As String
        Get
            Return m_SICode
        End Get
        Set(value As String)
            m_SICode = value
        End Set
    End Property
    Private m_SDescription As String
    Public Property SDescription As String
        Get
            Return m_SDescription
        End Get
        Set(value As String)
            m_SDescription = value
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
    Private m_MaxAdvance As Double
    Public Property MaxAdvance As Double
        Get
            Return m_MaxAdvance
        End Get
        Set(value As Double)
            m_MaxAdvance = value
        End Set
    End Property
    Private m_MaxCost As Double
    Public Property MaxCost As Double
        Get
            Return m_MaxCost
        End Get
        Set(value As Double)
            m_MaxCost = value
        End Set
    End Property
    Private m_MinCharge As Double
    Public Property MinCharge As Double
        Get
            Return m_MinCharge
        End Get
        Set(value As Double)
            m_MinCharge = value
        End Set
    End Property
    Private m_MinProfit As Double
    Public Property MinProfit As Double
        Get
            Return m_MinProfit
        End Get
        Set(value As Double)
            m_MinProfit = value
        End Set
    End Property
    Private m_Active As String
    Public Property Active As String
        Get
            Return m_Active
        End Get
        Set(value As String)
            m_Active = value
        End Set
    End Property
    Private m_LastUpdate As Date
    Public Property LastUpdate As Date
        Get
            Return m_LastUpdate
        End Get
        Set(value As Date)
            m_LastUpdate = value
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
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_BudgetPolicy " & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            If Me.ID = 0 Then Me.AddNew()
                            dr("ID") = Me.ID
                            dr("BranchCode") = Me.BranchCode
                            dr("JobType") = Me.JobType
                            dr("ShipBy") = Me.ShipBy
                            dr("SICode") = Me.SICode
                            dr("SDescription") = Me.SDescription
                            dr("TRemark") = Me.TRemark
                            dr("MaxAdvance") = Me.MaxAdvance
                            dr("MaxCost") = Me.MaxCost
                            dr("MinCharge") = Me.MinCharge
                            dr("MinProfit") = Me.MinProfit
                            dr("Active") = Me.Active
                            dr("LastUpdate") = Today.Date
                            dr("UpdateBy") = Me.UpdateBy
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBudgetPolicy", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBudgetPolicy", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()
        Dim retStr As String = Main.GetMaxByMask(m_ConnStr, "SELECT MAX(ID) as t FROM Job_BudgetPolicy ", "____")
        m_ID = Convert.ToInt32("0" & retStr)
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CBudgetPolicy)
        Dim lst As New List(Of CBudgetPolicy)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CBudgetPolicy
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_BudgetPolicy" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CBudgetPolicy(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ID"))) = False Then
                        row.ID = rd.GetInt32(rd.GetOrdinal("ID"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JobType"))) = False Then
                        row.JobType = rd.GetByte(rd.GetOrdinal("JobType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ShipBy"))) = False Then
                        row.ShipBy = rd.GetByte(rd.GetOrdinal("ShipBy"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SICode"))) = False Then
                        row.SICode = rd.GetString(rd.GetOrdinal("SICode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SDescription"))) = False Then
                        row.SDescription = rd.GetString(rd.GetOrdinal("SDescription")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TRemark"))) = False Then
                        row.TRemark = rd.GetString(rd.GetOrdinal("TRemark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("MaxAdvance"))) = False Then
                        row.MaxAdvance = rd.GetDouble(rd.GetOrdinal("MaxAdvance"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("MaxCost"))) = False Then
                        row.MaxCost = rd.GetDouble(rd.GetOrdinal("MaxCost"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("MinCharge"))) = False Then
                        row.MinCharge = rd.GetDouble(rd.GetOrdinal("MinCharge"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("MinProfit"))) = False Then
                        row.MinProfit = rd.GetDouble(rd.GetOrdinal("MinProfit"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Active"))) = False Then
                        row.Active = rd.GetString(rd.GetOrdinal("Active")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LastUpdate"))) = False Then
                        row.LastUpdate = rd.GetValue(rd.GetOrdinal("LastUpdate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UpdateBy"))) = False Then
                        row.UpdateBy = rd.GetString(rd.GetOrdinal("UpdateBy")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Job_BudgetPolicy" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBudgetPolicy", "DeleteData", cm.CommandText)
                End Using
                cn.Close()
                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBudgetPolicy", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class