Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim balance As Double = 100 
        ' there should be a way to loop this three times
        lstResults.Items.Add(Math.Round((((balance * 1.05) * 1.05) * 1.05), 2))


    End Sub
End Class
