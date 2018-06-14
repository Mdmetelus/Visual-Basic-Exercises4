<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblBurgers = New System.Windows.Forms.Label()
        Me.chkBurgers = New System.Windows.Forms.CheckBox()
        Me.grpBurgers = New System.Windows.Forms.GroupBox()
        Me.radWBnCheese = New System.Windows.Forms.RadioButton()
        Me.radWBacon = New System.Windows.Forms.RadioButton()
        Me.radWCheese = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.lblFries = New System.Windows.Forms.Label()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.grpFries = New System.Windows.Forms.GroupBox()
        Me.radLargeF = New System.Windows.Forms.RadioButton()
        Me.radMediumF = New System.Windows.Forms.RadioButton()
        Me.radSmallF = New System.Windows.Forms.RadioButton()
        Me.RadSoda = New System.Windows.Forms.RadioButton()
        Me.lblDrinks = New System.Windows.Forms.Label()
        Me.grpDrinks = New System.Windows.Forms.GroupBox()
        Me.radWater = New System.Windows.Forms.RadioButton()
        Me.chkDrinks = New System.Windows.Forms.CheckBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.TextBox()
        Me.grpBurgers.SuspendLayout()
        Me.grpFries.SuspendLayout()
        Me.grpDrinks.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBurgers
        '
        Me.lblBurgers.AutoSize = True
        Me.lblBurgers.Location = New System.Drawing.Point(132, 9)
        Me.lblBurgers.Name = "lblBurgers"
        Me.lblBurgers.Size = New System.Drawing.Size(91, 13)
        Me.lblBurgers.TabIndex = 0
        Me.lblBurgers.Text = "Choice of Burgers"
        Me.lblBurgers.Visible = False
        '
        'chkBurgers
        '
        Me.chkBurgers.AutoSize = True
        Me.chkBurgers.Location = New System.Drawing.Point(13, 45)
        Me.chkBurgers.Name = "chkBurgers"
        Me.chkBurgers.Size = New System.Drawing.Size(62, 17)
        Me.chkBurgers.TabIndex = 1
        Me.chkBurgers.Text = "Burgers"
        Me.chkBurgers.UseVisualStyleBackColor = True
        '
        'grpBurgers
        '
        Me.grpBurgers.Controls.Add(Me.radWBnCheese)
        Me.grpBurgers.Controls.Add(Me.radWBacon)
        Me.grpBurgers.Controls.Add(Me.radWCheese)
        Me.grpBurgers.Controls.Add(Me.radRegular)
        Me.grpBurgers.Location = New System.Drawing.Point(120, 25)
        Me.grpBurgers.Name = "grpBurgers"
        Me.grpBurgers.Size = New System.Drawing.Size(200, 116)
        Me.grpBurgers.TabIndex = 2
        Me.grpBurgers.TabStop = False
        Me.grpBurgers.Visible = False
        '
        'radWBnCheese
        '
        Me.radWBnCheese.AutoSize = True
        Me.radWBnCheese.Location = New System.Drawing.Point(6, 92)
        Me.radWBnCheese.Name = "radWBnCheese"
        Me.radWBnCheese.Size = New System.Drawing.Size(165, 17)
        Me.radWBnCheese.TabIndex = 3
        Me.radWBnCheese.TabStop = True
        Me.radWBnCheese.Text = "W/ Bacon and Cheese (5.39)"
        Me.radWBnCheese.UseVisualStyleBackColor = True
        '
        'radWBacon
        '
        Me.radWBacon.AutoSize = True
        Me.radWBacon.Location = New System.Drawing.Point(7, 68)
        Me.radWBacon.Name = "radWBacon"
        Me.radWBacon.Size = New System.Drawing.Size(102, 17)
        Me.radWBacon.TabIndex = 2
        Me.radWBacon.TabStop = True
        Me.radWBacon.Text = "W/Bacon (4.79)"
        Me.radWBacon.UseVisualStyleBackColor = True
        '
        'radWCheese
        '
        Me.radWCheese.AutoSize = True
        Me.radWCheese.Location = New System.Drawing.Point(7, 44)
        Me.radWCheese.Name = "radWCheese"
        Me.radWCheese.Size = New System.Drawing.Size(107, 17)
        Me.radWCheese.TabIndex = 1
        Me.radWCheese.TabStop = True
        Me.radWCheese.Text = "W/Cheese (4.79)"
        Me.radWCheese.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(7, 20)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(92, 17)
        Me.radRegular.TabIndex = 0
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular (4.19)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'lblFries
        '
        Me.lblFries.AutoSize = True
        Me.lblFries.Location = New System.Drawing.Point(128, 144)
        Me.lblFries.Name = "lblFries"
        Me.lblFries.Size = New System.Drawing.Size(79, 13)
        Me.lblFries.TabIndex = 3
        Me.lblFries.Text = "Choice Of Fries"
        Me.lblFries.Visible = False
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(13, 187)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(48, 17)
        Me.chkFries.TabIndex = 4
        Me.chkFries.Text = "Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'grpFries
        '
        Me.grpFries.Controls.Add(Me.radLargeF)
        Me.grpFries.Controls.Add(Me.radMediumF)
        Me.grpFries.Controls.Add(Me.radSmallF)
        Me.grpFries.Location = New System.Drawing.Point(120, 167)
        Me.grpFries.Name = "grpFries"
        Me.grpFries.Size = New System.Drawing.Size(200, 97)
        Me.grpFries.TabIndex = 5
        Me.grpFries.TabStop = False
        Me.grpFries.Visible = False
        '
        'radLargeF
        '
        Me.radLargeF.AutoSize = True
        Me.radLargeF.Location = New System.Drawing.Point(7, 67)
        Me.radLargeF.Name = "radLargeF"
        Me.radLargeF.Size = New System.Drawing.Size(82, 17)
        Me.radLargeF.TabIndex = 2
        Me.radLargeF.TabStop = True
        Me.radLargeF.Text = "Large (4.99)"
        Me.radLargeF.UseVisualStyleBackColor = True
        '
        'radMediumF
        '
        Me.radMediumF.AutoSize = True
        Me.radMediumF.Location = New System.Drawing.Point(7, 44)
        Me.radMediumF.Name = "radMediumF"
        Me.radMediumF.Size = New System.Drawing.Size(92, 17)
        Me.radMediumF.TabIndex = 1
        Me.radMediumF.TabStop = True
        Me.radMediumF.Text = "Medium (3.09)"
        Me.radMediumF.UseVisualStyleBackColor = True
        '
        'radSmallF
        '
        Me.radSmallF.AutoSize = True
        Me.radSmallF.Location = New System.Drawing.Point(7, 20)
        Me.radSmallF.Name = "radSmallF"
        Me.radSmallF.Size = New System.Drawing.Size(80, 17)
        Me.radSmallF.TabIndex = 0
        Me.radSmallF.TabStop = True
        Me.radSmallF.Text = "Small (2.39)"
        Me.radSmallF.UseVisualStyleBackColor = True
        '
        'RadSoda
        '
        Me.RadSoda.AutoSize = True
        Me.RadSoda.Location = New System.Drawing.Point(12, 19)
        Me.RadSoda.Name = "RadSoda"
        Me.RadSoda.Size = New System.Drawing.Size(80, 17)
        Me.RadSoda.TabIndex = 3
        Me.RadSoda.TabStop = True
        Me.RadSoda.Text = "Soda (1.69)"
        Me.RadSoda.UseVisualStyleBackColor = True
        '
        'lblDrinks
        '
        Me.lblDrinks.AutoSize = True
        Me.lblDrinks.Location = New System.Drawing.Point(129, 267)
        Me.lblDrinks.Name = "lblDrinks"
        Me.lblDrinks.Size = New System.Drawing.Size(74, 13)
        Me.lblDrinks.TabIndex = 6
        Me.lblDrinks.Text = "Coice of Drink"
        Me.lblDrinks.Visible = False
        '
        'grpDrinks
        '
        Me.grpDrinks.Controls.Add(Me.RadSoda)
        Me.grpDrinks.Controls.Add(Me.radWater)
        Me.grpDrinks.Location = New System.Drawing.Point(120, 286)
        Me.grpDrinks.Name = "grpDrinks"
        Me.grpDrinks.Size = New System.Drawing.Size(200, 74)
        Me.grpDrinks.TabIndex = 7
        Me.grpDrinks.TabStop = False
        Me.grpDrinks.Visible = False
        '
        'radWater
        '
        Me.radWater.AutoSize = True
        Me.radWater.Location = New System.Drawing.Point(12, 44)
        Me.radWater.Name = "radWater"
        Me.radWater.Size = New System.Drawing.Size(114, 17)
        Me.radWater.TabIndex = 0
        Me.radWater.TabStop = True
        Me.radWater.Text = "Bottle Water (1.49)"
        Me.radWater.UseVisualStyleBackColor = True
        '
        'chkDrinks
        '
        Me.chkDrinks.AutoSize = True
        Me.chkDrinks.Location = New System.Drawing.Point(13, 301)
        Me.chkDrinks.Name = "chkDrinks"
        Me.chkDrinks.Size = New System.Drawing.Size(56, 17)
        Me.chkDrinks.TabIndex = 8
        Me.chkDrinks.Text = "Drinks"
        Me.chkDrinks.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(484, 167)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(116, 67)
        Me.btnCompute.TabIndex = 9
        Me.btnCompute.Text = "Compute The Cost of Your Meal"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Cost Of Meal:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(484, 286)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 44)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close Program"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.Location = New System.Drawing.Point(420, 251)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.ReadOnly = True
        Me.lstDisplay.Size = New System.Drawing.Size(180, 20)
        Me.lstDisplay.TabIndex = 11
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 395)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblBurgers)
        Me.Controls.Add(Me.chkDrinks)
        Me.Controls.Add(Me.grpDrinks)
        Me.Controls.Add(Me.lblDrinks)
        Me.Controls.Add(Me.grpFries)
        Me.Controls.Add(Me.chkFries)
        Me.Controls.Add(Me.lblFries)
        Me.Controls.Add(Me.grpBurgers)
        Me.Controls.Add(Me.chkBurgers)
        Me.Name = "frmMenu"
        Me.Text = "Order Menu"
        Me.grpBurgers.ResumeLayout(False)
        Me.grpBurgers.PerformLayout()
        Me.grpFries.ResumeLayout(False)
        Me.grpFries.PerformLayout()
        Me.grpDrinks.ResumeLayout(False)
        Me.grpDrinks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBurgers As System.Windows.Forms.Label
    Friend WithEvents chkBurgers As System.Windows.Forms.CheckBox
    Friend WithEvents grpBurgers As System.Windows.Forms.GroupBox
    Friend WithEvents radWBnCheese As System.Windows.Forms.RadioButton
    Friend WithEvents radWBacon As System.Windows.Forms.RadioButton
    Friend WithEvents radWCheese As System.Windows.Forms.RadioButton
    Friend WithEvents radRegular As System.Windows.Forms.RadioButton
    Friend WithEvents lblFries As System.Windows.Forms.Label
    Friend WithEvents chkFries As System.Windows.Forms.CheckBox
    Friend WithEvents grpFries As System.Windows.Forms.GroupBox
    Friend WithEvents RadSoda As System.Windows.Forms.RadioButton
    Friend WithEvents radLargeF As System.Windows.Forms.RadioButton
    Friend WithEvents radMediumF As System.Windows.Forms.RadioButton
    Friend WithEvents radSmallF As System.Windows.Forms.RadioButton
    Friend WithEvents lblDrinks As System.Windows.Forms.Label
    Friend WithEvents grpDrinks As System.Windows.Forms.GroupBox
    Friend WithEvents radWater As System.Windows.Forms.RadioButton
    Friend WithEvents chkDrinks As System.Windows.Forms.CheckBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lstDisplay As System.Windows.Forms.TextBox

End Class
