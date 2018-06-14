Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim balance As Double = 100
        lstResults.Items.Add(Math.Round((balance * 1.05 ^ 10), 2))
    End Sub
End Class
