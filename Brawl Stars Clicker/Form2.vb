Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ProgressBar1.Value += 1
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            NumericUpDown1.Value += 1
            MsgBox("You've Reached a new level!
Press OK to continue")
            ProgressBar1.Value = ProgressBar1.Minimum
        End If

    End Sub
    Private Sub FormClosing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
    End Sub
End Class