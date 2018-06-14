Public Class frmMenu

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Create close program button with a Kind message.
        MessageBox.Show("Thank You For Ordering, We Appreciate Your Patronage.")
        MessageBox.Show("Have a Nice Day!")
        Close()
    End Sub

    Private Sub chkBurgers_CheckedChanged(sender As Object, e As EventArgs) Handles chkBurgers.CheckedChanged
        'Create visibility for burgers section
        If chkBurgers.Checked Then
            grpBurgers.Visible = True
            lblBurgers.Visible = True
        End If

    End Sub

    
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radSmallF_CheckedChanged(sender As Object, e As EventArgs) Handles radSmallF.CheckedChanged

    End Sub

    Private Sub radRegular_CheckedChanged(sender As Object, e As EventArgs) Handles radRegular.CheckedChanged

    End Sub

    Private Sub grpBurgers_Enter(sender As Object, e As EventArgs) Handles grpBurgers.Enter
    End Sub

    Private Sub grpFries_Enter(sender As Object, e As EventArgs) Handles grpFries.Enter
        
    End Sub

    Private Sub grpDrinks_Enter(sender As Object, e As EventArgs) Handles grpDrinks.Enter
    End Sub



    Private Sub lstDisplay_TextChanged(sender As Object, e As EventArgs) Handles lstDisplay.TextChanged
       
    End Sub

    Private Sub chkFries_CheckedChanged(sender As Object, e As EventArgs) Handles chkFries.CheckedChanged
        'Create visibility for fries section
        If chkFries.Checked Then
            grpFries.Visible = True
            lblFries.Visible = True
        End If
        'If chkFries.Unchecked Then
        'excess unused code
    End Sub

    Private Sub chkDrinks_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrinks.CheckedChanged
        'Create visibility for drinks section
        If chkDrinks.Checked Then
            grpDrinks.Visible = True
            lblDrinks.Visible = True
        End If
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Sandwich, Fries, Drink, orderTotal As Double
        'Declare names for variables of types of items to order.
        If (radRegular.Checked) Then
            Sandwich += 4.19
        ElseIf (radWCheese.Checked) Then
            Sandwich += 4.79
        ElseIf (radWBacon.Checked) Then
            Sandwich += 4.79
        ElseIf (radWBnCheese.Checked) Then
            Sandwich += 5.39
        Else
            Sandwich = 0
        End If
        'Conditional statments for chioce of radio button item selected and cost

        If (radSmallF.Checked) Then
            Fries = 2.39
        ElseIf (radMediumF.Checked) Then
            Fries = 3.09
        ElseIf (radLargeF.Checked) Then
            Fries = 4.99
        Else
            Fries = 0
        End If
        'Conditional statments for chioce of radio button item selected and cost.

        If (RadSoda.Checked) Then
            Drink = 1.69
        ElseIf (radWater.Checked) Then
            Drink = 1.49
        Else
            Drink = 0
        End If
        'Conditional statments for chioce of radio button item selected and cost.


        orderTotal = Sandwich + Fries + Drink
        'function for the output of the 3 iff statments
        lstDisplay.Text = " Your Total Is $ " & orderTotal
        'Displaying the function total as a Satament with Amount Total.

        'orderTotal = VarType()
        'excess unused code
    End Sub
End Class
