<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraficLight
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
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.txtYellow = New System.Windows.Forms.TextBox()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtRed
        '
        Me.txtRed.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtRed.Location = New System.Drawing.Point(124, 54)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.ReadOnly = True
        Me.txtRed.Size = New System.Drawing.Size(37, 20)
        Me.txtRed.TabIndex = 2
        '
        'txtYellow
        '
        Me.txtYellow.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtYellow.Location = New System.Drawing.Point(124, 121)
        Me.txtYellow.Name = "txtYellow"
        Me.txtYellow.ReadOnly = True
        Me.txtYellow.Size = New System.Drawing.Size(37, 20)
        Me.txtYellow.TabIndex = 1
        '
        'txtGreen
        '
        Me.txtGreen.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtGreen.Location = New System.Drawing.Point(124, 178)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.ReadOnly = True
        Me.txtGreen.Size = New System.Drawing.Size(37, 20)
        Me.txtGreen.TabIndex = 0
        '
        'frmTraficLight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtGreen)
        Me.Controls.Add(Me.txtYellow)
        Me.Controls.Add(Me.txtRed)
        Me.Name = "frmTraficLight"
        Me.Text = "Trafic Light"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRed As System.Windows.Forms.TextBox
    Friend WithEvents txtYellow As System.Windows.Forms.TextBox
    Friend WithEvents txtGreen As System.Windows.Forms.TextBox

End Class
