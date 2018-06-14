Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim balance As Double = 100
        lstResults.Items.Add(Math.Round(((((balance * 1.05) + 100) * 1.05 + 100) * 1.05)))
    End Sub
End Class
