Imports System.Data.OleDb
Public Class frmGenCode
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.ConnectionStr
        TextBox2.Text = My.Settings.DefaultSQL
        cboDbType.SelectedIndex = 0
        CheckConnect()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckConnect() Then
            MessageBox.Show("Connected")
        End If
    End Sub
    Function CheckConnect() As Boolean
        Dim bConnect As Boolean = False
        Try
            Dim oConn As New OleDbConnection(TextBox1.Text)
            oConn.Open()
            bConnect = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        TextBox2.Enabled = bConnect
        Button1.Enabled = bConnect
        Return bConnect
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter(TextBox2.Text, TextBox1.Text)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            TextBox3.Text = ReadStructure(dt)
            If TextBox3.Text <> "" Then
                Clipboard.SetText(TextBox3.Text, TextDataFormat.UnicodeText)
                MessageBox.Show("Copy to Clipboard OK!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function ReadStructure(oTbl As DataTable) As String
        Dim strAll As String = ""
        Dim preFix As String = cboDbType.Text
        Dim strPrivate As String = ""
        Dim strProperty As String = ""
        Dim strReader As String = ""
        Dim strWriter As String = ""
        Dim strReset As String = ""
        Dim strSet As String = ""
        Dim strGet As String = ""
        Dim strHtml As String = ""
        Dim strJavaLoad As String = ""
        Dim strJavaSave As String = ""
        Dim strJavaClear As String = ""
        Dim idx As Integer = 0
        For Each dc As DataColumn In oTbl.Columns
            idx += 1
            strProperty = ""
            If strPrivate <> "" Then strPrivate &= vbCrLf
            If strReader <> "" Then strReader &= vbCrLf
            If strWriter <> "" Then strWriter &= vbCrLf
            Dim strType As String = Replace(dc.DataType.FullName, "System.", "")
            If dc.ColumnName.IndexOf("date", StringComparison.InvariantCultureIgnoreCase) = dc.ColumnName.Length - 4 And dc.ColumnName.Length > 4 Then
                strType = "Date"
            End If
            strHtml &= vbCrLf & vbTab & "<div class=""col-sm-1"">"
            strHtml &= vbCrLf & "" & dc.ColumnName & " :<br/><div style=""display:flex"">"
            Select Case strType
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

                    strReset &= vbCrLf & "m_" & dc.ColumnName & " =0"

                    strHtml &= "<input type=""number"" id=""txt" & dc.ColumnName & """ class=""form-control"" value=""0.00"">"

                    strJavaLoad &= vbCrLf & "$('#txt" & dc.ColumnName & "').val(dr." & dc.ColumnName & ");"
                    strJavaSave &= vbCrLf & dc.ColumnName & ":CNum($('#txt" & dc.ColumnName & "').val()),"
                    strJavaClear &= vbCrLf & "$('#txt" & dc.ColumnName & "').val('0.00');"

                    strWriter &= "dr(""" & dc.ColumnName & """)=me." & dc.ColumnName & ""
                Case "DateTime", "Date"
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

                    strReset &= vbCrLf & "m_" & dc.ColumnName & " =DateTime.Minvalue"

                    strHtml &= "<input type=""date"" id=""txt" & dc.ColumnName & """ class=""form-control"">"

                    strJavaLoad &= vbCrLf & "$('#txt" & dc.ColumnName & "').val(CDateEN(dr." & dc.ColumnName & "));"
                    strJavaSave &= vbCrLf & dc.ColumnName & ":CDateTH($('#txt" & dc.ColumnName & "').val()),"
                    strJavaClear &= vbCrLf & "$('#txt" & dc.ColumnName & "').val('');"
                    If dc.ColumnName.IndexOf("time", StringComparison.InvariantCultureIgnoreCase) < 0 Then
                        strWriter &= "dr(""" & dc.ColumnName & """)=Main.GetDBDate(me." & dc.ColumnName & ")"
                    Else
                        strWriter &= "dr(""" & dc.ColumnName & """)=Main.GetDBTime(me." & dc.ColumnName & ")"
                    End If
                Case "Integer"
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

                    strReset &= vbCrLf & "m_" & dc.ColumnName & " =0"

                    strHtml &= "<input type=""text"" id=""txt" & dc.ColumnName & """ class=""form-control"" value=""0"">"

                    strJavaLoad &= vbCrLf & "$('#txt" & dc.ColumnName & "').val(dr." & dc.ColumnName & ");"
                    strJavaSave &= vbCrLf & dc.ColumnName & ":$('#txt" & dc.ColumnName & "').val(),"
                    strJavaClear &= vbCrLf & "$('#txt" & dc.ColumnName & "').val('');"
                    strWriter &= "dr(""" & dc.ColumnName & """)=me." & dc.ColumnName & ""
                Case Else
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

                    strReset &= vbCrLf & "m_" & dc.ColumnName & " ="""""

                    strHtml &= "<input type=""text"" id=""txt" & dc.ColumnName & """ class=""form-control"">"

                    strJavaLoad &= vbCrLf & "$('#txt" & dc.ColumnName & "').val(dr." & dc.ColumnName & ");"
                    strJavaSave &= vbCrLf & dc.ColumnName & ":$('#txt" & dc.ColumnName & "').val(),"
                    strJavaClear &= vbCrLf & "$('#txt" & dc.ColumnName & "').val('');"

                    strWriter &= "dr(""" & dc.ColumnName & """)=me." & dc.ColumnName & ""
            End Select
            strHtml &= "</div></div>"
            strProperty &= vbCrLf & "End Property"
            strPrivate &= strProperty
            strGet &= vbCrLf & "Dim v" & dc.ColumnName & "=obj." & dc.ColumnName & ""
            strSet &= vbCrLf & "obj." & dc.ColumnName & "=v" & dc.ColumnName & ""
        Next

        If CheckBox4.Checked = True Then
            strAll &= "'-----Class Definition-----" & vbCrLf
            Select Case cboDbType.Text
                Case "OleDb"
                    strAll &= "Imports System.Data.OleDb" & vbCrLf
                Case "Oracle"
                    strAll &= "Imports Oracle.DataAccess.Client" & vbCrLf
                Case "Odbc"
                    strAll &= "Imports System.Data.Odbc" & vbCrLf
                Case "MySql"
                    strAll &= "Imports MySql.Data.MySqlClient" & vbCrLf
                Case Else
                    preFix = "Sql"
                    strAll &= "Imports System.Data.SqlClient" & vbCrLf
            End Select
            strAll &= "Public Class " & TextBox4.Text & " " & vbCrLf
            strAll &= "Private m_ConnStr as String" & vbCrLf
            strAll &= "Public Sub New()" & vbCrLf
            strAll &= "" & vbCrLf
            strAll &= "End sub" & vbCrLf
            strAll &= "Public Sub New(pConnStr as String)" & vbCrLf
            strAll &= "m_ConnStr=pConnStr" & vbCrLf
            strAll &= "End sub" & vbCrLf
            strAll &= "Public Sub SetConnect(pConnStr as String)" & vbCrLf
            strAll &= "m_ConnStr=pConnStr" & vbCrLf
            strAll &= "End sub" & vbCrLf
            strAll = strAll & vbCrLf & strPrivate
            strAll = strAll & vbCrLf & "Public Function SaveData(pSQLWhere as string) as String"
            strAll = strAll & vbCrLf & "dim msg as string="""""
            strAll = strAll & vbCrLf & "using cn as new " & preFix & "Connection(m_ConnStr)"
            strAll = strAll & vbCrLf & "try"
            strAll = strAll & vbCrLf & "cn.Open"
            strAll = strAll & vbCrLf & "using da as new " & preFix & "DataAdapter(""" & TextBox2.Text & """ & pSQLWhere,cn)"
            strAll = strAll & vbCrLf & "using cb as new " & preFix & "CommandBuilder(da)"
            strAll = strAll & vbCrLf & "using dt as new DataTable"
            strAll = strAll & vbCrLf & "da.fill(dt)"
            strAll = strAll & vbCrLf & "dim dr as DataRow=dt.NewRow"
            strAll = strAll & vbCrLf & "if dt.Rows.Count>0 then dr=dt.rows(0)"
            strAll = strAll & vbCrLf & strWriter
            strAll = strAll & vbCrLf & "if dr.RowState=DataRowState.Detached then dt.rows.add(dr)"
            strAll = strAll & vbCrLf & "da.update(dt)"
            strAll = strAll & vbCrLf & "msg=""Save Complete"""
            strAll = strAll & vbCrLf & "End Using"
            strAll = strAll & vbCrLf & "End Using"
            strAll = strAll & vbCrLf & "End Using"
            strAll = strAll & vbCrLf & "catch ex as Exception"
            strAll = strAll & vbCrLf & "msg=ex.Message"
            strAll = strAll & vbCrLf & "End try"
            strAll = strAll & vbCrLf & "End Using"
            strAll = strAll & vbCrLf & "Return msg"
            strAll = strAll & vbCrLf & "End Function"

            strAll = strAll & vbCrLf & "Public Sub AddNew"
            strAll = strAll & vbCrLf & strReset
            strAll = strAll & vbCrLf & "End Sub"

            strAll = strAll & vbCrLf & "Public Function GetData(pSQLWhere as string) as List(Of " & TextBox4.Text & " ) "
            strAll = strAll & vbCrLf & "Dim lst as new List(Of " & TextBox4.Text & " )"
            strAll = strAll & vbCrLf & "using cn as new " & preFix & "Connection(m_ConnStr)"
            strAll = strAll & vbCrLf & "Dim row as " & TextBox4.Text & " "
            strAll = strAll & vbCrLf & "try"
            strAll = strAll & vbCrLf & "cn.Open"
            strAll = strAll & vbCrLf & "Dim rd as " & preFix & "DataReader=new " & preFix & "Command(""" & TextBox2.Text & """ & pSQLWhere,cn).ExecuteReader()"
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

            strAll = strAll & vbCrLf & "Public Function DeleteData(pSQLWhere as string) as String "
            strAll = strAll & vbCrLf & "Dim msg As String ="""""
            strAll = strAll & vbCrLf & "using cn as new " & preFix & "Connection(m_ConnStr)"
            strAll = strAll & vbCrLf & "try"
            strAll = strAll & vbCrLf & "cn.Open"
            strAll = strAll & vbCrLf & "Using cm As New " & preFix & "Command(""DELETE " + TextBox2.Text.Substring(TextBox2.Text.IndexOf("FROM")) + """ + pSQLWhere, cn)"
            strAll = strAll & vbCrLf & "cm.CommandTimeOut= 0 "
            strAll = strAll & vbCrLf & "cm.CommandType=CommandType.Text"
            strAll = strAll & vbCrLf & "cm.ExecuteNonQuery"
            strAll = strAll & vbCrLf & "End Using"
            strAll = strAll & vbCrLf & "cn.close"
            strAll = strAll & vbCrLf & "msg =""Delete Complete"""
            strAll = strAll & vbCrLf & "catch ex as Exception"
            strAll = strAll & vbCrLf & "msg=ex.Message"
            strAll = strAll & vbCrLf & "End try"
            strAll = strAll & vbCrLf & "End Using"
            strAll = strAll & vbCrLf & "Return msg"
            strAll = strAll & vbCrLf & "End Function"
            strAll = strAll & vbCrLf & "End Class"
        End If
        If CheckBox5.Checked = True Then
            strAll = strAll & vbCrLf & "'-----Controller-----"
            strAll = strAll & vbCrLf & "Function " & TextBox4.Text.Substring(1) & "() as ActionResult"
            strAll = strAll & vbCrLf & "Return GetView(""" & TextBox4.Text.Substring(1) & """)"
            strAll = strAll & vbCrLf & "End Function"

            strAll = strAll & vbCrLf & "Function Get" & TextBox4.Text.Substring(1) & "() as ActionResult"
            strAll = strAll & vbCrLf & "Try"
            strAll = strAll & vbCrLf & "Dim tSqlw As String = "" WHERE " & TextBox6.Text & "<>'' ""
                If Not IsNothing(Request.QueryString(""Code"")) Then
                    tSqlw &= String.Format(""AND " & TextBox6.Text & " ='{0}'"", Request.QueryString(""Code"").ToString)
                end if
                Dim oData = New " & TextBox4.Text & "(" & TextBox5.Text & ").GetData(tSqlW)
                Dim json As String = JsonConvert.SerializeObject(oData)
                json = ""{""""" & TextBox4.Text.Substring(1).ToLower & """"":{""""data"""":"" & json & ""}}""
                Return Content(json, jsonContent)"
            strAll = strAll & vbCrLf & "Catch ex As Exception"
            strAll = strAll & vbCrLf & "Return Content(""[]"", jsonContent)"
            strAll = strAll & vbCrLf & "End Try"
            strAll = strAll & vbCrLf & "End Function"

            strAll = strAll & vbCrLf & "Function Set" & TextBox4.Text.Substring(1) & "(<FromBody()> data as " & TextBox4.Text & ") as ActionResult"
            strAll = strAll & vbCrLf & "Try
                If Not IsNothing(data) Then
                    If """" & data." & TextBox6.Text & " = """" Then
                        Return Content(""{""""result"""":{""""data"""":null,""""msg"""":""""Please Enter Data""""}}"", jsonContent)
                    End If
                    data.SetConnect(" & TextBox5.Text & ")
                    Dim msg = data.SaveData(String.Format("" WHERE " & TextBox6.Text & "='{0}' "", data." & TextBox6.Text & "))
                    Dim json = ""{""""result"""":{""""data"""":"""""" & data." & TextBox6.Text & " & """""",""""msg"""":"""""" & msg & """"""}}""
                    Return Content(json, jsonContent)
                Else
                    Dim json = ""{""""result"""":{""""data"""":null,""""msg"""":""""No Data To Save""""}}""
                    Return Content(json, jsonContent)
                End If
            Catch ex As Exception
                Dim json = ""{""""result"""":{""""data"""":null,""""msg"""":"""""" & ex.Message & """"""}}""
                Return Content(json, jsonContent)
            End Try"
            strAll = strAll & vbCrLf & "End Function"

            strAll = strAll & vbCrLf & "Function Del" & TextBox4.Text.Substring(1) & "() as ActionResult"
            strAll = strAll & vbCrLf & "Try
                Dim tSqlw As String = "" WHERE " & TextBox6.Text & "<>'' ""
                If Not IsNothing(Request.QueryString(""Code"")) Then
                    tSqlw &= String.Format(""AND " & TextBox6.Text & " Like '{0}'"", Request.QueryString(""Code"").ToString)
                Else
                    Return Content(""{""""" & TextBox4.Text.Substring(1).ToLower & """"":{""""result"""":""""Please Select Some Data"""",""""data"""":[]}}"", jsonContent)
                End If
                Dim oData As New " & TextBox4.Text & "(" & TextBox5.Text & ")
                Dim msg = oData.DeleteData(tSqlw)

                Dim json = ""{""""" & TextBox4.Text.Substring(1).ToLower & """"":{""""result"""":"""""" & msg & """""",""""data"""":["" & JsonConvert.SerializeObject(oData) & ""]}}""
                Return Content(json, jsonContent)
            Catch ex As Exception
                Return Content(""[]"", jsonContent)
            End Try"
            strAll = strAll & vbCrLf & "End Function"
        End If
        If CheckBox3.Checked = True Then
            strAll = strAll & vbCrLf & "'-----Examples Test Class-----"
            strAll = strAll & vbCrLf & "Sub ExampleTestClass"
            strAll = strAll & vbCrLf & "Dim cls = New " & TextBox4.Text & "(" & TextBox5.Text & ").GetData("" WHERE " & TextBox6.Text & " IS NOT NULL "")"
            strAll = strAll & vbCrLf & "Dim obj = IF(cls.Count>0,cls(0),new " & TextBox4.Text & ")"
            strAll = strAll & vbCrLf & strGet
            strAll = strAll & vbCrLf & strSet
            strAll = strAll & vbCrLf & "MessageBox.Show(obj.SaveData(String.Format("" WHERE " & TextBox6.Text & "='{0}' "",obj." & TextBox6.Text & ")))"
            strAll = strAll & vbCrLf & "End Sub"
        End If
        If CheckBox1.Checked = True Then
            strAll = strAll & vbCrLf & "<!-- HTML CONTROLS -->"
            strAll = strAll & vbCrLf & "<div id=""dvForm"" class=""row"">"
            strAll = strAll & vbCrLf & vbTab & strHtml
            strAll = strAll & vbCrLf & "</div>"
            strAll = strAll & vbCrLf & "<div id=""dvCommand"">"
            strAll = strAll & vbCrLf & "
            <a href=""#"" class=""btn btn-default w3-purple"" id=""btnAdd"" onclick=""ClearData()"">
                <i class=""fa fa-lg fa-file-o""></i>&nbsp;<b>New</b>
            </a>
            <a href=""#"" class=""btn btn-success"" id=""btnSave"" onclick=""SaveData()"">
                <i class=""fa fa-lg fa-save""></i>&nbsp;<b>Save</b>
            </a>
            <a href=""#"" class=""btn btn-danger"" id=""btnDelete"" onclick=""DeleteData()"">
                <i class=""fa fa-lg fa-trash""></i>&nbsp;<b>Delete</b>
            </a>
"
            strAll = strAll & vbCrLf & "</div>"
        End If
        If CheckBox2.Checked = True Then
            strAll = strAll & vbCrLf & "//-----JAVA FUNCTIONS for HTML Scripts-----"
            strAll = strAll & "
<script type=""text/javascript"">
    let path = '@Url.Content(""~"")';
    SetEvents();
    function CallBackQuery" & TextBox4.Text.Substring(1) & "(p, code, ev) {
        $.get(p + 'master/get" & TextBox4.Text.Substring(1).ToLower & "?Code=' + code).done(function (r) {
            let dr = r." & TextBox4.Text.Substring(1).ToLower & ".data;
            if (dr.length > 0) {
                ev(dr[0]);
            }
        });
    }
    function SetEvents(){
        $('#txt" & TextBox6.Text & "').keydown(function (event) {
            if (event.which == 13) {
                let code=$('#txt" & TextBox6.Text & "').val();
                ClearData();
                $('#txt" & TextBox6.Text & "').val(code);
                CallBackQuery" & TextBox4.Text.Substring(1) & "(path, code,ReadData);
            }
        });
    }
    //CRUD Functions used in HTML Java Scripts
    function DeleteData() {
        let code = $('#txt" & TextBox6.Text & "').val();
        let ask = confirm(""Do you need to Delete "" + code + ""?"");
        if (ask == false) return;
            $.get(path + 'master/del" & TextBox4.Text.Substring(1).ToLower & "?code=' + code, function (r) {
                ShowMessage(r." & TextBox4.Text.Substring(1).ToLower & ".result);
                ClearData();
            });
    }"
            strAll = strAll & vbCrLf & vbTab & "    function ReadData(dr){"
            strAll = strAll & vbCrLf & vbTab & vbTab & strJavaLoad
            strAll = strAll & vbCrLf & vbTab & "    }"
            strAll = strAll & vbCrLf & vbTab & "    function SaveData(){"
            strAll = strAll & vbCrLf & vbTab & vbTab & "        let obj={"
            strAll = strAll & vbCrLf & vbTab & vbTab & vbTab & strJavaSave
            strAll = strAll & vbCrLf & vbTab & "    };"
            strAll = strAll & "
        if (obj." & TextBox6.Text & " != """") {
            let ask = confirm(""Do you need to Save "" + obj." & TextBox6.Text & " + ""?"");
            if (ask == false) return;
            let jsonText = JSON.stringify({ data: obj });
            //ShowMessage(jsonText);
            $.ajax({
                url: ""@Url.Action(""Set" & TextBox4.Text.Substring(1) & """, ""Master"")"",
                type: ""POST"",
                contentType: ""application/json"",
                data: jsonText,
                success: function (response) {
                    if (response.result.data != null) {
                        $('#txt" & TextBox6.Text & "').val(response.result.data);
                        $('#txt" & TextBox6.Text & "').focus();
                    }
                    ShowMessage(response.result.msg);
                },
                error: function (e) {
                    ShowMessage(e);
                }
            });
        } else {
            ShowMessage('No data to save');
        }"
            strAll = strAll & vbCrLf & vbTab & "    }"
            strAll = strAll & vbCrLf & vbTab & "    function ClearData(){"
            strAll = strAll & vbCrLf & vbTab & vbTab & "        " & strJavaClear
            strAll = strAll & vbCrLf & vbTab & "    }"
            strAll = strAll & vbCrLf & "</script>"
        End If

        Return strAll
    End Function

    Private Sub HTMLDesignerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HTMLDesignerToolStripMenuItem.Click
        frmHTML.Show()
    End Sub
End Class
