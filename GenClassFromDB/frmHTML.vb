Public Class frmHTML
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.Button = MouseButtons.Right Then
            mnuAction.Show(e.Location)
        End If
    End Sub

    Private Sub SetLabeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetLabeToolStripMenuItem.Click
        Dim msg As String = "C" & DataGridView1.CurrentCell.ColumnIndex & "R" & DataGridView1.CurrentCell.RowIndex
        Dim cellCount As Integer = 0
        If Not DataGridView1.AreAllCellsSelected(False) Then
            cellCount = DataGridView1.GetCellCount(DataGridViewElementStates.Selected)
        End If
        msg &= ":Selected Cell=" & cellCount
        MessageBox.Show(msg)
    End Sub

    Private Sub AddRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRowToolStripMenuItem.Click
        DataGridView1.Rows.Add()
    End Sub
End Class