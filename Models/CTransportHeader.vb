'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CTransportHeader
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
    Private m_JNo As String
    Public Property JNo As String
        Get
            Return m_JNo
        End Get
        Set(value As String)
            m_JNo = value
        End Set
    End Property
    Private m_VenderCode As String
    Public Property VenderCode As String
        Get
            Return m_VenderCode
        End Get
        Set(value As String)
            m_VenderCode = value
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
    Private m_BookingNo As String
    Public Property BookingNo As String
        Get
            Return m_BookingNo
        End Get
        Set(value As String)
            m_BookingNo = value
        End Set
    End Property
    Private m_LoadDate As Date
    Public Property LoadDate As Date
        Get
            Return m_LoadDate
        End Get
        Set(value As Date)
            m_LoadDate = value
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
    Private m_PackingPlace As String
    Public Property PackingPlace As String
        Get
            Return m_PackingPlace
        End Get
        Set(value As String)
            m_PackingPlace = value
        End Set
    End Property
    Private m_CYPlace As String
    Public Property CYPlace As String
        Get
            Return m_CYPlace
        End Get
        Set(value As String)
            m_CYPlace = value
        End Set
    End Property
    Private m_FactoryPlace As String
    Public Property FactoryPlace As String
        Get
            Return m_FactoryPlace
        End Get
        Set(value As String)
            m_FactoryPlace = value
        End Set
    End Property
    Private m_ReturnPlace As String
    Public Property ReturnPlace As String
        Get
            Return m_ReturnPlace
        End Get
        Set(value As String)
            m_ReturnPlace = value
        End Set
    End Property
    Private m_PackingDate As Date
    Public Property PackingDate As Date
        Get
            Return m_PackingDate
        End Get
        Set(value As Date)
            m_PackingDate = value
        End Set
    End Property
    Private m_CYDate As Date
    Public Property CYDate As Date
        Get
            Return m_CYDate
        End Get
        Set(value As Date)
            m_CYDate = value
        End Set
    End Property
    Private m_FactoryDate As Date
    Public Property FactoryDate As Date
        Get
            Return m_FactoryDate
        End Get
        Set(value As Date)
            m_FactoryDate = value
        End Set
    End Property
    Private m_ReturnDate As Date
    Public Property ReturnDate As Date
        Get
            Return m_ReturnDate
        End Get
        Set(value As Date)
            m_ReturnDate = value
        End Set
    End Property
    Private m_PackingTime As Date
    Public Property PackingTime As Date
        Get
            Return m_PackingTime
        End Get
        Set(value As Date)
            m_PackingTime = value
        End Set
    End Property
    Private m_CYTime As Date
    Public Property CYTime As Date
        Get
            Return m_CYTime
        End Get
        Set(value As Date)
            m_CYTime = value
        End Set
    End Property
    Private m_FactoryTime As Date
    Public Property FactoryTime As Date
        Get
            Return m_FactoryTime
        End Get
        Set(value As Date)
            m_FactoryTime = value
        End Set
    End Property
    Private m_ReturnTime As Date
    Public Property ReturnTime As Date
        Get
            Return m_ReturnTime
        End Get
        Set(value As Date)
            m_ReturnTime = value
        End Set
    End Property
    Private m_NotifyCode As String
    Public Property NotifyCode As String
        Get
            Return m_NotifyCode
        End Get
        Set(value As String)
            m_NotifyCode = value
        End Set
    End Property
    Private m_TransMode As String
    Public Property TransMode As String
        Get
            Return m_TransMode
        End Get
        Set(value As String)
            m_TransMode = value
        End Set
    End Property
    Private m_PaymentCondition As String
    Public Property PaymentCondition As String
        Get
            Return m_PaymentCondition
        End Get
        Set(value As String)
            m_PaymentCondition = value
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
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_LoadInfo" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("JNo") = Me.JNo
                            dr("VenderCode") = Me.VenderCode
                            dr("ContactName") = Me.ContactName
                            dr("BookingNo") = Me.BookingNo
                            dr("LoadDate") = Main.GetDBDate(Me.LoadDate)
                            dr("Remark") = Me.Remark
                            dr("PackingPlace") = Me.PackingPlace
                            dr("CYPlace") = Me.CYPlace
                            dr("FactoryPlace") = Me.FactoryPlace
                            dr("ReturnPlace") = Me.ReturnPlace
                            dr("PackingDate") = Main.GetDBDate(Me.PackingDate)
                            dr("CYDate") = Main.GetDBDate(Me.CYDate)
                            dr("FactoryDate") = Main.GetDBDate(Me.FactoryDate)
                            dr("ReturnDate") = Main.GetDBDate(Me.ReturnDate)
                            dr("PackingTime") = Main.GetDBTime(Me.PackingTime)
                            dr("CYTime") = Main.GetDBTime(Me.CYTime)
                            dr("FactoryTime") = Main.GetDBTime(Me.FactoryTime)
                            dr("ReturnTime") = Main.GetDBTime(Me.ReturnTime)
                            dr("NotifyCode") = Me.NotifyCode
                            dr("TransMode") = Me.TransMode
                            dr("PaymentCondition") = Me.PaymentCondition
                            dr("PaymentBy") = Me.PaymentBy
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CTransportHeader", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CTransportHeader", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_BranchCode = ""
        m_JNo = DateTime.MinValue
        m_VenderCode = ""
        m_ContactName = ""
        m_BookingNo = ""
        m_LoadDate = DateTime.MinValue
        m_Remark = ""
        m_PackingPlace = ""
        m_CYPlace = ""
        m_FactoryPlace = ""
        m_ReturnPlace = ""
        m_PackingDate = DateTime.MinValue
        m_CYDate = DateTime.MinValue
        m_FactoryDate = DateTime.MinValue
        m_ReturnDate = DateTime.MinValue
        m_PackingTime = DateTime.MinValue
        m_CYTime = DateTime.MinValue
        m_FactoryTime = DateTime.MinValue
        m_ReturnTime = DateTime.MinValue
        m_NotifyCode = ""
        m_TransMode = ""
        m_PaymentCondition = ""
        m_PaymentBy = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CTransportHeader)
        Dim lst As New List(Of CTransportHeader)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CTransportHeader
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_LoadInfo" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CTransportHeader(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JNo"))) = False Then
                        row.JNo = rd.GetValue(rd.GetOrdinal("JNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VenderCode"))) = False Then
                        row.VenderCode = rd.GetString(rd.GetOrdinal("VenderCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ContactName"))) = False Then
                        row.ContactName = rd.GetString(rd.GetOrdinal("ContactName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BookingNo"))) = False Then
                        row.BookingNo = rd.GetString(rd.GetOrdinal("BookingNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("LoadDate"))) = False Then
                        row.LoadDate = rd.GetValue(rd.GetOrdinal("LoadDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Remark"))) = False Then
                        row.Remark = rd.GetString(rd.GetOrdinal("Remark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PackingPlace"))) = False Then
                        row.PackingPlace = rd.GetString(rd.GetOrdinal("PackingPlace")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CYPlace"))) = False Then
                        row.CYPlace = rd.GetString(rd.GetOrdinal("CYPlace")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FactoryPlace"))) = False Then
                        row.FactoryPlace = rd.GetString(rd.GetOrdinal("FactoryPlace")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReturnPlace"))) = False Then
                        row.ReturnPlace = rd.GetString(rd.GetOrdinal("ReturnPlace")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PackingDate"))) = False Then
                        row.PackingDate = rd.GetValue(rd.GetOrdinal("PackingDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CYDate"))) = False Then
                        row.CYDate = rd.GetValue(rd.GetOrdinal("CYDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FactoryDate"))) = False Then
                        row.FactoryDate = rd.GetValue(rd.GetOrdinal("FactoryDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReturnDate"))) = False Then
                        row.ReturnDate = rd.GetValue(rd.GetOrdinal("ReturnDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PackingTime"))) = False Then
                        row.PackingTime = rd.GetValue(rd.GetOrdinal("PackingTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CYTime"))) = False Then
                        row.CYTime = rd.GetValue(rd.GetOrdinal("CYTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("FactoryTime"))) = False Then
                        row.FactoryTime = rd.GetValue(rd.GetOrdinal("FactoryTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReturnTime"))) = False Then
                        row.ReturnTime = rd.GetValue(rd.GetOrdinal("ReturnTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("NotifyCode"))) = False Then
                        row.NotifyCode = rd.GetString(rd.GetOrdinal("NotifyCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TransMode"))) = False Then
                        row.TransMode = rd.GetString(rd.GetOrdinal("TransMode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PaymentCondition"))) = False Then
                        row.PaymentCondition = rd.GetString(rd.GetOrdinal("PaymentCondition")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("PaymentBy"))) = False Then
                        row.PaymentBy = rd.GetString(rd.GetOrdinal("PaymentBy")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Job_LoadInfo" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    If Me.JNo <> "" Then
                        cm.CommandText = String.Format("DELETE FROM Job_LoadInfoDetail WHERE BranchCode='{0}' AND JNo='{1}'", Me.BranchCode, Me.JNo)
                        cm.ExecuteNonQuery()
                        Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CTransportHeader", "DeleteData", cm.CommandText)
                    End If
                End Using
                cn.Close()
                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CTransportHeader", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
