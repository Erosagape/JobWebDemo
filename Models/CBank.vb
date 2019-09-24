'-----Class Definition-----
Imports System.Data.SqlClient
Public Class CBank
    Private m_ConnStr As String
    Public Sub New()

    End Sub
    Public Sub New(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub
    Public Sub SetConnect(pConnStr As String)
        m_ConnStr = pConnStr
    End Sub

    Private m_Code As String
    Public Property Code As String
        Get
            Return m_Code
        End Get
        Set(value As String)
            m_Code = value
        End Set
    End Property
    Private m_BName As String
    Public Property BName As String
        Get
            Return m_BName
        End Get
        Set(value As String)
            m_BName = value
        End Set
    End Property
    Private m_CustomsCode As String
    Public Property CustomsCode As String
        Get
            Return m_CustomsCode
        End Get
        Set(value As String)
            m_CustomsCode = value
        End Set
    End Property
    Public Function SaveData(pSQLWhere As String) As String
        Dim msg As String = ""
        Using cn As New SqlConnection(m_ConnStr)
            Try
                cn.Open()

                Using da As New SqlDataAdapter("SELECT * FROM Mas_BankCode" & pSQLWhere, cn)
                    Using cb As New SqlCommandBuilder(da)
                        Using dt As New DataTable
                            da.Fill(dt)
                            Dim dr As DataRow = dt.NewRow
                            If dt.Rows.Count > 0 Then dr = dt.Rows(0)
                            dr("Code") = Me.Code
                            dr("BName") = Me.BName
                            dr("CustomsCode") = Me.CustomsCode
                            If dr.RowState = DataRowState.Detached Then dt.Rows.Add(dr)
                            da.Update(dt)
                            Main.SaveLogFromObject(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBank", "SaveData", Me)
                            msg = "Save Complete"
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBank", "SaveData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
    Public Sub AddNew()

        m_Code = ""
        m_BName = ""
        m_CustomsCode = ""
    End Sub
    Public Function GetData(pSQLWhere As String) As List(Of CBank)
        Dim lst As New List(Of CBank)
        Using cn As New SqlConnection(m_ConnStr)
            Dim row As CBank
            Try
                cn.Open()
                Dim rd As SqlDataReader = New SqlCommand("SELECT * FROM Mas_BankCode" & pSQLWhere, cn).ExecuteReader()
                While rd.Read()
                    row = New CBank(m_ConnStr)
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("Code"))) = False Then
                        row.Code = rd.GetString(rd.GetOrdinal("Code")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("BName"))) = False Then
                        row.BName = rd.GetString(rd.GetOrdinal("BName")).ToString()
                    End If
                    If IsDBNull(rd.GetValue(rd.GetOrdinal("CustomsCode"))) = False Then
                        row.CustomsCode = rd.GetString(rd.GetOrdinal("CustomsCode")).ToString()
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

                Using cm As New SqlCommand("DELETE FROM Mas_BankCode" + pSQLWhere, cn)
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.ExecuteNonQuery()
                    Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBank", "DeleteData", cm.CommandText)
                End Using

                msg = "Delete Complete"
            Catch ex As Exception
                Main.SaveLog(My.MySettings.Default.LicenseTo.ToString, "JOBSHIPPING", "CBank", "DeleteData", ex.Message)
                msg = ex.Message
            End Try
        End Using
        Return msg
    End Function
End Class