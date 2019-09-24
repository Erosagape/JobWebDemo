'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CTransportDetail
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
    Private m_ItemNo As Integer
    Public Property ItemNo As Integer
        Get
            Return m_ItemNo
        End Get
        Set(value As Integer)
            m_ItemNo = value
        End Set
    End Property
    Private m_CTN_NO As String
    Public Property CTN_NO As String
        Get
            Return m_CTN_NO
        End Get
        Set(value As String)
            m_CTN_NO = value
        End Set
    End Property
    Private m_SealNumber As String
    Public Property SealNumber As String
        Get
            Return m_SealNumber
        End Get
        Set(value As String)
            m_SealNumber = value
        End Set
    End Property
    Private m_TruckNO As String
    Public Property TruckNO As String
        Get
            Return m_TruckNO
        End Get
        Set(value As String)
            m_TruckNO = value
        End Set
    End Property
    Private m_TruckIN As Date
    Public Property TruckIN As Date
        Get
            Return m_TruckIN
        End Get
        Set(value As Date)
            m_TruckIN = value
        End Set
    End Property
    Private m_Start As Date
    Public Property Start As Date
        Get
            Return m_Start
        End Get
        Set(value As Date)
            m_Start = value
        End Set
    End Property
    Private m_Finish As Date
    Public Property Finish As Date
        Get
            Return m_Finish
        End Get
        Set(value As Date)
            m_Finish = value
        End Set
    End Property
    Private m_TimeUsed As Double
    Public Property TimeUsed As Double
        Get
            Return m_TimeUsed
        End Get
        Set(value As Double)
            m_TimeUsed = value
        End Set
    End Property
    Private m_CauseCode As String
    Public Property CauseCode As String
        Get
            Return m_CauseCode
        End Get
        Set(value As String)
            m_CauseCode = value
        End Set
    End Property
    Private m_Comment As String
    Public Property Comment As String
        Get
            Return m_Comment
        End Get
        Set(value As String)
            m_Comment = value
        End Set
    End Property
    Private m_TruckType As String
    Public Property TruckType As String
        Get
            Return m_TruckType
        End Get
        Set(value As String)
            m_TruckType = value
        End Set
    End Property
    Private m_Driver As String
    Public Property Driver As String
        Get
            Return m_Driver
        End Get
        Set(value As String)
            m_Driver = value
        End Set
    End Property
    Private m_TargetYardDate As Date
    Public Property TargetYardDate As Date
        Get
            Return m_TargetYardDate
        End Get
        Set(value As Date)
            m_TargetYardDate = value
        End Set
    End Property
    Private m_TargetYardTime As Date
    Public Property TargetYardTime As Date
        Get
            Return m_TargetYardTime
        End Get
        Set(value As Date)
            m_TargetYardTime = value
        End Set
    End Property
    Private m_ActualYardDate As Date
    Public Property ActualYardDate As Date
        Get
            Return m_ActualYardDate
        End Get
        Set(value As Date)
            m_ActualYardDate = value
        End Set
    End Property
    Private m_ActualYardTime As Date
    Public Property ActualYardTime As Date
        Get
            Return m_ActualYardTime
        End Get
        Set(value As Date)
            m_ActualYardTime = value
        End Set
    End Property
    Private m_UnloadFinishDate As Date
    Public Property UnloadFinishDate As Date
        Get
            Return m_UnloadFinishDate
        End Get
        Set(value As Date)
            m_UnloadFinishDate = value
        End Set
    End Property
    Private m_UnloadFinishTime As Date
    Public Property UnloadFinishTime As Date
        Get
            Return m_UnloadFinishTime
        End Get
        Set(value As Date)
            m_UnloadFinishTime = value
        End Set
    End Property
    Private m_UnloadDate As Date
    Public Property UnloadDate As Date
        Get
            Return m_UnloadDate
        End Get
        Set(value As Date)
            m_UnloadDate = value
        End Set
    End Property
    Private m_UnloadTime As Date
    Public Property UnloadTime As Date
        Get
            Return m_UnloadTime
        End Get
        Set(value As Date)
            m_UnloadTime = value
        End Set
    End Property
    Private m_Location As String
    Public Property Location As String
        Get
            Return m_Location
        End Get
        Set(value As String)
            m_Location = value
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
    Private m_ShippingMark As String
    Public Property ShippingMark As String
        Get
            Return m_ShippingMark
        End Get
        Set(value As String)
            m_ShippingMark = value
        End Set
    End Property
    Private m_ProductDesc As String
    Public Property ProductDesc As String
        Get
            Return m_ProductDesc
        End Get
        Set(value As String)
            m_ProductDesc = value
        End Set
    End Property
    Private m_CTN_SIZE As String
    Public Property CTN_SIZE As String
        Get
            Return m_CTN_SIZE
        End Get
        Set(value As String)
            m_CTN_SIZE = value
        End Set
    End Property
    Private m_ProductQty As Double
    Public Property ProductQty As Double
        Get
            Return m_ProductQty
        End Get
        Set(value As Double)
            m_ProductQty = value
        End Set
    End Property
    Private m_ProductUnit As String
    Public Property ProductUnit As String
        Get
            Return m_ProductUnit
        End Get
        Set(value As String)
            m_ProductUnit = value
        End Set
    End Property
    Private m_GrossWeight As Double
    Public Property GrossWeight As Double
        Get
            Return m_GrossWeight
        End Get
        Set(value As Double)
            m_GrossWeight = value
        End Set
    End Property
    Private m_Measurement As Double
    Public Property Measurement As Double
        Get
            Return m_Measurement
        End Get
        Set(value As Double)
            m_Measurement = value
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
    Private m_DeliveryNo As String
    Public Property DeliveryNo As String
        Get
            Return m_DeliveryNo
        End Get
        Set(value As String)
            m_DeliveryNo = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_LoadInfoDetail" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("JNo") = Me.JNo
                            dr("BookingNo") = Me.BookingNo
                            If Me.ItemNo = 0 Then Me.AddNew()
                            dr("ItemNo") = Me.ItemNo
                            dr("CTN_NO") = Me.CTN_NO
                            dr("SealNumber") = Me.SealNumber
                            dr("TruckNO") = Me.TruckNO
                            dr("TruckIN") = Main.GetDBDate(Me.TruckIN)
                            dr("Start") = Main.GetDBDate(Me.Start)
                            dr("Finish") = Main.GetDBDate(Me.Finish)
                            dr("TimeUsed") = Me.TimeUsed
                            dr("CauseCode") = Me.CauseCode
                            dr("Comment") = Me.Comment
                            dr("TruckType") = Me.TruckType
                            dr("Driver") = Me.Driver
                            dr("TargetYardDate") = Main.GetDBDate(Me.TargetYardDate)
                            dr("TargetYardTime") = Main.GetDBTime(Me.TargetYardTime)
                            dr("ActualYardDate") = Main.GetDBDate(Me.ActualYardDate)
                            dr("ActualYardTime") = Main.GetDBTime(Me.ActualYardTime)
                            dr("UnloadFinishDate") = Main.GetDBDate(Me.UnloadFinishDate)
                            dr("UnloadFinishTime") = Main.GetDBTime(Me.UnloadFinishTime)
                            dr("UnloadDate") = Main.GetDBDate(Me.UnloadDate)
                            dr("UnloadTime") = Main.GetDBTime(Me.UnloadTime)
                            dr("Location") = Me.Location
                            dr("ReturnDate") = Main.GetDBDate(Me.ReturnDate)
                            dr("ShippingMark") = Me.ShippingMark
                            dr("ProductDesc") = Me.ProductDesc
                            dr("CTN_SIZE") = Me.CTN_SIZE
                            dr("ProductQty") = Me.ProductQty
                            dr("ProductUnit") = Me.ProductUnit
                            dr("GrossWeight") = Me.GrossWeight
                            dr("Measurement") = Me.Measurement
                            dr("DeliveryNo") = Me.DeliveryNo
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CTransportDetail", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CTransportDetail", "SaveData", ex.Message)
                msg = "[ERROR]:" & ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()
        Dim retStr As String = Main.GetMaxByMask(m_ConnStr, String.Format("SELECT MAX(ItemNo) as t FROM Job_LoadInfoDetail WHERE BranchCode='{0}' And BookingNo ='{1}' ", m_BranchCode, m_BookingNo), "____")
        m_ItemNo = Convert.ToInt32("0" & retStr)
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CTransportDetail)
        Dim lst As New List(Of CTransportDetail)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CTransportDetail
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_LoadInfoDetail" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CTransportDetail(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JNo"))) = False Then
                        row.JNo = rd.GetString(rd.GetOrdinal("JNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BookingNo"))) = False Then
                        row.BookingNo = rd.GetString(rd.GetOrdinal("BookingNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ItemNo"))) = False Then
                        row.ItemNo = rd.GetInt16(rd.GetOrdinal("ItemNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CTN_NO"))) = False Then
                        row.CTN_NO = rd.GetString(rd.GetOrdinal("CTN_NO")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("SealNumber"))) = False Then
                        row.SealNumber = rd.GetString(rd.GetOrdinal("SealNumber")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TruckNO"))) = False Then
                        row.TruckNO = rd.GetString(rd.GetOrdinal("TruckNO")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TruckIN"))) = False Then
                        row.TruckIN = rd.GetValue(rd.GetOrdinal("TruckIN"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Start"))) = False Then
                        row.Start = rd.GetValue(rd.GetOrdinal("Start"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Finish"))) = False Then
                        row.Finish = rd.GetValue(rd.GetOrdinal("Finish"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TimeUsed"))) = False Then
                        row.TimeUsed = rd.GetValue(rd.GetOrdinal("TimeUsed"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CauseCode"))) = False Then
                        row.CauseCode = rd.GetString(rd.GetOrdinal("CauseCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Comment"))) = False Then
                        row.Comment = rd.GetString(rd.GetOrdinal("Comment")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TruckType"))) = False Then
                        row.TruckType = rd.GetString(rd.GetOrdinal("TruckType")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Driver"))) = False Then
                        row.Driver = rd.GetString(rd.GetOrdinal("Driver")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TargetYardDate"))) = False Then
                        row.TargetYardDate = rd.GetValue(rd.GetOrdinal("TargetYardDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TargetYardTime"))) = False Then
                        row.TargetYardTime = rd.GetValue(rd.GetOrdinal("TargetYardTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ActualYardDate"))) = False Then
                        row.ActualYardDate = rd.GetValue(rd.GetOrdinal("ActualYardDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ActualYardTime"))) = False Then
                        row.ActualYardTime = rd.GetValue(rd.GetOrdinal("ActualYardTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UnloadFinishDate"))) = False Then
                        row.UnloadFinishDate = rd.GetValue(rd.GetOrdinal("UnloadFinishDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UnloadFinishTime"))) = False Then
                        row.UnloadFinishTime = rd.GetValue(rd.GetOrdinal("UnloadFinishTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UnloadDate"))) = False Then
                        row.UnloadDate = rd.GetValue(rd.GetOrdinal("UnloadDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UnloadTime"))) = False Then
                        row.UnloadTime = rd.GetValue(rd.GetOrdinal("UnloadTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Location"))) = False Then
                        row.Location = rd.GetString(rd.GetOrdinal("Location")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReturnDate"))) = False Then
                        row.ReturnDate = rd.GetValue(rd.GetOrdinal("ReturnDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ShippingMark"))) = False Then
                        row.ShippingMark = rd.GetString(rd.GetOrdinal("ShippingMark")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ProductDesc"))) = False Then
                        row.ProductDesc = rd.GetString(rd.GetOrdinal("ProductDesc")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CTN_SIZE"))) = False Then
                        row.CTN_SIZE = rd.GetString(rd.GetOrdinal("CTN_SIZE")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ProductQty"))) = False Then
                        row.ProductQty = rd.GetDouble(rd.GetOrdinal("ProductQty"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ProductUnit"))) = False Then
                        row.ProductUnit = rd.GetString(rd.GetOrdinal("ProductUnit")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("GrossWeight"))) = False Then
                        row.GrossWeight = rd.GetDouble(rd.GetOrdinal("GrossWeight"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Measurement"))) = False Then
                        row.Measurement = rd.GetDouble(rd.GetOrdinal("Measurement"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DeliveryNo"))) = False Then
                        row.DeliveryNo = rd.GetString(rd.GetOrdinal("DeliveryNo"))
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

                Using cm As New SqlCommand("DELETE FROM Job_LoadInfoDetail" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CTransportDetail", "DeleteData", cm.CommandText)
                End Using
                cn.Close()
                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CTransportDetail", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
