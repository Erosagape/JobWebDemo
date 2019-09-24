'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CWHTaxDetail
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
    Private m_DocNo As String
    Public Property DocNo As String
        Get
            Return m_DocNo
        End Get
        Set(value As String)
            m_DocNo = value
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
    Private m_IncType As String
    Public Property IncType As String
        Get
            Return m_IncType
        End Get
        Set(value As String)
            m_IncType = value
        End Set
    End Property
    Private m_PayDate As Date
    Public Property PayDate As Date
        Get
            Return m_PayDate
        End Get
        Set(value As Date)
            m_PayDate = value
        End Set
    End Property
    Private m_PayAmount As Double
    Public Property PayAmount As Double
        Get
            Return m_PayAmount
        End Get
        Set(value As Double)
            m_PayAmount = value
        End Set
    End Property
    Private m_PayRate As Double
    Public Property PayRate As Double
        Get
            Return m_PayRate
        End Get
        Set(value As Double)
            m_PayRate = value
        End Set
    End Property
    Private m_PayTax As Double
    Public Property PayTax As Double
        Get
            Return m_PayTax
        End Get
        Set(value As Double)
            m_PayTax = value
        End Set
    End Property
    Private m_PayTaxDesc As String
    Public Property PayTaxDesc As String
        Get
            Return m_PayTaxDesc
        End Get
        Set(value As String)
            m_PayTaxDesc = value
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
    Private m_DocRefType As Integer
    Public Property DocRefType As Integer
        Get
            Return m_DocRefType
        End Get
        Set(value As Integer)
            m_DocRefType = value
        End Set
    End Property
    Private m_DocRefNo As String
    Public Property DocRefNo As String
        Get
            Return m_DocRefNo
        End Get
        Set(value As String)
            m_DocRefNo = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_WHTaxDetail" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("DocNo") = Me.DocNo
                            If Me.ItemNo = 0 Then Me.AddNew()
                            dr("ItemNo") = Me.ItemNo
                            dr("IncType") = Me.IncType
                            dr("PayDate") = Main.GetDBDate(Me.PayDate)
                            dr("PayAmount") = Me.PayAmount
                            dr("PayRate") = Me.PayRate
                            dr("PayTax") = Me.PayTax
                            dr("PayTaxDesc") = Me.PayTaxDesc
                            dr("JNo") = Me.JNo
                            dr("DocRefType") = Me.DocRefType
                            dr("DocRefNo") = Me.DocRefNo
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            If da.Update(dt) > 0 Then
                                UpdateTotal(cn)
                            End If
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CWHTaxDetail", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CWHTaxDetail", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()
        Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(ItemNo) as t FROM Job_WHTaxDetail WHERE BranchCode='{0}' And DocNo ='{1}' ", m_BranchCode, m_DocNo), "____")
        m_ItemNo = Convert.ToInt32("0" & retStr)
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CWHTaxDetail)
        Dim lst As New List(Of CWHTaxDetail)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CWHTaxDetail
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_WHTaxDetail" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CWHTaxDetail(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocNo"))) = False Then
                        row.DocNo = rd.GetString(rd.GetOrdinal("DocNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ItemNo"))) = False Then
                        row.ItemNo = rd.GetInt32(rd.GetOrdinal("ItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IncType"))) = False Then
                        row.IncType = rd.GetString(rd.GetOrdinal("IncType")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PayDate"))) = False Then
                        row.PayDate = rd.GetValue(rd.GetOrdinal("PayDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PayAmount"))) = False Then
                        row.PayAmount = rd.GetDouble(rd.GetOrdinal("PayAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PayRate"))) = False Then
                        row.PayRate = rd.GetDouble(rd.GetOrdinal("PayRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PayTax"))) = False Then
                        row.PayTax = rd.GetDouble(rd.GetOrdinal("PayTax"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PayTaxDesc"))) = False Then
                        row.PayTaxDesc = rd.GetString(rd.GetOrdinal("PayTaxDesc")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JNo"))) = False Then
                        row.JNo = rd.GetString(rd.GetOrdinal("JNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocRefType"))) = False Then
                        row.DocRefType = rd.GetByte(rd.GetOrdinal("DocRefType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocRefNo"))) = False Then
                        row.DocRefNo = rd.GetString(rd.GetOrdinal("DocRefNo")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Job_WHTaxDetail" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CWHTaxDetail", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CWHTaxDetail", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub UpdateTotal(cn As SqlConnection)
        Dim sql As String = SQLUpdateWHTaxHeader()

        Using cm As New SqlCommand(sql, cn)
            cm.CommandText = sql + " and h.BranchCode='" + Me.BranchCode + "' and h.DocNo='" + Me.DocNo + "'"
            cm.CommandType = CommandType.Text
            cm.ExecuteNonQuery()
            Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CWHTaxDetail", "UpdateTotal", cm.CommandText)
        End Using
    End Sub
End Class