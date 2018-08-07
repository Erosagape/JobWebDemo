﻿Imports System.Data
Imports System.Data.SqlClient
Public Class CServUnit
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_UnitType As String
    Public Property UnitType As String
        Get
            Return m_UnitType
        End Get
        Set(value As String)
            m_UnitType = value
        End Set
    End Property
    Private m_UName As String
    Public Property UName As String
        Get
            Return m_UName
        End Get
        Set(value As String)
            m_UName = value
        End Set
    End Property
    Private m_EName As String
    Public Property EName As String
        Get
            Return m_EName
        End Get
        Set(value As String)
            m_EName = value
        End Set
    End Property
    Private m_IsCTNUnit As Integer
    Public Property IsCTNUnit As Integer
        Get
            Return m_IsCTNUnit
        End Get
        Set(value As Integer)
            m_IsCTNUnit = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As Boolean
        Dim bComplete As Boolean = False
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_ServUnitType" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("UnitType") = Me.UnitType
                            dr("UName") = Me.UName
                            dr("EName") = Me.EName
                            dr("IsCTNUnit") = Me.IsCTNUnit
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            bComplete = True
                        End Using
                    End Using
                End Using
            Catch ex As Exception
            End Try
        End Using
        Return bComplete
    End Function
    Public Function GetData(pSQLWhere As String) As List(Of CServUnit)
        Dim lst As New List(Of CServUnit)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CServUnit
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_ServUnitType" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CServUnit(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UnitType"))) = False Then
                        row.UnitType = rd.GetString(rd.GetOrdinal("UnitType")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("UName"))) = False Then
                        row.UName = rd.GetString(rd.GetOrdinal("UName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("EName"))) = False Then
                        row.EName = rd.GetString(rd.GetOrdinal("EName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("IsCTNUnit"))) = False Then
                        row.IsCTNUnit = rd.GetInt32(rd.GetOrdinal("IsCTNUnit"))
                    End If
                    lst.Add(row)
                End While
            Catch ex As Exception
            End Try
        End Using
        Return lst
    End Function
End Class