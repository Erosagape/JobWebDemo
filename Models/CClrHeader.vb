﻿'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CClrHeader
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
    Private m_ClrNo As String
    Public Property ClrNo As String
        Get
            Return m_ClrNo
        End Get
        Set(value As String)
            m_ClrNo = value
        End Set
    End Property
    Private m_ClrDate As Date
    Public Property ClrDate As Date
        Get
            Return m_ClrDate
        End Get
        Set(value As Date)
            m_ClrDate = value
        End Set
    End Property
    Private m_ClearanceDate As Date
    Public Property ClearanceDate As Date
        Get
            Return m_ClearanceDate
        End Get
        Set(value As Date)
            m_ClearanceDate = value
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
    Private m_AdvRefNo As String
    Public Property AdvRefNo As String
        Get
            Return m_AdvRefNo
        End Get
        Set(value As String)
            m_AdvRefNo = value
        End Set
    End Property
    Private m_AdvTotal As Double
    Public Property AdvTotal As Double
        Get
            Return m_AdvTotal
        End Get
        Set(value As Double)
            m_AdvTotal = value
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
    Private m_JNo As Date
    Public Property JNo As Date
        Get
            Return m_JNo
        End Get
        Set(value As Date)
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
    Private m_ClearType As Integer
    Public Property ClearType As Integer
        Get
            Return m_ClearType
        End Get
        Set(value As Integer)
            m_ClearType = value
        End Set
    End Property
    Private m_ClearFrom As Integer
    Public Property ClearFrom As Integer
        Get
            Return m_ClearFrom
        End Get
        Set(value As Integer)
            m_ClearFrom = value
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
    Private m_TotalExpense As Double
    Public Property TotalExpense As Double
        Get
            Return m_TotalExpense
        End Get
        Set(value As Double)
            m_TotalExpense = value
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
    Private m_ReceiveBy As String
    Public Property ReceiveBy As String
        Get
            Return m_ReceiveBy
        End Get
        Set(value As String)
            m_ReceiveBy = value
        End Set
    End Property
    Private m_ReceiveDate As Date
    Public Property ReceiveDate As Date
        Get
            Return m_ReceiveDate
        End Get
        Set(value As Date)
            m_ReceiveDate = value
        End Set
    End Property
    Private m_ReceiveTime As Date
    Public Property ReceiveTime As Date
        Get
            Return m_ReceiveTime
        End Get
        Set(value As Date)
            m_ReceiveTime = value
        End Set
    End Property
    Private m_ReceiveRef As String
    Public Property ReceiveRef As String
        Get
            Return m_ReceiveRef
        End Get
        Set(value As String)
            m_ReceiveRef = value
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
    Private m_CoPersonCode As String
    Public Property CoPersonCode As String
        Get
            Return m_CoPersonCode
        End Get
        Set(value As String)
            m_CoPersonCode = value
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
    Private m_ClearTotal As Double
    Public Property ClearTotal As Double
        Get
            Return m_ClearTotal
        End Get
        Set(value As Double)
            m_ClearTotal = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Job_ClearHeader" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("BranchCode") = Me.BranchCode
                            dr("ClrNo") = Me.ClrNo
                            dr("ClrDate") = Main.GetDBDate(Me.ClrDate)
                            dr("ClearanceDate") = Main.GetDBDate(Me.ClearanceDate)
                            dr("EmpCode") = Me.EmpCode
                            dr("AdvRefNo") = Me.AdvRefNo
                            dr("AdvTotal") = Me.AdvTotal
                            dr("JobType") = Me.JobType
                            dr("JNo") = Main.GetDBDate(Me.JNo)
                            dr("InvNo") = Me.InvNo
                            dr("ClearType") = Me.ClearType
                            dr("ClearFrom") = Me.ClearFrom
                            dr("DocStatus") = Me.DocStatus
                            dr("TotalExpense") = Me.TotalExpense
                            dr("TRemark") = Me.TRemark
                            dr("ApproveBy") = Me.ApproveBy
                            dr("ApproveDate") = Main.GetDBDate(Me.ApproveDate)
                            dr("ApproveTime") = Main.GetDBTime(Me.ApproveTime)
                            dr("ReceiveBy") = Me.ReceiveBy
                            dr("ReceiveDate") = Main.GetDBDate(Me.ReceiveDate)
                            dr("ReceiveTime") = Main.GetDBTime(Me.ReceiveTime)
                            dr("ReceiveRef") = Me.ReceiveRef
                            dr("CancelReson") = Me.CancelReson
                            dr("CancelProve") = Me.CancelProve
                            dr("CancelDate") = Main.GetDBDate(Me.CancelDate)
                            dr("CancelTime") = Main.GetDBTime(Me.CancelTime)
                            dr("CoPersonCode") = Me.CoPersonCode
                            dr("CTN_NO") = Me.CTN_NO
                            dr("ClearTotal") = Me.ClearTotal
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_BranchCode = ""
        m_ClrNo = ""
        m_ClrDate = DateTime.MinValue
        m_ClearanceDate = DateTime.MinValue
        m_EmpCode = ""
        m_AdvRefNo = ""
        m_AdvTotal = 0
        m_JobType = 0
        m_JNo = DateTime.MinValue
        m_InvNo = ""
        m_ClearType = 0
        m_ClearFrom = 0
        m_DocStatus = 0
        m_TotalExpense = 0
        m_TRemark = ""
        m_ApproveBy = ""
        m_ApproveDate = DateTime.MinValue
        m_ApproveTime = DateTime.MinValue
        m_ReceiveBy = ""
        m_ReceiveDate = DateTime.MinValue
        m_ReceiveTime = DateTime.MinValue
        m_ReceiveRef = ""
        m_CancelReson = ""
        m_CancelProve = ""
        m_CancelDate = DateTime.MinValue
        m_CancelTime = DateTime.MinValue
        m_CoPersonCode = ""
        m_CTN_NO = ""
        m_ClearTotal = 0
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CClrHeader)
        Dim lst As New List(Of CClrHeader)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CClrHeader
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Job_ClearHeader" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CClrHeader(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BranchCode"))) = False Then
                        row.BranchCode = rd.GetString(rd.GetOrdinal("BranchCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ClrNo"))) = False Then
                        row.ClrNo = rd.GetString(rd.GetOrdinal("ClrNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ClrDate"))) = False Then
                        row.ClrDate = rd.GetValue(rd.GetOrdinal("ClrDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ClearanceDate"))) = False Then
                        row.ClearanceDate = rd.GetValue(rd.GetOrdinal("ClearanceDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EmpCode"))) = False Then
                        row.EmpCode = rd.GetString(rd.GetOrdinal("EmpCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvRefNo"))) = False Then
                        row.AdvRefNo = rd.GetString(rd.GetOrdinal("AdvRefNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("AdvTotal"))) = False Then
                        row.AdvTotal = rd.GetDouble(rd.GetOrdinal("AdvTotal"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JobType"))) = False Then
                        row.JobType = rd.GetByte(rd.GetOrdinal("JobType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("JNo"))) = False Then
                        row.JNo = rd.GetValue(rd.GetOrdinal("JNo"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("InvNo"))) = False Then
                        row.InvNo = rd.GetString(rd.GetOrdinal("InvNo")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ClearType"))) = False Then
                        row.ClearType = rd.GetByte(rd.GetOrdinal("ClearType"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ClearFrom"))) = False Then
                        row.ClearFrom = rd.GetByte(rd.GetOrdinal("ClearFrom"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("DocStatus"))) = False Then
                        row.DocStatus = rd.GetByte(rd.GetOrdinal("DocStatus"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TotalExpense"))) = False Then
                        row.TotalExpense = rd.GetDouble(rd.GetOrdinal("TotalExpense"))
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
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReceiveBy"))) = False Then
                        row.ReceiveBy = rd.GetString(rd.GetOrdinal("ReceiveBy")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReceiveDate"))) = False Then
                        row.ReceiveDate = rd.GetValue(rd.GetOrdinal("ReceiveDate"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReceiveTime"))) = False Then
                        row.ReceiveTime = rd.GetValue(rd.GetOrdinal("ReceiveTime"))
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ReceiveRef"))) = False Then
                        row.ReceiveRef = rd.GetString(rd.GetOrdinal("ReceiveRef")).ToString()
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
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CoPersonCode"))) = False Then
                        row.CoPersonCode = rd.GetString(rd.GetOrdinal("CoPersonCode")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CTN_NO"))) = False Then
                        row.CTN_NO = rd.GetString(rd.GetOrdinal("CTN_NO")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("ClearTotal"))) = False Then
                        row.ClearTotal = rd.GetDouble(rd.GetOrdinal("ClearTotal"))
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

                Using cm As New SqlCommand("DELETE FROM Job_ClearHeader" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                End Using
                cn.Close()
                msg = "Delete Complete"
            Catch ex As Exception
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class
