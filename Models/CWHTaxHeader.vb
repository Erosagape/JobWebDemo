Imports System.Data.SqlClient
Public Class CWHTaxHeader
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
    Private m_DocDate As Date
    Public Property DocDate As Date
        Get
            Return m_DocDate
        End Get
        Set(value As Date)
            m_DocDate = value
        End Set
    End Property
    Private m_TaxNumber1 As String
    Public Property TaxNumber1 As String
        Get
            Return m_TaxNumber1
        End Get
        Set(value As String)
            m_TaxNumber1 = value
        End Set
    End Property
    Private m_TName1 As String
    Public Property TName1 As String
        Get
            Return m_TName1
        End Get
        Set(value As String)
            m_TName1 = value
        End Set
    End Property
    Private m_TAddress1 As String
    Public Property TAddress1 As String
        Get
            Return m_TAddress1
        End Get
        Set(value As String)
            m_TAddress1 = value
        End Set
    End Property
    Private m_TaxNumber2 As String
    Public Property TaxNumber2 As String
        Get
            Return m_TaxNumber2
        End Get
        Set(value As String)
            m_TaxNumber2 = value
        End Set
    End Property
    Private m_TName2 As String
    Public Property TName2 As String
        Get
            Return m_TName2
        End Get
        Set(value As String)
            m_TName2 = value
        End Set
    End Property
    Private m_TAddress2 As String
    Public Property TAddress2 As String
        Get
            Return m_TAddress2
        End Get
        Set(value As String)
            m_TAddress2 = value
        End Set
    End Property
    Private m_TaxNumber3 As String
    Public Property TaxNumber3 As String
        Get
            Return m_TaxNumber3
        End Get
        Set(value As String)
            m_TaxNumber3 = value
        End Set
    End Property
    Private m_TName3 As String
    Public Property TName3 As String
        Get
            Return m_TName3
        End Get
        Set(value As String)
            m_TName3 = value
        End Set
    End Property
    Private m_TAddress3 As String
    Public Property TAddress3 As String
        Get
            Return m_TAddress3
        End Get
        Set(value As String)
            m_TAddress3 = value
        End Set
    End Property
    Private m_IDCard1 As String
    Public Property IDCard1 As String
        Get
            Return m_IDCard1
        End Get
        Set(value As String)
            m_IDCard1 = value
        End Set
    End Property
    Private m_IDCard2 As String
    Public Property IDCard2 As String
        Get
            Return m_IDCard2
        End Get
        Set(value As String)
            m_IDCard2 = value
        End Set
    End Property
    Private m_IDCard3 As String
    Public Property IDCard3 As String
        Get
            Return m_IDCard3
        End Get
        Set(value As String)
            m_IDCard3 = value
        End Set
    End Property
    Private m_Branch1 As String
    Public Property Branch1 As String
        Get
            Return m_Branch1
        End Get
        Set(value As String)
            m_Branch1 = value
        End Set
    End Property
    Private m_Branch2 As String
    Public Property Branch2 As String
        Get
            Return m_Branch2
        End Get
        Set(value As String)
            m_Branch2 = value
        End Set
    End Property
    Private m_Branch3 As String
    Public Property Branch3 As String
        Get
            Return m_Branch3
        End Get
        Set(value As String)
            m_Branch3 = value
        End Set
    End Property
    Private m_SeqInForm As Integer
    Public Property SeqInForm As Integer
        Get
            Return m_SeqInForm
        End Get
        Set(value As Integer)
            m_SeqInForm = value
        End Set
    End Property
    Private m_FormType As Integer
    Public Property FormType As Integer
        Get
            Return m_FormType
        End Get
        Set(value As Integer)
            m_FormType = value
        End Set
    End Property
    Private m_TaxLawNo As String
    Public Property TaxLawNo As String
        Get
            Return m_TaxLawNo
        End Get
        Set(value As String)
            m_TaxLawNo = value
        End Set
    End Property
    Private m_IncRate As Double
    Public Property IncRate As Double
        Get
            Return m_IncRate
        End Get
        Set(value As Double)
            m_IncRate = value
        End Set
    End Property
    Private m_IncOther As String
    Public Property IncOther As String
        Get
            Return m_IncOther
        End Get
        Set(value As String)
            m_IncOther = value
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
    Private m_TotalPayAmount As Double
    Public Property TotalPayAmount As Double
        Get
            Return m_TotalPayAmount
        End Get
        Set(value As Double)
            m_TotalPayAmount = value
        End Set
    End Property
    Private m_TotalPayTax As Double
    Public Property TotalPayTax As Double
        Get
            Return m_TotalPayTax
        End Get
        Set(value As Double)
            m_TotalPayTax = value
        End Set
    End Property
    Private m_SoLicenseNo As String
    Public Property SoLicenseNo As String
        Get
            Return m_SoLicenseNo
        End Get
        Set(value As String)
            m_SoLicenseNo = value
        End Set
    End Property
    Private m_SoLicenseAmount As Double
    Public Property SoLicenseAmount As Double
        Get
            Return m_SoLicenseAmount
        End Get
        Set(value As Double)
            m_SoLicenseAmount = value
        End Set
    End Property
    Private m_SoAccAmount As Double
    Public Property SoAccAmount As Double
        Get
            Return m_SoAccAmount
        End Get
        Set(value As Double)
            m_SoAccAmount = value
        End Set
    End Property
    Private m_PayeeAccNo As String
    Public Property PayeeAccNo As String
        Get
            Return m_PayeeAccNo
        End Get
        Set(value As String)
            m_PayeeAccNo = value
        End Set
    End Property
    Private m_SoTaxNo As String
    Public Property SoTaxNo As String
        Get
            Return m_SoTaxNo
        End Get
        Set(value As String)
            m_SoTaxNo = value
        End Set
    End Property
    Private m_PayTaxType As Integer
    Public Property PayTaxType As Integer
        Get
            Return m_PayTaxType
        End Get
        Set(value As Integer)
            m_PayTaxType = value
        End Set
    End Property
    Private m_PayTaxOther As String
    Public Property PayTaxOther As String
        Get
            Return m_PayTaxOther
        End Get
        Set(value As String)
            m_PayTaxOther = value
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
    Private m_CancelReason As String
    Public Property CancelReason As String
        Get
            Return m_CancelReason
        End Get
        Set(value As String)
            m_CancelReason = value
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
    Private m_LastUpdate As Date
    Public Property LastUpdate As Date
        Get
            Return m_LastUpdate
        End Get
        Set(value As Date)
            m_LastUpdate = value
        End Set
    End Property
    Private m_TeacherAmt As Double
    Public Property TeacherAmt As Double
        Get
            Return m_TeacherAmt
        End Get
        Set(value As Double)
            m_TeacherAmt = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_WHTax" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("DocNo") = Me.DocNo
                            dr("DocDate") = Main.GetDBDate(Me.DocDate)
                            dr("TaxNumber1") = Me.TaxNumber1
                            dr("TName1") = Me.TName1
                            dr("TAddress1") = Me.TAddress1
                            dr("TaxNumber2") = Me.TaxNumber2
                            dr("TName2") = Me.TName2
                            dr("TAddress2") = Me.TAddress2
                            dr("TaxNumber3") = Me.TaxNumber3
                            dr("TName3") = Me.TName3
                            dr("TAddress3") = Me.TAddress3
                            dr("IDCard1") = Me.IDCard1
                            dr("IDCard2") = Me.IDCard2
                            dr("IDCard3") = Me.IDCard3
                            dr("Branch1") = Me.Branch1
                            dr("Branch2") = Me.Branch2
                            dr("Branch3") = Me.Branch3
                            dr("SeqInForm") = Me.SeqInForm
                            dr("FormType") = Me.FormType
                            dr("TaxLawNo") = Me.TaxLawNo
                            dr("IncRate") = Me.IncRate
                            dr("IncOther") = Me.IncOther
                            dr("UpdateBy") = Me.UpdateBy
                            dr("TotalPayAmount") = Me.TotalPayAmount
                            dr("TotalPayTax") = Me.TotalPayTax
                            dr("SoLicenseNo") = Me.SoLicenseNo
                            dr("SoLicenseAmount") = Me.SoLicenseAmount
                            dr("SoAccAmount") = Me.SoAccAmount
                            dr("PayeeAccNo") = Me.PayeeAccNo
                            dr("SoTaxNo") = Me.SoTaxNo
                            dr("PayTaxType") = Me.PayTaxType
                            dr("PayTaxOther") = Me.PayTaxOther
                            dr("CancelProve") = Me.CancelProve
                            dr("CancelReason") = Me.CancelReason
                            dr("CancelDate") = Main.GetDBDate(Me.CancelDate)
                            dr("LastUpdate") = DateTime.Now
                            dr("TeacherAmt") = Me.TeacherAmt
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CWHTaxHeader", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CWHTaxHeader", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew(pFormatSQL As String)
        If pFormatSQL = "" Then
            m_DocNo = ""
        Else
            Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(DocNo) as t FROM Job_WHTax WHERE BranchCode='{0}' And DocNo Like '%{1}' ", m_BranchCode, pFormatSQL), pFormatSQL)
            m_DocNo = retStr
        End If
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CWHTaxHeader)
        Dim lst As New List(Of CWHTaxHeader)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CWHTaxHeader
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_WHTax" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CWHTaxHeader(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocNo"))) = False Then
                        row.DocNo = rd.GetString(rd.GetOrdinal("DocNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocDate"))) = False Then
                        row.DocDate = rd.GetValue(rd.GetOrdinal("DocDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TaxNumber1"))) = False Then
                        row.TaxNumber1 = rd.GetString(rd.GetOrdinal("TaxNumber1")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TName1"))) = False Then
                        row.TName1 = rd.GetString(rd.GetOrdinal("TName1")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TAddress1"))) = False Then
                        row.TAddress1 = rd.GetString(rd.GetOrdinal("TAddress1")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TaxNumber2"))) = False Then
                        row.TaxNumber2 = rd.GetString(rd.GetOrdinal("TaxNumber2")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TName2"))) = False Then
                        row.TName2 = rd.GetString(rd.GetOrdinal("TName2")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TAddress2"))) = False Then
                        row.TAddress2 = rd.GetString(rd.GetOrdinal("TAddress2")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TaxNumber3"))) = False Then
                        row.TaxNumber3 = rd.GetString(rd.GetOrdinal("TaxNumber3")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TName3"))) = False Then
                        row.TName3 = rd.GetString(rd.GetOrdinal("TName3")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TAddress3"))) = False Then
                        row.TAddress3 = rd.GetString(rd.GetOrdinal("TAddress3")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IDCard1"))) = False Then
                        row.IDCard1 = rd.GetString(rd.GetOrdinal("IDCard1")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IDCard2"))) = False Then
                        row.IDCard2 = rd.GetString(rd.GetOrdinal("IDCard2")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IDCard3"))) = False Then
                        row.IDCard3 = rd.GetString(rd.GetOrdinal("IDCard3")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Branch1"))) = False Then
                        row.Branch1 = rd.GetString(rd.GetOrdinal("Branch1")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Branch2"))) = False Then
                        row.Branch2 = rd.GetString(rd.GetOrdinal("Branch2")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Branch3"))) = False Then
                        row.Branch3 = rd.GetString(rd.GetOrdinal("Branch3")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SeqInForm"))) = False Then
                        row.SeqInForm = rd.GetInt32(rd.GetOrdinal("SeqInForm"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FormType"))) = False Then
                        row.FormType = rd.GetByte(rd.GetOrdinal("FormType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TaxLawNo"))) = False Then
                        row.TaxLawNo = rd.GetString(rd.GetOrdinal("TaxLawNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IncRate"))) = False Then
                        row.IncRate = rd.GetDouble(rd.GetOrdinal("IncRate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IncOther"))) = False Then
                        row.IncOther = rd.GetString(rd.GetOrdinal("IncOther")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UpdateBy"))) = False Then
                        row.UpdateBy = rd.GetString(rd.GetOrdinal("UpdateBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalPayAmount"))) = False Then
                        row.TotalPayAmount = rd.GetDouble(rd.GetOrdinal("TotalPayAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalPayTax"))) = False Then
                        row.TotalPayTax = rd.GetDouble(rd.GetOrdinal("TotalPayTax"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SoLicenseNo"))) = False Then
                        row.SoLicenseNo = rd.GetString(rd.GetOrdinal("SoLicenseNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SoLicenseAmount"))) = False Then
                        row.SoLicenseAmount = rd.GetDouble(rd.GetOrdinal("SoLicenseAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SoAccAmount"))) = False Then
                        row.SoAccAmount = rd.GetDouble(rd.GetOrdinal("SoAccAmount"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PayeeAccNo"))) = False Then
                        row.PayeeAccNo = rd.GetString(rd.GetOrdinal("PayeeAccNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SoTaxNo"))) = False Then
                        row.SoTaxNo = rd.GetString(rd.GetOrdinal("SoTaxNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PayTaxType"))) = False Then
                        row.PayTaxType = rd.GetByte(rd.GetOrdinal("PayTaxType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PayTaxOther"))) = False Then
                        row.PayTaxOther = rd.GetString(rd.GetOrdinal("PayTaxOther")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelProve"))) = False Then
                        row.CancelProve = rd.GetString(rd.GetOrdinal("CancelProve")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelReason"))) = False Then
                        row.CancelReason = rd.GetString(rd.GetOrdinal("CancelReason")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CancelDate"))) = False Then
                        row.CancelDate = rd.GetValue(rd.GetOrdinal("CancelDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LastUpdate"))) = False Then
                        row.LastUpdate = rd.GetValue(rd.GetOrdinal("LastUpdate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TeacherAmt"))) = False Then
                        row.TeacherAmt = rd.GetDouble(rd.GetOrdinal("TeacherAmt"))
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

                Using cm As New SqlCommand("DELETE FROM Job_WHTax" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CWHTaxHeader", "DeleteData", cm.CommandText)
                End Using
                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CWHTaxHeader", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class