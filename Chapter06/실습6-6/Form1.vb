Public Class frmMain
    Private Sub rchNotes_TextChanged() _
           Handles rchNotes.TextChanged
        btnUndo.Enabled = rchNotes.CanUndo
        btnRedo.Enabled = rchNotes.CanRedo

        If btnUndo.Enabled Then
            btnUndo.Text = "Undo " _
                & rchNotes.UndoActionName
        Else
            btnUndo.Text = "Undo"
        End If

        If btnRedo.Enabled Then
            If btnRedo.Enabled Then btnRedo.Text = "Redo " _
                & rchNotes.RedoActionName
        Else
            If btnRedo.Enabled Then btnRedo.Text = "Redo"
        End If
    End Sub

    Private Sub btnUndo_Click() Handles btnUndo.Click
        rchNotes.Undo()
    End Sub

    Private Sub btnRedo_Click() Handles btnRedo.Click
        rchNotes.Redo()
    End Sub

    Private Sub btnRed_Click() Handles btnRed.Click
        rchNotes.SelectionColor = Color.Red
    End Sub

    Private Sub btnBlue_Click() Handles btnBlue.Click
        rchNotes.SelectionColor = Color.Blue
    End Sub

End Class