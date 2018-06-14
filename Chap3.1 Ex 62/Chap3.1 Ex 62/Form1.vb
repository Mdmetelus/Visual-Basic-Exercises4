Public Class Form1

    Private Sub bbtnCompute_Click(sender As Object, e As EventArgs) Handles bbtnCompute.Click
        Dim fixedCosts, pricePerUnit, costPerUnit, breakEvenPoint As Double
        fixedCosts = 5000
        pricePerUnit = 8
        costPerUnit = 6
        breakEvenPoint = (fixedCosts / (pricePerUnit - costPerUnit))
        lstResults.Items.Clear()
        lstResults.Items.Add(breakEvenPoint)
    End Sub
End Class
