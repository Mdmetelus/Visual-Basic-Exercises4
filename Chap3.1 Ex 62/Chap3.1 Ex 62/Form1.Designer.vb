<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bbtnCompute = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'bbtnCompute
        '
        Me.bbtnCompute.Location = New System.Drawing.Point(56, 55)
        Me.bbtnCompute.Name = "bbtnCompute"
        Me.bbtnCompute.Size = New System.Drawing.Size(75, 23)
        Me.bbtnCompute.TabIndex = 0
        Me.bbtnCompute.Text = "Compute"
        Me.bbtnCompute.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(56, 159)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(120, 95)
        Me.lstResults.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.bbtnCompute)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bbtnCompute As System.Windows.Forms.Button
    Friend WithEvents lstResults As System.Windows.Forms.ListBox

End Class
