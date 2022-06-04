<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salario
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbPro = New System.Windows.Forms.RadioButton()
        Me.rbTec = New System.Windows.Forms.RadioButton()
        Me.rbAdm = New System.Windows.Forms.RadioButton()
        Me.rbObrero = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb10años = New System.Windows.Forms.RadioButton()
        Me.rb5_10 = New System.Windows.Forms.RadioButton()
        Me.rb5años = New System.Windows.Forms.RadioButton()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nupHijos = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nupHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbPro)
        Me.GroupBox1.Controls.Add(Me.rbTec)
        Me.GroupBox1.Controls.Add(Me.rbAdm)
        Me.GroupBox1.Controls.Add(Me.rbObrero)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 194)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clase trabajador"
        '
        'rbPro
        '
        Me.rbPro.AutoSize = True
        Me.rbPro.Location = New System.Drawing.Point(42, 140)
        Me.rbPro.Name = "rbPro"
        Me.rbPro.Size = New System.Drawing.Size(77, 17)
        Me.rbPro.TabIndex = 5
        Me.rbPro.Text = "Profesional"
        Me.rbPro.UseVisualStyleBackColor = True
        '
        'rbTec
        '
        Me.rbTec.AutoSize = True
        Me.rbTec.Location = New System.Drawing.Point(42, 102)
        Me.rbTec.Name = "rbTec"
        Me.rbTec.Size = New System.Drawing.Size(64, 17)
        Me.rbTec.TabIndex = 6
        Me.rbTec.Text = "Técnico"
        Me.rbTec.UseVisualStyleBackColor = True
        '
        'rbAdm
        '
        Me.rbAdm.AutoSize = True
        Me.rbAdm.Location = New System.Drawing.Point(42, 67)
        Me.rbAdm.Name = "rbAdm"
        Me.rbAdm.Size = New System.Drawing.Size(90, 17)
        Me.rbAdm.TabIndex = 3
        Me.rbAdm.Text = "Administrativo"
        Me.rbAdm.UseVisualStyleBackColor = True
        '
        'rbObrero
        '
        Me.rbObrero.AutoSize = True
        Me.rbObrero.Checked = True
        Me.rbObrero.Location = New System.Drawing.Point(42, 29)
        Me.rbObrero.Name = "rbObrero"
        Me.rbObrero.Size = New System.Drawing.Size(57, 17)
        Me.rbObrero.TabIndex = 4
        Me.rbObrero.TabStop = True
        Me.rbObrero.Text = "Obrero"
        Me.rbObrero.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbNo)
        Me.GroupBox2.Controls.Add(Me.rbSi)
        Me.GroupBox2.Location = New System.Drawing.Point(254, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 193)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "¿Inscrito en un sindicato?"
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Checked = True
        Me.rbNo.Location = New System.Drawing.Point(27, 67)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(39, 17)
        Me.rbNo.TabIndex = 1
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.Location = New System.Drawing.Point(27, 29)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(34, 17)
        Me.rbSi.TabIndex = 0
        Me.rbSi.Text = "Si"
        Me.rbSi.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb10años)
        Me.GroupBox3.Controls.Add(Me.rb5_10)
        Me.GroupBox3.Controls.Add(Me.rb5años)
        Me.GroupBox3.Location = New System.Drawing.Point(477, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(166, 194)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Años de servicio"
        '
        'rb10años
        '
        Me.rb10años.AutoSize = True
        Me.rb10años.Location = New System.Drawing.Point(37, 102)
        Me.rb10años.Name = "rb10años"
        Me.rb10años.Size = New System.Drawing.Size(101, 17)
        Me.rb10años.TabIndex = 4
        Me.rb10años.Text = "Más de 10 años"
        Me.rb10años.UseVisualStyleBackColor = True
        '
        'rb5_10
        '
        Me.rb5_10.AutoSize = True
        Me.rb5_10.Location = New System.Drawing.Point(37, 67)
        Me.rb5_10.Name = "rb5_10"
        Me.rb5_10.Size = New System.Drawing.Size(108, 17)
        Me.rb5_10.TabIndex = 3
        Me.rb5_10.Text = "Entre 5 y 10 años"
        Me.rb5_10.UseVisualStyleBackColor = True
        '
        'rb5años
        '
        Me.rb5años.AutoSize = True
        Me.rb5años.Checked = True
        Me.rb5años.Location = New System.Drawing.Point(37, 29)
        Me.rb5años.Name = "rb5años"
        Me.rb5años.Size = New System.Drawing.Size(107, 17)
        Me.rb5años.TabIndex = 2
        Me.rb5años.TabStop = True
        Me.rb5años.Text = "Menos de 5 años"
        Me.rb5años.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(41, 356)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(137, 356)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(240, 356)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Numero de hijos: "
        '
        'nupHijos
        '
        Me.nupHijos.Location = New System.Drawing.Point(133, 292)
        Me.nupHijos.Name = "nupHijos"
        Me.nupHijos.Size = New System.Drawing.Size(127, 20)
        Me.nupHijos.TabIndex = 7
        '
        'Salario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 403)
        Me.Controls.Add(Me.nupHijos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Salario"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nupHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbAdm As RadioButton
    Friend WithEvents rbObrero As RadioButton
    Friend WithEvents rbPro As RadioButton
    Friend WithEvents rbTec As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbSi As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rb5años As RadioButton
    Friend WithEvents rb10años As RadioButton
    Friend WithEvents rb5_10 As RadioButton
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nupHijos As NumericUpDown
End Class
