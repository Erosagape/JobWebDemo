<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHTML
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuAction = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MergeSelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetLabeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetFieldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col1, Me.col2, Me.col3, Me.col4, Me.col5, Me.col6, Me.col7, Me.col8, Me.col9, Me.col10, Me.col11, Me.col12})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(750, 418)
        Me.DataGridView1.TabIndex = 1
        '
        'col1
        '
        Me.col1.HeaderText = "1"
        Me.col1.Name = "col1"
        '
        'col2
        '
        Me.col2.HeaderText = "2"
        Me.col2.Name = "col2"
        '
        'col3
        '
        Me.col3.HeaderText = "3"
        Me.col3.Name = "col3"
        '
        'col4
        '
        Me.col4.HeaderText = "4"
        Me.col4.Name = "col4"
        '
        'col5
        '
        Me.col5.HeaderText = "5"
        Me.col5.Name = "col5"
        '
        'col6
        '
        Me.col6.HeaderText = "6"
        Me.col6.Name = "col6"
        '
        'col7
        '
        Me.col7.HeaderText = "7"
        Me.col7.Name = "col7"
        '
        'col8
        '
        Me.col8.HeaderText = "8"
        Me.col8.Name = "col8"
        '
        'col9
        '
        Me.col9.HeaderText = "9"
        Me.col9.Name = "col9"
        '
        'col10
        '
        Me.col10.HeaderText = "10"
        Me.col10.Name = "col10"
        '
        'col11
        '
        Me.col11.HeaderText = "11"
        Me.col11.Name = "col11"
        '
        'col12
        '
        Me.col12.HeaderText = "12"
        Me.col12.Name = "col12"
        '
        'mnuAction
        '
        Me.mnuAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRowToolStripMenuItem, Me.MergeSelectToolStripMenuItem, Me.SetLabeToolStripMenuItem, Me.SetFieldToolStripMenuItem})
        Me.mnuAction.Name = "mnuAction"
        Me.mnuAction.Size = New System.Drawing.Size(181, 114)
        '
        'AddRowToolStripMenuItem
        '
        Me.AddRowToolStripMenuItem.Name = "AddRowToolStripMenuItem"
        Me.AddRowToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddRowToolStripMenuItem.Text = "Add Row"
        '
        'MergeSelectToolStripMenuItem
        '
        Me.MergeSelectToolStripMenuItem.Name = "MergeSelectToolStripMenuItem"
        Me.MergeSelectToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.MergeSelectToolStripMenuItem.Text = "Merge Select"
        '
        'SetLabeToolStripMenuItem
        '
        Me.SetLabeToolStripMenuItem.Name = "SetLabeToolStripMenuItem"
        Me.SetLabeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SetLabeToolStripMenuItem.Text = "Set Label"
        '
        'SetFieldToolStripMenuItem
        '
        Me.SetFieldToolStripMenuItem.Name = "SetFieldToolStripMenuItem"
        Me.SetFieldToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SetFieldToolStripMenuItem.Text = "Set Field"
        '
        'frmHTML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 418)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmHTML"
        Me.Text = "frmHTML"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuAction.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents col1 As DataGridViewTextBoxColumn
    Friend WithEvents col2 As DataGridViewTextBoxColumn
    Friend WithEvents col3 As DataGridViewTextBoxColumn
    Friend WithEvents col4 As DataGridViewTextBoxColumn
    Friend WithEvents col5 As DataGridViewTextBoxColumn
    Friend WithEvents col6 As DataGridViewTextBoxColumn
    Friend WithEvents col7 As DataGridViewTextBoxColumn
    Friend WithEvents col8 As DataGridViewTextBoxColumn
    Friend WithEvents col9 As DataGridViewTextBoxColumn
    Friend WithEvents col10 As DataGridViewTextBoxColumn
    Friend WithEvents col11 As DataGridViewTextBoxColumn
    Friend WithEvents col12 As DataGridViewTextBoxColumn
    Friend WithEvents mnuAction As ContextMenuStrip
    Friend WithEvents AddRowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MergeSelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetLabeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetFieldToolStripMenuItem As ToolStripMenuItem
End Class
