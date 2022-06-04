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
        Me.btnPulsame = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVeces = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPulsame
        '
        Me.btnPulsame.Location = New System.Drawing.Point(30, 114)
        Me.btnPulsame.Name = "btnPulsame"
        Me.btnPulsame.Size = New System.Drawing.Size(144, 23)
        Me.btnPulsame.TabIndex = 0
        Me.btnPulsame.Text = "¡Pulsame!"
        Me.btnPulsame.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Veces pulsado: "
        '
        'txtVeces
        '
        Me.txtVeces.Location = New System.Drawing.Point(126, 68)
        Me.txtVeces.Name = "txtVeces"
        Me.txtVeces.ReadOnly = True
        Me.txtVeces.Size = New System.Drawing.Size(48, 20)
        Me.txtVeces.TabIndex = 2
        Me.txtVeces.Text = "0"
        Me.txtVeces.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 199)
        Me.Controls.Add(Me.txtVeces)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPulsame)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPulsame As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVeces As TextBox
End Class
