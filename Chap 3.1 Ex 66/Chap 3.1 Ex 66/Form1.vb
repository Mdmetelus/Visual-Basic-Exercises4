Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim purchasePrice, sellingPrice, percentProfit, haha As Double
        purchasePrice = 10
        sellingPrice = 15
        haha = ((sellingPrice - purchasePrice) / purchasePrice)
        percentProfit = (100 * haha)
        lstResults.Items.Add(percentProfit)
    End Sub
End Class
