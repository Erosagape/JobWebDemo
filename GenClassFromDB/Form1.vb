Imports System.Data.OleDb
Imports System.Data
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.ConnectionStr
        TextBox2.Text = My.Settings.DefaultSQL
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bConnect As Boolean
        Try
            Dim oConn As New OleDbConnection(TextBox1.Text)
            oConn.Open()
            bConnect = True
            MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        TextBox2.Enabled = bConnect
        Button1.Enabled = bConnect
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter(TextBox2.Text, TextBox1.Text)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            TextBox3.Text = ReadStructure(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function ReadStructure(oTbl As DataTable) As String
        Dim strAll As String = ""
        strAll &= "Imports System.Data" & vbCrLf
        strAll &= "Imports System.Data.SqlClient" & vbCrLf
        strAll &= "Public Class " & TextBox4.Text & " " & vbCrLf
        strAll &= "Private m_ConnStr as String" & vbCrLf
        strAll &= "Public Sub New(pConnStr as String)" & vbCrLf
        strAll &= "m_ConnStr=pConnStr" & vbCrLf
        strAll &= "End sub" & vbCrLf
        Dim strPrivate As String = ""
        Dim strProperty As String = ""
        Dim strReader As String = ""
        Dim strWriter As String = ""
        For Each dc As DataColumn In oTbl.Columns
            strProperty = ""
            If strPrivate <> "" Then strPrivate &= vbCrLf
            If strReader <> "" Then strReader &= vbCrLf
            If strWriter <> "" Then strWriter &= vbCrLf
            Select Case Replace(dc.DataType.FullName, "System.", "")
                Case "String"
                    strReader &= "if IsDbNull(rd.GetValue(rd.GetOrdinal(""" & dc.ColumnName & """)))=False then " & vbCrLf
                    strReader &= "row." & dc.ColumnName & " =rd.GetString(rd.GetOrdinal(""" & dc.ColumnName & """)).ToString()" & vbCrLf
                    strReader &= "End if"
                    strPrivate &= "Private m_" & dc.ColumnName & " as String"
                    strProperty &= vbCrLf & "Public Property " & dc.ColumnName & " as String"
                    strProperty &= vbCrLf & "Get"
                    strProperty &= vbCrLf & "Return m_" & dc.ColumnName
                    strProperty &= vbCrLf & "End Get"
                    strProperty &= vbCrLf & "Set (value as String)"
                    strProperty &= vbCrLf & "m_" & dc.ColumnName & " =value"
                    strProperty &= vbCrLf & "End Set"
                Case "Double"
                    strPrivate &= "Private m_" & dc.ColumnName & " as Double"
                    strReader &= "if IsDbNull(rd.GetValue(rd.GetOrdinal(""" & dc.ColumnName & """)))=False then " & vbCrLf
                    strReader &= "row." & dc.ColumnName & " =rd.GetDouble(rd.GetOrdinal(""" & dc.ColumnName & """))" & vbCrLf
                    strReader &= "End if"
                    strProperty &= vbCrLf & "Public Property " & dc.ColumnName & " as Double"
                    strProperty &= vbCrLf & "Get"
                    strProperty &= vbCrLf & "Return m_" & dc.ColumnName
                    strProperty &= vbCrLf & "End Get"
                    strProperty &= vbCrLf & "Set (value as Double)"
                    strProperty &= vbCrLf & "m_" & dc.ColumnName & " =value"
                    strProperty &= vbCrLf & "End Set"
                Case "DateTime"
                    strPrivate &= "Private m_" & dc.ColumnName & " as Date"
                    strReader &= "if IsDbNull(rd.GetValue(rd.GetOrdinal(""" & dc.ColumnName & """)))=False then " & vbCrLf
                    strReader &= "row." & dc.ColumnName & " =rd.GetValue(rd.GetOrdinal(""" & dc.ColumnName & """))" & vbCrLf
                    strReader &= "End if"
                    strProperty &= vbCrLf & "Public Property " & dc.ColumnName & " as Date"
                    strProperty &= vbCrLf & "Get"
                    strProperty &= vbCrLf & "Return m_" & dc.ColumnName
                    strProperty &= vbCrLf & "End Get"
                    strProperty &= vbCrLf & "Set (value as Date)"
                    strProperty &= vbCrLf & "m_" & dc.ColumnName & " =value"
                    strProperty &= vbCrLf & "End Set"
                Case Else
                    strPrivate &= "Private m_" & dc.ColumnName & " as Integer"
                    strReader &= "if IsDbNull(rd.GetValue(rd.GetOrdinal(""" & dc.ColumnName & """)))=False then " & vbCrLf
                    strReader &= "row." & dc.ColumnName & " =rd.Get" & Replace(dc.DataType.FullName, "System.", "") & "(rd.GetOrdinal(""" & dc.ColumnName & """))" & vbCrLf
                    strReader &= "End if"
                    strProperty &= vbCrLf & "Public Property " & dc.ColumnName & " as Integer"
                    strProperty &= vbCrLf & "Get"
                    strProperty &= vbCrLf & "Return m_" & dc.ColumnName
                    strProperty &= vbCrLf & "End Get"
                    strProperty &= vbCrLf & "Set (value as Integer)"
                    strProperty &= vbCrLf & "m_" & dc.ColumnName & " =value"
                    strProperty &= vbCrLf & "End Set"
            End Select
            strWriter &= "dr(""" & dc.ColumnName & """)=me." & dc.ColumnName & ""
            strProperty &= vbCrLf & "End Property"
            strPrivate &= strProperty
        Next
        strAll = strAll & vbCrLf & strPrivate
        strAll = strAll & vbCrLf & "Public Function SaveData(pSQLWhere as string) as Boolean"
        strAll = strAll & vbCrLf & "dim bComplete as boolean=false"
        strAll = strAll & vbCrLf & "using cn as new SqlConnection(m_ConnStr)"
        strAll = strAll & vbCrLf & "try"
        strAll = strAll & vbCrLf & "cn.Open"
        strAll = strAll & vbCrLf & "using da as new SqlDataAdapter(""" & TextBox2.Text & """ & pSQLWhere,cn)"
        strAll = strAll & vbCrLf & "using cb as new SqlCommandBuilder(da)"
        strAll = strAll & vbCrLf & "using dt as new DataTable"
        strAll = strAll & vbCrLf & "da.fill(dt)"
        strAll = strAll & vbCrLf & "dim dr as DataRow=dt.NewRow"
        strAll = strAll & vbCrLf & "if dt.Rows.Count>0 then dr=dt.rows(0)"
        strAll = strAll & vbCrLf & strWriter
        strAll = strAll & vbCrLf & "if dr.RowState=DataRowState.Detached then dt.rows.add(dr)"
        strAll = strAll & vbCrLf & "da.update(dt)"
        strAll = strAll & vbCrLf & "bComplete=True"
        strAll = strAll & vbCrLf & "End Using"
        strAll = strAll & vbCrLf & "End Using"
        strAll = strAll & vbCrLf & "End Using"
        strAll = strAll & vbCrLf & "catch ex as Exception"
        strAll = strAll & vbCrLf & "End try"
        strAll = strAll & vbCrLf & "End Using"
        strAll = strAll & vbCrLf & "Return bComplete"
        strAll = strAll & vbCrLf & "End Function"


        strAll = strAll & vbCrLf & "Public Function GetData(pSQLWhere as string) as List(Of " & TextBox4.Text & " ) "
        strAll = strAll & vbCrLf & "Dim lst as new List(Of " & TextBox4.Text & " )"
        strAll = strAll & vbCrLf & "using cn as new SqlConnection(m_ConnStr)"
        strAll = strAll & vbCrLf & "Dim row as " & TextBox4.Text & " "
        strAll = strAll & vbCrLf & "try"
        strAll = strAll & vbCrLf & "cn.Open"
        strAll = strAll & vbCrLf & "Dim rd as SqlDataReader=new SqlCommand(""" & TextBox2.Text & """ & pSQLWhere,cn).ExecuteReader()"
        strAll = strAll & vbCrLf & "while rd.Read()"
        strAll = strAll & vbCrLf & "row=New " & TextBox4.Text & " (m_ConnStr)"
        strAll = strAll & vbCrLf & strReader
        strAll = strAll & vbCrLf & "lst.Add(row)"
        strAll = strAll & vbCrLf & "End While"
        strAll = strAll & vbCrLf & "catch ex as Exception"
        strAll = strAll & vbCrLf & "End try"
        strAll = strAll & vbCrLf & "End Using"
        strAll = strAll & vbCrLf & "Return lst"
        strAll = strAll & vbCrLf & "End Function"
        Return strAll & vbCrLf & "End Class"
    End Function
End Class
