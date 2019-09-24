'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CGLDetail
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
    Private m_ItemNo As Integer
    Public Property ItemNo As Integer
        Get
            Return m_ItemNo
        End Get
        Set(value As Integer)
            m_ItemNo = value
        End Set
    End Property
    Private m_GLAccountCode As String
    Public Property GLAccountCode As String
        Get
            Return m_GLAccountCode
        End Get
        Set(value As String)
            m_GLAccountCode = value
        End Set
    End Property
    Private m_GLDescription As String
    Public Property GLDescription As String
        Get
            Return m_GLDescription
        End Get
        Set(value As String)
            m_GLDescription = value
        End Set
    End Property
    Private m_SourceDocument As String
    Public Property SourceDocument As String
        Get
            Return m_SourceDocument
        End Get
        Set(value As String)
            m_SourceDocument = value
        End Set
    End Property
    Private m_DebitAmt As Double
    Public Property DebitAmt As Double
        Get
            Return m_DebitAmt
        End Get
        Set(value As Double)
            m_DebitAmt = value
        End Set
    End Property
    Private m_CreditAmt As Double
    Public Property CreditAmt As Double
        Get
            Return m_CreditAmt
        End Get
        Set(value As Double)
            m_CreditAmt = value
        End Set
    End Property
    Private m_EntryDate As Date
    Public Property EntryDate As Date
        Get
            Return m_EntryDate
        End Get
        Set(value As Date)
            m_EntryDate = value
        End Set
    End Property
    Private m_EntryBy As String
    Public Property EntryBy As String
        Get
            Return m_EntryBy
        End Get
        Set(value As String)
            m_EntryBy = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_GLDetail" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("GLRefNo") = Me.GLRefNo
                            If Me.ItemNo = 0 Then Me.AddNew()
                            dr("ItemNo") = Me.ItemNo
                            dr("GLAccountCode") = Me.GLAccountCode
                            dr("GLDescription") = Me.GLDescription
                            dr("SourceDocument") = Me.SourceDocument
                            dr("DebitAmt") = Me.DebitAmt
                            dr("CreditAmt") = Me.CreditAmt
                            dr("EntryDate") = Main.GetDBDate(Me.EntryDate)
                            dr("EntryBy") = Me.EntryBy
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CGLDetail", "SaveData", Me)
                            UpdateTotal(cn)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CGLDetail", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()
        Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(ItemNo) as t FROM Job_GLDetail WHERE BranchCode='{0}' And GLRefNo ='{1}' ", m_BranchCode, m_GLRefNo), "____")
        m_ItemNo = Convert.ToInt32("0" & retStr)
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CGLDetail)
        Dim lst As New List(Of CGLDetail)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CGLDetail
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_GLDetail" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CGLDetail(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GLRefNo"))) = False Then
                        row.GLRefNo = rd.GetString(rd.GetOrdinal("GLRefNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ItemNo"))) = False Then
                        row.ItemNo = rd.GetValue(rd.GetOrdinal("ItemNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GLAccountCode"))) = False Then
                        row.GLAccountCode = rd.GetString(rd.GetOrdinal("GLAccountCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GLDescription"))) = False Then
                        row.GLDescription = rd.GetString(rd.GetOrdinal("GLDescription")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SourceDocument"))) = False Then
                        row.SourceDocument = rd.GetString(rd.GetOrdinal("SourceDocument")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DebitAmt"))) = False Then
                        row.DebitAmt = rd.GetDouble(rd.GetOrdinal("DebitAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CreditAmt"))) = False Then
                        row.CreditAmt = rd.GetDouble(rd.GetOrdinal("CreditAmt"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EntryDate"))) = False Then
                        row.EntryDate = rd.GetValue(rd.GetOrdinal("EntryDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EntryBy"))) = False Then
                        row.EntryBy = rd.GetString(rd.GetOrdinal("EntryBy")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Job_GLDetail" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CGLDetail", "DeleteData", cm.CommandText)
                End Using
                UpdateTotal(cn)
                cn.Close()
                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CGLDetail", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub UpdateTotal(cn As SqlConnection)
        Dim sql As String = SQLUpdateGLHeader()

        Using cm As New SqlCommand(sql, cn)
            cm.CommandText = sql & If(Me.GLRefNo <> "", " WHERE a.BranchCode='" + Me.BranchCode + "' and a.GLRefNo='" + Me.GLRefNo + "'", "")
            cm.CommandType = CommandType.Text
            cm.ExecuteNonQuery()
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CGLDetail", "UpdateTotal", cm.CommandText)
        End Using
    End Sub
End Class
