Imports System.Data.SqlClient
Public Class CVessel
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_RegsNumber As String
    Public Property RegsNumber As String
        Get
            Return m_RegsNumber
        End Get
        Set(value As String)
            m_RegsNumber = value
        End Set
    End Property
    Private m_TName As String
    Public Property TName As String
        Get
            Return m_TName
        End Get
        Set(value As String)
            m_TName = value
        End Set
    End Property
    Private m_VesselType As String
    Public Property VesselType As String
        Get
            Return m_VesselType
        End Get
        Set(value As String)
            m_VesselType = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_Vessel" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("RegsNumber") = Me.RegsNumber
                            dr("TName") = Me.TName
                            dr("VesselType") = Me.VesselType
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVessel", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVessel", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_RegsNumber = ""
        m_TName = ""
        m_VesselType = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CVessel)
        Dim lst As New List(Of CVessel)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CVessel
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_Vessel" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CVessel(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("RegsNumber"))) = False Then
                        row.RegsNumber = rd.GetString(rd.GetOrdinal("RegsNumber")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("TName"))) = False Then
                        row.TName = rd.GetString(rd.GetOrdinal("TName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("VesselType"))) = False Then
                        row.VesselType = rd.GetString(rd.GetOrdinal("VesselType")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Mas_Vessel" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVessel", "DeleteData", cm.CommandText)
                End Using
                cn.Close()
                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CVessel", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class