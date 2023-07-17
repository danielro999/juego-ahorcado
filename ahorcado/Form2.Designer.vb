<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CBOcultReper = New System.Windows.Forms.CheckBox()
        Me.CBPenalidad = New System.Windows.Forms.CheckBox()
        Me.CLBNivelErradas = New System.Windows.Forms.CheckedListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBtituloIntentos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CBOcultReper
        '
        Me.CBOcultReper.AutoSize = True
        Me.CBOcultReper.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOcultReper.Location = New System.Drawing.Point(32, 211)
        Me.CBOcultReper.Name = "CBOcultReper"
        Me.CBOcultReper.Size = New System.Drawing.Size(340, 41)
        Me.CBOcultReper.TabIndex = 28
        Me.CBOcultReper.Text = "Ocultar letras usadas"
        Me.CBOcultReper.UseVisualStyleBackColor = True
        '
        'CBPenalidad
        '
        Me.CBPenalidad.AutoSize = True
        Me.CBPenalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPenalidad.Location = New System.Drawing.Point(32, 273)
        Me.CBPenalidad.Name = "CBPenalidad"
        Me.CBPenalidad.Size = New System.Drawing.Size(461, 41)
        Me.CBPenalidad.TabIndex = 27
        Me.CBPenalidad.Text = "Penalidad por letras repetidas"
        Me.CBPenalidad.UseVisualStyleBackColor = True
        '
        'CLBNivelErradas
        '
        Me.CLBNivelErradas.BackColor = System.Drawing.Color.CadetBlue
        Me.CLBNivelErradas.CheckOnClick = True
        Me.CLBNivelErradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLBNivelErradas.FormattingEnabled = True
        Me.CLBNivelErradas.Items.AddRange(New Object() {"7 ", "5 ", "3 "})
        Me.CLBNivelErradas.Location = New System.Drawing.Point(32, 84)
        Me.CLBNivelErradas.Name = "CLBNivelErradas"
        Me.CLBNivelErradas.Size = New System.Drawing.Size(60, 121)
        Me.CLBNivelErradas.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 78)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 50)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Dificultad"
        '
        'LBtituloIntentos
        '
        Me.LBtituloIntentos.AutoSize = True
        Me.LBtituloIntentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBtituloIntentos.Location = New System.Drawing.Point(98, 123)
        Me.LBtituloIntentos.Name = "LBtituloIntentos"
        Me.LBtituloIntentos.Size = New System.Drawing.Size(318, 42)
        Me.LBtituloIntentos.TabIndex = 31
        Me.LBtituloIntentos.Text = "Cantidad de vidas"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(495, 450)
        Me.Controls.Add(Me.LBtituloIntentos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CBOcultReper)
        Me.Controls.Add(Me.CBPenalidad)
        Me.Controls.Add(Me.CLBNivelErradas)
        Me.Name = "Form2"
        Me.Text = "Dificultad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBOcultReper As CheckBox
    Friend WithEvents CBPenalidad As CheckBox
    Friend WithEvents CLBNivelErradas As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LBtituloIntentos As Label
End Class
