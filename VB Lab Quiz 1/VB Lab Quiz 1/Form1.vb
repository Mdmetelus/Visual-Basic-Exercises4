Public Class frmTraficLight

    Private Sub txtRed_TextChanged(sender As Object, e As EventArgs) Handles txtRed.GotFocus

        txtRed.BackColor = Color.Red
        txtYellow.BackColor = Color.DarkGray
        txtGreen.BackColor = Color.DarkGray

    End Sub

    Private Sub txtYellow_TextChanged(sender As Object, e As EventArgs) Handles txtYellow.GotFocus
        txtRed.BackColor = Color.DarkGray
        txtYellow.BackColor = Color.Yellow
        txtGreen.BackColor = Color.DarkGray
    End Sub

    Private Sub txtGreen_TextChanged(sender As Object, e As EventArgs) Handles txtGreen.GotFocus
        txtRed.BackColor = Color.DarkGray
        txtYellow.BackColor = Color.DarkGray
        txtGreen.BackColor = Color.Green
    End Sub

    Private Sub txtRed_TextChanged_1(sender As Object, e As EventArgs) Handles txtRed.Leave
        txtRed.BackColor = Color.DarkGray

    End Sub

    Private Sub txtGreen_TextChanged_1(sender As Object, e As EventArgs) Handles txtGreen.Leave
        txtGreen.BackColor = Color.DarkGray

    End Sub

    Private Sub txtYellow_TextChanged_1(sender As Object, e As EventArgs) Handles txtYellow.Leave
        txtYellow.BackColor = Color.DarkGray

    End Sub
End Class
